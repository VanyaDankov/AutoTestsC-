using System;
using System.Collections.Generic;
using System.Text;

namespace DevelopmentAndBuildTools
{
    public  class  StringAnalizer
    {
        public static int MaxCountInSeriesDifferentSimbols(string str)
        {
            int result = 0;
            if (str.Length > 0)
            {
                result = 1;
            }
            if (str.Length > 1)
            {
                int count = 1;
                for (int i = 0; i < str.Length - 1; i++)
                {

                    if (str[i] != str[i + 1])
                    {
                        count++;
                        if (count > result)
                        {
                            result = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return result;
        }
        public static int MaxCountInSeriesNumbers(string str)
        {
            int result = 0;
            if (str.Length > 0)
            {
                foreach(char s in str)
                {
                    if (char.IsNumber(s))
                    {
                        result = 1;
                        break;
                    }                    
                }
            }
            if (result == 0)
            {
                return 0;
            }
            if (str.Length > 1)
            {
                int count = 1;
                for (int i = 0; i < str.Length - 1; i++)
                {

                    if (str[i] == str[i + 1] && Char.IsNumber(str[i]))
                    {
                        count++;
                        if (count > result)
                        {
                            result = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return result;
        }
        public static int MaxCountInSeriesLatinSymbols(string str)
        {
            int result = 0;
            if (str.Length > 0)
            {
                foreach (char s in str)
                {
                    if (char.IsLetter(s))
                    {
                        result = 1;
                        break;
                    }
                }
            }
            if (result == 0)
            {
                return 0;
            }
            if (str.Length > 1)
            {
                int count = 1;
                for (int i = 0; i < str.Length - 1; i++)
                {

                    if (str[i] == str[i + 1] && Char.IsLetter(str[i]))
                    {
                        count++;
                        if (count > result)
                        {
                            result = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return result;
        }
    }
}
