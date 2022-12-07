using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary
{
    public static class Ext
    {
        public static bool MakeBool(this bool? item)
        {
            if (item == null)
                return false;
            else
                return System.Convert.ToBoolean(item);
        }

        public static string MakeString(this object val)
        {
            if (val == null)
                return string.Empty;
            else
                return val.ToString();
        }
        public static double MakeDouble(this double? val)
        {
            if (val == null)
                return 0.00;
            else
                return Convert.ToDouble(val);
        }

        public static int MakeInt(this int? val)
        {
            if (val == null)
                return 0;
            else
                return Convert.ToInt32(val);
        }
        public static DateTime MakeDateTime(this object val)
        {
            if (val == null)
                return default(DateTime);
            else
                return Convert.ToDateTime(val);
        }

        public static string Token()
        {
            //SQL: select replace(lower(newid()), '-', '')
            return Guid.NewGuid().MakeString().Replace("-", "").Replace("{", "").Replace("}", "");
        }

        public static string Encrypt(this string value)
        {
            if (!string.IsNullOrEmpty(value))
                return Crypto.Encrypt(value);
            else
                return value;
        }
        public static string Decrypt(this string value)
        {
            if (!string.IsNullOrEmpty(value))
                return Crypto.Decrypt(value);
            else
                return value;
        }


    }
}
