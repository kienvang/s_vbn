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
public partial class Modules_Document_Control_Download : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(down))
        {
            if (down == "1")
            {
                DocumentEntity doc = DocumentManager.CreateInstant().GetByIntId(IntId);
                if (doc != null)
                {
                    // kiem tra dang nhap
                    // kiem tra diem
                    if (!string.IsNullOrEmpty(Util.CurrentUserName)) // kt dang nhap
                    {
                        CustomersEntity CusObj = CustomersManager.CreateInstant().GetByName(Util.CurrentUserName);
                        if (CusObj != null) //kt user da ton tai trong bang customer chua
                        {
                            if (CusObj.Mark >= doc.Mark) // kt customer co du diem down tai lieu nay khong
                            {

                                // Tru diem va luu lai history download

                                DownLoadHistoryEntity downObj = new DownLoadHistoryEntity();
                                downObj.CustomerId = CusObj.Id;
                                downObj.DocumentId = doc.Id;
                                downObj.Date = DateTime.Now;
                                downObj.MarkBeforeDown = CusObj.Mark;
                                downObj.MarkAfterDown = CusObj.Mark - doc.Mark;
                                downObj.CreatedBy = Util.CurrentUserName;
                                downObj.CreatedDate = DateTime.Now;
                                downObj.IsDeleted = false;
                                DownLoadHistoryManager.CreateInstant().Insert(downObj);

                                //  tru diem
                                CusObj.Mark = CusObj.Mark - doc.Mark;
                                CustomersManager.CreateInstant().Update(CusObj);

                                string ext = doc.PathName.Substring(doc.PathName.LastIndexOf(".") + 1);
                                WebUtility.DownLoadFile(Page, doc.TextId + "." + ext, Server.MapPath(doc.PathName));
                            }
                            else
                            {
                                // Xu ly cho truong hop khong du diem down tai lieu
                                Response.Redirect("/Modules/Document/DownLoadGuide.aspx?flag=0");
                            }
                        }
                        else
                        {
                            CustomersEntity obj = new CustomersEntity();
                            obj.UserName = Util.CurrentUserName;
                            obj.FullName = Profile.FullName;
                            CustomersManager.CreateInstant().Insert(obj);

                            // sau khi insert vo bang customer bao cho kh bit la ho chua du diem download
                            Response.Redirect("/Modules/Document/DownLoadGuide.aspx?flag=0");
                        }
                    }
                }
            }
        }
    }
    public int IntId
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? int.Parse(Request["id"]) : -1; }
    }
    public string down
    {
        get { return !string.IsNullOrEmpty(Request["down"]) ? Request["down"] : ""; }
    }
    protected void lnkDown_Click(object sender, EventArgs e)
    {
        
    }
}
