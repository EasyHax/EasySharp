using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.SharpSkin;
using static SharpSkin_dll.Hooks;

namespace SharpSkin_dll
{
    unsafe class ProxyHook
    {
        public static bool      bHooked = false;
        public static RecvProp* o_pSequence_Prop;
        public static IntPtr    o_ProxyFn;

        public static void Hook()
        {
            if (bHooked)
                return;

            var pBaseViewModel = Utils.GetClass("CBaseViewModel");

            var pClassTable = pBaseViewModel->m_pRecvTable;

            for (int nIndex = 0; nIndex < pClassTable->m_nProps; nIndex++)
            {
                var pProp = &pClassTable->m_pProps[nIndex];

                if (Marshal.PtrToStringAnsi((IntPtr)pProp->m_pVarName) == "m_nSequence")
                {
                    o_pSequence_Prop = pProp;
                    o_ProxyFn = pProp->m_ProxyFn;
                    o_SetViewModelSequence = Marshal.GetDelegateForFunctionPointer<SetViewModelSequence>(o_ProxyFn);
                    pProp->m_ProxyFn = Marshal.GetFunctionPointerForDelegate(hkSetViewModelSequence_callback);
                    bHooked = true;
                    break;
                }
            }
        }

        public static void UnHook()
        {
            if (bHooked)
            {
                o_pSequence_Prop->m_ProxyFn = o_ProxyFn;
                bHooked = false;
            }
        }
    }
}
