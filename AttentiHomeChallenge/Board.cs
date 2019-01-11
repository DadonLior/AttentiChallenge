using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttentiHomeChallenge
{
    public class Board
    {
        public int NumOfRows { get;  private set; }
        public int NumOfCols { get; private set; }


        private Pixel[][] pixels;

        public Board(int numOfRows, int numOfCols)
        {
            NumOfRows = numOfRows;
            NumOfCols = numOfCols;

            InitBoard();
            SetNeighboursToEachPixel();
        }


        private void ForEachPixel(Action<int,int> action)
        {
            for (int i = 0; i < NumOfRows; i++)
            {
                for (int j = 0; j < NumOfCols; j++)
                {
                    action(i, j);
                }
            }
        }

        public void SetRandomIslands()
        {
            Random random = new Random();
            ForEachPixel((i, j) => pixels[i][j].Val = random.Next(2));

        }


        public Pixel GetPixel(int row, int col)
        {
            return pixels[row][col];
        }


        private void SetNeighboursToEachPixel()
        {
            ForEachPixel((i, j) => pixels[i][j].SetNeighbours(GetAvialableNeighbours(i, j)));
        }

        private void InitBoard()
        {
            pixels = new Pixel[NumOfRows][];
            for (int i = 0; i < NumOfRows; i++)
            {
                pixels[i] = new Pixel[NumOfCols];
                for (int j = 0; j < NumOfCols; j++)
                {
                    pixels[i][j] = new Pixel(i, j);
                }
            }
        }

        private List<Pixel> GetAvialableNeighbours(int row, int col)
        {
            List<Pixel> neighbours = new List<Pixel>();
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (!IsOutOfRange(i, j) && !(i == row && j == col))
                    {
                        neighbours.Add(pixels[i][j]);
                    }
                }
            }

            return neighbours;
        }

        public bool IsOutOfRange(int row, int col)
        {
            if ((row >= 0) && (row < this.NumOfRows) && (col >= 0) && (col < this.NumOfCols))
            {
                return false;
            }
            return true;
        }


        public List<Pixel> GetNeighbours(int row, int col)
        {
            return pixels[row][col].Neighbours;
        }

        public void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < NumOfRows; i++)
            {
                for (int j = 0; j < NumOfCols; j++)
                {
                    Console.Write(pixels[i][j].ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
