using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：体检用户 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
    [Serializable]
   public class TJ_YHB
    {
       /// <summary>
       /// [变量] 用户编号
       /// </summary>
       private string YHID;
       /// <summary>
       /// [变量] 用户姓名
       /// </summary>
       private string YHXM;
       /// <summary>
       /// [变量] 帐号
       /// </summary>
       private string YHM;
       /// <summary>
       /// [变量] 密码
       /// </summary>
       private string MM;
       /// <summary>
       /// [变量] 体检科室
       /// </summary>
       private string TJKS;
       /// <summary>
       /// [变量] 科室编码
       /// </summary>
       private string KSBM;
       /// <summary>
       /// [变量] 用户权限
       /// </summary>
       private string YHQX;
       /// <summary>
       /// [变量] 权限
       /// </summary>
       private int QXBM;

       /// <summary>
       /// [属性] 用户编号
       /// </summary>
       public string Yhid {
           get { return YHID; }
           set { YHID = value; }
       }
       /// <summary>
       /// [属性] 用户姓名
       /// </summary>
       public string Yhxm
       {
           get { return YHXM; }
           set { YHXM =value;}
       }
       /// <summary>
       /// [属性] 帐号
       /// </summary>
       public string Yhm
       {
           get { return YHM; }
           set { YHM = value; }
       }
       /// <summary>
       /// [属性] 密码
       /// </summary>
       public string Mm
       {
           get { return MM; }
           set { MM = value; }
       }
       /// <summary>
       /// [属性] 体检科室
       /// </summary>
       public string Tjks
       {
           get { return TJKS;}
           set { TJKS=value;}
       }
       /// <summary>
       /// [属性] 科室编码
       /// </summary>
       public string Ksbm
       {
           get { return KSBM; }
           set { KSBM=value;}
       }
       /// <summary>
       /// [属性] 用户权限
       /// </summary>
       public string Yhqx
       {
           get { return YHQX; }
           set { YHQX=value;}
       }
       /// <summary>
       /// [属性] 权限
       /// </summary>
       public int Qxbm
       {
           get { return QXBM; }
           set { QXBM = value;}
       }
    }
}
