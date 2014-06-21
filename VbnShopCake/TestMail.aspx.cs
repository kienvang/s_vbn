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

using Library.Tools;

public partial class TestMail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btn_Click(object sender, EventArgs e)
    {
        string to = txtEmail.Text.Trim();
        string subject = txtSubject.Text.Trim();
        string body = txtBody.Text.Trim();

        SGmail mail = new SGmail();
        int b = mail.SendMail(to, subject, body);
        Response.Write(b);
        //Mailer.Send(to, subject, body);
    }
}
