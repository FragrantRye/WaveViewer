using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Complex = System.Numerics.Complex;

namespace WaveViewer.Util
{
    public class HammingWindow
    {
        private static float[] scall_factor=new float[1024];
        static HammingWindow()
        {
            for (int i = 0; i < 1024; i++)
                scall_factor[i] = (float)(0.54 - 0.46 * Math.Cos(2 * Math.PI * i / 1023));
        }
        public static void Use(float[] sample)
        {
            int step = 1024 / sample.Length;
            for (int i = 0, j = 0; i < sample.Length; i++, j += step)
            {
                sample[i] *= scall_factor[j];
            }
        }
        public static void Use(Complex[] sample)
        {
            int step = 1024 / sample.Length;
            for (int i = 0, j = 0; i < sample.Length; i++, j += step)
            {
                sample[i] *= scall_factor[j];
            }
        }

    }
}
