using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.UIL
{

    public partial class Form3 : Form
    {
            
   //  生成字符串：
     private string GenerateId()
     {
        long i = 1;
          foreach (byte b in Guid.NewGuid().ToByteArray())
          {
              i *= ((int)b + 1);
          }
          return string.Format("{0:x}", i - DateTime.Now.Ticks);
       //  string.Format(,)
      }
 

   // 生成数字：

    private long GenerateId1()
    {
        byte[] buffer = Guid.NewGuid().ToByteArray();
        return BitConverter.ToInt64(buffer, 0);
    }
 
   // 按时间生成：
   // String.Format("{0}{1}", DateTime.Now.ToString("yyyyMMddHHmmss"),Guid.NewGuid().ToString().Split('-')[4]);
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Method.StringToDatetime(textBox1.Text);
          //  Debug.Write(Method.StringToDatetime(textBox1.Text));
            //Form2 tes = new Form2();
           // tes.Id = "09207106541";
           // tes.ShowDialog();
            //   int a=1;
            //GenerateId();
            DateTime test=DateTime.Now;
           Debug.Write("测试©"+test.ToString());
           // Label test1 = new Label();
           // this.label1.Text = Method.CreateLiuShuiId().ToString();
            //  test.s
           // test1.Show();
          //  Debug.Write(GenerateId1()+"\n");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
