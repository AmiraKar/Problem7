using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sumOfDigit = 0;
            int number;
            Console.WriteLine("Enter the number:");
            int
                
                num=int.Parse(Console.ReadLine());
            while (num > 0)
            {
                number=num%10;
                sumOfDigit += number;
                num/=10;

            }
            Console.WriteLine("Sum of the digits of a number is : "+ sumOfDigit);

        }
    }
}
