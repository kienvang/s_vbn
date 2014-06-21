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

using System.Text.RegularExpressions;

/// <summary>
/// Summary description for FilterRegular
/// </summary>
namespace Library.Tools
{
    public enum ReplaceType
    {
        Empty = 1,
        WhiteSpace = 2,
    }

    public class FilterRegular
    {
        public static string GetTextByRegex(string __RegexPattern, string __InputText)
        {
            return GetTextByRegex(__RegexPattern, __InputText, true);
        }

        public static string GetTextByRegex(string __RegexPattern, string __InputText, bool __RegexIgnoreCase)
        {
            return GetTextByRegex(__RegexPattern, __InputText, __RegexIgnoreCase, -1, -1);
        }

        public static string GetTextByRegex(string __RegexPattern, string __InputText, bool __RegexIgnoreCase, int __MatchIndex, int __GroupIndex)
        {
            string toReturn = string.Empty;

            if (!string.IsNullOrEmpty(__InputText))
            {
                Regex objRegex = new Regex(__RegexPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
                MatchCollection _MatchCollection = objRegex.Matches(__InputText);

                if (__MatchIndex == -1 && __GroupIndex == -1)
                {
                    foreach (Match match in _MatchCollection)
                    {
                        foreach (Group group in match.Groups)
                        {
                            //toReturn += Server.HtmlEncode(group.Value);
                            toReturn += group.Value;
                        }
                    }
                }
                else
                {
                    if (_MatchCollection.Count > __MatchIndex)
                    {
                        if (_MatchCollection[__MatchIndex].Groups.Count > __GroupIndex)
                        {
                            toReturn = _MatchCollection[__MatchIndex].Groups[__GroupIndex].Value;
                        }
                    }
                }
            }

            return toReturn.Trim();
        }

        public static string RegularReplace(string _input, string _pattern, ReplaceType type)
        {
            string tmp = string.Empty;
            switch (type)
            {
                case ReplaceType.Empty:
                    tmp = string.Empty;
                    break;
                case ReplaceType.WhiteSpace:
                    tmp = " ";
                    break;
            }
            return RegularReplace(_input, _pattern, tmp);
        }

        public static string RegularReplace(string _input, string[] _pattern, ReplaceType type)
        {
            string tmp = string.Empty;
            switch (type)
            {
                case ReplaceType.Empty:
                    tmp = string.Empty;
                    break;
                case ReplaceType.WhiteSpace:
                    tmp = " ";
                    break;
            }
            return RegularReplace(_input, _pattern, tmp);
        }

        public static string RegularReplace(string _input, string _pattern, string replace)
        {
            return Regex.Replace(_input, _pattern, replace, RegexOptions.IgnoreCase);
        }

        public static string RegularReplace(string _input, string[] _pattern, string replace)
        {
            string _roReturn = _input;

            for (int i = 0; i < _pattern.Length; i++)
                _roReturn = Regex.Replace(_roReturn, _pattern[i], replace, RegexOptions.IgnoreCase);

            return _roReturn;
        }
    }
}