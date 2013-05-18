using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PEIS_SPZZ.UIL.Reporter
{
    public partial class reporter : Form
    {
        public reporter()
        {
            InitializeComponent();
        }

        private void reporter_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tj_dbDataSet.GRMZYD”中。您可以根据需要移动或删除它。
            this.gRMZYDTableAdapter.Fill(this.tj_dbDataSet.GRMZYD);
            // TODO: 这行代码将数据加载到表“tj_dbDataSet.GRBJ”中。您可以根据需要移动或删除它。
            this.gRBJTableAdapter.Fill(this.tj_dbDataSet.GRBJ);

            this.reportViewer1.RefreshReport();
        }
    }
}
