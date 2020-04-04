using System;
using System.Globalization;
using SolutionAccount.Entities;
using SolutionAccount.Entities.Exeptions;

namespace SolutionAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account Data:");
                Console.Write("Numer: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holderAccount = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(numberAccount, holderAccount, withdrawLimit);
                acc.Deposit(initialBalance);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amountWithdraw);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainExeption domain)
            {
                Console.WriteLine(domain.Message);
            }
        }
    }
}
