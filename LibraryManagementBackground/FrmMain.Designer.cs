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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pageQueryStatistics = new System.Windows.Forms.TabPage();
            this.pageLabelSwitching = new System.Windows.Forms.TabPage();
            this.lvwBook = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnUpdateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageMakingCard = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.pageLabelSwitching.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pageQueryStatistics);
            this.tabMain.Controls.Add(this.pageLabelSwitching);
            this.tabMain.Controls.Add(this.pageMakingCard);
            this.tabMain.Location = new System.Drawing.Point(2, 1);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(977, 526);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
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
            this.pageLabelSwitching.Controls.Add(this.lvwBook);
            this.pageLabelSwitching.Location = new System.Drawing.Point(4, 22);
            this.pageLabelSwitching.Name = "pageLabelSwitching";
            this.pageLabelSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.pageLabelSwitching.Size = new System.Drawing.Size(969, 500);
            this.pageLabelSwitching.TabIndex = 1;
            this.pageLabelSwitching.Text = "标签转换";
            this.pageLabelSwitching.UseVisualStyleBackColor = true;
            // 
            // lvwBook
            // 
            this.lvwBook.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvwBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.cnIndex,
            this.chName,
            this.chType,
            this.cnCreateDate,
            this.cnUpdateDate});
            this.lvwBook.FullRowSelect = true;
            this.lvwBook.GridLines = true;
            this.lvwBook.Location = new System.Drawing.Point(6, 193);
            this.lvwBook.Name = "lvwBook";
            this.lvwBook.Size = new System.Drawing.Size(957, 301);
            this.lvwBook.TabIndex = 0;
            this.lvwBook.UseCompatibleStateImageBehavior = false;
            this.lvwBook.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "编号";
            this.chId.Width = 0;
            // 
            // cnIndex
            // 
            this.cnIndex.Text = "序号";
            // 
            // chName
            // 
            this.chName.Text = "仪器名称";
            this.chName.Width = 200;
            // 
            // chType
            // 
            this.chType.Text = "仪器型号";
            this.chType.Width = 200;
            // 
            // cnCreateDate
            // 
            this.cnCreateDate.Text = "入库时间";
            this.cnCreateDate.Width = 200;
            // 
            // cnUpdateDate
            // 
            this.cnUpdateDate.Text = "修改时间";
            this.cnUpdateDate.Width = 200;
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
            this.Controls.Add(this.tabMain);
            this.Name = "FrmMain";
            this.Text = "图书馆管理后台";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.pageLabelSwitching.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pageQueryStatistics;
        private System.Windows.Forms.TabPage pageLabelSwitching;
        private System.Windows.Forms.TabPage pageMakingCard;
        private System.Windows.Forms.ListView lvwBook;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader cnIndex;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader cnCreateDate;
        private System.Windows.Forms.ColumnHeader cnUpdateDate;
    }
}

