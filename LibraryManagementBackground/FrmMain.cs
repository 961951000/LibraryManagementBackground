using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using LibraryManagementBackground.DatabaseContext;
using LibraryManagementBackground.Forms;
using LibraryManagementBackground.Models;

namespace LibraryManagementBackground
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            #region listView初始化
            /*listView1.GridLines = true;//表格是否显示网格线
            listView1.FullRowSelect = true;//是否选中整行
            listView1.View = View.Details;//设置显示方式
            listView1.Scrollable = true;//是否自动显示滚动条
            listView1.MultiSelect = false;//是否可以选择多行
            listView1.Columns["ProductName"].Width = -1;//根据内容设置宽度
            listView1.Columns["SN"].Width = -2;//根据标题设置宽度*/
            #endregion
            using (var db = new MsSqlDbContext())
            {
                var books = db.Book.ToList();
                var users = db.User.ToList();
                var circulation = db.Circulation.ToList();
            }
        }
        void Success(string address)
        {
            switch (address)
            {
                case "FrmAddInstrument":
                    {
                        btnLabelSwitchingQuery_Click(null, null);
                    }
                    break;
                case "FrmUpdateInstrument":
                    {
                        btnLabelSwitchingQuery_Click(null, null);
                    }
                    break;
            }
        }
        private void tabMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == pageQueryStatistics)
            {
                MessageBox.Show("查询统计");
            }
            else if (e.TabPage == pageLabelSwitching)
            {
                cboLabelSwitchingQueryOrder.SelectedIndex = 2;
                using (var db = new MsSqlDbContext())
                {
                    var books = db.Book.OrderByDescending(x => x.Createdate).ToList();
                    for (var i = 0; i < books.Count; i++)
                    {
                        var book = books[i];
                        var item = new ListViewItem();
                        item.SubItems.Clear();
                        item.Text = book.Id.ToString();
                        item.SubItems.Add((i + 1).ToString());
                        item.SubItems.Add(book.Tid);
                        item.SubItems.Add(book.Name);
                        item.SubItems.Add(book.Author);
                        item.SubItems.Add(book.Createdate.ToString());
                        item.SubItems.Add(book.Updatedate.ToString());
                        lvwBook.Items.Add(item);
                    }
                }
            }
            else if (e.TabPage == pageMakingCard)
            {
                MessageBox.Show("开证办卡");
            }
        }
        /// <summary>
        /// 查询仪器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingQuery_Click(object sender, EventArgs e)
        {
            lvwBook.Items.Clear();
            using (var db = new MsSqlDbContext())
            {
                var instrumentName = txtInstrumentName.Text;
                var instrumentType = txtInstrumentType.Text;
                IQueryable<TBook> query = db.Book;
                if (!string.IsNullOrEmpty(instrumentName))
                {
                    query = query.Where(x => x.Name.Contains(instrumentName));
                }
                if (!string.IsNullOrEmpty(instrumentType))
                {
                    query = query.Where(x => x.Author.Contains(instrumentType));
                }
                switch (cboLabelSwitchingQueryOrder.SelectedIndex)
                {
                    case 0:
                        {
                            query = rdoLabelSwitchingQueryOrderAsc.Checked ? query.OrderBy(x => x.Name) : query.OrderByDescending(x => x.Name);
                        }
                        break;
                    case 1:
                        {
                            query = rdoLabelSwitchingQueryOrderAsc.Checked ? query.OrderBy(x => x.Author) : query.OrderByDescending(x => x.Author);
                        }
                        break;
                    case 2:
                        {
                            query = rdoLabelSwitchingQueryOrderAsc.Checked ? query.OrderBy(x => x.Createdate) : query.OrderByDescending(x => x.Createdate);
                        }
                        break;
                    case 3:
                        {
                            query = rdoLabelSwitchingQueryOrderAsc.Checked ? query.OrderBy(x => x.Updatedate) : query.OrderByDescending(x => x.Updatedate);
                        }
                        break;
                }
                var books = query.ToList();
                for (var i = 0; i < books.Count; i++)
                {
                    var book = books[i];
                    var item = new ListViewItem();
                    item.SubItems.Clear();
                    item.Text = book.Id.ToString();
                    item.SubItems.Add((i + 1).ToString());
                    item.SubItems.Add(book.Tid);
                    item.SubItems.Add(book.Name);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.Createdate.ToString());
                    item.SubItems.Add(book.Updatedate.ToString());
                    lvwBook.Items.Add(item);
                }
            }
        }
        /// <summary>
        /// 标签转换-新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmAddInstrument
            {
                StartPosition = FormStartPosition.CenterParent,
            };
            form.Success += Success;
            form.ShowDialog();
        }
        /// <summary>
        /// 标签转换-表格导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingImport_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Title = @"请选择文件",
                Filter = @"所有文件(*.*)|*.*"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        ///  标签转换-下载表格模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingDownload_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog()
            {
                Description = @"请选择文件路径"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 标签转换-修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwBook.SelectedIndices.Count > 0)
                {
                    var items = lvwBook.FocusedItem.SubItems;
                    var entity = new TBook
                    {
                        Id = Convert.ToInt32(items[0].Text),
                        Tid = items[2].Text,
                        Name = items[3].Text,
                        Author = items[4].Text
                    };
                    var form = new FrmUpdateInstrument(entity)
                    {
                        StartPosition = FormStartPosition.CenterParent,
                    };
                    form.Success += Success;
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// 标签转换-删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingDelete_Click(object sender, EventArgs e)
        {
            var message = "操作成功！";
            try
            {
                if (lvwBook.SelectedIndices.Count > 0)
                {
                    var items = lvwBook.FocusedItem.SubItems;
                    using (var db = new MsSqlDbContext())
                    {
                        var id = Convert.ToInt32(items[0].Text);
                        var entity = db.Book.Single(x => x.Id == id);
                        db.Book.Remove(entity);
                        db.SaveChanges();
                    }
                    btnLabelSwitchingQuery_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                message = "操作失败！";
                throw;
            }
            MessageBox.Show(message, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 加载Excel
        /// </summary>
        /// <param name="filePos">文件路径</param>
        /// <returns>数据表</returns>
        public static DataTable GetExcel(string filePos)
        {
            var connstr = "Provider=Microsoft.ACE.OLEDB.12.0 ;Data Source=" + filePos + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1'";
            //未在本地计算机上注册"Microsoft.ACE.OLEDB.12.0"  下载安装在  http://download.microsoft.com/download/7/0/3/703ffbcb-dc0c-4e19-b0da-1463960fdcdb/AccessDatabaseEngine.exe
            var ds = new DataSet();
            string tableName;
            using (var connection = new OleDbConnection(connstr))
            {
                connection.Open();
                var table = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                tableName = table?.Rows[0]["Table_Name"].ToString();
                var strExcel = "select * from " + "[" + tableName + "]";
                var adapter = new OleDbDataAdapter(strExcel, connstr);
                adapter.Fill(ds, tableName);
                connection.Close();
            }
            return ds.Tables[tableName];
        }
        /// <summary>        
        /// 下载文件        
        /// </summary>        
        /// <param name="path">下载文件地址</param>       
        /// <param name="filename">下载后的存放地址</param>        
        /// <param name="prog">用于显示的进度条</param>        
        /// <param name="label">用于显示的进度条百分比</param> 
        public void DownloadFile(string path, string filename, ProgressBar prog, Label label)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(path);
                var response = (HttpWebResponse)request.GetResponse();
                var totalBytes = response.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                var st = response.GetResponseStream();
                var so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                var by = new byte[1024];
                if (st != null)
                {
                    var osize = st.Read(by, 0, by.Length);
                    while (osize > 0)
                    {
                        totalDownloadedByte = osize + totalDownloadedByte;
                        Application.DoEvents();
                        so.Write(by, 0, osize);
                        if (prog != null)
                        {
                            prog.Value = (int)totalDownloadedByte;
                        }
                        osize = st.Read(by, 0, by.Length);

                        var percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                        label.Text = $@"当前补丁下载进度{percent}%";
                        Application.DoEvents(); //必须加注这句代码，否则label将因为循环执行太快而来不及显示信息
                    }
                }
                so.Close();
                st?.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
