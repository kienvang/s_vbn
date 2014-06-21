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

public partial class Admin_Adverts_Controls_ListAdverts : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        DataTable table = AdvertsManager.CreateInstant().GetAllAdverts();

        smartPager.Visible = true;
        if (table == null && table.Rows.Count == 0)
        {
            smartPager.Visible = false;
            return;
        }
        PagedDataSource pagedata = new PagedDataSource();

        pagedata = Func.GetPaging(table.DefaultView, Request["page"], 20);

        this.smartPager.RowCount = pagedata.DataSourceCount;
        this.smartPager.CurrentPage = pagedata.CurrentPageIndex + 1;
        this.smartPager.PageSize = pagedata.PageSize;
        this.smartPager.Visible = this.smartPager.RowCount > this.smartPager.PageSize;
        this.smartPager.UrlFormatString = "/Admin/Adverts/?&page={0}";


        repAdvert.DataSource = pagedata;
        repAdvert.DataBind();
    }

    public string cssOver(string remain)
    {
        string css = "normal";
        int limit = int.Parse(remain);
        if (limit < 10 && limit > 0)
            css = "overwarming";
        else if (limit <= 0 && limit >= -50)
            css = "overlimit";
        else if (limit <= -50)
            css = "overwarming2";
        return css;
    }

    protected void repAdvert_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        string[] param = e.CommandArgument.ToString().Split('|');
        AdvertsEntity advert = AdvertsManager.CreateInstant().SelectOne(new Guid(param[0]));
        if (advert != null)
        {
            switch (e.CommandName)
            {
                case "del":
                    bool IsDelete = true;
                    if (!AdvertsManager.CreateInstant().IsDelete(advert.Id))
                    {
                        IsDelete = false;
                        
                    }

                    if (int.Parse(param[1]) <= 0)
                    {
                        IsDelete = true;
                    }

                    if (IsDelete)
                    {
                        AdvertsManager.CreateInstant().DeleteAll(advert.Id);
                        AdvertsManager.CreateInstant().DeleteAdvertById(advert.Id);
                        AdvertsManager.CreateInstant().Delete(advert.Id);
                        Response.Redirect("/Admin/Adverts/");
                    }
                    else
                    {
                        Response.Redirect("/Admin/Adverts/AdvertSetting.aspx?id=" + param[0]);
                    }
                    break;
            }
        }
    }

    public string getDetail(int totalPage, string Id, string groupName)
    {
        string url = "";

        if (totalPage > 0)
        {
            url = "<a href='/Admin/Adverts/AdvertSetting.aspx?id=" + Id + "'>" + groupName + "</a>"; ;
        }
        else
            url = groupName;

        return url;
    }

}
