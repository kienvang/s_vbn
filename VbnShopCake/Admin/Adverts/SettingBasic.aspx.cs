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

public partial class Admin_Adverts_SettingBasic : System.Web.UI.Page
{
    public string PositionId
    {
        get { return Request["id"]; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCombo();
            LoadData();
        }

        loadTypeParent();
    }

    void LoadCombo()
    {
        //DataTable table = PositionManager.CreateInstant().SelectAllRDT();
        //table.DefaultView.Sort = "OrderIndex";
        //ddlPosition.DataTextField = "PositionName";
        //ddlPosition.DataValueField = "Id";
        //ddlPosition.DataSource = table.DefaultView;
        //ddlPosition.DataBind();
    }

    void LoadData()
    {
        if (!string.IsNullOrEmpty(PositionId))
        {
            DataTable table = AdvertsManager.CreateInstant().GetAdvertSetting(PositionId);
            table.DefaultView.Sort = "IsSingle, IsSetting desc, PositionTypeId,OrderIndex,AdvertName";
            repAdvert.DataSource = table.DefaultView;
            repAdvert.DataBind();

            group.Visible = true;
        }
        else
        {
            repAdvert.DataSource = null;
            repAdvert.DataBind();
            group.Visible = false;
        }
    }

    //protected void ddlPosition_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlPosition.SelectedValue == "")
    //        group.Visible = false;
    //    else
    //        group.Visible = true;

    //    LoadData();
    //}

    protected void repAdvert_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Guid AdvertId = new Guid(e.CommandArgument.ToString());
        switch (e.CommandName)
        {
            case "isvisible":
                AdvertsPositionEntity ad = AdvertsPositionManager.CreateInstant().SelectOne(AdvertId);
                if (ad != null)
                {
                    ad.IsVisible = !ad.IsVisible;
                    AdvertsPositionManager.CreateInstant().Update(ad);
                    //LoadData();
                    Response.Redirect(Request.RawUrl);
                }
                break;
            case "setvisible":
                AdvertsPositionManager.CreateInstant().InsertSetting(AdvertId, PositionId);
                //LoadData();
                Response.Redirect(Request.RawUrl);
                break;
            case "order":
                AdvertsPositionEntity adv = AdvertsPositionManager.CreateInstant().SelectOne(AdvertId);
                if (adv != null)
                {
                    TextBox txt = (TextBox)e.Item.FindControl("txtOrder");
                    int order = 0;
                    if (adv != null && txt != null && int.TryParse(txt.Text.Trim(), out order))
                    {
                        AdvertsPositionManager.CreateInstant().OrderRanking(adv.Id, order, adv.OrderIndex, PositionId);
                        //LoadData();
                        Response.Redirect(Request.RawUrl);
                    }
                }
                break;
            case "del":
                AdvertsPositionManager.CreateInstant().DeleteById(AdvertId);
                AdvertsGroupManager.CreateInstant().DeleteByAdvertPositionId(AdvertId);
                //LoadData();
                Response.Redirect(Request.RawUrl);
                break;
        }
    }

    protected void btnGroup_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            AdvertsPositionEntity group = new AdvertsPositionEntity();
            group.Id = Guid.NewGuid();
            group.GroupName = Filter.GetMaxString(txtGroupName.Text.Trim(), AdvertsPositionFields.GroupName.MaxLength);
            group.PositionId = PositionId;
            group.IsSingle = false;
            group.NumberOfGroup = 0;
            group.Width = FNumber.ConvertInt(txtWidth.Text.Trim());
            group.Height = FNumber.ConvertInt(txtHeight.Text.Trim());

            AdvertsPositionManager.CreateInstant().Insert(group);
            //LoadData();
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void valGroup_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = true;
        if (AdvertsPositionManager.CreateInstant().IsExistsGroupName(txtGroupName.Text.Trim(), PositionId))
        {
            args.IsValid = false;
            valGroup.ErrorMessage = "Trùng tên nhóm";
        }
    }

    public Guid GetAdvertId(Guid Id, bool IsSetting, bool IsSingle)
    {
        Guid AdverdId = Guid.Empty;
        if (!IsSetting)
        {
            AdverdId = Id;
        }
        else
        {
            if (IsSingle)
            {
                EntityCollection<AdvertsGroupEntity> items = AdvertsGroupManager.CreateInstant().SelectByAdvertPositionIdLST(Id);
                if (items != null && items.Count > 0)
                {
                    AdverdId = items[0].AdvertId;
                }
            }
        }
        return AdverdId;
    }

    void loadTypeParent()
    {
        DataTable table = PositionManager.CreateInstant().SelectByParentIdRDT(null);
        repTypeParent.DataSource = table;
        repTypeParent.DataBind();
    }

    public DataTable loadType(string Id)
    {
        DataTable table = PositionManager.CreateInstant().SelectByParentIdRDT(Id);
        return table;
    }

    public string getCss()
    {
        return "";
    }
}
