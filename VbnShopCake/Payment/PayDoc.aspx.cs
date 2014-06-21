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

public partial class Payment_PayDoc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["status"] == "1")
        {
            MarkTransferEntity od = MarkTransferManager.CreateInstant().GetByCode(Request["ordercode"]);
            if (od != null)
            {
                Session["PAY"] = true;

                // chi tiet nop tien
                MarkAddHistoryEntity hisobj = new MarkAddHistoryEntity();

                // kt user da ton tai trong bang customer chua 
                CustomersEntity CusObj = new CustomersEntity();
                CustomersEntity CusTemp = CustomersManager.CreateInstant().GetByName(Util.CurrentUserName);
                if (CusTemp != null) //kt user da ton tai trong bang customer chua
                {
                    hisobj.MarkBeforeAdd = CusTemp.Mark;

                    CusObj = CusTemp;
                    CusObj.Mark = CusObj.Mark + od.Mark;
                    CustomersManager.CreateInstant().Update(CusObj);
                }
                else
                {
                    hisobj.MarkBeforeAdd = 0;

                    CusObj.Id = Guid.NewGuid();
                    CusObj.UserName = Util.CurrentUserName;
                    CusObj.FullName = Profile.FullName;
                    CusObj.Mark = od.Mark;
                    CustomersManager.CreateInstant().Insert(CusObj);
                }
                hisobj.Id = Guid.NewGuid();
                hisobj.CustomerId = CusObj.Id;
                hisobj.CodeMarkId = Guid.Empty;
                hisobj.Date = DateTime.Now;
                hisobj.MarkAfterAdd = CusObj.Mark;
                hisobj.CreatedBy = Util.CurrentUserName;
                hisobj.CreatedDate = DateTime.Now;
                hisobj.IsDeleted = false;
                MarkAddHistoryManager.CreateInstant().Insert(hisobj);

                Response.Redirect("/Payment/Thankyou.aspx?t=" + NganLuong.PayDoc + "&id=" + od.Id.ToString());
            }
        }
        Response.Redirect("/");
    }
}
