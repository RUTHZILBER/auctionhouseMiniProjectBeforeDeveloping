using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Auctionhouse.Utilitis
{
    class ValidateUtilities//מחלקה לבדיקות תקינות למיניהן. פעולותיה בד"כ מקבלות מחרוזת

    {
        public static bool IsHebrew(string word)// עברית
        {
            string pattern= @"\b[א-ת-\s]+$";
            Regex reg=new Regex(pattern);
            bool x = reg.IsMatch(word);
            return x;


        }

        public static bool IsHebrewNum(string word)//עברית ומספר
        {
            string pattern = @"\b[א-ת-\s]+\d+$";
            Regex reg = new Regex(pattern);
            bool x = reg.IsMatch(word);
            return x;


        }

        public static bool IsAddress(string word)//רחוב מספר ועיר
        {
            string pattern = @"\b[ א-ת]+\d+ [א-ת ]+$";
            Regex reg = new Regex(pattern);
            bool x = reg.IsMatch(word);
            return x;
        }

        
        public static bool IsNum(string st)
         {
            string pattern=@"\b[0-9-\s]+$";
            Regex reg = new Regex(pattern);
            bool a = reg.IsMatch(st);
            return a;
          }
           public static bool Isalfa(string st)//רחוב ומספר
           {
                string pattern = @"\b[א-ת ]+\d+$";
            Regex reg=new Regex(pattern);
            return reg.IsMatch(st);
           }
        public static bool LegalId(string s)
        {
            int x;
            if (!int.TryParse(s, out x))
                if (s.Length < 5 || s.Length > 9)
                    return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i] - '0'));
                if (k > 9)
                    k -= 9;
                sum += k;
            }

            return sum % 10 == 0;
        }

        public static bool IsCellPhone(string pel)
       {
            string pattren = @"\b05[0 2 3 4 5 6 7 8]-[2-9]\d{6}$";
            Regex reg = new Regex(pattren);
            return reg.IsMatch(pel);
        }

        public static bool IsTelPhone(string tel)
        {
            string pattren = @"\b0[2 3 4 72 77 8 9]-[2-9]\d{6}$";
            Regex reg = new Regex(pattren);
            bool x= reg.IsMatch(tel);
            return x;
        }

    }
}
