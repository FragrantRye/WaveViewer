namespace WaveViewer.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.频谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.频谱的频谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.倒谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.波形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帧分隔线toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.频谱ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.频谱的频谱ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.对数频谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.倒谱ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帧长设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.自定义ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.myChart1 = new WaveViewer.MyControl.MyChart();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar_move = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.textBox_move = new System.Windows.Forms.TextBox();
            this.trackBar_scale = new System.Windows.Forms.TrackBar();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_move)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.计算ToolStripMenuItem,
            this.显示ToolStripMenuItem,
            this.帧长设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(869, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭文件ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭文件ToolStripMenuItem
            // 
            this.关闭文件ToolStripMenuItem.Enabled = false;
            this.关闭文件ToolStripMenuItem.Name = "关闭文件ToolStripMenuItem";
            this.关闭文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭文件ToolStripMenuItem.Text = "关闭文件";
            this.关闭文件ToolStripMenuItem.Click += new System.EventHandler(this.关闭文件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.频谱ToolStripMenuItem,
            this.频谱的频谱ToolStripMenuItem,
            this.倒谱ToolStripMenuItem});
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.计算ToolStripMenuItem.Text = "计算";
            // 
            // 频谱ToolStripMenuItem
            // 
            this.频谱ToolStripMenuItem.Name = "频谱ToolStripMenuItem";
            this.频谱ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.频谱ToolStripMenuItem.Text = "频谱";
            this.频谱ToolStripMenuItem.Click += new System.EventHandler(this.频谱ToolStripMenuItem_Click);
            // 
            // 频谱的频谱ToolStripMenuItem
            // 
            this.频谱的频谱ToolStripMenuItem.Name = "频谱的频谱ToolStripMenuItem";
            this.频谱的频谱ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.频谱的频谱ToolStripMenuItem.Text = "频谱的频谱";
            this.频谱的频谱ToolStripMenuItem.Click += new System.EventHandler(this.频谱的频谱ToolStripMenuItem_Click);
            // 
            // 倒谱ToolStripMenuItem
            // 
            this.倒谱ToolStripMenuItem.Name = "倒谱ToolStripMenuItem";
            this.倒谱ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.倒谱ToolStripMenuItem.Text = "倒谱";
            this.倒谱ToolStripMenuItem.Click += new System.EventHandler(this.倒谱ToolStripMenuItem_Click);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.波形ToolStripMenuItem,
            this.帧分隔线toolStripMenuItem,
            this.频谱ToolStripMenuItem1,
            this.频谱的频谱ToolStripMenuItem1,
            this.对数频谱ToolStripMenuItem,
            this.倒谱ToolStripMenuItem1});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 波形ToolStripMenuItem
            // 
            this.波形ToolStripMenuItem.Name = "波形ToolStripMenuItem";
            this.波形ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.波形ToolStripMenuItem.Text = "波形";
            this.波形ToolStripMenuItem.Click += new System.EventHandler(this.波形ToolStripMenuItem_Click);
            // 
            // 帧分隔线toolStripMenuItem
            // 
            this.帧分隔线toolStripMenuItem.Name = "帧分隔线toolStripMenuItem";
            this.帧分隔线toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.帧分隔线toolStripMenuItem.Text = "帧分隔线";
            this.帧分隔线toolStripMenuItem.Click += new System.EventHandler(this.帧分隔线toolStripMenuItem_Click);
            // 
            // 频谱ToolStripMenuItem1
            // 
            this.频谱ToolStripMenuItem1.Name = "频谱ToolStripMenuItem1";
            this.频谱ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.频谱ToolStripMenuItem1.Text = "频谱";
            this.频谱ToolStripMenuItem1.Click += new System.EventHandler(this.频谱ToolStripMenuItem1_Click);
            // 
            // 频谱的频谱ToolStripMenuItem1
            // 
            this.频谱的频谱ToolStripMenuItem1.Name = "频谱的频谱ToolStripMenuItem1";
            this.频谱的频谱ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.频谱的频谱ToolStripMenuItem1.Text = "频谱的频谱";
            this.频谱的频谱ToolStripMenuItem1.Click += new System.EventHandler(this.频谱的频谱ToolStripMenuItem1_Click);
            // 
            // 对数频谱ToolStripMenuItem
            // 
            this.对数频谱ToolStripMenuItem.Name = "对数频谱ToolStripMenuItem";
            this.对数频谱ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.对数频谱ToolStripMenuItem.Text = "对数频谱";
            this.对数频谱ToolStripMenuItem.Click += new System.EventHandler(this.对数频谱ToolStripMenuItem_Click);
            // 
            // 倒谱ToolStripMenuItem1
            // 
            this.倒谱ToolStripMenuItem1.Name = "倒谱ToolStripMenuItem1";
            this.倒谱ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.倒谱ToolStripMenuItem1.Text = "倒谱";
            this.倒谱ToolStripMenuItem1.Click += new System.EventHandler(this.倒谱ToolStripMenuItem1_Click);
            // 
            // 帧长设置ToolStripMenuItem
            // 
            this.帧长设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.帧长设置ToolStripMenuItem.Name = "帧长设置ToolStripMenuItem";
            this.帧长设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帧长设置ToolStripMenuItem.Text = "设置";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.自定义ToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "帧长设置";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem4.Text = "256";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem5.Text = "512";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem6.Text = "1024";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // 自定义ToolStripMenuItem1
            // 
            this.自定义ToolStripMenuItem1.Name = "自定义ToolStripMenuItem1";
            this.自定义ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.自定义ToolStripMenuItem1.Text = "自定义";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myChart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar4);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar3);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar2);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar_move);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_scale);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_move);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar_scale);
            this.splitContainer1.Size = new System.Drawing.Size(869, 600);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // myChart1
            // 
            this.myChart1.Location = new System.Drawing.Point(0, 0);
            this.myChart1.MinX = 0F;
            this.myChart1.Name = "myChart1";
            this.myChart1.Scale_times = 1F;
            this.myChart1.Size = new System.Drawing.Size(867, 454);
            this.myChart1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "倒谱";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "对数频谱";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "频谱的频谱";
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar4.LargeChange = 3;
            this.trackBar4.Location = new System.Drawing.Point(815, -1);
            this.trackBar4.Maximum = 20;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 126);
            this.trackBar4.TabIndex = 11;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar4.ValueChanged += new System.EventHandler(this.TrackBar4_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.LargeChange = 3;
            this.trackBar3.Location = new System.Drawing.Point(766, -1);
            this.trackBar3.Maximum = 20;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 126);
            this.trackBar3.TabIndex = 10;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.LargeChange = 3;
            this.trackBar2.Location = new System.Drawing.Point(715, -1);
            this.trackBar2.Maximum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 126);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar2.ValueChanged += new System.EventHandler(this.TrackBar2_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "频谱";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(660, -1);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 126);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // trackBar_move
            // 
            this.trackBar_move.LargeChange = 50;
            this.trackBar_move.Location = new System.Drawing.Point(178, 33);
            this.trackBar_move.Maximum = 100000;
            this.trackBar_move.Name = "trackBar_move";
            this.trackBar_move.Size = new System.Drawing.Size(483, 45);
            this.trackBar_move.SmallChange = 10;
            this.trackBar_move.TabIndex = 6;
            this.trackBar_move.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_move.Scroll += new System.EventHandler(this.trackBar_move_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "缩放比例×";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "显示位置";
            // 
            // textBox_scale
            // 
            this.textBox_scale.Location = new System.Drawing.Point(98, 89);
            this.textBox_scale.Name = "textBox_scale";
            this.textBox_scale.Size = new System.Drawing.Size(74, 21);
            this.textBox_scale.TabIndex = 3;
            this.textBox_scale.Text = "1.000";
            this.textBox_scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_scale_KeyDown);
            // 
            // textBox_move
            // 
            this.textBox_move.Location = new System.Drawing.Point(98, 33);
            this.textBox_move.Name = "textBox_move";
            this.textBox_move.Size = new System.Drawing.Size(74, 21);
            this.textBox_move.TabIndex = 2;
            this.textBox_move.Text = "0";
            this.textBox_move.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_move_KeyDown);
            // 
            // trackBar_scale
            // 
            this.trackBar_scale.Location = new System.Drawing.Point(178, 89);
            this.trackBar_scale.Maximum = 500;
            this.trackBar_scale.Minimum = -664;
            this.trackBar_scale.Name = "trackBar_scale";
            this.trackBar_scale.Size = new System.Drawing.Size(483, 45);
            this.trackBar_scale.TabIndex = 1;
            this.trackBar_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_scale.Scroll += new System.EventHandler(this.trackBar_scale_Scroll);
            // 
            // button_play
            // 
            this.button_play.BackColor = System.Drawing.Color.Transparent;
            this.button_play.BackgroundImage = global::WaveViewer.Properties.Resources.play;
            this.button_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_play.Location = new System.Drawing.Point(268, 1);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(24, 23);
            this.button_play.TabIndex = 6;
            this.button_play.UseVisualStyleBackColor = false;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Transparent;
            this.button_stop.BackgroundImage = global::WaveViewer.Properties.Resources.stop;
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_stop.Location = new System.Drawing.Point(292, 1);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(24, 23);
            this.button_stop.TabIndex = 7;
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 625);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Main";
            this.Text = "WaveViewer";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Main_Layout);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_move)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 频谱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 频谱的频谱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 波形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 频谱ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 频谱的频谱ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帧长设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private MyControl.MyChart myChart1;
        private System.Windows.Forms.ToolStripMenuItem 关闭文件ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.TrackBar trackBar_scale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_scale;
        private System.Windows.Forms.TextBox textBox_move;
        private System.Windows.Forms.ToolStripMenuItem 自定义ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帧分隔线toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 倒谱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对数频谱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 倒谱ToolStripMenuItem1;
        private System.Windows.Forms.TrackBar trackBar_move;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}