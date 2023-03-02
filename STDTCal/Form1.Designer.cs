namespace STDTCal
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.New_toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工时编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模型搭建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模型编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工时标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线路信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.展示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.编辑ToolStripMenuItem,
            this.结果ToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_toolStripTextBox,
            this.Open_ToolStripMenuItem,
            this.Save_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 28);
            this.toolStripMenuItem1.Text = "文件";
            // 
            // New_toolStripTextBox
            // 
            this.New_toolStripTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.New_toolStripTextBox.Name = "New_toolStripTextBox";
            this.New_toolStripTextBox.Size = new System.Drawing.Size(100, 30);
            this.New_toolStripTextBox.Text = "新建";
            this.New_toolStripTextBox.Click += new System.EventHandler(this.ProjectNew);
            // 
            // Open_ToolStripMenuItem
            // 
            this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
            this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.Open_ToolStripMenuItem.Text = "打开";
            this.Open_ToolStripMenuItem.Click += new System.EventHandler(this.ProjectOpen);
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.Save_ToolStripMenuItem.Text = "保存";
            this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.ProjectSave);
            // 
            // Exit_ToolStripMenuItem
            // 
            this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
            this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(190, 34);
            this.Exit_ToolStripMenuItem.Text = "退出";
            this.Exit_ToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工时编辑ToolStripMenuItem,
            this.模型搭建ToolStripMenuItem,
            this.模型编辑ToolStripMenuItem,
            this.工时标准ToolStripMenuItem,
            this.线路信息ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 工时编辑ToolStripMenuItem
            // 
            this.工时编辑ToolStripMenuItem.Name = "工时编辑ToolStripMenuItem";
            this.工时编辑ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.工时编辑ToolStripMenuItem.Text = "工时编辑";
            this.工时编辑ToolStripMenuItem.Click += new System.EventHandler(this.工时编辑ToolStripMenuItem_Click);
            // 
            // 模型搭建ToolStripMenuItem
            // 
            this.模型搭建ToolStripMenuItem.Name = "模型搭建ToolStripMenuItem";
            this.模型搭建ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.模型搭建ToolStripMenuItem.Text = "模型搭建";
            // 
            // 模型编辑ToolStripMenuItem
            // 
            this.模型编辑ToolStripMenuItem.Name = "模型编辑ToolStripMenuItem";
            this.模型编辑ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.模型编辑ToolStripMenuItem.Text = "模型编辑";
            // 
            // 工时标准ToolStripMenuItem
            // 
            this.工时标准ToolStripMenuItem.Name = "工时标准ToolStripMenuItem";
            this.工时标准ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.工时标准ToolStripMenuItem.Text = "工时标准";
            // 
            // 线路信息ToolStripMenuItem
            // 
            this.线路信息ToolStripMenuItem.Name = "线路信息ToolStripMenuItem";
            this.线路信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.线路信息ToolStripMenuItem.Text = "线路信息";
            // 
            // 结果ToolStripMenuItem
            // 
            this.结果ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算ToolStripMenuItem,
            this.展示ToolStripMenuItem,
            this.导出ToolStripMenuItem});
            this.结果ToolStripMenuItem.Name = "结果ToolStripMenuItem";
            this.结果ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.结果ToolStripMenuItem.Text = "结果";
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.计算ToolStripMenuItem.Text = "计算";
            // 
            // 展示ToolStripMenuItem
            // 
            this.展示ToolStripMenuItem.Name = "展示ToolStripMenuItem";
            this.展示ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.展示ToolStripMenuItem.Text = "展示";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.版本ToolStripMenuItem.Text = "版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据测试";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox New_toolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工时编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模型搭建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 模型编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工时标准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线路信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 展示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

