using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
         BankAccount brunoAccount = new BankAccount();

            Console.WriteLine("How much would loke to deposit? ");

            var amountToDeposit = double.Parse(Console.ReadLine());

            brunoAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your account balance is now: {brunoAccount.GetBalance()}");



        }
    }
}
