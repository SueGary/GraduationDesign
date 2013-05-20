using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：体检收费明细 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    public class TJ_SFMXB
    {
        /// <summary>
        /// [变量] 序号，唯一标识每一条收费
        /// </summary>
        private int id;
        /// <summary>
        /// [变量] 团体编码
        /// </summary>
        private string ttbm;
        /// <summary>
        /// [变量] 套餐编号
        /// </summary>
        private string tcbh;
        /// <summary>
        /// [变量] 套餐名称
        /// </summary>
        private string tcmc;
        /// <summary>
        /// [变量] 体检大类ID
        /// </summary>
        private string dlid;
        /// <summary>
        /// [变量] 大类名称
        /// </summary>
        private string dlmc;
        /// <summary>
        /// [变量] 体检收费项目ID
        /// </summary>
        private string tjsfid;
        /// <summary>
        /// [变量] 体检收费项目名称
        /// </summary>
        private string tjsfmc;
        /// <summary>
        /// [变量] 费用类别
        /// </summary>
        private int fylb;
        /// <summary>
        /// [变量] 体检套餐总金额
        /// </summary>
        private int tczje;
        /// <summary>
        /// [变量] 项目记录状态
        /// </summary>
        private int jlzt;
        /// <summary>
        /// [变量] 缴费状态
        /// </summary>
        private int jfzt;
        /// <summary>
        /// [变量] 体检标记
        /// </summary>
        private int tjbz;
        /// <summary>
        /// [变量] 体检医生代码
        /// </summary>
        private int ysdm;


        /// <summary>
        /// [属性] 序号，唯一标识每一条收费
        /// </summary>
        public int Id {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// [属性] 团体编码
        /// </summary>
        public string Ttbm {
            get { return ttbm; }
            set { ttbm = value; }
        }
        /// <summary>
        /// [属性] 套餐编号
        /// </summary>
        public string Tcbh {
            get { return tcbh; }
            set { tcbh = value; }
        }
        /// <summary>
        /// [属性] 套餐名称
        /// </summary>
        public string Tcmc {
            get { return tcmc; }
            set { tcmc = value; }
        }
        /// <summary>
        /// [属性] 体检大类ID
        /// </summary>
        public string Dlid {
            get { return dlid; }
            set { dlid = value; }
        }
        /// <summary>
        /// [属性] 大类名称
        /// </summary>
        public string Dlmc {
            get { return dlmc; }
            set { dlmc = value; }
        }
        /// <summary>
        /// [属性] 体检收费项目ID
        /// </summary>
        public string Tjsfid {
            get { return tjsfid; }
            set { tjsfid = value; }
        
        }
        /// <summary>
        /// [属性] 体检收费项目名称
        /// </summary>
        public string Tjsfmc {
            get { return tjsfmc; }
            set { tjsfmc = value; }
        }
        /// <summary>
        /// [属性] 费用类别
        /// </summary>
        public int Fylb {
            get { return fylb; }
            set { fylb = value; }
        }
        /// <summary>
        /// [属性] 体检套餐总金额
        /// </summary>
        public int Tczje {
            get { return tczje; }
            set { tczje = value; }
        }
        /// <summary>
        /// [属性] 项目记录状态
        /// </summary>
        public int Jlzt {
            get { return jlzt; }
            set { jlzt = value; }
        }
        /// <summary>
        /// [属性] 缴费状态
        /// </summary>
        public int Jfzt {
            get { return jfzt; }
            set { jfzt = value; }
        }
        /// <summary>
        /// [属性] 体检标记
        /// </summary>
        public int Tjbz {
            get { return tjbz; }
            set { tjbz = value; }
        }
        /// <summary>
        /// [属性] 体检医生代码
        /// </summary>
        public int Ysdm {
            get { return ysdm; }
            set { ysdm = value; }
        }
    }
}
