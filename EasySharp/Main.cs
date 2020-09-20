using System;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Input;

using RGiesecke.DllExport;

using static SharpSkin_dll.SharpSkin;
using static SharpSkin_dll.Hooks;
using static SharpSkin_dll.Structs;

namespace SharpSkin_dll
{
    public static class Main
    {
        [DllExport( "Entry" )]
        public static unsafe void Entry()
        {
            Thread.CurrentThread.SetApartmentState( ApartmentState.STA );
            Execute();
        }

        [STAThread]
        public static unsafe void Execute()
        {
            try
            {
                WinApi.AllocConsole();
                Display.Init();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;

                //VpkParser.Do();
                //return;
                Display.UnderLine( "=====| SharpSkin |=====\n", ConsoleColor.DarkGreen );
                Init();

                //new Task(Features.TriggerBot.Do).Start();

                //weapons.ReadyConfig();
                //CustomSkins.Init();

                #region Loop
                while ( !bUnload )
                {
                    if ( Keyboard.IsKeyDown( Key.Insert ) )
                    {
                        if ( !form.Visible ) new Task( () => form.ShowDialog() ).Start();
                        else new MethodInvoker( form.Hide ).BeginInvoke( null, null );
                        Thread.Sleep( 150 );
                    }
                    if ( Keyboard.IsKeyDown( Key.Delete ) )
                    {
                        if ( form.Visible ) form.Hide();
                        break;
                    }
                }
                #endregion

                Dispose();
                Console.WriteLine( "Unloaded." );
            }
            catch ( Exception ex )
            {
                Console.WriteLine( ex );
            }
        }
    }

    unsafe class SharpSkin
    {
        public static readonly string config_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SharpSkin\\";

        public static Form1 form;
        public static Random random = new Random((int)DateTime.Now.Ticks);
        public static bool bUnload = false;

        public static Localize       g_Localize;
        public static Client         g_Client;
        public static Engine         g_Engine;
        public static Entity         g_Entity;
        public static ModelInfo      g_MdlInfo;
        public static ModelCache     g_MdlCache;
        public static EngineTrace    g_EngineTrace;
        public static DebugOverlay   g_DbgOverlay;
        public static Surface        g_Surface;
        public static Panel          g_Panel;
        public static MaterialSystem g_MatSys;
        public static ModelRender    g_MdlRender;
        public static NetvarMngr     g_NtvMngr;
        public static BasePlayer     g_LocalPlayer { get => g_Entity.GetClientEntity(g_Engine.GetLocalPlayer()); }

        public static void Init()
        {
            Display.WriteLine("[!] Loading Interfaces..", ConsoleColor.DarkYellow);

            g_Client        = new Client       (Interface.CreateInterface("VClient018"          , "client.dll"));
            g_Engine        = new Engine       (Interface.CreateInterface("VEngineClient014"    , "engine.dll"         ));
            g_Entity        = new Entity       (Interface.CreateInterface("VClientEntityList003", "client.dll"));
            g_MdlInfo       = new ModelInfo    (Interface.CreateInterface("VModelInfoClient004" , "engine.dll"         ));
            g_EngineTrace   = new EngineTrace  (Interface.CreateInterface("EngineTraceClient004", "engine.dll"         ));
            g_DbgOverlay    = new DebugOverlay (Interface.CreateInterface("VDebugOverlay004"    , "engine.dll"         ));
            g_Surface       = new Surface      (Interface.CreateInterface("VGUI_Surface031"     , "vguimatsurface.dll" ));
            g_Localize      = new Localize     (Interface.CreateInterface("Localize_001"        , "localize.dll"       ));
            g_Panel         = new Panel        (Interface.CreateInterface("VGUI_Panel009"       , "vgui2.dll"          ));
            g_MdlRender     = new ModelRender  (Interface.CreateInterface("VEngineModel016"     , "engine.dll"         ));
            g_MdlCache      = new ModelCache   (Interface.CreateInterface("MDLCache004"         , "datacache.dll"      ));
            g_MatSys        = new MaterialSystem(Interface.CreateInterface("VMaterialSystem080" , "materialsystem.dll" ));
            g_NtvMngr       = new NetvarMngr();

            g_NtvMngr.DumpClasses();

            Display.WriteLine("[+] Interfaces Loaded!\n", ConsoleColor.DarkYellow);

            DisplayInterface("g_Client:      ", g_Client.addr     .ToString("X8"));
            DisplayInterface("g_Engine:      ", g_Engine.addr     .ToString("X8"));
            DisplayInterface("g_Entity:      ", g_Entity.addr     .ToString("X8"));
            DisplayInterface("g_MdlInfo:     ", g_MdlInfo.addr    .ToString("X8"));
            DisplayInterface("g_EngineTrace: ", g_EngineTrace.addr.ToString("X8"));
            DisplayInterface("g_Localize:    ", g_Localize.addr   .ToString("X8"));
            DisplayInterface("g_DbgOverlay:  ", g_DbgOverlay.addr .ToString("X8"));
            DisplayInterface("g_Surface:     ", g_Surface.addr    .ToString("X8"));
            DisplayInterface("g_MdlCache:    ", g_MdlCache.addr   .ToString("X8"));
            DisplayInterface("g_Panel:       ", g_Panel.addr      .ToString("X8"));
            DisplayInterface("g_MdlRender:   ", g_MdlRender.addr  .ToString("X8"));
            DisplayInterface("g_MatSys:      ", g_MatSys.addr     .ToString("X8"));
            DisplayInterface("g_NtvMngr:     ", g_NtvMngr.count   .ToString("X8"));

            DumpSkins.Dump();
            form = new Form1();
            GuiTheme.DarkTheme();
            //ProxyHook.Hook();

            Display.WriteLine("\n[!] Hooking game functions..", ConsoleColor.DarkYellow);

            // Uncomment what you need

            hk_FrameStageNotify  = new EzyHook<FrameStageNotify>(37, g_Client.addr,    hkFrameStageNotify_callback, out o_FrameStageNotify);
            //hk_CreateMove        = new EzyHook<CreateMove>      (22, g_Client.addr,    hkCreateMove_callback,       out o_CreateMove      );
            hk_PaintTraverse     = new EzyHook<PaintTraverse>   (41, g_Panel.addr ,    hkPaintTraverse_callback,    out o_PaintTraverse   );
            //hk_DrawModelExecute  = new EzyHook<DrawModelExecute>(21, g_MdlRender.addr, hkDrawModelExecute_callback, out o_DrawModelExecute);
            //hk_FindModel         = new EzyHook<FindModel>       (10, g_MdlCache.addr,  hkFindModel_callback,        out o_FindModel       );

            Display.WriteLine("[+] Game functions hooked!\n", ConsoleColor.DarkYellow);
        }

        public static void Dispose()
        {
            ProxyHook.UnHook();

            if ( hk_FrameStageNotify != null ) hk_FrameStageNotify.UnHook();
            if ( hk_CreateMove       != null ) hk_CreateMove      .UnHook();
            if ( hk_PaintTraverse    != null ) hk_PaintTraverse   .UnHook();
            if ( hk_DrawModelExecute != null ) hk_DrawModelExecute.UnHook();
            if ( hk_FindModel        != null ) hk_FindModel       .UnHook();

            form.Dispose();
            //WinApi.FreeConsole();
        }

        static void DisplayInterface(string interfaceName, string interfaceAddr)
        {
            Display.Write(interfaceName, ConsoleColor.Magenta);
            Display.WriteLine(interfaceAddr, ConsoleColor.DarkCyan);
        }
    }

    class Display
    {
        public static void Init()
        {
            var handle = WinApi.GetStdHandle(-11);
            WinApi.GetConsoleMode(handle, out uint mode);
            WinApi.SetConsoleMode(handle, mode | 4);
        }

        public static void WriteLine(string str, ConsoleColor color) => Write(str + Environment.NewLine, color);
        public static void Write(string str, ConsoleColor color)
        {
            var o_color = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = o_color;
        }

        public static void UnderLine(string str) => Console.WriteLine("\x1B[4m" + str + "\x1B[0m");
        public static void UnderLine(string str, ConsoleColor color)
        {
            var o_color = Console.ForegroundColor;
            Console.ForegroundColor = color;
            UnderLine(str);
            Console.ForegroundColor = o_color;
        }
    }

    class GuiTheme
    {
        //Default Theme
        public static Color clr_MenuPanel      = Color.FromArgb(97, 67, 91);
        public static Color clr_UnderMenuPanel = Color.FromArgb(50, 20, 60);
        public static Color clr_BoxPanel       = Color.FromArgb(90, 50, 80);
        public static Color clr_BackPanel      = Color.FromArgb(31, 10, 35);
        public static Color clr_SharpSkin      = Color.FromArgb(31, 10, 35);

        public static void ApplyTheme(Color c1, Color c2, Color c3, Color c4, Color c5)
        {
            ColorControls(form.Controls);

            clr_MenuPanel      = c1;
            clr_UnderMenuPanel = c2;
            clr_BoxPanel       = c3;
            clr_BackPanel      = c4;
            clr_SharpSkin      = c5;

            void ColorControls(Control.ControlCollection cs)
            {
                foreach (Control c in cs)
                {
                    ReplaceColor(c);
                    if (c.HasChildren)
                        ColorControls(c.Controls);
                }
            }

            void ReplaceColor(Control c)
            {
                if (c.BackColor == clr_MenuPanel)
                    c.BackColor = c1;
                if (c.BackColor == clr_UnderMenuPanel)
                    c.BackColor = c2;
                if (c.BackColor == clr_BoxPanel)
                    c.BackColor = c3;
                if (c.BackColor == clr_BackPanel)
                    c.BackColor = c4;
                if (c.BackColor == clr_SharpSkin)
                    c.BackColor = c5;
            }
        }

        public static void RandomTheme()
        {
            var c1 = RandomColor();
            var c2 = RandomColor();
            var c3 = RandomColor();
            var c4 = RandomColor();
            var c5 = RandomColor();
            ApplyTheme(c1, c2, c3, c4, c5);
        }

        public static void PurpleTheme()
        {
            var c1 = Color.FromArgb(97, 67, 91);
            var c2 = Color.FromArgb(50, 20, 60);
            var c3 = Color.FromArgb(90, 50, 80);
            var c4 = Color.FromArgb(31, 10, 35);
            var c5 = Color.FromArgb(31, 10, 35);
            ApplyTheme(c1, c2, c3, c4, c5);
        }

        public static void DarkTheme()
        {
            var c1 = Color.FromArgb(10, 10, 10);
            var c2 = Color.FromArgb(30, 30, 30);
            var c3 = Color.FromArgb(20, 20, 20);
            var c4 = Color.FromArgb(30, 30, 30);
            var c5 = Color.FromArgb(0, 0, 0);
            ApplyTheme(c1, c2, c3, c4, c5);
        }

        private static Color RandomColor()
        {
            var R = random.Next(0, 256);
            var G = random.Next(0, 256);
            var B = random.Next(0, 256);
            return Color.FromArgb(255, R, G, B);
        }
    }
}
