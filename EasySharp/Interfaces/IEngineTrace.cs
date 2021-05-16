using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.GenericInterop;
using static SharpSkin_dll.Structs;

namespace SharpSkin_dll
{

    unsafe class EngineTrace : baseInterface
    {
        private Delegate traceRay;

        public EngineTrace((IntPtr, IntPtr, int) infos) : base(infos)
        {
            traceRay = WrapVFunc(5, t_Void, t_IntPtr, t_Uint, t_IntPtr, t_IntPtr);
        }

        public Trace_t* TraceRay(BasePlayer p1, BasePlayer p2, uint fMask = 0x4600400B)
        {
            var trace_t = new Trace_t();
            var filter_t = new TraceFilter();
            var ray_t = new Ray_t(p1.GetHitboxPos(Hitboxes.HITBOX_HEAD), p2.GetHitboxPos(Hitboxes.HITBOX_HEAD));
            var vtable = new CTraceFilterVTable(Memory.FunctionToPointer<d_ShouldHitEntity>(filter_t.ShouldHitEntity), Memory.FunctionToPointer<d_GetTraceType>(filter_t.GetTraceType));

            vtable.pGetTraceType = Marshal.GetFunctionPointerForDelegate<d_GetTraceType>(filter_t.GetTraceType);
            vtable.pShouldHitEntity = Marshal.GetFunctionPointerForDelegate<d_ShouldHitEntity>(filter_t.ShouldHitEntity);
            (filter_t.pVTable, filter_t.pSkip1) = ((IntPtr)(&vtable), p1.addr);

            return TraceRay(&ray_t, &filter_t, &trace_t, fMask);
        }

        public Trace_t* TraceRay(Ray_t* ray, TraceFilter* pFilter, Trace_t* pTrace, uint fMask = 0x4600400B)
        {
            traceRay.DynamicInvoke(addr, (IntPtr)ray, fMask, (IntPtr)pFilter, (IntPtr)pTrace);
            return pTrace;
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public unsafe delegate bool d_ShouldHitEntity(IntPtr addr, IntPtr pEntityHandle, int contentsMask);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public unsafe delegate int d_GetTraceType(IntPtr addr);

        public unsafe struct TraceFilter
        {
            public IntPtr pVTable;
            public IntPtr pSkip1;

            public bool ShouldHitEntity(IntPtr addr, IntPtr pEntityHandle, int contentsMask)
            {
                return !(pEntityHandle == pSkip1);
            }
            public int GetTraceType(IntPtr addr) => 0;
        }

        public unsafe struct CTraceFilterVTable
        {
            public CTraceFilterVTable(IntPtr pShouldHitEntity, IntPtr pGetTraceType)
                => (this.pShouldHitEntity, this.pGetTraceType) = (pShouldHitEntity, pGetTraceType);

            public IntPtr pShouldHitEntity;
            public IntPtr pGetTraceType;
        }

        public unsafe struct Ray_t
        {
            public VectorAligned m_Start;
            public VectorAligned m_Delta;
            public VectorAligned m_StartOffset;
            public VectorAligned m_Extents;
            public IntPtr m_pWorldAxisTransform;
            public byte m_IsRay;
            public byte m_IsSwept;

            public Ray_t(Vector start, Vector end)
            {
                m_Delta = end - start;
                m_IsSwept = Convert.ToByte(m_Delta.Length != 0);
                Console.WriteLine(m_IsSwept);
                m_Extents = Vector.Zero;
                m_pWorldAxisTransform = IntPtr.Zero;
                m_IsRay = 1;
                m_StartOffset = Vector.Zero;
                m_Start = start;
            }
        }

        public unsafe struct Surface_t
        {
            public IntPtr name;
            public short surfaceProps;
            public ushort flags;
        }

        public unsafe struct Plane_t
        {
            Vector normal;
            float dist;
            byte type;
            byte signbits;
            fixed byte pad[2];
        }

        public unsafe struct Trace_t
        {
            public Vector startpos;
            public Vector endpos;
            public Plane_t plane;
            public float fraction;
            public int contents;
            public ushort dispFlags;
            public byte allsolid;
            public byte startsolid;
            public float fractionleftsolid;
            public Surface_t surface;
            public int hitgroup;
            public short physicsbone;
            public ushort worldSurfaceIndex;
            public IntPtr hit_entity;
            public int hitbox;
        }
    }
}
