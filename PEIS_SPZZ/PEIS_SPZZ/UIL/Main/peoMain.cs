using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEIS_SPZZ.UIL.Main
{
    public partial class peoMain : Form
    {
        /// <summary>
        /// 【变量】标识登录用户的身份
        /// </summary>
        private string id;
        /// <summary>
        /// 【属性】标识登录用户的身份
        /// </summary>
        public string Id {
            get { return id; }
            set { id = value; }
        }
        public peoMain()
        {
            InitializeComponent();
        }
    }
}
