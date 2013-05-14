using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：婚姻情况数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-15 
    /// </summary>
    [Serializable]
    public class Marriage
    {
        /// <summary>[变量]编号</summary>
        private int id;
        /// <summary>[变量]名称</summary>
        private string name;
        /// <summary>[属性]编号</summary>
        public int ID
        {
            get { return id; }        
        }
        /// <summary>[属性]名称</summary>
        public string Name
        {
            get { return name; }
        }
          /// <summary>实例化对象方法。私有仅供内部访问</summary>
        private Marriage()
        {

        }
        public static readonly Marriage Empty = new Marriage();
        public static readonly Marriage WeiHun = new Marriage()
        {
            id=0,
            name="未婚"
        };
        public static readonly Marriage YiHun = new Marriage() { id=1,name="已婚"};
        public static readonly Marriage LiHun = new Marriage() { id=2,name="离婚"};
        /// <summary>所有“婚姻状况”对象列表。</summary>
        public static readonly List<Marriage> AllList = new List<Marriage>
        {
            Marriage.WeiHun,
            Marriage.YiHun,
            Marriage.LiHun
        };
        /// <summary>
        /// 根据“婚姻状态”编号，返回一个“婚姻状态”对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Marriage GetDataById(int id)
        {
            foreach (Marriage tmpMar in AllList)
            {
                if (tmpMar.id == id)
                    return tmpMar;
            }
            return null;
        }
        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return name;
        }


    }
}
