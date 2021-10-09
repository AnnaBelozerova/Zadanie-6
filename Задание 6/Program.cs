using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6
{
    class Program
    {   //Найти самое длинное слово в строке
        static void Main(string[] args)
        {   
            Console.Write("Введите строку: ");
            string startString = Console.ReadLine();
            string resultString = "";
            string[] stringArray = startString.Split();
            int maxLenght = 0;

            foreach (string s in stringArray)
            {
                if (maxLenght < s.Length)
                {
                    maxLenght = s.Length;
                    resultString = s;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово в строке: {0}", resultString);
            Console.ReadKey();
        }
    }
}
