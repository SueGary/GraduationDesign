using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
     /// <summary>
    /// 对象名称：急救指南据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
     /// </summary>
   public class JJZN
    {
       /// <summary>
       /// [变量] 唯一标识损伤，ID号
       /// </summary>
       private string ssid;
       /// <summary>
       /// [变量] 损伤描述
       /// </summary>
       private string ssms;
       /// <summary>
       /// [变量]标识措施
       /// </summary>
       private string cdid;
       /// <summary>
       /// [变量]措施描述
       /// </summary>
       private string cdms;
       /// <summary>
       /// [属性]唯一标识损伤，ID号
       /// </summary>
       public string Ssid {
           get { return ssid; }
           set { ssid = value; }
       }
       /// <summary>
       /// [属性] 损伤描述
       /// </summary>
       public string Ssms {
           get { return ssms; }
           set { ssms = value; }
       }
       /// <summary>
       /// [属性]标识措施
       /// </summary>
       public string Cdid {
           get { return cdid; }
           set { cdid = value; }
       }
       /// <summary>
       /// [属性]措施描述
       /// </summary>
       public string Cdms {
           get { return cdms; }
           set { cdms = value; }
       }
    }
}
