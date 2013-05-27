using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.DAL.Common
{
    /// <summary>
    /// 对象名称：个人每周运动 通用数据访问父类（数据访问层）
    /// 对象说明：提供“个人每周运动（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“个人每周运动类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    public abstract class GRMZYD_DAL
    {
        //警告：仅用于缓存“个人每周运动（GRMZYD_DAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static GRMZYD_DAL gRMZYD_DAL;
        /// <summary>
        /// 获取“个人每周运动（GRMZYD_DAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“个人每周运动（GRMZYD_DAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static GRMZYD_DAL Instance
        {
            get
            {
                if (gRMZYD_DAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            gRMZYD_DAL = new SqlServer.GRMZYD_DAL();
                            break;

                        default:
                            gRMZYD_DAL = new SqlServer.GRMZYD_DAL();
                            break;
                    }
                }
                return gRMZYD_DAL;
            }
        }
         /// <summary>
         /// 从DataReader中读取数据，并为GRMZYD对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="dataReader">IDataReader</param>
       /// <param name="gRMZYD">个人每周运动（GRMZYD）实例对象</param>
        protected void ReadGRMZYDAllData(IDataReader dataReader, GRMZYD gRMZYD)
        { 
            //标识每项运动
            if (dataReader["YDID"] != DBNull.Value)
                gRMZYD.YdId = Convert.ToString(dataReader["YDID"]);
            //个人信息ID
            if (dataReader["TJRYID"] != DBNull.Value)
                gRMZYD.TjryId = Convert.ToString(dataReader["TJRYID"]);
            //时间
            if (dataReader["SJ"] != DBNull.Value)
                gRMZYD.Sj = Convert.ToString(dataReader["SJ"]);
            //计划运动
            if (dataReader["JHYD"] != DBNull.Value)
                gRMZYD.Jhyd = Convert.ToString(dataReader["JHYD"]);
            //落实情况
            if (dataReader["LSQK"] != DBNull.Value)
                gRMZYD.Lsqk = Convert.ToString(dataReader["LSQK"]);
        
        }

       /// <summary>
        /// 从DataReader中读取数据，并为GRMZYD对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
       /// </summary>
        /// <param name="dataReader">IDataReader</param>
        /// <param name="gRMZYD">每周运动（GRMZYD）实例对象</param>
        protected void ReadGRMZYDPageData(IDataReader dataReader, GRMZYD gRMZYD)
        { 
            //标识每项运动
            if (dataReader["YDID"] != DBNull.Value)
                gRMZYD.YdId = Convert.ToString(dataReader["YDID"]);
            //个人信息ID
            if (dataReader["TJRYID"] != DBNull.Value)
                gRMZYD.TjryId = Convert.ToString(dataReader["TJRYID"]);
            //时间
            if (dataReader["SJ"] != DBNull.Value)
                gRMZYD.Sj = Convert.ToString(dataReader["SJ"]);
            //计划运动
            if (dataReader["JHYD"] != DBNull.Value)
                gRMZYD.Jhyd = Convert.ToString(dataReader["JHYD"]);
            //落实情况
            if (dataReader["LSQK"] != DBNull.Value)
                gRMZYD.Lsqk = Convert.ToString(dataReader["LSQK"]);
        
        }
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 将个人每周运动（GRMZYD）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRMZYD">个人每周运动（GRMZYD）实例对象</param>
        /// <returns></returns>
        public abstract int Insert(GRMZYD gRMZYD);

        /// <summary>
        /// 将个人每周运动（GRMZYD）数据，根据主键“唯一标识每项运动（YDID）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRMZYD">个人每周运动（GRMZYD）实例对象</param>
        /// <returns></returns>
        public abstract int Update(GRMZYD gRMZYD);

        /// <summary>
        /// 根据个人每周运动（GRMZYD）的主键“唯一标识每项运动（YDID）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">人每周运动（GRMZYD）的主键“唯一标识每项运动（YDID）”</param>
        public abstract int Delete(int yDID);


        /// <summary>
        /// 根据个人每周运动（GRMZYD）的主键“唯一标识每项运动（YDID）”从数据库中获取个人每周运动（GRMZYD）的实例。
        /// 成功从数据库中取得记录返回新个人信息（GRXX）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">人每周运动（GRMZYD）的主键“唯一标识每项运动（YDID）”</param>
        public abstract GRMZYD GetDataBySerialId(int yDID);

        /// <summary>
        /// 从数据库中读取并返回所个人每周运动（GRMZYD）List列表。
        /// </summary>
        public abstract List<GRMZYD> GetAllList();

        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的个人每周运动（GRMZYD)的列表及分页信息。
        /// 该方法所获取的个人每周运动（GRMZYD)列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);















































    }
}
