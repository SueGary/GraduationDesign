using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：个人每周运动SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“个人信息类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 通常不需要直接实例化本类，而使用“个人信息类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-15
    /// </summary>
    public class GRMZYD_DAL:DAL.Common.GRMZYD_DAL
    {
        /// <summary>
        /// 将个每周运动（GRMZYD）数据，利用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRMZYD">个人每周运动（GRMZYD）实例对象</param>
        /// <returns></returns>
        public override int Insert(GRMZYD gRMZYD)
        {
            string sqlText = "INSERT INTO [GRMZYD]"
                           + "([YDID],[TJRYID],[SJ],[JHYD],[LSQK])"
                           + "VALUES"
                           + "(@ydid,@tjryid,@sj,@jhyd,@lsqk)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ydid",System.Data.SqlDbType.NVarChar,10){Value=gRMZYD.YdId},
                new SqlParameter("@tjryid",System.Data.SqlDbType.NVarChar,10){Value=gRMZYD.TjryId},
                new SqlParameter("@sj",System.Data.SqlDbType.NVarChar,10){Value=gRMZYD.Sj},
                new SqlParameter("@jhyd",System.Data.SqlDbType.Text){Value=gRMZYD.Jhyd},
                new SqlParameter("@lsqk",System.Data.SqlDbType.Text){Value=gRMZYD.Lsqk}
         
            
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }
        /// <summary>
        /// 将个人每周运动（GRMZYD）数据，根据主键，采用UPDATE更新到数据库，返回影响的行数
        /// </summary>
        /// <param name="gRMZYD">个人每周运动（GRMZYD）实例对象</param>
        /// <returns></returns>
        public override int  Update(GRMZYD gRMZYD)
        {
            string sqlText = "UPDATE [GRMZYD] SET"
                        + "[TJRYID]=@tjryid,[SJ]=@sj,[JHYD]=@jhyd,[LSQK]=@lsqk"
                        + "WHERE [YDID]=@ydid";
            SqlParameter[] parameters =
            {
                new SqlParameter("@tjryid",SqlDbType.NVarChar,10){Value=gRMZYD.TjryId},
                new SqlParameter("@sj",SqlDbType.NVarChar,10){Value=gRMZYD.Sj},
                new SqlParameter("@jhyd",SqlDbType.Text){Value=gRMZYD.Jhyd},
                new SqlParameter("@lsqk",SqlDbType.Text){Value=gRMZYD.Lsqk},
                new SqlParameter("@ydid",SqlDbType.NVarChar,10){Value=gRMZYD.YdId}      
            
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText,parameters);
        }
        /// <summary>
        /// 将个人每周运动（GRMZYD）数据，根据主键，采用delete删除相关记录，返回影响的行数
        /// </summary>
        /// <param name="yDID">主键 运动标识号</param>
        /// <returns></returns>
        public override int Delete(int yDID)
        {
            string sqlText = "DELETE FROM[GRMZYD]"
                            + "WHERE [YDID]=@ydid";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ydid",SqlDbType.NVarChar,10){Value=yDID}            
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }
        /// <summary>
        /// 根据个人每周运动的主键 从数据库获取个人每周运动的实例
        /// </summary>
        /// <param name="yDID">个人每周运动的主键</param>
        /// <returns></returns>
        public override GRMZYD GetDataBySerialId(int yDID)
        {
            GRMZYD gRMZYD = null;
            string sqlText = "SELECT * FROM [GRMZYD] WHERE [YDID]=@ydid";
            SqlParameter[] parameters ={
             new SqlParameter("@ydid",SqlDbType.NVarChar,10){Value=yDID}};
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read()) {
                gRMZYD = new GRMZYD();
                ReadGRMZYDAllData(sqlDataReader, gRMZYD);
            }
            sqlDataReader.Close();
            return gRMZYD;
        }
        /// <summary>
        /// 从数据库中读取并返回所有个人每周运动（GRMZYD）LIST 列表
        /// </summary>
        /// <returns></returns>
        public override List<GRMZYD> GetAllList()
        {
            string sqlText = "Select * from [GRMZYD]";
            List<GRMZYD> list = new List<GRMZYD>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read()) {
                GRMZYD gRMZYD = new GRMZYD();
                ReadGRMZYDAllData(sqlDataReader, gRMZYD);
                list.Add(gRMZYD);
            }
            sqlDataReader.Close();
            return list;
        }
        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人每周运动（GRMZYD）的列表及分页信息。
        /// 该方法所获取的个人每周运动（GRMZYD）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        /// <param name="pageSize">页面大小</param>
        /// <param name="curPage">当前页数</param>
        /// <returns></returns>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "select * from [GRMZYD]";
            List<GRMZYD> list = new List<GRMZYD>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;
            while (sqlDataReader.Read()) {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    GRMZYD gRXX = new GRMZYD();
                    ReadGRMZYDPageData(sqlDataReader, gRXX);
                    list.Add(gRXX);
                }
            }
            sqlDataReader.Close();

            if (pageData.RecordCount > 0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }



       



    }
}
