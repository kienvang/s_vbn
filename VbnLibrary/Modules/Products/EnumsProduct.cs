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
/// Summary description for EnumsProduct
/// </summary>
namespace Modules.Products
{
    public class EnumsAction
    {
        public const string AddProuct = "Thêm - Thêm sản phẩm mới";
        public const string AddPhoto = "Thêm - Thêm hình sản phẩm";
        public const string UpdatePrice = "Cập nhật - Thay đổi giá bán <span style='text-decoration: line-through'>[[priceold/]]</span> - <span style='font-weight:bold'>[pricenew/]</span>";
        public const string UpdatePricePo = "Cập nhật - Thay đổi giá mua <span style='text-decoration: line-through'>[[priceold/]]</span> - <span style='font-weight:bold'>[pricenew/]</span>";
        public const string UpdateStore = "Cập nhật - Thay đổi số lượng <span style='text-decoration: line-through'>[[amountold/]]</span> - <span style='font-weight:bold'>[amountnew/]</span>";
        public const string UpdateInfos = "Cập nhật - Cập nhật thông tin sản phẩm";
        public const string UpdateIsVisible = "Cập nhật - Thiết lập hiển thị";
        public const string UpdateAmount = "Cập nhật - Thêm số lượng sản phẩm";
        public const string UpdateDel = "Cập nhật - Xóa sản phẩm";
    }

    public class EnumsProduct
    {
        public EnumsProduct()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}