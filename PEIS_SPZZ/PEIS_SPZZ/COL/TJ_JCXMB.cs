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
    /// </summary
    [Serializable]
    public class TJ_JCXMB
    {
        #region 体检项目类【变量】
        /// <summary>
        /// [变量] 流水号
        /// </summary>
        private int id;
        /// <summary>
        /// [变量]项目编号
        /// </summary>
        private string xmbh;
        /// <summary>
        /// [变量]项目名称
        /// </summary>
        private string xmmc;
        /// <summary>
        /// [变量] 组合项目编号
        /// </summary>
        private string zhxmbh;
        /// <summary>
        /// [变量] 项目名称拼音码
        /// </summary>
        private string pym;
        /// <summary>
        /// [变量]单位
        /// </summary>
        private string dw;
        /// <summary>
        /// [变量]参考下限
        /// </summary>
        private string ckxx;
        /// <summary>
        /// [变量]参考上限
        /// </summary>
        private string cksx;
        /// <summary>
        /// [变量]正常值
        /// </summary>
        private string zcz;
        /// <summary>
        /// [变量]是否选用
        /// </summary>
        private string sfxy;
        #endregion
        #region 体检项目类【属性】
        /// <summary>
        /// [属性] 流水号
        /// </summary>
        public int Id {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// [属性]项目编号
        /// </summary>
        public string Xmbh {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性]项目名称
        /// </summary>
        public string Xmmc
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性] 组合项目编号
        /// </summary>
        public string Zhxmbh
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性] 项目名称拼音码
        /// </summary>
        public string Pym
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性]单位
        /// </summary>
        public string Dw
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性]参考下限
        /// </summary>
        public string Ckxx
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性]参考上限
        /// </summary>
        public string Cksx
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性]正常值
        /// </summary>
        public string Zcz
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        /// <summary>
        /// [属性]是否选用
        /// </summary>
        public string Sfxy
        {
            get { return xmbh; }
            set { xmbh = value; }
        }
        #endregion
    }
}
