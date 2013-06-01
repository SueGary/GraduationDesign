using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEIS_SPZZ.UIL.userDic
{
    public partial class userDic : Form
    {
        public userDic()
        {
            InitializeComponent();
        }

        private void userDic_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tj_dbDataSet.TJ_YHB”中。您可以根据需要移动或删除它。
            //this.tJ_YHBTableAdapter.Fill(this.tj_dbDataSet.TJ_YHB);

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            penghaoran.addUserDic asDic = new penghaoran.addUserDic();
            asDic.Show();

        }

 
    }
}
