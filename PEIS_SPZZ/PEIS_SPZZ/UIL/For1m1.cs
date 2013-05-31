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
    public partial class For1m1 : Form
    {
        private static Size detailModeSize = new Size(700, 350);
        private static For1m1 instance;
        /// <summary>
        /// 返回该窗体的唯一实例。如果之前该窗体没有被创建，进行创建并返回该窗体的唯一实例。
        /// 此处采用单键模式对窗体的唯一实例进行控制，以便外界窗体或控件可以随时访问本窗体。
        /// </summary>
        public static For1m1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new For1m1();              
                }
                return instance;
            }
        }
        private For1m1()
        {    
            InitializeComponent();
          //  this.label1.Text = a;
           // this.label2.Text = b;
        }
        /// <summary>
        /// 根据异常信息，给用户提示异常描述
        /// </summary>
        /// <param name="exception"></param>
        public static void ShowException(Exception exception)
        {
            For1m1 formSysMessage = new For1m1();
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
                // 判断是否需要显示异常的详细信息，如具体异常原因，执行的SQL语句等。可由App.Config配置。
                if (System.Configuration.ConfigurationManager.AppSettings["ShowExceptionDetail"] == "true")
                {
                    if (!string.IsNullOrEmpty(customException.DetailMessage))
                    {
                        formSysMessage.label2.Visible = true;
                        formSysMessage.label2.Text = customException.DetailMessage;
                        formSysMessage.Size = detailModeSize;
                    }

            }
       
            }
            formSysMessage.ShowDialog();
        }
        /// <summary>
        /// 无异常，提示操作成功
        /// </summary>
        /// <param name="message">描述内容</param>
        public static void ShowSuccess(string message)
        {
            For1m1 formSysMessage = new For1m1();
            formSysMessage.label1.Text = message; ;
            formSysMessage.ShowDialog();
        
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
