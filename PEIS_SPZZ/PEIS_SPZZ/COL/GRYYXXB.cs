using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：个人预约信息表据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
   public class GRYYXXB
    {
       /// <summary>
       /// [变量] 标识每一条预约记录
       /// </summary>
       private int id;
       /// <summary>
       /// [变量] 个人体检ID
       /// </summary>
       private string tjryid;
       /// <summary>
       /// [变量]体检姓名
       /// </summary>
       private string tjxm;
       /// <summary>
       /// [变量]性别
       /// </summary>
       private int sex;
       /// <summary>
       /// [变量]联系电话
       /// </summary>
       private string lxdh;
       /// <summary>
       /// [变量] 套餐项目编号
       /// </summary>
       private string tcxmbh;
       /// <summary>
       /// [变量] 预约时间
       /// </summary>
       private string yysj;
       /// <summary>
       /// [变量] 体检时间
       /// </summary>
       private string tjsj;
       /// <summary>
       /// [属性]标识每一条预约记录
       /// </summary>
       public int Id {
           get { return id; }
           set { id = value;}
       }
       /// <summary>
       /// [属性]个人体检ID
       /// </summary>
       public string Tjryid {
           get { return tjryid; }
           set { tjryid = value; }
       }
       /// <summary>
       /// [属性]性别
       /// </summary>
       public int Sex {
           get { return sex; }
           set { sex = value; }
       }
       /// <summary>
       /// [属性]联系电话
       /// </summary>
       public string Lxdh {
           get { return lxdh; }
           set { lxdh = value; }
       }
       /// <summary>
       /// [属性]套餐项目编号
       /// </summary>
       public string Tcxmbh {
           get { return tcxmbh; }
           set { tcxmbh = value; }
       }
       /// <summary>
       /// [属性]预约时间
       /// </summary>
       public string Yysj {
           get { return yysj; }
           set { yysj = value; }
       }
       /// <summary>
       /// [属性]体检时间
       /// </summary>
       public string Tjsj {
           get { return tjsj; }
           set { tjsj = value; }
       }
    }
}
