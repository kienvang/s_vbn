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
using Modules;
using Library.Tools;
using Modules.Document;
public partial class Modules_Document_Control_ListDocumentByGroup : Authentication
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
        }
    }
    public Guid ID
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? Util.IsGuid(Request["id"]) ? new Guid(Request["id"]) : Guid.Empty : Guid.Empty; }
    }
    public string Name
    {
        get { return !string.IsNullOrEmpty(Request["name"]) ? Request["name"] : ""; }
    }
    public int IntId
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? FString.IsInteger(Request["id"]) ? int.Parse(Request["id"]) : -1 : -1; }
    }
    public int CountDoc
    {
        get { return DocumentManager.CreateInstant().GetByGroup(IntId).Rows.Count; }
    }
    public void LoadData()
    {
        if (IntId != -1)
        {
            DataTable dtTop = DocumentManager.CreateInstant().GetByGroup(IntId);
            DocumentGroupEntity obj=DocumentGroupManager.CreateInstant().GetByIntID(IntId);
            if (obj != null)
                lbTitle.Text = obj.GroupName;
            listByGroup.DataSource = dtTop;
            listByGroup.DataBind();
        }
    }
    public string SplitString(string str)
    {
        string result = "";
        string[] temp = str.Split(' ');
        if (temp.Length >= 10)
        {
            for (int i = 0; i < 10; i++)
                result += temp[i] + " ";
            return result + "...";
        }
        return str;
    }
    
}
