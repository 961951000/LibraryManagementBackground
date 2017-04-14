using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementBackground.Models;

namespace LibraryManagementBackground.ViewModels
{
    public class CirculationView
    {
        #region Model
        /// <summary>
        /// 编号
        /// </summary>
        public int? Id
        {
            set;
            get;
        }
        /// <summary>
        /// 流通类型
        /// </summary>
        public string Circulationtype
        {
            set;
            get;
        }
        /// <summary>
        /// 图书电子标签
        /// </summary>
        public string Bookbarcode
        {
            set;
            get;
        }
        /// <summary>
        /// 学籍号
        /// </summary>
        public string Patroncode
        {
            set;
            get;
        }
        /// <summary>
        /// 借出时间
        /// </summary>
        public DateTime? LendTime
        {
            set;
            get;
        }
        /// <summary>
        /// 归还时间
        /// </summary>
        public DateTime? ReturnTime
        {
            set;
            get;
        }
        /// <summary>
        /// 仪器型号
        /// </summary>
        public string BookName
        {
            set;
            get;
        }
        /// <summary>
        /// 读者卡号
        /// </summary>
        public string Author
        {
            set;
            get;
        }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string UserName
        {
            set;
            get;
        }
        /// <summary>
        /// 读者卡号
        /// </summary>
        public string CardCode
        {
            set;
            get;
        }
        #endregion Model
    }
}
