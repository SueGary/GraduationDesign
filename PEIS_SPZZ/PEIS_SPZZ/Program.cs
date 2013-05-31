using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PEIS_SPZZ.UIL;
using System.Threading;
using PEIS_SPZZ.UIL.Main;
using PEIS_SPZZ.UIL.login;

namespace PEIS_SPZZ
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 全局异常注册
            ApplicationEventHandlerClass AppEvents = new ApplicationEventHandlerClass();
            Application.ThreadException += new ThreadExceptionEventHandler(AppEvents.OnThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new hosMain());

         
        }
        // 全局异常处理
        public class ApplicationEventHandlerClass
        {
            public void OnThreadException(object sender, ThreadExceptionEventArgs e)
            {
                Form1.ShowException(e.Exception);

               // FormSysMessage.ShowException(e.Exception); // 调用FormSysMessage窗体，显示异常信息。
            }
        }
    }
}
