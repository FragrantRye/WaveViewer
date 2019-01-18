using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WaveViewer.Util
{
    /// <summary>
    /// 读取wav文件的基本信息和数据
    /// </summary>
    public class WAVReader
    {
        #region RIFF WAVE Chunk
        private string Id; //文件标识
        private double Size;  //文件大小
        private string Type; //文件类型
        #endregion

        #region Format Chunk
        private string formatId;
        private double formatSize;      //数值为16或18，18则最后又附加信息
        private int formatTag;
        private int num_Channels;       //声道数目，1--单声道；2--双声道
        private int SamplesPerSec;      //采样率
        private int AvgBytesPerSec;     //每秒所需字节数 
        private int BlockAlign;         //数据块对齐单位(每个采样需要的字节数) 
        private int BitsPerSample;      //每个采样需要的bit数
        private string additionalInfo;  //附加信息（可选，通过Size来判断有无）
                                        /*
                                         * 以'fmt'作为标示。一般情况下Size为16，此时最后附加信息没有；
                                         * 如果为18则最后多了2个字节的附加信息。
                                         * 主要由一些软件制成的wav格式中含有该2个字节的附加信息
                                         */
        #endregion

        #region Fact Chunk(可选)
        /*
        * Fact Chunk是可选字段，一般当wav文件由某些软件转化而成，则包含该Chunk。
        */
        private string factId;
        private int factSize;
        private string factData;
        #endregion

        #region Data Chunk
        private string dataId;
        private int dataSize;
        private float[] wavdata;   //默认为单声道,采用double类型是为了方便傅里叶变换
        #endregion

        #region API
        public string GetId() { return Id; }       //文件标识
        public double GetSize() { return Size; }      //文件大小
        public string GetWavType() { return Type; }     //文件类型
        public string GetFormatId() { return formatId; }
        public double GetFormatSize() { return formatSize; }            //数值为16或18，18则最后又附加信息
        public int GetFormatTag() { return formatTag; }
        public int GetNum_Channels() { return num_Channels; }           //声道数目，1--单声道；2--双声道
        public int GetSamplesPerSec() { return SamplesPerSec; }         //采样率
        public int GetAvgBytesPerSec() { return AvgBytesPerSec; }       //每秒所需字节数 
        public int GetBlockAlign() { return BlockAlign; }               //数据块对齐单位(每个采样需要的字节数) 
        public int GetBitsPerSample() { return BitsPerSample; }         //每个采样需要的bit数
        public string GetDataId() { return dataId; }
        public int GetDataSize() { return dataSize; }                   //数据所占的字节数
        public float[] GetData() { return wavdata; }               //wav数据

        #endregion

        public void Clear()
        {
            Size = formatSize = factSize = dataSize = 0;
            wavdata = null;
        }

        /// <summary>
        /// 读取波形文件并显示
        /// </summary>
        /// <param name="filePath">wav文件的路径</param>
        public void ReadWAVFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new Exception("文件不存在");
            byte[] id = new byte[4];
            byte[] size = new byte[4];
            byte[] type = new byte[4];

            byte[] formatid = new byte[4];
            byte[] formatsize = new byte[4];
            byte[] formattag = new byte[2];
            byte[] numchannels = new byte[2];
            byte[] samplespersec = new byte[4];
            byte[] avgbytespersec = new byte[4];
            byte[] blockalign = new byte[2];
            byte[] bitspersample = new byte[2];
            byte[] additionalinfo = new byte[2];    //可选

            byte[] factid = new byte[4];
            byte[] factsize = new byte[4];
            byte[] factdata = new byte[4];

            byte[] dataid = new byte[4];
            byte[] datasize = new byte[4];


            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.UTF8))
                {
                    #region  RIFF WAVE Chunk
                    br.Read(id, 0, 4);
                    br.Read(size, 0, 4);
                    br.Read(type, 0, 4);


                    this.Id = Utils.getString(id, 4);
                    long longsize = Utils.bytArray2Int(size);//十六进制转为十进制
                    this.Size = longsize * 1.0;
                    this.Type = Utils.getString(type, 4);
                    #endregion

                    #region Format Chunk
                    br.Read(formatid, 0, 4);
                    br.Read(formatsize, 0, 4);
                    br.Read(formattag, 0, 2);
                    br.Read(numchannels, 0, 2);
                    br.Read(samplespersec, 0, 4);
                    br.Read(avgbytespersec, 0, 4);
                    br.Read(blockalign, 0, 2);
                    br.Read(bitspersample, 0, 2);
                    if (Utils.getString(formatsize, 2) == "18")
                    {
                        br.Read(additionalinfo, 0, 2);
                        this.additionalInfo = Utils.getString(additionalinfo, 2);  //附加信息
                    }

                    this.formatId = Utils.getString(formatid, 4);

                    this.formatSize = Utils.bytArray2Int(formatsize);

                    byte[] tmptag = Utils.composeByteArray(formattag);
                    this.formatTag = Utils.bytArray2Int(tmptag);

                    byte[] tmpchanels = Utils.composeByteArray(numchannels);
                    this.num_Channels = Utils.bytArray2Int(tmpchanels);                //声道数目，1--单声道；2--双声道

                    this.SamplesPerSec = Utils.bytArray2Int(samplespersec);            //采样率

                    this.AvgBytesPerSec = Utils.bytArray2Int(avgbytespersec);          //每秒所需字节数   

                    byte[] tmpblockalign = Utils.composeByteArray(blockalign);
                    this.BlockAlign = Utils.bytArray2Int(tmpblockalign);              //数据块对齐单位(每个采样需要的字节数)

                    byte[] tmpbitspersample = Utils.composeByteArray(bitspersample);
                    this.BitsPerSample = Utils.bytArray2Int(tmpbitspersample);        // 每个采样需要的bit数     
                    #endregion

                    #region  Fact Chunk
                    //byte[] verifyFactChunk = new byte[2];
                    //br.Read(verifyFactChunk, 0, 2);
                    //string test = getString(verifyFactChunk, 2);
                    //if (getString(verifyFactChunk, 2) == "fa")
                    //{
                    //    byte[] halffactId = new byte[2];
                    //    br.Read(halffactId, 0, 2);

                    //    byte[] factchunkid = new byte[4];
                    //    for (int i = 0; i < 2; i++)
                    //    {
                    //        factchunkid[i] = verifyFactChunk[i];
                    //        factchunkid[i + 2] = halffactId[i];
                    //    }

                    //    this.factId = getString(factchunkid, 4);

                    //    br.Read(factsize, 0, 4);
                    //    this.factSize = bytArray2Int(factsize);

                    //    br.Read(factdata, 0, 4);
                    //    this.factData = getString(factdata, 4);
                    //}
                    #endregion

                    #region Data Chunk

                    byte[] dt_id = new byte[4];
                    while (true)
                    {
                        br.Read(dt_id, 0, 4);
                        if (Utils.getString(dt_id, 4) == "data")
                        {
                            break;
                        }
                        fs.Seek(-3, SeekOrigin.Current);
                    }
                    this.dataId = Utils.getString(dt_id, 4);

                    br.Read(datasize, 0, 4);

                    this.dataSize = Utils.bytArray2Int(datasize);

                    if (BitsPerSample == 8)
                    {
                        wavdata = new float[dataSize];
                        for (int i = 0; i < this.dataSize; i++)
                        {
                            byte wavdt = br.ReadByte();
                            wavdata[i] = wavdt;
                            //Console.WriteLine(wavdt);
                        }
                    }
                    else if (BitsPerSample == 16)
                    {
                        wavdata = new float[dataSize / 2];
                        for (int i = 0; i < this.dataSize / 2; i++)
                        {
                            short wavdt = br.ReadInt16();
                            wavdata[i] = wavdt;
                            //Console.WriteLine(wavdt);
                        }
                    }
                    #endregion
                }
            }
        }

    }
}
