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

public partial class Modules_FeedBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    FeedBackEntity getFeedBack()
    {
        FeedBackEntity feedback = new FeedBackEntity();

        feedback.Id = Guid.NewGuid();
        feedback.UserName = Util.CurrentUserName;
        feedback.Message = Filter.GetStringNoHtml(txtMessage.Text.Trim(), FeedBackFields.Message.MaxLength);
        feedback.Sender = Filter.GetStringNoHtml(txtSender.Text.Trim(), FeedBackFields.Sender.MaxLength);
        feedback.SenderEmail = Filter.GetMaxString(txtSenderEmail.Text.Trim(), FeedBackFields.SenderEmail.MaxLength);
        feedback.UserIp = WebUtility.GetUserIP();

        return feedback;
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            FeedBackEntity feedback = getFeedBack();
            FeedBackManager.CreateInstant().Insert(feedback);

            EventsManager.CreateInstant().AddEvent(feedback.Message, Modules.Events.EnumsEvents.FeedBack, feedback.Id.ToString());

            Response.Redirect(Modules.UrlBuilder.FeedBackComplete());
        }
    }
}
