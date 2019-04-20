using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Providers.FourierTransform;
using System.Windows.Forms;
using WaveViewer.MyControl;
using WaveViewer.Util;
using Complex = System.Numerics.Complex;
using System.Threading;

namespace WaveViewer.Forms
{
    public partial class ProgressDlg : Form
    {
        private enum CalculateType
        {
            Spec, SpecSpec, Cepstrum, Error
        }
        private CalculateType type;
        private static IFourierTransformProvider FFT;
        private MySeries sample;
        private MySeries[] spec, answer;
        public ProgressDlg()
        {
            InitializeComponent();
        }
        static ProgressDlg()
        {
            FFT = FourierTransformControl.CreateManaged();
        }
        public static MySeries[] CalculateSpec(MySeries wave)
        {
            ProgressDlg p=new ProgressDlg();
            p.type = CalculateType.Spec;
            p.sample = wave;
            p.ShowDialog();
            return p.answer;
        }
        public static MySeries[] CalculateSpecSpec(MySeries[] spec)
        {
            ProgressDlg p = new ProgressDlg();
            p.type = CalculateType.SpecSpec;
            p.spec = spec;
            p.ShowDialog();
            return p.answer;
        }
        public static MySeries[] CalculateCepstrum(MySeries[] spec)
        {
            ProgressDlg p = new ProgressDlg();
            p.type = CalculateType.Cepstrum;
            p.spec = spec;
            p.ShowDialog();
            return p.answer;
        }

        delegate void SetValueCallback(int value);
        private void SetBarValue(int value)
        {
            if (value == progressBar.Value) return;
            if (this.progressBar.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetBarValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.progressBar.Value = value;
            }
        }

        private void SetLabelValue(int value)
        {
            if (value == progressBar.Value) return;
            if (this.label.InvokeRequired)
            {
                SetValueCallback d = new SetValueCallback(SetLabelValue);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.label.Text = value.ToString() + '%';
            }
        }

        private void ProgressDlg_Shown(object sender, EventArgs e)
        {
            Thread t;
            switch (type)
            {
                case CalculateType.Spec:
                    t = new Thread(new ThreadStart(CalculateSpec));
                    break;
                case CalculateType.SpecSpec:
                    t = new Thread(new ThreadStart(CalculateSpecSpec));
                    break;
                case CalculateType.Cepstrum:
                    t = new Thread(new ThreadStart(CalculateCepstrum));
                    break;
                default:
                    return;
            }
            t.Start();
        }
        private void CalculateSpec()
        {
            answer = new MySeries[sample.end * 2 / Setting.FrameLength - 1];
            Complex[] buff = new Complex[Setting.FrameLength];

            for (int frame = 0; frame < answer.Length; frame++)
            {
                SetLabelValue(frame * 100 / answer.Length);
                SetBarValue(frame * 100 / answer.Length);
                for (int i = 0; i < Setting.FrameLength; i++)
                {
                    buff[i] = sample.data[frame * Setting.FrameLength / 2 + i];
                }
                HammingWindow.Use(buff);
                FFT.Forward(buff, FourierTransformScaling.ForwardScaling);
                answer[frame] = new MySeries();
                answer[frame].begin = (frame + 1) * Setting.FrameLength / 2;
                answer[frame].end = answer[frame].begin + Setting.FrameLength - 1;
                answer[frame].data = new float[Setting.FrameLength];
                for (int i = 0; i < Setting.FrameLength; i++)
                {
                    answer[frame].data[i] = (float)Complex.Abs(buff[i]);
                }
            }
            SetLabelValue(100);
            SetBarValue(100);
            this.Invoke(new Action(this.Close));
        }

        private void CalculateSpecSpec()
        {
            answer = new MySeries[spec.Length];
            Complex[] buff = new Complex[Setting.FrameLength];
            for (int frame = 0; frame < answer.Length; frame++)
            {
                SetLabelValue(frame * 100 / answer.Length);
                SetBarValue(frame * 100 / answer.Length);
                for (int i = 0; i < Setting.FrameLength; i++)
                {
                    buff[i] = spec[frame].data[i];
                }
                FFT.Forward(buff, FourierTransformScaling.ForwardScaling);
                answer[frame] = new MySeries();
                answer[frame].begin = (frame + 1) * Setting.FrameLength / 2;
                answer[frame].end = answer[frame].begin + Setting.FrameLength - 1;
                answer[frame].data = new float[Setting.FrameLength];
                for (int i = 0; i < Setting.FrameLength; i++)
                {
                    answer[frame].data[i] = (float)Complex.Abs(buff[i]);
                }
            }
            SetLabelValue(100);
            SetBarValue(100);
            this.Invoke(new Action(this.Close));
        }

        private void CalculateCepstrum()
        {
            answer = new MySeries[spec.Length];
            Complex[] buff = new Complex[Setting.FrameLength];

            for (int frame = 0; frame < answer.Length; frame++)
            {
                SetLabelValue(frame * 100 / answer.Length);
                SetBarValue(frame * 100 / answer.Length);
                for (int i = 0; i < Setting.FrameLength; i++)
                {
                    buff[i] = Math.Log(1 + spec[frame].data[i]);
                }
                FFT.Backward(buff, FourierTransformScaling.NoScaling);
                answer[frame] = new MySeries();
                answer[frame].begin = (frame + 1) * Setting.FrameLength / 2;
                answer[frame].end = answer[frame].begin + Setting.FrameLength - 1;
                answer[frame].data = new float[Setting.FrameLength];
                for (int i = 0; i < Setting.FrameLength; i++)
                {
                    answer[frame].data[i] = (float)Complex.Abs(buff[i]);
                }
            }
            SetLabelValue(100);
            SetBarValue(100);
            this.Invoke(new Action(this.Close));
        }
    }
}
