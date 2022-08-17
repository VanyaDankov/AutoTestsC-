using System;

namespace BasicOfFramwork
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Enter number ");
            Console.WriteLine("Enter number system ");
            result=Translator.TranslateBaseNumber(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(result);
        }
    }
}
