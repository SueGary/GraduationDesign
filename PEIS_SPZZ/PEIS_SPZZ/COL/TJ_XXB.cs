using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：体检信息表 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class TJ_XXB
    {
        /// <summary>
        /// [变量]流水号
        /// </summary>
        private int id;
        /// <summary>
        /// [变量]体检人员ID
        /// </summary>
        private string tjryid;
        /// <summary>
        /// [变量]预约编号
        /// </summary>
        private string yybh;
        /// <summary>
        /// [变量]体检编号
        /// </summary>
        private string tjbh;
        /// <summary>
        /// [变量]体检结论
        /// </summary>
        private string tjjl;
        /// <summary>
        /// [变量]保健处方
        /// </summary>
        private string bjcf;
        /// <summary>
        /// [变量]医生编号
        /// </summary>
        private int ysdm;
        /// <summary>
        /// [变量]评估时间
        /// </summary>
        private string pgsj;
        /// <summary>
        /// [变量]审核医生
        /// </summary>
        private string shys;
        /// <summary>
        /// [变量]审核时间
        /// </summary>
        private string shsj;
        /// <summary>
        /// [变量]体检记录状态
        /// </summary>
        private int jlzy;
        /// <summary>
        /// [变量]打印标记
        /// </summary>
        private int dybz;
        /// <summary>
        /// [变量]人员锁定状态
        /// </summary>
        private int sdzt;

        /// <summary>
        /// [属性]流水号
        /// </summary>
        public int Id {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// [属性]体检人员ID
        /// </summary>
        public string Tjryid
        {
            get { return tjryid; }
            set { tjryid = value; }
        }
        /// <summary>
        /// [属性]预约编号
        /// </summary>
        public string Yybh
        {
            get { return yybh; }
            set { yybh = value; }
        }
        /// <summary>
        /// [属性]体检编号
        /// </summary>
        public string Tjbh
        {
            get { return tjbh; }
            set { tjbh = value; }
        }
        /// <summary>
        /// [属性]体检结论
        /// </summary>
        public string Tjjl
        {
            get { return tjjl; }
            set { tjjl = value; }
        }
        /// <summary>
        /// [属性]保健处方
        /// </summary>
        public string Bjcf
        {
            get { return bjcf; }
            set { bjcf = value; }
        }
        /// <summary>
        /// [属性]医生编号
        /// </summary>
        public int Ysdm
        {
            get { return ysdm; }
            set { ysdm = value; }
        }
        /// <summary>
        /// [属性]评估时间
        /// </summary>
        public string Pgsj
        {
            get { return pgsj; }
            set { pgsj = value; }
        }
        /// <summary>
        /// [属性]审核医生
        /// </summary>
        public string Shys
        {
            get { return shys; }
            set { shys = value; }
        }
        /// <summary>
        /// [属性]审核时间
        /// </summary>
        public string Shsj
        {
            get { return shsj; }
            set { shsj = value; }
        }
        /// <summary>
        /// [属性]体检记录状态
        /// </summary>
        public int Jlzy
        {
            get { return jlzy; }
            set { jlzy = value; }
        }
        /// <summary>
        /// [属性]打印标记
        /// </summary>
        public int Dybz
        {
            get { return dybz; }
            set { dybz = value; }
        }
        /// <summary>
        /// [属性]人员锁定状态
        /// </summary>
        public int Sdzt
        {
            get { return sdzt; }
            set { sdzt = value; }
        }
    }
}
