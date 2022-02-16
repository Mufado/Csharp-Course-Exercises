using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Exercises.ExceptionsExercise.Exceptions
{
    sealed class WithdrawException : AccountException
    {
        public WithdrawException(string message) : base(message)
        {
        }
    }
}
