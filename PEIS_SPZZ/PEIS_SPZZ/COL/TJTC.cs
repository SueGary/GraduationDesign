using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：体检套餐 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class TJTC
    {
        /// <summary>
        /// [变量] 套餐唯一编号
        /// </summary>
        private string tj_tcid;
        /// <summary>
        /// [变量] 套餐名称
        /// </summary>
        private string tj_tcmc;
        /// <summary>
        /// [变量] 性别限制
        /// </summary>
        private string tj_xbxz;
        /// <summary>
        /// [变量] 套餐项目ID
        /// </summary>
        private string tj_tcxmid;
        /// <summary>
        /// [变量] 套餐折扣
        /// </summary>
        private string tj_tczk;
        /// <summary>
        /// [变量] 套餐费用
        /// </summary>
        private int tj_tcfy;
        /// <summary>
        /// [变量] 套餐描述
        /// </summary>
        private string tj_tcms;



        /// <summary>
        /// [属性] 套餐唯一编号
        /// </summary>
        public string Tj_tcid
        {
            get { return tj_tcid; }
            set { tj_tcid = value; }
        }
        /// <summary>
        /// [属性] 套餐名称
        /// </summary>
        public string Tj_tcmc
        {
            get { return tj_tcmc; }
            set { tj_tcmc = value; }
        }
        /// <summary>
        /// [属性] 性别限制
        /// </summary>
        public string Tj_xbxz
        {
            get { return tj_xbxz; }
            set { tj_xbxz = value; }
        }
        /// <summary>
        /// [属性] 套餐项目ID
        /// </summary>
        public string Tj_tcxmid
        {
            get { return tj_tcxmid; }
            set { tj_tcxmid = value; }
        }
        /// <summary>
        /// [属性] 套餐折扣
        /// </summary>
        public string Tj_tczk
        {
            get { return tj_tczk; }
            set { tj_tczk = value; }
        }
        /// <summary>
        /// [属性] 套餐费用
        /// </summary>
        public int Tj_tcfy
        {
            get { return tj_tcfy; }
            set { tj_tcfy = value; }
        }
        /// <summary>
        /// [属性] 套餐描述
        /// </summary>
        public string Tj_tcms {
            get { return tj_tcms; }
            set { tj_tcms = value; }
        }
    }
}
