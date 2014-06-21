using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Collections.Generic;

/// <summary>
/// Summary description for Breadcrumb
/// </summary>
namespace Library.Breadcrumb
{
    public class LinkEntity
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Alt { get; set; }
        public bool Last { get; set; }
    }

    public class Breadcrumb
    {
        MasterPage _masterpage;
        Page _page = new Page();
        Control _control;
        int _levelMasterPage = 2;
        string _controlId = "ucMyBreadcrumb";

        List<LinkEntity> _link = new List<LinkEntity>();
        
        public Breadcrumb(Page page)
        {
            _page = page;
        }

        /// <summary>
        /// Init Breadcrumb
        /// </summary>
        /// <param name="levelMasterPage">Cấp của master page chính</param>
        /// <param name="controlId">Tên của control Breadcrumb tren main master page</param>
        public void Init(int levelMasterPage, string controlId)
        {
            _levelMasterPage = levelMasterPage;
            _controlId = controlId;
            _masterpage = _page.Master;
            for (int i = 1; i <= levelMasterPage - 1; i++)
                _masterpage = _masterpage.Master as MasterPage;
            _control = _masterpage.FindControl(controlId);
        }

        /// <summary>
        /// Init Breadcrumb
        /// </summary>
        /// <param name="levelMasterPage">Cấp của master page chính</param>
        public void Init(int levelMasterPage)
        {
            _levelMasterPage = levelMasterPage;
            Init(levelMasterPage, _controlId);
        }

        public void Init()
        {
            Init(_levelMasterPage, _controlId);
        }

        public void Add(string title, string link)
        {
            Add(title, link, "", false);
        }

        public void Add(string title, string link, string alt)
        {
            Add(title, link, alt, false);
        }

        public void Add(string title, string link, string alt, bool last)
        {
            LinkEntity item = new LinkEntity();
            item.Title = title;
            item.Link = link;
            item.Alt = alt;
            item.Last = last;
            _link.Add(item);
        }

        public void StartBreadcrumb(string titleHome, string linkHome, string alt)
        {
            LinkEntity item = new LinkEntity();
            item.Title = titleHome;
            item.Link = linkHome;
            item.Alt = alt;
            item.Last = false;
            _link.Insert(0, item);
            //StartBreadcrumb();

            Repeater rpt = (Repeater)_control.FindControl("rptLink");
            rpt.DataSource = _link;
            rpt.DataBind();
        }

        public void StartBreadcrumb()
        {
            LinkEntity item = new LinkEntity();
            item.Title = "Trang chủ";
            item.Link = Library.Tools.UrlBuilder.RootUrl;
            item.Alt = "Du lịch Việt Nam";
            item.Last = false;
            _link.Insert(0, item);

            Repeater rpt = (Repeater)_control.FindControl("rptLink");
            rpt.DataSource = _link;
            rpt.DataBind();
        }
    }
}