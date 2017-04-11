namespace LibraryManagementBackground
{
    partial class FrmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageQueryStatistics = new System.Windows.Forms.TabPage();
            this.pageLabelSwitching = new System.Windows.Forms.TabPage();
            this.pageMakingCard = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageQueryStatistics);
            this.tabControl1.Controls.Add(this.pageLabelSwitching);
            this.tabControl1.Controls.Add(this.pageMakingCard);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 526);
            this.tabControl1.TabIndex = 0;
            // 
            // pageQueryStatistics
            // 
            this.pageQueryStatistics.Location = new System.Drawing.Point(4, 22);
            this.pageQueryStatistics.Name = "pageQueryStatistics";
            this.pageQueryStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.pageQueryStatistics.Size = new System.Drawing.Size(969, 500);
            this.pageQueryStatistics.TabIndex = 0;
            this.pageQueryStatistics.Text = "查询统计";
            this.pageQueryStatistics.UseVisualStyleBackColor = true;
            // 
            // pageLabelSwitching
            // 
            this.pageLabelSwitching.Location = new System.Drawing.Point(4, 22);
            this.pageLabelSwitching.Name = "pageLabelSwitching";
            this.pageLabelSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.pageLabelSwitching.Size = new System.Drawing.Size(969, 500);
            this.pageLabelSwitching.TabIndex = 1;
            this.pageLabelSwitching.Text = "标签转换";
            this.pageLabelSwitching.UseVisualStyleBackColor = true;
            // 
            // pageMakingCard
            // 
            this.pageMakingCard.Location = new System.Drawing.Point(4, 22);
            this.pageMakingCard.Name = "pageMakingCard";
            this.pageMakingCard.Padding = new System.Windows.Forms.Padding(3);
            this.pageMakingCard.Size = new System.Drawing.Size(969, 500);
            this.pageMakingCard.TabIndex = 2;
            this.pageMakingCard.Text = "开证办卡";
            this.pageMakingCard.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "图书馆管理后台";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageQueryStatistics;
        private System.Windows.Forms.TabPage pageLabelSwitching;
        private System.Windows.Forms.TabPage pageMakingCard;
    }
}

