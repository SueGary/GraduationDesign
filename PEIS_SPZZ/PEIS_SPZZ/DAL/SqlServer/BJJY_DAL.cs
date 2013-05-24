using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PEIS_SPZZ.COL;
using PEIS_SPZZ.SFL;

namespace PEIS_SPZZ.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：保健建议SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“保健建议（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 通常不需要直接实例化本类，而使用“保健建议（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public class BJJY_DAL:Common.BJJY_DAL
    {
        /// <summary>
        /// 将保健建议（BJJY）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">保健建议（BJJY）实例对象</param>
        public override int Insert(BJJY bJJY) {
        string sqlText="INSERT INTO []"
        
        
        }


        /// <summary>
        /// 将保健建议（BJJY）数据，根据主键“流水号（Msid）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="gRXX">保健建议（BJJY）实例对象</param>
        public override int Update(BJJY bJJY) { 
        
        
        
        
        
        }


        /// <summary>
        /// 根据保健建议（BJJY）的主键“流水号（Msid）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="serialId">保健建议（BJJY）的主键“流水号（Msid）”</param>
        public override int Delete(int serialId){
        
        
        
        
        }


        /// <summary>
        /// 根据保健建议（BJJY）的主键“流水号（Msid）”从数据库中获取保健建议（BJJY）的实例。
        /// 成功从数据库中取得记录返回新 保健建议（BJJY）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="serialId">保健建议（BJJY）的主键“流水号（Msid）”</param>
        public override BJJY GetDataBySerialId(int serialId){
        
        
        
        
        }


        /// <summary>
        /// 从数据库中读取并返回所有保健建议（BJJY）List列表。
        /// </summary>
        public override List<BJJY> GetAllList(){
        
        
        
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的保健建议（BJJY）的列表及分页信息。
        /// 该方法所获取的保健建议（BJJY）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage){
        
        
        
        
        }
    }
}
