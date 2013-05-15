using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using SUJIALI.PEIS.COL;
using SUJIALI.PEIS.SFL;

namespace SUJIALI.PEIS.DAL.Common
{
    /// <summary>
    /// 对象名称：个人信息通用数据访问父类（数据访问层）
    /// 对象说明：提供“个人信息类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“个人信息类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    public abstract class GRXXDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“个人信息（GRXXDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static GRXXDAL gRXXDAL;


        /// <summary>
        /// 获取“个人信息（GRXXDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“个人信息（GRXXDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static GRXXDAL Instance
        {
            get
            {
                if (gRXXDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            gRXXDAL = new SqlServer.GRXXDAL();
                            break;

                        default:
                            gRXXDAL = new SqlServer.GRXXDAL();
                            break;
                    }
                }
                return gRXXDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为GRXX对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        protected void ReadGRXXAllData(IDataReader dataReader, GRXX gRXX)
        {
            // 流水号
            if (dataReader["SerialId"] != DBNull.Value)
                gRXX.SerialId = Convert.ToInt32(dataReader["SerialId"]);
            // 预约号
            if (dataReader["ReservationId"] != DBNull.Value)
                gRXX.ReservationId = Convert.ToString(dataReader["ReservationId"]);
            // 体检号
            if (dataReader["PhysicalExamination"] != DBNull.Value)
                gRXX.PhysicalExamination = Convert.ToString(dataReader["PhysicalExamination"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                gRXX.Name = Convert.ToString(dataReader["Name"]);
            // 姓名拼音码
            if (dataReader["NameOfRubyCode"] != DBNull.Value)
                gRXX.NameOfRubyCode = Convert.ToString(dataReader["NameOfRubyCode"]);
            // 性别
            if (dataReader["Sex"] != DBNull.Value)
            {
                Sex tmpSex = Sex.GetDataById(Convert.ToInt32(dataReader["Sex"]));
                if (tmpSex != null) gRXX.Sex = tmpSex;
            }
            // 出生日期
            if (dataReader["DateOfBirth"] != DBNull.Value)
                gRXX.DateOfBirth = Convert.ToString(dataReader["DateOfBirth"]);
            // 身份证
            if (dataReader["IDCard"] != DBNull.Value)
                gRXX.IDCard = Convert.ToString(dataReader["IDCard"]);
            // 民族
            if (dataReader["Nationa"] != DBNull.Value)
                gRXX.Nationa = Convert.ToString(dataReader["Nationa"]);
            // 政治面貌
            if (dataReader["ThePoliticalLandscape"] != DBNull.Value)
                gRXX.ThePoliticalLandscape = Convert.ToString(dataReader["ThePoliticalLandscape"]);
            // 婚姻状况
            if (dataReader["MaritalStatus"] != DBNull.Value)
                gRXX.MaritalStatus = Convert.ToString(dataReader["MaritalStatus"]);
            // 户口所在地
            if (dataReader["WhereHisherHousehold"] != DBNull.Value)
                gRXX.WhereHisherHousehold = Convert.ToString(dataReader["WhereHisherHousehold"]);
            // 现居住地址
            if (dataReader["CurrentResidentialAddress"] != DBNull.Value)
                gRXX.CurrentResidentialAddress = Convert.ToString(dataReader["CurrentResidentialAddress"]);
            // 籍贯
            if (dataReader["NativePlace"] != DBNull.Value)
                gRXX.NativePlace = Convert.ToString(dataReader["NativePlace"]);
            // 联系电话
            if (dataReader["ContactPhone"] != DBNull.Value)
                gRXX.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
            // 文化程度
            if (dataReader["EducationLevel"] != DBNull.Value)
                gRXX.EducationLevel = Convert.ToString(dataReader["EducationLevel"]);
            // 职业
            if (dataReader["Professional"] != DBNull.Value)
                gRXX.Professional = Convert.ToString(dataReader["Professional"]);
            // 所属单位编号
            if (dataReader["CompanyId"] != DBNull.Value)
                gRXX.CompanyId = Convert.ToString(dataReader["CompanyId"]);
            // 家族病史
            if (dataReader["FamilyHistory"] != DBNull.Value)
                gRXX.FamilyHistory = Convert.ToString(dataReader["FamilyHistory"]);
            // 付费方式
            if (dataReader["Billing"] != DBNull.Value)
                gRXX.Billing = Convert.ToString(dataReader["Billing"]);
            // 登记日期
            if (dataReader["DateOfRegistration"] != DBNull.Value)
                gRXX.DateOfRegistration = Convert.ToString(dataReader["DateOfRegistration"]);
            // 体育锻炼情况
            if (dataReader["PhysicalExercise"] != DBNull.Value)
                gRXX.PhysicalExercise = Convert.ToString(dataReader["PhysicalExercise"]);
            // 个人饮食情况
            if (dataReader["PersonalDiet"] != DBNull.Value)
                gRXX.PersonalDiet = Convert.ToString(dataReader["PersonalDiet"]);
            // 个人睡眠情况
            if (dataReader["PersonalSleep"] != DBNull.Value)
                gRXX.PersonalSleep = Convert.ToString(dataReader["PersonalSleep"]);
            // 吸烟情况
            if (dataReader["CigaretteSmoking"] != DBNull.Value)
                gRXX.CigaretteSmoking = Convert.ToString(dataReader["CigaretteSmoking"]);
            // 饮酒情况
            if (dataReader["AlcoholDrinking"] != DBNull.Value)
                gRXX.AlcoholDrinking = Convert.ToString(dataReader["AlcoholDrinking"]);
            // 其他情况
            if (dataReader["OtherCircumstances"] != DBNull.Value)
                gRXX.OtherCircumstances = Convert.ToString(dataReader["OtherCircumstances"]);
            // 既往史
            if (dataReader["PreviousHistory"] != DBNull.Value)
                gRXX.PreviousHistory = Convert.ToString(dataReader["PreviousHistory"]);
            // 药物过敏
            if (dataReader["DrugAllergy"] != DBNull.Value)
                gRXX.DrugAllergy = Convert.ToString(dataReader["DrugAllergy"]);
            // 读物接触史
            if (dataReader["ReadingHistoryOfExposure"] != DBNull.Value)
                gRXX.ReadingHistoryOfExposure = Convert.ToString(dataReader["ReadingHistoryOfExposure"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为GRXX对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        protected void ReadGRXXPageData(IDataReader dataReader, GRXX gRXX)
        {
            // 流水号
            if (dataReader["SerialId"] != DBNull.Value)
                gRXX.SerialId = Convert.ToInt32(dataReader["SerialId"]);
            // 预约号
            if (dataReader["ReservationId"] != DBNull.Value)
                gRXX.ReservationId = Convert.ToString(dataReader["ReservationId"]);
            // 体检号
            if (dataReader["PhysicalExamination"] != DBNull.Value)
                gRXX.PhysicalExamination = Convert.ToString(dataReader["PhysicalExamination"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                gRXX.Name = Convert.ToString(dataReader["Name"]);
            // 姓名拼音码
            if (dataReader["NameOfRubyCode"] != DBNull.Value)
                gRXX.NameOfRubyCode = Convert.ToString(dataReader["NameOfRubyCode"]);
            // 性别
            if (dataReader["Sex"] != DBNull.Value)
            {
                Sex tmpSex = Sex.GetDataById(Convert.ToInt32(dataReader["Sex"]));
                if (tmpSex != null) gRXX.Sex = tmpSex;
            }
            // 出生日期
            if (dataReader["DateOfBirth"] != DBNull.Value)
                gRXX.DateOfBirth = Convert.ToString(dataReader["DateOfBirth"]);
            // 身份证
            if (dataReader["IDCard"] != DBNull.Value)
                gRXX.IDCard = Convert.ToString(dataReader["IDCard"]);
            // 民族
            if (dataReader["Nationa"] != DBNull.Value)
                gRXX.Nationa = Convert.ToString(dataReader["Nationa"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将个人信息（GRXX）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public abstract int Insert(GRXX gRXX);


        /// <summary>
        /// 将个人信息（GRXX）数据，根据主键“流水号（SerialId）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public abstract int Update(GRXX gRXX);


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public abstract int Delete(int serialId);


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”从数据库中获取个人信息（GRXX）的实例。
        /// 成功从数据库中取得记录返回新个人信息（GRXX）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public abstract GRXX GetDataBySerialId(int serialId);


        /// <summary>
        /// 从数据库中读取并返回所有个人信息（GRXX）List列表。
        /// </summary>
        public abstract List<GRXX> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人信息（GRXX）的列表及分页信息。
        /// 该方法所获取的个人信息（GRXX）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
