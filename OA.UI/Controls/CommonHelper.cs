
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Windows.Threading;

namespace Ay.Framework.WPF
{

    /// <summary>
    /// 公共帮助类
    /// </summary>
    public class CommonHelper
    {

        #region 类型转换
        /// <summary>
        /// 返回对象obj的String值,obj为null时返回空值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>字符串。</returns>
        public static string ToObjectString(object obj)
        {
            return null == obj ? String.Empty : obj.ToString();
        }
        /// <summary>
        /// 取得Int值,如果为Null 则返回０
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int GetInt(object obj)
        {
            if (obj != null)
            {
                int i;
                int.TryParse(obj.ToString(), out i);
                return i;
            }
            else
                return 0;
        }

        public static float GetFloat(object obj)
        {
            float i;
            float.TryParse(obj.ToString(), out i);
            return i;
        }
        public static decimal GetTryDecimal(object obj)
        {
            decimal i;
            decimal.TryParse(obj.ToString(), out i);
            return i;
        }

        /// <summary>
        /// 取得Int值,如果不成功则返回指定exceptionvalue值
        /// </summary>
        /// <param name="obj">要计算的值</param>
        /// <param name="exceptionvalue">异常时的返回值</param>
        /// <returns></returns>
        public static int GetInt(object obj, int exceptionvalue)
        {
            if (obj == null)
                return exceptionvalue;
            if (string.IsNullOrEmpty(obj.ToString()))
                return exceptionvalue;
            int i = exceptionvalue;
            try { i = Convert.ToInt32(obj); }
            catch { i = exceptionvalue; }
            return i;
        }

        /// <summary>
        /// 取得byte值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte Getbyte(object obj)
        {
            if (obj != null && obj.ToString() != "")
                return byte.Parse(obj.ToString());
            else
                return 0;
        }

        /// <summary>
        /// 获得Long值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static long GetLong(object obj)
        {
            if (obj != null && obj.ToString() != "")
                return long.Parse(obj.ToString());
            else
                return 0;
        }

        /// <summary>
        /// 取得Long值,如果不成功则返回指定exceptionvalue值
        /// </summary>
        /// <param name="obj">要计算的值</param>
        /// <param name="exceptionvalue">异常时的返回值</param>
        /// <returns></returns>
        public static long GetLong(object obj, long exceptionvalue)
        {
            if (obj == null)
            {
                return exceptionvalue;
            }
            if (string.IsNullOrEmpty(obj.ToString()))
            {
                return exceptionvalue;
            }
            long i = exceptionvalue;
            try
            {
                i = Convert.ToInt64(obj);
            }
            catch
            {
                i = exceptionvalue;
            }
            return i;
        }

        /// <summary>
        /// 取得Decimal值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static decimal GetDecimal(object obj)
        {
            if (obj != null && obj.ToString() != "")
                return decimal.Parse(obj.ToString());
            else
                return 0;
        }
        /// <summary>
        /// 取得GetDouble值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static double GetDouble(object obj)
        {
            if (obj != null && obj.ToString() != "")
                return double.Parse(obj.ToString());
            else
                return 0;
        }

        /// <summary>
        /// 取得DateTime值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime GetDateTime(object obj)
        {
            if (obj != null && obj.ToString() != "")
                //return DateTime.Parse(obj.ToString());    
                return Convert.ToDateTime(obj);
            else
                return DateTime.Now;
            //return DateTime.MinValue;
        }
        /// <summary>
        /// 取得DateTime值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime? ToDateTime(object obj)
        {
            if (obj != null && obj.ToString() != "")
                return DateTime.Parse(obj.ToString());
            else
                return null;
        }
        /// <summary>
        /// 格式化日期 yyyy-MM-dd HH:mm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetFormatDateTime(object obj, string Format)
        {
            if (obj.ToString() != null && obj.ToString() != "")
                return DateTime.Parse(obj.ToString()).ToString(Format);
            else
                return "";
        }

        /// <summary>
        /// 格式化日期 yyyy-MM-dd HH:mm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetYYYYMMddDateTime(DateTime obj)
        {
            return obj.ToString("yyyy-MM-dd HH:mm:ss");
        }



        /// <summary>
        /// 取得bool值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool GetBool(object obj)
        {
            if (obj != null)
            {
                bool flag;
                bool.TryParse(obj.ToString(), out flag);
                return flag;
            }
            else
                return false;
        }

        /// <summary>
        /// 取得byte[]
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Byte[] GetByte(object obj)
        {
            if (obj.ToString() != null && obj.ToString() != "")
            {
                return (Byte[])obj;
            }
            else
                return null;
        }

        /// <summary>
        /// 取得string值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetString(object obj)
        {
            if (obj != null && obj != DBNull.Value)
                return obj.ToString();
            else
                return "";
        }
        /// <summary>   
        /// 判断用户输入是否为日期   
        /// </summary>   
        /// <param ></param>   
        /// <returns></returns>   
        /// <remarks>   
        /// 可判断格式如下（其中-可替换为.，不影响验证)   
        /// YYYY | YYYY-MM |YYYY.MM| YYYY-MM-DD|YYYY.MM.DD | YYYY-MM-DD HH:MM:SS | YYYY.MM.DD HH:MM:SS | YYYY-MM-DD HH:MM:SS.FFF | YYYY.MM.DD HH:MM:SS:FF (年份验证从1000到2999年)
        /// </remarks>   
        public static bool IsDateTime(string strValue)
        {
            if (strValue == null || strValue == "")
            {
                return false;
            }
            string regexDate = @"[1-2]{1}[0-9]{3}((-|[.]){1}(([0]?[1-9]{1})|(1[0-2]{1}))((-|[.]){1}((([0]?[1-9]{1})|([1-2]{1}[0-9]{1})|(3[0-1]{1})))( (([0-1]{1}[0-9]{1})|2[0-3]{1}):([0-5]{1}[0-9]{1}):([0-5]{1}[0-9]{1})(\.[0-9]{3})?)?)?)?$";
            if (Regex.IsMatch(strValue, regexDate))
            {
                //以下各月份日期验证，保证验证的完整性   
                int _IndexY = -1;
                int _IndexM = -1;
                int _IndexD = -1;
                if (-1 != (_IndexY = strValue.IndexOf("-")))
                {
                    _IndexM = strValue.IndexOf("-", _IndexY + 1);
                    _IndexD = strValue.IndexOf(":");
                }
                else
                {
                    _IndexY = strValue.IndexOf(".");
                    _IndexM = strValue.IndexOf(".", _IndexY + 1);
                    _IndexD = strValue.IndexOf(":");
                }
                //不包含日期部分，直接返回true   
                if (-1 == _IndexM)
                {
                    return true;
                }
                if (-1 == _IndexD)
                {
                    _IndexD = strValue.Length + 3;
                }
                int iYear = Convert.ToInt32(strValue.Substring(0, _IndexY));
                int iMonth = Convert.ToInt32(strValue.Substring(_IndexY + 1, _IndexM - _IndexY - 1));
                int iDate = Convert.ToInt32(strValue.Substring(_IndexM + 1, _IndexD - _IndexM - 4));
                //判断月份日期   
                if ((iMonth < 8 && 1 == iMonth % 2) || (iMonth > 8 && 0 == iMonth % 2))
                {
                    if (iDate < 32)
                    { return true; }
                }
                else
                {
                    if (iMonth != 2)
                    {
                        if (iDate < 31)
                        { return true; }
                    }
                    else
                    {
                        //闰年   
                        if ((0 == iYear % 400) || (0 == iYear % 4 && 0 < iYear % 100))
                        {
                            if (iDate < 30)
                            { return true; }
                        }
                        else
                        {
                            if (iDate < 29)
                            { return true; }
                        }
                    }
                }
            }
            return false;
        }
        #endregion

        #region 数据判断
        /// <summary>
        /// 判断文本obj是否为空值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Boolean值。</returns>
        public static bool IsEmpty(string obj)
        {
            return ToObjectString(obj).Trim() == String.Empty ? true : false;
        }

        /// <summary>
        /// 判断对象是否为正确的日期值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Boolean。</returns>
        public static bool IsDateTime(object obj)
        {
            try
            {
                DateTime dt = DateTime.Parse(ToObjectString(obj));
                if (dt > DateTime.MinValue && DateTime.MaxValue > dt)
                    return true;
                return false;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Int32值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Int32值。</returns>
        public static bool IsInt(object obj)
        {
            try
            {
                int.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Long值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Long值。</returns>
        public static bool IsLong(object obj)
        {
            try
            {
                long.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Float值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Float值。</returns>
        public static bool IsFloat(object obj)
        {
            try
            {
                float.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Double值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Double值。</returns>
        public static bool IsDouble(object obj)
        {
            try
            {
                double.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// 判断对象是否为正确的Decimal值。
        /// </summary>
        /// <param name="obj">对象。</param>
        /// <returns>Decimal值。</returns>
        public static bool IsDecimal(object obj)
        {
            try
            {
                decimal.Parse(ToObjectString(obj));
                return true;
            }
            catch
            { return false; }
        }
        #endregion

        #region "全球唯一码GUID"
        /// <summary>
        /// 获取一个全球唯一码GUID字符串
        /// </summary>
        public static string GetGuid
        {
            get
            {
                return Guid.NewGuid().ToString().ToLower();
            }
        }
        #endregion

        #region 自动生成日期编号
        /// <summary>
        /// 自动生成编号  201008251145409865
        /// </summary>
        /// <returns></returns>
        public static string CreateNo()
        {
            Random random = new Random();
            string strRandom = random.Next(1000, 10000).ToString(); //生成编号 
            string code = DateTime.Now.ToString("yyyyMMddHHmmss") + strRandom;//形如
            return code;
        }
        #endregion

        #region 生成0-9随机数
        /// <summary>
        /// 生成0-9随机数
        /// </summary>
        /// <param name="codeNum">生成长度</param>
        /// <returns></returns>
        public static string RndNum(int codeNum)
        {
            StringBuilder sb = new StringBuilder(codeNum);
            Random rand = new Random();
            for (int i = 1; i < codeNum + 1; i++)
            {
                int t = rand.Next(9);
                sb.AppendFormat("{0}", t);
            }
            return sb.ToString();

        }
        #endregion

  

        #region 排序字段转换
        /// <summary>
        /// 排序字段转换
        /// </summary>
        /// <param name="acquiesce">默认字段</param>
        /// <param name="orderField">排序字段</param>
        /// <returns></returns>
        public static string ToOrderField(string acquiesce, string orderField)
        {
            if (!string.IsNullOrEmpty(orderField))
            {
                return orderField;
            }
            return acquiesce;
        }

        #endregion

        #region string转数组[1,2]转 '1','2'
        public static string ToArrayString(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }
            else
            {
                return "'" + text.Replace(",", "','") + "'";
            }
        }
        #endregion
    }

    public static class CommonHelperExtend
    {
     

        #region <<时间扩展>>

        /// <summary>
        /// 例如2012-03-22 12:22:24 可以转换成20120322
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToDate2IntString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyyMMdd");
        }

        /// <summary>
        /// 获得本周，上周，下周
        /// 2013年11月6日15:38:54 杨洋写
        /// </summary>
        /// <param name="dts">时间</param>
        /// <param name="day">差天，-7就是上周，7就是下周</param>
        /// <returns></returns>
        public static DateTime[] GetWeekDate(this DateTime dts, int day = 0)
        {
            DateTime dt = dts.AddDays(day);
            DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d")));  //本周周一
            DateTime endWeek = startWeek.AddDays(6);  //本周周日
            return new DateTime[] { startWeek, endWeek };
        }

        /// <summary>
        /// 获取开始时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime GetBeginTime(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0);
        }
        /// <summary>
        /// 获取结束时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime GetEndTime(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59);
        }
        /// <summary>
        /// 获取开始时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime? GetBeginTime(this DateTime? dateTime)
        {
            if (!dateTime.HasValue)
            {
                return dateTime;
            }
            return new Nullable<DateTime>(dateTime.Value.GetBeginTime());
        }
        /// <summary>
        /// 获取结束时间
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime? GetEndTime(this DateTime? dateTime)
        {
            if (!dateTime.HasValue)
            {
                return dateTime;
            }
            return new Nullable<DateTime>(dateTime.Value.GetEndTime());
        }
        #endregion

        #region <<字符串长度验证扩展>>
        /// <summary>
        /// 判断此字符串是否超过指定长度
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static bool ValidateLength(this string s, int length)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            return length >= s.Length;
        }
        #endregion

    }
}