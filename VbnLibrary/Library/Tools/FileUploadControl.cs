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
using System.IO;

using Modules;

/// <summary>
/// Summary description for FileUploadControl
/// </summary>
namespace Library.Tools
{
    public class FileUploadControl
    {
        public static string GetFileName(string FileName, string Absolute, string TextId, int MaxLength)
        {
            string file = "";
            string path = "";

            string ext = "";
            string nor = "";

            int len = FileName.Length;
            int index = FileName.LastIndexOf(".");

            ext = FileName.Substring(index, len - index);
            nor = FileName.Substring(0, index);

            if (string.IsNullOrEmpty(TextId))
            {
                TextId = UnicodeConversion.CreateInstant().GetStringId(nor);
            }

            file = HttpContext.Current.Server.MapPath("~") + Absolute + "/" + TextId + ext;

            string subname = "-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss").Replace("-", "");
            path = Absolute + "/" + TextId + ext;
            if (File.Exists(file))
            {
                path = Absolute + "/" + TextId + subname;
                if (path.Length >= MaxLength + 4)
                    path = path.Substring(0, path.Length);
                path += ext;
            }

            return path;
        }

        public static string FullPath(FileUpload fileUpload, string FileName, int MaxLength, string AbsolutePath)
        {
            string textId = "";
            if (!string.IsNullOrEmpty(FileName))
                textId = UnicodeConversion.CreateInstant().GetStringId(FileName);
            return FullPath(fileUpload, AbsolutePath, textId, MaxLength);
        }

        public static string FullPath(FileUpload fileUpload, int MaxLength)
        {
            return FullPath(fileUpload, EnumsFile.Files, "", MaxLength);
        }

        public static string FullPath(FileUpload fileUpload, string AbsolutePath, string TextId, int MaxLength)
        {
            string FullPath = "";
            if (string.IsNullOrEmpty(AbsolutePath))
                AbsolutePath = EnumsFile.Files;

            if (fileUpload.HasFile)
            {
                FullPath = GetFileName(fileUpload.FileName, AbsolutePath, TextId, MaxLength);
                fileUpload.SaveAs(HttpContext.Current.Server.MapPath("~") + FullPath);
            }

            return FullPath;
        }

        public static bool IsValidPhoto(FileUpload file, EnumsCheckType type)
        {
            bool t1 = true;
            bool t2 = true;

            if (type == EnumsCheckType.ExtendName || type == EnumsCheckType.SizeAndExtendName)
            {
                string FileName = file.FileName;
                int len = FileName.Length;
                int index = FileName.LastIndexOf(".");

                string ext = FileName.Substring(index + 1).ToLower();
                if (ext != EnumsFileType.Bmp && ext != EnumsFileType.Gif &&
                    ext != EnumsFileType.Jpeg && ext != EnumsFileType.Jpg &&
                    ext != EnumsFileType.Png)
                    t1 = false;
            }

            //if (type == EnumsCheckType.Size || type == EnumsCheckType.SizeAndExtendName)
            //{
            //    int size = int.Parse(ConfigurationManager.AppSettings["filemax"]);
            //    if (file.FileBytes.Length > size)
            //        t2 = false;
            //}
            return t1 & t2;
        }
    }
}