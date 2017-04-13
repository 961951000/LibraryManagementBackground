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
            this.lblLabelSwitchingProgress1 = new System.Windows.Forms.Label();
            this.prgLabelSwitching1 = new System.Windows.Forms.ProgressBar();
            this.lblLabelSwitchingProgress2 = new System.Windows.Forms.Label();
            this.prgLabelSwitching2 = new System.Windows.Forms.ProgressBar();
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMain.SuspendLayout();
            this.pageLabelSwitching.SuspendLayout();
            this.grpLabelSwitchingGet.SuspendLayout();
            this.grpLabelSwitchingSet.SuspendLayout();
            this.pageMakingCard.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(1086, 615);
            this.tabMain.TabIndex = 0;
            this.tabMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMain_Selected);
            // 
            // pageQueryStatistics
            // 
            this.pageQueryStatistics.Location = new System.Drawing.Point(4, 22);
            this.pageQueryStatistics.Name = "pageQueryStatistics";
            this.pageQueryStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.pageQueryStatistics.Size = new System.Drawing.Size(1078, 589);
            this.pageQueryStatistics.TabIndex = 0;
            this.pageQueryStatistics.Text = "查询统计";
            this.pageQueryStatistics.UseVisualStyleBackColor = true;
            // 
            // pageLabelSwitching
            // 
            this.pageLabelSwitching.Controls.Add(this.lblLabelSwitchingProgress1);
            this.pageLabelSwitching.Controls.Add(this.prgLabelSwitching1);
            this.pageLabelSwitching.Controls.Add(this.lblLabelSwitchingProgress2);
            this.pageLabelSwitching.Controls.Add(this.prgLabelSwitching2);
            this.pageLabelSwitching.Controls.Add(this.grpLabelSwitchingGet);
            this.pageLabelSwitching.Controls.Add(this.grpLabelSwitchingSet);
            this.pageLabelSwitching.Controls.Add(this.lvwBook);
            this.pageLabelSwitching.Location = new System.Drawing.Point(4, 22);
            this.pageLabelSwitching.Name = "pageLabelSwitching";
            this.pageLabelSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.pageLabelSwitching.Size = new System.Drawing.Size(1078, 589);
            this.pageLabelSwitching.TabIndex = 1;
            this.pageLabelSwitching.Text = "标签转换";
            this.pageLabelSwitching.UseVisualStyleBackColor = true;
            // 
            // lblLabelSwitchingProgress1
            // 
            this.lblLabelSwitchingProgress1.AutoSize = true;
            this.lblLabelSwitchingProgress1.Location = new System.Drawing.Point(500, 505);
            this.lblLabelSwitchingProgress1.Name = "lblLabelSwitchingProgress1";
            this.lblLabelSwitchingProgress1.Size = new System.Drawing.Size(161, 12);
            this.lblLabelSwitchingProgress1.TabIndex = 6;
            this.lblLabelSwitchingProgress1.Text = "lblLabelSwitchingProgress1";
            // 
            // prgLabelSwitching1
            // 
            this.prgLabelSwitching1.Location = new System.Drawing.Point(230, 500);
            this.prgLabelSwitching1.Name = "prgLabelSwitching1";
            this.prgLabelSwitching1.Size = new System.Drawing.Size(600, 23);
            this.prgLabelSwitching1.TabIndex = 5;
            this.prgLabelSwitching1.Visible = false;
            // 
            // lblLabelSwitchingProgress2
            // 
            this.lblLabelSwitchingProgress2.AutoSize = true;
            this.lblLabelSwitchingProgress2.Location = new System.Drawing.Point(500, 551);
            this.lblLabelSwitchingProgress2.Name = "lblLabelSwitchingProgress2";
            this.lblLabelSwitchingProgress2.Size = new System.Drawing.Size(161, 12);
            this.lblLabelSwitchingProgress2.TabIndex = 4;
            this.lblLabelSwitchingProgress2.Text = "lblLabelSwitchingProgress2";
            // 
            // prgLabelSwitching2
            // 
            this.prgLabelSwitching2.Location = new System.Drawing.Point(230, 545);
            this.prgLabelSwitching2.Name = "prgLabelSwitching2";
            this.prgLabelSwitching2.Size = new System.Drawing.Size(600, 23);
            this.prgLabelSwitching2.TabIndex = 3;
            this.prgLabelSwitching2.Visible = false;
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
            this.pageMakingCard.Controls.Add(this.label1);
            this.pageMakingCard.Controls.Add(this.progressBar1);
            this.pageMakingCard.Controls.Add(this.label2);
            this.pageMakingCard.Controls.Add(this.progressBar2);
            this.pageMakingCard.Controls.Add(this.groupBox1);
            this.pageMakingCard.Controls.Add(this.groupBox2);
            this.pageMakingCard.Controls.Add(this.listView1);
            this.pageMakingCard.Location = new System.Drawing.Point(4, 22);
            this.pageMakingCard.Name = "pageMakingCard";
            this.pageMakingCard.Padding = new System.Windows.Forms.Padding(3);
            this.pageMakingCard.Size = new System.Drawing.Size(1078, 589);
            this.pageMakingCard.TabIndex = 2;
            this.pageMakingCard.Text = "开证办卡";
            this.pageMakingCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(236, 497);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(236, 542);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(600, 23);
            this.progressBar2.TabIndex = 10;
            this.progressBar2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(493, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(367, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "倒序";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(287, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "正序";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "排    序：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "仪器名称",
            "仪器型号",
            "入库时间",
            "修改时间"});
            this.comboBox1.Location = new System.Drawing.Point(132, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "开始查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "仪器型号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "仪器名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 150);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "下载表格模板";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "表格导入";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "新增";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1054, 301);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "序号";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "电子标签";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "仪器名称";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "仪器型号";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "入库时间";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "修改时间";
            this.columnHeader7.Width = 200;
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
            this.pageMakingCard.ResumeLayout(false);
            this.pageMakingCard.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblLabelSwitchingProgress2;
        private System.Windows.Forms.ProgressBar prgLabelSwitching2;
        private System.Windows.Forms.Label lblLabelSwitchingProgress1;
        private System.Windows.Forms.ProgressBar prgLabelSwitching1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

