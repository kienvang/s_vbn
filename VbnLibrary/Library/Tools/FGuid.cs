using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Tools
{
    public class FGuid
    {
        public static bool IsGuid(string GuidId)
        {
            if (string.IsNullOrEmpty(GuidId))
                return false;
            string parttern = "########-####-####-####-############";
            string guid = GuidId.ToLower();

            Regex reg = new Regex(parttern.Replace("#", "[a-z0-9]"));
            if (reg.IsMatch(guid) && guid.Length == parttern.Length)
                return true;
            return false;
        }

        public static Guid ToGuid(object val)
        {
            if (!Convert.IsDBNull(val) && IsGuid(val.ToString()))
                return new Guid(val.ToString());
            return Guid.Empty;
        }

        public static Guid ToGuid(string val)
        {
            if (!string.IsNullOrEmpty(val) && IsGuid(val))
                return new Guid(val);
            return Guid.Empty;
        }
    }
}
