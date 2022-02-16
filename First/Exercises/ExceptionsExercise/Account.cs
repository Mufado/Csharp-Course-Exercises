using First.Exercises.ExceptionsExercise.Exceptions;
using System;

namespace First.Exercises.ExceptionsExercise
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if (number < 0 || balance < 0 || withdrawLimit <= 0)
                throw new AccountException("Invalid values in account data");
            if (String.IsNullOrWhiteSpace(holder))
                throw new AccountException("Holder can not be empty");

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
                throw new WithdrawException("The amount exceeds withdraw limit");
            if (amount > Balance)
                throw new WithdrawException("Not enough balance");

            Balance -= amount;
        }
    }
}
