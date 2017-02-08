using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class FormGrid : Form
    {
        public FormGrid(string [,] grid)
        {
            InitializeComponent();
        }

        private void gridFiller(string[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int n = 0; n < grid.GetLength(1); n++)
                {
                    dataGridWarehouse.Rows[i].Cells[n].Value = grid[i, n];
                }
            }
        }

        private void gridChecker(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridWarehouse.Rows[dataGridWarehouse.CurrentCell.ColumnIndex].Cells[0].Value.ToString() != "10")
            {
                dataGridWarehouse.Rows[dataGridWarehouse.CurrentCell.ColumnIndex].Cells[4].ReadOnly = true;
            }
        }
    }
}
