using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            bool validMove = false;
            bool playingRound = true;

            Gameboard myGameboard = new Gameboard();

            while (playingRound)
            {

            }

            while (!validMove)
            {
                Console.Write("Row:");
                row = int.Parse(Console.ReadLine());
                Console.Write("Column:");
                column = int.Parse(Console.ReadLine());

                try
                {
                    myGameboard.SetPlayerPiece(new GameboardPosition(row, column), Gameboard.PlayerPiece.O);
                }
                catch (PositionChoiceOutOfRangeException ex)
                {
                    Console.WriteLine("I think you tried an illegal move!");
                    Console.WriteLine(ex.Message);
                }
                catch (PositionChoiceTakenException ex)
                {
                    Console.WriteLine("I think you tried an illegal move!");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("I will be sure to write this no matter what.");
                }
            }

            Console.ReadKey();
        }

    }
}
