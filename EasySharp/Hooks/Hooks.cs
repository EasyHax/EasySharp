using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    class Hooks
    {
        [UnmanagedFunctionPointer( CallingConvention.ThisCall )]
        public delegate void FrameStageNotify( IntPtr addr, int frame_Stage );
        public static HookEngine<FrameStageNotify> hk_FrameStageNotify;
        public static FrameStageNotify hkFrameStageNotify_callback = new FrameStageNotify( hkFrameStageNotify );

        [UnmanagedFunctionPointer( CallingConvention.ThisCall )]
        public delegate void CreateMove( IntPtr addr, int sequence_number, float input_sample_frametime, bool active );
        public static HookEngine<CreateMove> hk_CreateMove;
        public static CreateMove hkCreateMove_callback = new CreateMove( hkCreateMove );

        [UnmanagedFunctionPointer( CallingConvention.ThisCall )]
        public delegate void PaintTraverse( IntPtr addr, uint panel, bool forceRepaint, bool allowForce );
        public static HookEngine<PaintTraverse> hk_PaintTraverse;
        public static PaintTraverse hkPaintTraverse_callback = new PaintTraverse( hkPaintTraverse );

        [UnmanagedFunctionPointer( CallingConvention.ThisCall )]
        public unsafe delegate void DrawModelExecute( IntPtr addr, IntPtr ctx, DrawModelState_t* state, ModelRenderInfo_t* pInfo, IntPtr pCustomBoneToWorld );
        public static HookEngine<DrawModelExecute> hk_DrawModelExecute;
        unsafe public static DrawModelExecute hkDrawModelExecute_callback = new DrawModelExecute( hkDrawModelExecute );

        [UnmanagedFunctionPointer( CallingConvention.ThisCall )]
        public delegate ushort FindModel( IntPtr addr, string model );
        public static HookEngine<FindModel> hk_FindModel;
        public static FindModel hkFindModel_callback = new FindModel( hkFindModel );

        [UnmanagedFunctionPointer( CallingConvention.Cdecl )]
        unsafe public delegate void SetViewModelSequence( CRecvProxyData* pConstData, IntPtr pViewModel, IntPtr pOut );
        public static HookEngine<SetViewModelSequence> hk_SetViewModelSequence;
        unsafe public static SetViewModelSequence hkSetViewModelSequence_callback = new SetViewModelSequence( hkSetViewModelSequence );


        unsafe public static void hkSetViewModelSequence( CRecvProxyData* pConstData, IntPtr pViewModel, IntPtr pOut )
        {
            FixSequence.Do( pConstData, pViewModel );
            hk_SetViewModelSequence.o_fn( pConstData, pViewModel, pOut );
        }

        //static bool done = false;
        unsafe public static void hkDrawModelExecute( IntPtr addr, IntPtr ctx, DrawModelState_t* state, ModelRenderInfo_t* pInfo, IntPtr pCustomBoneToWorld )
        {
            /*
            if (!done)
            {
                Console.WriteLine("try");
                CustomSkins.Test("VertexLitGeneric", "models/weapons/aqua", false, false);
                Console.WriteLine("success");
                done = true;
            }
            */
            if ( form.chams1.chams_enabled.Checked )
                Chams.Do( Marshal.PtrToStringAnsi( (IntPtr)pInfo->pModel->szName ) );

            hk_DrawModelExecute.o_fn( addr, ctx, state, pInfo, pCustomBoneToWorld );
            g_MdlRender.ForcedMaterialOverride( IntPtr.Zero );
        }

        public static ushort hkFindModel( IntPtr addr, string model )
        {
            if ( model.Contains( "knife" ) )
            {
                var a = g_MdlCache.FindModel( "models/weapons/v_knife_m9_bay.mdl" );
                return a;
            }

            return hk_FindModel.o_fn( addr, model );
        }

        public static void hkFrameStageNotify( IntPtr addr, int frame_stage )
        {
            /*
            if (!ProxyHook.bHooked && g_Engine.IsInGame() && g_LocalPlayer && g_LocalPlayer.isAlive)
            {
                ProxyHook.Hook();
                //Console.WriteLine("hooked");
            }
            if (ProxyHook.bHooked && !g_Engine.IsInGame())
            {
                ProxyHook.UnHook();
                //Console.WriteLine("unhooked");
            }
            */
            if ( frame_stage == 2 && ( form.weapons1.weapon_enabled.Checked || form.knife1.knife_enabled.Checked ) )
                SkinChanger.Do();

            hk_FrameStageNotify.o_fn( addr, frame_stage );
        }

        public static void hkCreateMove( IntPtr addr, int sequence_number, float input_sample_frametime, bool active )
        {
            hk_CreateMove.o_fn( addr, sequence_number, input_sample_frametime, active );

            //if (WinApi.isKeyDown(VirtualKeys.A))
            //    SharpSkin.g_LocalPlayer.GetHitboxPos(Hitboxes.HITBOX_HEAD);

            if ( form.hax1.aim_enabled.Checked )
                Task.Factory.StartNew( () => Features.Legit.Aimbot.Do() );

            /*
            Task.Factory.StartNew(() => BHop.Do());
            Task.Factory.StartNew(() => Trigger.Do());
            Task.Factory.StartNew(() => Aim.Do());
            Task.Factory.StartNew(() => Wall.Do());
            */
        }

        public static void hkPaintTraverse( IntPtr addr, uint panel, bool forceRepaint, bool allowForce )
        {
            hk_PaintTraverse.o_fn( addr, panel, forceRepaint, allowForce );


            //if ( !ProxyHook.bHooked && g_Engine.IsInGame() && g_LocalPlayer && g_LocalPlayer.isAlive )
            //    ProxyHook.Hook();
            //if ( ProxyHook.bHooked && !g_Engine.IsInGame() )
            //    ProxyHook.UnHook();

            /*
            if (WinApi.isKeyDown(VirtualKeys.E))
            {
                var ens = Utils.GetEnemies();
                var a = Utils.GetClosest(ens, Hitboxes.HITBOX_HEAD, out var en, out var ang);
                if (a)
                {
                    SharpSkin.g_Surface.DrawLine_FromWorld(SharpSkin.g_LocalPlayer.m_vecOrigin, en.m_vecOrigin);
                }
            }
            */
            /*
            if (Keyboard.IsKeyDown(Key.E))
            {
                Utils.GetClosest(Utils.GetEnemies(), out var p, out var vAngle);

                if (!p)
                {                  
                    g_Surface.DrawLine_FromWorld(g_LocalPlayer.VecOrigin, p.VecOrigin);

                    var trace_t = g_EngineTrace.TraceRay(g_LocalPlayer, p/);

                    Console.WriteLine("fraction: " + trace_t->fraction);
                    Console.WriteLine("entity:" + trace_t->hit_entity);
                    Console.WriteLine("health: " + new Player(trace_t->hit_entity).Health);
                }
            }
            */

            //DrawShots.Do();
            //Wall.Do();
        }
    }
}
