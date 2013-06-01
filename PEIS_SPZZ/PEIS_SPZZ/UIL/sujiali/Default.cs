using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEIS_SPZZ.BLL;
using PEIS_SPZZ.SFL;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.UIL.UserControls;


namespace PEIS_SPZZ.UIL.sujiali
{
    /// <summary>
    /// 对象说明：该界面显示所有“个人身体状况”的信息列表，可以通过该界面导航到相应的添加、修改、删除界面。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013/6/1
    /// </summary>
    public partial class Default : Form
    {
        private static Default instance;
        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Default Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Default();
                }
                BindDataGrid(); // 每次返回该控件的实例前，都将对DataGridView控件的数据源进行重新绑定。
                return instance;
            }
        }
        /// <summary>
        /// 对DataGridView控件的数据源进行绑定。
        /// </summary>
        private static void BindDataGrid()
        {
            instance.grxytzpb.DataControl = instance.grxytzdgv;
            instance.grxytzpb.DataSource = GRXYTZ_BLL.GetPageList(instance.grxytzpb.PageSize, instance.grxytzpb.CurPage);
            instance.grxytzpb.DataBind();
        }
        public Default()
        {
            InitializeComponent();
        }




   

        /// <summary>
        /// 显示最后一页的数据，该方法为静态方法，供外界控制信息列表页数调用。
        /// </summary>
        public static void GotoLastPage()
        {
            instance.grxytzpb.CurPage = int.MaxValue;
        }

        private void grxytzdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //用户单击DataGridView“操作”列中的“修改”按钮。
            if (DataGridViewActionButtonCell.IsModifyButtonClick(sender, e))
            {
                string objectId = grxytzdgv["actioncol", e.RowIndex].Value.ToString(); // 获取所要修改关联对象的主键。
             //   Modify.LoadDataById(objectId);                                       // 根据关联对象的主键，从数据库中获取信息。
            //    FormMain.LoadNewControl(Modify.Instance);                            // 载入该模块的修改信息界面至主窗体显示。
            }

            //用户单击DataGridView“操作”列中的“删除”按钮。
            if (DataGridViewActionButtonCell.IsDeleteButtonClick(sender, e))
            {
                string objectId = grxytzdgv["actioncol", e.RowIndex].Value.ToString(); // 获取所要删除关联对象的主键。
           //     Delete.LoadDataById(objectId);                                       // 根据关联对象的主键，从数据库中获取信息。
            //    FormMain.LoadNewControl(Delete.Instance);                            // 载入该模块的删除信息界面至主窗体显示。
            }
        }

         /// <summary>
        /// PageBar控件的当前页码发生变更时的事件处理方法。
        /// </summary>
        private void grxytzpb_PageChanged(object sender, EventArgs e)
        {
            BindDataGrid(); //重新对DataGridView控件的数据源进行绑定。
        }

        private void grxytzpb_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }

    }
}
