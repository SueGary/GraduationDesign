using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PEIS_SPZZ.UIL.penghaoran
{
    public partial class addUserDic : Form
    {
        public addUserDic()
        {
            InitializeComponent();
        }
        public bool seleUserDic()
        {
            bool validateUser = false;
            
            try
            {                
                string selectSql = string.Format("select count(*) from TJ_YHB where YHID = '{0}' or YHM = '{1}'", textBox1.Text, textBox3.Text);
                SqlCommand sqlSelectCmd = new SqlCommand(selectSql);
                int i = (int)sqlSelectCmd.ExecuteScalar();
                if (i > 0)
                {
                    validateUser = true;
                }

            }
            catch (System.Exception ex)
            {
            	MessageBox.Show("错误：" + ex.Message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();  
            }
            return validateUser;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                if (seleUserDic())
                {
                    MessageBox.Show("对不起，您所输入的用户编号或用户名已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string sql;
                        sql = "insert into TJ_YHB(YHID,YHXM,YHM,MM,TJKS,KSBM,YHQX,QXBM) values ('";
                        sql += textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + textBox7.Text + "' , '" + textBox8.Text + "')";
                        SqlCommand sqlcmd = new SqlCommand(sql);
                        int i = sqlcmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("添加失败!\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("请填完整相关信息!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
