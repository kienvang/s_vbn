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

/// <summary>
/// Summary description for EnumsFile
/// </summary>
namespace Modules
{
    public class EnumsFile
    {
        public const string Files = "/userfiles";
        public const string Images = "/userfiles/images";
        public const string Catalogs = "/userfiles/images/Catalogs";
        public const string Thumbnails = "/userfiles/images/Thumbnails";
        public const string Advert = "/userfiles/adverts";
        public const string Videos = "/userfiles/videos";
        public const string Banner = "/userfiles/banner";
        public const string Player = "/player";
        public const string Document = "/userfiles/Document";
        public const string DocumentImage = "/userfiles/DocumentImage";
        public const string Code = "/userfiles/Code";
    }

    public class EnumsMediaType
    {
        public const string Flash = "FLASH";
        public const string Image = "IMAGE";
    }

    public class EnumsFileType
    {
        public const string Jpeg = "jpeg";
        public const string Jpg = "jpg";
        public const string Bmp = "bmp";
        public const string Png = "png";
        public const string Gif = "gif";
    }
   
    public enum EnumsCheckType
    {
        Size = 1,
        ExtendName = 2,
        SizeAndExtendName = 3,
    }
}