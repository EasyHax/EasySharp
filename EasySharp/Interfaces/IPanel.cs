using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class Panel : baseInterface
    {
        public Panel((IntPtr, IntPtr, int) infos) : base(infos)
        {

        }
    }
}
