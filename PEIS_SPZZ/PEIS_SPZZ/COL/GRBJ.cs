using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：个人保健数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
   [Serializable]
   public class GRBJ
    {
       /// <summary>
        /// [变量] 唯一标识一条保健
       /// </summary>
       private int id;
       /// <summary>
       /// [变量] 关联体检人员表，人员ID
       /// </summary>
       private string tjryid;
       /// <summary>
       /// [变量] 关联保健明细表，明细ID
       /// </summary>
       private string mxid;
       /// <summary>
       /// [属性] 唯一标识一条保健
       /// </summary>
       public int Id
       {
           get { return id; }
           set { id = value; }
       }
       /// <summary>
       /// [属性] 关联体检人员表，人员ID
       /// </summary>
       public string Tjryid
       {
           get { return tjryid; }
           set { tjryid = value; }
       }
       /// <summary>
       /// [属性] 关联保健明细表，明细ID
       /// </summary>
       public string Mxid
       {
           get { return mxid; }
           set { mxid = value; } 
       }
    }
}
