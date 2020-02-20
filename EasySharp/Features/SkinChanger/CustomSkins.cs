using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    unsafe class CustomSkins
    {
        public static IntPtr Constructor_addr;
        public static IntPtr InitKey_addr;
        public static IntPtr LoadFromBuffer_addr;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void d_InitKeyValues(IntPtr pKeyValues, string name);
        public static d_InitKeyValues init;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void d_LoadFromBuffer(IntPtr pKeyValues, string resourceName, string buffer);
        public static d_LoadFromBuffer load;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr New(IntPtr ptr);

        public static void Init2()
        {
            var mSize = 0;
            var mAddr = IntPtr.Zero;

            foreach (ProcessModule m in Process.GetCurrentProcess().Modules)
                if (m.ModuleName == "vstdlib.dll")
                {
                    mSize = m.ModuleMemorySize;
                    mAddr = m.BaseAddress;
                }
            var addr = WinApi.GetProcAddress(mAddr, "KeyValuesSystem");
            Console.WriteLine(addr);

            var ctr = Marshal.GetDelegateForFunctionPointer<New>(addr);
            var key = ctr(addr);
            var key2 = ctr(addr);
            Console.WriteLine(key);
            Console.WriteLine(key2);
        }

        public static void Init()
        {
            Console.WriteLine("called");

            var mSize = 0;
            var mAddr = IntPtr.Zero;

            foreach(ProcessModule m in Process.GetCurrentProcess().Modules)
                if(m.ModuleName == "client.dll")
                {
                    mSize = m.ModuleMemorySize;
                    mAddr = m.BaseAddress;
                }

            Constructor_addr = Memory.PatternScan(g_Client.mHandle, g_Client.mSize, "E8 ? ? ? ? 8B F8 EB 02 33 FF 53 8B 9E ? ? ? ? 8B CF 6A 01 68 ? ? ? ? E8 ? ? ? ? 85 C0 74 07 89 58 0C C6 40 10 02");
            //Constructor_addr = Constructor_addr + *(int*)(Constructor_addr + 1) + 4;

            InitKey_addr = Memory.PatternScan(g_Client.mHandle, g_Client.mSize, "68 ? ? ? ? 8B C8 E8 ? ? ? ? 89 45 FC EB 07 C7 45 ? ? ? ? ? 8B 03 56") + 7;
            InitKey_addr = InitKey_addr + *(int*)(InitKey_addr + 1) + 5;
            //55 8B EC 83 EC 48 53 56 57 8B F9 89 7D F4
            //55 8B EC 83 E4 F8 83 EC 34 53 8B 5D 0C 89 4C 24 04
            LoadFromBuffer_addr = Memory.PatternScan(g_Client.mHandle, g_Client.mSize, "55 8B EC 83 E4 F8 83 EC 3C 8B C1");
            //LoadFromBuffer_addr = LoadFromBuffer_addr + *(int*)(LoadFromBuffer_addr + 1) + 4;
            Console.WriteLine(LoadFromBuffer_addr);
            if (LoadFromBuffer_addr == IntPtr.Zero)
                return;
            init = Marshal.GetDelegateForFunctionPointer<d_InitKeyValues>(InitKey_addr);
            load = Marshal.GetDelegateForFunctionPointer<d_LoadFromBuffer>(LoadFromBuffer_addr);

            Console.WriteLine("Constructor_addr:" + Constructor_addr);
            Console.WriteLine("InitKey_addr:" + InitKey_addr);
            Console.WriteLine("LoadFromBuffer_addr:" + LoadFromBuffer_addr);

            Test("VertexLitGeneric", "models/weapons/v_models/knife_m9_bay/knife_m9_bay", false, false);

            Console.WriteLine("done");

        }

        public static IMaterial mymat;

        public static void Test(string mat_type, string base_material, bool ignorez, bool nofog)
        {
            var mat_name = "test_mat_lol_ezhax";
            var mat_data = System.IO.File.ReadAllText(@"D:\Programme\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\models\weapons\v_models\knife_m9_bay\knife_m9_bay.vmt");

            var keys = new KeyValues();
            var pKeyValues = &keys;

            init((IntPtr)pKeyValues, mat_name);
            Console.WriteLine("1");
            load((IntPtr)pKeyValues, mat_name, mat_data);
            Console.WriteLine("2");
            var mat = g_MatSys.CreateMaterial(mat_name, (IntPtr)pKeyValues);
            Console.WriteLine(mat.addr);
            
            mymat = mat;
        }

        struct KeyValues
        {
            fixed byte _pad[0x20];
        }
    }
}
