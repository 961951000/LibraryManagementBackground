using LibraryManagementBackground.Forms;

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
            this.lblLabelSwitchingBar = new System.Windows.Forms.Label();
            this.prgLabelSwitching = new System.Windows.Forms.ProgressBar();
            this.grpLabelSwitchingGet = new System.Windows.Forms.GroupBox();
            this.rdoLabelSwitchingQueryOrderDesc = new System.Windows.Forms.RadioButton();
            this.rdoLabelSwitchingQueryOrderAsc = new System.Windows.Forms.RadioButton();
            this.lblLabelSwitchingQueryOrder = new System.Windows.Forms.Label();
            this.cboLabelSwitchingQueryOrder = new System.Windows.Forms.ComboBox();
            this.btnLabelSwitchingQuery = new System.Windows.Forms.Button();
            this.txtInstrumentType = new System.Windows.Forms.TextBox();
            this.txtInstrumentName = new System.Windows.Forms.TextBox();
            this.lblInstrumentType = new System.Windows.Forms.Label();
            this.lblInstrumentName = new System.Windows.Forms.Label();
            this.grpLabelSwitchingSet = new System.Windows.Forms.GroupBox();
            this.btnLabelSwitchingDownload = new System.Windows.Forms.Button();
            this.btnLabelSwitchingDelete = new System.Windows.Forms.Button();
            this.btnLabelSwitchingUpdate = new System.Windows.Forms.Button();
            this.btnLabelSwitchingImport = new System.Windows.Forms.Button();
            this.btnLabelSwitchingAdd = new System.Windows.Forms.Button();
            this.lvwBook = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnTagCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cnUpdateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageMakingCard = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.pageLabelSwitching.SuspendLayout();
            this.grpLabelSwitchingGet.SuspendLayout();
            this.grpLabelSwitchingSet.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(1086, 567);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
            // 
            // pageQueryStatistics
            // 
            this.pageQueryStatistics.Location = new System.Drawing.Point(4, 22);
            this.pageQueryStatistics.Name = "pageQueryStatistics";
            this.pageQueryStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.pageQueryStatistics.Size = new System.Drawing.Size(1078, 541);
            this.pageQueryStatistics.TabIndex = 0;
            this.pageQueryStatistics.Text = "查询统计";
            this.pageQueryStatistics.UseVisualStyleBackColor = true;
            // 
            // pageLabelSwitching
            // 
            this.pageLabelSwitching.Controls.Add(this.lblLabelSwitchingBar);
            this.pageLabelSwitching.Controls.Add(this.prgLabelSwitching);
            this.pageLabelSwitching.Controls.Add(this.grpLabelSwitchingGet);
            this.pageLabelSwitching.Controls.Add(this.grpLabelSwitchingSet);
            this.pageLabelSwitching.Controls.Add(this.lvwBook);
            this.pageLabelSwitching.Location = new System.Drawing.Point(4, 22);
            this.pageLabelSwitching.Name = "pageLabelSwitching";
            this.pageLabelSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.pageLabelSwitching.Size = new System.Drawing.Size(1078, 541);
            this.pageLabelSwitching.TabIndex = 1;
            this.pageLabelSwitching.Text = "标签转换";
            this.pageLabelSwitching.UseVisualStyleBackColor = true;
            // 
            // lblLabelSwitchingBar
            // 
            this.lblLabelSwitchingBar.AutoSize = true;
            this.lblLabelSwitchingBar.Location = new System.Drawing.Point(485, 507);
            this.lblLabelSwitchingBar.Name = "lblLabelSwitchingBar";
            this.lblLabelSwitchingBar.Size = new System.Drawing.Size(0, 12);
            this.lblLabelSwitchingBar.TabIndex = 4;
            // 
            // prgLabelSwitching
            // 
            this.prgLabelSwitching.Location = new System.Drawing.Point(230, 501);
            this.prgLabelSwitching.Name = "prgLabelSwitching";
            this.prgLabelSwitching.Size = new System.Drawing.Size(568, 23);
            this.prgLabelSwitching.TabIndex = 3;
            this.prgLabelSwitching.Visible = false;
            // 
            // grpLabelSwitchingGet
            // 
            this.grpLabelSwitchingGet.Controls.Add(this.rdoLabelSwitchingQueryOrderDesc);
            this.grpLabelSwitchingGet.Controls.Add(this.rdoLabelSwitchingQueryOrderAsc);
            this.grpLabelSwitchingGet.Controls.Add(this.lblLabelSwitchingQueryOrder);
            this.grpLabelSwitchingGet.Controls.Add(this.cboLabelSwitchingQueryOrder);
            this.grpLabelSwitchingGet.Controls.Add(this.btnLabelSwitchingQuery);
            this.grpLabelSwitchingGet.Controls.Add(this.txtInstrumentType);
            this.grpLabelSwitchingGet.Controls.Add(this.txtInstrumentName);
            this.grpLabelSwitchingGet.Controls.Add(this.lblInstrumentType);
            this.grpLabelSwitchingGet.Controls.Add(this.lblInstrumentName);
            this.grpLabelSwitchingGet.Location = new System.Drawing.Point(487, 26);
            this.grpLabelSwitchingGet.Name = "grpLabelSwitchingGet";
            this.grpLabelSwitchingGet.Size = new System.Drawing.Size(450, 150);
            this.grpLabelSwitchingGet.TabIndex = 2;
            this.grpLabelSwitchingGet.TabStop = false;
            this.grpLabelSwitchingGet.Text = "查询";
            // 
            // rdoLabelSwitchingQueryOrderDesc
            // 
            this.rdoLabelSwitchingQueryOrderDesc.AutoSize = true;
            this.rdoLabelSwitchingQueryOrderDesc.Checked = true;
            this.rdoLabelSwitchingQueryOrderDesc.Location = new System.Drawing.Point(367, 87);
            this.rdoLabelSwitchingQueryOrderDesc.Name = "rdoLabelSwitchingQueryOrderDesc";
            this.rdoLabelSwitchingQueryOrderDesc.Size = new System.Drawing.Size(47, 16);
            this.rdoLabelSwitchingQueryOrderDesc.TabIndex = 8;
            this.rdoLabelSwitchingQueryOrderDesc.TabStop = true;
            this.rdoLabelSwitchingQueryOrderDesc.Text = "倒序";
            this.rdoLabelSwitchingQueryOrderDesc.UseVisualStyleBackColor = true;
            // 
            // rdoLabelSwitchingQueryOrderAsc
            // 
            this.rdoLabelSwitchingQueryOrderAsc.AutoSize = true;
            this.rdoLabelSwitchingQueryOrderAsc.Location = new System.Drawing.Point(287, 87);
            this.rdoLabelSwitchingQueryOrderAsc.Name = "rdoLabelSwitchingQueryOrderAsc";
            this.rdoLabelSwitchingQueryOrderAsc.Size = new System.Drawing.Size(47, 16);
            this.rdoLabelSwitchingQueryOrderAsc.TabIndex = 7;
            this.rdoLabelSwitchingQueryOrderAsc.Text = "正序";
            this.rdoLabelSwitchingQueryOrderAsc.UseVisualStyleBackColor = true;
            // 
            // lblLabelSwitchingQueryOrder
            // 
            this.lblLabelSwitchingQueryOrder.AutoSize = true;
            this.lblLabelSwitchingQueryOrder.Location = new System.Drawing.Point(61, 91);
            this.lblLabelSwitchingQueryOrder.Name = "lblLabelSwitchingQueryOrder";
            this.lblLabelSwitchingQueryOrder.Size = new System.Drawing.Size(65, 12);
            this.lblLabelSwitchingQueryOrder.TabIndex = 6;
            this.lblLabelSwitchingQueryOrder.Text = "排    序：";
            // 
            // cboLabelSwitchingQueryOrder
            // 
            this.cboLabelSwitchingQueryOrder.FormattingEnabled = true;
            this.cboLabelSwitchingQueryOrder.Items.AddRange(new object[] {
            "仪器名称",
            "仪器型号",
            "入库时间",
            "修改时间"});
            this.cboLabelSwitchingQueryOrder.Location = new System.Drawing.Point(132, 86);
            this.cboLabelSwitchingQueryOrder.Name = "cboLabelSwitchingQueryOrder";
            this.cboLabelSwitchingQueryOrder.Size = new System.Drawing.Size(121, 20);
            this.cboLabelSwitchingQueryOrder.TabIndex = 5;
            // 
            // btnLabelSwitchingQuery
            // 
            this.btnLabelSwitchingQuery.Location = new System.Drawing.Point(287, 121);
            this.btnLabelSwitchingQuery.Name = "btnLabelSwitchingQuery";
            this.btnLabelSwitchingQuery.Size = new System.Drawing.Size(75, 23);
            this.btnLabelSwitchingQuery.TabIndex = 4;
            this.btnLabelSwitchingQuery.Text = "开始查询";
            this.btnLabelSwitchingQuery.UseVisualStyleBackColor = true;
            this.btnLabelSwitchingQuery.Click += new System.EventHandler(this.btnLabelSwitchingQuery_Click);
            // 
            // txtInstrumentType
            // 
            this.txtInstrumentType.Location = new System.Drawing.Point(132, 58);
            this.txtInstrumentType.Name = "txtInstrumentType";
            this.txtInstrumentType.Size = new System.Drawing.Size(100, 21);
            this.txtInstrumentType.TabIndex = 3;
            // 
            // txtInstrumentName
            // 
            this.txtInstrumentName.Location = new System.Drawing.Point(132, 26);
            this.txtInstrumentName.Name = "txtInstrumentName";
            this.txtInstrumentName.Size = new System.Drawing.Size(100, 21);
            this.txtInstrumentName.TabIndex = 2;
            // 
            // lblInstrumentType
            // 
            this.lblInstrumentType.AutoSize = true;
            this.lblInstrumentType.Location = new System.Drawing.Point(61, 61);
            this.lblInstrumentType.Name = "lblInstrumentType";
            this.lblInstrumentType.Size = new System.Drawing.Size(65, 12);
            this.lblInstrumentType.TabIndex = 1;
            this.lblInstrumentType.Text = "仪器型号：";
            // 
            // lblInstrumentName
            // 
            this.lblInstrumentName.AutoSize = true;
            this.lblInstrumentName.Location = new System.Drawing.Point(61, 29);
            this.lblInstrumentName.Name = "lblInstrumentName";
            this.lblInstrumentName.Size = new System.Drawing.Size(65, 12);
            this.lblInstrumentName.TabIndex = 0;
            this.lblInstrumentName.Text = "仪器名称：";
            // 
            // grpLabelSwitchingSet
            // 
            this.grpLabelSwitchingSet.Controls.Add(this.btnLabelSwitchingDownload);
            this.grpLabelSwitchingSet.Controls.Add(this.btnLabelSwitchingDelete);
            this.grpLabelSwitchingSet.Controls.Add(this.btnLabelSwitchingUpdate);
            this.grpLabelSwitchingSet.Controls.Add(this.btnLabelSwitchingImport);
            this.grpLabelSwitchingSet.Controls.Add(this.btnLabelSwitchingAdd);
            this.grpLabelSwitchingSet.Location = new System.Drawing.Point(6, 26);
            this.grpLabelSwitchingSet.Name = "grpLabelSwitchingSet";
            this.grpLabelSwitchingSet.Size = new System.Drawing.Size(450, 150);
            this.grpLabelSwitchingSet.TabIndex = 1;
            this.grpLabelSwitchingSet.TabStop = false;
            this.grpLabelSwitchingSet.Text = "设置";
            // 
            // btnLabelSwitchingDownload
            // 
            this.btnLabelSwitchingDownload.Location = new System.Drawing.Point(168, 38);
            this.btnLabelSwitchingDownload.Name = "btnLabelSwitchingDownload";
            this.btnLabelSwitchingDownload.Size = new System.Drawing.Size(100, 23);
            this.btnLabelSwitchingDownload.TabIndex = 4;
            this.btnLabelSwitchingDownload.Text = "下载表格模板";
            this.btnLabelSwitchingDownload.UseVisualStyleBackColor = true;
            this.btnLabelSwitchingDownload.Click += new System.EventHandler(this.btnLabelSwitchingDownload_Click);
            // 
            // btnLabelSwitchingDelete
            // 
            this.btnLabelSwitchingDelete.Location = new System.Drawing.Point(87, 68);
            this.btnLabelSwitchingDelete.Name = "btnLabelSwitchingDelete";
            this.btnLabelSwitchingDelete.Size = new System.Drawing.Size(75, 23);
            this.btnLabelSwitchingDelete.TabIndex = 3;
            this.btnLabelSwitchingDelete.Text = "删除";
            this.btnLabelSwitchingDelete.UseVisualStyleBackColor = true;
            this.btnLabelSwitchingDelete.Click += new System.EventHandler(this.btnLabelSwitchingDelete_Click);
            // 
            // btnLabelSwitchingUpdate
            // 
            this.btnLabelSwitchingUpdate.Location = new System.Drawing.Point(7, 68);
            this.btnLabelSwitchingUpdate.Name = "btnLabelSwitchingUpdate";
            this.btnLabelSwitchingUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnLabelSwitchingUpdate.TabIndex = 2;
            this.btnLabelSwitchingUpdate.Text = "修改";
            this.btnLabelSwitchingUpdate.UseVisualStyleBackColor = true;
            this.btnLabelSwitchingUpdate.Click += new System.EventHandler(this.btnLabelSwitchingUpdate_Click);
            // 
            // btnLabelSwitchingImport
            // 
            this.btnLabelSwitchingImport.Location = new System.Drawing.Point(87, 38);
            this.btnLabelSwitchingImport.Name = "btnLabelSwitchingImport";
            this.btnLabelSwitchingImport.Size = new System.Drawing.Size(75, 23);
            this.btnLabelSwitchingImport.TabIndex = 1;
            this.btnLabelSwitchingImport.Text = "表格导入";
            this.btnLabelSwitchingImport.UseVisualStyleBackColor = true;
            this.btnLabelSwitchingImport.Click += new System.EventHandler(this.btnLabelSwitchingImport_Click);
            // 
            // btnLabelSwitchingAdd
            // 
            this.btnLabelSwitchingAdd.Location = new System.Drawing.Point(6, 38);
            this.btnLabelSwitchingAdd.Name = "btnLabelSwitchingAdd";
            this.btnLabelSwitchingAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLabelSwitchingAdd.TabIndex = 0;
            this.btnLabelSwitchingAdd.Text = "新增";
            this.btnLabelSwitchingAdd.UseVisualStyleBackColor = true;
            this.btnLabelSwitchingAdd.Click += new System.EventHandler(this.btnLabelSwitchingAdd_Click);
            // 
            // lvwBook
            // 
            this.lvwBook.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvwBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.cnIndex,
            this.cnTagCode,
            this.chName,
            this.chType,
            this.cnCreateDate,
            this.cnUpdateDate});
            this.lvwBook.FullRowSelect = true;
            this.lvwBook.GridLines = true;
            this.lvwBook.Location = new System.Drawing.Point(6, 193);
            this.lvwBook.Name = "lvwBook";
            this.lvwBook.Size = new System.Drawing.Size(1054, 301);
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
            this.cnIndex.Width = 50;
            // 
            // cnTagCode
            // 
            this.cnTagCode.Text = "电子标签";
            this.cnTagCode.Width = 200;
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
            this.pageMakingCard.Size = new System.Drawing.Size(1078, 541);
            this.pageMakingCard.TabIndex = 2;
            this.pageMakingCard.Text = "开证办卡";
            this.pageMakingCard.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 617);
            this.Controls.Add(this.tabMain);
            this.Name = "FrmMain";
            this.Text = "图书馆管理后台";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.pageLabelSwitching.ResumeLayout(false);
            this.pageLabelSwitching.PerformLayout();
            this.grpLabelSwitchingGet.ResumeLayout(false);
            this.grpLabelSwitchingGet.PerformLayout();
            this.grpLabelSwitchingSet.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpLabelSwitchingGet;
        private System.Windows.Forms.GroupBox grpLabelSwitchingSet;
        private System.Windows.Forms.Button btnLabelSwitchingQuery;
        private System.Windows.Forms.TextBox txtInstrumentType;
        private System.Windows.Forms.TextBox txtInstrumentName;
        private System.Windows.Forms.Label lblInstrumentType;
        private System.Windows.Forms.Label lblInstrumentName;
        private System.Windows.Forms.Button btnLabelSwitchingImport;
        private System.Windows.Forms.Button btnLabelSwitchingAdd;
        private System.Windows.Forms.RadioButton rdoLabelSwitchingQueryOrderDesc;
        private System.Windows.Forms.RadioButton rdoLabelSwitchingQueryOrderAsc;
        private System.Windows.Forms.Label lblLabelSwitchingQueryOrder;
        private System.Windows.Forms.ComboBox cboLabelSwitchingQueryOrder;
        private System.Windows.Forms.Button btnLabelSwitchingDelete;
        private System.Windows.Forms.Button btnLabelSwitchingUpdate;
        private System.Windows.Forms.ColumnHeader cnTagCode;
        private System.Windows.Forms.Button btnLabelSwitchingDownload;
        private System.Windows.Forms.Label lblLabelSwitchingBar;
        private System.Windows.Forms.ProgressBar prgLabelSwitching;
    }
}

