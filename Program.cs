using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a number less than 200 and above -200");
                int num = int.Parse(Console.ReadLine());

                if (num < -200 || num > 200)
                {
                    Console.WriteLine("Enter a number less than 200 and above -200");
                    num = int.Parse(Console.ReadLine());
                }

                if (num <= 100)
                {
                    for (int i = num; i <= 100; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (num >= 100)
                {
                    for (int i = num; i >= 100; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
