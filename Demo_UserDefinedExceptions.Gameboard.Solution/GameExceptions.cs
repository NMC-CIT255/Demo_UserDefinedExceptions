using System;

namespace Demo_UserDefinedExceptions
{
    /// <summary>
    /// The player has requested a position with the row and/or column value out of range
    /// </summary>
    public class PositionChoiceOutOfRangeException : Exception
    {
        public PositionChoiceOutOfRangeException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// The player has requested a position that is already taken on the game board
    /// </summary>
    public class PositionChoiceTakenException : Exception
    {
        public PositionChoiceTakenException(string message) : base(message)
        {
        }
    }
}
