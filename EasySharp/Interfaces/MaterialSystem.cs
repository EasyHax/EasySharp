using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class MaterialSystem : baseInterface
    {
        Delegate createMaterial;
        Delegate findMaterial;
        Delegate firstMaterial;
        Delegate nextMaterial;
        Delegate invalidMaterial;
        Delegate getMaterial;

        public string TEXTURE_GROUP_OTHER = "Other textures";
        public string TEXTURE_GROUP_MODEL = "Model textures";

        public MaterialSystem((IntPtr, IntPtr, int) infos) : base(infos)
        {
            createMaterial = WrapVFunc(83, t_IntPtr, t_String, t_IntPtr);
            findMaterial = WrapVFunc(84, t_IntPtr, t_String, t_String);
            firstMaterial = WrapVFunc(86, t_Ushort);
            nextMaterial = WrapVFunc(87, t_Ushort, t_Ushort);
            invalidMaterial = WrapVFunc(88, t_Ushort);
            getMaterial = WrapVFunc(89, t_Ushort, t_Ushort);
        }

        public IMaterial CreateMaterial(string materialName, IntPtr KeyValues) => (IntPtr)createMaterial.DynamicInvoke(addr, materialName, KeyValues);
        public IMaterial FindMaterial(string materialName, string textureGroupName = null) => (IntPtr)findMaterial.DynamicInvoke(addr, materialName, textureGroupName);
        public IMaterial GetMaterial(ushort materialIndex) => (IntPtr)getMaterial.DynamicInvoke(addr, materialIndex);

        public ushort FirstMaterial() => (ushort)firstMaterial.DynamicInvoke(addr);
        public ushort NextMaterial(ushort materialIndex) => (ushort)nextMaterial.DynamicInvoke(addr, materialIndex);
        public ushort InvalidMaterial() => (ushort)invalidMaterial.DynamicInvoke(addr);

        public void OverriderMaterial(string materialName, int flag = 0, bool enable = false, float alpha = -1f, float r = -1f, float g = -1f, float b = -1f)
        {
            var mat = SharpSkin.g_MatSys.FindMaterial(materialName);
            if (alpha != -1f) mat.AlphaModulate(alpha);
            if (flag != 0) mat.SetMaterialVarFlag(flag, enable);
            if (r + g + b >= 0f && r + g + b <= 3f) mat.ColorModulate(r, g, b);
            SharpSkin.g_MdlRender.ForcedMaterialOverride(mat);
        }

        public void OverriderMaterial(string materialName, int flag, bool enable, float alpha, System.Drawing.Color color)
        {
            var mat = SharpSkin.g_MatSys.FindMaterial(materialName);
            mat.AlphaModulate(alpha);
            mat.SetMaterialVarFlag(flag, enable);
            mat.ColorModulate(color.R / 255f, color.G / 255f, color.B / 255f);
            SharpSkin.g_MdlRender.ForcedMaterialOverride(mat);
        }
    }

    public struct IMaterial
    {
        public enum MaterialVarFlags_t
        {
            MATERIAL_VAR_DEBUG                   = (1 << 0),
            MATERIAL_VAR_NO_DEBUG_OVERRIDE       = (1 << 1),
            MATERIAL_VAR_NO_DRAW                 = (1 << 2),
            MATERIAL_VAR_USE_IN_FILLRATE_MODE    = (1 << 3),
            MATERIAL_VAR_VERTEXCOLOR             = (1 << 4),
            MATERIAL_VAR_VERTEXALPHA             = (1 << 5),
            MATERIAL_VAR_SELFILLUM               = (1 << 6),
            MATERIAL_VAR_ADDITIVE                = (1 << 7),
            MATERIAL_VAR_ALPHATEST               = (1 << 8),
            MATERIAL_VAR_UNUSED                  = (1 << 9),
            MATERIAL_VAR_ZNEARER                 = (1 << 10),
            MATERIAL_VAR_MODEL                   = (1 << 11),
            MATERIAL_VAR_FLAT                    = (1 << 12),
            MATERIAL_VAR_NOCULL                  = (1 << 13),
            MATERIAL_VAR_NOFOG                   = (1 << 14),
            MATERIAL_VAR_IGNOREZ                 = (1 << 15),
            MATERIAL_VAR_DECAL                   = (1 << 16),
            MATERIAL_VAR_BASEALPHAENVMAPMASK     = (1 << 20),
            MATERIAL_VAR_TRANSLUCENT             = (1 << 21),
            MATERIAL_VAR_OPAQUETEXTURE           = (1 << 24),
            MATERIAL_VAR_SUPPRESS_DECALS         = (1 << 26),
            MATERIAL_VAR_HALFLAMBERT             = (1 << 27),
            MATERIAL_VAR_WIREFRAME               = (1 << 28),
            MATERIAL_VAR_ALLOWALPHATOCOVERAGE    = (1 << 29),
            MATERIAL_VAR_ALPHA_MODIFIED_BY_PROXY = (1 << 30),
            MATERIAL_VAR_VERTEXFOG               = (1 << 31),
        }

        public static implicit operator IMaterial(IntPtr ptr) => new IMaterial { addr = ptr };
        public IntPtr addr;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate void d_AlphaModulate(IntPtr addr, float alpha);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate void d_ColorModulate(IntPtr addr, float r, float g, float b);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate void d_SetMaterialVarFlag(IntPtr addr, int flag, bool on);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate bool d_IsErrorMaterial(IntPtr addr);
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate string d_GetName(IntPtr addr);

        public void AlphaModulate(float alpha) => Marshal.GetDelegateForFunctionPointer<d_AlphaModulate>(addr.VirtualAddress(27))(addr, alpha);
        public void ColorModulate(float r, float g, float b) => Marshal.GetDelegateForFunctionPointer<d_ColorModulate>(addr.VirtualAddress(28))(addr, r, g, b);
        public void SetMaterialVarFlag(int flag, bool on) => Marshal.GetDelegateForFunctionPointer<d_SetMaterialVarFlag>(addr.VirtualAddress(29))(addr, flag, on);
        public bool IsErrorMaterial() => Marshal.GetDelegateForFunctionPointer<d_IsErrorMaterial>(addr.VirtualAddress(42))(addr);
        public string GetTextureGroupName() => Marshal.GetDelegateForFunctionPointer<d_GetName>(addr.VirtualAddress(1))(addr);
        public string GetName() => Marshal.GetDelegateForFunctionPointer<d_GetName>(addr.VirtualAddress(0))(addr);
    }
}
