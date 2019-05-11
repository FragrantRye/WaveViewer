using System;
using System.Drawing;
using System.Windows.Forms;
using WaveViewer.Util;

namespace WaveViewer.Forms
{
    public partial class Main : Form
    {
        private WAVReader _wr;
        private PCMPlayer _player;

        public Main()
        {
            InitializeComponent();
            Setting.FrameLength = 512;
            toolStripMenuItem5.Checked = true;
            myChart.specFinish += () => { if(!频谱ToolStripMenuItem1.Checked) 频谱ToolStripMenuItem1_Click(频谱ToolStripMenuItem1, null); };
            myChart.specspecFinish += () => { if (!频谱的频谱ToolStripMenuItem1.Checked) 频谱的频谱ToolStripMenuItem1_Click(频谱的频谱ToolStripMenuItem1, null); };
            myChart.cepstrumFinish += () => { if (!倒谱ToolStripMenuItem1.Checked) 倒谱ToolStripMenuItem1_Click(倒谱ToolStripMenuItem1, null); };
            myChart.chooseChanged += ChooseAreaChange;
        }
        private void AllMenuInitial(bool isOpen)
        {
            Setting.ShowFrameSeparator = isOpen;
            Setting.ShowWave = isOpen;
            Setting.ShowSpec = false;
            Setting.ShowSpecSpec = false;
            Setting.ShowLogSpec = false;
            Setting.ShowCepstrum = false;
            帧分隔线toolStripMenuItem.Checked = isOpen;
            波形ToolStripMenuItem.Checked = isOpen;
            频谱ToolStripMenuItem1.Checked = false;
            频谱的频谱ToolStripMenuItem1.Checked = false;
            对数频谱ToolStripMenuItem.Checked = false;
            倒谱ToolStripMenuItem1.Checked = false;

            频谱ToolStripMenuItem.Checked = false;
            频谱的频谱ToolStripMenuItem.Checked = false;
            倒谱ToolStripMenuItem.Checked = false;
            识别基音频率ToolStripMenuItem.Checked = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.GC.Collect();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "波形文件|*.wav";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _wr = new WAVReader();
                _wr.ReadWAVFile(dlg.FileName);
                关闭文件ToolStripMenuItem.Enabled = true;
                myChart.Datas = _wr.GetData();
                myChart.sample_frequent = _wr.GetSamplesPerSec();
                trackBar_move.Maximum = _wr.GetData().Length;
                this.Text = "WaveViewer — " + dlg.SafeFileName;
                AllMenuInitial(true);
                myChart.Refresh();
            }
        }

        private void 关闭文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myChart.Clear();
            _wr.Clear();
            关闭文件ToolStripMenuItem.Enabled = false;
            this.Text = "WaveViewer";
            AllMenuInitial(false);
            System.GC.Collect();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void Main_Layout(object sender, LayoutEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                trackBar_move.Width = trackBar_scale.Width = this.Width - 402;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            myChart.Size = new Size(splitContainer.Panel1.Width, splitContainer.Panel1.Height);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.AboutBox().ShowDialog();
        }

        private void trackBar_move_Scroll(object sender, EventArgs e)
        {
            myChart.MinX = ((TrackBar)sender).Value;
            textBox_move.Text = ((TrackBar)sender).Value.ToString();
        }

        private void trackBar_scale_Scroll(object sender, EventArgs e)
        {
            var times = (float)Math.Pow(2.0, ((TrackBar)sender).Value / 100.0);
            myChart.Scale_times = times;
            if (times >= 10.0f)
            {
                trackBar_move.SmallChange = 1;
            }
            else
            {
                trackBar_move.SmallChange = (int)(10.0f / times);
            }
            trackBar_move.LargeChange = 5 * trackBar_move.SmallChange;
            textBox_scale.Text = times.ToString("#0.000");
        }

        private void 波形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowWave = ((ToolStripMenuItem)sender).Checked;
            myChart.Refresh();
        }

        private void 帧分隔线toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowFrameSeparator = ((ToolStripMenuItem)sender).Checked;
            myChart.Refresh();
        }

        private void 频谱ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowSpec = ((ToolStripMenuItem)sender).Checked;
            myChart.Refresh();
        }

        private void 频谱的频谱ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowSpecSpec = ((ToolStripMenuItem)sender).Checked;
            myChart.Refresh();
        }

        private void 对数频谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowLogSpec = ((ToolStripMenuItem)sender).Checked;
            myChart.Refresh();
        }

        private void 倒谱ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowCepstrum = ((ToolStripMenuItem)sender).Checked;
            myChart.Refresh();
        }

        private void SingleCheck(ToolStripMenuItem sender)
        {
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            自定义ToolStripMenuItem1.Checked = false;
            sender.Checked = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SingleCheck((ToolStripMenuItem)sender);
            Setting.FrameLength = 256;
            myChart.Refresh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SingleCheck((ToolStripMenuItem)sender);
            Setting.FrameLength = 512;
            myChart.Refresh();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SingleCheck((ToolStripMenuItem)sender);
            Setting.FrameLength = 1024;
            myChart.Refresh();
        }

        private void 频谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart.CalculateSpec())
                频谱ToolStripMenuItem.Checked = true;
            else
                MessageBox.Show("请先打开一个波形文件!", "提示");
        }

        private void 频谱的频谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart.CalculateSpecSpec())
                频谱的频谱ToolStripMenuItem.Checked = true;
            else
                MessageBox.Show("请先计算频谱!", "提示");
        }

        private void 倒谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart.CalculateCepstrum())
                倒谱ToolStripMenuItem.Checked = true;
            else
                MessageBox.Show("请先计算频谱!", "提示");
        }

        private void 识别基音频率ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart.CalculateFrequent())
            {
                识别基音频率ToolStripMenuItem.Checked = true;
                myChart.Refresh();
            }
            else
                MessageBox.Show("请先计算倒谱!", "提示");
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (_wr != null && _wr.GetData() != null)
            {
                if (myChart.ChooseAreaMin < myChart.ChooseAreaMax )
                {
                    _player = new PCMPlayer(_wr.GetData(),
                        myChart.ChooseAreaMin,
                        myChart.ChooseAreaMax,
                        _wr.GetNum_Channels(), _wr.GetSamplesPerSec(), (short)_wr.GetBitsPerSample());
                }
                else
                {
                    _player = new PCMPlayer(_wr.GetData(),
                        0,
                        _wr.GetData().Length,
                        _wr.GetNum_Channels(), _wr.GetSamplesPerSec(), (short)_wr.GetBitsPerSample());
                }
                _player.Play();
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            _player?.Stop();
        }

        private void textBox_move_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            if (!int.TryParse(((TextBox) sender).Text, out var value))
                value = 0;
            if (value >= trackBar_move.Maximum)
                value = trackBar_move.Maximum;
            if (value <= trackBar_move.Minimum)
                value = trackBar_move.Minimum;
            trackBar_move.Value = value;
            trackBar_move.Focus();
            trackBar_move_Scroll(trackBar_move, null);
        }

        private void textBox_scale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue != 13) return;
            if (!double.TryParse(((TextBox) sender).Text, out var times))
                times = 1.0f;
            var value = (int) (100 * Math.Log(times, 2.0));
            if (value >= trackBar_scale.Maximum)
                value = trackBar_scale.Maximum;
            if (value <= trackBar_scale.Minimum)
                value = trackBar_scale.Minimum;
            trackBar_scale.Value = value;
            trackBar_scale.Focus();
            trackBar_scale_Scroll(trackBar_scale, null);
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            myChart.SpecMove = ((TrackBar)sender).Value;
            myChart.Refresh();
        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            myChart.SpecSpecMove = ((TrackBar)sender).Value;
            myChart.Refresh();
        }

        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            myChart.LogSpecMove = ((TrackBar)sender).Value;
            myChart.Refresh();
        }

        private void TrackBar4_ValueChanged(object sender, EventArgs e)
        {
            myChart.CepsMove = ((TrackBar)sender).Value;
            myChart.Refresh();
        }

        private void ChooseAreaChange(int length)
        {
            toolStripStatusLabel1.Text = "选择了" + length.ToString() + "个采样点";
            if (_wr != null)
                toolStripStatusLabel2.Text = "时长约" + ((double)length / _wr.GetSamplesPerSec()).ToString("0.000") + "s";
        }
    }
}
