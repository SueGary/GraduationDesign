using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using PEIS_SPZZ.COL;

namespace PEIS_SPZZ.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：个人血压、体重SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“个人血压、体重（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 通常不需要直接实例化本类，而使用“个人血压、体重（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public class GRXYTZ_DAL:DAL.Common.GRXYTZ_DAL
    {
        /// <summary>
        /// 将个人血压体重（GRXYTZ）数据，采用INSERT操作插入到数据库中，并返回影响的行数
        /// </summary>
        /// <param name="gRXYTZ">个人血压体重（GRXYTZ）实例对象</param>
        /// <returns></returns>
        public override int Insert(COL.GRXYTZ gRXYTZ)
        {
           // string sqlText = "INSERT INTO [GRXYTZ]([ID],[TJRYID],[SSY],[SZY],[TZ],[XL],[RQSJ])VALUES(@ID,@TJRYID,@SSY,@SZY,@TZ,@XL,@RQSJ)";
            string sqlText = "INSERT INTO [GRXYTZ]([TJRYID],[SSY],[SZY],[TZ],[XL],[RQSJ])VALUES(@TJRYID,@SSY,@SZY,@TZ,@XL,@RQSJ)";
            SqlParameter[] parameters = 
            {
             //   new SqlParameter("@ID", SqlDbType.Int,32){ Value =gRXYTZ.Id},
                new SqlParameter("@TJRYID", SqlDbType.NVarChar , 10){ Value = gRXYTZ.Tjryid},
                new SqlParameter("@SSY", SqlDbType.Text){ Value = gRXYTZ.Ssy},
                new SqlParameter("@SZY", SqlDbType.Text){ Value = gRXYTZ.Szy },
                new SqlParameter("@TZ", SqlDbType.Text){ Value = gRXYTZ.Tz},
                new SqlParameter("@XL", SqlDbType.Text){ Value = gRXYTZ.Xl},
                new SqlParameter("@RQSJ", SqlDbType.DateTime){ Value = gRXYTZ.Rqsj } 
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }
        /// <summary>
        /// 将个人血压体重（GRXYTZ）数据，根据ID号，采用UPDATE操作更新到数据库中，并返回影响的行数
        /// </summary>
        /// <param name="gRXYTZ">个人血压体重（GRXYTZ）实例对象</param>
        /// <returns></returns>
        public override int Update(COL.GRXYTZ gRXYTZ)
        {
            string sqlText = "UPDATE [GRXYTZ] SET "
                         + "[SSY]=@SSY,[SZY]=@SZY,[TZ]=@TZ,[XL]=@XL,[RQSJ]=@RQSJ WHERE [ID]=@ID";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ID", SqlDbType.Int,32){ Value =gRXYTZ.Id},
             //   new SqlParameter("@TJRYID", SqlDbType.NVarChar , 10){ Value = gRXYTZ.Tjryid},
                new SqlParameter("@SSY", SqlDbType.Text){ Value = gRXYTZ.Ssy},
                new SqlParameter("@SZY", SqlDbType.Text){ Value = gRXYTZ.Szy },
                new SqlParameter("@TZ", SqlDbType.Text){ Value = gRXYTZ.Tz},
                new SqlParameter("@XL", SqlDbType.Text){ Value = gRXYTZ.Xl},
                new SqlParameter("@RQSJ", SqlDbType.DateTime){ Value = gRXYTZ.Rqsj } 
               
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }
        /// <summary>
        /// 根据个人血压体重（GRXYTZ）的主键ID，采用DEL操作从数据库中删除相关记录，并返回受影响的行数
        /// </summary>
        /// <param name="serialId"></param>
        /// <returns></returns>
        public override int Delete(int serialId)
        {
            string sqlText = "DELETE FROM [GRXYTZ] "
                          + "WHERE [ID]=@ID";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ID", SqlDbType.Int,32){ Value =serialId},
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }
        /// <summary>
        /// 根据个人血压体重（GRXYTZ）的主键“流水号（ID）”从数据库中获取个人血压体重（GRXYTZ）的实例。
        /// 成功从数据库中取得记录返回新个人血压体重（GRXYTZ）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId"></param>
        /// <returns></returns>
        public override COL.GRXYTZ GetDataBySerialId(int serialId)
        {
            GRXYTZ gRXYTZ = null;
            string sqlText = "SELECT [ID],[TJRYID],[SSY],[SZY],[TZ],[XL],[RQSJ]"
                           + "FROM [GRXYTZ] "
                           + "WHERE [ID]=@ID";
            SqlParameter[] parameters = 
            {
               new SqlParameter("@ID", SqlDbType.Int,32){ Value =serialId},
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                gRXYTZ = new GRXYTZ();
                ReadGRXYTZAllData(sqlDataReader, gRXYTZ);
            }
            sqlDataReader.Close();
            return gRXYTZ;
        }
        /// <summary>
        /// 从数据库中读取并返回所有个人血压体重（GRXYTZ）List列表。
        /// </summary>
        /// <returns></returns>
        public override List<COL.GRXYTZ> GetAllList()
        {
            string sqlText = "SELECT [ID],[TJRYID],[SSY],[SZY],[TZ],[XL],[RQSJ] FROM [GRXYTZ] ";
            List<GRXYTZ> list = new List<GRXYTZ>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                GRXYTZ gRXYTZ = new GRXYTZ();
                ReadGRXYTZAllData(sqlDataReader, gRXYTZ);
                list.Add(gRXYTZ);
            }
            sqlDataReader.Close();
            return list;
        }
        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人血压体重（GRXYTZ）的列表及分页信息。
        /// 该方法所获取的个人血压体重（GRXYTZ）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="curPage">当前页数</param>
        /// <returns></returns>
        public override COL.PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [ID],[TJRYID],[SSY],[SZY],[TZ],[XL],[RQSJ] FROM [GRXYTZ]";
            List<GRXYTZ> list = new List<GRXYTZ>();
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
                    GRXYTZ gRXYTZ = new GRXYTZ();
                    ReadGRXYTZPageData(sqlDataReader, gRXYTZ);
                    list.Add(gRXYTZ);
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
