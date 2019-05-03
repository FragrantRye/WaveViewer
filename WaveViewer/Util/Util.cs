using System;

namespace WaveViewer.Util
{
    /// <summary>
    /// 实用工具
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// 返回 00:00:00.00 格式表示的时间的字符串
        /// </summary>
        /// <param name="duration">以秒为单位的时间长度</param>
        /// <returns></returns>
        public static string Time2String(float duration)
        {
            string timeFormat = "";

            int Int32Duration = (int)duration;
            if (Int32Duration / 3600 < 10)
            {
                timeFormat += "0";
            }
            timeFormat += Convert.ToString(Int32Duration / 3600);
            timeFormat += ":";
            Int32Duration %= 3600;
            if (Int32Duration / 60 < 10)
            {
                timeFormat += "0";
            }
            timeFormat += Convert.ToString(Int32Duration / 60);
            timeFormat += ":";
            Int32Duration %= 60;
            if (Int32Duration < 10)
            {
                timeFormat += "0";
            }
            timeFormat += Convert.ToString(Int32Duration);
            timeFormat += ".";
            timeFormat += Convert.ToString((int)((duration - (int)duration) * 100.0f));
            return timeFormat;
        }

        /// <summary>
        /// 数字节数组转换为int
        /// </summary>
        /// <param name="bytArray"></param>
        /// <returns></returns>
        public static int bytArray2Int(byte[] bytArray)
        {
            return bytArray[0] | (bytArray[1] << 8) | (bytArray[2] << 16) | (bytArray[3] << 24);
        }


        /// <summary>
        /// 将字节数组转换为字符串
        /// </summary>
        /// <param name="bts"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string getString(byte[] bts, int len)
        {
            char[] tmp = new char[len];
            for (int i = 0; i < len; i++)
            {
                tmp[i] = (char)bts[i];
            }
            return new string(tmp);
        }

        /// <summary>
        /// 组成4个元素的字节数组
        /// </summary>
        /// <param name="bt"></param>
        /// <returns></returns>
        public static byte[] composeByteArray(byte[] bt)
        {
            byte[] tmptag = new byte[4] { 0, 0, 0, 0 };
            tmptag[0] = bt[0];
            tmptag[1] = bt[1];
            return tmptag;
        }
    }
}
