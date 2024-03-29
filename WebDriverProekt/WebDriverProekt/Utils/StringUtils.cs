﻿using System;
using System.Linq;

namespace WebDriverProekt.Utils
{
    public class StringUtils
    {
        public static string GetRandomString(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }
        public static string GetBackcpase(int lenght)
        {
            string str = "";
            for(int i=0; i < lenght; i++)
            {
                str += "/b";
            }
            return str;
        }
        public static string DataToFile()
        {
            string data = DateTime.Now.ToString("u");
            var result = new String(data.Where(Char.IsDigit).ToArray());
            return result;
        }
    }
}
