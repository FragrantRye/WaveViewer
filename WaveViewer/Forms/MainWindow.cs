using System;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WaveViewer.Util;

namespace WaveViewer.Forms
{
    public partial class MainWindow : Form
    {
        private string filePath;
        private WAVReader wr = new WAVReader();
        private PCMPlayer player;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Explore_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "波形文件|*.wav";
            f.ShowDialog();
            TextBox_FilePath.Text = f.FileName;
            button_OK.Enabled = true;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            //开启交互
            button_play.Enabled = true;
            button_stop.Enabled = true;
            numericUpDown_DPI.Enabled = true;
            trackBar_panning.Enabled = true;
            trackBar_scale.Enabled = true;

            ToolStripMenuItem_显示_波形.Checked = true;
            //清理之前的数据
            chart_WAVdata.Series[0].Points.Clear();
            listView_Info.Clear();
            wr.Clear();

            if (!File.Exists(TextBox_FilePath.Text))
            {
                MessageBox.Show("文件不存在，请检查文件路径", "警告");
                return;
            }
            this.filePath = TextBox_FilePath.Text;
            wr.ReadWAVFile(filePath);
            float[] data = wr.GetData();

            // 在chart中显示数据
            // 设置显示范围
            chart_WAVdata.ChartAreas[0].AxisX.Minimum = 0;
            chart_WAVdata.ChartAreas[0].AxisX.Maximum = data.Count();
            
            for (int x = 0; x < data.Count(); x += data.Count() / (int)numericUpDown_DPI.Value)
            {
                chart_WAVdata.Series[0].Points.AddXY(x, data[x]);
            }

            //显示音频信息列表
            this.listView_Info.Columns.Add("属性", 80, HorizontalAlignment.Left);
            this.listView_Info.Columns.Add("值", 115, HorizontalAlignment.Left);

            ListViewItem[] lvi = new ListViewItem[5];
            lvi[0] = new ListViewItem("文件大小");
            lvi[0].SubItems.Add(wr.GetSize().ToString());
            lvi[1] = new ListViewItem("声道数");
            lvi[1].SubItems.Add(wr.GetNum_Channels().ToString());
            lvi[2] = new ListViewItem("采样率");
            lvi[2].SubItems.Add(wr.GetSamplesPerSec().ToString());
            lvi[3] = new ListViewItem("采样深度");
            lvi[3].SubItems.Add(wr.GetBitsPerSample().ToString());
            lvi[4] = new ListViewItem("时间");
            lvi[4].SubItems.Add(Utils.Time2String(data.Count() / (float)wr.GetSamplesPerSec()));

            foreach (ListViewItem i in lvi)
            {
                this.listView_Info.Items.Add(i);
            }

            //滚动条的最大值由音频长度决定
            trackBar_scale.Maximum = (int)Math.Ceiling(100 * Math.Log(wr.GetData().Count() / 20.0, 2.0));
            trackBar_panning.Maximum = 0;
        }

        private void trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            chart_WAVdata.Series[0].ChartType = SeriesChartType.FastLine;
        }
        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            chart_WAVdata.Series[0].ChartType = SeriesChartType.Spline;
        }

        private void trackBar_scale_ValueChanged(object sender, EventArgs e)
        {
            double times = Math.Pow(2.0, trackBar_scale.Value / 100.0);
            label_scale.Text = "放大倍数:" + Convert.ToString((int)times) + "×";
            double AxisXLength = wr.GetData().Length / times;
            trackBar_panning.LargeChange = (int)(AxisXLength / 10.0);
            trackBar_panning.SmallChange = (int)(AxisXLength / 20.0);
            int newMax = (int)(wr.GetData().Length - wr.GetData().Length / times);
            if (trackBar_panning.Value > newMax)
            {
                trackBar_panning.Value = newMax;
                trackBar_panning.Maximum = newMax;
                return;
            }
            trackBar_panning.Maximum = newMax;
            chart_WAVdata.Series[0].Points.Clear();
            chart_WAVdata.ChartAreas[0].AxisX.Maximum = chart_WAVdata.ChartAreas[0].AxisX.Minimum + AxisXLength;
            if (AxisXLength <= (int)numericUpDown_DPI.Value)
            {
                for (int i = (int)chart_WAVdata.ChartAreas[0].AxisX.Minimum; i <= chart_WAVdata.ChartAreas[0].AxisX.Maximum; i++)
                {
                    chart_WAVdata.Series[0].Points.AddXY(i, wr.GetData()[i]);
                }
            }
            else
            {
                for (double i = chart_WAVdata.ChartAreas[0].AxisX.Minimum; i <= chart_WAVdata.ChartAreas[0].AxisX.Maximum; i += AxisXLength / (double)numericUpDown_DPI.Value)
                {
                    chart_WAVdata.Series[0].Points.AddXY((int)i, wr.GetData()[(int)i]);
                }
            }
        }

        private void trackBar_panning_ValueChanged(object sender, EventArgs e)
        {
            label_Panning.Text = "图形平移:" + Convert.ToString(trackBar_panning.Value);
            chart_WAVdata.Series[0].Points.Clear();

            double change = trackBar_panning.Value - chart_WAVdata.ChartAreas[0].AxisX.Minimum;
            chart_WAVdata.ChartAreas[0].AxisX.Minimum = trackBar_panning.Value;
            chart_WAVdata.ChartAreas[0].AxisX.Maximum += change;
            double AxisXLength = chart_WAVdata.ChartAreas[0].AxisX.Maximum - chart_WAVdata.ChartAreas[0].AxisX.Minimum;
            if (AxisXLength <= (int)numericUpDown_DPI.Value)
            {
                for (int i = (int)chart_WAVdata.ChartAreas[0].AxisX.Minimum; i <= chart_WAVdata.ChartAreas[0].AxisX.Maximum; i++)
                {
                    chart_WAVdata.Series[0].Points.AddXY(i, wr.GetData()[i]);
                }
            }
            else
            {
                for (double i = chart_WAVdata.ChartAreas[0].AxisX.Minimum; i <= chart_WAVdata.ChartAreas[0].AxisX.Maximum; i += AxisXLength / (double)numericUpDown_DPI.Value)
                {
                    chart_WAVdata.Series[0].Points.AddXY((int)i, wr.GetData()[(int)i]);
                }
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                int w = this.Size.Width;
                int h = this.Size.Height;
                groupBox_trackBars.Size = new Size(w - 40, 124);
                trackBar_scale.Size = new Size(w - 151, 45);
                trackBar_panning.Size = new Size(w - 151, 45);
                chart_WAVdata.Size = new Size(w - 224, h - 252);
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            player = new PCMPlayer(wr.GetData(),
                (int)chart_WAVdata.ChartAreas[0].AxisX.Minimum,
                (int)chart_WAVdata.ChartAreas[0].AxisX.Maximum,
                wr.GetNum_Channels(), wr.GetSamplesPerSec(), (short)wr.GetBitsPerSample());
            player.Play();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void chart_WAVdata_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= chart_WAVdata.Location.X + chart_WAVdata.ChartAreas[0].InnerPlotPosition.X &&
                //e.X <= chart_WAVdata.Location.X + chart_WAVdata.ChartAreas[0].InnerPlotPosition.X + chart_WAVdata.ChartAreas[0].InnerPlotPosition.Width &&
                e.Y >= chart_WAVdata.Location.Y + chart_WAVdata.ChartAreas[0].InnerPlotPosition.Y //&&
                //e.Y <= chart_WAVdata.Location.Y + chart_WAVdata.ChartAreas[0].InnerPlotPosition.Y + chart_WAVdata.ChartAreas[0].InnerPlotPosition.Height
                )
                chart_WAVdata.Cursor = Cursors.Cross;
            else
                chart_WAVdata.Cursor = Cursors.Default;
        }

        private void chart_WAVdata_MouseLeave(object sender, EventArgs e)
        {
            chart_WAVdata.Cursor = Cursors.Default;
        }

        private void numericUpDown_DPI_ValueChanged(object sender, EventArgs e)
        {
            trackBar_panning_ValueChanged(sender, e);
        }

        private void ToolStripMenuItem_计算_频谱_Click(object sender, EventArgs e)
        {
            int begin = (int)chart_WAVdata.ChartAreas[0].AxisX.Minimum;
            int N = (int)chart_WAVdata.ChartAreas[0].AxisX.Maximum - (int)chart_WAVdata.ChartAreas[0].AxisX.Minimum;
            Complex[] fin = new Complex[N];
            Complex[] fout = new Complex[N];
            FFTW plan = new FFTW(fin, fout, FFTW.Sign.FFTW_FORWARD);
            for(int i = 0; i < N; i++)
            {
                fin[i] = wr.GetData()[i + begin];
            }
            plan.Execute();

            float sum = 0, max = Complex.Abs(fout[0]);
            int max_locate=0;
            for (int i = 0; i < N; i++)
            {
                sum += Complex.Abs(fout[i]);
                if (Complex.Abs(fout[i]) > max)
                {
                    max = Complex.Abs(fout[i]);
                    max_locate = i;
                }
            }
            chart_WAVdata.Series[1].Points.Clear();
            try
            {
                if (N <= (int)numericUpDown_DPI.Value)
                {
                    for (int i = begin; i < chart_WAVdata.ChartAreas[0].AxisX.Maximum; i++)
                    {
                        chart_WAVdata.Series[1].Points.AddXY(i, Complex.Abs(fout[i - begin]) / max * 30000.0);
                    }
                }
                else
                {
                    for (double i = chart_WAVdata.ChartAreas[0].AxisX.Minimum; i < chart_WAVdata.ChartAreas[0].AxisX.Maximum; i += N / (double)numericUpDown_DPI.Value)
                    {
                        chart_WAVdata.Series[1].Points.AddXY(i, Complex.Abs(fout[(int)(i - begin)]) / max * 30000.0);
                    }
                }
            }
            catch (IndexOutOfRangeException) { }
            Console.WriteLine(sum / fout.Length);
            Console.WriteLine(44100.0*max_locate / N);
            Console.WriteLine(max);
        }
    }
}
