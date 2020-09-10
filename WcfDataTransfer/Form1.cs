using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfDataTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(rowsTextBox.Text, out int rows);
            Int32.TryParse(columnsTextBox.Text, out int columns);
            int[,] blocker = new int[rows, columns];

            Randomise(blocker, rows, columns);
            int[] blocker1D = TransformArray(blocker, rows, columns);
        }

        private int[] TransformArray(int[,] blocker, int rows, int columns)
        {
            int[] blocker1D = new int[rows * columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    blocker1D[row * columns + column] = blocker[rows, column];
                }
            }

            return blocker1D;
        }

        private void Randomise(int[,] data, int rows, int columns)
        {
            // this could be used for the yellow part for task allocation
            Random random = new Random((int)DateTime.Now.Ticks);

            for (int column = 0; column < columns; column++)
            {
                int count = 0;

                // 2 is the number of yellow box 
                while (count < 2)
                {
                    int randomRow = random.Next(0, rows - 1);

                    if (data[randomRow, column] == 0)
                    {
                        data[randomRow, column] = 1;
                        count++;
                    }
                }
            }
        }
    }
}
