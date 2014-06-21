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

using System.Net;

using System.Net.Mail;
using System.Text;

/// <summary>
/// Summary description for Mailer
/// </summary>
public class Mailer
{
    public Mailer()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void Send(string to, string title, string body)
    {
        MailMessage mail = new MailMessage();

        MailAddress address = new MailAddress(to);

        MailAddress FromAddress = new MailAddress("webmaster@vbn.vn", "vbn");



        mail.From = FromAddress;

        mail.To.Add(address);

        mail.Body = body;

        mail.Subject = title;

        mail.BodyEncoding = Encoding.UTF8;

        SmtpClient SendMail = new SmtpClient();

        NetworkCredential Authentication = new NetworkCredential();

        Authentication.UserName = "webmaster@vbn.vn";

        Authentication.Password = "bakery*#";

        SendMail.Credentials = Authentication;

        SendMail.Host = "mail.vbn.vn";

        SendMail.Port = 25;

        SendMail.Send(mail);
    }
}
