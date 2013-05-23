using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace PEIS_SPZZ.UIL
{
    public partial class GraphForm : Form
    {
        LineItem myCurve;
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            
            //设置折线图名称和坐标轴名称
            this.zedGraphControl1.GraphPane.Title.Text = "烘干塔温度折线图";
            this.zedGraphControl1.GraphPane.XAxis.Title.Text = "时间";
            this.zedGraphControl1.GraphPane.YAxis.Title.Text = "温度";
            //如果坐标轴标度不想使用数值，而是使用文本，需要设置坐标轴类型为text
            this.zedGraphControl1.GraphPane.XAxis.Type = AxisType.Text;
            //定义一个datetime类型的变量a，用来接收数据表中日期时间类型的数据
            DateTime a;
           
            string[] monthX;
         
            #region 周记录
            if (comboBox1.Text == "周记录")
            {
                string[] weekX = new string[7];
                for (int i = 6; i >= 0; i--)
                {
                    switch (i)
                    {
                        case 0: weekX[i] = "周一";
                            break;
                        case 1: weekX[i] = "周二";
                            break;
                        case 2: weekX[i] = "周三";
                            break;
                        case 3: weekX[i] = "周四";
                            break;
                        case 4: weekX[i] = "周五";
                            break;
                        case 5: weekX[i] = "周六";
                            break;
                        case 6: weekX[i] = "周日";
                            break;
                    }
                }
                this.zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = weekX;
            }
            #endregion
            #region 月记录
            if (comboBox1.Text == "月记录")
            {
                double[] szy = new double[10];
                string[] weekX = new string[30];
                for (int i = 29; i >= 0; i--)
                {
                    weekX[i] = (i+1).ToString();
                    //switch (i)
                    //{
                    //    case 0: weekX[i] = "周一";
                    //        break;
                    //    case 1: weekX[i] = "周二";
                    //        break;
                    //    case 2: weekX[i] = "周三";
                    //        break;
                    //    case 3: weekX[i] = "周四";
                    //        break;
                    //    case 4: weekX[i] = i.ToString();
                    //        break;
                    //    case 5: weekX[i] = i.ToString();
                    //        break;
                    //    case 6: weekX[i] = i.ToString();
                    //        break;
                    //}
                }
                this.zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = weekX;
                if (myCurve == null)
                    myCurve = this.zedGraphControl1.GraphPane.AddCurve("温度", null, szy, Color.Red, SymbolType.None);
            }
            #endregion
           
            //若想从数据表的所有数据中找出最近的十条数据，可以用top关键字，该关键字的功能是将排序查询结果的前n条记录找出来
         //   MyDS_Grid = MyDataClass.getDataSet("Select top 10 * from tb_zzt order by pczsj desc", "tb_zzt");

            //若想向统计图中输出显示结果，需要注意上一步排序结果是降序，而显示时应该是升序，所以此处向数组赋值时应该反序
            //if (comboBox1.Text == "周记录")
            
    
             //   this.zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = weekX;
              
                a = (DateTime)MyDS_Grid.Tables[0].Rows[i][0];
                szx[-(i - 9)] = a.ToString("hh:mm:ss");
               szy[-(i - 9)] = Convert.ToDouble(MyDS_Grid.Tables[0].Rows[i][8]);
            
            //addcurve方法的几个参数分别代表了：1折线表示含义；2X轴数据；3Y轴数据；4折线颜色；5折线类型
            //此处需要注意，若两坐标轴均为数值型，则直接添加到addcurve方法中即可，本实例的X轴采用了text类型，所以使用addcurve方法时
            //X轴数据设置为空null，然后再在后面单独添加
          //  LineItem myCurve;
           
          
            //刷新、重绘折线图
            this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Refresh();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            GraphForm_Load(sender,  e);
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

    }
}
