using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：性别数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-15 
    /// </summary>
    [Serializable]
    public class Sex
    {
        /// <summary>
        /// [变量]编号
        /// </summary>
        private int id;
        /// <summary>
        /// [变量]名称
        /// </summary>
        private string name;
        /// <summary>
        /// [属性]编号
        /// </summary>
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        /// <summary>
        /// 实例化对象方法。私有仅供内部访问
        /// </summary>
        private Sex()
        { 
        }

        public static readonly Sex Empty = new Sex();

        public static readonly Sex Male = new Sex()
        {
            id = 0,
            name = "男"
        };
        public static readonly Sex Female = new Sex()
        {
            id=1,
            name="女"
        };
        /// <summary>
        /// 所有“性别”对象列表
        /// </summary>
        public static readonly List<Sex> AllList = new List<Sex>
        {
            Sex.Male,
            Sex.Female
        };
        /// <summary>
        /// 根据“性别”编号，返回一个“性别”对象。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Sex GetDataById(int id)
        {
            foreach (Sex tmpSex in AllList)
            {
                if (tmpSex.id == id)
                    return tmpSex;
            }
            return null;
        }
        /// <summary>
        /// 已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return name;
        }
    }
}
