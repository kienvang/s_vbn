using System;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace Library.Tools
{
  public class UnicodeConversion
  {
    /// <summary>
    /// Method to create an instance of FacilityManager
    /// </summary>
    /// <returns>An instant of FacilityManager class</returns>
    public static UnicodeConversion CreateInstant()
    {
      return new UnicodeConversion();
    }

    public string GetStringId(string Text)
    {
      string id = CleanUpkeywordToFolder(Text).Trim();
      id = id.Replace(" ", "-").Replace("--", "-").ToLower();
      return id;
    }

    public string GetStringId(string Text, int LimitCharacters)
    {
      string id = GetStringId(Text);
      if (id.Length > LimitCharacters)
        id = id.Substring(0, LimitCharacters).Trim();
      return id;
    }


    // Instance variable

    /**
    *  TCVN-to-Unicode conversion
    *
    */
    public String UnicodeToUnicode(String strTextIn)
    {
      StringBuilder strB = new StringBuilder(strTextIn);
      string[] Unicode_Char = { "\u00E1", "\u00E0", "\u1EA3", "\u00E3", "\u1EA1", "\u0103", "\u1EAF", "\u1EB1", "\u1EB3", "\u1EB5", "\u1EB7", "\u00E2", "\u1EA5", "\u1EA7", "\u1EA9", "\u1EAB", "\u1EAD", "\u00E9", "\u00E8", "\u1EBB", "\u1EBD", "\u1EB9", "\u00EA", "\u1EBF", "\u1EC1", "\u1EC3", "\u1EC5", "\u1EC7", "\u00ED", "\u00EC", "\u1EC9", "\u0129", "\u1ECB", "\u00F3", "\u00F2", "\u1ECF", "\u00F5", "\u1ECD", "\u00F4", "\u1ED1", "\u1ED3", "\u1ED5", "\u1ED7", "\u1ED9", "\u01A1", "\u1EDB", "\u1EDD", "\u1EDF", "\u1EE1", "\u1EE3", "\u00FA", "\u00F9", "\u1EE7", "\u0169", "\u1EE5", "\u01B0", "\u1EE9", "\u1EEB", "\u1EED", "\u1EEF", "\u1EF1", "\u00FD", "\u1EF3", "\u1EF7", "\u1EF9", "\u1EF5", "\u0111" };
      string[] Unicode_Cap = { "\u00C1", "\u00C0", "\u1EA2", "\u00C3", "\u1EA0", "\u0102", "\u1EAE", "\u1EB0", "\u1EB2", "\u1EB4", "\u1EB6", "\u00C2", "\u1EA4", "\u1EA6", "\u1EA8", "\u1EAA", "\u1EAC", "\u00C9", "\u00C8", "\u1EBA", "\u1EBC", "\u1EB8", "\u00CA", "\u1EBE", "\u1EC0", "\u1EC2", "\u1EC4", "\u1EC6", "\u00CD", "\u00CC", "\u1EC8", "\u0128", "\u1ECA", "\u00D3", "\u00D2", "\u1ECE", "\u00D5", "\u1ECC", "\u00D4", "\u1ED0", "\u1ED2", "\u1ED4", "\u1ED6", "\u1ED8", "\u01A0", "\u1EDA", "\u1EDC", "\u1EDE", "\u1EE0", "\u1EE2", "\u00DA", "\u00D9", "\u1EE6", "\u0168", "\u1EE4", "\u01AF", "\u1EE8", "\u1EEA", "\u1EEC", "\u1EEE", "\u1EF0", "\u00DD", "\u1EF2", "\u1EF6", "\u1EF8", "\u1EF4", "\u0110" };
      string[] Unicode_Char_Yahoo = { "&#225", "&#224", "&#7843", "&#227", "&#7841", "&#259", "&#7855", "&#7857", "&#7859", "&#7861", "&#7863", "&#226", "&#7845", "&#7847", "&#7849", "&#7851", "&#7853", "&#233", "&#232", "&#7867", "&#7869", "&#7865", "&#234", "&#7871", "&#7873", "&#7875", "&#7877", "&#7879", "&#237", "&#236", "&#7881", "&#297", "&#7883", "&#243", "&#242", "&#7887", "&#245", "&#7885", "&#244", "&#7889", "&#7891", "&#7893", "&#7895", "&#7897", "&#417", "&#7899", "&#7901", "&#7903", "&#7905", "&#7907", "&#250", "&#249", "&#7911", "&#361", "&#7909", "&#432", "&#7913", "&#7915", "&#7917", "&#7919", "&#7921", "&#253", "&#7923", "&#7927", "&#7929", "&#7925", "&#273" };
      string[] Unicode_Cap_Yahoo = { "&#193", "&#192", "&#7842", "&#195", "&#7840", "&#258", "&#7854", "&#7856", "&#7858", "&#7860", "&#7862", "&#194", "&#7844", "&#7846", "&#7848", "&#7850", "&#7852", "&#201", "&#200", "&#7866", "&#7868", "&#7864", "&#202", "&#7870", "&#7872", "&#7874", "&#7876", "&#7878", "&#205", "&#204", "&#7880", "&#296", "&#7882", "&#211", "&#210", "&#7886", "&#213", "&#7884", "&#212", "&#7888", "&#7890", "&#7892", "&#7894", "&#7896", "&#416", "&#7898", "&#7900", "&#7902", "&#7904", "&#7906", "&#218", "&#217", "&#7910", "&#360", "&#7908", "&#431", "&#7912", "&#7914", "&#7916", "&#7918", "&#7920", "&#221", "&#7922", "&#7926", "&#7928", "&#7924", "&#272" };
      for (int i = 0; i < Unicode_Char.Length; i++)
      {
        strB.Replace(Unicode_Char[i], Unicode_Char_Yahoo[i] + ";");
      }
      for (int i = 0; i < Unicode_Char.Length; i++)
      {
        strB.Replace(Unicode_Cap[i], Unicode_Cap_Yahoo[i] + ";");
      }

      return strB.ToString();
    }

    public String UnicodeToUnicodebyBinh(String strTextIn)
    {
      StringBuilder strB = new StringBuilder(strTextIn);
      string[] Unicode_Char = { "\u00E1", "\u00E0", "\u1EA3", "\u00E3", "\u1EA1", "\u0103", "\u1EAF", "\u1EB1", "\u1EB3", "\u1EB5", "\u1EB7", "\u00E2", "\u1EA5", "\u1EA7", "\u1EA9", "\u1EAB", "\u1EAD", "\u00E9", "\u00E8", "\u1EBB", "\u1EBD", "\u1EB9", "\u00EA", "\u1EBF", "\u1EC1", "\u1EC3", "\u1EC5", "\u1EC7", "\u00ED", "\u00EC", "\u1EC9", "\u0129", "\u1ECB", "\u00F3", "\u00F2", "\u1ECF", "\u00F5", "\u1ECD", "\u00F4", "\u1ED1", "\u1ED3", "\u1ED5", "\u1ED7", "\u1ED9", "\u01A1", "\u1EDB", "\u1EDD", "\u1EDF", "\u1EE1", "\u1EE3", "\u00FA", "\u00F9", "\u1EE7", "\u0169", "\u1EE5", "\u01B0", "\u1EE9", "\u1EEB", "\u1EED", "\u1EEF", "\u1EF1", "\u00FD", "\u1EF3", "\u1EF7", "\u1EF9", "\u1EF5", "\u0111" };
      string[] Unicode_Cap = { "\u00C1", "\u00C0", "\u1EA2", "\u00C3", "\u1EA0", "\u0102", "\u1EAE", "\u1EB0", "\u1EB2", "\u1EB4", "\u1EB6", "\u00C2", "\u1EA4", "\u1EA6", "\u1EA8", "\u1EAA", "\u1EAC", "\u00C9", "\u00C8", "\u1EBA", "\u1EBC", "\u1EB8", "\u00CA", "\u1EBE", "\u1EC0", "\u1EC2", "\u1EC4", "\u1EC6", "\u00CD", "\u00CC", "\u1EC8", "\u0128", "\u1ECA", "\u00D3", "\u00D2", "\u1ECE", "\u00D5", "\u1ECC", "\u00D4", "\u1ED0", "\u1ED2", "\u1ED4", "\u1ED6", "\u1ED8", "\u01A0", "\u1EDA", "\u1EDC", "\u1EDE", "\u1EE0", "\u1EE2", "\u00DA", "\u00D9", "\u1EE6", "\u0168", "\u1EE4", "\u01AF", "\u1EE8", "\u1EEA", "\u1EEC", "\u1EEE", "\u1EF0", "\u00DD", "\u1EF2", "\u1EF6", "\u1EF8", "\u1EF4", "\u0110" };

      string[] Unicode_Char_Yahoo = { "&aacute;", "&agrave;", "&#7843;", "&atilde;", "&#7841;", "&#259;", "&#7855;", "&#7857;", "&#7859;", "&#7861;", "&#7863;", "&acirc;", "&#7845;", "&#7847;", "&#7849;", "&#7851;", "&#7853;", "&eacute;", "&eacute;", "&#7867;", "&#7869;", "&#7865;", "&ecirc;", "&#7871;", "&#7873;", "&#7875;", "&#7871;", 
                
                "&#7879;", "&iacute;", "&igrave;", "&#7881;", "&#297;", "&#7883;", "&oacute;", "&ograve;", "&#7887;", "&otilde;", "&#7885;", "&ocirc;", "&#7889;", 
                "&#7891;", "&#7893;", "&#7895;", "&#7897;", "&#417;", "&#7899;", "&#7901;", "&#7903;", "&#7905;",
                "&#7907;", "&uacute;", "&ugrave;", "&#7911;", "&#361;", 
                "&#7909;", "&#432;", "&#7913;", "&#7915;", "&#7917;", "&#7919;", "&#7921;", "&yacute;", "&#7923;", "&#7927;", 
                "&#7929;", "&#7925;", "&#273;" };
      string[] Unicode_Cap_Yahoo = { "&Aacute;", "&Agrave;", "&#7842;", "&Atilde;", "&#7840;", 
                "&#258;", "&#7854; ", "&#7856;", "&#7858;", "&#7860;", "&#7862;"
                , "&Acirc;", "&#7844;", "&#7846;", "&#7848;",
                "&#7850;", "&#7852;", "&Eacute;"
                , "&Egrave;", "&#7866;",
                "&#7868;", "&#7864;", "&Ecirc;", "&#7870;", "&#7872;", "&#7874;", "&#7876;"
                , "&#7878; ", "&Iacute;"
                , "&Iacute;", "&#7880", "&#296;", " &#7882;", "&Oacute;", "&Ograve;", 
                "&#7886;", "&Otilde;", "&#7884;", "&Ocirc;", "&#7888;", "&#7890;"
                , "&#7892;", "&#7894;", "&#7896;", "&#416;", "&#7898;", "&#7900;", "&#7902;", "&#7904;", "&#7906;"
                , "&Uacute;", "&Ugrave;", "&#7910;", "&#360;", "&#7908;",
                "&#431;", "&#7912;", "&#7914;", "&#7916;", 
                "&#7918;", "&#7920;", "&Yacute;", "&#7922;", "&#7926;", "&#7928;", "&#7924;", "&#272;" };

      for (int i = 0; i < Unicode_Char.Length; i++)
      {
        strB.Replace(Unicode_Char[i], Unicode_Char_Yahoo[i]);
      }
      for (int i = 0; i < Unicode_Char.Length; i++)
      {
        strB.Replace(Unicode_Cap[i], Unicode_Cap_Yahoo[i]);
      }

      return strB.ToString();
    }




    /**
    *  TCVN-to-Unicode conversion
    *
    */
    public String TCVNtoUnicode(String strTCVN)
    {
      StringBuilder strB = new StringBuilder(strTCVN);
      char[] TCVN_char = {'\u00FC', '\u00FB', '\u00FE', '\u00FA', '\u00F9', '\u00F7', '\u00F6',
													 '\u00F5', '\u00F8', '\u00F1', '\u00F4', '\u00EE', '\u00EC', '\u00EB', '\u00EA', '\u00ED',
													 '\u00E9', '\u00E7', '\u00E6', '\u00E5', '\u00E8', '\u00E1', '\u00E4', '\u00DE', '\u00D8',
													 '\u00D6', '\u00D4', '\u00D3', '\u00D2', '\u00D5', '\u00CF', '\u00CE', '\u00D1', '\u00C6',
													 '\u00BD', '\u00BC', '\u00AB', '\u00BE', '\u00CB', '\u00C9', '\u00C8', '\u00C7', '\u00CA',
													 '\u00B6', '\u00B9', '\u00AD', '\u00A6', '\u00AC', '\u00A5', '\u00F2', '\u00DC', '\u00AE',
													 '\u00A8', '\u00A1', '\u00F3', '\u00EF', '\u00E2', '\u00BB', '\u00E3', '\u00DF', '\u00DD',
													 '\u00D7', '\u00AA', '\u00D0', '\u00CC', '\u00B7', '\u00A9', '\u00B8', '\u00B5', '\u00A4',
													 '\u00A7', '\u00A3', '\u00A2'};
      char[] Unicode_char = {'\u1EF9', '\u1EF7', '\u1EF5', '\u1EF3', '\u1EF1', '\u1EEF', '\u1EED',
															'\u1EEB', '\u1EE9', '\u1EE7', '\u1EE5', '\u1EE3', '\u1EE1', '\u1EDF', '\u1EDD', '\u1EDB',
															'\u1ED9', '\u1ED7', '\u1ED5', '\u1ED3', '\u1ED1', '\u1ECF', '\u1ECD', '\u1ECB', '\u1EC9',
															'\u1EC7', '\u1EC5', '\u1EC3', '\u1EC1', '\u1EBF', '\u1EBD', '\u1EBB', '\u1EB9', '\u1EB7',
															'\u1EB5', '\u1EB3', '\u00F4', '\u1EAF', '\u1EAD', '\u1EAB', '\u1EA9', '\u1EA7', '\u1EA5',
															'\u1EA3', '\u1EA1', '\u01B0', '\u01AF', '\u01A1', '\u01A0', '\u0169', '\u0129', '\u0111',
															'\u0103', '\u0102', '\u00FA', '\u00F9', '\u00F5', '\u1EB1', '\u00F3', '\u00F2', '\u00ED',
															'\u00EC', '\u00EA', '\u00E9', '\u00E8', '\u00E3', '\u00E2', '\u00E1', '\u00E0', '\u00D4',
															'\u0110', '\u00CA', '\u00C2'};

      for (int i = 0; i < TCVN_char.Length; i++)
      {
        strB.Replace(TCVN_char[i], Unicode_char[i]);
      }

      string[] TCVN_cap = {"\u0041\u00E0", "\u0041\u1EA3", "\u0041\u00E3", "\u0041\u00E1",
														"\u0041\u1EA1", "\u0045\u00E8", "\u0045\u1EBB", "\u0045\u1EBD", "\u0045\u00E9",
														"\u0045\u1EB9", "\u0049\u00EC", "\u0049\u1EC9", "\u0049\u0129", "\u0049\u00ED",
														"\u0049\u1ECB", "\u004F\u00F2", "\u004F\u1ECF", "\u004F\u00F5", "\u004F\u00F3",
														"\u004F\u1ECD", "\u0055\u00F9", "\u0055\u1EE7", "\u0055\u0169", "\u0055\u00FA",
														"\u0055\u1EE5", "\u0059\u1EF3", "\u0059\u1EF7", "\u0059\u1EF9", "\u0059\u00FD",
														"\u0059\u1EF5", "\u0102\u1EB1", "\u0102\u1EB3", "\u0102\u1EB5", "\u0102\u1EAF",
														"\u0102\u1EB7", "\u00C2\u1EA7", "\u00C2\u1EA9", "\u00C2\u1EAB", "\u00C2\u1EA5",
														"\u00C2\u1EAD", "\u00CA\u1EC1", "\u00CA\u1EC3", "\u00CA\u1EC5", "\u00CA\u1EBF",
														"\u00CA\u1EC7", "\u00D4\u1ED3", "\u00D4\u1ED5", "\u00D4\u1ED7", "\u00D4\u1ED1",
														"\u00D4\u1ED9", "\u01A0\u1EDD", "\u01A0\u1EDF", "\u01A0\u1EE1", "\u01A0\u1EDB",
														"\u01A0\u1EE3", "\u01AF\u1EEB", "\u01AF\u1EED", "\u01AF\u1EEF", "\u01AF\u1EE9",
														"\u01AF\u1EF1"};
      string[] Unicode_cap = {"\u00C0", "\u1EA2", "\u00C3", "\u00C1", "\u1EA0", "\u00C8",
															 "\u1EBA", "\u1EBC", "\u00C9", "\u1EB8", "\u00CC", "\u1EC8", "\u0128", "\u00CD", "\u1ECA",
															 "\u00D2", "\u1ECE", "\u00D5", "\u00D3", "\u1ECC", "\u00D9", "\u1EE6", "\u0168", "\u00DA",
															 "\u1EE4", "\u1EF2", "\u1EF6", "\u1EF8", "\u00DD", "\u1EF4", "\u1EB0", "\u1EB2", "\u1EB4",
															 "\u1EAE", "\u1EB6", "\u1EA6", "\u1EA8", "\u1EAA", "\u1EA4", "\u1EAC", "\u1EC0", "\u1EC2",
															 "\u1EC4", "\u1EBE", "\u1EC6", "\u1ED2", "\u1ED4", "\u1ED6", "\u1ED0", "\u1ED8", "\u1EDC",
															 "\u1EDE", "\u1EE0", "\u1EDA", "\u1EE2", "\u1EEA", "\u1EEC", "\u1EEE", "\u1EE8", "\u1EF0"};

      for (int i = 0; i < TCVN_cap.Length; i++)
      {
        strB.Replace(TCVN_cap[i], Unicode_cap[i]);
      }

      return strB.ToString();
    }

    /**
    *  Unicode-to-TCVN conversion
    *
    */
    public String UnicodetoTCVN(String strUnicode)
    {
      StringBuilder strB = new StringBuilder(strUnicode);
      char[] TCVN_char = {'\u00FC', '\u00FB', '\u00FE', '\u00FA', '\u00F9', '\u00F7', '\u00F6',
													 '\u00F5', '\u00F8', '\u00F1', '\u00F4', '\u00EE', '\u00EC', '\u00EB', '\u00EA', '\u00ED',
													 '\u00E9', '\u00E7', '\u00E6', '\u00E5', '\u00E8', '\u00E1', '\u00E4', '\u00DE', '\u00D8',
													 '\u00D6', '\u00D4', '\u00D3', '\u00D2', '\u00D5', '\u00CF', '\u00CE', '\u00D1', '\u00C6',
													 '\u00BD', '\u00BC', '\u00AB', '\u00BE', '\u00CB', '\u00C9', '\u00C8', '\u00C7', '\u00CA',
													 '\u00B6', '\u00B9', '\u00AD', '\u00A6', '\u00AC', '\u00A5', '\u00F2', '\u00DC', '\u00AE',
													 '\u00A8', '\u00A1', '\u00F3', '\u00EF', '\u00E2', '\u00BB', '\u00E3', '\u00DF', '\u00DD',
													 '\u00D7', '\u00AA', '\u00D0', '\u00CC', '\u00B7', '\u00A9', '\u00B8', '\u00B5', '\u00A4',
													 '\u00A7', '\u00A3', '\u00A2'};
      char[] Unicode_char = {'\u1EF9', '\u1EF7', '\u1EF5', '\u1EF3', '\u1EF1', '\u1EEF', '\u1EED',
															'\u1EEB', '\u1EE9', '\u1EE7', '\u1EE5', '\u1EE3', '\u1EE1', '\u1EDF', '\u1EDD', '\u1EDB',
															'\u1ED9', '\u1ED7', '\u1ED5', '\u1ED3', '\u1ED1', '\u1ECF', '\u1ECD', '\u1ECB', '\u1EC9',
															'\u1EC7', '\u1EC5', '\u1EC3', '\u1EC1', '\u1EBF', '\u1EBD', '\u1EBB', '\u1EB9', '\u1EB7',
															'\u1EB5', '\u1EB3', '\u00F4', '\u1EAF', '\u1EAD', '\u1EAB', '\u1EA9', '\u1EA7', '\u1EA5',
															'\u1EA3', '\u1EA1', '\u01B0', '\u01AF', '\u01A1', '\u01A0', '\u0169', '\u0129', '\u0111',
															'\u0103', '\u0102', '\u00FA', '\u00F9', '\u00F5', '\u1EB1', '\u00F3', '\u00F2', '\u00ED',
															'\u00EC', '\u00EA', '\u00E9', '\u00E8', '\u00E3', '\u00E2', '\u00E1', '\u00E0', '\u00D4',
															'\u0110', '\u00CA', '\u00C2'};

      for (int i = 0; i < TCVN_char.Length; i++)
      {
        strB.Replace(Unicode_char[i], TCVN_char[i]);
      }

      string[] TCVN_cap = {"\u0041\u00E0", "\u0041\u1EA3", "\u0041\u00E3", "\u0041\u00E1",
														"\u0041\u1EA1", "\u0045\u00E8", "\u0045\u1EBB", "\u0045\u1EBD", "\u0045\u00E9",
														"\u0045\u1EB9", "\u0049\u00EC", "\u0049\u1EC9", "\u0049\u0129", "\u0049\u00ED",
														"\u0049\u1ECB", "\u004F\u00F2", "\u004F\u1ECF", "\u004F\u00F5", "\u004F\u00F3",
														"\u004F\u1ECD", "\u0055\u00F9", "\u0055\u1EE7", "\u0055\u0169", "\u0055\u00FA",
														"\u0055\u1EE5", "\u0059\u1EF3", "\u0059\u1EF7", "\u0059\u1EF9", "\u0059\u00FD",
														"\u0059\u1EF5", "\u0102\u1EB1", "\u0102\u1EB3", "\u0102\u1EB5", "\u0102\u1EAF",
														"\u0102\u1EB7", "\u00C2\u1EA7", "\u00C2\u1EA9", "\u00C2\u1EAB", "\u00C2\u1EA5",
														"\u00C2\u1EAD", "\u00CA\u1EC1", "\u00CA\u1EC3", "\u00CA\u1EC5", "\u00CA\u1EBF",
														"\u00CA\u1EC7", "\u00D4\u1ED3", "\u00D4\u1ED5", "\u00D4\u1ED7", "\u00D4\u1ED1",
														"\u00D4\u1ED9", "\u01A0\u1EDD", "\u01A0\u1EDF", "\u01A0\u1EE1", "\u01A0\u1EDB",
														"\u01A0\u1EE3", "\u01AF\u1EEB", "\u01AF\u1EED", "\u01AF\u1EEF", "\u01AF\u1EE9",
														"\u01AF\u1EF1"};
      string[] Unicode_cap = {"\u00C0", "\u1EA2", "\u00C3", "\u00C1", "\u1EA0", "\u00C8",
															 "\u1EBA", "\u1EBC", "\u00C9", "\u1EB8", "\u00CC", "\u1EC8", "\u0128", "\u00CD", "\u1ECA",
															 "\u00D2", "\u1ECE", "\u00D5", "\u00D3", "\u1ECC", "\u00D9", "\u1EE6", "\u0168", "\u00DA",
															 "\u1EE4", "\u1EF2", "\u1EF6", "\u1EF8", "\u00DD", "\u1EF4", "\u1EB0", "\u1EB2", "\u1EB4",
															 "\u1EAE", "\u1EB6", "\u1EA6", "\u1EA8", "\u1EAA", "\u1EA4", "\u1EAC", "\u1EC0", "\u1EC2",
															 "\u1EC4", "\u1EBE", "\u1EC6", "\u1ED2", "\u1ED4", "\u1ED6", "\u1ED0", "\u1ED8", "\u1EDC",
															 "\u1EDE", "\u1EE0", "\u1EDA", "\u1EE2", "\u1EEA", "\u1EEC", "\u1EEE", "\u1EE8", "\u1EF0"};

      for (int i = 0; i < TCVN_cap.Length; i++)
      {
        strB.Replace(Unicode_cap[i], TCVN_cap[i]);
      }

      return strB.ToString();
    }


    /**
    *  VIQR-to-Unicode conversion.
    *
    */
    public String VIQRtoUnicode(String strVIQR)
    {
      StringBuilder strB = new StringBuilder(strVIQR);

      // not needed for VIQR
      //			if (rtf)
      //				RTFtoANSI();

      strB.Replace("u*", "u+");
      strB.Replace("U*", "U+");
      strB.Replace("o*", "o+");
      strB.Replace("O*", "O+");
      strB.Replace("Dd", "DD");
      strB.Replace("D-", "DD");
      strB.Replace("d-", "dd");
      strB.Replace('\u0092', '\''); // replace right single quotation mark (\u0092, or \u2019) with apostrophe

      // Attempt to fix the problem with . and ? punctuation marks becoming diacritical marks.
      // This, however, is commented out because it may interfere with correct conversions
      // when a proper name (hence capitalized) instead of a capital letter beginning a sentence is encountered.
      //			strB = new StringBuilder(Regex.Replace(strB.ToString(), "[?\\.]\\s+\\p{Lu}", "\\$0")); // Lu = UppercaseLetter

      // change diacritical marks to punctuation marks if . or ? is 
      // after a vowel which in turn is after any mark `?~'.^(+ae        
      strB = new StringBuilder(Regex.Replace(strB.ToString(), "([`?~'.^(+ae][aeiouy])([?.])", "$1\\$2"));

      string[] VIQR_char = {"y~", "Y~", "y?", "Y?", "y.", "Y.", "y`", "Y`", "u+.", "U+.", "u+~",
														 "U+~", "u+?", "U+?", "u+`", "U+`", "u+'", "U+'", "u?", "U?", "u.", "U.", "o+.", "O+.",
														 "o+~", "O+~", "o+?", "O+?", "o+`", "O+`", "o+'", "O+'", "o^.", "O^.", "o^~", "O^~", "o^?",
														 "O^?", "o^`", "O^`", "o^'", "O^'", "o?", "O?", "o.", "O.", "i.", "I.", "i?", "I?", "e^.",
														 "E^.", "e^~", "E^~", "e^?", "E^?", "e^`", "E^`", "e^'", "E^'", "e~", "E~", "e?", "E?", "e.",
														 "E.", "a(.", "A(.", "a(~", "A(~", "a(?", "A(?", "a(`", "A(`", "a('", "A('", "a^.", "A^.",
														 "a^~", "A^~", "a^?", "A^?", "a^`", "A^`", "a^'", "A^'", "a?", "A?", "a.", "A.", "u+", "U+",
														 "o+", "O+", "u~", "U~", "i~", "I~", "dd", "a(", "A(", "y'", "u'", "u`", "o~", "o^", "o'",
														 "o`", "i'", "i`", "e^", "e'", "e`", "a~", "a^", "a'", "a`", "Y'", "U'", "U`", "O~", "O^",
														 "O'", "O`", "DD", "I'", "I`", "E^", "E'", "E`", "A~", "A^", "A'", "A`"};
      string[] Unicode_char = {"\u1EF9", "\u1EF8", "\u1EF7", "\u1EF6", "\u1EF5", "\u1EF4",
																"\u1EF3", "\u1EF2", "\u1EF1", "\u1EF0", "\u1EEF", "\u1EEE", "\u1EED", "\u1EEC", "\u1EEB",
																"\u1EEA", "\u1EE9", "\u1EE8", "\u1EE7", "\u1EE6", "\u1EE5", "\u1EE4", "\u1EE3", "\u1EE2",
																"\u1EE1", "\u1EE0", "\u1EDF", "\u1EDE", "\u1EDD", "\u1EDC", "\u1EDB", "\u1EDA", "\u1ED9",
																"\u1ED8", "\u1ED7", "\u1ED6", "\u1ED5", "\u1ED4", "\u1ED3", "\u1ED2", "\u1ED1", "\u1ED0",
																"\u1ECF", "\u1ECE", "\u1ECD", "\u1ECC", "\u1ECB", "\u1ECA", "\u1EC9", "\u1EC8", "\u1EC7",
																"\u1EC6", "\u1EC5", "\u1EC4", "\u1EC3", "\u1EC2", "\u1EC1", "\u1EC0", "\u1EBF", "\u1EBE",
																"\u1EBD", "\u1EBC", "\u1EBB", "\u1EBA", "\u1EB9", "\u1EB8", "\u1EB7", "\u1EB6", "\u1EB5",
																"\u1EB4", "\u1EB3", "\u1EB2", "\u1EB1", "\u1EB0", "\u1EAF", "\u1EAE", "\u1EAD", "\u1EAC",
																"\u1EAB", "\u1EAA", "\u1EA9", "\u1EA8", "\u1EA7", "\u1EA6", "\u1EA5", "\u1EA4", "\u1EA3",
																"\u1EA2", "\u1EA1", "\u1EA0", "\u01B0", "\u01AF", "\u01A1", "\u01A0", "\u0169", "\u0168",
																"\u0129", "\u0128", "\u0111", "\u0103", "\u0102", "\u00FD", "\u00FA", "\u00F9", "\u00F5",
																"\u00F4", "\u00F3", "\u00F2", "\u00ED", "\u00EC", "\u00EA", "\u00E9", "\u00E8", "\u00E3",
																"\u00E2", "\u00E1", "\u00E0", "\u00DD", "\u00DA", "\u00D9", "\u00D5", "\u00D4", "\u00D3",
																"\u00D2", "\u0110", "\u00CD", "\u00CC", "\u00CA", "\u00C9", "\u00C8", "\u00C3", "\u00C2",
																"\u00C1", "\u00C0"};

      for (int i = 0; i < VIQR_char.Length; i++)
      {
        strB.Replace(VIQR_char[i], Unicode_char[i]);
      }

      strB.Replace("\\.", ".");
      strB.Replace("\\?", "?");
      strB.Replace("\\d", "d");
      strB.Replace("\\D", "D");
      strB.Replace("\\'", "\'");
      strB.Replace("\\-", "-");
      strB.Replace("\\\\", "\\");

      return strB.ToString();

    }

    /**
    *  VIQR-to-Unicode conversion.
    * Ham nay khong bo ky tu dac biet , Ham UnicodeToASCII2 bo nhung ky tu dac biet
    */
    public String UnicodeToASCII(String strUnicode)
    {
      StringBuilder strB = new StringBuilder(strUnicode);

      string[] Unicode_char = {"\u1EF9", "\u1EF8", "\u1EF7", "\u1EF6", "\u1EF5", "\u1EF4",
																"\u1EF3", "\u1EF2", "\u1EF1", "\u1EF0", "\u1EEF", "\u1EEE", "\u1EED", "\u1EEC", "\u1EEB",
																"\u1EEA", "\u1EE9", "\u1EE8", "\u1EE7", "\u1EE6", "\u1EE5", "\u1EE4", "\u1EE3", "\u1EE2",
																"\u1EE1", "\u1EE0", "\u1EDF", "\u1EDE", "\u1EDD", "\u1EDC", "\u1EDB", "\u1EDA", "\u1ED9",
																"\u1ED8", "\u1ED7", "\u1ED6", "\u1ED5", "\u1ED4", "\u1ED3", "\u1ED2", "\u1ED1", "\u1ED0",
																"\u1ECF", "\u1ECE", "\u1ECD", "\u1ECC", "\u1ECB", "\u1ECA", "\u1EC9", "\u1EC8", "\u1EC7",
																"\u1EC6", "\u1EC5", "\u1EC4", "\u1EC3", "\u1EC2", "\u1EC1", "\u1EC0", "\u1EBF", "\u1EBE",
																"\u1EBD", "\u1EBC", "\u1EBB", "\u1EBA", "\u1EB9", "\u1EB8", "\u1EB7", "\u1EB6", "\u1EB5",
																"\u1EB4", "\u1EB3", "\u1EB2", "\u1EB1", "\u1EB0", "\u1EAF", "\u1EAE", "\u1EAD", "\u1EAC",
																"\u1EAB", "\u1EAA", "\u1EA9", "\u1EA8", "\u1EA7", "\u1EA6", "\u1EA5", "\u1EA4", "\u1EA3",
																"\u1EA2", "\u1EA1", "\u1EA0", "\u01B0", "\u01AF", "\u01A1", "\u01A0", "\u0169", "\u0168",
																"\u0129", "\u0128", "\u0111", "\u0103", "\u0102", "\u00FD", "\u00FA", "\u00F9", "\u00F5",
																"\u00F4", "\u00F3", "\u00F2", "\u00ED", "\u00EC", "\u00EA", "\u00E9", "\u00E8", "\u00E3",
																"\u00E2", "\u00E1", "\u00E0", "\u00DD", "\u00DA", "\u00D9", "\u00D5", "\u00D4", "\u00D3",
																"\u00D2", "\u0110", "\u00CD", "\u00CC", "\u00CA", "\u00C9", "\u00C8", "\u00C3", "\u00C2",
																"\u00C1", "\u00C0"};
      string[] Ascii_char = {"y", "Y", "y", "Y", "y", "Y", "y", "Y", "u", "U", "u",
														 "U", "u", "U", "u", "U", "u", "U", "u", "U", "u", "U", "o", "O",
														 "o", "O", "o", "O", "o", "O", "o", "O", "o", "O", "o", "O", "o",
														 "O", "o", "O", "o", "O", "o", "O", "o", "O", "i", "I", "i", "I", "e",
														 "E", "e", "E", "e", "E", "e", "E", "e", "E", "e", "E", "e", "E", "e",
														 "E", "a", "A", "a", "A", "a", "A", "a", "A", "a", "A", "a", "A",
														 "a", "A", "a", "A", "a", "A", "a", "A", "a", "A", "a", "A", "u", "U",
														 "o", "O", "u", "U", "i", "I", "d", "a", "A", "y", "u", "u", "o", "o", "o",
														 "o", "i", "i", "e", "e", "e", "a", "a", "a", "a", "Y", "U", "U", "O", "O",
														 "O", "O", "D", "I", "I", "E", "E", "E", "A", "A", "A", "A"};

      for (int i = 0; i < Ascii_char.Length; i++)
      {
        strB.Replace(Unicode_char[i], Ascii_char[i]);
      }

      //			strB.Replace("\\.", ".");
      //			strB.Replace("\\?", "?");
      //			strB.Replace("\\d", "d");
      //			strB.Replace("\\D", "D");
      //			strB.Replace("\\'", "\'");
      //			strB.Replace("\\-", "-");
      //			strB.Replace("\\\\", "\\");

      return strB.ToString();
    }
    /**
*  Windows_characters conversion.
*
*/
    public string WindowscharactersTohtml(string stringvalues)
    {
      StringBuilder strB = new StringBuilder(stringvalues);
      string[] Windows_characters = { "\u201A", "\u0192", "\u201E", "\u2026", "\u2020", "\u2021", "\u02C6", "\u2030", "\u0160", "\u2039", "\u0152", "\u2018", "\u2019", "\u201C", "\u201D", "\u2022", "\u2013", "\u2014", "\u02DC", "\u2122", "\u0161", "\u203A", "\u0153", "\u0178" };
      string[] Windows_characters_html = { "&#8218;", "&#402;", "&#8222;", "&#8230;", "&#8224;", "&#8225;", "&#710;", "&#8240;", "&#352;", "&#8249;", "&#338;", "&#8216;", "&#8217;", "&#8220;", "&#8221;", "&#8226;", "&#8211;", "&#8212;", "&#732;", "&#8482;", "&#353;", "&#8250;", "&#339;", "&#376;" };
      for (int i = 0; i < Windows_characters.Length; i++)
      {
        strB.Replace(Windows_characters[i], Windows_characters_html[i]);
      }
      return strB.ToString();
    }
    public string RemoveWindowscharacters(string stringvalues)
    {
      StringBuilder strB = new StringBuilder(stringvalues);
      string[] Windows_characters = { "\u201A", "\u0192", "\u201E", "\u2026", "\u2020", "\u2021", "\u02C6", "\u2030", "\u0160", "\u2039", "\u0152", "\u2018", "\u2019", "\u201C", "\u201D", "\u2022", "\u2013", "\u2014", "\u02DC", "\u2122", "\u0161", "\u203A", "\u0153", "\u0178" };
      for (int i = 0; i < Windows_characters.Length; i++)
      {
        strB.Replace(Windows_characters[i], " ");
      }
      return strB.ToString();
    }

    public string CleanUpkeywordToFolder(string _string)
    {
      string sResult = "";
      _string = _string.Trim().Replace(" ", "-");
      _string = _string.Trim().Replace("%20", "-");
      _string = _string.Trim().Replace("--", "-");
      string sInput = UnicodeToASCII(_string);
      sInput = WindowscharactersTohtml(sInput);
      sInput = UnicodeToUnicodebyBinh(sInput);
      sInput = RemoveWindowscharacters(sInput);
      char[] arrChar = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                            '0','1','2','3','4','5','6','7','8','9',
                            '_', '-'};
      foreach (char c in sInput)
      {
        for (short i = 0; i < arrChar.Length; i++)
          if (c.Equals(arrChar[i]))
          {
            sResult += c;
            break;
          }
      }
      return sResult;

    }

    public string UnicodeToASCII2(string _string)
    {
      string sResult = "";
      //_string = _string.Trim().Replace(" ", "-");
      //_string = _string.Trim().Replace("%20", "-");
      //_string = _string.Trim().Replace("--", "-");
      string sInput = UnicodeToASCII(_string);
      sInput = WindowscharactersTohtml(sInput);
      sInput = UnicodeToUnicodebyBinh(sInput);
      sInput = RemoveWindowscharacters(sInput);
      char[] arrChar = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                            '0','1','2','3','4','5','6','7','8','9',
                            '_', '-', ' '};
      foreach (char c in sInput)
      {
        for (short i = 0; i < arrChar.Length; i++)
          if (c.Equals(arrChar[i]))
          {
            sResult += c;
            break;
          }
      }
      return sResult;

    }

    /// <summary>
    /// Remove all comments and html tags
    /// </summary>
    public string GetTextFromHtml(string html)
    {
      if (string.IsNullOrEmpty(html))
        return string.Empty;
      // s/<[a-zA-Z\/][^>]*>//g   - http://networking.ringofsaturn.com/Web/removetags.php
      // <!*[^<>]*>               - http://regexlib.com/RETester.aspx?regexp_id=1898
      // </?[a-z][a-z0-9]*[^<>]*> - http://regexlib.com/REDetails.aspx?regexp_id=1895
      // <[^>]*>                  - http://www.4guysfromrolla.com/webtech/073000-1.shtml    - Sunday, July 30, 2000
      html = Regex.Replace(html, @"<!*[^<>]*>", "", RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"</?[a-z][a-z0-9]*[^<>]*>", "", RegexOptions.IgnoreCase);
      return html.Trim();
    }
    public string GetTextFromHtmlByForum(string html)
    {
      if (string.IsNullOrEmpty(html))
        return string.Empty;

      string pattern = @"[\[\w\]].+[\[/\w\w]]";
      Regex rgx = new Regex(pattern);
      html = rgx.Replace(html, string.Empty);
      pattern = @"[\[\w+.\]].+[\[/\w\w]]";
      rgx = new Regex(pattern);
      html = rgx.Replace(html, string.Empty);
      html = Regex.Replace(html, @"<!*[^<>]*>", "", RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"</?[a-z][a-z0-9]*[^<>]*>", "", RegexOptions.IgnoreCase);
      return html.Trim();

    }


    /// <summary>
    /// Remove all script tag
    /// </summary>
    public string RemoveHtmlTag_Script(string html)
    {
      // http://haacked.com/archive/2004/10/25/usingregularexpressionstomatchhtml.aspx
      html = Regex.Replace(html, @"<script(.*?)>((.|\n)*?)(<\/script>)", String.Empty, RegexOptions.IgnoreCase);
      return html.Trim();
    }

    /// <summary>
    /// Remove all style and link tag that related to CSS
    /// </summary>
    public string RemoveHtmlTag_Style(string html)
    {
      // http://haacked.com/archive/2004/10/25/usingregularexpressionstomatchhtml.aspx
      html = Regex.Replace(html, @"<style(.*?)>((.|\n)*?)(<\/style>)", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<link(.*?)>((.|\n)*?)(<\/link>)", String.Empty, RegexOptions.IgnoreCase);
      return html.Trim();
    }

    public string CleanUpEmailBody(string html)
    {
      html = Regex.Replace(html, @"<html(.*?)>", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"</html>", String.Empty);
      html = Regex.Replace(html, @"<head(.*?)>((.|\n)*?)(<\/head>)", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<meta(.*?)>((.|\n)*?)(<\/meta>)", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<link(.*?)>((.|\n)*?)(<\/link>)", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<style(.*?)>((.|\n)*?)(<\/style>)", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<script(.*?)>((.|\n)*?)(<\/script>)", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<body(.*?)>", String.Empty, RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"</body>", String.Empty);

      return html;
    }

    private string FixWeirdCharacters(string html)
    {
      //NameValueCollection nvc = new NameValueCollection();
      Hashtable nvc = new Hashtable();
      nvc.Add("&Agrave;", "À");
      nvc.Add("&Aacute;", "Á");
      nvc.Add("&Acirc;", "Â");
      nvc.Add("&Atilde;", "Ã");
      nvc.Add("&Ccedil;", "Ç");
      nvc.Add("&Egrave;", "È");
      nvc.Add("&Eacute;", "É");
      nvc.Add("&Ecirc;", "Ê");
      nvc.Add("&Igrave;", "Ì");
      nvc.Add("&Iacute;", "Í");
      nvc.Add("&Icirc;", "Î");
      nvc.Add("&ETH;", "Ð");
      nvc.Add("&Ograve;", "Ò");
      nvc.Add("&Oacute;", "Ó");
      nvc.Add("&Ocirc;", "Ô");
      nvc.Add("&Otilde;", "Õ");
      nvc.Add("&Ugrave;", "Ù");
      nvc.Add("&Uacute;", "Ú");
      nvc.Add("&Yacute;", "Ý");
      nvc.Add("&agrave;", "à");
      nvc.Add("&aacute;", "á");
      nvc.Add("&acirc;", "â");
      nvc.Add("&atilde;", "ã");
      nvc.Add("&aring;", "å");
      nvc.Add("&ccedil;", "ç");
      nvc.Add("&egrave;", "è");
      nvc.Add("&eacute;", "é");
      nvc.Add("&ecirc;", "ê");
      nvc.Add("&igrave;", "ì");
      nvc.Add("&iacute;", "í");
      nvc.Add("&icirc;", "î");
      nvc.Add("&ograve;", "ò");
      nvc.Add("&oacute;", "ó");
      nvc.Add("&ocirc;", "ô");
      nvc.Add("&otilde;", "õ");
      nvc.Add("&ugrave;", "ù");
      nvc.Add("&uacute;", "ú");
      nvc.Add("&ucirc;", "û");
      nvc.Add("&yacute;", "ý");
      foreach (string key in nvc.Keys)
      {
        html = html.Replace(key, nvc[key].ToString());
      }
      return html;
    }

    /*
    public string MakeSafe(string value)
    {
      return value
          .Replace("&Agrave;", "À")
          .Replace("&Aacute;", "Á")
          .Replace("&Acirc;", "Â")
          .Replace("&Atilde;", "Ã")
          .Replace("&Ccedil;", "Ç")
          .Replace("&Egrave;", "È")
          .Replace("&Eacute;", "É")
          .Replace("&Ecirc;", "Ê")
          .Replace("&Igrave;", "Ì")
          .Replace("&Iacute;", "Í")
          .Replace("&Icirc;", "Î")
          .Replace("&ETH;", "Ð")
          .Replace("&Ograve;", "Ò")
          .Replace("&Oacute;", "Ó")
          .Replace("&Ocirc;", "Ô")
          .Replace("&Otilde;", "Õ")
          .Replace("&Ugrave;", "Ù")
          .Replace("&Uacute;", "Ú")
          .Replace("&Yacute;", "Ý")
          .Replace("&agrave;", "à")
          .Replace("&aacute;", "á")
          .Replace("&acirc;", "â")
          .Replace("&atilde;", "ã")
          .Replace("&aring;", "å")
          .Replace("&ccedil;", "ç")
          .Replace("&egrave;", "è")
          .Replace("&eacute;", "é")
          .Replace("&ecirc;", "ê")
          .Replace("&igrave;", "ì")
          .Replace("&iacute;", "í")
          .Replace("&icirc;", "î")
          .Replace("&ograve;", "ò")
          .Replace("&oacute;", "ó")
          .Replace("&ocirc;", "ô")
          .Replace("&otilde;", "õ")
          .Replace("&ugrave;", "ù")
          .Replace("&uacute;", "ú")
          .Replace("&ucirc;", "û")
          .Replace("&yacute;", "ý");
    }
    */

    /// <summary>
    /// Get rid of non-standard Microsoft Word HTML tags
    /// </summary>
    public string CleanUpWordHtml(string html)
    {
      //return CleanUpWordHtml_ByJeffAtwood(MakeSafe(html));
      html = FixWeirdCharacters(html);

      html = FixEntityCharacters(html);
      //html = CleanUpWordHtml_ByTimMackey(html);
      //html = CleanUpWordHtml_ByJeffAtwood(html);
      html = CleanUpWordHtml_ByPhuong(html);
      return html;
    }

    /// <summary>
    /// 14/12/2008
    /// Cleaning Word's Nasty HTML
    /// Try to avoid remove div that wrap image and caption
    /// </summary>
    private string CleanUpWordHtml_ByPhuong(string html)
    {
      NameValueCollection nvc = new NameValueCollection();
      // get rid of unnecessary tag spans (comments and title)
      nvc.Add(@"<!--(\w|\W)+?-->", string.Empty);
      nvc.Add(@"<title>(\w|\W)+?</title>", string.Empty);
      nvc.Add(@"<style>(\w|\W)+?</style>", string.Empty);
      // Get rid of classes and styles
      //nvc.Add(@"\s?class=\w+", string.Empty);
      //nvc.Add(@"\s+style='[^']+'", string.Empty);
      nvc.Add(@"(font-family:[^&gt;]*[;'])|(font-size:[^&gt;]*[;'])|(line-height:[^&gt;]*[;'])|(MsoNormal)|(&lt;!--\[if.*?&lt;!\[endif\]--&gt;)", string.Empty);
      // Get rid of unnecessary tags
      //nvc.Add(@"<(meta|link|/?o:|/?style|/?div|/?st\d|/?head|/?html|body|/?body|/?span|!\[)[^>]*?>", string.Empty);
      nvc.Add(@"<(meta|link|/?o:|/?st\d|/?head|/?html|body|/?body|/?span|!\[)[^>]*?>", string.Empty); // keep DIV after clean up - by Phuong
      // Get rid of empty paragraph tags
      nvc.Add(@"(<[^>]+>)+&nbsp;(</\w+>)+", string.Empty);
      // remove bizarre v: element attached to <img> tag
      nvc.Add(@"\s+v:\w+=""[^""]+""", string.Empty);
      // remove extra lines
      nvc.Add(@"(\n\r){2,}", string.Empty);
      // TimMackey
      nvc.Add(@"<[/]?(font|span|xml|del|ins|[ovwxp]:\w+)[^>]*?>", string.Empty);
      nvc.Add(@"<([^>]*)(?:lang|size|face|[ovwxp]:\w+)=(?:'[^']*'|""[^""]*""|[^\s>]+)([^>]*)>", "<$1$2>");
      //nvc.Add(@"<([^>]*)(?:lang|size|face|[ovwxp]:\w+)=(?:'[^']*'|""[^""]*""|[^\s>]+)([^>]*)>", "<$1$2>");
      //nvc.Add(@"(class=\w+(?=([^&lt;]*&gt;))|(&lt;!--\[if.*?&lt;!\[endif\]--&gt;)|(&lt;!\[if !\w+\]&gt;)|(&lt;!\[endif\]&gt;)|(&lt;o:p&gt;[^&lt;]*&lt;/o:p&gt;)|(&lt;span[^&gt;]*&gt;)|(&lt;/span&gt;)|(font-family:[^&gt;]*[;'])|(font-size:[^&gt;]*[;'])", string.Empty);

      foreach (string key in nvc.Keys)
      {
        html = Regex.Replace(html, key, nvc[key], RegexOptions.IgnoreCase);
      }

      return html.Trim();
    }


    /// <summary>
    /// Removes all FONT and SPAN tags, and all Class and Style attributes.
    /// Designed to get rid of non-standard Microsoft Word HTML tags.
    /// http://tim.mackey.ie/CommentView,guid,2ece42de-a334-4fd0-8f94-53c6602d5718.aspx
    /// </summary>
    private string CleanUpWordHtml_ByTimMackey(string html)
    {
      // start by completely removing all unwanted tags 
      html = Regex.Replace(html, @"<[/]?(font|span|xml|del|ins|[ovwxp]:\w+)[^>]*?>", string.Empty, RegexOptions.IgnoreCase);
      // then run another pass over the html (twice), removing unwanted attributes 
      html = Regex.Replace(html, @"<([^>]*)(?:class|lang|style|size|face|[ovwxp]:\w+)=(?:'[^']*'|""[^""]*""|[^\s>]+)([^>]*)>", "<$1$2>", RegexOptions.IgnoreCase);
      html = Regex.Replace(html, @"<([^>]*)(?:class|lang|style|size|face|[ovwxp]:\w+)=(?:'[^']*'|""[^""]*""|[^\s>]+)([^>]*)>", "<$1$2>", RegexOptions.IgnoreCase);
      return html.Trim();
    }



    /// <summary>
    /// January 09, 2006
    /// Cleaning Word's Nasty HTML
    /// I recently wrote a Word 2003 document that I later turned into a blog post. The transition between Word doc and HTML presented some problems. Word offers two HTML options in its save dialog: "Save as HTML" and "Save as Filtered HTML". In practice, that means you get to choose between totally nasty HTML and slightly less nasty HTML.
    /// I searched around for any existing Word cleanup solutions and found the Textism Word HTML Cleaner, and Tim Mackey's set of regular expressions. The Textism solution is great, but requires a subscription for files over 20kb. And I wasn't quite happy with Tim's regular expressions, either. So I created my own Word HTML cleanup solution.
    /// This c# 2.0 code removes all unnecessary cruft from Word documents saved as HTML, stripping the HTML down to the bare-bones basics: \
    /// http://www.codinghorror.com/blog/archives/000485.html
    /// </summary>
    private string CleanUpWordHtml_ByJeffAtwood(string html)
    {
      StringCollection sc = new StringCollection();
      // get rid of unnecessary tag spans (comments and title)
      sc.Add(@"<!--(\w|\W)+?-->");
      sc.Add(@"<title>(\w|\W)+?</title>");
      // Get rid of classes and styles
      sc.Add(@"\s?class=\w+");
      sc.Add(@"\s+style='[^']+'");
      // Get rid of unnecessary tags
      //sc.Add(@"<(meta|link|/?o:|/?style|/?div|/?st\d|/?head|/?html|body|/?body|/?span|!\[)[^>]*?>");
      sc.Add(@"<(meta|link|/?o:|/?style||/?st\d|/?head|/?html|body|/?body|/?span|!\[)[^>]*?>"); // keep DIV after clean up - by Phuong
      // Get rid of empty paragraph tags
      sc.Add(@"(<[^>]+>)+&nbsp;(</\w+>)+");
      // remove bizarre v: element attached to <img> tag
      sc.Add(@"\s+v:\w+=""[^""]+""");
      // remove extra lines
      sc.Add(@"(\n\r){2,}");

      foreach (string s in sc)
      {
        html = Regex.Replace(html, s, "", RegexOptions.IgnoreCase);
      }

      return html.Trim();
    }

    private string FixEntityCharacters(string html)
    {
      NameValueCollection nvc = new NameValueCollection();
      nvc.Add("“", "&ldquo;");
      nvc.Add("”", "&rdquo;");
      nvc.Add("–", "&mdash;");
      nvc.Add("&agrave;", "à");
      foreach (string key in nvc.Keys)
      {
        html = html.Replace(key, nvc[key]);
      }
      return html;
    }
  }
}


