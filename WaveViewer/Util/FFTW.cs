using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WaveViewer.Util
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Complex
    {
        [FieldOffset(0)] private float real;
        [FieldOffset(4)] private float imag;

        public static float Abs(Complex c)
        {
            return (float)Math.Sqrt(c.real * c.real + c.imag * c.imag);
        }
        
        //隐式转换，将Complex转为float
        public static implicit operator float(Complex source)
        {
            return source.real;
        }
        //隐式转换，将float转换为Complex
        public static implicit operator Complex(float source)
        {
            Complex tar = new Complex();
            tar.real = source;
            tar.imag = 0.0f;
            return tar;
        }
        public float Real
        {
            get
            {
                return this.real;
            }
            set
            {
                this.real = value;
            }
        }
        public float Imag
        {
            get
            {
                return this.imag;
            }
            set
            {
                this.imag = value;
            }
        }

        public override string ToString()
        {
            return "(" + this.real + ", " + this.imag + ")";
        }
    }

    class FFTW
    {
        public enum Sign
        {
            FFTW_FORWARD = -1,
            FFTW_BACKWARD = 1
        };

        private IntPtr plan;

        public FFTW(float[] fft_in, Complex[] fft_out)
            : this(fft_in.Length, fft_in, fft_out) { }
        public FFTW(int n, float[] fft_in, Complex[] fft_out)
        {
            GCHandle hin = GCHandle.Alloc(fft_in, GCHandleType.Pinned);
            GCHandle hout = GCHandle.Alloc(fft_out, GCHandleType.Pinned);
            this.plan = fftwf_plan_dft_r2c_1d(n, hin.AddrOfPinnedObject(), hout.AddrOfPinnedObject(), 0);
        }

        public FFTW(Complex[] fft_in, float[] fft_out)
            : this(fft_in.Length, fft_in, fft_out) { }
        public FFTW(int n, Complex[] fft_in, float[] fft_out)
        {
            GCHandle hin = GCHandle.Alloc(fft_in, GCHandleType.Pinned);
            GCHandle hout = GCHandle.Alloc(fft_out, GCHandleType.Pinned);
            this.plan = fftwf_plan_dft_c2r_1d(n, hin.AddrOfPinnedObject(), hout.AddrOfPinnedObject(), 0);
        }

        public FFTW(Complex[] fft_in, Complex[] fft_out, Sign sign)
            : this(fft_in.Length, fft_in, fft_out, sign) { }
        public FFTW(int n, Complex[] fft_in, Complex[] fft_out, Sign sign)
        {
            GCHandle hin = GCHandle.Alloc(fft_in, GCHandleType.Pinned);
            GCHandle hout = GCHandle.Alloc(fft_out, GCHandleType.Pinned);
            this.plan = fftwf_plan_dft_1d(n, hin.AddrOfPinnedObject(), hout.AddrOfPinnedObject(), (int)sign, 0);
        }
        ~FFTW()
        {
            fftwf_destroy_plan(this.plan);
        }
        public void Execute()
        {
            fftwf_execute(this.plan);
        }

        #region DLL导入函数
        [DllImport("libfftw3f-3.dll",
        EntryPoint = "fftwf_execute", ExactSpelling = true,
        CallingConvention = CallingConvention.Cdecl)]
        private static extern void fftwf_execute(IntPtr plan);

        [DllImport("libfftw3f-3.dll",
        EntryPoint = "fftwf_plan_dft_1d", ExactSpelling = true,
        CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr fftwf_plan_dft_1d(int n, IntPtr fin, IntPtr fout, int sign, uint flags);

        [DllImport("libfftw3f-3.dll",
        EntryPoint = "fftwf_destroy_plan", ExactSpelling = true,
        CallingConvention = CallingConvention.Cdecl)]
        private static extern void fftwf_destroy_plan(IntPtr plan);

        [DllImport("libfftw3f-3.dll",
        EntryPoint = "fftwf_plan_dft_r2c_1d", ExactSpelling = true,
        CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr fftwf_plan_dft_r2c_1d(int n, IntPtr fin, IntPtr fout, uint flags);

        [DllImport("libfftw3f-3.dll",
        EntryPoint = "fftwf_plan_dft_c2r_1d", ExactSpelling = true,
        CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr fftwf_plan_dft_c2r_1d(int n, IntPtr fin, IntPtr fout, uint flags);
        #endregion
    }
}
