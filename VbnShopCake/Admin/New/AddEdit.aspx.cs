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

public partial class Admin_New_AddEdit : System.Web.UI.Page
{
    public Guid Id
    {
        get
        {
            return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }

    void LoadData()
    {
        NewsEntity news = NewsManager.CreateInstant().SelectOne(Id);
        if (news != null)
        {
            txtSubject.Text = news.Subject;
            txtBody.Value = news.Body;

            btnAdd.Visible = false;
            btnEdit.Visible = true;
            btnCancel.Visible = true;
            btnDelete.Visible = true;
        }
    }

    NewsEntity getNews()
    {
        NewsEntity news = new NewsEntity();
        news.Id = Guid.NewGuid();
        news.Subject = Filter.GetMaxString(txtSubject.Text.Trim(), NewsFields.Subject.MaxLength);
        news.Body = txtBody.Value;
        news.CreatedBy = Util.CurrentUserName;

        return news;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            NewsEntity news = getNews();
            news.TextId = NewsManager.CreateInstant().GetUniqueTextIdFromUnicodeText(news.Subject);
            NewsManager.CreateInstant().Insert(news);

            Response.Redirect("/Admin/New");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            NewsEntity news = getNews();
            NewsEntity tmp = NewsManager.CreateInstant().SelectOne(Id);
            if (tmp != null)
            {
                news.Id = tmp.Id;
                if (news.Subject != tmp.Subject)
                    news.TextId = NewsManager.CreateInstant().GetUniqueTextIdFromUnicodeText(news.Subject);
                NewsManager.CreateInstant().Update(news); 
                Response.Redirect("/Admin/New");
            }
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        NewsEntity tmp = NewsManager.CreateInstant().SelectOne(Id);
        if (tmp != null)
        {
            NewsManager.CreateInstant().Delete(Id);
            Response.Redirect("/Admin/New");
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/New");
    }
}
