using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones.Exceptions
{
    public class CheckFinishNumberException : Exception
    {
        public CheckFinishNumberException(string message) : base(message)
        {
        }
    }
}
