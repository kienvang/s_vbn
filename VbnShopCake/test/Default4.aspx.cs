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
using System.Security.Cryptography.X509Certificates;

public partial class test_Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        X509Certificate2 _RecipientCert = new X509Certificate2(Server.MapPath(@"App_Data\Certificates\biz_pkcs12.p12"), "biz");
    }
}
