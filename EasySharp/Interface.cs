using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;

using static SharpSkin_dll.Offset;
using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    class Interface
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr d_CreateInterface(string interface_name, IntPtr addr);

        public static (IntPtr, IntPtr, int) CreateInterface(string interface_name, string module_name)
        {
            IntPtr mHandle = IntPtr.Zero;
            int mSize = 0;

            foreach(ProcessModule m in Process.GetCurrentProcess().Modules)
                if(m.ModuleName == module_name)
                {
                    mHandle = m.BaseAddress;
                    mSize = m.ModuleMemorySize;
                }
            var createInterface = Marshal.GetDelegateForFunctionPointer<d_CreateInterface>(WinApi.GetProcAddress(mHandle, "CreateInterface"));
            return (createInterface(interface_name, IntPtr.Zero), mHandle, mSize);
        }
    }

    struct VectorAligned
    {
        public float X, Y, Z, W;

        public VectorAligned(float X, float Y, float Z, float W)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.W = W;
        }

        public static implicit operator VectorAligned(Vector v) => new VectorAligned(v.X, v.Y, v.Z, 0);

        public double Length { get => X * X + Y * Y + Z * Z; }
    }

    public struct Vector
    {
        public float X, Y, Z;

        public Vector(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Vector(float T)
        {
            X = T;
            Y = T;
            Z = T;
        }

        public static implicit operator Vector(float f) => new Vector(f);

        // Angles between two vectors
        public static Vector operator ^(Vector v1, Vector v2)
        {
            var difference = v1 - v2;
            var distance = (float)Math.Sqrt(difference.X * difference.X + difference.Y * difference.Y + difference.Z * difference.Z);
            
            var vAngle = new Vector(
                X: (float)(Math.Asin(difference.Z / distance) * (180 / Math.PI)),
                Y: (float)(Math.Atan(difference.Y / difference.X) * (180 / Math.PI)),
                Z: 0f);

            if (difference.X >= 0f) vAngle.Y += 180f;
            if(vAngle.Y > 180f)     vAngle.Y -= 360f;

            return vAngle;
        }

        // Fov between a vector and your viewangles
        public static double operator ~(Vector v1)
        {
            var difference = v1 - g_Engine.GetViewAngles();
            return Math.Sqrt(difference.X * difference.X + difference.Y * difference.Y);
        }

        public static Vector operator *(Vector v1, Vector v2) => new Vector(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        public static Vector operator /(Vector v1, Vector v2) => new Vector(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);

        public static Vector Zero { get => new Vector(0); }
        public double Length { get => Math.Sqrt(X * X + Y * Y + Z * Z); }

        public override string ToString() => string.Format("X:{0} Y:{1} Z:{2}", X, Y, Z);

        public void Clamp()
        {
            if (X > 89.0f && X <= 180.0f) X = 89.0f;
            while (X > 180f)    X -= 360f;
            while (X < -89.0f)  X =- 89.0f;
            while (Y > 180f)    Y -= 360f;
            while (Y < -180f)   Y += 360f;
            Z = 0;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NativeColor
    {
        public static implicit operator NativeColor(Color clr) => new NativeColor(clr.R, clr.G, clr.B, 255);

        public NativeColor(int R, int G, int B, int A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public int R, G, B, A;
    }
}
