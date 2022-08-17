using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfFramwork
{
    static class Translator
    {
        public static string TranslateBaseNumber(string strNumber, string strBaseNumber)
        {
            int res=0;
            int number;
            int baseNumber;
            double variable1, variable2;
            try
            {
                variable1 = Convert.ToDouble(strNumber);
                number = Convert.ToInt32(variable1);
                variable2 = Convert.ToDouble(strBaseNumber);
                baseNumber = Convert.ToInt32(variable2);
                if (variable1 != number || variable2 != baseNumber)
                {
                    return "number or baseNumber is not intager";
                }
                if (baseNumber < 2 || baseNumber > 20)
                {
                    return "Basenumber >20 or <2";
                }
                int i = 1;
                while (number != 0)
                {
                    
                    res += number % baseNumber * i;
                    number /= baseNumber;
                    if (baseNumber > 9)
                    {
                        i *= 100;
                    }
                    else
                    {
                        i *= 10;
                    }
                }
               
                return Convert.ToString(res);

            }
            catch (Exception e)
            {
                return e.ToString();
            }
           
        }
      
    }
}
