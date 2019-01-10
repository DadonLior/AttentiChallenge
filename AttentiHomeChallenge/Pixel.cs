using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiHomeChallenge
{
    public class Pixel
    {

        public int Row { get; private set; }
        public int Col { get; private set; }

        public int Val { get; set; }

        public List<Pixel> Neighbours { get; private set; }

        public ConsoleColor  Color { get; set; }

        public Pixel(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            Val = 0;
            Color = ConsoleColor.Gray;
        }

        public void SetNeighbours(List<Pixel> neighbours)
        {
            this.Neighbours = neighbours;
        }

        public override string ToString()
        {
            Console.ForegroundColor = Color;
            return $"{Val} ";
        }



    }
}
