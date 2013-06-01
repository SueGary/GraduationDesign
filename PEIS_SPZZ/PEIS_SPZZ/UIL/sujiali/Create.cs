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

namespace PEIS_SPZZ.UIL.sujiali
{
    /// <summary>
    /// 对象说明：该界面用于添加“个人身体状况信息”对象至数据库，添加操作成功后返回列表界面。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013/6/1
    /// </summary>
    public partial class Create : Form
    {
        private COL.GRXYTZ gRXYTZ;
        private static Create instance;
        public static Create Instance
        {
            get {
                if (instance == null) {
                    instance = new Create();
                }
                instance.gRXYTZ = new COL.GRXYTZ();
         //       instance.ssybox.Focus();
                instance.BindObjectToForm();
                return instance;
            }
        }

        private void BindObjectToForm()
        {
             ssybox.Text=gRXYTZ.Ssy ;  //收缩压
             szybox.Text=gRXYTZ.Szy;  //舒张压
             weightbox.Text=gRXYTZ.Tz ;  //体重
             xlbox.Text=gRXYTZ.Xl ;  //心率
            dtbox.Text=gRXYTZ.Rqsj;//日期
        }


        private Create()
        {
            InitializeComponent();
            this.ControlBox = false;
           
        }



        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormToObject() {
            gRXYTZ.Ssy = DataValid.GetNullOrString(ssybox.Text);  //收缩压
            gRXYTZ.Szy = DataValid.GetNullOrString(szybox.Text);  //舒张压
            gRXYTZ.Tz = DataValid.GetNullOrString(this.weightbox.Text);  //体重
            gRXYTZ.Xl = DataValid.GetNullOrString(this.xlbox.Text);  //心率
            gRXYTZ.Rqsj = DataValid.GetNullOrString(this.dtbox.Text);//日期
            gRXYTZ.Id = DataValid.GetNullOrInt(idbox.Text); //ID
            gRXYTZ.Tjryid = DataValid.GetNullOrString(this.tjryidbox.Text);  //体检人员ID
              
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            BindFormToObject();
            GRXYTZ_BLL.Insert(gRXYTZ);  // 调用“业务逻辑层”的方法，检查有效性后插入至数据库。
            Form1.ShowSuccessMsg("“个人身体状况信息”添加成功，单击“确定”按钮返回信息列表。");
            Default.GotoLastPage();
        }

        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void Create_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
