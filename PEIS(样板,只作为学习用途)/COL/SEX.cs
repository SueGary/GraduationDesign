﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace SUJIALI.PEIS.COL
{
    /// <summary>
    /// 对象名称：性别数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-5 14:41:27
    /// </summary>
    [Serializable]
    public class Sex
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? _id;
        /// <summary>[变量]名称</summary>
        private string _name;


        /// <summary>[属性]编号</summary>
        public int? id
        {
            get { return _id; }
        }
        /// <summary>[属性]名称</summary>
        public string name
        {
            get { return _name; }
        }


        /// <summary>实例化对象方法。私有仅供内部访问</summary>
        private Sex()
        {
        }

        public static readonly Sex Empty = new Sex();

        public static readonly Sex Male  = new Sex()
        {
            _id = 1,
            _name = "男"
        };

        public static readonly Sex Femal  = new Sex()
        {
            _id = 2,
            _name = "女"
        };

        /// <summary>所有“性别”对象列表。</summary>
        public static readonly List<Sex> AllList = new List<Sex>
        {
            Sex.Male ,
            Sex.Femal 
        };

        /// <summary>根据“性别”编号，返回一个“性别”对象。</summary>
        public static Sex GetDataById(int id)
        {
            foreach (Sex tmpSex in AllList)
            {
                if (tmpSex.id == id)
                    return tmpSex;
            }
            return null;
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return name;
        }

        #endregion EasyCode所生成的默认代码
    }
}
