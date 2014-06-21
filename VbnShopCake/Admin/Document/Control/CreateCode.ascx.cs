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
using System.Text.RegularExpressions;
public partial class Admin_Document_Control_CreateCode : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            LoadData();
    }
    public void LoadData()
    {
        txtCreatedDate.Text = DateTime.Now.ToShortDateString();
        RepCode.DataSource = CodeMarkManager.CreateInstant().SelectByCreatedDateRDT(FDateTime.ConvertDate(DateTime.Now.ToShortDateString()));
        RepCode.DataBind();
    }
    protected void btAdd_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            for (int i = 0; i < int.Parse(txtCount.Text); i++)
            {
                string code = MD5.Encrypt(Guid.NewGuid().ToString(), "vbn", true);
                string pattern = @"\W";
                Regex myregex = new Regex(pattern);
                code = myregex.Replace(code, "").ToUpper().Remove(10);

                CodeMarkEntity obj = new CodeMarkEntity();
                obj.Id = Guid.NewGuid();
                obj.Code = code;
                obj.Mark = int.Parse(txtMark.Text);
                obj.CreatedBy = Util.CurrentUserName;
                obj.CreatedDate = FDateTime.ConvertDate(DateTime.Now.ToShortDateString());
                obj.IsDeleted = false;

                object[] arr = new object[] { i + 1, obj.Code, obj.Mark };
                CodeMarkManager.CreateInstant().Insert(obj);
            }
            RepCode.DataSource = CodeMarkManager.CreateInstant().SelectByCreatedDateRDT(FDateTime.ConvertDate(DateTime.Now.ToShortDateString()));
            RepCode.DataBind();
        }
    }
    public DataTable CreateDataTable()
    {
        DataTable tb = new DataTable("tb");
        tb.Columns.Add(new DataColumn("STT"));
        tb.Columns.Add(new DataColumn("code"));
        tb.Columns.Add(new DataColumn("mark"));
        DataTable dt = CodeMarkManager.CreateInstant().SelectByCreatedDateRDT(FDateTime.ConvertDate(txtCreatedDate.Text.Trim()));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            object[] arr = new object[] { i+1, dt.Rows[i]["Code"].ToString(), dt.Rows[i]["Mark"].ToString() };
            tb.Rows.Add(arr);
        }
        return tb;
    }
    protected void lnkExport_Click(object sender, EventArgs e)
    {
        DataTable dt = CreateDataTable();
        if (dt.Rows.Count > 0)
        {
            string filename = "Code-" + DateTime.Now.ToString("dd-MM-yyyy") + ".xls";
            ExcelConvertor excel = new ExcelConvertor();
            excel.ShowExcelTableBorder = true;
            excel.Convert(dt, Server.MapPath("~/userfiles/Code/   "), filename);
            WebUtility.DownLoadFile(Page, filename, Server.MapPath("/userfiles/Code/") + filename);
        }
        else
        {
            CustomValidator1.ErrorMessage = "Không có mã số được tạo";
            CustomValidator1.IsValid = false;
        }
    }
    protected void btSearch_Click(object sender, EventArgs e)
    {
        RepCode.DataSource = CodeMarkManager.CreateInstant().SelectByCreatedDateRDT(FDateTime.ConvertDate(txtCreatedDate.Text.Trim()));
        RepCode.DataBind();
    }
}
