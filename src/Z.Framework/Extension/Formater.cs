using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z.Framework.Extension
{
    public static class Formater
    {

        public static string FormatString = "yyyy-MM-dd HH:mm:ss";
        /// <summary>
        /// 格式化时间
        /// </summary>
        public static string FormatDateTimeStr(this DateTime dt)
        {
            return dt.ToString(FormatString);
        }

        /// <summary>
        /// 格式化时间
        /// </summary>
        public static string FormatDateTimeStr(this DateTime? dt)
        {
            if (dt.HasValue)
            {
                return dt.Value.ToString(FormatString);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
