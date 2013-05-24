using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.DAL.Common
{
    /// <summary>
    /// 对象名称：保健建议  通用数据访问父类（数据访问层）
    /// 对象说明：提供“保健建议（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“保健建议（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public abstract class BJJY_DAL
    {
        //警告：仅用于缓存“保健建议（BJJY_DAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static BJJY_DAL bJJYDAL;

        /// <summary>
        /// 获取“保健建议（BJJY_DAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“保健建议（BJJY_DAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static BJJY_DAL Instance
        {
            get
            {
                if (bJJYDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            bJJYDAL = new SqlServer.BJJY_DAL();
                            break;

                        default:
                            bJJYDAL = new SqlServer.BJJY_DAL();
                            break;
                    }
                }
                return bJJYDAL;
            }
        }

        /// <summary>
        /// 从DataReader中读取数据，并为BJJY对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="bJJY">保健建议（BJJY）实例对象</param>
        protected void ReadBJJYAllData(IDataReader dataReader, BJJY bJJY)
        {
            //流水号
            if (dataReader["MSID"] != DBNull.Value)
                bJJY.Msid = Convert.ToInt32(dataReader["MSID"]);
            // 体检描述
            if (dataReader["TJMS"] != DBNull.Value)
                bJJY.Tjms = Convert.ToString(dataReader["MSID"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为BJJY对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="bJJY">保健建议（BJJY）实例对象</param>
        protected void ReadBJJYPageData(IDataReader dataReader, BJJY bJJY)
        {
           
        }

        /// <summary>
        /// 将保健建议（BJJY）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="bJJY">保健建议（BJJY）实例对象</param>
        public abstract int Insert(BJJY bJJY);


        /// <summary>
        /// 将保健建议（BJJY）数据，根据主键“流水号（Msid）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="bJJY">保健建议（BJJY）实例对象</param>
        public abstract int Update(BJJY bJJY);


        /// <summary>
        /// 根据保健建议（BJJY）的主键“流水号（Msid）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">保健建议（BJJY）的主键“流水号（Msid）”</param>
        public abstract int Delete(int serialId);


        /// <summary>
        /// 根据保健建议（BJJY）的主键“流水号（Msid）”从数据库中获取保健建议（BJJY）的实例。
        /// 成功从数据库中取得记录返回新 保健建议（BJJY）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">保健建议（BJJY）的主键“流水号（Msid）”</param>
        public abstract  BJJY  GetDataBySerialId(int serialId);


        /// <summary>
        /// 从数据库中读取并返回所有保健建议（BJJY）List列表。
        /// </summary>
        public abstract List< BJJY> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的保健建议（BJJY）的列表及分页信息。
        /// 该方法所获取的保健建议（BJJY）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);







    }
}
