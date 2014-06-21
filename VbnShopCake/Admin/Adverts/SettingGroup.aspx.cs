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

using Library.Tools;

public partial class Admin_Adverts_SettingGroup : System.Web.UI.Page
{
    public Guid Id
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    void LoadData()
    {
        AdvertsPositionEntity group = AdvertsPositionManager.CreateInstant().SelectOne(Id);
        if (group != null)
        {
            lblGroupName.Text = group.GroupName;
            txtHeight.Text = group.Height.ToString();
            txtWidth.Text = group.Width.ToString();
        }

        DataTable table = AdvertsManager.CreateInstant().GetAdvertSettingGroup(Id);
        table.DefaultView.Sort = "AdvertName";
        repAdvert.DataSource = table.DefaultView;
        repAdvert.DataBind();

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    protected void repAdvert_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "setting":
                Guid AdvertId = new Guid(e.CommandArgument.ToString());
                AdvertsManager.CreateInstant().UpdateGroup(AdvertId, Id);
                Response.Redirect(Request.RawUrl);
                break;
        }
    }

    protected void btnGroup_Click(object sender, EventArgs e)
    {
        AdvertsPositionEntity group = AdvertsPositionManager.CreateInstant().SelectOne(Id);
        if (group != null)
        {
            group.Width = FNumber.ConvertInt(txtWidth.Text.Trim());
            group.Height = FNumber.ConvertInt(txtHeight.Text.Trim());

            AdvertsPositionManager.CreateInstant().Update(group);

            Response.Redirect(Request.RawUrl);
        }
    }
}
