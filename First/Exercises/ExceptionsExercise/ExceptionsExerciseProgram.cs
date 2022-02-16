using First.Exercises.ExceptionsExercise.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Exercises.ExceptionsExercise
{
    class ExceptionsExerciseProgram
    {
        public void ExceptionsExercise()
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int account_number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string account_holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double account_balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double account_withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                var account = new Account(account_number, account_holder, account_balance, account_withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (WithdrawException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (AccountException e)
            {
                Console.WriteLine($"Failed to create account: {e.Message}");
            }
        }
    }
}
