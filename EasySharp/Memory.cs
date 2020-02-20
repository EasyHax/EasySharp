using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace SharpSkin_dll
{
    public static unsafe class Memory
    {
        public static IntPtr VirtualAddress(this IntPtr addr, int index) => *(IntPtr*)(*(IntPtr*)(addr) + index * 4);
        public static IntPtr FunctionToPointer<T>(T func) where T : class => Marshal.GetFunctionPointerForDelegate<T>(func);

        public static IntPtr PatternScan(IntPtr addr, int length, string signature)
        {

            var split = signature.Split(' ');
            var lPattern = new List<int>();

            foreach (var s in split)
            {
                if (s.Contains("?"))
                {
                    lPattern.Add(-1);
                    continue;
                }
                lPattern.Add(Convert.ToInt32(s, 16));
            }

            var pattern = lPattern.ToArray();

            for (var i = addr.ToInt32(); i < addr.ToInt32() + length; i++)
            {
                var b = *(byte*)i;
                if (b == pattern[0])
                    for (int j = 0; j < pattern.Length; j++)
                    {
                        b = *(byte*)(i + j);
                        if (b == pattern[j] || pattern[j] == -1)
                        {
                            if (j == pattern.Length - 1)
                            {
                                return (IntPtr)i;
                            }
                        }
                        else
                            break;
                    }
            }

            return IntPtr.Zero;
        }
    }

    public static class GenericInterop
    {
        public static Type t_IntPtr = typeof(IntPtr);
        public static Type t_Int32  = typeof(int   );
        public static Type t_Int64  = typeof(long  );
        public static Type t_Byte   = typeof(byte  );
        public static Type t_Uint   = typeof(uint  );
        public static Type t_Vector = typeof(Vector);
        public static Type t_Bool   = typeof(bool  );
        public static Type t_Float  = typeof(float );
        public static Type t_String = typeof(string);
        public static Type t_Ushort = typeof(ushort);
        public static Type t_Void   = null;

        public static T call<T>(this IntPtr addr, params object[] args)
        {
            var tArgs = new Type[args.Length];
            for (var i = 0; i < args.Length; i++)
                tArgs[i] = args[i].GetType();

            var @type = CreateDelegate(typeof(T), tArgs);
            var @delegate = Marshal.GetDelegateForFunctionPointer(addr, @type);
            return (T)@delegate.DynamicInvoke(args);
        }

        public static Delegate deleg(this IntPtr addr, Type type) => Marshal.GetDelegateForFunctionPointer(addr, type);

        public static Delegate WrapVFunc(this IntPtr addr, int index, Type return_Type, params Type[] args)
            => addr.VirtualAddress(index).deleg(CreateDelegate(return_Type, args));

        public static Type CreateDelegate(Type returntype, params Type[] args)
        {
            var temp              = args.ToList(); temp.Insert(0, typeof(IntPtr));
            var paramtypes        = temp.ToArray();
            var myCurrentDomain   = AppDomain.CurrentDomain;
            var myAssemblyName    = new AssemblyName() { Name = "TempAssembly" };
            var myAssemblyBuilder = myCurrentDomain.DefineDynamicAssembly(myAssemblyName, AssemblyBuilderAccess.Run);
            var dynamicMod        = myAssemblyBuilder.DefineDynamicModule("TempModule");
            var tb                = dynamicMod.DefineType("delegate-maker" + Guid.NewGuid(), TypeAttributes.Public | TypeAttributes.Sealed, typeof(MulticastDelegate));

            tb.DefineConstructor(MethodAttributes.RTSpecialName | MethodAttributes.SpecialName | MethodAttributes.Public | MethodAttributes.HideBySig, CallingConventions.Standard,
                 new Type[] { typeof(object), typeof(IntPtr) }).SetImplementationFlags(MethodImplAttributes.Runtime);
            tb.DefineMethod("Invoke", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.NewSlot | MethodAttributes.HideBySig, CallingConventions.Standard, returntype, null,
                             new Type[] { typeof(System.Runtime.CompilerServices.CallConvThiscall) }, paramtypes, null, null).SetImplementationFlags(MethodImplAttributes.Runtime);
            return tb.CreateType();
        }
    }
}
