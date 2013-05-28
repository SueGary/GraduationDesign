using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：团队登记表 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class TTDJB
    {
        /// <summary>
        /// [变量] 流水号
        /// </summary>
        private int id;
        /// <summary>
        /// [变量] 团体编码
        /// </summary>
        private string ttbm;
        /// <summary>
        /// [变量] 团体名称
        /// </summary>
        private string ttmc;
        /// <summary>
        /// [变量] 地址
        /// </summary>
        private string dz;
        /// <summary>
        /// [变量] 团体性质编号
        /// </summary>
        private int ttxzid;
        /// <summary>
        /// [变量] 联系电话
        /// </summary>
        private string lxdh;
        /// <summary>
        /// [变量] 移动电话
        /// </summary>
        private string yddh;
        /// <summary>
        /// [变量] 联系人
        /// </summary>
        private string lxr;
        /// <summary>
        /// [变量]法人代表
        /// </summary>
        private string frdb;
        /// <summary>
        /// [变量] 电子邮箱
        /// </summary>
        private string dzyx;
        /// <summary>
        /// [变量] 登记日期
        /// </summary>
        private string djrq;
        /// <summary>
        /// [变量] 结账日期
        /// </summary>
        private string jzrq;

        /// <summary>
        /// [属性] 流水号
        /// </summary>
        public int Id {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// [属性] 团体编码
        /// </summary>
        public string Ttbm
        {
            get { return ttbm; }
            set { ttbm = value; }
        }
        /// <summary>
        /// [属性] 团体名称
        /// </summary>
        public string Ttmc
        {
            get { return ttmc; }
            set { ttmc = value; }
        }
        /// <summary>
        /// [属性] 地址
        /// </summary>
        public string Dz
        {
            get { return dz; }
            set { dz = value; }
        }
        /// <summary>
        /// [属性] 团体性质编号
        /// </summary>
        public int Ttxzid
        {
            get { return ttxzid; }
            set { ttxzid = value; }
        }
        /// <summary>
        /// [属性] 联系电话
        /// </summary>
        public string Lxdh
        {
            get { return lxdh; }
            set { lxdh = value; }
        }
        /// <summary>
        /// [属性] 移动电话
        /// </summary>
        public string Yddh
        {
            get { return yddh; }
            set { yddh = value; }
        }
        /// <summary>
        /// [属性] 联系人
        /// </summary>
        public string Lxr
        {
            get { return lxr; }
            set { lxr = value; }
        }
        /// <summary>
        /// [属性]法人代表
        /// </summary>
        public string Frdb
        {
            get { return frdb; }
            set { frdb = value; }
        }
        /// <summary>
        /// [属性] 电子邮箱
        /// </summary>
        public string Dzyx
        {
            get { return dzyx; }
            set { dzyx = value; }
        }
        /// <summary>
        /// [属性] 登记日期
        /// </summary>
        public string Djrq
        {
            get { return djrq; }
            set { djrq= value; }
        }
        /// <summary>
        /// [属性] 结账日期
        /// </summary>
        public string Jzrq
        {
            get { return jzrq; }
            set { jzrq = value; }
        }
    }
}
