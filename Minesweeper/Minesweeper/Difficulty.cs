using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void RBEasy_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GridHeight = 9;
            MainForm.GridWidth = 9;
            MainForm.MineCount = 10;
        }

        private void RBMedium_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GridHeight = 16;
            MainForm.GridWidth = 16;
            MainForm.MineCount = 40;
        }

        private void RBHard_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.GridHeight = 16;
            MainForm.GridWidth = 30;
            MainForm.MineCount = 99;
        }

        private void BTNOk_Click(object sender, EventArgs e)
        {
            if (RBCustom.Checked == true)
            {
                MainForm.GridHeight = Convert.ToInt32(TBHeight.Text);
                MainForm.GridWidth = Convert.ToInt32(TBWidth.Text);
                if (MainForm.GridHeight * MainForm.GridWidth > Convert.ToInt32(TBMines.Text))
                {
                    MainForm.MineCount = Convert.ToInt32(TBMines.Text);
                }
                else
                {
                    MessageBox.Show("Can't have more mines than fields!");
                    return;
                }
            }
            if (TBLives.Text != "")
            {
                MainForm.Lives = Convert.ToInt32(TBLives.Text);
            }
            else
            {
                MessageBox.Show("Please enter lives!");
            }
            MainForm.FieldSize = Convert.ToInt32(TBFieldSize.Text);
            this.Close();
        }
    }
}
