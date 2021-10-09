using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_6._3
{   //Удалить текст в скобках
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string startString = Console.ReadLine();       
            int charFBracket = startString.IndexOf('{');            

            while (charFBracket != -1)
            {               
                for (int i = charFBracket; i < startString.Length; i++)
                {
                    if (startString[i] == '{')
                    {
                        charFBracket = i;
                    }
                    if (startString[i] == '}') 
                    {
                        startString = startString.Remove(charFBracket,i-charFBracket+1);
                        break;
                    }
                }
                charFBracket = startString.IndexOf('{');
                if (startString.IndexOf('{') == -1 || startString.IndexOf('}') == -1)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine((startString.Length>0)? startString:"Вся строка удалена");
            Console.ReadKey();
        }
    }
}
