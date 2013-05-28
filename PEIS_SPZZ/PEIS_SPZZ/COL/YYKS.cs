using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：医院科室 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class YYKS
    {
        #region 医院科室【变量】
        /// <summary>
        /// [变量] 唯一标识科室
        /// </summary>
        private string  tj_ksid;
        /// <summary>
        /// [变量] 科室名称
        /// </summary>
        private string tj_ksmc;
        #endregion
        #region 医院科室【属性】
        /// <summary>
        /// [属性] 唯一标识科室
        /// </summary>
        public string Tj_ksid {
            get { return tj_ksid; }
            set { tj_ksid = value; }
        }
        /// <summary>
        /// [属性] 科室名称
        /// </summary>
        public string Tj_ksmc
        {
            get { return tj_ksmc; }
            set { tj_ksmc = value; }
        }
        #endregion
    }
}
