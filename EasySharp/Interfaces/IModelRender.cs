using System;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class ModelRender : baseInterface
    {
        Delegate forcedMaterialOverride;

        public ModelRender((IntPtr, IntPtr, int) infos) : base(infos)
        {
            forcedMaterialOverride = WrapVFunc(1, t_Void, t_IntPtr);
        }

        unsafe public void ForcedMaterialOverride(IMaterial material) => forcedMaterialOverride.DynamicInvoke(addr, material.addr);
    }

    public unsafe struct DrawModelState_t
    {
        studiohdr_t* m_pStudioHdr;
        IntPtr m_pStudioHWData;
        IntPtr m_pRenderable;
        IntPtr m_pModelToWorld;
        IntPtr m_decals;
        int m_drawFlags;
        int m_lod;
    }

    public unsafe struct ModelRenderInfo_t
    {
        Vector origin;
        Vector angles;
        fixed byte pad[4];
        IntPtr pRenderable;
        public model_t* pModel;
        IntPtr pModelToWorld;
        IntPtr pLightingOffset;
        Vector* pLightingOrigin;
        int flags;
        public int entity_index;
        int skin;
        int body;
        int hitboxset;
        ushort instance;
    }

    public unsafe struct model_t
    {
        void* fnHandle;               //0x0000 
        public fixed byte szName[260];            //0x0004 
        int nLoadFlags;             //0x0108 
        int nServerCount;           //0x010C 
        int type;                   //0x0110 
        int flags;                  //0x0114 
        Vector vecMins;                //0x0118 
        Vector vecMaxs;                //0x0124 
        float radius;                 //0x0130 
        fixed byte pad[0x1C];              //0x0134
    };
}
