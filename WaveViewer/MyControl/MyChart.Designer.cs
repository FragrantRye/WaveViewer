namespace WaveViewer.MyControl
{
    partial class MyChart
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.renderControl = new SharpDX.Windows.RenderControl();
            this.SuspendLayout();
            // 
            // renderControl
            // 
            this.renderControl.Location = new System.Drawing.Point(0, 0);
            this.renderControl.Name = "renderControl";
            this.renderControl.Size = new System.Drawing.Size(525, 389);
            this.renderControl.TabIndex = 0;
            this.renderControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MyChart_Paint);
            this.renderControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.renderControl_MouseDown);
            this.renderControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.renderControl_MouseMove);
            this.renderControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.renderControl_MouseUp);
            // 
            // MyChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.renderControl);
            this.Name = "MyChart";
            this.Size = new System.Drawing.Size(525, 389);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MyChart_Layout);
            this.ResumeLayout(false);

        }

        #endregion

        private SharpDX.Windows.RenderControl renderControl;
    }
}
