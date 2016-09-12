using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UserDefinedExceptions
{
    /// <summary>
    /// struct to store the game board location of a player's piece
    /// Note: the struct is designed to accept any integer as a row or column value and assumes validation regarding type is
    /// occurring at the View and validation regarding the actual position is occurring at the Model.
    /// </summary>
    public struct GameboardPosition
    {
        public int Row { get; set; }
        public int Column { get; set; }
        
        public GameboardPosition(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
