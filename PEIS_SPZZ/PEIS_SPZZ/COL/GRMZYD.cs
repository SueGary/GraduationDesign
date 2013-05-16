using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：每周运动数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    //[Serializable]
    public class GRMZYD
    {
        /// <summary>
        /// [变量] 运动项目ID
        /// </summary>
        private string ydId;
        /// <summary>
        /// [变量] 个人ID
        /// </summary>
        private string tjryId;
        /// <summary>
        /// [变量] 时间/日期
        /// </summary>
        private string sj;
        /// <summary>
        /// [变量] 计划运动
        /// </summary>
        private string jhyd;
        /// <summary>
        /// [变量] 落实情况
        /// </summary>
        private string lsqk;


        /// <summary>
        /// [属性] 运动项目ID
        /// </summary>
        public string YdId
        {
            get { return ydId; }
            set { ydId = value; }
        }
        /// <summary>
        /// [属性] 个人ID
        /// </summary>
        public string TjryId
        {
            get { return tjryId; }
            set { tjryId = value; }
        }
        /// <summary>
        /// [属性] 时间/日期
        /// </summary>
        public string Sj
        {
            get { return sj; }
            set {sj=value;}
        }
        /// <summary>
        /// [属性] 计划运动
        /// </summary>
        public string Jhyd
        {
            get { return jhyd; }
            set { jhyd = value; }
        
        }
        /// <summary>
        /// [属性] 落实情况
        /// </summary>
        public string Lsqk
        {
            get { return lsqk; }
            set { lsqk = value; }
        }
    }
}
