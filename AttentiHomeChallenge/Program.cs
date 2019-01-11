using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiHomeChallenge
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Attenti Challenge");
            bool tryAgain = false;
            bool displayMatrix = false;
            do
            {
                int numberOfRows, numberOfCols;
                Console.WriteLine();
                GetBoardSizeFromUser(out numberOfRows, out numberOfCols);
                Console.Write("Do you want to display matrix?[Y/N]");
                displayMatrix = Console.ReadKey().Key == ConsoleKey.Y;

                Console.WriteLine(Environment.NewLine + "Generate random bitmap");
                Board board = new Board(numberOfRows, numberOfCols);
                board.SetRandomIslands();

                if (displayMatrix)
                {
                    Console.WriteLine("Before find number of islands");
                    board.Print();
                }
                var numberOfIslands = Algorithm.GetNumberOfIsland(board);

                Console.WriteLine($"Number of islands {numberOfIslands}");

                if (displayMatrix)
                {
                    board.Print();
                }

                Console.Write("Do you want to try again?[Y/N]");
                tryAgain = Console.ReadKey().Key == ConsoleKey.Y;
            } while (tryAgain);

            Console.WriteLine(Environment.NewLine + "Press any key to exit");
            Console.ReadKey();
        }

        static void GetBoardSizeFromUser(out int numberOfRows, out int numberOfCols)
        {
            GetBoardSizeFromUser("rows", out numberOfRows);
            GetBoardSizeFromUser("columns", out numberOfCols);
        }

        static void GetBoardSizeFromUser(string matrixVertical, out int output)
        {
            string message = $"Please enter number of {matrixVertical}: ";
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write(message);
            }
        }
    }
}
