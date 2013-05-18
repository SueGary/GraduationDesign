using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.DAL;
using PEIS_SPZZ.SFL;



namespace PEIS_SPZZ.BLL
{
    /// <summary>
    /// 对象名称：个人每周运动业务逻辑类（业务逻辑层）
    /// 对象说明：记录个人每周运动的信息
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-15 
    /// </summary>
   public class GRMZYD_BLL
    {
       internal static DAL.Common.GRMZYD_DAL DataAccess
       {
           get {

               return DAL.Common.GRMZYD_DAL.Instance;      
           }
       }
       public static void CheckValid(GRMZYD gRMZYD)
       {
           #region 检查各属性是否符合空值约束
           if(DataValid.IsNull(gRMZYD.Jhyd))
               throw new CustomException("“计划运动”不能为空，请您确认输入是否正确。");
      //     if (DataValid.IsNull())
            //   throw new CustomException("“计划运动”不能为空，请您确认输入是否正确。");
           #endregion



       }

       /// <summary>
       /// 添加运动计划
       /// </summary>
       /// <param name="gRMZYD">个人每周运动（GRMZYD）实例对象</param>
       /// <returns></returns>
       public static int Insert(GRMZYD gRMZYD)
       {
           return DataAccess.Insert(gRMZYD);
       }




























    }
}
