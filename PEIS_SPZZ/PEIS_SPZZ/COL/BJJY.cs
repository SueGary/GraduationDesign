using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：保健建议数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class BJJY
    {
        /// <summary>
        /// [变量]唯一标识描述ID
        /// </summary>
        private int msid;
        /// <summary>
        /// [变量]体检描述
        /// </summary>
        private string tjms;
        /// <summary>
        /// [属性]唯一标识描述ID
        /// </summary>
        public int Msid
        {
            get { return msid; }
            set { msid = value;}
        }
        /// <summary>
        /// 体检描述
        /// </summary>
        public string Tjms
        {
            get { return tjms; }
            set { tjms = value; }
        }
    }
}
