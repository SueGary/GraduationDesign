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
            comboBox1.SelectedItem = "周记录";
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            PointPairList list = new PointPairList();
            setzedGraph("血压");               
            for (int i = 0; i <= 7; i++)
            {
                double x=i+0.1;
                int y =60+i;
                list.Add(x,y);
            }
            //#region 周记录
            //if (comboBox1.Text == "周记录")
            //{
            //    string[] weekX = new string[7];
            //    for (int i = 6; i >= 0; i--)
            //    {
            //        switch (i)
            //        {
            //            case 0: weekX[i] = "周一";
            //                break;
            //            case 1: weekX[i] = "周二";
            //                break;
            //            case 2: weekX[i] = "周三";
            //                break;
            //            case 3: weekX[i] = "周四";
            //                break;
            //            case 4: weekX[i] = "周五";
            //                break;
            //            case 5: weekX[i] = "周六";
            //                break;
            //            case 6: weekX[i] = "周日";
            //                break;
            //        }
            //    }
            //    this.zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = weekX;
                
            //}
            //#endregion
            //#region 月记录
            //if (comboBox1.Text == "月记录")
            //{
            //  //  double[] szy = new double[100];
            //    string[] weekX = new string[30];
            //    for (int i = 29; i >= 0; i--)
            //    {
            //        weekX[i] = (i+1).ToString();
          
            //    }
            //    this.zedGraphControl1.GraphPane.XAxis.Scale.TextLabels = weekX;
            //    if (myCurve == null)
            //        myCurve = this.zedGraphControl1.GraphPane.AddCurve("温度", list, Color.Red, SymbolType.Circle);
            //}
            //#endregion

            if (myCurve == null)
                myCurve = this.zedGraphControl1.GraphPane.AddCurve("温度", list, Color.Red, SymbolType.Circle);
            //刷新、重绘折线图
            this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Refresh();

        }
       /// <summary>
        /// 坐标图的设置，title，X轴，Y轴的名字
       /// </summary>
       /// <param name="yRecord">血压、体重</param>
        public void setzedGraph(string yRecord) {
            //设置折线图名称和坐标轴名称
            this.zedGraphControl1.GraphPane.Title.Text = "个人"+yRecord;
            this.zedGraphControl1.GraphPane.XAxis.Title.Text = "时间";
            this.zedGraphControl1.GraphPane.YAxis.Title.Text = yRecord;
            //如果坐标轴标度不想使用数值，而是使用文本，需要设置坐标轴类型为text
         //   this.zedGraphControl1.GraphPane.XAxis.Type = AxisType.Text;
        
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
