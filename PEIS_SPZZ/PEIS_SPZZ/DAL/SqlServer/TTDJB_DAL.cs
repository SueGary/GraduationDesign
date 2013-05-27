using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：团体登记  SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“团体登记（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 通常不需要直接实例化本类，而使用“团体登记（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public class TTDJB_DAL:Common.TTDJB_DAL
    {
        public override int Insert(COL.TTDJB tTDJB)
        {
            throw new NotImplementedException();
        }

        public override int Update(COL.TTDJB tTDJB)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int serialId)
        {
            throw new NotImplementedException();
        }

        public override COL.TTDJB GetDataBySerialId(int serialId)
        {
            throw new NotImplementedException();
        }

        public override List<COL.TTDJB> GetAllList()
        {
            throw new NotImplementedException();
        }

        public override COL.PageData GetPageList(int pageSize, int curPage)
        {
            throw new NotImplementedException();
        }
    }
}
