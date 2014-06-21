using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Tools;

namespace Modules.Document
{
    public class UrlBuilder
    {
        public static string ListDocument()
        {
            string url = "";

            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu.html";
            }
            else
            {
                url = "/Modules/Document/ListDocument.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string ListDocumentByGroup(string GroupName,int GroupId)
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/" + GroupId.ToString() + "/" + GroupName + ".html";
            }
            else
            {
                url = "/Modules/Document/ListDocumentByGroup.aspx?id=" + GroupId + "&name=" + GroupName;
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string MarkAddHistory()
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Lich-su-nap-diem.html";
            }
            else
            {
                url = "/Modules/Document/MarkAddHistory.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string ListAllDocumentByGroup(int Id, string groupname)
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Tat-ca-tai-lieu/" + Id.ToString() + "/" + groupname + ".html";
            }
            else
            {
                url = "/Modules/Document/ListAllDocument.aspx?id=" + Id.ToString();
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string ListAllDocument()
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Tat-ca-tai-lieu.html";
            }
            else
            {
                url = "/Modules/Document/ListAllDocument.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string DownLoadHistory()
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Lich-su-download-tai-lieu.html";
            }
            else
            {
                url = "/Modules/Document/DownLoadHistory.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string DownLoadGuide()
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/nap-diem.html";
            }
            else
            {
                url = "/Modules/Document/DownLoadGuide.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }
        public static string DownLoadGuide1(int flag)
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Huong-dan/" + flag.ToString() + ".html";
            }
            else
            {
                url = "/Modules/Document/DownLoadGuide.aspx?flag=" + flag.ToString();
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }
        public static string DocumentDetail(int Id,string name)
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Chi-Tiet/" + Id.ToString() + "/" + name + ".html";
            }
            else
            {
                url = "/Modules/Document/DocumentDetail.aspx?id=" + Id.ToString();
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }

        public static string Download(int Id)
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/download/" + Id.ToString() + ".html";
            }
            else
            {
                url = "/Modules/Document/Download.aspx?id=" + Id.ToString();
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }
        public static string DownLoadGuideAdmin()
        {
            string url = "";
            if (Config.IsUrlRewrite())
            {
                url = "/Tai-lieu/Huong-dan-tai-tai-lieu.html";
            }
            else
            {
                url = "/Admin/Document/DownLoadGuide.aspx";
            }

            return Library.Tools.UrlBuilder.RootUrl + url;
        }
    }
}
