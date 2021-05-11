using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    unsafe class DumpSkins
    {
        public static List<SharpSkin_Weapon> sharpSkin_Skins = new List<SharpSkin_Weapon>();
        public static List<(int, string)> sharpSkin_AllSkins = new List<(int, string)>();
        public static int[] sharpSkin_SkinId;

        [UnmanagedFunctionPointer( CallingConvention.Cdecl )]
        public delegate int item_system();

        [UnmanagedFunctionPointer( CallingConvention.Cdecl )]
        public delegate int d_V_UCS2ToUTF8( IntPtr ucs, IntPtr name, int len );

        [UnmanagedFunctionPointer( CallingConvention.ThisCall )]
        public delegate IntPtr find_item( IntPtr ptr, string tokenName );

        public static void Dump()
        {
            var sig_address        = Memory.PatternScan(SharpSkin.g_Client.mHandle, SharpSkin.g_Client.mSize, "E8 ?? ?? ?? ?? FF 76 0C 8D 48 04 E8");
            var item_system_offset = *(int*)(sig_address + 1);
            var item_system_fn     = sig_address + 5 + item_system_offset;
            var item_System        = Marshal.GetDelegateForFunctionPointer<item_system>(item_system_fn);
            var item_schema        = item_System() + 4;

            var get_paint_kit_definition_offset = *(int*)(sig_address + 11 + 1);
            var get_paint_kit_definition_fn     = sig_address + 5 + 11 + get_paint_kit_definition_offset;
            var start_element_offset            = *(int*)(get_paint_kit_definition_fn + 8 + 2);

            var head_offset    = start_element_offset - 12;
            var map_head       = item_schema + head_offset;
            var last_element   = *(int*)(map_head + 0x0018);
            var ptr            = (Head_t*)(map_head);

            var V_UCS2ToUTF8 = WinApi.getApi<d_V_UCS2ToUTF8>("V_UCS2ToUTF8", "vstdlib.dll", out _);
            var output       = Marshal.AllocHGlobal(256);

            for ( int i = 0; i < last_element; i++ )
            {
                var paint_kit = ptr->memory[i].value;

                if ( paint_kit->id == 9001 )
                    continue;

                var itemName  = Encoding.UTF8.GetString((byte*)(paint_kit->item_name.buffer), paint_kit->item_name.length - 1).Remove(0, 1);
                var raw_item  = g_Localize.FindItem(itemName);
                var length    = V_UCS2ToUTF8(raw_item, output, 256);
                var skin_name = Encoding.UTF8.GetString((byte*)output, length - 1);
                sharpSkin_AllSkins.Add( (paint_kit->id, skin_name) );

                var skin_info = Parser.Parse(itemName);
                if ( skin_info.Item1 == "ERROR" )
                    continue;


                sharpSkin_Skins.Add( new SharpSkin_Weapon( paint_kit->id, skin_info.Item2, skin_info.Item1, skin_name ) );
            }

            sharpSkin_AllSkins = sharpSkin_AllSkins.OrderBy(x => x.Item2).ToList();

            sharpSkin_SkinId = sharpSkin_AllSkins.Select( x => x.Item1 ).ToArray();
        }

        public struct SharpSkin_Weapon
        {
            public SharpSkin_Weapon( int id, string weapon, string name, string translated_name )
            {
                this.id = id;
                this.name = name;
                this.translated_name = translated_name;
                this.weapon = weapon;
                this.index = (ItemDefinitionIndex)Enum.Parse( typeof( ItemDefinitionIndex ), weapon );
            }

            public readonly int id;
            public readonly string name;
            public readonly string translated_name;
            public readonly string weapon;
            public readonly ItemDefinitionIndex index;
        }

        struct Node_t
        {
            public int previous_id;
            public int next_id;
            public void* _unknown_ptr;
            public int _unknown;
            public int key;
            public CPaintKit* value;
        }

        struct Head_t
        {
            public Node_t* memory;
            public int allocation_count;
            public int grow_size;
            public int start_element;
            public int next_available;
            public int _unknown;
            public int last_element;
        }

        struct String_t
        {
            public char* buffer;
            public int capacity;
            public int grow_size;
            public int length;
        }

        struct CPaintKit
        {
            public int id;
            public String_t name;
            public String_t description;
            public String_t item_name;
            public String_t material_name;
            public String_t image_inventory;
        }
    }

    struct CPaintKit
    {
        public int id;
        public int name;
        public int description;
        public int item_name;
        public int material_name;
        public int image_inventory;
        public char pad_0x0054;
    };

    enum SkinType
    {
        WEAPON,
        KNIFE,
        GLOVE
    }

    public enum ItemDefinitionIndex
    {
        DEAGLE = 1,
        ELITE = 2,
        FIVESEVEN = 3,
        GLOCK = 4,
        AK47 = 7,
        AUG = 8,
        AWP = 9,
        FAMAS = 10,
        G3SG1 = 11,
        GALILAR = 13,
        M249 = 14,
        M4A1 = 16,
        MAC10 = 17,
        P90 = 19,
        MP5_SD = 23,
        UMP45 = 24,
        XM1014 = 25,
        BIZON = 26,
        MAG7 = 27,
        NEGEV = 28,
        SAWEDOFF = 29,
        TEC9 = 30,
        TASER = 31,
        HKP2000 = 32,
        MP7 = 33,
        MP9 = 34,
        NOVA = 35,
        P250 = 36,
        SCAR20 = 38,
        SG553 = 39,
        SSG08 = 40,
        KNIFE = 42,
        FLASHBANG = 43,
        HEGRENADE = 44,
        SMOKEGRENADE = 45,
        MOLOTOV = 46,
        DECOY = 47,
        INCGRENADE = 48,
        C4 = 49,
        _T_ = 59,
        M4A1_SILENCER = 262204,
        USP_SILENCER = 262205,
        CZ75A = 63,
        REVOLVER = 64,

        //Knifes

        BAYONET = 500,
        CSS = 503,
        FLIP = 505,
        GUT = 506,
        KARAMBIT = 507,
        M9_BAYONET = 508,
        TACTICAL = 509,
        FALCHION = 512,
        SURVIVAL_BOWIE = 514,
        BUTTERFLY = 515,
        PUSH = 516,
        URSUS = 519,
        NAVAJA = 520,
        STILETTO = 522,
        WIDOWMAKER = 523,
        CLASSIC = 503,
        SKELETON = 525,
        SURVIVAL = 518,
        NOMAD = 521,
        PARACORD = 517,

        //Gloves

        STUDDED_BLOODHOUND = 5027,
        T_SIDE = 5028,
        C_TSIDE = 5029,
        SPORTY = 5030,
        SLICK = 5031,
        LEATHER_WRAP = 5032,
        MOTORCYCLE = 5033,
        SPECIALIST = 5034,
        GHYDRA = 5035
    }
}
