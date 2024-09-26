using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string str = "";
            string ending = "";
            int tryes = 0;
            int wins = 0;

            do
            {
                ending = "";
                for (int i = 0; i < 2; i++)
                    ending += Convert.ToChar(rnd.Next(1072, 1103));
                Console.WriteLine("Введите слово с окончанием: " + ending);
                str = Console.ReadLine();
                if (str == "")
                {
                    Console.WriteLine("Баллы: " + wins * 100 / tryes);
                    Console.WriteLine("Попытки: " + tryes);
                }
                else if (str.Substring(str.Length - 2) == ending)
                {
                    Console.WriteLine("Верно!");
                    tryes++;
                    wins++;
                }
                else
                {
                    Console.WriteLine("Неверно!");
                    tryes++;
                }
                
          
            } while (str != "");

            Console.ReadLine();

        }
    }
}
