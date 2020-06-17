using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones.Exceptions
{
    public class CheckVariantException : Exception
    {
        public CheckVariantException(string message) : base(message)
        {
        }
    }
}
