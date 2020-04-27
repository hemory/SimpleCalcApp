using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoosterQuizPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            const double monthlyPayment = (599.55);

            Console.WriteLine("What is your name?");
            string userName = (Console.ReadLine());

            Console.WriteLine(Environment.NewLine + $"Hello {userName}, what is your current principal loan balance?");
            double userBalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "What is your annual interest rate?");
            double userInterest = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double interestFraction = userInterest / 100;
            double annualInterest = userBalance * interestFraction;
            double monthlyInterestDue = annualInterest * 12;
            double paymentToPrincipal = monthlyPayment - (annualInterest / 12);
            double newPrincipalBalance = userBalance - paymentToPrincipal;

            Console.WriteLine(Environment.NewLine + $"So based on your entries your annual interest rate will be {annualInterest}.");
            Console.WriteLine($"Your monthly interest due will be {monthlyInterestDue / 12} dollars.");
            Console.WriteLine($"Your monthly payment amount minus the monthly interest charge is {paymentToPrincipal}.");
            Console.WriteLine($"Your principal balance will be {newPrincipalBalance} after your first payment.");
            Console.ReadLine();
        }
    }
}
