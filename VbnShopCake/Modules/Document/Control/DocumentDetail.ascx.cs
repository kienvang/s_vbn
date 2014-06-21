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
using Modules.Document;
public partial class Modules_Document_Control_DocumentDetail : Authentication
{
    public int ReMark
    {
        get { return DocumentManager.CreateInstant().GetByIntId(IntId).ReMark; }
    }
    public bool IsShowVideo
    {
        get { return DocumentManager.CreateInstant().GetByIntId(IntId).ShowVideo; }
    }
    protected void Page_Load(object sender, EventArgs e)
    
    {
        if (!IsPostBack)
        {
            Session.Abandon();
            LoadData();
            if (!string.IsNullOrEmpty(Util.CurrentUserName))
            {
                divInfo.Visible = true;
                LoadInfo();
            }
            else
                divInfo.Visible = false;
        }
    }
    public int IntId
    {
        get { return !string.IsNullOrEmpty(Request["id"]) ? FString.IsInteger(Request["id"]) ? int.Parse(Request["id"]) : -1  : -1; }
    }
    public void LoadInfo()
    {
       
        CustomersEntity obj = CustomersManager.CreateInstant().GetByName(Util.CurrentUserName);
        if (obj != null)
            lbMark.Text = obj.Mark.ToString();
        DataTable dtObj = DownLoadHistoryManager.CreateInstant().GetDownLoadHistoryTop(Util.CurrentUserName);
        if (dtObj.Rows.Count >0)
        {
            lbDateDownEarly.Text = ((DateTime)dtObj.Rows[0]["Date"]).ToString("dd/MM/yyyy");
            lbMarkBeforeDown.Text = ((long)dtObj.Rows[0]["MarkBeforeDown"]).ToString();
            lbMarkAfterDown.Text = ((long)dtObj.Rows[0]["MarkAfterDown"]).ToString();
            LbDoc.Text = (string)dtObj.Rows[0]["DocumentName"];
        }
    }

    public void LoadData()
    {
        if (IntId != -1)
        {
            DocumentEntity obj = DocumentManager.CreateInstant().GetByIntId(IntId);
            if (obj != null)
            {
                lbTitle.Text = obj.DocumentName;
                lbSoLanTai.Text = obj.CountDown.ToString();
                lbDungLuong.Text = obj.FileSize.ToString();
                lbNgayCapNhat.Text = FDateTime.ConvertDate(obj.CreatedDate.ToString()).ToString("hh:mm") + "  " + FDateTime.ConvertDate(obj.CreatedDate.ToString()).ToShortDateString();
                lbDiemCan.Text = obj.Mark.ToString();
                lbDescription.Text = obj.Description;
                DataTable dtGuide = GuideManager.CreateInstant().SelectAllRDT();
                if(dtGuide.Rows.Count>0)   
                    lbGuide.Text = (string)dtGuide.Rows[0]["Guide"];
                if (obj.ShowVideo == true)
                {
                    if(!string.IsNullOrEmpty(obj.VideoTrailer))
                    {
                        string ExtensionFileName = System.IO.Path.GetExtension(obj.VideoTrailer).Trim('.');
                        ExtensionFileName = ExtensionFileName.ToLower();
                        if (ExtensionFileName.Equals("flv"))
                            VideoBox1.VideoType = "FLA";
                        else
                            VideoBox1.VideoType = "WMP";
                        VideoBox1.FileName = Library.Tools.UrlBuilder.RootUrl + obj.VideoTrailer;
                        VideoBox1.AutoStart = 0;
                        VideoBox1.Thumbnail = "/images/no_img.gif";
                        VideoBox1.ObjectType = "";
                        VideoBox1.CodeEmbeb = "";
                    } 
                }
            }
        }
    }
    protected void lnkDown_Click(object sender, EventArgs e)
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
                        //Response.Redirect("/Modules/Document/Download.aspx?id=" + IntId, false);
                        // Tru diem va luu lai history download

                        string temp = "0";
                        temp = (string)Session["flagdown"];
                        if (temp == "0" || string.IsNullOrEmpty(temp))
                        {
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

                            Session["flagdown"] = "1";
                        }
                        
                        
                        string ext = doc.PathName.Substring(doc.PathName.LastIndexOf(".") + 1);
                        WebUtility.DownLoadFile(Page, doc.TextId + "." + ext, Server.MapPath(doc.PathName));
                        Response.Redirect(Request.RawUrl);
                    }
                    else
                    {
                        // Xu ly cho truong hop khong du diem down tai lieu
                        Response.Redirect(Modules.Document.UrlBuilder.DownLoadGuide1(0));
                    }
                }
                else
                {
                    CustomersEntity obj = new CustomersEntity();
                    obj.UserName = Util.CurrentUserName;
                    obj.FullName = Profile.FullName;
                    CustomersManager.CreateInstant().Insert(obj);

                    // sau khi insert vo bang customer bao cho kh bit la ho chua du diem download
                    Response.Redirect(Modules.Document.UrlBuilder.DownLoadGuide1(0));
                }
            }
        }
    }
  
}
