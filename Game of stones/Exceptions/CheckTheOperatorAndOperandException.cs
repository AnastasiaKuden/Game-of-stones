using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones.Exceptions
{
    public class CheckTheOperatorAndOperandException : Exception
    {
        public CheckTheOperatorAndOperandException(string message) : base(message)
        {
        }
    }
}
