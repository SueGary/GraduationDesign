using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using SUJIALI.PEIS.COL;
using SUJIALI.PEIS.SFL;

namespace SUJIALI.PEIS.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：个人信息SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“个人信息类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“个人信息类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    public class GRXXDAL:DAL.Common.GRXXDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将个人信息（GRXX）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public override int Insert(GRXX gRXX)
        {
            string sqlText = "INSERT INTO [tj_grxx]"
                           + "([ReservationId],[PhysicalExamination],[Name],[NameOfRubyCode],[Sex],[DateOfBirth],[IDCard],[Nationa],[ThePoliticalLandscape],"
                           + "[MaritalStatus],[WhereHisherHousehold],[CurrentResidentialAddress],[NativePlace],[ContactPhone],[EducationLevel],[Professional],[CompanyId],"
                           + "[FamilyHistory],[Billing],[DateOfRegistration],[PhysicalExercise],[PersonalDiet],[PersonalSleep],[CigaretteSmoking],[AlcoholDrinking],"
                           + "[OtherCircumstances],[PreviousHistory],[DrugAllergy],[ReadingHistoryOfExposure])"
                           + "VALUES"
                           + "(@ReservationId,@PhysicalExamination,@Name,@NameOfRubyCode,@Sex,@DateOfBirth,@IDCard,@Nationa,@ThePoliticalLandscape,"
                           + "@MaritalStatus,@WhereHisherHousehold,@CurrentResidentialAddress,@NativePlace,@ContactPhone,@EducationLevel,@Professional,@CompanyId,"
                           + "@FamilyHistory,@Billing,@DateOfRegistration,@PhysicalExercise,@PersonalDiet,@PersonalSleep,@CigaretteSmoking,@AlcoholDrinking,"
                           + "@OtherCircumstances,@PreviousHistory,@DrugAllergy,@ReadingHistoryOfExposure)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ReservationId"             , SqlDbType.NVarChar , 50){ Value = gRXX.ReservationId             },
                new SqlParameter("@PhysicalExamination"       , SqlDbType.NVarChar , 50){ Value = gRXX.PhysicalExamination       },
                new SqlParameter("@Name"                      , SqlDbType.NVarChar , 50){ Value = gRXX.Name                      },
                new SqlParameter("@NameOfRubyCode"            , SqlDbType.NVarChar , 50){ Value = gRXX.NameOfRubyCode            },
                new SqlParameter("@Sex"                       , SqlDbType.Int      , 4 ){ Value = gRXX.Sex.id                    },
                new SqlParameter("@DateOfBirth"               , SqlDbType.NVarChar , 50){ Value = gRXX.DateOfBirth               },
                new SqlParameter("@IDCard"                    , SqlDbType.NVarChar , 50){ Value = gRXX.IDCard                    },
                new SqlParameter("@Nationa"                   , SqlDbType.NVarChar , 50){ Value = gRXX.Nationa                   },
                new SqlParameter("@ThePoliticalLandscape"     , SqlDbType.NVarChar , 50){ Value = gRXX.ThePoliticalLandscape     },
                new SqlParameter("@MaritalStatus"             , SqlDbType.NVarChar , 50){ Value = gRXX.MaritalStatus             },
                new SqlParameter("@WhereHisherHousehold"      , SqlDbType.NVarChar , 50){ Value = gRXX.WhereHisherHousehold      },
                new SqlParameter("@CurrentResidentialAddress" , SqlDbType.NVarChar , 50){ Value = gRXX.CurrentResidentialAddress },
                new SqlParameter("@NativePlace"               , SqlDbType.NVarChar , 50){ Value = gRXX.NativePlace               },
                new SqlParameter("@ContactPhone"              , SqlDbType.NVarChar , 50){ Value = gRXX.ContactPhone              },
                new SqlParameter("@EducationLevel"            , SqlDbType.NVarChar , 50){ Value = gRXX.EducationLevel            },
                new SqlParameter("@Professional"              , SqlDbType.NVarChar , 50){ Value = gRXX.Professional              },
                new SqlParameter("@CompanyId"                 , SqlDbType.NVarChar , 50){ Value = gRXX.CompanyId                 },
                new SqlParameter("@FamilyHistory"             , SqlDbType.NVarChar , 50){ Value = gRXX.FamilyHistory             },
                new SqlParameter("@Billing"                   , SqlDbType.NVarChar , 50){ Value = gRXX.Billing                   },
                new SqlParameter("@DateOfRegistration"        , SqlDbType.NVarChar , 50){ Value = gRXX.DateOfRegistration        },
                new SqlParameter("@PhysicalExercise"          , SqlDbType.NVarChar , 50){ Value = gRXX.PhysicalExercise          },
                new SqlParameter("@PersonalDiet"              , SqlDbType.NVarChar , 50){ Value = gRXX.PersonalDiet              },
                new SqlParameter("@PersonalSleep"             , SqlDbType.NVarChar , 50){ Value = gRXX.PersonalSleep             },
                new SqlParameter("@CigaretteSmoking"          , SqlDbType.NVarChar , 50){ Value = gRXX.CigaretteSmoking          },
                new SqlParameter("@AlcoholDrinking"           , SqlDbType.NVarChar , 50){ Value = gRXX.AlcoholDrinking           },
                new SqlParameter("@OtherCircumstances"        , SqlDbType.NVarChar , 50){ Value = gRXX.OtherCircumstances        },
                new SqlParameter("@PreviousHistory"           , SqlDbType.NVarChar , 50){ Value = gRXX.PreviousHistory           },
                new SqlParameter("@DrugAllergy"               , SqlDbType.NVarChar , 50){ Value = gRXX.DrugAllergy               },
                new SqlParameter("@ReadingHistoryOfExposure"  , SqlDbType.NVarChar , 50){ Value = gRXX.ReadingHistoryOfExposure  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将个人信息（GRXX）数据，根据主键“流水号（SerialId）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">个人信息（GRXX）实例对象</param>
        public override int Update(GRXX gRXX)
        {
            string sqlText = "UPDATE [tj_grxx] SET "
                           + "[ReservationId]=@ReservationId,[PhysicalExamination]=@PhysicalExamination,[Name]=@Name,[NameOfRubyCode]=@NameOfRubyCode,"
                           + "[Sex]=@Sex,[DateOfBirth]=@DateOfBirth,[IDCard]=@IDCard,[Nationa]=@Nationa,[ThePoliticalLandscape]=@ThePoliticalLandscape,"
                           + "[MaritalStatus]=@MaritalStatus,[WhereHisherHousehold]=@WhereHisherHousehold,[CurrentResidentialAddress]=@CurrentResidentialAddress,"
                           + "[NativePlace]=@NativePlace,[ContactPhone]=@ContactPhone,[EducationLevel]=@EducationLevel,[Professional]=@Professional,[CompanyId]=@CompanyId,"
                           + "[FamilyHistory]=@FamilyHistory,[Billing]=@Billing,[DateOfRegistration]=@DateOfRegistration,[PhysicalExercise]=@PhysicalExercise,[PersonalDiet]=@PersonalDiet,"
                           + "[PersonalSleep]=@PersonalSleep,[CigaretteSmoking]=@CigaretteSmoking,[AlcoholDrinking]=@AlcoholDrinking,[OtherCircumstances]=@OtherCircumstances,"
                           + "[PreviousHistory]=@PreviousHistory,[DrugAllergy]=@DrugAllergy,[ReadingHistoryOfExposure]=@ReadingHistoryOfExposure "
                           + "WHERE [SerialId]=@SerialId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ReservationId"             , SqlDbType.NVarChar , 50){ Value = gRXX.ReservationId             },
                new SqlParameter("@PhysicalExamination"       , SqlDbType.NVarChar , 50){ Value = gRXX.PhysicalExamination       },
                new SqlParameter("@Name"                      , SqlDbType.NVarChar , 50){ Value = gRXX.Name                      },
                new SqlParameter("@NameOfRubyCode"            , SqlDbType.NVarChar , 50){ Value = gRXX.NameOfRubyCode            },
                new SqlParameter("@Sex"                       , SqlDbType.Int      , 4 ){ Value = gRXX.Sex.id                    },
                new SqlParameter("@DateOfBirth"               , SqlDbType.NVarChar , 50){ Value = gRXX.DateOfBirth               },
                new SqlParameter("@IDCard"                    , SqlDbType.NVarChar , 50){ Value = gRXX.IDCard                    },
                new SqlParameter("@Nationa"                   , SqlDbType.NVarChar , 50){ Value = gRXX.Nationa                   },
                new SqlParameter("@ThePoliticalLandscape"     , SqlDbType.NVarChar , 50){ Value = gRXX.ThePoliticalLandscape     },
                new SqlParameter("@MaritalStatus"             , SqlDbType.NVarChar , 50){ Value = gRXX.MaritalStatus             },
                new SqlParameter("@WhereHisherHousehold"      , SqlDbType.NVarChar , 50){ Value = gRXX.WhereHisherHousehold      },
                new SqlParameter("@CurrentResidentialAddress" , SqlDbType.NVarChar , 50){ Value = gRXX.CurrentResidentialAddress },
                new SqlParameter("@NativePlace"               , SqlDbType.NVarChar , 50){ Value = gRXX.NativePlace               },
                new SqlParameter("@ContactPhone"              , SqlDbType.NVarChar , 50){ Value = gRXX.ContactPhone              },
                new SqlParameter("@EducationLevel"            , SqlDbType.NVarChar , 50){ Value = gRXX.EducationLevel            },
                new SqlParameter("@Professional"              , SqlDbType.NVarChar , 50){ Value = gRXX.Professional              },
                new SqlParameter("@CompanyId"                 , SqlDbType.NVarChar , 50){ Value = gRXX.CompanyId                 },
                new SqlParameter("@FamilyHistory"             , SqlDbType.NVarChar , 50){ Value = gRXX.FamilyHistory             },
                new SqlParameter("@Billing"                   , SqlDbType.NVarChar , 50){ Value = gRXX.Billing                   },
                new SqlParameter("@DateOfRegistration"        , SqlDbType.NVarChar , 50){ Value = gRXX.DateOfRegistration        },
                new SqlParameter("@PhysicalExercise"          , SqlDbType.NVarChar , 50){ Value = gRXX.PhysicalExercise          },
                new SqlParameter("@PersonalDiet"              , SqlDbType.NVarChar , 50){ Value = gRXX.PersonalDiet              },
                new SqlParameter("@PersonalSleep"             , SqlDbType.NVarChar , 50){ Value = gRXX.PersonalSleep             },
                new SqlParameter("@CigaretteSmoking"          , SqlDbType.NVarChar , 50){ Value = gRXX.CigaretteSmoking          },
                new SqlParameter("@AlcoholDrinking"           , SqlDbType.NVarChar , 50){ Value = gRXX.AlcoholDrinking           },
                new SqlParameter("@OtherCircumstances"        , SqlDbType.NVarChar , 50){ Value = gRXX.OtherCircumstances        },
                new SqlParameter("@PreviousHistory"           , SqlDbType.NVarChar , 50){ Value = gRXX.PreviousHistory           },
                new SqlParameter("@DrugAllergy"               , SqlDbType.NVarChar , 50){ Value = gRXX.DrugAllergy               },
                new SqlParameter("@ReadingHistoryOfExposure"  , SqlDbType.NVarChar , 50){ Value = gRXX.ReadingHistoryOfExposure  },
                new SqlParameter("@SerialId"                  , SqlDbType.Int      , 4 ){ Value = gRXX.SerialId                  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public override int Delete(int serialId)
        {
            string sqlText = "DELETE FROM [tj_grxx] "
                           + "WHERE [SerialId]=@SerialId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@SerialId" , SqlDbType.Int , 4){ Value = serialId }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据个人信息（GRXX）的主键“流水号（SerialId）”从数据库中获取个人信息（GRXX）的实例。
        /// 成功从数据库中取得记录返回新个人信息（GRXX）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">个人信息（GRXX）的主键“流水号（SerialId）”</param>
        public override GRXX GetDataBySerialId(int serialId)
        {
            GRXX gRXX = null;
            string sqlText = "SELECT [SerialId],[ReservationId],[PhysicalExamination],[Name],[NameOfRubyCode],[Sex],[DateOfBirth],[IDCard],[Nationa],[ThePoliticalLandscape],"
                           + "[MaritalStatus],[WhereHisherHousehold],[CurrentResidentialAddress],[NativePlace],[ContactPhone],[EducationLevel],[Professional],[CompanyId],"
                           + "[FamilyHistory],[Billing],[DateOfRegistration],[PhysicalExercise],[PersonalDiet],[PersonalSleep],[CigaretteSmoking],[AlcoholDrinking],"
                           + "[OtherCircumstances],[PreviousHistory],[DrugAllergy],[ReadingHistoryOfExposure] "
                           + "FROM [tj_grxx] "
                           + "WHERE [SerialId]=@SerialId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@SerialId" , SqlDbType.Int , 4){ Value = serialId }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                gRXX = new GRXX();
                ReadGRXXAllData(sqlDataReader,gRXX);
            }
            sqlDataReader.Close();
            return gRXX;
        }


        /// <summary>
        /// 从数据库中读取并返回所有个人信息（GRXX）List列表。
        /// </summary>
        public override List<GRXX> GetAllList()
        {
            string sqlText = "SELECT [SerialId],[ReservationId],[PhysicalExamination],[Name],[NameOfRubyCode],[Sex],[DateOfBirth],[IDCard],[Nationa],[ThePoliticalLandscape],"
                           + "[MaritalStatus],[WhereHisherHousehold],[CurrentResidentialAddress],[NativePlace],[ContactPhone],[EducationLevel],[Professional],[CompanyId],"
                           + "[FamilyHistory],[Billing],[DateOfRegistration],[PhysicalExercise],[PersonalDiet],[PersonalSleep],[CigaretteSmoking],[AlcoholDrinking],"
                           + "[OtherCircumstances],[PreviousHistory],[DrugAllergy],[ReadingHistoryOfExposure] "
                           + "FROM [tj_grxx]";
            List<GRXX> list = new List<GRXX>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                GRXX gRXX = new GRXX();
                ReadGRXXAllData(sqlDataReader, gRXX);
                list.Add(gRXX);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人信息（GRXX）的列表及分页信息。
        /// 该方法所获取的个人信息（GRXX）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [SerialId],[ReservationId],[PhysicalExamination],[Name],[NameOfRubyCode],[Sex],[DateOfBirth],[IDCard],[Nationa] "
                           + "FROM [tj_grxx]";
            List<GRXX> list = new List<GRXX>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            while (sqlDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    GRXX gRXX = new GRXX();
                    ReadGRXXPageData(sqlDataReader, gRXX);
                    list.Add(gRXX);
                }
            }
            sqlDataReader.Close();

            if(pageData.RecordCount>0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
