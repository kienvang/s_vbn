using System;
using System.Collections;
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Configuration;
using System.Xml;

namespace Library.Tools
{
	/// <summary>
	/// Collection of utility methods for web tier
	/// </summary>
	public static class UrlBuilder
	{
		public static string RootUrl
		{
			get
			{
				if (HttpContext.Current.Request.ServerVariables["SERVER_PORT"] == "80")
					return "http://" + HttpContext.Current.Request.ServerVariables["SERVER_NAME"];
				else
                    return "http://" + HttpContext.Current.Request.ServerVariables["SERVER_NAME"] + ":" + HttpContext.Current.Request.ServerVariables["SERVER_PORT"];
			}
		}
		public static string Build(string Url)
		{
			return RootUrl + Url;
		}

		public static void GoToLoginPage()
		{
			string url = RootUrl + "/DangNhap.aspx";
			HttpContext context = HttpContext.Current;
			if (context != null)
				url += "?ReturnUrl=" + context.Server.UrlEncode(context.Request.Url.ToString());
			context.Response.Redirect(url);
		}
        
	
	}
}