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
using System.Collections;

using Library.Tools;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
/// <summary>
/// Summary description for NganLuong
/// </summary>
public class NganLuong
{
    public NganLuong()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static NganLuong CreateInstant()
    {
        return new NganLuong();
    }

    public const string PayShop = "SHOP";
    public const string PayDoc = "DOC";

    private String nganluong_url = "https://www.nganluong.vn/checkout.php";
    private String merchant_site_code = ConfigurationManager.AppSettings["merchant_site_code"];	//thay mã merchant site mà ban dã dang ký vào dây
    private String secure_pass = ConfigurationManager.AppSettings["secure_pass"];	//thay mat khau giao tiep giua website cua ban voi NgânLuong.vn mà ban dã dang ký vào dây
    string _receiver = ConfigurationManager.AppSettings["receiver"];
    string _return_url = UrlBuilder.RootUrl + "/payment/checkin.aspx";

    public String GetMD5Hash(String input)
    {

        System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();

        byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);

        bs = x.ComputeHash(bs);

        System.Text.StringBuilder s = new System.Text.StringBuilder();

        foreach (byte b in bs)
        {

            s.Append(b.ToString("x2").ToLower());

        }

        String md5String = s.ToString();

        return md5String;
    }

    public string buildCheckoutUrl(string ordercode, string price, string paytype)
    {
        return buildCheckoutUrl(_return_url, _receiver, paytype, ordercode, price);
    }

    public String buildCheckoutUrl(String return_url, String receiver, String transaction_info, String order_code, String price)
    {
        // Tao bien secure code
        String secure_code = "";

        TransactionEntity trans = new TransactionEntity();
        trans.Id = Guid.NewGuid();
        trans.ProductType = transaction_info;

        secure_code += this.merchant_site_code;

        secure_code += " " + HttpUtility.UrlEncode(return_url).ToLower();

        secure_code += " " + receiver;

        secure_code += " " + trans.Id.ToString();

        secure_code += " " + order_code;

        secure_code += " " + price;

        secure_code += " " + this.secure_pass;

        // Tao mang bam
        Hashtable ht = new Hashtable();

        ht.Add("merchant_site_code", this.merchant_site_code);

        ht.Add("return_url", HttpUtility.UrlEncode(return_url).ToLower());

        ht.Add("receiver", receiver);

        ht.Add("transaction_info", trans.Id.ToString());

        ht.Add("order_code", order_code);

        ht.Add("price", price);

        ht.Add("secure_code", this.GetMD5Hash(secure_code));

        // Tao url redirect
        String redirect_url = this.nganluong_url;

        if (redirect_url.IndexOf("?") == -1)
        {
            redirect_url += "?";
        }
        else if (redirect_url.Substring(redirect_url.Length - 1, 1) != "?" && redirect_url.IndexOf("&") == -1)
        {
            redirect_url += "&";
        }

        String url = "";

        // Duyet các phan tu trong mang bam ht1 de tao redirect url
        IDictionaryEnumerator en = ht.GetEnumerator();

        while (en.MoveNext())
        {
            if (url == "")
                url += en.Key.ToString() + "=" + en.Value.ToString();
            else
                url += "&" + en.Key.ToString() + "=" + en.Value.ToString();
        }

        String rdu = redirect_url + url;

        trans.ClientIp = WebUtility.GetUserIP();
        trans.MachineId = merchant_site_code;
        trans.OrderCode = order_code;
        trans.Price = FNumber.ConvertDecimal(price);
        trans.TransType = "NL";
        trans.UrlCheckOut = return_url;
        trans.UrlReturn = redirect_url + url;
        trans.CreatedBy = Util.CurrentUserName;
        trans.CreatedDate = DateTime.Now;
        TransactionManager.CreateInstant().Insert(trans);

        return rdu;
    }

    public Boolean verifyPaymentUrl(Page p, out TransactionEntity trans)
    {
        return verifyPaymentUrl(p.Request.QueryString["transaction_info"], p.Request.QueryString["order_code"], p.Request.QueryString["price"], p.Request.QueryString["payment_id"], p.Request.QueryString["payment_type"], p.Request.QueryString["error_text"], p.Request.QueryString["secure_code"], p.Request.RawUrl, out trans);
    }

    public Boolean verifyPaymentUrl(String transaction_info, String order_code, String price, String payment_id, String payment_type, String error_text, String secure_code, string urlReturn, out TransactionEntity trans)
    {
        String str = "";
        trans = new TransactionEntity();
        str += " " + transaction_info;

        str += " " + order_code;

        str += " " + price;

        str += " " + payment_id;

        str += " " + payment_type;

        str += " " + error_text;

        str += " " + this.merchant_site_code;

        str += " " + this.secure_pass;

        // Mã hóa các tham so
        String verify_secure_code = "";

        verify_secure_code = this.GetMD5Hash(str);
        trans = null;
        // Xác thuc mã cua cho web voi mã tro vo to nganluong.vn
        if (verify_secure_code == secure_code)
        {
            trans = TransactionManager.CreateInstant().SelectOne(FGuid.ToGuid(transaction_info));
            if (trans.OrderCode == order_code && trans.Price == FNumber.ConvertDecimal(price))
            {
                trans.UrlReturn2 = urlReturn;
                trans.Status = true;
                TransactionManager.CreateInstant().Update(trans);
                return true;
            }
        }
        trans.Status = false;
        return false;
    }
}
