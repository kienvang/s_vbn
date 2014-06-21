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
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;

public partial class Admin_Document_MarkTransfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadData();
        }
    }

    void loadData()
    {
        DataTable tbl = MarkTransferManager.CreateInstant().SelectAllRDT();
        tbl.DefaultView.Sort = "Mark";
        rep.DataSource = tbl.DefaultView;
        rep.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            MarkTransferEntity mk = new MarkTransferEntity();
            mk.Code = txtCode.Text.Trim();
            mk.Mark = FNumber.ConvertInt(txtMark.Text.Trim());
            mk.Cost = FNumber.ConvertDecimal(txtCost.Text.Trim());
            MarkTransferManager.CreateInstant().Insert(mk);

            Response.Redirect(Request.RawUrl);
        }
    }

    protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "del":
                MarkTransferManager.CreateInstant().Delete(new Guid(e.CommandArgument.ToString()));
                Response.Redirect(Request.RawUrl);
                break;
        }
    }

    protected void invalid_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        if (MarkTransferManager.CreateInstant().GetByCode(txtCode.Text.Trim()) != null)
        {
            args.IsValid = false;
            invalid.ErrorMessage = "Trùng mã";
        }
    }
}
