using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;
using System.Web;
using Library.Tools;

namespace Library.Tools
{
    public class FilterHtml
    {
        #region "Pattern Regular Expression"

        public static FilterHtml CreateInstant()
        {
            return new FilterHtml();
        }

        string[] PatternHtml
        {
            get
            {
                return new[] { @"<[\s]*(!--|script|title)(.*?)>((.|\n)*?)(<\/(--|script|title)>)",
                               @"<[\s]*(/?tbody|/?body|/?head|/?link|/?html|/?a|/?br|/?center|/?dd|/?dl|/?dt|/?thead|/?tfoot|" +
                               @"/?embed|/?font|/?frame|/?frameset|/?h1|/?h2|/?h3|/?h4|/?h5|/?h6|/?i|/?span|/?b|/?hr|/?label|" +
                               @"/?img|/?li|/?ol|/?p|/?pre|/?table|/?td|/?tr|/?th|/?tt|/?ul|/?u|/?blockquote|/?div|/?map|/?area|/?cation|" +
                               @"/?noframes|/?base|/?form|/?input|/?select|/?option|/?textarea|/?strong)(>|\s[^>]*?>)"
                             };
            }
        }

        string[] PatternHtml2
        {
            get
            {
                return new[] { @"<[\s]*(!--|script|title)(.*?)>((.|\n)*?)(<\/(--|script|title)>)",
                               @"<[\s]*(/?link|/?center|" +
                               @"/?frame|/?frameset|/?iframe|" +
                               @"/?pre|/?th|/?tt|/?map|/?area|" +
                               @"/?noframes|/?base|/?input|/?select|/?option|/?textarea)[^>]*?>"
                             };
            }
        }

        /// <summary>
        /// Pattern : Use to IsMatch for Number
        /// </summary>
        string PatternNumbersOnly
        {
            get
            {
                return @"[-\+]?[0-9](\.[0-9]+)?";
            }
        }

        string[] PatternNumbersOnly_ByReplace
        {
            get
            {
                return new[] { "([^0-9\\.,-]+)", 
                               "[\\s\\D]*[\\.,][\\s\\D]",
                               "(-{2})|(\\s[-]*\\s)" };
            }
        }

        string[] PatternTextOnly_ByReplace
        {
            get
            {
                return new[] { @"([^a-zA-Z\s\u00E0-\uFFFF]+)" };
            }
        }

        public string PatternTextOnly
        {
            get
            {
                return @"([a-zA-Z\s\u00E0-\uFFFF]+)";
            }
        }

        string[] PatternTextWithNumbers
        {
            get
            {
                return new[] { @"([^a-zA-Z0-9\s\u00E0-\uFFFF]+)" };
            }
        }

        public string PatternTextNumbers
        {
            get
            {
                return @"([a-zA-Z0-9\s\u00E0-\uFFFF]+)";
            }
        }

        string[] PatternTextWithNumbersAndDash
        {
            get
            {
                return new[] { @"([^a-zA-Z0-9_\-\s\u00E0-\uFFFF]+)" };
            }
        }

        public string PatternTextNumbersAndDash
        {
            get
            {
                return @"([a-zA-Z0-9_\-\s\u00E0-\uFFFF]+)";
            }
        }

        string[] PatternTextWithNumbersAndSpecialCharactersFew
        {
            get
            {
                return new[] { @"([^a-zA-Z0-9\u00E0-\uFFFF\-_\.,?/\(\)\*&%$@!’”;:\s]+)" };
            }
        }

        public string PatternTextNumbersAndSpecialCharactersFew
        {
            get
            {
                return @"([^a-zA-Z0-9\u00E0-\uFFFF\-_\.,?/\(\)\*&%$@!’”;:\s]+)";
            }
        }

        string[] PatternTextWithNumbersAndSpecialCharactersAll
        {
            get
            {
                return new[] { @"([^a-zA-Z0-9\u00E0-\uFFFF~!@#$%\^&\*\(\)\-_=\+\[\];:’”,\./?{}\\|\s]+)" };
            }
        }

        public string PatternTextNumbersAndSpecialCharactersAll
        {
            get
            {
                return @"([^a-zA-Z0-9\u00E0-\uFFFF~!@#$%\^&\*\(\)\-_=\+\[\];:’”,\./?{}\\|\s]+)";
            }
        }

        #endregion

        public string Filter_RemoveHtmlTag(string _input)
        {
            return FilterRegular.RegularReplace(_input, PatternHtml, ReplaceType.Empty);
        }

        public string Filter_RemoveHtmlTag2(string _input)
        {
            return FilterRegular.RegularReplace(_input, PatternHtml2, ReplaceType.Empty);
        }

        public string Filter_NumbersOnly(string _input, int limit)
        {
            string _return = "";
            _return = Filter_RemoveHtmlTag(_input);
            _return = FilterRegular.RegularReplace(_return, PatternNumbersOnly_ByReplace, ReplaceType.Empty).Trim();
            if (_return.Length <= limit)
                return _return;
            return _return.Substring(0, limit);
        }

        /// <summary>
        /// Get only number from anthing string
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <returns></returns>
        public string Filter_NumbersOnly(string _input)
        {
            return Filter_NumbersOnly(_input, 10);
        }

        /// <summary>
        /// Get only text [a-zA-Z] from anthing string
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="limit">Number of characters</param>
        /// <returns></returns>
        public string Filter_TextOnly(string _input, int limit)
        {
            string _return = "";
            _return = Filter_RemoveHtmlTag(_input);
            _return = FilterRegular.RegularReplace(_return, PatternTextOnly_ByReplace, ReplaceType.Empty);
            if (_return.Length <= limit)
                return _return;
            return _return.Substring(0, limit);
        }

        /// <summary>
        /// Get only text [a-zA-Z] from anthing string with limit = 400
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <returns></returns>
        public string Filter_TextOnly(string _input)
        {
            return Filter_TextOnly(_input, 400);
        }

        /// <summary>
        /// Get text and number [a-zA-Z0-9]
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="_limit">Number of characters</param>
        /// <returns></returns>
        public string Filter_TextWithNumbers(string _input, int _limit)
        {
            string _return = "";
            _return = Filter_RemoveHtmlTag(_input);
            _return = FilterRegular.RegularReplace(_return, PatternTextWithNumbers, ReplaceType.Empty);

            if (_return.Length <= _limit)
                return _return;
            return _return.Substring(0, _limit);
        }

        /// <summary>
        /// Get text and number [a-zA-Z0-9] with limit 400 characters
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input"></param>
        /// <returns></returns>
        public string Filter_TextWithNumbers(string _input)
        {
            return Filter_TextWithNumbers(_input, 400);
        }

        /// <summary>
        /// Get text with numbers and dash [A-Za-z0-9-_]
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="_limit">Number of characters</param>
        /// <returns></returns>
        public string Filter_TextWithNumbersAndDash(string _input, int _limit)
        {
            string _return = "";

            _return = Filter_RemoveHtmlTag(_input);
            _return = FilterRegular.RegularReplace(_return, PatternTextWithNumbersAndDash, ReplaceType.Empty);

            if (_return.Length <= _limit)
                return _return;

            return HttpContext.Current.Server.HtmlEncode(_return);
        }

        /// <summary>
        /// Get text with numbers and dash [A-Za-z0-9-_] with limit 50 characters
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input">Number of characters</param>
        /// <returns></returns>
        public string Filter_TextWithNumbersAndDash(string _input)
        {
            return Filter_TextWithNumbersAndDash(_input, 50);
        }

        /// <summary>
        /// Get Text With Numbers And Special Characters Few [a-zA-Z0-9-_.,?/\()*&amp;%$@!&#39;&quot;;:]
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="_limit">Number of characters</param>
        /// <returns></returns>
        public string Filter_TextWithNumbersAndSpecialCharactersFew(string _input, int _limit)
        {
            string _return = "";

            _return = Filter_RemoveHtmlTag(_input);
            _return = FilterRegular.RegularReplace(_return, PatternTextWithNumbersAndSpecialCharactersFew, ReplaceType.Empty);

            //_return = HttpContext.Current.Server.HtmlEncode(_return);

            if (_return.Length > _limit)
                _return = _return.Substring(0, _limit - 1);

            return _return;
        }

        /// <summary>
        /// Get Text With Numbers And Special Characters Few [a-zA-Z0-9-_.,?/\()*&amp;%$@!&#39;&quot;;:] with limit 25 characters
        /// Delete all HTML tag &lt;...&gt; &lt;.../&gt;
        /// </summary>
        /// <param name="_input"></param>
        /// <returns></returns>
        public string Filter_TextWithNumbersAndSpecialCharactersFew(string _input)
        {
            return Filter_TextWithNumbersAndSpecialCharactersFew(_input, 50);
        }

        /// <summary>
        /// Get Text With Numbers And Special Characters All [a-zA-Z0-9~!@#$%^&amp;*()-_=+[];:&#39;&quot;,./?{}\|&lt;&gt;]
        /// Delete tags : b, strong, i, u, ul, ol, li, h1, h2, h3, h4, h5, h6, font, span, div, table, th, thead, tr, td, tfoot, blockquote, tbody, embed, html, head, body, form, a, img, p, br, hr, label, caption, dl, dt, dd
        /// </summary>
        /// <param name="_input"></param>
        /// <param name="_limit">Number of characters</param>
        /// <returns></returns>
        public string Filter_TextWithNumbersAndSpecialCharactersAll(string _input, int _limit)
        {
            string _return = "";

            _return = FilterRegular.RegularReplace(_input, PatternHtml, ReplaceType.Empty);
            _return = FilterRegular.RegularReplace(_input, PatternHtml2, ReplaceType.Empty);
            _return = FilterRegular.RegularReplace(_return, PatternTextWithNumbersAndSpecialCharactersAll, ReplaceType.Empty);

            if (_return.Length <= _limit)
                return _return;

            return HttpContext.Current.Server.HtmlDecode(_return);
        }

        /// <summary>
        /// Get Text With Numbers And Special Characters All [a-zA-Z0-9~!@#$%^&amp;*()-_=+[];:&#39;&quot;,./?{}\|&lt;&gt;] with limit 50 characters
        /// Delete tags : b, strong, i, u, ul, ol, li, h1, h2, h3, h4, h5, h6, font, span, div, table, th, thead, tr, td, tfoot, blockquote, tbody, embed, html, head, body, form, a, img, p, br, hr, label, caption, dl, dt, dd
        /// </summary>
        /// <param name="_input"></param>
        /// <returns></returns>
        public string Filter_TextWithNumbersAndSpecialCharactersAll(string _input)
        {
            return Filter_TextWithNumbersAndSpecialCharactersAll(_input, 50);
        }

        public string Filter_NonPrintCharacters(string _input)
        {
            string _return = "";

            _return = FilterRegular.RegularReplace(_input, PatternHtml2, ReplaceType.Empty);
            _return = FilterRegular.RegularReplace(_return, new string[] { @"([\x00-\x1F]+)" }, ReplaceType.Empty);

            return _return;
        }
    }
}