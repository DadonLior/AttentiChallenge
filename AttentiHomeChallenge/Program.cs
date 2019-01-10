using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiHomeChallenge
{
    class Program
    {
        static Random random = new Random();
        static Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
        static IEnumerable<ConsoleColor> excludedColors = new HashSet<ConsoleColor>() { ConsoleColor.Gray, ConsoleColor.Black };

        static IEnumerable<int> range = Enumerable.Range(1, consoleColors.Length);

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

                if (displayMatrix)
                {
                    Console.WriteLine("Before find number of islands");
                    board.Print();
                }

                var numberOfIslands = GetNumberOfIsland(board);

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

        static int GetNumberOfIsland(Board board)
        {
            int count = 0;
            ConsoleColor randomColor = ConsoleColor.Gray;
            for (int i = 0; i < board.NumOfRows; i++)
            {
                for (int j = 0; j < board.NumOfCols; j++)
                {
                    Pixel pixel = board.GetPixel(i, j);

                    if (pixel.Val == 1)
                    {
                        randomColor = ConsoleColor.Gray;
                        while (excludedColors.Contains(randomColor))
                        {
                            randomColor = (ConsoleColor)consoleColors.GetValue(random.Next(consoleColors.Length));
                        }
                        DFS(pixel, randomColor);
                        count++;
                    }
                }
            }
            return count;
        }

        static void DFS(Pixel pixel, ConsoleColor color)
        {
            pixel.Val++;
            pixel.Color = color;

            foreach (var neighbour in pixel.Neighbours)
            {
                if (neighbour.Val == 1)
                {
                    DFS(neighbour, color);
                }
            }
        }
    }
}
