using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;
using Brush = SharpDX.Direct2D1.Brush;

namespace WaveViewer.MyControl
{
    public partial class MyChart : UserControl
    {
        //波形数据
        private MySeries _wave;
        //频谱以及频谱的频谱数据
        private MySeries[] _spec, _specspec;
        //倒谱数据
        private MySeries[] _cepstrum;
        private int _chosenAreaMin, _chosenAreaMax;
        /// <summary>
        /// 鼠标选择区域的最小值
        /// </summary>
        public int ChooseAreaMin
        {
            get
            {
                return this._chosenAreaMin;
            }
        }
        /// <summary>
        /// 鼠标选择区域的最大值
        /// </summary>
        public int ChooseAreaMax
        {
            get
            {
                return this._chosenAreaMax;
            }
        }
        /// <summary>
        /// 图表区横坐标的最小值
        /// </summary>
        private float _minX;
        /// <summary>
        /// 频谱图位移量
        /// </summary>
        public int SpecMove = 0;
        /// <summary>
        /// 频谱的频谱图位移量
        /// </summary>
        public int SpecSpecMove = 0;
        /// <summary>
        /// 对数频谱图位移量
        /// </summary>
        public int LogSpecMove = 0;
        /// <summary>
        /// 倒谱图位移量
        /// </summary>
        public int CepsMove = 0;
        /// <summary>
        /// 平均每采样点间隔的像素数
        /// </summary>
        private float _scale_times_X;

        private WindowRenderTarget _renderTarget;
        private Point _mouseStartPoint, _mouseEndPoint;
        private bool _isMouseMoving = false;
        private SolidColorBrush _blackBrush, _greenBrush, _blueBrush, _redBrush, _pinkBrush;
        private SharpDX.DirectWrite.TextFormat _blackTextFormat;

        [Description("图表X坐标的最小值")]
        public float MinX
        {
            get
            {
                return _minX;
            }
            set
            {
                _minX = value;
                this.Refresh();
            }
        }
        [Description("缩放（平均每采样点使用几个像素渲染）")]
        public float Scale_times
        {
            get
            {
                return _scale_times_X;
            }
            set
            {
                _scale_times_X = value;
                this.Refresh();
            }
        }
        [Description("波形数据数组")]
        public float[] Datas
        {
            set
            {
                this._wave = new MySeries {data = value, begin = 0, end = value.Length - 1};
            }
        }

        public MyChart()
        {
            InitializeComponent();
            InitRender();
        }
        public void Clear()
        {
            this._wave = null;
            this._spec = null;
            this._specspec = null;
            this._cepstrum = null;
            this.Refresh();
        }

        private void InitRender()
        {
            Factory factory = new Factory(FactoryType.MultiThreaded);
            RenderTargetProperties renderProps = new RenderTargetProperties
            {
                PixelFormat = new PixelFormat(),
                Usage = RenderTargetUsage.None,
                Type = RenderTargetType.Default
            };
            HwndRenderTargetProperties hwndProps = new HwndRenderTargetProperties()
            {
                // 承载控件的句柄。
                Hwnd = renderControl.Handle,
                // 控件的尺寸。
                PixelSize = new Size2(renderControl.ClientSize.Width, renderControl.ClientSize.Height),
                PresentOptions = PresentOptions.None
            };
            _renderTarget = new WindowRenderTarget(factory, renderProps, hwndProps)
            {
                AntialiasMode = AntialiasMode.PerPrimitive
            };

            _blackBrush = new SolidColorBrush(_renderTarget, new RawColor4(0.0f, 0.0f, 0.0f, 0.9f));    //纯种黑
            _blueBrush = new SolidColorBrush(_renderTarget, new RawColor4(0.3f, 0.6f, 1.0f, 0.5f));     //天依蓝
            _greenBrush = new SolidColorBrush(_renderTarget, new RawColor4(0.0f, 0.8f, 0.0f, 0.9f));    //原谅绿
            _redBrush = new SolidColorBrush(_renderTarget, new RawColor4(0.8f, 0.0f, 0.0f, 0.9f));      //姨妈红
            _pinkBrush = new SolidColorBrush(_renderTarget, new RawColor4(1.0f, 0.3f, 0.3f, 0.9f));     //少女粉

            SharpDX.DirectWrite.Factory fac = new SharpDX.DirectWrite.Factory();
            _blackTextFormat = new SharpDX.DirectWrite.TextFormat(fac, "微软雅黑", 10.0f);//一个阿拉伯数字宽度6像素吧（大概....）
        }

        RawVector2 getPixelPoint(float x, float y, float moveY, float scale)
        {
            return new RawVector2((x - _minX) * _scale_times_X + 40.0f,
                renderControl.ClientSize.Height - 20 - moveY - y * scale);
        }

        private void DrawSeries(MySeries s, Brush brush, float moveY, float scale)
        {
            int begin, end;
            begin = s.begin < this._minX ? (int)this._minX : s.begin;
            float maxX = this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X;
            end = maxX > s.end ? s.end : (int)Math.Ceiling(maxX);
            for (int i = begin + 1; i < end; i++)
            {
                _renderTarget.DrawLine(getPixelPoint(i - 1, s.data[i - s.begin - 1], moveY, scale),
                    getPixelPoint(i, s.data[i - s.begin], moveY, scale),
                    brush, 0.5f);
            }
        }
        private void DrawSeriesHalf(MySeries s, Brush brush, float moveY, float scale)
        {
            int begin, end;
            begin = s.begin < this._minX ? (int)this._minX : s.begin;
            float maxX = this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X;
            end = maxX > s.end ? s.end : (int)Math.Ceiling(maxX);
            for (int i = begin + 1; i < end && i - s.begin <= Setting.FrameLength / 2; i++)
            {
                _renderTarget.DrawLine(getPixelPoint(i - 1, s.data[i - s.begin - 1], moveY, scale),
                    getPixelPoint(i, s.data[i - s.begin], moveY, scale),
                    brush);
            }
        }
        private void DrawSeriesHalfLog(MySeries s, Brush brush, float moveY, float scale)
        {
            int begin, end;
            begin = s.begin < this._minX ? (int)this._minX : s.begin;
            float maxX = this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X;
            end = maxX > s.end ? s.end : (int)Math.Ceiling(maxX);
            for (int i = begin + 1; i < end && i - s.begin <= Setting.FrameLength / 2; i++)
            {
                _renderTarget.DrawLine(getPixelPoint(i - 1, (float)Math.Log10(s.data[i - s.begin - 1]), moveY, scale),
                    getPixelPoint(i, (float)Math.Log10(s.data[i - s.begin]), moveY, scale),
                    brush);
            }
        }

        private void DrawGrid()
        {
            //横线
            _renderTarget.DrawLine(new RawVector2(40, renderControl.ClientSize.Height - 20),
                new RawVector2(renderControl.ClientSize.Width, renderControl.ClientSize.Height - 20), _blackBrush);
            //竖线
            _renderTarget.DrawLine(new RawVector2(40, renderControl.ClientSize.Height - 20),
                new RawVector2(40, 0), _blackBrush);

            var strLen = ((int)(this._minX + (renderControl.ClientSize.Width - 40) / _scale_times_X)).ToString().Length * 6.0f;//字符串长度不会超过这个值
            var interval = (strLen + 6.0f) / _scale_times_X;//留6像素的间隔，确定为采样点分割线的间距
            //计算合适的分度值
            int a = 1, b = 2, c = 5;
            while (true)
            {
                if (a > interval)
                {
                    interval = a;
                    break;
                }
                if (b > interval)
                {
                    interval = b;
                    break;
                }
                if (c > interval)
                {
                    interval = c;
                    break;
                }
                a *= 10;
                b *= 10;
                c *= 10;
            }
            //绘制横坐标分割线和数字
            for (int i = (int)_minX-(int)_minX%(int)interval+(int)interval; i < (int)_minX+(renderControl.ClientSize.Width - 40) / _scale_times_X; i += (int)interval)
            {
                var x = (i-_minX) * _scale_times_X + 40.0f;
                _renderTarget.DrawLine(new RawVector2(x, renderControl.ClientSize.Height - 20),
                    new RawVector2(x, renderControl.ClientSize.Height - 27), _blackBrush, 0.8f);

                _renderTarget.DrawText(i.ToString(), _blackTextFormat, new RawRectangleF(x - strLen / 2, renderControl.ClientSize.Height - 20, x + strLen / 2, renderControl.ClientSize.Height), _blackBrush);
            }
            //左下角分度值标注
            _renderTarget.DrawText(interval.ToString(), _blackTextFormat, new RawRectangleF(40, renderControl.ClientSize.Height - 38, 45 + 6 * interval.ToString().Length, renderControl.ClientSize.Height - 18), _blackBrush);
            //绘制纵坐标分割线和数字
            //0
            _renderTarget.DrawLine(new RawVector2(40, renderControl.ClientSize.Height / 2 - 10),
                new RawVector2(renderControl.ClientSize.Width, renderControl.ClientSize.Height / 2 - 10), _blackBrush);
            _renderTarget.DrawText("0", _blackTextFormat, new RawRectangleF(30, renderControl.ClientSize.Height / 2 - 7, 36, renderControl.ClientSize.Height / 2 - 17), _blackBrush);
            //-10000
            _renderTarget.DrawLine(new RawVector2(40, (renderControl.ClientSize.Height - 20) * 2 / 3),
                new RawVector2(45, (renderControl.ClientSize.Height - 20) * 2 / 3), _blackBrush);
            _renderTarget.DrawText("-10000", _blackTextFormat, new RawRectangleF(1, (renderControl.ClientSize.Height - 20) * 2 / 3 + 3, 36, (renderControl.ClientSize.Height - 20) * 2 / 3 - 7), _blackBrush);
            //-20000
            _renderTarget.DrawLine(new RawVector2(40, (renderControl.ClientSize.Height - 20) * 5 / 6),
                new RawVector2(45, (renderControl.ClientSize.Height - 20) * 5 / 6), _blackBrush);
            _renderTarget.DrawText("-20000", _blackTextFormat, new RawRectangleF(1, (renderControl.ClientSize.Height - 20) * 5 / 6 + 3, 36, (renderControl.ClientSize.Height - 20) * 5 / 6 - 7), _blackBrush);
            //-30000
            _renderTarget.DrawText("-30000", _blackTextFormat, new RawRectangleF(1, renderControl.ClientSize.Height - 17, 36, renderControl.ClientSize.Height - 27), _blackBrush);
            //10000
            _renderTarget.DrawLine(new RawVector2(40, (renderControl.ClientSize.Height - 20) / 3),
                new RawVector2(45, (renderControl.ClientSize.Height - 20) / 3), _blackBrush);
            _renderTarget.DrawText("10000", _blackTextFormat, new RawRectangleF(6, (renderControl.ClientSize.Height - 20) / 3 + 3, 36, (renderControl.ClientSize.Height - 20) / 3 - 7), _blackBrush);
            //20000
            _renderTarget.DrawLine(new RawVector2(40, (renderControl.ClientSize.Height - 20) / 6),
                new RawVector2(45, (renderControl.ClientSize.Height - 20) / 6), _blackBrush);
            _renderTarget.DrawText("20000", _blackTextFormat, new RawRectangleF(6, (renderControl.ClientSize.Height - 20) / 6 + 3, 36, (renderControl.ClientSize.Height - 20) / 6 - 7), _blackBrush);
            //30000
            _renderTarget.DrawText("30000", _blackTextFormat, new RawRectangleF(6, 3, 36, -7), _blackBrush);
        }
        private void DrawWave()
        {
            if (_wave != null)
            {
                DrawSeries(_wave, _blackBrush, renderControl.ClientSize.Height / 2.0f - 10.0f, renderControl.ClientSize.Height / 65535.0f);
            }
        }
        private void DrawFrameSepa()
        {
            if (Setting.FrameLength * _scale_times_X < 10)
                return;
            //相邻两分隔线的间距
            int distance = Setting.FrameLength / 2;
            for (int i = (int)_minX - (int)_minX % distance + distance; i < (int)_minX + (renderControl.ClientSize.Width - 40) / _scale_times_X; i += distance)
            {
                float x = (i - _minX) * _scale_times_X + 40.0f;
                int order = i / distance;
                string orderinary = "No." + order.ToString();
                if (order % 2 == 0)
                {
                    _renderTarget.DrawLine(new RawVector2(x, 0), new RawVector2(x, renderControl.ClientSize.Height - 20), _greenBrush);
                    _renderTarget.DrawText(orderinary, _blackTextFormat,
                        new RawRectangleF(x, 2, x + orderinary.Length * 6, 12), _greenBrush);
                }
                else
                {
                    _renderTarget.DrawLine(new RawVector2(x, 0), new RawVector2(x, renderControl.ClientSize.Height - 20), _pinkBrush);
                    _renderTarget.DrawText(orderinary, _blackTextFormat,
                        new RawRectangleF(x, 2, x + orderinary.Length * 6, 12), _pinkBrush);
                }
            }
        }
        private void DrawSpec()
        {
            if (_spec != null)
            {
                int beginFrame = (int)(this._minX * 2 / Setting.FrameLength);
                int endFrame = (int)((this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X) * 2 / Setting.FrameLength)-1;
                if (beginFrame > 0) beginFrame--;
                try
                {
                    for (int i = beginFrame; i <= endFrame; i++)
                    {
                        if(i%2==0)
                            DrawSeriesHalf(_spec[i], _redBrush, 2*SpecMove, 5e-4f);
                        else
                            DrawSeriesHalf(_spec[i], _greenBrush, 2*SpecMove, 5e-4f);
                    }
                }
                catch (IndexOutOfRangeException) { return; }
            }
        }
        private void DrawSpecSpec()
        {
            if (_specspec != null)
            {
                int beginFrame = (int)(this._minX * 2 / Setting.FrameLength);
                int endFrame = (int)((this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X) * 2 / Setting.FrameLength) - 1;
                if (beginFrame > 0) beginFrame--;
                try
                {
                    for (int i = beginFrame; i <= endFrame; i++)
                    {
                        if (i % 2 == 0)
                            DrawSeriesHalf(_specspec[i], _greenBrush, 50 + 2 * SpecSpecMove, 1e-5f);
                        else
                            DrawSeriesHalf(_specspec[i], _redBrush, 50 + 2 * SpecSpecMove, 1e-5f);
                    }
                }
                catch (IndexOutOfRangeException) { return; }
            }
        }
        private void DrawLogSpec()
        {
            if (_spec != null)
            {
                int beginFrame = (int)(this._minX * 2 / Setting.FrameLength);
                int endFrame = (int)((this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X) * 2 / Setting.FrameLength) - 1;
                if (beginFrame > 0) beginFrame--;
                try
                {
                    for (int i = beginFrame; i <= endFrame; i++)
                    {
                        if (i % 2 == 0)
                            DrawSeriesHalfLog(_spec[i], _greenBrush, 80 + 2 * LogSpecMove, 20);
                        else
                            DrawSeriesHalfLog(_spec[i], _redBrush, 80 + 2 * LogSpecMove, 20);
                    }
                }
                catch (IndexOutOfRangeException) { return; }
            }
        }
        private void DrawCepstrum()
        {
            if (_cepstrum != null)
            {
                int beginFrame = (int)(this._minX * 2 / Setting.FrameLength);
                int endFrame = (int)((this._minX + (renderControl.ClientSize.Width - 40) / this._scale_times_X) * 2 / Setting.FrameLength) - 1;
                if (beginFrame > 0) beginFrame--;
                try
                {
                    for (int i = beginFrame; i <= endFrame; i++)
                    {
                        if (i % 2 == 0)
                            DrawSeriesHalf(_cepstrum[i], _redBrush, 140 + 2 * CepsMove, 2.0f);
                        else
                            DrawSeriesHalf(_cepstrum[i], _greenBrush, 140 + 2 * CepsMove, 2.0f);
                    }
                }
                catch (IndexOutOfRangeException) { return; }
            }
        }

        public bool CalculateSpec()
        {
            if (_wave != null)
            {
                _spec = new MySeries[_wave.end * 2 / Setting.FrameLength - 1];
                Util.Complex[] fin = new Util.Complex[Setting.FrameLength];
                Util.Complex[] fout = new Util.Complex[Setting.FrameLength];
                Util.FFTW plan = new Util.FFTW(fin, fout, Util.FFTW.Sign.FFTW_FORWARD);

                for (int frame = 0; frame < _spec.Length; frame++)
                {
                    for (int i = 0; i < Setting.FrameLength; i++)
                    {
                        fin[i] = _wave.data[frame * Setting.FrameLength / 2 + i];
                    }

                    plan.Execute();
                    _spec[frame] = new MySeries();
                    _spec[frame].begin = (frame + 1) * Setting.FrameLength / 2;
                    _spec[frame].end = _spec[frame].begin + Setting.FrameLength - 1;
                    _spec[frame].data = new float[Setting.FrameLength];
                    for (int i = 0; i < fout.Length; i++)
                    {
                        _spec[frame].data[i] = Util.Complex.Abs(fout[i]);
                    }
                }
                return true;
            }
            return false;
        }
        public bool CalculateSpecSpec()
        {
            if (_spec != null)
            {
                _specspec = new MySeries[_spec.Length];
                Util.Complex[] fin = new Util.Complex[Setting.FrameLength];
                Util.Complex[] fout = new Util.Complex[Setting.FrameLength];
                Util.FFTW plan = new Util.FFTW(fin, fout, Util.FFTW.Sign.FFTW_FORWARD);

                for (int frame = 0; frame < _spec.Length; frame++)
                {
                    for (int i = 0; i < Setting.FrameLength; i++)
                    {
                        fin[i] = _spec[frame].data[i];
                    }

                    plan.Execute();
                    _specspec[frame] = new MySeries();
                    _specspec[frame].begin = (frame + 1) * Setting.FrameLength / 2;
                    _specspec[frame].end = _specspec[frame].begin + Setting.FrameLength - 1;
                    _specspec[frame].data = new float[Setting.FrameLength];
                    for (int i = 0; i < fout.Length; i++)
                    {
                        _specspec[frame].data[i] = Util.Complex.Abs(fout[i]);
                    }
                }
                return true;
            }
            return false;
        }
        public bool CalculateCepstrum()
        {
            if (_spec != null)
            {
                _cepstrum = new MySeries[_spec.Length];
                Util.Complex[] fin = new Util.Complex[Setting.FrameLength];
                Util.Complex[] fout = new Util.Complex[Setting.FrameLength];
                Util.FFTW plan = new Util.FFTW(fin, fout, Util.FFTW.Sign.FFTW_BACKWARD);

                for (int frame = 0; frame < _spec.Length; frame++)
                {
                    for (int i = 0; i < Setting.FrameLength; i++)
                    {
                        fin[i] = 1+(float)Math.Log10(_spec[frame].data[i]);
                    }
                    plan.Execute();
                    _cepstrum[frame] = new MySeries();
                    _cepstrum[frame].begin = (frame + 1) * Setting.FrameLength / 2;
                    _cepstrum[frame].end = _cepstrum[frame].begin + Setting.FrameLength - 1;
                    _cepstrum[frame].data = new float[Setting.FrameLength];
                    _cepstrum[frame].data[0] = 0.0f;
                    for (int i = 1; i < fout.Length; i++)
                    {
                        _cepstrum[frame].data[i] = Util.Complex.Abs(fout[i]);
                    }
                }
                return true;
            }
            return false;
        }

        private void MyChart_Paint(object sender, PaintEventArgs e)
        {
            _renderTarget.BeginDraw();
            _renderTarget.Clear(new RawColor4(1.0f, 1.0f, 1.0f, 1.0f));//用白色清空

            DrawGrid();
            if(Setting.ShowWave)
                DrawWave();
            if(Setting.ShowFrameSeparator)
                DrawFrameSepa();
            if (Setting.ShowSpec)
                DrawSpec();
            if (Setting.ShowSpecSpec)
                DrawSpecSpec();
            if (Setting.ShowLogSpec)
                DrawLogSpec();
            if (Setting.ShowCepstrum)
                DrawCepstrum();

            if (_isMouseMoving)
            {
                RawRectangleF rect = new RawRectangleF
                {
                    Left = Math.Min(_mouseStartPoint.X, _mouseEndPoint.X),
                    Right = Math.Max(_mouseStartPoint.X, _mouseEndPoint.X),
                    Top = Math.Min(_mouseStartPoint.Y, _mouseEndPoint.Y),
                    Bottom = Math.Max(_mouseStartPoint.Y, _mouseEndPoint.Y)
                };
                _renderTarget.FillRectangle(rect, _blueBrush);
            }
            if (_chosenAreaMin < _chosenAreaMax)
            {
                var x = (_chosenAreaMin - _minX) * _scale_times_X + 40.0f;
                if (x > 40 && x < renderControl.ClientSize.Width)
                    _renderTarget.DrawLine(new RawVector2(x, 0),
                        new RawVector2(x, this.Height), _blueBrush, 2);
                x = (_chosenAreaMax - _minX) * _scale_times_X + 40.0f;
                if (x > 40 && x < renderControl.ClientSize.Width)
                    _renderTarget.DrawLine(new RawVector2(x, 0),
                        new RawVector2(x, this.Height), _blueBrush, 2);
            }
            _renderTarget.EndDraw();
        }
        
        private void MyChart_Layout(object sender, LayoutEventArgs e)
        {
            if (this != null && _renderTarget != null)
            {
                try
                {
                    _renderTarget.Resize(new Size2(this.Width, this.Height));
                    renderControl.Height = this.Height;
                    renderControl.Width = this.Width-8;
                    this.Refresh();
                }
                catch (Exception) { }
            }
        }

        private void renderControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMouseMoving = true;
                _mouseStartPoint.X = e.X;
                _mouseStartPoint.Y = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                _chosenAreaMin = 0;
                _chosenAreaMax = 0;
                this.Refresh();
            }
        }

        private void renderControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isMouseMoving)
            {
                _mouseEndPoint.X = e.X;
                _mouseEndPoint.Y = e.Y;
                this.Refresh();
            }
        }

        private void renderControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _isMouseMoving = false;
            _chosenAreaMin = (int)(this._minX + (Math.Min(_mouseStartPoint.X, _mouseEndPoint.X) - 40) / this._scale_times_X);
            _chosenAreaMax = (int)(this._minX + Math.Ceiling((Math.Max(_mouseStartPoint.X, _mouseEndPoint.X) - 40) / this._scale_times_X));
            if (_wave != null)
            {
                if (_chosenAreaMin < 0)
                    _chosenAreaMin = 0;
                if (_chosenAreaMax > _wave.data.Length)
                    _chosenAreaMax = _wave.data.Length;
            }
            this.Refresh();
        }
    }
}
