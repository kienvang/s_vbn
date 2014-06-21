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

using System.Collections.Generic;
using System.Collections;
using System.Text;

/// <summary>
/// Summary description for WebUtility
/// </summary>
namespace Library.Tools
{
    public class WebUtility
    {
        public static string GetToolTipText(string ToolTip)
        {
            return Library.Tools.Util.TrimString(Library.Tools.UnicodeConversion.CreateInstant().GetTextFromHtml(ToolTip.Trim()), 105);
        }

        public static string GetUniqueTextIdFromUnicodeText(string UnicodeText, string ParameterName, string SQL, string ConnectionString, int maxLength)
        {
            Library.Tools.UnicodeConversion _UnicodeConversion = new Library.Tools.UnicodeConversion();
            string TextIdValue = _UnicodeConversion.GetStringId(_UnicodeConversion.UnicodeToASCII2(UnicodeText), maxLength);
            string toReturn = TextIdValue;

            int index = 2;
            while (IsTextIdExisted(toReturn, ParameterName, SQL, ConnectionString))
            {
                toReturn = TextIdValue + "-" + index.ToString();
                if (toReturn.Length > maxLength)
                {
                    toReturn = TextIdValue.Substring(0, maxLength - ("-" + index.ToString()).Length) + "-" + index.ToString();
                }
                index++;
            }

            return toReturn;
        }
        //public static string GetUniqueTextIdFromUnicodeText(string UnicodeText, string _ext, string FolderName, int maxLength)
        //{
        //  Library.Tools.UnicodeConversion _UnicodeConversion = new UnicodeConversion();
        //  string TextIdValue = _UnicodeConversion.GetStringId(_UnicodeConversion.UnicodeToASCII2(UnicodeText), maxLength);
        //  string toReturn = TextIdValue;
        //  int index = 2;
        //  while (Chudu24.Database.Community.BLL.FilesManager.CreateInstant().IsTextIdExisted(toReturn + _ext, FolderName))
        //  {
        //    toReturn = TextIdValue + "-" + index.ToString();
        //    if (toReturn.Length > maxLength)
        //    {
        //      toReturn = TextIdValue.Substring(0, maxLength - ("-" + index.ToString()).Length) + "-" + index.ToString();
        //    }
        //    index++;
        //  }
        //  return toReturn;
        //}

        // TextIdValue = "lap-trinh-dzui-qua"
        // SQL = "SELECT TextId FROM Articles WHERE TextId = @TextId";
        // ParameterName = "@TextId";
        // ConnectionString = AppConfig["Article.ConnectionString"];
        // maxLength = 300;
        public static string GetUniqueTextId(string TextIdValue, string ParameterName, string SQL, string ConnectionString, int maxLength)
        {
            string toReturn = TextIdValue;

            int index = 2;
            while (IsTextIdExisted(toReturn, ParameterName, SQL, ConnectionString))
            {
                toReturn = TextIdValue + "-" + index.ToString();
                if (toReturn.Length > maxLength)
                {
                    toReturn = TextIdValue.Substring(0, maxLength - ("-" + index.ToString()).Length) + "-" + index.ToString();
                }
                index++;
            }

            return toReturn;
        }

        // TextIdValue = "lap-trinh-dzui-qua"
        // SQL = "SELECT TextId FROM Articles WHERE TextId = @TextId";
        // ParameterName = "@TextId";
        // ConnectionString = AppConfig["Article.ConnectionString"];
        // maxLength = 300;
        public static bool IsTextIdExisted(string TextIdValue, string ParameterName, string SQL, string ConnectionString)
        {
            System.Data.DataTable dt = Library.Tools.SqlHelper.ExecuteDataTable(ConnectionString
                            , CommandType.Text
                            , SQL
                            , new System.Data.SqlClient.SqlParameter(ParameterName, TextIdValue));
            return (dt.Rows.Count > 0);
        }


        // TextIdValue = "lap-trinh-dzui-qua"
        // SQL = "SELECT TextId FROM Articles WHERE TextId = @TextId";
        // ParameterName = "@TextId";
        // ConnectionString = AppConfig["Article.ConnectionString"];
        // maxLength = 300;
        //public static string GetUniqueTextId(string TextIdValue, string ParameterName, string SQL, string ConnectionString, int maxLength)
        //{
        //    string toReturn = TextIdValue;
        //}

        public static string GetUserIP()
        {
            return (System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"]
                            + " " + System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"]).Trim();
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

        public static bool IsMetaTagExisted(System.Web.UI.MasterPage Master, string TagName)
        {
            bool existed = false;

            foreach (System.Web.UI.Control c in Master.Page.Header.Controls)
            {
                if (c.ID == TagName + "1")
                    existed = true;
            }
            return existed;
        }

        public static void SetPageTitle(System.Web.UI.MasterPage Master, string PageTitle)
        {
            SetPageTitle(Master, PageTitle, string.Empty);
        }

        public static void SetPageTitle(System.Web.UI.MasterPage Master, string PageTitle, string ModuleId)
        {
            if (string.IsNullOrEmpty(Master.Page.Header.Title) || Master.Page.Header.Title == "Untitled Page")
            {
                if (PageTitle.Length > 90)
                {
                    Master.Page.Header.Title = Library.Tools.UnicodeConversion.CreateInstant().UnicodeToASCII(PageTitle);
                }
                else
                {
                    string Non_Unicode_PageTitle = Library.Tools.UnicodeConversion.CreateInstant().UnicodeToASCII(PageTitle);
                    if (Non_Unicode_PageTitle != PageTitle)
                        Master.Page.Header.Title = PageTitle + " - " + Non_Unicode_PageTitle;
                    else
                        Master.Page.Header.Title = Non_Unicode_PageTitle;
                }
                //Master.Page.Header.Title = PageTitle + " - " + Library.Tools.UnicodeConversion.CreateInstant().UnicodeToASCII(PageTitle);
                //Master.Page.Header.Title = PageTitle;
            }
        }

        public static void SetMetaDescription(System.Web.UI.MasterPage Master, string Description, string ModuleId)
        {
            if (!IsMetaTagExisted(Master, "description"))
            {
                System.Web.UI.HtmlControls.HtmlMeta _HtmlMeta = new System.Web.UI.HtmlControls.HtmlMeta();
                _HtmlMeta.ID = "description1";
                _HtmlMeta.Name = "description";
                _HtmlMeta.Content = Library.Tools.UnicodeConversion.CreateInstant().GetTextFromHtml(Description);
                Master.Page.Header.Controls.Add(_HtmlMeta);
            }
        }

        public static void SetMetaDescription(System.Web.UI.MasterPage Master, string Description)
        {
            SetMetaDescription(Master, Description, string.Empty);
        }

        public static void SetMetaKeywords(System.Web.UI.MasterPage Master, string Keywords, string ModuleId)
        {
            if (!IsMetaTagExisted(Master, "keywords"))
            {
                System.Web.UI.HtmlControls.HtmlMeta _HtmlMeta = new System.Web.UI.HtmlControls.HtmlMeta();
                _HtmlMeta.ID = "keywords1";
                _HtmlMeta.Name = "keywords";
                _HtmlMeta.Content = Library.Tools.UnicodeConversion.CreateInstant().GetTextFromHtml(Keywords);
                Master.Page.Header.Controls.Add(_HtmlMeta);
            }
        }

        public static void SetMetaKeywords(System.Web.UI.MasterPage Master, string Keywords)
        {
            SetMetaKeywords(Master, Keywords, string.Empty);
        }

        public static void SetMetaDescriptionKeywords(System.Web.UI.MasterPage Master, string Description, string Keywords, string ModuleId)
        {
            SetMetaDescription(Master, Description, ModuleId);
            SetMetaKeywords(Master, Keywords, ModuleId);
        }

        public static void SetMetaDescriptionKeywords(System.Web.UI.MasterPage Master, string Description, string Keywords)
        {
            SetMetaDescription(Master, Description, string.Empty);
            SetMetaKeywords(Master, Keywords, string.Empty);
        }

        public static void SetPageTitleDescriptionKeywords(System.Web.UI.MasterPage Master, string PageTitle, string Description, string Keywords, string ModuleId)
        {
            SetPageTitle(Master, PageTitle, string.Empty);
            SetMetaDescription(Master, Description, ModuleId);
            SetMetaKeywords(Master, Keywords, ModuleId);
        }

        public static void SetPageTitleDescriptionKeywords(System.Web.UI.MasterPage Master, string PageTitle, string Description, string Keywords)
        {
            SetPageTitleDescriptionKeywords(Master, PageTitle, Description, Keywords, string.Empty);
        }
        public static void SetMetaRobots(System.Web.UI.MasterPage Master)
        {
            if (!IsMetaTagExisted(Master, "robots"))
            {
                System.Web.UI.HtmlControls.HtmlMeta _HtmlMeta = new System.Web.UI.HtmlControls.HtmlMeta();
                _HtmlMeta.ID = "robots1";
                _HtmlMeta.Name = "robots";
                _HtmlMeta.Content = "noindex";
                Master.Page.Header.Controls.Add(_HtmlMeta);
            }
        }

        public static void Refesh(Page page)
        {
            page.Response.Redirect(page.Request.RawUrl);
        }

        public static string AddQueryString(string RawURL, params string[] agrument)
        {
            string url = "";
            string param = "";
            for (int i = 0; i < agrument.Length; i++)
                param += agrument[i] + "&";
            if (!string.IsNullOrEmpty(param))
            {
                param = param.TrimEnd('&');
                if (RawURL.Contains("?"))
                    url = RawURL + "&" + param;
                else
                    url = RawURL + "?" + param;
            }
            return url;
        }

        public static string GetLockButtonJscript(Page p, LinkButton btn, string disabledText, ArrayList aCol, string customScript)
        {
            disabledText = string.IsNullOrEmpty(disabledText) ? btn.Text : disabledText; disabledText = disabledText.Replace("'", "");

            StringBuilder sb = new StringBuilder();
            if (btn.CausesValidation && p.Validators.Count > 0 && btn != null)
            {
                sb.Append("if (typeof(Page_ClientValidate) == 'function') { ");
                sb.Append("if (Page_ClientValidate('" + btn.ValidationGroup + "') == false) { return false; }} ");
            }

            if (!String.IsNullOrEmpty(customScript))
            {
                sb.Append(customScript);
            }

            PostBackOptions opt = new PostBackOptions(btn, "", "", false, true, true, true, true, btn.ValidationGroup);

            sb.Append(p.ClientScript.GetPostBackEventReference(opt));
            sb.Append(";");

            if (String.IsNullOrEmpty(customScript))
            {
                sb.Append("this.style.display='none';this.value='" + disabledText + "';");
            }

            if (aCol != null)
            {
                foreach (Control c in aCol)
                {
                    if (c is LinkButton)
                    {
                        sb.Append("document.getElementById('" + c.ClientID + "').style.display='none';");
                        sb.Append("document.getElementById('" + c.ClientID + "').value='dadasdsadas';");
                    }

                }
            }

            return sb.ToString();
        }

        public static string GetLockButtonJscript(Page p, LinkButton btn, string disabledText, string customScript)
        {
            return GetLockButtonJscript(p, btn, disabledText, null, customScript);
        }

        public static void DownLoadFile(Page p, string filename, byte[] buffer)
        {
            //p.Response.Clear();
            p.Response.ContentType = "application/octet-stream";
            p.Response.AddHeader("Content-Length", buffer.Length.ToString());
            p.Response.AddHeader("Content-Disposition", "attachment; filename=" + filename);
            p.Response.BinaryWrite(buffer);
            p.Response.End();
        }
        /// <summary>
        /// Download file ve client
        /// </summary>
        /// <param name="p"></param>
        /// <param name="clientName">Ten file mac dinh nguoi dung thay khi download ve</param>
        /// <param name="serverFilePath">Duong dan file tren server</param>
        public static void DownLoadFile(Page p, string clientName, string serverFilePath)
        {
            byte[] buffer = FileUtil.ReadByteArrayFromFile(serverFilePath);
            DownLoadFile(p, clientName, buffer);
        }
    }
}