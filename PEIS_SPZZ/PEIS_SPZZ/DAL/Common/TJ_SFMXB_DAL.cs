using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;
using System.Data;

namespace PEIS_SPZZ.DAL.Common
{
    /// <summary>
    /// 对象名称：体检收费  通用数据访问父类（数据访问层）
    /// 对象说明：提供“体检收费（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“体检收费（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public abstract class TJ_SFMXB_DAL
    {
        //警告：仅用于缓存“体检收费（TJ_SFMXB_DAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static TJ_SFMXB_DAL tJ_SFMXB_DAL;


        /// <summary>
        /// 获取“体检收费（TJ_SFMXB_DAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“体检收费（TJ_SFMXB_DAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static TJ_SFMXB_DAL Instance
        {
            get
            {
                if (tJ_SFMXB_DAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            tJ_SFMXB_DAL = new SqlServer.TJ_SFMXB_DAL();
                            break;

                        default:
                            tJ_SFMXB_DAL = new SqlServer.TJ_SFMXB_DAL();
                            break;
                    }
                }
                return tJ_SFMXB_DAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为TJ_SFMXB对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="tJ_SFMXB">体检费用（TJ_SFMXB）实例对象</param>
        protected void ReadTJ_SFMXBAllData(IDataReader dataReader, TJ_SFMXB tJ_SFMXB)
        {
            
        
        }


        /// <summary>
        /// 从DataReader中读取数据，并为TJ_SFMXB对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="gRXX">体检费用（TJ_SFMXB）实例对象</param>
        protected void ReadTJ_SFMXBPageData(IDataReader dataReader, TJ_SFMXB tJ_SFMXB)
        {
           
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将体检费用（TJ_SFMXB）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="tJ_SFMXB">体检费用（TJ_SFMXB）实例对象</param>
        public abstract int Insert(TJ_SFMXB tJ_SFMXB);


        /// <summary>
        /// 将体检费用（TJ_SFMXB）数据，根据主键“流水号（ID）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="tJ_SFMXB">体检费用（TJ_SFMXB）实例对象</param>
        public abstract int Update(TJ_SFMXB tJ_SFMXB);


        /// <summary>
        /// 根据体检费用（TJ_SFMXB）的主键“流水号（ID）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">体检费用（TJ_SFMXB）的主键“流水号（ID）”</param>
        public abstract int Delete(int serialId);


        /// <summary>
        /// 根据 体检费用（TJ_SFMXB）的主键“流水号（ID）”从数据库中获取体检费用（TJ_SFMXB）的实例。
        /// 成功从数据库中取得记录返回新体检费用（TJ_SFMXB）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">体检费用（TJ_SFMXB）的主键“流水号（ID）”</param>
        public abstract TJ_SFMXB GetDataBySerialId(int serialId);


        /// <summary>
        /// 从数据库中读取并返回所有体检费用（TJ_SFMXB）List列表。
        /// </summary>
        public abstract List<TJ_SFMXB> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的体检费用（TJ_SFMXB）的列表及分页信息。
        /// 该方法所获取的体检费用（TJ_SFMXB）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);

















    }
}
