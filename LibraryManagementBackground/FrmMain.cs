using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using LibraryManagementBackground.DatabaseContext;
using LibraryManagementBackground.Forms;
using LibraryManagementBackground.Models;
using LibraryManagementBackground.Util;

namespace LibraryManagementBackground
{

    public partial class FrmMain : Form, IMessageFilter
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

            Init();
            using (var db = new MsSqlDbContext())
            {
                var books = db.Book.ToList();
                var users = db.User.ToList();
                var circulation = db.Circulation.ToList();
            }
        }

        private void Init()
        {
            lblLabelSwitchingProgress1.Text = string.Empty;
            lblLabelSwitchingProgress2.Text = string.Empty;
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
        /// 标签转换-查询
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
            try
            {
                Application.AddMessageFilter(this); //鼠标锁定
                Cursor = Cursors.WaitCursor;
                btnLabelSwitchingImport.Enabled = false;
                var fileDialog = new OpenFileDialog
                {
                    Multiselect = true,
                    Title = @"请选择文件",
                    Filter = @"所有文件(*.*)|*.*"
                };
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var file = fileDialog.FileName;
                    var dt = GetExcel(file);
                    ProgressBar prog;
                    Label label;
                    if (!prgLabelSwitching1.Visible)
                    {
                        prog = prgLabelSwitching1;
                        label = lblLabelSwitchingProgress1;
                    }
                    else
                    {
                        prog = prgLabelSwitching2;
                        label = lblLabelSwitchingProgress2;
                    }
                    LabelSwitchingImport(dt, prog, label);
                    btnLabelSwitchingQuery_Click(null, null);
                    MessageBox.Show(@"数据导入完成！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OleDbException odex) when (odex.Message == "外部表不是预期的格式。")
            {
                MessageBox.Show($@"{Models.Message.FailMessage}{odex.Message}", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Models.Message.FailMessage, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
#if DEBUG
                throw;
#else
                Loger.Error(ex);
#endif
            }
            finally
            {
                btnLabelSwitchingImport.Enabled = true;
                Application.RemoveMessageFilter(this);//鼠标解锁
                Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// 标签转换-表格导入
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="prog">用于显示的进度条</param>
        /// <param name="label">用于显示的进度条百分比</param>
        private void LabelSwitchingImport(DataTable dt, ProgressBar prog, Label label)
        {
            try
            {
                prog.Visible = true;
                prog.Maximum = dt.Rows.Count;
                using (var db = new MsSqlDbContext())
                {
                    var tran = db.Database.BeginTransaction();
                    try
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            var entity = new TBook
                            {
                                Tid = Convert.ToString(dr[0]),
                                Name = Convert.ToString(dr[1]),
                                Author = Convert.ToString(dr[2]),
                                Createdate = DateTime.Now,
                                Updatedate = DateTime.Now,
                                Barcode = "默认",
                                Callcode = "默认",
                                Status = "默认",
                                Createby = 0,
                                Updateby = 0
                            };
                            var item = ItemDetailBatch.BatchAdd(entity);
                            db.Database.ExecuteSqlCommand(item.Key, item.Value.ToArray<object>());
                            prog.Value++;
                            var percent = Convert.ToSingle(prog.Value) / Convert.ToSingle(prog.Maximum) * 100;
                            label.Text = $@"导入进度{percent:F2}%";
                            Application.DoEvents(); //必须加注这句代码，否则label将因为循环执行太快而来不及显示信息
                        }
                        tran.Commit();
                    }
                    catch (SqlException)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                throw;
#else
                Loger.Error(ex);
#endif
            }
            finally
            {
                prog.Visible = false;
                prog.Value = 0;
                label.Text = string.Empty;
            }
        }
        /// <summary>
        ///  标签转换-下载表格模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingDownload_Click(object sender, EventArgs e)
        {
            btnLabelSwitchingDownload.Enabled = false;
            try
            {
                var dialog = new FolderBrowserDialog()
                {
                    Description = @"请选择文件保存路径"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var foldPath = dialog.SelectedPath;
                    var path = Path.GetFullPath(@"../../Resource/Tool/ubuntu-16.10-desktop-amd64.iso");
                    var filename = Path.Combine(foldPath, Path.GetFileName(path));
                    ProgressBar prog;
                    Label label;
                    if (!prgLabelSwitching1.Visible)
                    {
                        prog = prgLabelSwitching1;
                        label = lblLabelSwitchingProgress1;
                    }
                    else
                    {
                        prog = prgLabelSwitching2;
                        label = lblLabelSwitchingProgress2;
                    }
                    DownloadFile(path, filename, prog, label);
                    MessageBox.Show(@"文件下载完成！", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Models.Message.FailMessage, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
#if DEBUG
                throw;
#else
                Loger.Error(ex);
#endif
            }
            finally
            {
                btnLabelSwitchingDownload.Enabled = true;
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
#if DEBUG
                throw;
#else
                Loger.Error(ex);
#endif
            }
        }
        /// <summary>
        /// 标签转换-删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLabelSwitchingDelete_Click(object sender, EventArgs e)
        {
            var message = Models.Message.SuccecssMessage;
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
                message = Models.Message.FailMessage;
#if DEBUG
                throw;
#else
                Loger.Error(ex);
#endif
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
        private void DownloadFile(string path, string filename, ProgressBar prog, Label label)
        {
            try
            {
                var request = (FileWebRequest)WebRequest.Create(path);
                var response = (FileWebResponse)request.GetResponse();
                var totalBytes = response.ContentLength;
                if (totalBytes > int.MaxValue)
                {
                    MessageBox.Show(@"下载文件大小超过限制");
                    return;
                }

                if (prog != null)
                {
                    prog.Visible = true;
                    prog.Maximum = (int)totalBytes;
                }
                var st = response.GetResponseStream();
                var so = new FileStream(filename, FileMode.Create);
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
                        var percent = Convert.ToSingle(totalDownloadedByte) / Convert.ToSingle(totalBytes) * 100;
                        label.Text = $@"下载进度{percent:F2}%";
                        Application.DoEvents(); //必须加注这句代码，否则label将因为循环执行太快而来不及显示信息
                    }
                }
                so.Close();
                st?.Close();
            }
            catch (Exception ex)
            {
#if DEBUG
                throw;
#else
                Loger.Error(ex);
#endif
            }
            finally
            {
                if (prog != null)
                {
                    prog.Visible = false;
                    prog.Value = 0;
                }
                label.Text = string.Empty;
            }
        }

        public bool PreFilterMessage(ref System.Windows.Forms.Message m)
        {
            if (m.Msg >= 513 && m.Msg <= 515)
            {
                return true;
            }
            return false;
        }
    }
}
