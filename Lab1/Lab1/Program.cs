using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Output(int num)
        {
            int digit = 0;
            int temp = Math.Abs(num);
            do
            {
                temp /= 10;
                digit++;
            } while (temp > 0);

            switch (digit) 
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(num.ToString() + " ");
                    Console.ResetColor();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(num.ToString() + " ");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(num.ToString() + " ");
                    Console.ResetColor();
                    break;
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());

            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);

            Output(a);
            Output(b);
            Output(c);

            Console.ReadLine();
        }
    }
}
