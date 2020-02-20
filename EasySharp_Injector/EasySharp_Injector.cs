using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyHook;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SharpSkin
{
    class Program
    {
        public static string lib = "EasySharp.dll";
        public static string target = "csgo";

        static void Main(string[] args)
        {
            try
            {
                RemoteHooking.Inject(Process.GetProcessesByName(target).FirstOrDefault().Id, lib, lib);
                Console.WriteLine("Success");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message + Environment.NewLine + Ex.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
