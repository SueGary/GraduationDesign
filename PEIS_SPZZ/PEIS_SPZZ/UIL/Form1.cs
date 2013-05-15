using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.UIL
{
    public partial class Form1 : Form
    {
        private static Form1 instance;
        /// <summary>
        /// 返回该窗体的唯一实例。如果之前该窗体没有被创建，进行创建并返回该窗体的唯一实例。
        /// 此处采用单键模式对窗体的唯一实例进行控制，以便外界窗体或控件可以随时访问本窗体。
        /// </summary>
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }
        private Form1()
        {    
            InitializeComponent();
          //  this.label1.Text = a;
           // this.label2.Text = b;
        }

        public static void ShowException(Exception exception)
        {
            Form1 formSysMessage = new Form1();
            formSysMessage.label1.Text = exception.Message;

            if (exception is CustomException)
            {
                CustomException customException = exception as CustomException;
                switch (customException.Type)
                {
                    case ExceptionType.Info: // 提示信息
                        formSysMessage.pictureBox1.Image = PEIS_SPZZ.Properties.Resources.TipInfo;
                        formSysMessage.pictureBox1.Image = PEIS_SPZZ.Properties.Resources.MessageInfo;
                        break;

                    case ExceptionType.Warn: // 警告信息
                        formSysMessage.pictureBox1.Image = PEIS_SPZZ.Properties.Resources.TipWarn;
                        formSysMessage.pictureBox2.Image = PEIS_SPZZ.Properties.Resources.MessageWarn;
                        break;

                    default:                 // 错误信息
                        formSysMessage.pictureBox1.Image = PEIS_SPZZ.Properties.Resources.TipError;
                        formSysMessage.pictureBox2.Image = PEIS_SPZZ.Properties.Resources.MessageError;
                        break;

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
