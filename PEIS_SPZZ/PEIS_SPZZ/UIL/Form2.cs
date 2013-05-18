using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.BLL;
using PEIS_SPZZ.SFL;


namespace PEIS_SPZZ.UIL
{
    public partial class Form2 : Form
    {
        
        private string id;
        public  string Id 
        {
            
            get { return id; }
            set { id = value; }
        }
        public Form2()
        {
            InitializeComponent();
        //    this.SJ.Text = datetime.Text;
        }
        private GRMZYD gRMZYD=new GRMZYD();

        private void BindFormToObject()
        {
            DataValid.IsOutLength(id, 10);
            gRMZYD.Sj =Convert.ToString(datetime.Text);
            gRMZYD.TjryId = id;
            gRMZYD.YdId = "11111";
            gRMZYD.Jhyd = "1111";
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
    
             BindFormToObject();
            GRMZYD_BLL.Insert(gRMZYD);
            Form1.ShowSuccess("“计划运动”添加成功，单击“确定”按钮返回信息列表");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
