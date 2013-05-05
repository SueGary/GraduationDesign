using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SUJIALI.PEIS.BLL;
using SUJIALI.PEIS.COL;
using SUJIALI.PEIS.SFL;

namespace SUJIALI.PEIS.UIL.TmpPath
{
    /// <summary>
    /// 对象名称：“空白模块模块”修改界面控件（用户界面层）
    /// 对象说明：该界面用于修改“个人信息”对象并提交至数据库，修改操作成功后返回列表界面。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013/5/5 14:41:42
    /// </summary>
    public partial class Modify : UserControl
    {
        private GRXX gRXX;
        private static Modify instance;

        /// <summary>
        /// 返回一个该控件的实例。如果之前该控件已经被创建，直接返回已创建的控件。
        /// 此处采用单键模式对控件实例进行缓存，避免因界面切换重复创建和销毁对象。
        /// </summary>
        public static Modify Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Modify();
                }

                if (instance.gRXX == null)
                    throw new CustomException("在调用本模块修改界面的实例前，必须调用Modify.LoadDataById方法，装载所要修改的关联对象。",ExceptionType.Error);

                instance.InitControl();      // 每次返回该控件的实例前，都将对下拉框等界面显示控件的数据源进行初始化。
                instance.BindObjectToForm(); // 每次返回该控件的实例前，都将关联对象当前的值，绑定至界面控件进行显示。
                return instance;
            }
        }

        /// <summary>
        /// 根据关联对象的主键，从数据库中获取关联对象信息，以备进行修改操作。
        /// </summary>
        public static void LoadDataById(string gRXXSerialId)
        {
            if (instance == null)
            {
                instance = new Modify();
            }
            instance.gRXX = GRXXBLL.GetDataBySerialId(gRXXSerialId);
            if (instance.gRXX == null)
                throw new CustomException("对不起，所要修改的信息不存在或已删除。");
        }

        /// <summary>
        /// 私有的控件实例化方法，创建实例只能通过该控件的Instance属性实现。
        /// </summary>
        private Modify()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 用户单击“保存”按钮时的事件处理方法。
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            BindFormlToObject(); // 进行数据绑定
            GRXXBLL.Update(gRXX); // 调用“业务逻辑层”的方法，检查有效性后更新至数据库。
            FormSysMessage.ShowSuccessMsg("“个人信息”修改成功，单击“确定”按钮返回信息列表。");
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }

        /// <summary>
        /// 用户单击“取消”按钮时的事件处理方法。
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormMain.LoadNewControl(Default.Instance); // 载入该模块的信息列表界面至主窗体显示。
        }


        #region 界面控件与关联对象之间的绑定方法

        /// <summary>
        /// 初始化下拉框等控件的数据源。
        /// </summary>
        private void InitControl()
        {
            //指定“性别”下拉框的数据源
            DrpSex.DisplayMember = "name";
            DrpSex.ValueMember = "id";
            DrpSex.DataSource = Sex.AllList;

        }

        /// <summary>
        /// 将界面控件中的值，绑定给关联对象。
        /// </summary>
        private void BindFormlToObject()
        {
            if (!DataValid.IsNullOrInt(DrpSex.SelectedValue.ToString()))
                throw new CustomException("“性别”的编号，不是一个有效的整数，请您重新输入。");

            gRXX.ReservationId = DataValid.GetNullOrString(TxtReservationId.Text);  // 预约号
            gRXX.PhysicalExamination = DataValid.GetNullOrString(TxtPhysicalExamination.Text);  // 体检号
            gRXX.Name = DataValid.GetNullOrString(TxtName.Text);  // 姓名
            gRXX.NameOfRubyCode = DataValid.GetNullOrString(TxtNameOfRubyCode.Text);  // 姓名拼音码
            gRXX.Sex = Sex.GetDataById(DataValid.GetNullOrInt(DrpSex.SelectedValue.ToString()).Value);  // 性别
            gRXX.DateOfBirth = DataValid.GetNullOrString(TxtDateOfBirth.Text);  // 出生日期
            gRXX.IDCard = DataValid.GetNullOrString(TxtIDCard.Text);  // 身份证
            gRXX.Nationa = DataValid.GetNullOrString(TxtNationa.Text);  // 民族
            gRXX.ThePoliticalLandscape = DataValid.GetNullOrString(TxtThePoliticalLandscape.Text);  // 政治面貌
            gRXX.MaritalStatus = DataValid.GetNullOrString(TxtMaritalStatus.Text);  // 婚姻状况
            gRXX.WhereHisherHousehold = DataValid.GetNullOrString(TxtWhereHisherHousehold.Text);  // 户口所在地
            gRXX.CurrentResidentialAddress = DataValid.GetNullOrString(TxtCurrentResidentialAddress.Text);  // 现居住地址
            gRXX.NativePlace = DataValid.GetNullOrString(TxtNativePlace.Text);  // 籍贯
            gRXX.ContactPhone = DataValid.GetNullOrString(TxtContactPhone.Text);  // 联系电话
            gRXX.EducationLevel = DataValid.GetNullOrString(TxtEducationLevel.Text);  // 文化程度
            gRXX.Professional = DataValid.GetNullOrString(TxtProfessional.Text);  // 职业
            gRXX.CompanyId = DataValid.GetNullOrString(TxtCompanyId.Text);  // 所属单位编号
            gRXX.FamilyHistory = DataValid.GetNullOrString(TxtFamilyHistory.Text);  // 家族病史
            gRXX.Billing = DataValid.GetNullOrString(TxtBilling.Text);  // 付费方式
            gRXX.DateOfRegistration = DataValid.GetNullOrString(TxtDateOfRegistration.Text);  // 登记日期
            gRXX.PhysicalExercise = DataValid.GetNullOrString(TxtPhysicalExercise.Text);  // 体育锻炼情况
            gRXX.PersonalDiet = DataValid.GetNullOrString(TxtPersonalDiet.Text);  // 个人饮食情况
            gRXX.PersonalSleep = DataValid.GetNullOrString(TxtPersonalSleep.Text);  // 个人睡眠情况
            gRXX.CigaretteSmoking = DataValid.GetNullOrString(TxtCigaretteSmoking.Text);  // 吸烟情况
            gRXX.AlcoholDrinking = DataValid.GetNullOrString(TxtAlcoholDrinking.Text);  // 饮酒情况
            gRXX.OtherCircumstances = DataValid.GetNullOrString(TxtOtherCircumstances.Text);  // 其他情况
            gRXX.PreviousHistory = DataValid.GetNullOrString(TxtPreviousHistory.Text);  // 既往史
            gRXX.DrugAllergy = DataValid.GetNullOrString(TxtDrugAllergy.Text);  // 药物过敏
            gRXX.ReadingHistoryOfExposure = DataValid.GetNullOrString(TxtReadingHistoryOfExposure.Text);  // 读物接触史
        }

        /// <summary>
        /// 将关联对象中的值，绑定至界面控件进行显示。
        /// </summary>
        private void BindObjectToForm()
        {
            TxtReservationId.Text = gRXX.ReservationId;  // 预约号
            TxtPhysicalExamination.Text = gRXX.PhysicalExamination;  // 体检号
            TxtName.Text = gRXX.Name;  // 姓名
            TxtNameOfRubyCode.Text = gRXX.NameOfRubyCode;  // 姓名拼音码
            if (gRXX.Sex != null) DrpSex.SelectedValue = gRXX.Sex.id ;
            TxtDateOfBirth.Text = gRXX.DateOfBirth;  // 出生日期
            TxtIDCard.Text = gRXX.IDCard;  // 身份证
            TxtNationa.Text = gRXX.Nationa;  // 民族
            TxtThePoliticalLandscape.Text = gRXX.ThePoliticalLandscape;  // 政治面貌
            TxtMaritalStatus.Text = gRXX.MaritalStatus;  // 婚姻状况
            TxtWhereHisherHousehold.Text = gRXX.WhereHisherHousehold;  // 户口所在地
            TxtCurrentResidentialAddress.Text = gRXX.CurrentResidentialAddress;  // 现居住地址
            TxtNativePlace.Text = gRXX.NativePlace;  // 籍贯
            TxtContactPhone.Text = gRXX.ContactPhone;  // 联系电话
            TxtEducationLevel.Text = gRXX.EducationLevel;  // 文化程度
            TxtProfessional.Text = gRXX.Professional;  // 职业
            TxtCompanyId.Text = gRXX.CompanyId;  // 所属单位编号
            TxtFamilyHistory.Text = gRXX.FamilyHistory;  // 家族病史
            TxtBilling.Text = gRXX.Billing;  // 付费方式
            TxtDateOfRegistration.Text = gRXX.DateOfRegistration;  // 登记日期
            TxtPhysicalExercise.Text = gRXX.PhysicalExercise;  // 体育锻炼情况
            TxtPersonalDiet.Text = gRXX.PersonalDiet;  // 个人饮食情况
            TxtPersonalSleep.Text = gRXX.PersonalSleep;  // 个人睡眠情况
            TxtCigaretteSmoking.Text = gRXX.CigaretteSmoking;  // 吸烟情况
            TxtAlcoholDrinking.Text = gRXX.AlcoholDrinking;  // 饮酒情况
            TxtOtherCircumstances.Text = gRXX.OtherCircumstances;  // 其他情况
            TxtPreviousHistory.Text = gRXX.PreviousHistory;  // 既往史
            TxtDrugAllergy.Text = gRXX.DrugAllergy;  // 药物过敏
            TxtReadingHistoryOfExposure.Text = gRXX.ReadingHistoryOfExposure;  // 读物接触史
        }

        #endregion 界面控件与关联对象之间的绑定方法


    }
}
