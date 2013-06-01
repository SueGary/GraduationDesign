using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEIS_SPZZ.SFL;
using PEIS_SPZZ.BLL;

namespace PEIS_SPZZ.UIL.sujiali
{
    /// <summary>
    /// 对象说明：该界面用于修改“个人身体状况”对象并提交至数据库，修改操作成功后返回列表界面。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013/6/1
    /// </summary>
    public partial class Modify : Form
    {
        private COL.GRXYTZ gRXYTZ;
        private static Modify instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Modify Instance
        {
            get
            {
                if (instance == null)
                {
                    
                    instance = new Modify();
                }

                if (instance.gRXYTZ == null)
                    throw new CustomException("在调用本模块修改界面的实例前，必须调用Modify.LoadDataById方法，装载所要修改的关联对象。", ExceptionType.Error);

             
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象当前的值，绑定至界面控件进行显示。
                return instance;
            }
        }

     
        /// <summary>
        /// 根据关联对象的主键，从数据库中获取关联对象信息，以备进行修改操作。
        /// </summary>
        public static void LoadDataById(string gRXXSerialId)
        {
            if (instance == null)
            {
                instance = new Modify();
            }
            instance.gRXYTZ = GRXYTZ_BLL.GetDataBySerialId(gRXXSerialId);
            if (instance.gRXYTZ == null)
                throw new CustomException("对不起，所要修改的信息不存在或已删除。");
        }

             Modify()
        {
            InitializeComponent();
            this.ControlBox = false;
                
        }
        /// <summary>
        /// 用户单击“保存”按钮时的事件处理方法。
        /// </summary>
        private void savebtn_Click(object sender, EventArgs e)
        {
            BindFormlToObject(); // 进行数据绑定
            GRXYTZ_BLL.Update(gRXYTZ); // 调用“业务逻辑层”的方法，检查有效性后更新至数据库。
            Form1.ShowSuccessMsg("“个人信息”修改成功，单击“确定”按钮返回信息列表。");
            this.Visible = false;  // 载入该模块的信息列表界面至主窗体显示。
            Default.Refresh();
        }

   
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 载入该模块的信息列表界面至主窗体显示。
        }

        #region 界面控件与关联对象之间的绑定方法
        /// <summary>
        /// 
        /// </summary>
        private void BindFormlToObject()
        {
            gRXYTZ.Ssy = DataValid.GetNullOrString(ssybox.Text);  //收缩压
            gRXYTZ.Szy = DataValid.GetNullOrString(szybox.Text);  //舒张压
            gRXYTZ.Tz = DataValid.GetNullOrString(this.weightbox.Text);  //体重
            gRXYTZ.Xl = DataValid.GetNullOrString(this.xlbox.Text);  //心率
            gRXYTZ.Rqsj = DataValid.GetNullOrString(this.dtbox.Text);//日期
         //   gRXYTZ.Id = DataValid.GetNullOrInt(idbox.Text); //ID
        //    gRXYTZ.Tjryid = DataValid.GetNullOrString(this.tjryidbox.Text);  //体检人员ID
        }
        /// <summary>
        /// 
        /// </summary>
        private void BindObjectToForm()
        {
            ssybox.Text=gRXYTZ.Ssy ;      //收缩压
            szybox.Text=gRXYTZ.Szy;        //舒张压
            this.weightbox.Text=gRXYTZ.Tz;  //体重
            this.xlbox.Text=gRXYTZ.Xl;     //心率
            this.dtbox.Text=gRXYTZ.Rqsj; //日期
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitControl()
        {
            throw new NotImplementedException();
        }





        #endregion 界面控件与关联对象之间的绑定方法













    }
}
