using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PEIS_SPZZ.UIL.userDic
{
    public partial class userDic : Form
    {
        DataSet dataset1;
        BindingManagerBase bmb;
        public userDic()
        {
            InitializeComponent();
        }
        public DataSet selectYh(string sqlselect)
        {
            DBConnection.DtPh.Open();
            DataSet dataset = new DataSet();
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlselect, DBConnection.DtPh);
                dataAdapter.Fill(dataset, "TJ_YHB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                DBConnection.DtPh.Close(); 
            }
            return dataset;
        }
        private void userDic_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“tj_dbDataSet.TJ_YHB”中。您可以根据需要移动或删除它。
            //this.tJ_YHBTableAdapter.Fill(this.tj_dbDataSet.TJ_YHB);
            string selectYh1 = string.Format("select YHID as '用户编码',YHXM as '用户姓名',YHM as '用户名',MM as '密码',TJKS as '体检科室',KSBM as '科室编码',YHQX as '用户权限',QXBM as '权限编码'from TJ_YHB");
            dataset1 = new DataSet(); 
            dataset1 = selectYh(selectYh1);
            dataGridView1.DataSource = dataset1.Tables["TJ_YHB"];
            bmb = this.BindingContext[dataset1.Tables["TJ_YHB"]];
            if (dataGridView1.Rows.Count != 0)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; i += 2)
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FloralWhite;
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            penghaoran.addUserDic asDic = new penghaoran.addUserDic();
            asDic.Show();

        }

 
    }
}
