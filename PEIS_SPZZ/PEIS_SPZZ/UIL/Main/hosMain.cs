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
        public hosMain()
        {
            InitializeComponent();
        }

        private void 个人预约ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 test = Form1.Instance;
        }

        private void hosMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void hosMain_Load(object sender, EventArgs e)
        {

        }

        private void 基本资料设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
