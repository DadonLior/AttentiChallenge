using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiHomeChallenge
{
    public static class Algorithm
    {
        static Random random = new Random();
        static Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
        static IEnumerable<ConsoleColor> excludedColors = new HashSet<ConsoleColor>() { ConsoleColor.Gray, ConsoleColor.Black };


        public static int GetNumberOfIsland(Board board)
        {
            Stack<Pixel> pixelStack = new Stack<Pixel>();
            int numberOfIslands = 0;
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

                        pixelStack.Push(pixel);
                        IterativeDFS(pixelStack, randomColor);
                        numberOfIslands++;
                    }
                }
            }
            return numberOfIslands;
        }

        public static void IterativeDFS(Stack<Pixel> pixelsStack, ConsoleColor color)
        {
            while (pixelsStack.Count > 0)
            {
                var pixel = pixelsStack.Pop();

                if (pixel.Val == 2)
                    continue;

                pixel.Val++;
                pixel.Color = color;

                foreach (var neighbour in pixel.Neighbours)
                    if (neighbour.Val == 1)
                        pixelsStack.Push(neighbour);
            }
        }
    }
}
