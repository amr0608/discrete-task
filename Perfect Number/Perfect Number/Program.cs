using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to count Perfect Number");
            Console.WriteLine("please enter First Number");
            int N1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter Second Number");
            int N2 = int.Parse(Console.ReadLine());
            int i;
            Console.WriteLine("the Numbers is :");
            for (; N1 <= N2; N1++)
            {
                int sum = 0;
                for ( i = 1; i < N1; i++)
                {
                    if (N1 % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == i)
                {
                    
                    Console.WriteLine(i);
                }
            }
 
        }
    }
}
