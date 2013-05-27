﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：体检收费 SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“体检收费 （业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 通常不需要直接实例化本类，而使用“体检收费（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-24
    /// </summary>
    public class TJ_SFMXB_DAL:Common.TJ_SFMXB_DAL
    {
        public override int Insert(COL.TJ_SFMXB tJ_SFMXB)
        {
            throw new NotImplementedException();
        }

        public override int Update(COL.TJ_SFMXB tJ_SFMXB)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int serialId)
        {
            throw new NotImplementedException();
        }

        public override COL.TJ_SFMXB GetDataBySerialId(int serialId)
        {
            throw new NotImplementedException();
        }

        public override List<COL.TJ_SFMXB> GetAllList()
        {
            throw new NotImplementedException();
        }

        public override COL.PageData GetPageList(int pageSize, int curPage)
        {
            throw new NotImplementedException();
        }
    }
}
