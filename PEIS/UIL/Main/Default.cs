using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SUJIALI.PEIS.BLL;
using SUJIALI.PEIS.COL;
using SUJIALI.PEIS.SFL;

namespace SUJIALI.PEIS.UIL.Main
{
    /// <summary>
    /// 对象名称：“欢迎使用”用户控件（用户界面层）
    /// 对象说明：用户进入系统时，用于显时系统相关欢迎信息的模块。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013/5/5 14:41:42
    /// </summary>
    public partial class Default : UserControl
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
                return instance;
            }
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private Default()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }


    }
}
