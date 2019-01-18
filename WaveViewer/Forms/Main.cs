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
        }
        private void AllMenuInitial(bool isOpen)
        {
            Setting.ShowFrameSeparator = isOpen;
            Setting.ShowWave = isOpen;
            Setting.ShowSpec = false;
            Setting.ShowSpecSpec = false;
            Setting.ShowCepstrum = false;
            帧分隔线toolStripMenuItem.Checked = isOpen;
            波形ToolStripMenuItem.Checked = isOpen;
            频谱ToolStripMenuItem1.Checked = false;
            频谱的频谱ToolStripMenuItem1.Checked = false;
            倒谱ToolStripMenuItem1.Checked = false;

            频谱ToolStripMenuItem.Checked = false;
            频谱的频谱ToolStripMenuItem.Checked = false;
            倒谱ToolStripMenuItem.Checked = false;
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
                myChart1.Datas = _wr.GetData();
                trackBar_move.Maximum = _wr.GetData().Length;
                this.Text = "WaveViewer — " + dlg.SafeFileName;
                AllMenuInitial(true);
                myChart1.Refresh();
            }
        }

        private void 关闭文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myChart1.Clear();
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
                splitContainer1.Size = new Size(this.Width, this.Height - 65);
                myChart1.Size = new Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            myChart1.Size = new Size(splitContainer1.Panel1.Width, splitContainer1.Panel1.Height);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Forms.AboutBox().ShowDialog();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            myChart1.MinX = ((HScrollBar)sender).Value;
            textBox_move.Text = ((HScrollBar)sender).Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            myChart1.MinX = ((TrackBar)sender).Value;
            textBox_move.Text = ((TrackBar)sender).Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float times = (float)Math.Pow(2.0, ((TrackBar)sender).Value / 100.0);
            myChart1.Scale_times = times;
            if (times >= 10.0)
            {
                trackBar_move.SmallChange = 1;
            }
            else
            {
                trackBar_move.SmallChange = (int)(10.0 / times);
            }
            trackBar_move.LargeChange = 5 * trackBar_move.SmallChange;
            textBox_scale.Text = times.ToString("×#0.000");
        }

        private void 波形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowWave = ((ToolStripMenuItem)sender).Checked;
            myChart1.Refresh();
        }

        private void 帧分隔线toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowFrameSeparator = ((ToolStripMenuItem)sender).Checked;
            myChart1.Refresh();
        }

        private void 频谱ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowSpec = ((ToolStripMenuItem)sender).Checked;
            myChart1.Refresh();
        }

        private void 频谱的频谱ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowSpecSpec = ((ToolStripMenuItem)sender).Checked;
            myChart1.Refresh();
        }
        private void 倒谱ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            Setting.ShowCepstrum = ((ToolStripMenuItem)sender).Checked;
            myChart1.Refresh();
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
            myChart1.Refresh();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SingleCheck((ToolStripMenuItem)sender);
            Setting.FrameLength = 512;
            myChart1.Refresh();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            SingleCheck((ToolStripMenuItem)sender);
            Setting.FrameLength = 1024;
            myChart1.Refresh();
        }

        private void 频谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart1.CalculateSpec())
                频谱ToolStripMenuItem.Checked = true;
            else
                MessageBox.Show("请先打开一个波形文件!", "提示");
        }

        private void 频谱的频谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart1.CalculateSpecSpec())
                频谱的频谱ToolStripMenuItem.Checked = true;
            else
                MessageBox.Show("请先计算频谱!", "提示");
        }

        private void 倒谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myChart1.CalculateCepstrum())
                倒谱ToolStripMenuItem.Checked = true;
            else
                MessageBox.Show("请先计算频谱!", "提示");
        }

        private void button_playstop_Click(object sender, EventArgs e)
        {
            if (_wr != null && _wr.GetData() != null)
            {
                if (myChart1.ChooseAreaMin < myChart1.ChooseAreaMax )
                {
                    _player = new PCMPlayer(_wr.GetData(),
                        myChart1.ChooseAreaMin,
                        myChart1.ChooseAreaMax,
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (_player != null)
                _player.Stop();
        }
    }
}
