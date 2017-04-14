using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementBackground.DatabaseContext;
using LibraryManagementBackground.Models;
using LibraryManagementBackground.Util;

namespace LibraryManagementBackground.Forms
{
    public partial class FrmUpdateUser : Form
    {
        public delegate void SuccessHandler(string address);
        public event SuccessHandler Success;
        private readonly TUser _entity;
        public FrmUpdateUser(TUser entity)
        {
            InitializeComponent();
            _entity = entity;
            txtCardCode.Text = entity.Cardcode;
            txtStudentCode.Text = entity.Patroncode;
            txtName.Text = entity.Name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var message = Models.Message.SuccecssMessage;
            try
            {
                using (var db = new MsSqlDbContext())
                {
                    var entity = db.User.Single(x => x.Id == _entity.Id);
                    txtCardCode.Text = entity.Cardcode;
                    txtStudentCode.Text = entity.Patroncode;
                    txtName.Text = entity.Name;
                    entity.Updatedate = DateTime.Now;
                    //db.Entry(entity).State = System.Data.Entity.EntityState.Modified;//修改
                    db.SaveChanges();
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
            Success?.Invoke(Name);
            MessageBox.Show(message, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"您确认退出吗？", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
