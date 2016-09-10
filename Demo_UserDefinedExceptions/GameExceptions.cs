using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UserDefinedExceptions
{
    public class PositionChoiceOutOfRangeException : Exception
    {
        public PositionChoiceOutOfRangeException(string message) : base(message)
        {
        }
    }

    public class PositionChoiceTakenException : Exception
    {
        public PositionChoiceTakenException(string message) : base(message)
        {
        }
    }
}
