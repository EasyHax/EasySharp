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
        public static bool bHooked = false;

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
                    hk_SetViewModelSequence = new HookEngine<SetViewModelSequence>( pProp->m_ProxyFn, hkSetViewModelSequence_callback, 7 );
                    bHooked = true;
                    break;
                }
            }
        }
    }
}
