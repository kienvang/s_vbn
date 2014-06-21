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
/// Summary description for FDateTime
/// </summary>
namespace Library.Tools
{
    public class FDateTime
    {
        public static DateTime ResetTime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        }

        public static int CompareDate(DateTime dt1, DateTime dt2)
        {
            dt1 = ResetTime(dt1);
            dt2 = ResetTime(dt2);
            return dt1.CompareTo(dt2);
        }

        public static int Days(DateTime dt1, DateTime dt2)
        {
            dt1 = ResetTime(dt1);
            dt2 = ResetTime(dt2);

            return dt2.Subtract(dt1).Days + 1;
        }

        public static string FormatDateTime(DateTime dt, string Lang)
        {
            if (Lang == "vi-VN")
            {
                return GetDayName(dt.DayOfWeek) + dt.ToString("dd/MM/yyyy - H:mm");
            }
            return dt.ToString("dddd, MMMM dd, yyyy - H:mm");
        }

        public static string FormatDate(DateTime dt, string Lang)
        {
            if (Lang == "vi-VN")
            {
                return GetDayName(dt.DayOfWeek) + dt.ToString("dd/MM/yyyy");
            }
            return dt.ToString("dddd, MMMM dd, yyyy");
        }

        public static string GetDayName(DayOfWeek dayofweek)
        {
            string st = "";
            switch (dayofweek)
            {
                case DayOfWeek.Monday:
                    st = "Thứ Hai ";
                    break;
                case DayOfWeek.Tuesday:
                    st = "Thứ Ba ";
                    break;
                case DayOfWeek.Wednesday:
                    st = "Thứ Tư ";
                    break;
                case DayOfWeek.Thursday:
                    st = "Thứ Năm ";
                    break;
                case DayOfWeek.Friday:
                    st = "Thứ Sáu ";
                    break;
                case DayOfWeek.Saturday:
                    st = "Thứ Bảy ";
                    break;
                case DayOfWeek.Sunday:
                    st = "Chủ Nhật ";
                    break;
            }
            return st;
        }

        public static string FormatDate(DateTime dt)
        {
            return FormatDate(dt, CultureInfo.CurrentCulture.Name);
        }

        public static string FormatDateTime(DateTime dt)
        {
            return FormatDateTime(dt, CultureInfo.CurrentCulture.Name);
        }

        public static string FormatTime(int Minutes, string Lang)
        {
            int m = Minutes % 60;
            int h = Minutes - m;
            string strM = "minutes";
            string strH = "hours";
            if (Lang == "vi-VN")
            {
                strM = "phút";
                strH = "giờ";
            }
            string time = "";

            if (h > 0)
            {
                time += (h / 60).ToString() + " " + strH + " ";
            }

            if (m > 0)
            {
                time += m.ToString() + " " + strM + " ";
            }

            return time;
        }

        public static string FormatTime(int Minutes)
        {
            return FormatTime(Minutes, CultureInfo.CurrentCulture.Name);
        }

        public static DateTime ConvertDate(string value)
        {
            return Convert.ToDateTime(value, new CultureInfo("vi-VN"));
        }

        public static DateTime ConvertTime(string value)
        {
            try
            {
                string[] st = value.Trim().Split(':');
                int[] time = { int.Parse(st[0]), int.Parse(st[1]) };
                return new DateTime(1900, 1, 1, time[0], time[1], 0);
            }
            catch
            {
            }
            return DateTime.Now;
        }
    }
}