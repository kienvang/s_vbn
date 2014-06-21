using System;
using System.Collections;
using System.Collections.Specialized;
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

using System.IO;
using System.Net.Mail;

using Modules;
using System.Text.RegularExpressions;

public partial class test_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string param = "id={0}&t={1}";
        string s1 = "bạn & chún tôi";
        string s2 = @" ngahom ' "" dsdas";

        string st = "";

        //param = string.Format(param, Server.UrlEncode(s1), Server.UrlEncode(s2));

        //Response.Write(param + "<br><br><br>");

        //param = Server.UrlEncode(param);

        //Response.Write(param + "<br><br><br>");

        //param = Server.UrlDecode(param);

        //Response.Write(param + "<br><br><br>");

        //param = Server.UrlDecode(param);

        //Response.Write(param + "<br><br><br>asas");

        SingleOrderDetail1.OrderId = new Guid("EDD0C046-5BBA-4DDE-A043-A68EF045AEC7");
        string html = SingleOrderDetail1.GetBody();

        //HistoryEmail.SendMailHistory("kienvang.it.2412@gmail.com", "phuongmathy@gmail.com", "a432dfda", html);

        //MP.Tools.SendMail.CreateInstant().Send("tung.pnq@gmail.com", "helo", "demomail");

        //SendMail("tung.pnq@gmail.com", "test 1", "test");

        SGmail smail = new SGmail();
        //smail.SendMail("tung.pnq@gmail.com", "chào bạn sd sads", "lâu qua minh ko gap nha", false);

        //Response.Write(html);
    }

    public bool SendMail(string stTo, string stTitle, string stBody)
    {
        try
        {
            string To = stTo;
            string From = "kienvang.it.2412@gmail.com";
            string Subject = stTitle;
            string Body = stBody;

            //SmtpMail.SmtpServer = "http://mail.google.com/a/it-apple.com";
            //SmtpMail.Send(From, To, Subject, Body);

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(From);
            mail.To.Add(new MailAddress(To));

            mail.Subject = Subject;

            mail.Body = Body;
            mail.BodyEncoding = System.Text.Encoding.UTF8;

            AlternateView plainView = AlternateView.CreateAlternateViewFromString(Regex.Replace(Body, @"<(.|\n)*?>", string.Empty), null, "text/plain");
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(Body, null, "text/html");

            mail.AlternateViews.Add(plainView);
            mail.AlternateViews.Add(htmlView);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";

            smtp.EnableSsl = true;

            smtp.Send(mail);

            //// Smtp configuration
            //SmtpMail.SmtpServer = "smtp.gmail.com";
            //// - smtp.gmail.com use smtp authentication
            //mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
            //mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "kienvang.it.2412@gmail.com");
            //mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "bluestar");
            //// - smtp.gmail.com use port 465 or 587
            //mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", "465");
            //// - smtp.gmail.com use STARTTLS (some clients call this SSL)
            //mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");

            //SmtpMail.Send(mail);
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
