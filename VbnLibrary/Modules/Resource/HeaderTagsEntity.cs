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
/// Summary description for HeaderTagsEntity
/// </summary>
namespace Modules.Resource
{
    public class ResourcesEntity
    {
        public const string STitle = "Title";
        public const string SDescription = "Description";
        public const string SKeyWords = "KeyWords";

        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }

        public static ResourcesEntity CreateInstant()
        {
            return new ResourcesEntity();
        }

        public void SetPage(Page page, string Title, string Description, string KeyWords)
        {
            WebUtility.SetPageTitle(page.Master, Title);
            WebUtility.SetMetaDescription(page.Master, Description);
            WebUtility.SetMetaKeywords(page.Master, KeyWords);
        }
    }
}