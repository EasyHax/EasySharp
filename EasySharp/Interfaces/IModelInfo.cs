using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class ModelInfo : baseInterface
    {
        private Delegate getModelIndex;
        private Delegate getStudioModel;
        private Delegate getModel;
        private Delegate getModelName;

        public ModelInfo((IntPtr, IntPtr, int) infos) : base(infos)
        {
            getModelIndex = WrapVFunc(2, t_Int32, t_String);
            getStudioModel = WrapVFunc(32, t_IntPtr, t_IntPtr);
            getModel = WrapVFunc(1, t_IntPtr, t_Int32);
            getModelName = WrapVFunc(3, t_String, t_IntPtr);
        }

        public int GetModelIndex(string model) => (int)getModelIndex.DynamicInvoke(addr, model);
        public unsafe studiohdr_t* GetStudioModel(IntPtr model) => (studiohdr_t*)(IntPtr)getStudioModel.DynamicInvoke(addr, model);
        public unsafe model_t* GetModel(int modelIndex) => (model_t*)(IntPtr)getModel.DynamicInvoke(addr, modelIndex);
        public unsafe string GetModelName(model_t* pModel) => (string)getModelName.DynamicInvoke(addr, (IntPtr)pModel);
    }

    unsafe struct studiohdr_t
    {
        public int id;                     //0x0000 
        public int version;                //0x0004 
        public long checksum;              //0x0008 
        fixed byte szName[60];             //0x000C 
        public int length;                 //0x004C 
        Vector vecEyePos;                  //0x0050 
        Vector vecIllumPos;                //0x005C 
        Vector vecHullMin;                 //0x0068 
        Vector vecHullMax;                 //0x0074 
        Vector vecBBMin;                   //0x0080 
        Vector vecBBMax;                   //0x008C 
        public int flags;                  //0x0098 
        public int numbones;               //0x009C 
        public int boneindex;              //0x00A0 
        public int numbonecontrollers;     //0x00A4 
        public int bonecontrollerindex;    //0x00A8 
        public int numhitboxsets;          //0x00AC 
        public int hitboxsetindex;         //0x00B0 
        public int numlocalanim;           //0x00B4 
        public int localanimindex;         //0x00B8 
        public int numlocalseq;            //0x00BC 
        public int localseqindex;          //0x00C0 
        public int activitylistversion;    //0x00C4 
        public int eventsindexed;          //0x00C8 
        public int numtextures;            //0x00CC 
        public int textureindex;           //0

        public unsafe mstudiohitboxset_t* GetHitboxSet(int i)
        {
            if (i > numhitboxsets) return (mstudiohitboxset_t*)IntPtr.Zero;
            fixed (void* ptr = &this)
            {
                return (mstudiohitboxset_t*)((IntPtr)ptr + hitboxsetindex + i);
            }
        }
    }

    struct mstudiohitboxset_t
    {
        public int sznameindex;
        public int numhitboxes;
        public int hitboxindex;

        public unsafe mstudiobbox_t* GetHitbox(int i)
        {
            if (i > numhitboxes) return (mstudiobbox_t*)IntPtr.Zero;
            fixed (void* ptr = &this)
                return (mstudiobbox_t*)((IntPtr)ptr + hitboxindex + i);
        }
    }

    unsafe struct mstudiobbox_t
    {
        public int bone;
        int group;
        public Vector bbmin;
        public Vector bbmax;
        int szhitboxnameindex;
        fixed byte m_iPad01[3];
        float m_flRadius;
        fixed byte m_iPad02[4];
    }
}
