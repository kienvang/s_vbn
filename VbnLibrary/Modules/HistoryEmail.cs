using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Library.Tools;

/// <summary>
/// Summary description for HistoryEmail
/// </summary>
namespace Modules
{
    public class HistoryEmail
    {
        public HistoryEmail()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public static bool SendMailHistory(string OrderCode, string from, string to, string cc, string bcc, string subject, string body, string username)
        {
            try
            {
                //SendMail sendmail = new SendMail(from, to, cc, bcc, subject, body);
                //sendmail.Send2();

                SGmail smail = new SGmail();
                smail.SendMail(to, subject, body);

                //Insert History Email
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@OrderCode", OrderCode);
                param[1] = new SqlParameter("@EmailTo", to);
                param[2] = new SqlParameter("@EmailFrom", from);
                param[3] = new SqlParameter("@EmailCc", cc);
                param[4] = new SqlParameter("@EmailBcc", bcc);
                param[5] = new SqlParameter("@Subject", subject);
                param[6] = new SqlParameter("@Body", body);
                param[7] = new SqlParameter("@SendBy", username);
                SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.StoredProcedure, "HistoryEmail_Insert", param);


                return true;
            }
            catch { return false; }
        }

        public static bool SendMailHistory(string OrderCode, string from, string to, string cc, string bcc, string subject, string body)
        {
            return SendMailHistory(OrderCode, from, to, cc, bcc, subject, body, Util.CurrentUserName);
        }

        public static bool SendMailHistory(string from, string to, string subject, string body)
        {
            return SendMailHistory("", from, to, "", "", subject, body, "");
        }
    }
}