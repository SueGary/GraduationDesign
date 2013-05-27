using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEIS_SPZZ.SFL
{
    /// <summary>
    /// 常用方法
    /// </summary>
    public class Method
    {
        /// <summary>
        /// 根据当前日期获取唯一一位14位数的长的字符串
        /// </summary>
        /// <returns>返回该字符串</returns>
        public static string CreateId() {
            string id;
            DateTime time = DateTime.Now;
            id = string.Format("{0:yyyyMMddHHmmss}",time);
            return id;
        }
        /// <summary>
        ///  利用GUID，返回19位唯一标识符
        /// </summary>
        /// <returns>返回该字符串</returns>
        public static string CreateLiuShuiId() {
            string id;
            byte[] buffer = Guid.NewGuid().ToByteArray();
            Int64 tmp=BitConverter.ToInt64(buffer, 0);
            id = Convert.ToString(tmp);
            return id;
        }
        /// <summary>
        /// 根据 格式为“yyyMMddHHmmss”年月日时分秒的字符串，将其字符串类型转化为日期类型
        /// </summary>
        /// <param name="timeString">日期字符串（格式“yyyMMddHHmmss”）</param>
        /// <returns></returns>
        public static DateTime StringToDatetime(string timeString) { 
            string format="yyyyMMddHHmmss";
            
            DateTime dt = DateTime.ParseExact(timeString, format, System.Globalization.CultureInfo.CurrentCulture);
         
            return dt;
        }
    }
}
