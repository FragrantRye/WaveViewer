using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveViewer
{
    public class Setting
    {
        public static string FileName { get; set; }
        public static bool CalcSpec { get; set; }
        public static bool CalcSpecSpec { get; set; }
        public static bool ShowWave { get; set; }
        public static bool ShowFrameSeparator { get; set; }
        public static bool ShowSpec { get; set; }
        public static bool ShowSpecSpec { get; set; }
        public static bool ShowCepstrum { get; set; }
        public static int FrameLength { get; set; }
        public static int DPI { get; set; }
    }
}
