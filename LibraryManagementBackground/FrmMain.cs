using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementBackground.DatabaseContext;

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
                for (int i = 0; i < books.Count; i++)
                {
                    var book = books[i];
                    var item = new ListViewItem();
                    item.SubItems.Clear();
                    item.Text = book.Id.ToString();
                    item.SubItems.Add((i + 1).ToString());
                    item.SubItems.Add(book.Name);
                    item.SubItems.Add(book.Author);
                    item.SubItems.Add(book.Createdate.ToString());
                    item.SubItems.Add(book.Updatedate.ToString());
                    lvwBook.Items.Add(item);
                }
            }
        }
        private void tabMain_Selected(object sender, TabControlEventArgs e)
        {
            /*if (e.TabPage == pageQueryStatistics)
            {
                MessageBox.Show("查询统计");
            }
            else
            if (e.TabPage == pageLabelSwitching)
            {
                MessageBox.Show("标签转换");
            }
            else
            if (e.TabPage == pageMakingCard)
            {
                MessageBox.Show("开证办卡");
            }*/
        }
    }
}
