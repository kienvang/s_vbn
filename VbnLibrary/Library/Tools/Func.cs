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
using System.Collections;
using System.Text;

using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>
/// Summary description for Func
/// </summary>
namespace Library.Tools
{
    public class Func
    {
        public static string AutomationCode(int Number)
        {
            string code = "";
            List<string> ch = new List<string>();
            int i = 0;
            for (i = 65; i <= 90; i++)
                ch.Add(((char)i).ToString());
            for (i = 97; i <= 122; i++)
                ch.Add(((char)i).ToString());
            for (i = 0; i < 10; i++)
                ch.Add(i.ToString());

            if (Number > 62)
                Number = 62;

            Random rand = new Random();
            for (i = 0; i < Number; i++)
            {
                int k = rand.Next(0, ch.Count - 1);
                code += ch[k];
                ch.RemoveAt(k);
            }

            return code;
        }

        /// <summary>
        /// Default 50 charactor
        /// </summary>
        /// <returns></returns>
        public static string AutomationCode()
        {
            return AutomationCode(50);
        }

        public static PagedDataSource GetPaging(DataTable view, string page, int PageSize)
        {
            return GetPaging(view.DefaultView, page, PageSize);
        }

        public static PagedDataSource GetPaging(DataView view, string page, int PageSize)
        {
            PagedDataSource paging = new PagedDataSource();

            int pagenumber = 0;
            if (!string.IsNullOrEmpty(page))
            {
                if (!int.TryParse(page, out pagenumber))
                    pagenumber = 0;
            }
            pagenumber--;
            if (pagenumber < 0) pagenumber = 0;

            paging.AllowPaging = true;
            paging.DataSource = view;
            paging.CurrentPageIndex = pagenumber;
            paging.PageSize = PageSize;
            return paging;
        }

        public static PagedDataSource GetPaging(IEntityCollection2 view, string page, int PageSize)
        {
            return GetPaging(view.DefaultView, page, PageSize);
        }

        public static PagedDataSource GetPaging(IEntityView2 view, string page, int PageSize)
        {
            PagedDataSource paging = new PagedDataSource();

            int pagenumber = 0;
            if (!string.IsNullOrEmpty(page))
            {
                if (!int.TryParse(page, out pagenumber))
                    pagenumber = 0;
            }

            paging.AllowPaging = true;
            paging.DataSource = view;
            paging.CurrentPageIndex = pagenumber;
            paging.PageSize = PageSize;
            return paging;
        }
    }
}