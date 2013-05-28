using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：体检项目 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class TJXM
    {
        /// <summary>
        /// [变量]体检项目 ID
        /// </summary>
        private string tj_xmid;
        /// <summary>
        /// [变量] 体检项目名称
        /// </summary>
        private string tj_xmmc;
        /// <summary>
        /// [属性] 体检项目名称
        /// </summary>
        public string Tj_xmid
        {
            get { return tj_xmid; }
            set { tj_xmid = value; }
        }
        /// <summary>
        /// [属性] 体检项目名称
        /// </summary>
        public string Tj_xmmc {
            get { return tj_xmmc; }
            set { tj_xmmc = value; }
        }
    }
}
