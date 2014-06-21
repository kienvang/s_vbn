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
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using Library.Tools;

public partial class Modules_Products_Controls_PaymentMethod : System.Web.UI.UserControl
{
    public string PaymentMethod
    {
        get
        {
            string pay = "CAH";
            if (rdoNL.Checked)
                pay = "NL";
            if (rdoBanking.Checked)
                pay = "BAK";
            if (rdoCardInternal.Checked)
                pay = "CAR";
            if (rdoVisa.Checked)
                pay = "VIS";
            return pay;
        }
    }

    public string ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadPayment();
            if (string.IsNullOrEmpty(Util.CurrentUserName))
            {
                //divNL.Visible = false;
            }

            if (ProductId == "DOC")
            {
                divCah.Visible = false;
                rdoCah.Checked = false;
                divBanking.Visible = false;
                divCardInternal.Visible = false;
                divVisa.Visible = false;
                rdoNL.Checked = true;
            }
        }
    }

    void loadPayment()
    {
        EntityCollection<PaymentMethodEntity> items = PaymentMethodManager.CreateInstant().SelectByIsVisibleLST(true);
        for (int i = 0; i < items.Count; i++)
        {
            switch (items[i].PayId)
            {
                case "CAH":
                    lkCah.NavigateUrl = items[i].Link;
                    break;
                case "CAR":
                    lkCardInternal.NavigateUrl = items[i].Link;
                    break;
                case "BAK":
                    lkBanking.NavigateUrl = items[i].Link;
                    break;
                case "VIS":
                    lkBanking.NavigateUrl = items[i].Link;
                    break;
                case "NL":
                    lkNL.NavigateUrl = items[i].Link;
                    break;
            }
        }
    }
}
