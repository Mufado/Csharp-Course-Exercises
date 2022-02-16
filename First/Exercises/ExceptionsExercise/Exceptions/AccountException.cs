using System;

namespace First.Exercises.ExceptionsExercise.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
