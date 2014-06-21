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

using Winnovative.WnvHtmlConvert;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;

using Library.Tools;

public partial class test_TestPDF : System.Web.UI.Page
{
    Guid Id = new Guid("4328c8a8-bf01-492a-aaba-60ab2fba3fa3");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string detail = "";
        SingleOrderDetail1.OrderId = Id;
        detail = SingleOrderDetail1.GetBody();

        EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderCompleted(Id, detail);
        if (template != null)
        {
            template = EmailTemplatesManager.CreateInstant().GetFormatEmail(template);

            string HtmlContent = template.Body;

            Response.Write(HtmlContent);

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string detail = "";
        SingleOrderDetail1.OrderId = Id;
        detail = SingleOrderDetail1.GetBody();

        EmailTemplatesEntity template = EmailTemplatesManager.CreateInstant().GetOrderCompleted(Id, detail);
        if (template != null)
        {
            template = EmailTemplatesManager.CreateInstant().GetFormatEmail(template);

            string HtmlContent = template.Body;

            ExportPdf.CreateInstant().Export("abccc", template.Body);

            
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
            string HtmlContent = Util.GetFileTemplate2();

            ExportPdf.CreateInstant().Export("abccc", HtmlContent);


    }
}
