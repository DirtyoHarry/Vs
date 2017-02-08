using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace calc
{
    public partial class UI : Form
    {
        string[,] grid;
        char selChar = (char) 9;
        movimento[] moves;
        public UI()
        {
            InitializeComponent();


        }

        void fileLoader()
        {
            OpenFileDialog broswer = new OpenFileDialog();

            broswer.Title = "Open Your Inventory";
            broswer.Filter = "TXT files|*.txt";
            broswer.InitialDirectory = @"C:\";

            if (broswer.ShowDialog() == DialogResult.OK)
            {

                string[,] grid = new string[File.ReadLines(broswer.FileName).Count(), 5];
                moves = new movimento[File.ReadLines(broswer.FileName).Count()];

                for (int i = 0; i < File.ReadLines(broswer.FileName).Count(); i++)
                {
                    sdToBd(i, File.ReadLines(broswer.FileName).Skip(i).Take(1).First().Split(selChar))
                    moves[i] = new movimento();
                    moves[i].input(File.ReadLines(broswer.FileName).Skip(i).Take(1).First().Split(selChar));
                }
            }
            else if (broswer.ShowDialog() == DialogResult.Cancel || broswer.ShowDialog() == DialogResult.Abort)
            {

            }
            
        }

        private void selChr(object sender, EventArgs e)
        {
           // selChar = Convert.ToChar(charDropDown.Text);
        }



        private void DropDownFileOpen_Click(object sender, EventArgs e) // used to open an already existing .txt file
        {
            bool worked = false;
            fileLoader();
            labelResult.Text = calculator.LifoAdvanced(moves, ref worked).ToString();
            if (!worked)
            {
                MessageBox.Show("You must insert a table with valid data before trying to calculate lifo");
            }
        }

        private void DropDownFileNew_Click(object sender, EventArgs e) // used to create a new file (which is not necessarly saved as a .txt)
        {
          //  FormGrid newFrm = new FormGrid();
          //  newFrm.Show();
        }

        private void sdToBd(int row, string[]sdArray)
        {
            for (int i = 0; i < grid.GetLength(0);i++)
            {
                grid[row, i] = sdArray[i];
            }
        }

    } 
}

