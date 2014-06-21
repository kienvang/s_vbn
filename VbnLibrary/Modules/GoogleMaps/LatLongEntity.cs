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

/// <summary>
/// Summary description for LatLong
/// </summary>
/// 

namespace Modules.GoogleMaps
{
    public class LatLongEntity
    {
        public string Lat { get; set; }
        public string Long { get; set; }
        public string Zoom { get; set; }
    }
}