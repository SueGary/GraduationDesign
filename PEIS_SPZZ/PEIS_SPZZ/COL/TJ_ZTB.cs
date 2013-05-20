using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：体检状态 数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-18
    /// </summary>
   public class TJ_ZTB
    {
       /// <summary>
       /// [变量] 唯一标识体检状态
       /// </summary>
       private int id;
       /// <summary>
       /// [变量] 体检人员编号
       /// </summary>
       private string tjrybh;
       /// <summary>
       /// [变量] 当前状态
       /// </summary>
       private int dqzt;
       /// <summary>
       /// [变量] 体检者姓名
       /// </summary>
       private string tjxm;
       /// <summary>
       /// [变量] 性别
       /// </summary>
       private int sex;
       /// <summary>
       /// [变量] 年龄
       /// </summary>
       private int nl;
       /// <summary>
       /// [变量] 是否缴费
       /// </summary>
       private string sfjf;
       /// <summary>
       /// [变量] 付费方式
       /// </summary>
       private string fffs;
       /// <summary>
       /// [变量] 登记时间
       /// </summary>
       private string djsj;
       /// <summary>
       /// [变量] 套餐选择时间
       /// </summary>
       private string tcxzsj;
       /// <summary>
       /// [变量] 确认时间
       /// </summary>
       private string qrsj;
       /// <summary>
       /// [变量] 分检时间
       /// </summary>
       private string fjsj;
       /// <summary>
       /// [变量] 总检时间
       /// </summary>
       private string zjsj;
       /// <summary>
       /// [变量] 团体编号
       /// </summary>
       private string ttbm;
       /// <summary>
       /// [变量] 总检医生
       /// </summary>
       private string zjys;
       /// <summary>
       /// [变量] 套餐名称
       /// </summary>
       private string tcmc;
       /// <summary>
       /// [变量] 是否打印报告
       /// </summary>
       private int sfdybg;
       /// <summary>
       /// [变量] 单项或套餐
       /// </summary>
       private int sftc;

    }
}
