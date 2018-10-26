using System;

namespace Z.Framework.Extension
{
    public static class SafeConvertExtension
    {
        public static string SafeToStr(this object data, string defaultValue = "")
        {
            string result = defaultValue;

            if (data != null)
            {
                result = data.ToString();
            }

            return result;
        }


        public static int SafeToInt32(this object data, int defaultValue = default(int))
        {
            int result = defaultValue;

            if (data != null)
            {
                if (!int.TryParse(data.ToString(), out result))
                {
                    result = defaultValue;
                }
            }

            return result;
        }

        public static decimal SafeToDecimal(this object data, decimal defaultValue = default(decimal))
        {
            decimal result = defaultValue;

            if (data != null)
            {
                if (!decimal.TryParse(data.ToString(), out result))
                {
                    result = defaultValue;
                }
            }

            return result;
        }

        public static DateTime SafeToDateTime(this object data, DateTime defaultValue = default(DateTime))
        {
            DateTime result = defaultValue;

            if (data != null)
            {
                if (!DateTime.TryParse(data.ToString(), out result))
                {
                    result = defaultValue;
                }
            }

            return result;
        }

        public static bool SafeToBool(this object data, bool defaultValue = default(bool))
        {
            bool result = defaultValue;

            if (data != null)
            {
                if (data.ToString() == "1"
                    || data.ToString().ToLower() == "true"
                    || data.ToString().ToLower() == "on"
                    || data.ToString().ToLower() == "checked")
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
