using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace SUJIALI.PEIS.COL
{
    /// <summary>
    /// 对象名称：个人信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    [Serializable]
    public class GRXX
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]流水号</summary>
        private int? serialId;
        /// <summary>[变量]预约号</summary>
        private string reservationId;
        /// <summary>[变量]体检号</summary>
        private string physicalExamination;
        /// <summary>[变量]姓名</summary>
        private string name;
        /// <summary>[变量]姓名拼音码</summary>
        private string nameOfRubyCode;
        /// <summary>[变量]性别</summary>
        private Sex sex;
        /// <summary>[变量]出生日期</summary>
        private string dateOfBirth;
        /// <summary>[变量]身份证</summary>
        private string iDCard;
        /// <summary>[变量]民族</summary>
        private string nationa;
        /// <summary>[变量]政治面貌</summary>
        private string thePoliticalLandscape;
        /// <summary>[变量]婚姻状况</summary>
        private string maritalStatus;
        /// <summary>[变量]户口所在地</summary>
        private string whereHisherHousehold;
        /// <summary>[变量]现居住地址</summary>
        private string currentResidentialAddress;
        /// <summary>[变量]籍贯</summary>
        private string nativePlace;
        /// <summary>[变量]联系电话</summary>
        private string contactPhone;
        /// <summary>[变量]文化程度</summary>
        private string educationLevel;
        /// <summary>[变量]职业</summary>
        private string professional;
        /// <summary>[变量]所属单位编号</summary>
        private string companyId;
        /// <summary>[变量]家族病史</summary>
        private string familyHistory;
        /// <summary>[变量]付费方式</summary>
        private string billing;
        /// <summary>[变量]登记日期</summary>
        private string dateOfRegistration;
        /// <summary>[变量]体育锻炼情况</summary>
        private string physicalExercise;
        /// <summary>[变量]个人饮食情况</summary>
        private string personalDiet;
        /// <summary>[变量]个人睡眠情况</summary>
        private string personalSleep;
        /// <summary>[变量]吸烟情况</summary>
        private string cigaretteSmoking;
        /// <summary>[变量]饮酒情况</summary>
        private string alcoholDrinking;
        /// <summary>[变量]其他情况</summary>
        private string otherCircumstances;
        /// <summary>[变量]既往史</summary>
        private string previousHistory;
        /// <summary>[变量]药物过敏</summary>
        private string drugAllergy;
        /// <summary>[变量]读物接触史</summary>
        private string readingHistoryOfExposure;


        /// <summary>[属性]流水号</summary>
        public int? SerialId
        {
            get { return serialId; }
            set { serialId = value; }
        }
        /// <summary>[属性]预约号</summary>
        public string ReservationId
        {
            get { return reservationId; }
            set { reservationId = value; }
        }
        /// <summary>[属性]体检号</summary>
        public string PhysicalExamination
        {
            get { return physicalExamination; }
            set { physicalExamination = value; }
        }
        /// <summary>[属性]姓名</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]姓名拼音码</summary>
        public string NameOfRubyCode
        {
            get { return nameOfRubyCode; }
            set { nameOfRubyCode = value; }
        }
        /// <summary>[属性]性别</summary>
        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[属性]出生日期</summary>
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        /// <summary>[属性]身份证</summary>
        public string IDCard
        {
            get { return iDCard; }
            set { iDCard = value; }
        }
        /// <summary>[属性]民族</summary>
        public string Nationa
        {
            get { return nationa; }
            set { nationa = value; }
        }
        /// <summary>[属性]政治面貌</summary>
        public string ThePoliticalLandscape
        {
            get { return thePoliticalLandscape; }
            set { thePoliticalLandscape = value; }
        }
        /// <summary>[属性]婚姻状况</summary>
        public string MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }
        /// <summary>[属性]户口所在地</summary>
        public string WhereHisherHousehold
        {
            get { return whereHisherHousehold; }
            set { whereHisherHousehold = value; }
        }
        /// <summary>[属性]现居住地址</summary>
        public string CurrentResidentialAddress
        {
            get { return currentResidentialAddress; }
            set { currentResidentialAddress = value; }
        }
        /// <summary>[属性]籍贯</summary>
        public string NativePlace
        {
            get { return nativePlace; }
            set { nativePlace = value; }
        }
        /// <summary>[属性]联系电话</summary>
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        /// <summary>[属性]文化程度</summary>
        public string EducationLevel
        {
            get { return educationLevel; }
            set { educationLevel = value; }
        }
        /// <summary>[属性]职业</summary>
        public string Professional
        {
            get { return professional; }
            set { professional = value; }
        }
        /// <summary>[属性]所属单位编号</summary>
        public string CompanyId
        {
            get { return companyId; }
            set { companyId = value; }
        }
        /// <summary>[属性]家族病史</summary>
        public string FamilyHistory
        {
            get { return familyHistory; }
            set { familyHistory = value; }
        }
        /// <summary>[属性]付费方式</summary>
        public string Billing
        {
            get { return billing; }
            set { billing = value; }
        }
        /// <summary>[属性]登记日期</summary>
        public string DateOfRegistration
        {
            get { return dateOfRegistration; }
            set { dateOfRegistration = value; }
        }
        /// <summary>[属性]体育锻炼情况</summary>
        public string PhysicalExercise
        {
            get { return physicalExercise; }
            set { physicalExercise = value; }
        }
        /// <summary>[属性]个人饮食情况</summary>
        public string PersonalDiet
        {
            get { return personalDiet; }
            set { personalDiet = value; }
        }
        /// <summary>[属性]个人睡眠情况</summary>
        public string PersonalSleep
        {
            get { return personalSleep; }
            set { personalSleep = value; }
        }
        /// <summary>[属性]吸烟情况</summary>
        public string CigaretteSmoking
        {
            get { return cigaretteSmoking; }
            set { cigaretteSmoking = value; }
        }
        /// <summary>[属性]饮酒情况</summary>
        public string AlcoholDrinking
        {
            get { return alcoholDrinking; }
            set { alcoholDrinking = value; }
        }
        /// <summary>[属性]其他情况</summary>
        public string OtherCircumstances
        {
            get { return otherCircumstances; }
            set { otherCircumstances = value; }
        }
        /// <summary>[属性]既往史</summary>
        public string PreviousHistory
        {
            get { return previousHistory; }
            set { previousHistory = value; }
        }
        /// <summary>[属性]药物过敏</summary>
        public string DrugAllergy
        {
            get { return drugAllergy; }
            set { drugAllergy = value; }
        }
        /// <summary>[属性]读物接触史</summary>
        public string ReadingHistoryOfExposure
        {
            get { return readingHistoryOfExposure; }
            set { readingHistoryOfExposure = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
