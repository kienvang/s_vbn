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
using Modules;

public partial class Admin_Adverts_AddEditAdvert : System.Web.UI.Page
{
    public Guid AdvertId
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblStatus.Text = "Thêm Quảng Cáo";
            this.Title = "Thêm Quảng Cáo";
            if (AdvertId != Guid.Empty)
            {
                lblStatus.Text = "Cập Nhật Quảng Cáo";
                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                reqFile.Enabled = false;

                LoadData();
            }
        }
    }

    void LoadData()
    {
        AdvertsEntity advert = AdvertsManager.CreateInstant().SelectOne(AdvertId);
        if (advert != null)
        {
            this.Title = "Cập Nhật Quảng Cáo - " + advert.AdvertName;
            txtAdvertName.Text = advert.AdvertName;
            txtBeginDate.Text = advert.BeginDate.ToString("dd/MM/yyyy");
            txtEndDate.Text = advert.EndDate.ToString("dd/MM/yyyy");
            ddlType.SelectedValue = advert.Type;
            txtAddressUrl.Text = advert.AddressUrl;
            chkIsVisible.Checked = advert.IsVisible;
            txtWidth.Text = advert.Width.ToString();
            txtHeight.Text = advert.Height.ToString();
            
            Image1.Visible = true;
            Image1.ImageUrl = advert.Path;
        }
    }

    AdvertsEntity getAdvert()
    {
        AdvertsEntity advert = new AdvertsEntity();

        advert.Id = Guid.NewGuid();
        advert.AdvertName = Filter.GetMaxString(txtAdvertName.Text, AdvertsFields.AdvertName.MaxLength);
        advert.BeginDate = FDateTime.ConvertDate(txtBeginDate.Text);
        advert.EndDate = FDateTime.ConvertDate(txtEndDate.Text);
        advert.IsVisible = chkIsVisible.Checked;
        advert.AddressUrl = Filter.GetMaxString(txtAddressUrl.Text, AdvertsFields.AddressUrl.MaxLength);
        advert.Type = ddlType.Text;
        advert.UpdatedBy = Util.CurrentUserName;
        advert.UpdatedDate = DateTime.Now;
        int w = 0;
        int h = 0;
        if (int.TryParse(txtWidth.Text.Trim(), out w))
            advert.Width = w;
        if (int.TryParse(txtHeight.Text.Trim(), out h))
            advert.Height = h;
        return advert;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            AdvertsEntity advert = getAdvert();
            advert.CreatedBy = Util.CurrentUserName;
            advert.Path = FileUploadControl.FullPath(fileLoad, EnumsFile.Advert, "", AdvertsFields.Path.MaxLength);

            AdvertsManager.CreateInstant().Insert(advert);
            Response.Redirect("/Admin/Adverts/");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            AdvertsEntity tmp = AdvertsManager.CreateInstant().SelectOne(AdvertId);
            if (tmp != null)
            {
                AdvertsEntity advert = getAdvert();
                advert.Id = tmp.Id;
                advert.Path = tmp.Path;
                advert.CreatedBy = tmp.CreatedBy;
                advert.CreatedDate = tmp.CreatedDate;

                if (fileLoad.HasFile)
                {
                    advert.Path = FileUploadControl.FullPath(fileLoad, EnumsFile.Advert, "", AdvertsFields.Path.MaxLength);
                }
                AdvertsManager.CreateInstant().Update(advert);

                AdvertsPositionManager.CreateInstant().UpdateNumberOfGroup(advert.Id);

                Response.Redirect("/Admin/Adverts/");
            }
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        AdvertsEntity advert = AdvertsManager.CreateInstant().SelectOne(AdvertId);
        if (advert != null && AdvertsManager.CreateInstant().IsDelete(advert.Id))
        {
            AdvertsManager.CreateInstant().DeleteAll(advert.Id);
            AdvertsManager.CreateInstant().DeleteAdvertById(AdvertId);
            Response.Redirect("/Admin/Adverts/");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/Adverts/");
    }
}
