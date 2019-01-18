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
            this.对数振幅谱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trackBar_move = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_scale = new System.Windows.Forms.TextBox();
            this.textBox_move = new System.Windows.Forms.TextBox();
            this.trackBar_scale = new System.Windows.Forms.TrackBar();
            this.button_playstop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭文件ToolStripMenuItem
            // 
            this.关闭文件ToolStripMenuItem.Enabled = false;
            this.关闭文件ToolStripMenuItem.Name = "关闭文件ToolStripMenuItem";
            this.关闭文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭文件ToolStripMenuItem.Text = "关闭文件";
            this.关闭文件ToolStripMenuItem.Click += new System.EventHandler(this.关闭文件ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
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
            this.频谱ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.频谱ToolStripMenuItem.Text = "频谱";
            this.频谱ToolStripMenuItem.Click += new System.EventHandler(this.频谱ToolStripMenuItem_Click);
            // 
            // 频谱的频谱ToolStripMenuItem
            // 
            this.频谱的频谱ToolStripMenuItem.Name = "频谱的频谱ToolStripMenuItem";
            this.频谱的频谱ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.频谱的频谱ToolStripMenuItem.Text = "频谱的频谱";
            this.频谱的频谱ToolStripMenuItem.Click += new System.EventHandler(this.频谱的频谱ToolStripMenuItem_Click);
            // 
            // 倒谱ToolStripMenuItem
            // 
            this.倒谱ToolStripMenuItem.Name = "倒谱ToolStripMenuItem";
            this.倒谱ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
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
            this.对数振幅谱ToolStripMenuItem,
            this.倒谱ToolStripMenuItem1});
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.显示ToolStripMenuItem.Text = "显示";
            // 
            // 波形ToolStripMenuItem
            // 
            this.波形ToolStripMenuItem.Name = "波形ToolStripMenuItem";
            this.波形ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.波形ToolStripMenuItem.Text = "波形";
            this.波形ToolStripMenuItem.Click += new System.EventHandler(this.波形ToolStripMenuItem_Click);
            // 
            // 帧分隔线toolStripMenuItem
            // 
            this.帧分隔线toolStripMenuItem.Name = "帧分隔线toolStripMenuItem";
            this.帧分隔线toolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.帧分隔线toolStripMenuItem.Text = "帧分隔线";
            this.帧分隔线toolStripMenuItem.Click += new System.EventHandler(this.帧分隔线toolStripMenuItem_Click);
            // 
            // 频谱ToolStripMenuItem1
            // 
            this.频谱ToolStripMenuItem1.Name = "频谱ToolStripMenuItem1";
            this.频谱ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.频谱ToolStripMenuItem1.Text = "频谱";
            this.频谱ToolStripMenuItem1.Click += new System.EventHandler(this.频谱ToolStripMenuItem1_Click);
            // 
            // 频谱的频谱ToolStripMenuItem1
            // 
            this.频谱的频谱ToolStripMenuItem1.Name = "频谱的频谱ToolStripMenuItem1";
            this.频谱的频谱ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.频谱的频谱ToolStripMenuItem1.Text = "频谱的频谱";
            this.频谱的频谱ToolStripMenuItem1.Click += new System.EventHandler(this.频谱的频谱ToolStripMenuItem1_Click);
            // 
            // 对数振幅谱ToolStripMenuItem
            // 
            this.对数振幅谱ToolStripMenuItem.Name = "对数振幅谱ToolStripMenuItem";
            this.对数振幅谱ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.对数振幅谱ToolStripMenuItem.Text = "对数振幅谱";
            // 
            // 倒谱ToolStripMenuItem1
            // 
            this.倒谱ToolStripMenuItem1.Name = "倒谱ToolStripMenuItem1";
            this.倒谱ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
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
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
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
            this.splitContainer1.Panel2.Controls.Add(this.trackBar_move);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_scale);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_move);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar_scale);
            this.splitContainer1.Size = new System.Drawing.Size(869, 600);
            this.splitContainer1.SplitterDistance = 454;
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
            // trackBar_move
            // 
            this.trackBar_move.LargeChange = 50;
            this.trackBar_move.Location = new System.Drawing.Point(178, 33);
            this.trackBar_move.Maximum = 100000;
            this.trackBar_move.Name = "trackBar_move";
            this.trackBar_move.Size = new System.Drawing.Size(511, 45);
            this.trackBar_move.SmallChange = 10;
            this.trackBar_move.TabIndex = 6;
            this.trackBar_move.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_move.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "缩放比例";
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
            this.textBox_scale.Text = "×1.000";
            // 
            // textBox_move
            // 
            this.textBox_move.Location = new System.Drawing.Point(98, 33);
            this.textBox_move.Name = "textBox_move";
            this.textBox_move.Size = new System.Drawing.Size(74, 21);
            this.textBox_move.TabIndex = 2;
            this.textBox_move.Text = "0";
            // 
            // trackBar_scale
            // 
            this.trackBar_scale.Location = new System.Drawing.Point(178, 89);
            this.trackBar_scale.Maximum = 500;
            this.trackBar_scale.Minimum = -664;
            this.trackBar_scale.Name = "trackBar_scale";
            this.trackBar_scale.Size = new System.Drawing.Size(511, 45);
            this.trackBar_scale.TabIndex = 1;
            this.trackBar_scale.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_scale.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button_playstop
            // 
            this.button_playstop.BackColor = System.Drawing.Color.Transparent;
            this.button_playstop.BackgroundImage = global::WaveViewer.Properties.Resources.play;
            this.button_playstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_playstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_playstop.Location = new System.Drawing.Point(268, 1);
            this.button_playstop.Name = "button_playstop";
            this.button_playstop.Size = new System.Drawing.Size(24, 23);
            this.button_playstop.TabIndex = 6;
            this.button_playstop.UseVisualStyleBackColor = false;
            this.button_playstop.Click += new System.EventHandler(this.button_playstop_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WaveViewer.Properties.Resources.stop;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(292, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_playstop);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem 对数振幅谱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 倒谱ToolStripMenuItem1;
        private System.Windows.Forms.TrackBar trackBar_move;
        private System.Windows.Forms.Button button_playstop;
        private System.Windows.Forms.Button button1;
    }
}