namespace WaveViewer.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 10000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(50D, -20000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(60D, 10000D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.chart_WAVdata = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar_scale = new System.Windows.Forms.TrackBar();
            this.listView_Info = new System.Windows.Forms.ListView();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.TextBox_FilePath = new System.Windows.Forms.TextBox();
            this.label_FileChoose = new System.Windows.Forms.Label();
            this.button_Explore = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_scale = new System.Windows.Forms.Label();
            this.trackBar_panning = new System.Windows.Forms.TrackBar();
            this.label_Panning = new System.Windows.Forms.Label();
            this.groupBox_trackBars = new System.Windows.Forms.GroupBox();
            this.numericUpDown_DPI = new System.Windows.Forms.NumericUpDown();
            this.groupBox_DPI = new System.Windows.Forms.GroupBox();
            this.label_DPI = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_计算 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_计算_频谱 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_计算_频谱的频谱 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_显示 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_显示_波形 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_显示_频谱 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_显示_频谱的频谱 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart_WAVdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scale)).BeginInit();
            this.groupBox_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_panning)).BeginInit();
            this.groupBox_trackBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DPI)).BeginInit();
            this.groupBox_DPI.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_WAVdata
            // 
            this.chart_WAVdata.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Straight;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.Interval = 10000D;
            chartArea1.AxisY.IntervalOffset = 2768D;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.Maximum = 32767D;
            chartArea1.AxisY.Minimum = -32768D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.IntervalOffset = 2768D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 9F;
            chartArea1.InnerPlotPosition.Y = 2F;
            chartArea1.Name = "ChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 97F;
            this.chart_WAVdata.ChartAreas.Add(chartArea1);
            this.chart_WAVdata.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart_WAVdata.Location = new System.Drawing.Point(0, 70);
            this.chart_WAVdata.MinimumSize = new System.Drawing.Size(660, 363);
            this.chart_WAVdata.Name = "chart_WAVdata";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series_WAVData";
            series1.Points.Add(dataPoint1);
            series1.SmartLabelStyle.Enabled = false;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            series2.Points.Add(dataPoint2);
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint5);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_WAVdata.Series.Add(series1);
            this.chart_WAVdata.Series.Add(series2);
            this.chart_WAVdata.Size = new System.Drawing.Size(660, 363);
            this.chart_WAVdata.TabIndex = 0;
            this.chart_WAVdata.MouseLeave += new System.EventHandler(this.chart_WAVdata_MouseLeave);
            this.chart_WAVdata.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_WAVdata_MouseMove);
            // 
            // trackBar_scale
            // 
            this.trackBar_scale.AutoSize = false;
            this.trackBar_scale.Enabled = false;
            this.trackBar_scale.LargeChange = 2;
            this.trackBar_scale.Location = new System.Drawing.Point(2, 26);
            this.trackBar_scale.Maximum = 150;
            this.trackBar_scale.Name = "trackBar_scale";
            this.trackBar_scale.Size = new System.Drawing.Size(733, 45);
            this.trackBar_scale.TabIndex = 1;
            this.trackBar_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_scale.ValueChanged += new System.EventHandler(this.trackBar_scale_ValueChanged);
            this.trackBar_scale.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseDown);
            this.trackBar_scale.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // listView_Info
            // 
            this.listView_Info.GridLines = true;
            this.listView_Info.Location = new System.Drawing.Point(6, 21);
            this.listView_Info.Name = "listView_Info";
            this.listView_Info.Size = new System.Drawing.Size(200, 133);
            this.listView_Info.TabIndex = 2;
            this.listView_Info.UseCompatibleStateImageBehavior = false;
            this.listView_Info.View = System.Windows.Forms.View.Details;
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_Info.Controls.Add(this.listView_Info);
            this.groupBox_Info.Location = new System.Drawing.Point(640, 201);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(216, 160);
            this.groupBox_Info.TabIndex = 3;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "音频信息";
            // 
            // TextBox_FilePath
            // 
            this.TextBox_FilePath.Location = new System.Drawing.Point(135, 34);
            this.TextBox_FilePath.Name = "TextBox_FilePath";
            this.TextBox_FilePath.Size = new System.Drawing.Size(384, 21);
            this.TextBox_FilePath.TabIndex = 4;
            // 
            // label_FileChoose
            // 
            this.label_FileChoose.AutoSize = true;
            this.label_FileChoose.Location = new System.Drawing.Point(68, 38);
            this.label_FileChoose.Name = "label_FileChoose";
            this.label_FileChoose.Size = new System.Drawing.Size(65, 12);
            this.label_FileChoose.TabIndex = 5;
            this.label_FileChoose.Text = "选择文件：";
            // 
            // button_Explore
            // 
            this.button_Explore.Location = new System.Drawing.Point(525, 33);
            this.button_Explore.Name = "button_Explore";
            this.button_Explore.Size = new System.Drawing.Size(64, 23);
            this.button_Explore.TabIndex = 6;
            this.button_Explore.Text = "浏览...";
            this.button_Explore.UseVisualStyleBackColor = true;
            this.button_Explore.Click += new System.EventHandler(this.button_Explore_Click);
            // 
            // button_OK
            // 
            this.button_OK.Enabled = false;
            this.button_OK.Location = new System.Drawing.Point(595, 33);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(65, 23);
            this.button_OK.TabIndex = 7;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_scale
            // 
            this.label_scale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_scale.AutoSize = true;
            this.label_scale.Location = new System.Drawing.Point(733, 28);
            this.label_scale.Name = "label_scale";
            this.label_scale.Size = new System.Drawing.Size(77, 12);
            this.label_scale.TabIndex = 8;
            this.label_scale.Text = "放大倍数:1×";
            // 
            // trackBar_panning
            // 
            this.trackBar_panning.Enabled = false;
            this.trackBar_panning.Location = new System.Drawing.Point(2, 75);
            this.trackBar_panning.Name = "trackBar_panning";
            this.trackBar_panning.Size = new System.Drawing.Size(733, 45);
            this.trackBar_panning.TabIndex = 9;
            this.trackBar_panning.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_panning.ValueChanged += new System.EventHandler(this.trackBar_panning_ValueChanged);
            this.trackBar_panning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseDown);
            this.trackBar_panning.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // label_Panning
            // 
            this.label_Panning.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_Panning.AutoSize = true;
            this.label_Panning.Location = new System.Drawing.Point(734, 78);
            this.label_Panning.Name = "label_Panning";
            this.label_Panning.Size = new System.Drawing.Size(65, 12);
            this.label_Panning.TabIndex = 10;
            this.label_Panning.Text = "图形平移:0";
            // 
            // groupBox_trackBars
            // 
            this.groupBox_trackBars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_trackBars.Controls.Add(this.trackBar_scale);
            this.groupBox_trackBars.Controls.Add(this.label_Panning);
            this.groupBox_trackBars.Controls.Add(this.trackBar_panning);
            this.groupBox_trackBars.Controls.Add(this.label_scale);
            this.groupBox_trackBars.Location = new System.Drawing.Point(12, 439);
            this.groupBox_trackBars.Name = "groupBox_trackBars";
            this.groupBox_trackBars.Size = new System.Drawing.Size(844, 124);
            this.groupBox_trackBars.TabIndex = 11;
            this.groupBox_trackBars.TabStop = false;
            this.groupBox_trackBars.Text = "图像缩放";
            // 
            // numericUpDown_DPI
            // 
            this.numericUpDown_DPI.Enabled = false;
            this.numericUpDown_DPI.Location = new System.Drawing.Point(111, 20);
            this.numericUpDown_DPI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_DPI.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_DPI.Name = "numericUpDown_DPI";
            this.numericUpDown_DPI.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown_DPI.TabIndex = 12;
            this.numericUpDown_DPI.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_DPI.ValueChanged += new System.EventHandler(this.numericUpDown_DPI_ValueChanged);
            // 
            // groupBox_DPI
            // 
            this.groupBox_DPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_DPI.Controls.Add(this.label_DPI);
            this.groupBox_DPI.Controls.Add(this.numericUpDown_DPI);
            this.groupBox_DPI.Location = new System.Drawing.Point(656, 85);
            this.groupBox_DPI.Name = "groupBox_DPI";
            this.groupBox_DPI.Size = new System.Drawing.Size(190, 60);
            this.groupBox_DPI.TabIndex = 13;
            this.groupBox_DPI.TabStop = false;
            this.groupBox_DPI.Text = "分辨率";
            // 
            // label_DPI
            // 
            this.label_DPI.AutoSize = true;
            this.label_DPI.Location = new System.Drawing.Point(16, 20);
            this.label_DPI.Name = "label_DPI";
            this.label_DPI.Size = new System.Drawing.Size(89, 24);
            this.label_DPI.TabIndex = 13;
            this.label_DPI.Text = "同时显示的样本\r\n点数的最大值";
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(666, 33);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(56, 23);
            this.button_play.TabIndex = 14;
            this.button_play.Text = "播放";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(728, 33);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(59, 23);
            this.button_stop.TabIndex = 15;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_计算,
            this.toolStripMenuItem_显示});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_计算
            // 
            this.toolStripMenuItem_计算.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_计算_频谱,
            this.ToolStripMenuItem_计算_频谱的频谱});
            this.toolStripMenuItem_计算.Name = "toolStripMenuItem_计算";
            this.toolStripMenuItem_计算.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_计算.Text = "计算";
            // 
            // ToolStripMenuItem_计算_频谱
            // 
            this.ToolStripMenuItem_计算_频谱.Name = "ToolStripMenuItem_计算_频谱";
            this.ToolStripMenuItem_计算_频谱.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_计算_频谱.Text = "频谱";
            this.ToolStripMenuItem_计算_频谱.Click += new System.EventHandler(this.ToolStripMenuItem_计算_频谱_Click);
            // 
            // ToolStripMenuItem_计算_频谱的频谱
            // 
            this.ToolStripMenuItem_计算_频谱的频谱.Name = "ToolStripMenuItem_计算_频谱的频谱";
            this.ToolStripMenuItem_计算_频谱的频谱.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_计算_频谱的频谱.Text = "频谱的频谱";
            // 
            // toolStripMenuItem_显示
            // 
            this.toolStripMenuItem_显示.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_显示_波形,
            this.ToolStripMenuItem_显示_频谱,
            this.ToolStripMenuItem_显示_频谱的频谱});
            this.toolStripMenuItem_显示.Name = "toolStripMenuItem_显示";
            this.toolStripMenuItem_显示.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_显示.Text = "显示";
            // 
            // ToolStripMenuItem_显示_波形
            // 
            this.ToolStripMenuItem_显示_波形.Name = "ToolStripMenuItem_显示_波形";
            this.ToolStripMenuItem_显示_波形.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_显示_波形.Text = "波形";
            // 
            // ToolStripMenuItem_显示_频谱
            // 
            this.ToolStripMenuItem_显示_频谱.Name = "ToolStripMenuItem_显示_频谱";
            this.ToolStripMenuItem_显示_频谱.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_显示_频谱.Text = "频谱";
            // 
            // ToolStripMenuItem_显示_频谱的频谱
            // 
            this.ToolStripMenuItem_显示_频谱的频谱.Name = "ToolStripMenuItem_显示_频谱的频谱";
            this.ToolStripMenuItem_显示_频谱的频谱.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_显示_频谱的频谱.Text = "频谱的频谱";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(868, 576);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.groupBox_DPI);
            this.Controls.Add(this.groupBox_trackBars);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Explore);
            this.Controls.Add(this.label_FileChoose);
            this.Controls.Add(this.TextBox_FilePath);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.chart_WAVdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(884, 615);
            this.Name = "MainWindow";
            this.Text = "音频波形查看器";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart_WAVdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scale)).EndInit();
            this.groupBox_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_panning)).EndInit();
            this.groupBox_trackBars.ResumeLayout(false);
            this.groupBox_trackBars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DPI)).EndInit();
            this.groupBox_DPI.ResumeLayout(false);
            this.groupBox_DPI.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_WAVdata;
        private System.Windows.Forms.TrackBar trackBar_scale;
        private System.Windows.Forms.ListView listView_Info;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.TextBox TextBox_FilePath;
        private System.Windows.Forms.Label label_FileChoose;
        private System.Windows.Forms.Button button_Explore;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_scale;
        private System.Windows.Forms.TrackBar trackBar_panning;
        private System.Windows.Forms.Label label_Panning;
        private System.Windows.Forms.GroupBox groupBox_trackBars;
        private System.Windows.Forms.NumericUpDown numericUpDown_DPI;
        private System.Windows.Forms.GroupBox groupBox_DPI;
        private System.Windows.Forms.Label label_DPI;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_计算;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_显示;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_计算_频谱;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_计算_频谱的频谱;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_显示_波形;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_显示_频谱;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_显示_频谱的频谱;
    }
}

