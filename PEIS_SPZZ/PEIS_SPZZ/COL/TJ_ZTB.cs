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
    [Serializable]
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



       /// <summary>
       /// [属性] 唯一标识体检状态
       /// </summary>
       public int Id {
           get { return id; }
           set { id = value; }
       }
       /// <summary>
       /// [属性] 体检人员编号
       /// </summary>
       public string Tjrybh
       {
           get { return tjrybh; }
           set { tjrybh = value; }
       }
       /// <summary>
       /// [属性] 当前状态
       /// </summary>
       public int Dqzt
       {
           get { return dqzt; }
           set { dqzt = value; }
       }
       /// <summary>
       /// [属性] 体检者姓名
       /// </summary>
       public string Tjxm
       {
           get { return tjxm; }
           set { tjxm = value; }
       }
       /// <summary>
       /// [属性] 性别
       /// </summary>
       public int Sex
       {
           get { return sex; }
           set { sex = value; }
       }
       /// <summary>
       /// [属性] 年龄
       /// </summary>
       public int Nl
       {
           get { return nl; }
           set { nl = value; }
       }
       /// <summary>
       /// [属性] 是否缴费
       /// </summary>
       public string Sfjf
       {
           get { return sfjf; }
           set { sfjf = value; }
       }
       /// <summary>
       /// [属性] 付费方式
       /// </summary>
       public string Fffs
       {
           get { return fffs; }
           set { fffs = value; }
       }
       /// <summary>
       /// [属性] 登记时间
       /// </summary>
       public string Djsj
       {
           get { return djsj; }
           set { djsj = value; }
       }
       /// <summary>
       /// [属性] 套餐选择时间
       /// </summary>
       public string Tcxzsj
       {
           get { return tcxzsj; }
           set { tcxzsj = value; }
       }
       /// <summary>
       /// [属性] 确认时间
       /// </summary>
       public string Qrsj
       {
           get { return qrsj; }
           set { qrsj = value; }
       }
       /// <summary>
       /// [属性] 分检时间
       /// </summary>
       public string Fjsj
       {
           get { return fjsj; }
           set { fjsj = value; }
       }
       /// <summary>
       /// [属性] 总检时间
       /// </summary>
       public string Zjsj
       {
           get { return zjsj; }
           set { zjsj = value; }
       }
       /// <summary>
       /// [属性] 团体编号
       /// </summary>
       public string Ttbm
       {
           get { return ttbm; }
           set { ttbm = value; }
       }
       /// <summary>
       /// [属性] 总检医生
       /// </summary>
       public string Zjys
       {
           get { return zjys; }
           set { zjys = value; }
       }
       /// <summary>
       /// [属性] 套餐名称
       /// </summary>
       public string Tcmc
       {
           get { return tcmc; }
           set { tcmc = value; }
       }
       /// <summary>
       /// [属性] 是否打印报告
       /// </summary>
       public int Sfdybg
       {
           get { return sfdybg; }
           set { sfdybg = value; }
       }
       /// <summary>
       /// [属性] 单项或套餐
       /// </summary>
       public int Sftc
       {
           get { return sftc; }
           set { sftc = value; }
       }

    }
}
