using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text.RegularExpressions;

public partial class Modules_Videos_Controls_VideoBox : System.Web.UI.UserControl
{
    public string FileName = "";
    public string VideoName = "";
    public int AutoStart = 0;
    public string VideoType = "";
    public string ObjectType = "";
    public string CodeEmbeb;
    public int Width = 520;
    public int Height = 400;
    public string Thumbnail = "";

    public string File = "";
    public string Folder = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(FileName))
        {
            int index = FileName.LastIndexOf("/");
            Folder = FileName.Substring(0, index + 1);
            File = FileName.Substring(index + 1);

            if (ObjectType == "EMBED")
            {
                string w = "width[\\s]*=[\"'\\s]*([^\"'#\\s>]+)[\"']*";
                string w1 = "width=\"" + Width.ToString() + "\"";
                string h = "height[\\s]*=[\"'\\s]*([^\"'#\\s>]+)[\"']*";
                string h1 = "height=\"" + Height.ToString() + "\"";

                CodeEmbeb = Regex.Replace(CodeEmbeb, w, w1, RegexOptions.IgnoreCase);
                CodeEmbeb = Regex.Replace(CodeEmbeb, h, h1, RegexOptions.IgnoreCase);
            }
        }
    }
}
