using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GenerateStructs
{
    #region GenerateStructs
    class Program
    {
        static void Main( string[] args )
        {
            var desk    = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var lines   = File.ReadAllText(desk + "\\DTBASE.txt");
            var classes = lines.Split(new string[] { "public class " }, StringSplitOptions.None);
            var structs = new List<string>();

            foreach ( var c in classes )
            {

                var props = c.Split('\n');

                if ( props.Length <= 1 ) 
                    continue;

                var cname = props[0].Remove( props[0].Length - 1 );
                var s = new StructCreator(cname);

                foreach ( var p in props )
                    if ( p.Contains( "Int32" ) )
                    {
                        var tpn       = p.Substring(p.IndexOf("Int32 ") + 6);
                        var prop_name = tpn.Remove( tpn.IndexOf( ' ' ) );
                        var t         = "Offset." + cname + "." + prop_name;
                        var t1        = "public int prop_name { get => *(int*)(addr + __path); set => *(int*)(addr + __path) = value; }";

                        s.lines.Add( t1.Replace( "prop_name", prop_name ).Replace( "__path", t ) );
                    }

                structs.Add( string.Join( Environment.NewLine, s.get() ) );
            }

            File.WriteAllText( desk + "\\DTBASE_structs.txt", string.Join( "\n", structs.ToArray() ) );
        }
    }

    class StructCreator
    {
        public List<string> lines;
        string sname;

        public StructCreator( string struct_name )
        {
            sname = struct_name;
            lines = new List<string>();
            lines.Add( "" );
            lines.Add( string.Format( "public class {0} : baseStructs", sname.Substring( 3 ) ) );
            lines.Add( "{" );
            lines.Add( $"public static implicit operator {sname.Substring( 3 )}(IntPtr ptr) => new {sname.Substring( 3 )}() {"{"} addr = ptr {"}"};" );
        }

        public List<string> get()
        {
            lines.Add( "\n}" );
            return lines;
        }
    }
    #endregion
}