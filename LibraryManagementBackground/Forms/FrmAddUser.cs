﻿using System;
using System.Windows.Forms;
using LibraryManagementBackground.DatabaseContext;
using LibraryManagementBackground.Models;
using LibraryManagementBackground.Util;

namespace LibraryManagementBackground.Forms
{
    public partial class FrmAddUser : Form
    {
        public delegate void SuccessHandler(string address);
        public event SuccessHandler Success;
        public FrmAddUser()
        {
            InitializeComponent();
        }
        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            txtCardCode.Focus();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var message = Models.Message.SuccecssMessage;
            try
            {
                var entity = new TUser()
                {
                    Cardcode = txtCardCode.Text,
                    Patroncode = txtStudentCode.Text,
                    Name = txtName.Text,
                    Createdate = DateTime.Now,
                    Updatedate = DateTime.Now,
                    Createby = 0,
                    Updateby = 0
                };

                using (var db = new MsSqlDbContext())
                {
                    db.User.Add(entity);
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
