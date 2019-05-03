using System.IO;
using System.Media;

namespace WaveViewer.Util
{
    public class PCMPlayer
    {
        
        private MemoryStream ms;
        private SoundPlayer sp;
        private byte[] WAVhead = { 0x52, 0x49, 0x46, 0x46,//RIFF
                                         0,    0,    0,    0,//size
                                      0x57, 0x41, 0x56, 0x45,//WAVE
                                      0x66, 0x6d, 0x74, 0x20,//fmt 
                                      0x10,    0,    0,    0,//fmt_size
                                      0x01,    0,    0,    0,//formattag, numchannels
                                         0,    0,    0,    0,//samplespersec
                                         0,    0,    0,    0,//avgbytespersec
                                      0x02,    0,    0,    0,//blockalign, bitspersample
                                      0x64, 0x61, 0x74 ,0x61,//data
                                         0,    0,    0,    0 //data_size
        };
        public PCMPlayer(float[] data, int begin, int end, int numchannels, int samplespersec, short bitspersample)
        {
            WAVhead[22] = (byte)numchannels;
            WAVhead[24] = (byte)(samplespersec & 0xff);
            WAVhead[25] = (byte)((samplespersec >> 8) & 0xff);
            WAVhead[26] = (byte)((samplespersec >> 16) & 0xff);
            WAVhead[27] = (byte)((samplespersec >> 24) & 0xff);
            int avgbytespersec = bitspersample / 8 * samplespersec * numchannels;
            WAVhead[28] = (byte)(avgbytespersec & 0xff);
            WAVhead[29] = (byte)((avgbytespersec >> 8) & 0xff);
            WAVhead[30] = (byte)((avgbytespersec >> 16) & 0xff);
            WAVhead[31] = (byte)((avgbytespersec >> 24) & 0xff);
            WAVhead[34] = (byte)(bitspersample & 0xff);
            WAVhead[35] = (byte)((bitspersample >> 8) & 0xff);
            int data_size = (end - begin + 1) * bitspersample / 8;
            WAVhead[40] = (byte)(data_size & 0xff);
            WAVhead[41] = (byte)((data_size >> 8) & 0xff);
            WAVhead[42] = (byte)((data_size >> 16) & 0xff);
            WAVhead[43] = (byte)((data_size >> 24) & 0xff);
            int size = data_size + 36;
            WAVhead[4] = (byte)(size & 0xff);
            WAVhead[5] = (byte)((size >> 8) & 0xff);
            WAVhead[6] = (byte)((size >> 16) & 0xff);
            WAVhead[7] = (byte)((size >> 24) & 0xff);

            ms = new MemoryStream(bitspersample / 8 * (end - begin + 1) + 44);

            foreach (byte i in WAVhead)
            {
                ms.WriteByte(i);
            }
            if (bitspersample == 8)
            {
                for (int i = begin; i <= end; i++)
                {
                    ms.WriteByte((byte)data[i]);
                }
            }
            else
            {
                short temp;
                for (int i = begin; i < end; i++)
                {
                    temp = (short)data[i];
                    ms.WriteByte((byte)(temp & 0xff));
                    ms.WriteByte((byte)((temp >> 8) & 0xff));
                }
            }
            ms.Seek(0, SeekOrigin.Begin);
            sp = new SoundPlayer(ms);
        }

        public void Play()
        {
            sp.Load();
            sp.Play();
        }
        public void Stop()
        {
            sp.Stop();
            sp.Dispose();
        }
    }
}