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
public partial class Admin_Document_Control_MarkManager : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadData();
    }
    public void LoadData()
    {
        DataTable dt = CustomersManager.CreateInstant().SelectAllRDT();
        RepMark.DataSource = dt;
        RepMark.DataBind();
    }
    protected void btEdit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            for (int i = 0; i < RepMark.Items.Count; i++)
            {
                HiddenField Hid = (HiddenField)RepMark.Items[i].FindControl("HidID");
                TextBox txt=(TextBox)RepMark.Items[i].FindControl("txtMark");
                if (!string.IsNullOrEmpty(Hid.Value))
                {
                    CustomersEntity Obj = CustomersManager.CreateInstant().SelectByIdLST(new Guid(Hid.Value)).Items[0];
                    if (Obj != null)
                    {
                        if (!string.IsNullOrEmpty(txt.Text))
                        {
                            Obj.Mark = int.Parse(txt.Text);
                            CustomersManager.CreateInstant().Update(Obj);
                        }

                    }
                }
            }
            CustomValidator1.ErrorMessage = "Cập nhật thành công";
            CustomValidator1.IsValid = false;
            LoadData();
        }
    }
}
