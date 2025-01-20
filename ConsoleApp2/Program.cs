using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the principal amount of the loan in dollars?");
            var loanAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the interest rate? (input .05 for 5%)");
            var interestRate = (Console.ReadLine());
            Console.WriteLine("what is the period of the loan in years?");
            var period = int.Parse(Console.ReadLine());
            Console.WriteLine("The total interest of the loan is " + (loanAmount * period));
        }
    }
}
