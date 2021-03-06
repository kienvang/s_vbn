﻿using System;
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

public partial class Admin_Webservices_PositionItem : System.Web.UI.Page
{
    public string Id
    {
        get { return Request["typeid"]; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        PositionTypeEntity pos = PositionTypeManager.CreateInstant().GetById(Id);
        if (pos != null)
        {
            lblPosId.Text = pos.Id;
            lblTypeName.Text = pos.TypeName;
            lblWidth.Text = pos.Width.ToString() + " px";
            lblHeight.Text = pos.Height.ToString() + " px";
        }

        string html = "";
        html = Util.RenderControl((Control)div);
        Response.Write(html);
        Response.End();
    }
}
