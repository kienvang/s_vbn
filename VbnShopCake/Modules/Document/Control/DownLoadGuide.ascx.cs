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
using Modules.Role;
public partial class Modules_Document_Control_DownLoadGuide : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadData();
            loadMark();
            loadHelp();
        }
    }

    public string Flag
    {
        get { return !string.IsNullOrEmpty(Request["flag"]) ? Request["flag"] : ""; }
    }

    public void LoadData()
    {
        if (Flag != "" && Flag=="0")
            lbAlert.Text = "Số điểm hiện tại của bạn không đủ để download tài liệu này, vui lòng xem hướng dẫn bên dưới để nạp thêm điểm vào tài khoản";
    }

    void loadMark()
    {
        DataTable tbl = MarkTransferManager.CreateInstant().SelectAllRDT();
        if (tbl != null && tbl.Rows.Count > 0)
        {
            tbl.DefaultView.Sort = "Mark";
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ListItem item = new ListItem();
                item.Value = tbl.Rows[i]["Id"].ToString();
                item.Text = tbl.Rows[i]["Code"].ToString() + " - " + tbl.Rows[i]["Mark"].ToString() + " điểm ứng với " + FNumber.FormatNumber(tbl.Rows[i]["Cost"]) + "VND";
                if (i == 0) item.Selected = true;
                rdoMark.Items.Add(item);
            }
        }
        else
        {
            divMark.Visible = false;
        }
    }

    void loadHelp()
    {
        EmailTemplatesEntity temp = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("DocPayCard");
        if (temp != null)
            lblPutCard.Text = temp.Body;
        temp = EmailTemplatesManager.CreateInstant().GetTemplateByTemplateCode("DocPayOnline");
        if (temp != null)
            lblPayOnline.Text = temp.Body;
    }

    protected void btSubmit_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Util.CurrentUserName))
        {
            CodeMarkEntity obj = CodeMarkManager.CreateInstant().GetByCode(txtCode.Text.Trim());
            if (obj != null)
            {
                // chi tiet nop tien
                MarkAddHistoryEntity hisobj = new MarkAddHistoryEntity();
                
                // kt user da ton tai trong bang customer chua 
                CustomersEntity CusObj=new CustomersEntity();
                CustomersEntity CusTemp = CustomersManager.CreateInstant().GetByName(Util.CurrentUserName);
                if (CusTemp != null) //kt user da ton tai trong bang customer chua
                {
                    if (CusTemp.Mark < Modules.Document.DocumentConfig.MaxMark)
                    {
                        hisobj.MarkBeforeAdd = CusTemp.Mark;

                        CusObj = CusTemp;
                        CusObj.Mark = CusObj.Mark + obj.Mark;
                        CustomersManager.CreateInstant().Update(CusObj);
                    }
                    else
                    {
                        CustomValidator1.ErrorMessage = "Số điểm hiện tại của bạn đã đạt giới hạn (giới hạn: "+ Modules.Document.DocumentConfig.MaxMark+" điểm), vui lòng giữ lại mã số và nạp điểm vào lần sau";
                        CustomValidator1.IsValid = false;
                        return;
                    }
                }
                else
                {
                    hisobj.MarkBeforeAdd = 0;

                    CusObj.Id = Guid.NewGuid();
                    CusObj.UserName = Util.CurrentUserName;
                    CusObj.FullName = Profile.FullName;
                    CusObj.Mark = obj.Mark;
                    CustomersManager.CreateInstant().Insert(CusObj);
                }
                hisobj.Id = Guid.NewGuid();
                hisobj.CustomerId = CusObj.Id;
                hisobj.CodeMarkId = obj.Id;
                hisobj.Date = DateTime.Now;
                hisobj.MarkAfterAdd = CusObj.Mark;
                hisobj.CreatedBy = Util.CurrentUserName;
                hisobj.CreatedDate = DateTime.Now;
                hisobj.IsDeleted = false;
                MarkAddHistoryManager.CreateInstant().Insert(hisobj);

                obj.IsDeleted = true;
                CodeMarkManager.CreateInstant().Update(obj);

                CustomValidator1.ErrorMessage = "Nạp điểm thành công";
                CustomValidator1.IsValid = false;
            }
            else
            {
                CustomValidator1.ErrorMessage = "Mã số không tồn tại";
                CustomValidator1.IsValid = false;
                return;
            }          
        }
        else
            Response.Redirect(CheckRoles.CreateInstant().GetUrlDirect(Request.RawUrl));
    }

    protected void btnPay_Click(object sender, EventArgs e)
    {
        MarkTransferEntity mark = MarkTransferManager.CreateInstant().SelectOne(new Guid(rdoMark.SelectedValue));
        if (mark != null)
        {
            string url = NganLuong.CreateInstant().buildCheckoutUrl("" + mark.Code + "", FNumber.FormatNumber(mark.Cost).Replace(",", ""), NganLuong.PayDoc);
            Response.Redirect(url);
        }
        else
            Response.Redirect(Request.RawUrl);
    }
}
