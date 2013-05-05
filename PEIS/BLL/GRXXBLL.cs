using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using SUJIALI.PEIS.COL;
using SUJIALI.PEIS.DAL;
using SUJIALI.PEIS.SFL;

namespace SUJIALI.PEIS.BLL
{
    /// <summary>
    /// 对象名称：个人信息业务逻辑类（业务逻辑层）
    /// 对象说明：记录体检人员的个人基本信息
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    public class GRXXBLL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要提供该类的基本业务逻辑。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.GRXXDAL DataAccess
        {
            get
            {
                return DAL.Common.GRXXDAL.Instance;
            }
        }


        /// <summary>
        /// 对个人信息（GRXX）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public static void CheckValid(GRXX gRXX)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(gRXX.ReservationId))
                throw new CustomException("“预约号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXX.PhysicalExamination))
                throw new CustomException("“体检号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXX.Name))
                throw new CustomException("“姓名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXX.NameOfRubyCode))
                throw new CustomException("“姓名拼音码”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXX.Sex))
                throw new CustomException("“性别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(gRXX.IDCard))
                throw new CustomException("“身份证”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(gRXX.ReservationId , 50))
                throw new CustomException("“预约号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.PhysicalExamination , 50))
                throw new CustomException("“体检号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.Name , 50))
                throw new CustomException("“姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.NameOfRubyCode , 50))
                throw new CustomException("“姓名拼音码”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.DateOfBirth , 50))
                throw new CustomException("“出生日期”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.IDCard , 50))
                throw new CustomException("“身份证”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.Nationa , 50))
                throw new CustomException("“民族”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.ThePoliticalLandscape , 50))
                throw new CustomException("“政治面貌”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.MaritalStatus , 50))
                throw new CustomException("“婚姻状况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.WhereHisherHousehold , 50))
                throw new CustomException("“户口所在地”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.CurrentResidentialAddress , 50))
                throw new CustomException("“现居住地址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.NativePlace , 50))
                throw new CustomException("“籍贯”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.ContactPhone , 50))
                throw new CustomException("“联系电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.EducationLevel , 50))
                throw new CustomException("“文化程度”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.Professional , 50))
                throw new CustomException("“职业”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.CompanyId , 50))
                throw new CustomException("“所属单位编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.FamilyHistory , 50))
                throw new CustomException("“家族病史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.Billing , 50))
                throw new CustomException("“付费方式”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.DateOfRegistration , 50))
                throw new CustomException("“登记日期”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.PhysicalExercise , 50))
                throw new CustomException("“体育锻炼情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.PersonalDiet , 50))
                throw new CustomException("“个人饮食情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.PersonalSleep , 50))
                throw new CustomException("“个人睡眠情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.CigaretteSmoking , 50))
                throw new CustomException("“吸烟情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.AlcoholDrinking , 50))
                throw new CustomException("“饮酒情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.OtherCircumstances , 50))
                throw new CustomException("“其他情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.PreviousHistory , 50))
                throw new CustomException("“既往史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.DrugAllergy , 50))
                throw new CustomException("“药物过敏”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(gRXX.ReadingHistoryOfExposure , 50))
                throw new CustomException("“读物接触史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将个人信息（GRXX）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public static int Insert(GRXX gRXX)
        {
            CheckValid(gRXX);
            return DataAccess.Insert(gRXX);
        }


        /// <summary>
        /// 将个人信息（GRXX）数据，根据主键“流水号（SerialId）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public static int Update(GRXX gRXX)
        {
            CheckValid(gRXX);
            return DataAccess.Update(gRXX);
        }


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public static int Delete(int serialId)
        {
            return DataAccess.Delete(serialId);
        }


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”从数据库中获取个人信息（GRXX）的实例。
        /// 成功从数据库中取得记录返回新个人信息（GRXX）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public static GRXX GetDataBySerialId(int serialId)
        {
            return DataAccess.GetDataBySerialId(serialId);
        }


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”从数据库中获取个人信息（GRXX）的实例。
        /// 成功从数据库中取得记录返回新个人信息（GRXX）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public static GRXX GetDataBySerialId(string serialId)
        {
            if(!DataValid.IsInt(serialId))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataBySerialId(Convert.ToInt32(serialId));
        }


        /// <summary>
        /// 从数据库中读取并返回所有个人信息（GRXX）List列表。
        /// </summary>
        public static List<GRXX> GetAllList()
        {
            return DataAccess.GetAllList();
           
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人信息（GRXX）的列表及分页信息。
        /// 该方法所获取的个人信息（GRXX）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public static PageData GetPageList(int pageSize, int curPage)
        {
            return DataAccess.GetPageList(pageSize,curPage);
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
