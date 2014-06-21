using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Tools;
namespace Library.Tools
{
    public class Authentication : System.Web.UI.UserControl
    {
        public Authentication()
        { 
        }
        public bool IsSignIn()
        {
            if (!string.IsNullOrEmpty(Util.CurrentUserName))
                return true;
            return false;
        }
    }
}
