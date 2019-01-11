using AttentiHomeChallenge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttentiHomeCallengeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstStageControls = new List<Control>() { label1, textBox1, button1, button2 };
            SecondStageControls = new List<Control>() { solveBtn };
            ThirdStageControls = new List<Control>() { restartBtn, numberOfIslandsLabel };
        }

        public List<Control> FirstStageControls { get; set; }
        public List<Control> SecondStageControls { get; set; }
        public List<Control> ThirdStageControls { get; set; }
        public Button[][] Buttons { get; set; }


        public Board Board { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsTextBoxValid())
            {
                invalidMessage.Visible = true;
                return;
            }

                
            FirstStageControls.ForEach((control) => control.Visible = false);

            int columns, rows;
            GetNumberOfRowsAndColumnsFromTextBox(out rows, out columns);
            initBoard(rows, columns);

            SecondStageControls.ForEach((control) => control.Visible = true);
        }

        private bool IsTextBoxValid()
        {
            try
            {
                int columns, rows;
                GetNumberOfRowsAndColumnsFromTextBox(out rows, out columns);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void initBoard(int numberOfRows, int numberOfColumns, bool isRandom = true, bool isEnable = false)
        {
            Board = new Board(numberOfRows, numberOfColumns);
            if (isRandom)
                Board.SetRandomIslands();

            Buttons = new Button[Board.NumOfRows][];
            for (int i = 0; i < Board.NumOfRows; i++)
            {
                Buttons[i] = new Button[Board.NumOfCols];
                for (int j = 0; j < Board.NumOfCols; j++)
                {
                    Pixel pixel = Board.GetPixel(i, j);

                    Button newButton = new Button()
                    {
                        Location = new Point(15 * i, 15 * j),
                        Size = new Size(15, 15),
                        Enabled = isEnable,
                        Name = $"{i},{j}"
                    };

                    if (pixel.Val == 1)
                        newButton.BackColor = Color.Black;

                    if (isEnable)
                        newButton.Click += boardBtn_Click;

                    Buttons[i][j] = newButton;
                    this.Controls.Add(newButton);
                }
            }
        }

        private void boardBtn_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;

            string[] boardsIndexes = buttonClicked.Name.Split(',');
            int row = int.Parse(boardsIndexes[0]);
            int col = int.Parse(boardsIndexes[1]);

            Pixel pixel = Board.GetPixel(row, col);

            if (buttonClicked.BackColor == Color.Black)
            {
                buttonClicked.BackColor = SystemColors.Control;
                pixel.Val = 0;
            }
            else
            {
                buttonClicked.BackColor = Color.Black;
                pixel.Val = 1;
            }
        }

        private void GetNumberOfRowsAndColumnsFromTextBox(out int rows, out int columns)
        {
            string[] bitmapSize = textBox1.Text.Split(',');
            columns = int.Parse(bitmapSize[0]);
            rows = int.Parse(bitmapSize[1]);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsTextBoxValid())
            {
                invalidMessage.Visible = true;
                return;
            }

            FirstStageControls.ForEach((control) => control.Visible = false);

            int columns, rows;
            GetNumberOfRowsAndColumnsFromTextBox(out rows, out columns);
            initBoard(rows, columns, false, true);

            SecondStageControls.ForEach((control) => control.Visible = true);
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Bitmap size: n,m";
            }
        }

        public static Color DrawingColor(ConsoleColor color)
        {
            switch (color)
            {
                case ConsoleColor.Black:

                    return Color.Black;
                case ConsoleColor.Blue:

                    return Color.Blue;
                case ConsoleColor.Cyan:

                    return Color.Cyan;
                case ConsoleColor.DarkBlue:

                    return Color.DarkBlue;
                case ConsoleColor.DarkGray:

                    return Color.DarkGray;
                case ConsoleColor.DarkGreen:

                    return Color.DarkGreen;
                case ConsoleColor.DarkMagenta:

                    return Color.DarkMagenta;
                case ConsoleColor.DarkRed:

                    return Color.DarkRed;
                case ConsoleColor.DarkYellow:

                    return Color.FromArgb(255, 128, 128, 0);
                case ConsoleColor.Gray:

                    return Color.Gray;
                case ConsoleColor.Green:

                    return Color.Green;
                case ConsoleColor.Magenta:

                    return Color.Magenta;
                case ConsoleColor.Red:

                    return Color.Red;
                case ConsoleColor.White:

                    return Color.White;
                default:
                    return Color.Yellow;
            }
        }

        private void solveBtn_Click_1(object sender, EventArgs e)
        {
            SecondStageControls.ForEach((control) => control.Visible = false);

            int numberOfIslands = Algorithm.GetNumberOfIsland(Board);

            for (int i = 0; i < Board.NumOfRows; i++)
            {
                for (int j = 0; j < Board.NumOfCols; j++)
                {
                    Pixel pixel = Board.GetPixel(i, j);
                    Buttons[i][j].BackColor = DrawingColor(pixel.Color);
                }
            }

            numberOfIslandsLabel.Text = $"Number of islands:{numberOfIslands}";

            ThirdStageControls.ForEach((control) => control.Visible = true);
        }

        private void restartBtn_Click_1(object sender, EventArgs e)
        {
            ThirdStageControls.ForEach((control) => control.Visible = false);

            for (int i = 0; i < Board.NumOfRows; i++)
            {
                for (int j = 0; j < Board.NumOfCols; j++)
                {
                    this.Controls.Remove(Buttons[i][j]);
                }
            }

            Buttons = null;
            Board = null;

            FirstStageControls.ForEach((control) => control.Visible = true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            invalidMessage.Visible = false;
        }
    }
}
