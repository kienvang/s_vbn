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

using Library.Tools;

/// <summary>
/// Summary description for NumberReservation
/// </summary>
namespace Modules
{
    public class OrderCode
    {
        int _year = 2009;
        short _ascii = 65;

        public static OrderCode CreateInstant()
        {
            return new OrderCode();
        }

        public string GetNumber(int Year, int Month, int Day, string type)
        {
            string year = GetYear(Year);
            string month = Month.ToString().PadLeft(2, '0');
            string day = Day.ToString().PadLeft(2, '0');
            int number = 1;

            if (string.IsNullOrEmpty(year))
                return string.Empty;

            string strSQL = "Select Top(1) Id,NumberId " +
                            "From OrderCode " +
                            "Where NumberYear='{0}' and NumberMonth='{1}'  and Id=( Select Max(Id) " +
                            "                                                       From OrderCode " +
                            "                                                       Where NumberYear='{0}' and NumberMonth='{1}')";
            DataTable table = new DataTable();
            strSQL = string.Format(strSQL, year, month);
            table = SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake,
                CommandType.Text, strSQL, null);

            if (table != null && table.Rows.Count > 0)
                number = Convert.ToInt32(table.Rows[0]["NumberId"]) + 1;

            strSQL = "Insert Into OrderCode(NumberYear,NumberMonth,NumberDay,NumberId) " +
                     "Values ('{0}','{1}','{2}',{3})";
            strSQL = string.Format(strSQL, year, month, day, number.ToString());
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake,
                CommandType.Text, strSQL, null);

            return year + type + month + day + number.ToString();
        }

        public string GetNumber()
        {
            return GetNumber(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, "");
        }

        string GetYear(int Year)
        {
            if (Year < _year)
                return string.Empty;

            string stYear = Year.ToString();
            int[] year = { int.Parse(stYear[0].ToString()), int.Parse(stYear[1].ToString()), int.Parse(stYear[2].ToString()), int.Parse(stYear[3].ToString()) };

            return ConvertAscii(year[2]) + ConvertAscii(year[3]);
        }

        string GetMonth(int Month)
        {
            if (Month < 10)
                return Month.ToString();

            short ascii = _ascii;

            for (int i = 10; i < Month; i++)
                ascii++;

            return ((char)ascii).ToString();
        }

        string ConvertAscii(int value)
        {
            return ((char)(value + _ascii)).ToString();
        }
    }
}