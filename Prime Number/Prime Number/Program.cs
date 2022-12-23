using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace loob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int FirstNumber =int.Parse(Console.ReadLine());

            Console.WriteLine("please enter second number");
            int SecondNumber = int.Parse(Console.ReadLine());
            
            int x;
            
            for (; FirstNumber<=SecondNumber; FirstNumber++)
            {
                for (x=FirstNumber;x<=FirstNumber;x++)
                if (FirstNumber % 2 == 0)
                    break;
             else if (x == FirstNumber)
                    Console.WriteLine(FirstNumber);
            }
        }
    }
}
