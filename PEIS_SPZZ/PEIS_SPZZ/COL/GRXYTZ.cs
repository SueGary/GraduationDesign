using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：个人血压、体重据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
    public class GRXYTZ
    {
        /// <summary>
        /// [变量]唯一标识每一条记录
        /// </summary>
        private int? id;
        /// <summary>
        /// [变量]关联个人信息表
        /// </summary>
        private string tjryid;
        /// <summary>
        /// [变量]收缩压
        /// </summary>
        private string ssy;
        /// <summary>
        /// [变量]舒张压
        /// </summary>
        private string szy;
        /// <summary>
        /// [变量]体重
        /// </summary>
        private string tz;
        /// <summary>
        /// [变量]心率
        /// </summary>
        private string xl;
        /// <summary>
        /// [变量]日期/时间
        /// </summary>
        private string rqsj;
        /// <summary>
        /// [属性]唯一标识每一条记录
        /// </summary>
        public int? Id {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// [属性]关联个人信息ID
        /// </summary>
        public string Tjryid {
            get { return tjryid; }
            set { tjryid = value; }
        }
        /// <summary>
        /// [属性] 收缩压
        /// </summary>
        public string Ssy {
            get { return ssy; }
            set { ssy = value; }
        }
        /// <summary>
        /// [属性] 舒张压
        /// </summary>
        public string Szy {
            get { return szy; }
            set { szy = value; }
        
        }
        /// <summary>
        /// [属性] 体重
        /// </summary>
        public string Tz {
            get { return tz; }
            set { tz = value; }
        }
        /// <summary>
        /// [属性]心率
        /// </summary>
        public string Xl {
            get { return xl; }
            set { xl = value; }
        }
        /// <summary>
        /// [属性]日期/时间
        /// </summary>
        public string Rqsj {
            get { return rqsj; }
            set { rqsj = value; }
        }
    }
}
