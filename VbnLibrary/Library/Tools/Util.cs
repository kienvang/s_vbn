using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Web;
using System.IO;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Collections.Generic;

namespace Library.Tools
{
    /// <summary>
    /// Summary description for Util.
    /// </summary>
    public class Util
    {
        public Util()
        {
        }

        public static string CurrentUserName
        {
            get
            {
                string _CurrentUserName = "";
                if (HttpContext.Current.User.Identity.IsAuthenticated) _CurrentUserName = HttpContext.Current.User.Identity.Name;
                return _CurrentUserName;
            }
        }

        // TrimString("Hello world! This is a truncated string!", 30)

        public static string TrimString(string s, int nMax)
        {
            if (s.Length <= nMax)
                return s;

            int nLastSpace = s.LastIndexOf(" ", nMax - 1);
            if (nLastSpace == -1) return "";

            return s.Substring(0, nLastSpace) + "...";
        }

        // ------ Syntax ------
        // System.Web.UI.Control control1 = LoadControl("~/Controls/CustomControl.ascx");
        // control1.DataBind();
        // string html = RenderControl(control1);
        public static string RenderControl(System.Web.UI.Control ctrl)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            System.IO.StringWriter tw = new System.IO.StringWriter(sb);
            System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
            ctrl.RenderControl(hw);
            return sb.ToString();
        }



        public static string GetNodeText(System.Xml.XmlNode node, string xPath)
        {
            XmlNode temp = node.SelectSingleNode(xPath);
            if (temp != null && temp.InnerText != null)
            {
                return temp.InnerText;
            }
            return "";
        }
        public static string GetNodeText(System.Xml.XmlNode node, string xPath, string nameSpace)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(node.OwnerDocument.NameTable);
            nsmgr.AddNamespace("g", nameSpace);

            XmlNode temp = node.SelectSingleNode(xPath, nsmgr);
            if (temp != null && temp.InnerText != null)
            {
                return temp.InnerText;
            }
            return "";
        }

        public static string RemoveInvalidHostCharacters(string InputString)
        {
            const string ALPHANUMERIC_CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnop0123456789 ";

            string sChar;
            string sOutput = "";
            for (int i = 0; i < InputString.Length; i++)
            {
                sChar = InputString.Substring(i, 1);
                if (ALPHANUMERIC_CHARS.IndexOf(sChar) >= 0)
                {
                    sOutput += sChar;
                }
            }
            return sOutput;
        }

        /// <summary>
        /// Method: Returns proper case of a string.
        /// This does NOT handle people's names like:
        /// O'Brien, van Beethoven, d'Amotto, al Kareem, etc.
        /// </summary>
        public static string GetProperCase(string InputString)
        {
            // Split string on whitespace and put string into an array.
            //string[] InputArray = Regex.Split(InputString,"\\s+");
            string[] InputArray = Regex.Split(InputString, "\\b");
            // Get word count.
            int WordCount = InputArray.GetUpperBound(0);
            string Prefix = "";
            string Suffix = "";
            string ReturnString = "";
            // Loop through array and build output string.
            for (int Loop = 0; Loop <= WordCount; Loop++)
            {
                if (InputArray[Loop].Trim().Length > 0)
                {
                    Prefix = InputArray[Loop].Substring(0, 1);
                    Prefix = Prefix.ToUpper();                        // Make first letter uppercase
                    Suffix = InputArray[Loop].Substring(1);
                    Suffix = Suffix.ToLower();                        // Make remaining characters lowercase
                    ReturnString = ReturnString + Prefix + Suffix;
                }
                else
                {
                    if (InputArray[Loop] == " ")
                        ReturnString = ReturnString + " ";
                }

            }
            return ReturnString;
        }

        /// <summary>
        /// Evaluates an object and returns True if the object can be converted to a number 
        /// and returns False if it cannot be converted to a number without an error.
        /// </summary>
        /// <param name="o">The object to be evaluated</param>
        /// <returns>Returns True if object <i>o</i> can be converted to a number, False if it cannot be 
        /// converted to a number.</returns>
        public static bool IsNumeric(object o)
        {
            try
            {
                double d = System.Convert.ToDouble(o);
                return (true);
            }
            catch
            {
                return (false);
            }
        }

        public static bool IsGuid(string GuidId)
        {
            if (string.IsNullOrEmpty(GuidId))
                return false;
            string parttern = "########-####-####-####-############";
            string guid = GuidId.ToLower();

            Regex reg = new Regex(parttern.Replace("#", "[a-z0-9]"));
            return reg.IsMatch(guid);
        }

        public static DateTime CreateDate(int hours, int minutes, int seconds)
        {
            return new DateTime(1900, 1, 1, hours, minutes, seconds);
        }

        public static string GetFileTemplate(string Lang)
        {
            string body = "";
            string filename = HttpContext.Current.Server.MapPath("~") + "/EmailTemplates/EmailTemplate_{0}.htm";
            filename = string.Format(filename, Lang);

            StreamReader reader = new StreamReader(filename);
            body = reader.ReadToEnd();
            reader.Close();
            return body;
        }

        public static string GetFileTemplate2()
        {
            string body = "";
            string filename = HttpContext.Current.Server.MapPath("~") + "/pdf.htm";

            StreamReader reader = new StreamReader(filename);
            body = reader.ReadToEnd();
            reader.Close();
            return body;
        }

        public static DataTable QueryTable(DataTable table, string sort, params string[] query)
        {
            DataView view = new DataView(table);
            for (int i = 0; i < query.Length ; i++)
            {
                view = new DataView(view.ToTable(), query[i], sort, DataViewRowState.CurrentRows);
            }
            return view.ToTable();
        }
        

        public static string ToHexa(byte[] data)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sb.AppendFormat("{0:X2}", data[i]);
            return sb.ToString();
        }

        public static string DoMD5(string SData)
        {
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //System.Text.UTF8Encoding encode = new System.Text.UTF8Encoding();
            //System.Text.ASCIIEncoding encode = new System.Text.ASCIIEncoding();
            System.Text.Encoding encode = System.Text.Encoding.GetEncoding("ISO-8859-1");
            byte[] result1 = md5.ComputeHash(encode.GetBytes(SData));
            string sResult2 = ToHexa(result1);
            return sResult2;
        }
    }
}