using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Assisgnment_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;

            int answer = whatever(a);
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        public static int whatever(int a)
        {
            Console.WriteLine("The number is:" + a);

            if (a > 0)
            {
                Console.WriteLine("The new number:" + a);
                return whatever(a / 3) + 3;
            }
            else
            {
                Console.WriteLine("3");
                return (a - 3);
            }
        }
    }
}
