using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._2
{   //Палиндром
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string startString = Console.ReadLine().Replace(" ", string.Empty).ToLower();       
            string revString = new string(startString.ToCharArray().Reverse().ToArray());
            
            if (string.Equals(revString, startString) == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }            
            Console.ReadKey();
        }
    }
}
