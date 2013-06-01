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
    public partial class hosMain : Form
    {
        int[] mdi=new int[3];
        public hosMain()
        {
            InitializeComponent();
        }

        private void 个人预约ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 test = Form1.Instance;
             for (int i = 0; i < 3; i++)
            {
                if (mdi[i] == 0)
                {
                    mdi[i] = 1;
                    yuyue fm = new yuyue(mdi,i);
                    fm.MdiParent = this;
                    fm.Show();
                    break;
        }

        private void hosMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Dispose();
        }

        private void hosMain_Load(object sender, EventArgs e)
        {

        }

        private void 基本资料设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 用户字典ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userDic.userDic us = new userDic.userDic();
            us.Show();
        }
    }
}
