using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;

/// <summary>
/// Summary description for FNumber
/// </summary>
namespace Library.Tools
{
    public class FNumber
    {
        public static string FormatNumber(double number, int NumDecimal, string Lang)
        {
            CultureInfo cul = new CultureInfo(Lang);
            string format = string.Format("N{0}", NumDecimal.ToString());
            cul.NumberFormat.CurrencyDecimalDigits = NumDecimal;
            string ch = cul.NumberFormat.CurrencyDecimalSeparator;
            if (NumDecimal == 0)
                return number.ToString(format);
            return number.ToString(format).TrimEnd('0').TrimEnd(ch[0]);
        }

        public static string FormatNumber(double number, int NumDecimal)
        {
            string format = string.Format("N{0}", NumDecimal.ToString());
            string tmp = Math.Round((double)number, NumDecimal).ToString(format);
            if (CultureInfo.CurrentCulture.Name == "vi-VN")
            {
                tmp = tmp.Replace(',', '#');
                tmp = tmp.Replace('.', ',');
                tmp = tmp.Replace('#', '.');
            }

            return tmp;
        }

        public static string FormatNumber(decimal number, int NumDecimal)
        {
            return FormatNumber((double)number, NumDecimal);
        }

        public static string FormatNumber(object number, int NumberDecimal, string Lang)
        {
            return FormatNumber(Convert.ToDouble(number), NumberDecimal, Lang);
        }

        public static string FormatNumber(object number, int NumberDecimal)
        {
            return FormatNumber(Convert.ToDouble(number), NumberDecimal);
        }

        public static string FormatNumber(object number)
        {
            return FormatNumber(number, 0);
        }

        public static string FormatNumber(double number)
        {
            return FormatNumber(number, 0);
        }

        public static string FormatNumber(decimal number)
        {
            return FormatNumber(number, 0);
        }

        public static decimal ConvertDecimal(string value)
        {
            return decimal.Parse(value, new CultureInfo("en-US"));
        }

        public static int ConvertInt(string value)
        {
            int f = 0;
            int.TryParse(value, NumberStyles.Integer,new CultureInfo("en-US") ,out f);
            return f;
        }

        public static bool IsDecimal(string value)
        {
            decimal val = 0;
            return decimal.TryParse(value, NumberStyles.Float, new CultureInfo("en-US"), out val);
        }

        public static decimal Round2(decimal val)
        {
            long r = Convert.ToInt64(val);
            long tmp = r % 100;

            if (tmp < 50)
                return (r / 100) * 100;
            return ((r / 100) * 100) + 100;
        }

        public static decimal Round2(string val)
        {
            return Round2(decimal.Parse(val));
        }
    }
}