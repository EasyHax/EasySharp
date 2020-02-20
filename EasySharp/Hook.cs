using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.Structs;
using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    public class EzyHook<T> where T : class
    {
        private bool bHooked = false;
        private IntPtr original_addr;
        private IntPtr old_value;

        unsafe public EzyHook(int index, IntPtr baseaddr, T callback_func, out T original_func)
        {
            var callback_addr = Marshal.GetFunctionPointerForDelegate(callback_func);
            original_addr = *(IntPtr*)baseaddr + index * 4;
            old_value = *(IntPtr*)original_addr;
            original_func = Marshal.GetDelegateForFunctionPointer<T>(old_value);
            WinApi.VirtualProtect(original_addr, 4, 0x40, out int lpflOldProtect);
            Marshal.WriteIntPtr(original_addr, callback_addr);
            bHooked = true;
        }

        public void UnHook()
        {
            if (bHooked)
            {
                Marshal.WriteIntPtr(original_addr, old_value);
                bHooked = false;
            }
        }
    }

    public static class Hooks
    {
        public delegate void FrameStageNotify(int frame_Stage);
        public static EzyHook<FrameStageNotify> hk_FrameStageNotify;
        public static FrameStageNotify o_FrameStageNotify;
        public static FrameStageNotify hkFrameStageNotify_callback = new FrameStageNotify(hkFrameStageNotify);

        public delegate void CreateMove(int sequence_number, float input_sample_frametime, bool active);
        public static EzyHook<CreateMove> hk_CreateMove;
        public static CreateMove o_CreateMove;
        public static CreateMove hkCreateMove_callback = new CreateMove(hkCreateMove);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void PaintTraverse(IntPtr addr, uint panel, bool forceRepaint, bool allowForce);
        public static EzyHook<PaintTraverse> hk_PaintTraverse;
        public static PaintTraverse o_PaintTraverse;
        public static PaintTraverse hkPaintTraverse_callback = new PaintTraverse(hkPaintTraverse);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public unsafe delegate void DrawModelExecute(IntPtr addr, IntPtr ctx, DrawModelState_t* state, ModelRenderInfo_t* pInfo, IntPtr pCustomBoneToWorld);
        public static EzyHook<DrawModelExecute> hk_DrawModelExecute;
        public static DrawModelExecute o_DrawModelExecute;
        unsafe public static DrawModelExecute hkDrawModelExecute_callback = new DrawModelExecute(hkDrawModelExecute);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ushort FindModel(IntPtr addr, string model);
        public static EzyHook<FindModel> hk_FindModel;
        public static FindModel o_FindModel;
        public static FindModel hkFindModel_callback = new FindModel(hkFindModel);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        unsafe public delegate void SetViewModelSequence(IntPtr addr, CRecvProxyData* pDataConst, IntPtr pStruct, IntPtr pOut);
        unsafe public static SetViewModelSequence o_SetViewModelSequence;
        unsafe public static SetViewModelSequence hkSetViewModelSequence_callback = new SetViewModelSequence(hkSetViewModelSequence);

        unsafe public static void hkSetViewModelSequence(IntPtr addr, CRecvProxyData* pDataConst, IntPtr pStruct, IntPtr pOut)
        {
            var Data = new CRecvProxyData();
            Data = *pDataConst;
            var pData = &Data;

            FixSequence.Do(pData, pStruct);
            o_SetViewModelSequence(addr, pData, pStruct, pOut);
        }

        //static bool done = false;
        unsafe public static void hkDrawModelExecute(IntPtr addr, IntPtr ctx, DrawModelState_t* state, ModelRenderInfo_t* pInfo, IntPtr pCustomBoneToWorld)
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
            if (form.chams1.chams_enabled.Checked)
                Chams.Do(Marshal.PtrToStringAnsi((IntPtr)pInfo->pModel->szName));

            o_DrawModelExecute(addr, ctx, state, pInfo, pCustomBoneToWorld);
            g_MdlRender.ForcedMaterialOverride(IntPtr.Zero);
        }

        public static ushort hkFindModel(IntPtr addr, string model)
        {
            if (model.Contains("knife"))
            {
                var a = g_MdlCache.FindModel("models/weapons/v_knife_m9_bay.mdl");
                return a;
            }
            
            return o_FindModel(addr, model);
        }

        public static void hkFrameStageNotify(int frame_stage)
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

            o_FrameStageNotify( frame_stage );

            if (frame_stage == 2 && (form.weapons1.weapon_enabled.Checked || form.knife1.knife_enabled.Checked)) 
                SkinChanger.Do();
        }

        public static void hkCreateMove(int sequence_number, float input_sample_frametime, bool active)
        {
            o_CreateMove(sequence_number, input_sample_frametime, active);

            //if (WinApi.isKeyDown(VirtualKeys.A))
            //    SharpSkin.g_LocalPlayer.GetHitboxPos(Hitboxes.HITBOX_HEAD);

            /*
            Task.Factory.StartNew(() => BHop.Do());
            Task.Factory.StartNew(() => Trigger.Do());
            Task.Factory.StartNew(() => Aim.Do());
            Task.Factory.StartNew(() => Wall.Do());
            */
        }

        public static void hkPaintTraverse(IntPtr addr, uint panel, bool forceRepaint, bool allowForce)
        {
            o_PaintTraverse(addr, panel, forceRepaint, allowForce);

            
            if (!ProxyHook.bHooked && g_Engine.IsInGame() && g_LocalPlayer && g_LocalPlayer.isAlive)
                ProxyHook.Hook();
            if (ProxyHook.bHooked && !g_Engine.IsInGame())
                ProxyHook.UnHook();

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
