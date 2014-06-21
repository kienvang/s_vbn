using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Web;
using aspNetEmail;
using System.IO;

using Library.Tools;

namespace Library.Tools
{
    /// <summary>
    /// Summary description for Util.
    /// </summary>
    public class SendMail
    {
        static string ProductionConfig_info = ConfigurationManager.AppSettings["SMTP_CONFIG_FILE_INFO"];
        public static string ConfigFile_info = System.Web.HttpContext.Current.Server.MapPath(ProductionConfig_info);
        public static SendMail CreateInstant()
        {
            return new SendMail();
        }

        public SendMail()
        {
        }

        public SendMail(string from, string to, string subject, string body)
        {
            From = from;
            To = to;
            Subject = subject;
            Body = body;
        }

        public SendMail(string from, string to, string cc, string bcc, string subject, string body)
        {
            From = from;
            To = to;
            Cc = cc;
            Bcc = bcc;
            Subject = subject;
            Body = body;
        }

        public SendMail(string from, string to, string cc, string bcc, string subject, string body, string configFile)
        {
            From = from;
            To = to;
            Cc = cc;
            Bcc = bcc;
            Subject = subject;
            Body = body;
            ConfigFile = configFile;
        }

        public string From, To, Cc, Bcc, Subject, Body = string.Empty;
        public string LocalConfig = ConfigurationManager.AppSettings["SMTP_CONFIG_FILE_INFO"];
        public string ProductionConfig = ConfigurationManager.AppSettings["SMTP_CONFIG_FILE_INFO"];
        //public string LocalConfig = ConfigurationManager.AppSettings["SMTP_CONFIG_FILE_LOCALHOST"];
        //public string ProductionConfig = ConfigurationManager.AppSettings["SMTP_CONFIG_FILE_PRODUCTION"];
        public string ConfigFile = string.Empty;

        public void Send()
        {
            if (string.IsNullOrEmpty(ConfigFile))
            {
                ConfigFile = System.Web.HttpContext.Current.Server.MapPath(ProductionConfig);
            }
            Send(From, To, Cc, Bcc, Subject, Body, ConfigFile);
        }

        public void Send(string from, string to, string cc, string bcc, string subject, string body)
        {
            if (string.IsNullOrEmpty(ConfigFile))
            {
                ConfigFile = System.Web.HttpContext.Current.Server.MapPath(ProductionConfig);
            }
            Send(from, to, cc, bcc, subject, body, ConfigFile);
        }

        public void Send(string from, string to, string cc, string bcc, string subject, string body, Stream stream, string filename)
        {
            if (string.IsNullOrEmpty(ConfigFile))
            {
                ConfigFile = System.Web.HttpContext.Current.Server.MapPath(ProductionConfig);
            }
            Send(from, to, cc, bcc, subject, body, stream, filename, ConfigFile);
        }

        public void Send(string from, string to, string cc, string bcc, string subject, string body, string SmtpPhysicalConfigFilePath)
        {
            //string smtpConfigFile = System.Web.HttpContext.Current.Server.MapPath(filePath);
            string smtpConfigFile = SmtpPhysicalConfigFilePath;

            /***** Read SMTP config file *****/
            Library.Tools.IO io = new Library.Tools.IO();
            System.Data.DataTable dtConfig = io.RegexToDataTable(smtpConfigFile);


            /***** Load SMTP config *****/
            int configIndex = (new Random()).Next(dtConfig.Rows.Count); // get random row index between 0 and (count - 1)
            string SmtpServer = dtConfig.Rows[configIndex]["SMTP.Server"].ToString().Trim();
            string SmtpUserName = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim() : String.Empty;
            string SmtpPassword = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim() : String.Empty;
            int SmtpPort = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Port"].ToString().Trim())) ? Convert.ToInt16(dtConfig.Rows[configIndex]["SMTP.Port"].ToString()) : 0;
            bool SmtpUseSsl = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString().Trim())) ? Convert.ToBoolean(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString()) : false;

            bool sentSuccess = Send(from, to, cc, bcc, subject, body, SmtpServer, SmtpUserName, SmtpPassword, SmtpPort, SmtpUseSsl);
            int sentCount = 1;
            while (sentCount < 3 && !sentSuccess) // try to send 10 times before terminate
            {
                /***** Load SMTP config *****/
                configIndex = (new Random()).Next(dtConfig.Rows.Count); // get random row index between 0 and (count - 1)
                SmtpServer = dtConfig.Rows[configIndex]["SMTP.Server"].ToString().Trim();
                SmtpUserName = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim() : String.Empty;
                SmtpPassword = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim() : String.Empty;
                SmtpPort = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Port"].ToString().Trim())) ? Convert.ToInt16(dtConfig.Rows[configIndex]["SMTP.Port"].ToString()) : 0;
                SmtpUseSsl = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString().Trim())) ? Convert.ToBoolean(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString()) : false;

                sentSuccess = Send(from, to, cc, bcc, subject, body, SmtpServer, SmtpUserName, SmtpPassword, SmtpPort, SmtpUseSsl);
                sentCount++;
            }
        }


        public void Send(string from, string to, string cc, string bcc, string subject, string body, Stream stream, string filename, string SmtpPhysicalConfigFilePath)
        {
            //string smtpConfigFile = System.Web.HttpContext.Current.Server.MapPath(filePath);
            string smtpConfigFile = SmtpPhysicalConfigFilePath;

            /***** Read SMTP config file *****/
            Library.Tools.IO io = new Library.Tools.IO();
            System.Data.DataTable dtConfig = io.RegexToDataTable(smtpConfigFile);


            /***** Load SMTP config *****/
            int configIndex = (new Random()).Next(dtConfig.Rows.Count); // get random row index between 0 and (count - 1)
            string SmtpServer = dtConfig.Rows[configIndex]["SMTP.Server"].ToString().Trim();
            string SmtpUserName = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim() : String.Empty;
            string SmtpPassword = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim() : String.Empty;
            int SmtpPort = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Port"].ToString().Trim())) ? Convert.ToInt16(dtConfig.Rows[configIndex]["SMTP.Port"].ToString()) : 0;
            bool SmtpUseSsl = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString().Trim())) ? Convert.ToBoolean(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString()) : false;

            bool sentSuccess = Send(from, to, cc, bcc, subject, body, stream, filename, SmtpServer, SmtpUserName, SmtpPassword, SmtpPort, SmtpUseSsl);
            int sentCount = 1;
            while (sentCount < 3 && !sentSuccess) // try to send 10 times before terminate
            {
                /***** Load SMTP config *****/
                configIndex = (new Random()).Next(dtConfig.Rows.Count); // get random row index between 0 and (count - 1)
                SmtpServer = dtConfig.Rows[configIndex]["SMTP.Server"].ToString().Trim();
                SmtpUserName = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim() : String.Empty;
                SmtpPassword = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim() : String.Empty;
                SmtpPort = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Port"].ToString().Trim())) ? Convert.ToInt16(dtConfig.Rows[configIndex]["SMTP.Port"].ToString()) : 0;
                SmtpUseSsl = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString().Trim())) ? Convert.ToBoolean(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString()) : false;

                sentSuccess = Send(from, to, cc, bcc, subject, body, stream, filename, SmtpServer, SmtpUserName, SmtpPassword, SmtpPort, SmtpUseSsl);
                sentCount++;
            }
        }

        private bool Send(string from, string to, string cc, string bcc, string subject, string body
            , string SmtpServer, string SmtpUserName, string SmtpPassword, int SmtpPort, bool SmtpUseSsl)
        {
            EmailMessage _EmailMessage = new EmailMessage();
            _EmailMessage.Server = SmtpServer;
            if (!String.IsNullOrEmpty(SmtpUserName)) _EmailMessage.Username = SmtpUserName;
            if (!String.IsNullOrEmpty(SmtpPassword)) _EmailMessage.Password = SmtpPassword;
            if (SmtpPort != 0) _EmailMessage.Port = SmtpPort;
            if (SmtpUseSsl) _EmailMessage.LoadSslSocket(new AdvancedIntellect.Ssl.SslSocket()); // create the ssl socket

            //Trace.Warn("_EmailMessage.Server", _EmailMessage.Server);
            //Trace.Warn("_EmailMessage.Username", _EmailMessage.Username);
            //Trace.Warn("_EmailMessage.Password", _EmailMessage.Password);
            //Trace.Warn("_EmailMessage.Port", _EmailMessage.Port.ToString());

            _EmailMessage.FromAddress = from;
            _EmailMessage.To = to;
            if (!String.IsNullOrEmpty(cc)) _EmailMessage.Cc = cc;
            if (!String.IsNullOrEmpty(bcc)) _EmailMessage.Bcc = bcc;
            _EmailMessage.Subject = subject;
            _EmailMessage.Body = body;
            _EmailMessage.CharSet = "utf-8";
            _EmailMessage.BodyFormat = MailFormat.Html;

            return _EmailMessage.Send();
        }

        public void Send2()
        {
            Send2("VbnShopCake", "kienvang.it.2412@gmail.com", From, To, Cc, Bcc, Subject, Body, ConfigFile_info);
        }

        public void Send2(string FromName, string FromAddress, string from, string to, string cc, string bcc, string subject, string body, string SmtpPhysicalConfigFilePath)
        {
            //string smtpConfigFile = System.Web.HttpContext.Current.Server.MapPath(filePath);
            string smtpConfigFile = SmtpPhysicalConfigFilePath;

            /***** Read SMTP config file *****/
            Library.Tools.IO io = new Library.Tools.IO();
            System.Data.DataTable dtConfig = io.RegexToDataTable(smtpConfigFile);


            /***** Load SMTP config *****/
            int configIndex = (new Random()).Next(dtConfig.Rows.Count); // get random row index between 0 and (count - 1)
            string SmtpServer = dtConfig.Rows[configIndex]["SMTP.Server"].ToString().Trim();
            string SmtpUserName = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim() : String.Empty;
            string SmtpPassword = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim() : String.Empty;
            int SmtpPort = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Port"].ToString().Trim())) ? Convert.ToInt16(dtConfig.Rows[configIndex]["SMTP.Port"].ToString()) : 0;
            bool SmtpUseSsl = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString().Trim())) ? Convert.ToBoolean(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString()) : false;

            bool sentSuccess = Send2(FromName, FromAddress, from, to, cc, bcc, subject, body, SmtpServer, SmtpUserName, SmtpPassword, SmtpPort, SmtpUseSsl);
            int sentCount = 1;
            while (sentCount < 3 && !sentSuccess) // try to send 10 times before terminate
            {
                /***** Load SMTP config *****/
                configIndex = (new Random()).Next(dtConfig.Rows.Count); // get random row index between 0 and (count - 1)
                SmtpServer = dtConfig.Rows[configIndex]["SMTP.Server"].ToString().Trim();
                SmtpUserName = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Username"].ToString().Trim() : String.Empty;
                SmtpPassword = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim())) ? dtConfig.Rows[configIndex]["SMTP.Password"].ToString().Trim() : String.Empty;
                SmtpPort = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.Port"].ToString().Trim())) ? Convert.ToInt16(dtConfig.Rows[configIndex]["SMTP.Port"].ToString()) : 0;
                SmtpUseSsl = (!String.IsNullOrEmpty(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString().Trim())) ? Convert.ToBoolean(dtConfig.Rows[configIndex]["SMTP.UseSSL"].ToString()) : false;

                sentSuccess = Send2(FromName, FromAddress, from, to, cc, bcc, subject, body, SmtpServer, SmtpUserName, SmtpPassword, SmtpPort, SmtpUseSsl);
                sentCount++;
            }
        }
        /// <summary>
        /// phai truyen property cho FromName va FromAddress
        /// Default: FromName=Chudu24,FromAddress=info@chudu24.com
        /// </summary>
        /// <param name="FromName"></param>
        /// <param name="FromAddress"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="cc"></param>
        /// <param name="bcc"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <param name="SmtpServer"></param>
        /// <param name="SmtpUserName"></param>
        /// <param name="SmtpPassword"></param>
        /// <param name="SmtpPort"></param>
        /// <param name="SmtpUseSsl"></param>
        /// <returns></returns>
        private bool Send2(string FromName, string FromAddress, string from, string to, string cc, string bcc, string subject, string body
           , string SmtpServer, string SmtpUserName, string SmtpPassword, int SmtpPort, bool SmtpUseSsl)
        {
            EmailMessage _EmailMessage = new EmailMessage();
            _EmailMessage.Server = SmtpServer;
            if (!String.IsNullOrEmpty(SmtpUserName)) _EmailMessage.Username = SmtpUserName;
            if (!String.IsNullOrEmpty(SmtpPassword)) _EmailMessage.Password = SmtpPassword;
            if (SmtpPort != 0) _EmailMessage.Port = SmtpPort;
            if (SmtpUseSsl) _EmailMessage.LoadSslSocket(new AdvancedIntellect.Ssl.SslSocket()); // create the ssl socket

            //Trace.Warn("_EmailMessage.Server", _EmailMessage.Server);
            //Trace.Warn("_EmailMessage.Username", _EmailMessage.Username);
            //Trace.Warn("_EmailMessage.Password", _EmailMessage.Password);
            //Trace.Warn("_EmailMessage.Port", _EmailMessage.Port.ToString());

            _EmailMessage.FromAddress = FromAddress;
            _EmailMessage.FromName = FromName;
            _EmailMessage.To = to;
            if (!String.IsNullOrEmpty(cc)) _EmailMessage.Cc = cc;
            if (!String.IsNullOrEmpty(bcc)) _EmailMessage.Bcc = bcc;
            _EmailMessage.Subject = subject;
            _EmailMessage.Body = body;
            _EmailMessage.CharSet = "utf-8";
            _EmailMessage.BodyFormat = MailFormat.Html;

            return _EmailMessage.Send();
        }
        private bool Send(string from, string to, string cc, string bcc, string subject, string body, Stream stream, string filename
            , string SmtpServer, string SmtpUserName, string SmtpPassword, int SmtpPort, bool SmtpUseSsl)
        {
            EmailMessage _EmailMessage = new EmailMessage();
            _EmailMessage.Server = SmtpServer;
            if (!String.IsNullOrEmpty(SmtpUserName)) _EmailMessage.Username = SmtpUserName;
            if (!String.IsNullOrEmpty(SmtpPassword)) _EmailMessage.Password = SmtpPassword;
            if (SmtpPort != 0) _EmailMessage.Port = SmtpPort;
            if (SmtpUseSsl) _EmailMessage.LoadSslSocket(new AdvancedIntellect.Ssl.SslSocket()); // create the ssl socket

            //Trace.Warn("_EmailMessage.Server", _EmailMessage.Server);
            //Trace.Warn("_EmailMessage.Username", _EmailMessage.Username);
            //Trace.Warn("_EmailMessage.Password", _EmailMessage.Password);
            //Trace.Warn("_EmailMessage.Port", _EmailMessage.Port.ToString());

            _EmailMessage.FromAddress = from;
            _EmailMessage.To = to;
            if (!String.IsNullOrEmpty(cc)) _EmailMessage.Cc = cc;
            if (!String.IsNullOrEmpty(bcc)) _EmailMessage.Bcc = bcc;
            _EmailMessage.Subject = subject;
            _EmailMessage.Body = body;
            _EmailMessage.CharSet = "utf-8";
            _EmailMessage.BodyFormat = MailFormat.Html;

            Attachment _attach = new Attachment(stream, filename);
            _EmailMessage.AddAttachment(_attach);

            return _EmailMessage.Send();
        }
    }
}