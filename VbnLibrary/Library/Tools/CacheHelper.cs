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
using System.Web.Caching;
using System.IO;

namespace Library.Tools
{
	/// <summary>
	/// Summary description for CachingHelper
	/// </summary>

	public class CachingHelper
	{
		public CachingHelper()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static object GetCacheObject(string cacheKey)
		{
			System.Web.Caching.Cache cache = System.Web.HttpRuntime.Cache;
			object cacheObject = cache.Get(cacheKey);
			return cacheObject;
		}

		public static bool SetCacheObject(string cacheKey, object cacheItem)
		{
			try
			{
				string dependencyFile = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["CacheDependencyFolder"] + "/" + cacheKey + ".txt");
				if (!File.Exists(dependencyFile))
					File.Create(dependencyFile);
				System.Web.Caching.Cache cache = System.Web.HttpRuntime.Cache;
				CacheDependency cacheDependency = new CacheDependency(dependencyFile);
				cache.Insert(cacheKey, cacheItem, cacheDependency);
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public static bool ExpireParticularCache(string cacheKey)
		{
			try
			{
				string dependencyFile = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["CacheDependencyFolder"] + "/" + cacheKey + ".txt");
				Random r = new Random();
				File.WriteAllText(dependencyFile, r.Next().ToString());
			}

			catch (Exception e)
			{
				return false;
			}
			return true;
		}
	}
}