using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSkin_dll
{
    public class IClientUnknown : Structs.baseStructs
    {
        public IntPtr pUnknown { get => addr + 0; }
    }
}
