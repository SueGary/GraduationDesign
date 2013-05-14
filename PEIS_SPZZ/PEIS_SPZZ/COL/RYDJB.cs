using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.COL
{
    /// <summary>
    /// 对象名称：个人信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：苏嘉立
    /// 编写日期：2013-5-15
    /// </summary>
     [Serializable]
    public class RYDJB
    {
         /// <summary>
         /// [变量]流水号
         /// </summary>
         private int? lsId;
         /// <summary>
         /// [变量]体检人员号
         /// </summary>
         private string tjryId;
         /// <summary>
         /// [变量]体检卡号
         /// </summary>
         private string tjkId;
         /// <summary>
         /// [变量]体检人员姓名
         /// </summary>
         private string tjName;
         /// <summary>
         /// [变量]姓名拼音码
         /// </summary>
         private string tjNameOfPY;
         /// <summary>
         /// [变量]体检人员性别
         /// </summary>
         private Sex sex;
         /// <summary>
         /// [变量]体检人员出生日期
         /// </summary>
         private string birthday;
         /// <summary>
         /// [变量]年龄
         /// </summary>
         private int age;
         /// <summary>
         /// [变量]身份证号
         /// </summary>
         private string numOfID;
         /// <summary>
         /// [变量]单位编号
         /// </summary>
         private string numOfdep;
         /// <summary>
         /// [变量]民族
         /// </summary>
         private string minzu;
         /// <summary>
         /// [变量]婚姻状况
         /// </summary>
         private Marriage hunyin;
         /// <summary>
         /// [变量]现居住地
         /// </summary>
         private string address;
         /// <summary>
         /// [变量]籍贯
         /// </summary>
         private string jiguan;
         /// <summary>
         /// [变量]联系电话
         /// </summary>
         private string lxdh;
         /// <summary>
         /// [变量]文化程度
         /// </summary>
         private string whcd;
         /// <summary>
         /// [变量]职业
         /// </summary>
         private string zhiye;


         /// <summary>
         /// [属性]流水号
         /// </summary>
         public int? LsId
         {
             get { return lsId; }
             set { lsId = value; }
         }
         /// <summary>
         /// [属性]体检人员号
         /// </summary>
         public string TjryId
         {
             get { return tjryId; }
             set { tjryId = value; }
         }
         /// <summary>
         /// [属性]体检卡号
         /// </summary>
         public string TjkId
         {
             get { return tjkId; }
             set { tjkId = value; }
         }
         /// <summary>
         /// [属性]体检人员姓名
         /// </summary>
         public string TjName
         {
               get { return tjName; }
               set { tjName = value;}
         }
         /// <summary>
         /// [属性]姓名拼音码
         /// </summary>
         public string TjNameOfPY
         {
             get { return tjNameOfPY; }
             set { tjNameOfPY = value; }
         }
         /// <summary>
         /// [属性]体检人员性别
         /// </summary>
         public Sex Sex
         {
             get { return sex; }
             set { sex = value;}
         }
         /// <summary>
         /// [属性]体检人员出生日期
         /// </summary>
         public string Birthday
         {
             get { return birthday; }
             set { birthday = value;}
         }
         /// <summary>
         /// [属性]年龄
         /// </summary>
         public int Age
         {
             get { return age; }
             set { age = value; }
         }

         /// <summary>
         /// [属性]身份证号
         /// </summary>
         public string NumOfID
         {
             get { return numOfID; }
             set { numOfID = value; }
         }
         /// <summary>
         /// [属性]单位编号
         /// </summary>
         public string NumOfdep
         {
             get { return numOfdep; }
             set { numOfdep = value; }
         }
         /// <summary>
         /// [属性]民族
         /// </summary>
         public string Minzu
         {
             get { return minzu; }
             set { minzu = value; }
         }
         /// <summary>
         /// [属性]婚姻状况
         /// </summary>
         public Marriage Hunyin
         {
             get { return hunyin; }
             set { hunyin = value; }
         }
         /// <summary>
         /// [属性]现居住地
         /// </summary>
         public string Address
         {
             get { return address; }
             set { address = value; }
         }
         /// <summary>
         /// [属性]籍贯
         /// </summary>
         public string Jiguan
         {
             get { return jiguan; }
             set { jiguan = value; }
         }
         /// <summary>
         /// [属性]联系电话
         /// </summary>
         public string Lxdh
         {
             get { return lxdh; }
             set { lxdh = value; }
         }
         /// <summary>
         /// [属性]文化程度
         /// </summary>
         public string Whcd
         {
             get { return whcd; }
             set { whcd = value; }
         }
         /// <summary>
         /// [属性]职业
         /// </summary>
         public string Zhiye
         {
             get { return zhiye; }
             set { zhiye = value;}
         }
    }
}
