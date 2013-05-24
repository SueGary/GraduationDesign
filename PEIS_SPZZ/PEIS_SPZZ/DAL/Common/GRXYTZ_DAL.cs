using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;


namespace PEIS_SPZZ.DAL.Common
{
    /// <summary>
    /// 对象名称：个人血压体重  通用数据访问父类（数据访问层）
    /// 对象说明：提供“个人血压体重（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“个人血压体重（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public abstract class GRXYTZ_DAL
    {
        //警告：仅用于缓存“个人信息（GRXXDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static GRXYTZ_DAL gRXYTZ;
        /// <summary>
        /// 获取“个人信息（GRXXDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“个人信息（GRXXDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static GRXYTZ_DAL Instance
        {
            get
            {
                if (gRXYTZ == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            gRXYTZ = new SqlServer.GRXYTZ_DAL();
                            break;

                        default:
                            gRXYTZ = new SqlServer.GRXYTZ_DAL();
                            break;
                    }
                }
                return gRXYTZ;
            }
        }

    }
    

}
