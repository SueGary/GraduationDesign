using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.BLL
{
    /// <summary>
    /// 对象名称：个人血压体重 业务逻辑类（业务逻辑层）
    /// 对象说明：记录个人血压体重
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-31
    /// </summary>
   public class GRXYTZ_BLL
    {
        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.GRXYTZ_DAL DataAccess
        {
            get
            {
                return DAL.Common.GRXYTZ_DAL.Instance;
            }
        }
         /// <summary>
        /// 个人血压体重（GRXYTZ）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="gRXX">个人血压体重（GRXYTZ）实例对象</param>
        public static void CheckValid(GRXYTZ gRXYTZ)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(gRXYTZ.Id))
                throw new CustomException("“ID”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXYTZ.Rqsj))
                throw new CustomException("“日期/时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXYTZ.Ssy))
                throw new CustomException("“收缩压”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXYTZ.Szy))
                throw new CustomException("“舒张压”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXYTZ.Tz))
                throw new CustomException("“体重”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXYTZ.Xl))
                throw new CustomException("“心率”不能为空，请您确认输入是否正确。");

             if (DataValid.IsNull(gRXYTZ.Tjryid))
                throw new CustomException("“个人信息ID”不能为空，请您确认输入是否正确。");
             #endregion
            #region 检查字符串是否超出规定长度
             if (DataValid.IsOutLength(gRXYTZ.Tjryid, 14))
                 throw new CustomException("“体检人员ID”长度不能超过 14 个汉字或字符，请您确认输入是否正确。");
            if (DataValid.IsOutLength(gRXYTZ.Ssy, 30))
                 throw new CustomException("“收缩压”长度不能超过 30个汉字或字符，请您确认输入是否正确。");
              if (DataValid.IsOutLength(gRXYTZ.Szy, 30))
                 throw new CustomException("“舒张压”长度不能超过 30个汉字或字符，请您确认输入是否正确。");

              if (DataValid.IsOutLength(gRXYTZ.Tz, 30))
                 throw new CustomException("“体重”长度不能超过 30个汉字或字符，请您确认输入是否正确。");

              if (DataValid.IsOutLength(gRXYTZ.Xl, 30))
                 throw new CustomException("“心率”长度不能超过 30个汉字或字符，请您确认输入是否正确。");
              if (DataValid.IsOutLength(gRXYTZ.Rqsj, 30))
                 throw new CustomException("“日期/时间”长度不能超过 30个汉字或字符，请您确认输入是否正确。");


             #endregion
        }

        /// <summary>
        /// 将个人血压体重（GRXYTZ）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXYTZ">个人血压体重（GRXYTZ）实例对象</param>
        public static int Insert(GRXYTZ gRXYTZ)
        {
            CheckValid(gRXYTZ);
            return DataAccess.Insert(gRXYTZ);
        }


        /// <summary>
        /// 将个人血压体重（GRXYTZ）数据，根据主键“流水号（ID）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXYTZ">个人血压体重（GRXYTZ）实例对象</param>
        public static int Update(GRXYTZ gRXYTZ)
        {
            CheckValid(gRXYTZ);
            return DataAccess.Update(gRXYTZ);
        }


        /// <summary>
        /// 根据个人血压体重（GRXYTZ）的主键“流水号（ID）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">个人血压体重（GRXYTZ）的主键“流水号（ID）”</param>
        public static int Delete(int serialId)
        {
            return DataAccess.Delete(serialId);
        }


        /// <summary>
        /// 根据个人血压体重（GRXYTZ）的主键“流水号（ID）”从数据库中获取个人血压体重（GRXYTZ）的实例。
        /// 成功从数据库中取得记录返回新个人血压体重（GRXYTZ）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">个人血压体重（GRXYTZ）的主键“流水号（ID）”</param>
        public static GRXYTZ GetDataBySerialId(int serialId)
        {
            return DataAccess.GetDataBySerialId(serialId);
        }


        /// <summary>
        /// 根据个人血压体重（GRXYTZ）的主键“流水号（ID）”从数据库中获取个人血压体重（GRXYTZ）的实例。
        /// 成功从数据库中取得记录返回新个人血压体重（GRXYTZ）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">个人血压体重（GRXYTZ）的主键“流水号（ID）”</param>
        public static GRXYTZ GetDataBySerialId(string serialId)
        {
            if(!DataValid.IsInt(serialId))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataBySerialId(Convert.ToInt32(serialId));
        }


        /// <summary>
        /// 从数据库中读取并返回所有个人血压体重（GRXYTZ）List列表。
        /// </summary>
        public static List<GRXYTZ> GetAllList()
        {
            return DataAccess.GetAllList();
           
        }




        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人血压体重（GRXYTZ）的列表及分页信息。
        /// 该方法所获取的个人血压体重（GRXYTZ）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public static PageData GetPageList(int pageSize, int curPage)
        {
            return DataAccess.GetPageList(pageSize,curPage);
        }


       













    }
}
