using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using Modules;
using Library.Tools;
namespace Modules.Document
{
    public class DocumentConfig
    {
        public static int star1
        {
            get { return int.Parse(DocumentConfigManager.CreateInstant().GetByCode("1star").Value); }
        }
        public static int star2
        {
            get { return int.Parse(DocumentConfigManager.CreateInstant().GetByCode("2star").Value); }
        }
        public static int star3
        {
            get { return int.Parse(DocumentConfigManager.CreateInstant().GetByCode("3star").Value); }
        }
        public static int star4
        {
            get { return int.Parse(DocumentConfigManager.CreateInstant().GetByCode("4star").Value); }
        }
        public static int star5
        {
            get { return int.Parse(DocumentConfigManager.CreateInstant().GetByCode("5star").Value); }
        }
        public static int MaxMark
        {
            get { return int.Parse(DocumentConfigManager.CreateInstant().GetByCode("MaxMark").Value); }
        }
    }
}
