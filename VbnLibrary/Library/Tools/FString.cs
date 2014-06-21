using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Library.Tools
{
    public class FString
    {
        public static bool IsInteger(string str) // ham kiem tra xem mot chuoi co phai la so khong
        {
            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '0' && str[i] != '1' && str[i] != '2' && str[i] != '3' &&
                    str[i] != '4' && str[i] != '5' && str[i] != '6' && str[i] != '7' &&
                    str[i] != '8' && str[i] != '9')
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        } 
        public static string GetToPattern(string input)
        {
            string[] tmp = input.Split(' ');
            string st = "";
            for (int i = 0; i < tmp.Length; i++)
            {
                if (!string.IsNullOrEmpty(tmp[i].Trim()))
                {
                    string lower = tmp[i].Trim().ToLower();
                    string upper = tmp[i].Trim().ToUpper();

                    string f = "";
                    string format = "[{0}{1}]";
                    for (int j = 0; j < lower.Length; j++)
                    {
                        f += string.Format(format, lower[j], upper[j]);
                    }

                    st += f + @"[\s_\-]*";
                }
            }

            if (!string.IsNullOrEmpty(st))
                st = @"[\s]*" + st.Substring(0, st.Length - 8) + @"[\s]*";
            return st;
        }

        public static string GetString(string _string)
        {
            string sInput = UnicodeConversion.CreateInstant().UnicodeToASCII(_string);
            char[] arrChar = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                            '0','1','2','3','4','5','6','7','8','9',
                            '_', '-'};
            /*
            foreach (char c in sInput)
            {
                for (short i = 0; i < arrChar.Length; i++)
                    if (c.Equals(arrChar[i]))
                    {
                        sResult += c;
                        break;
                    }
            }
            */
            return sInput;

        }
        
        public static bool Compare(string input, string search)
        {
            string patern = GetString(input);
            patern = GetToPattern(patern);
            string s = GetString(search);
            return Regex.IsMatch(s, patern);
        }
        /// <summary>
        /// Lay byte array tu string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] GetByte(string text)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(text);

        }
        /// <summary>
        /// Lay string tu byte array
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string GetString(byte[] bytes)
        {
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            return enc.GetString(bytes);

        }
        /// <summary>
        /// Tach chuoi binh thuong sang chuoi co dau '' de search.
        /// EX: str = "user1,user2,user3" --> "'user1','user2','user3'"
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static string SplitSearchString(string user)
        {
            if (string.IsNullOrEmpty(user))
                return "";
            user = user.Replace(";", ",");
            user = user.Replace(",", "','");
            user = "'" + user + "'";
            return user;
        }

        /// <summary>
        /// Tra ve chuoi chuan, moi tu cach nhau boi mot khoang trang
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetStandardString(string str)
        {
            string desStr = str;
            for (int i = 0; i < desStr.Length - 1; i++)
                if (str[i] == ' ')
                {
                    int count = 0;
                    for (int j = i + 1; j < desStr.Length; j++)
                    {
                        if (desStr[j] == ' ')
                            count++;
                        else
                        {
                            desStr = desStr.Remove(i, count);
                            i = j;
                            break;
                        }
                    }
                }
            return desStr;
        }
        /// <summary>
        /// Rut ngan chuoi dai thanh mot chuoi ngan hon voi dau ... cuoi cung
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SplitString(string str,int length)
        {
            string result = "";
            string[] temp = str.Split(' ');
            if (temp.Length >= length)
            {
                for (int i = 0; i < length; i++)
                    result += temp[i] + " ";
                return result;
            }
            return str;
        }
    }
}
