using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class Localize : baseInterface
    {
        Delegate findItem;

        public Localize((IntPtr, IntPtr, int) infos) : base(infos)
        {
            findItem = WrapVFunc(12, t_IntPtr, t_String);
        }

        public IntPtr FindItem(string item) => (IntPtr)findItem.DynamicInvoke(addr, item);
    }
}
