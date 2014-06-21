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

public partial class Modules_Document_Control_ListDocument : Authentication
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    LoadData();
        //}
    }
    //public void LoadData()
    //{
    //    DataTable dtTop = DocumentManager.CreateInstant().GetTopDown();
    //    listTopDown.DataSource = dtTop;
    //    listTopDown.DataBind();

    //    DataTable dtNew = DocumentManager.CreateInstant().Getnew();
    //    ListDown.DataSource = dtNew;
    //    ListDown.DataBind();
    //}
    //public string SplitString(string str)
    //{
    //    string result="";
    //    string[] temp = str.Split(' ');
    //    if (temp.Length >=10)
    //    {
    //        for (int i = 0; i < 10; i++)
    //            result += temp[i]+" ";
    //        return result+"...";
    //    }
    //    return str;
    //}
}
