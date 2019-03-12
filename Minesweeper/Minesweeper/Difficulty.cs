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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        int ClickCount = 2;
        public Difficulty()
        {
            InitializeComponent();
            if (MainForm.OurBool == true)
            {
                this.BackColor = Color.Red;
                TBHeight.BackColor = Color.Gold;
                TBLives.BackColor = Color.Gold;
                TBWidth.BackColor = Color.Gold;
                TBMines.BackColor = Color.Gold;
                BTNOk.BackColor = Color.Gold;
                BTNMinimize.ForeColor = Color.Gold;
                BTNMinimize.BackColor = Color.Transparent;
                BTNMinimize.FlatAppearance.MouseOverBackColor = Color.Red;
                BTNMinimize.FlatAppearance.MouseDownBackColor = Color.Red;
                BTNClose.ForeColor = Color.Gold;
                BTNClose.BackColor = Color.Transparent;
                BTNClose.FlatAppearance.MouseOverBackColor = Color.Red;
                BTNClose.FlatAppearance.MouseDownBackColor = Color.Red;
                BTNOur.ForeColor = Color.Gold;
                label4.ForeColor = Color.Gold;
                PCBox1.Visible = true;
                PCBox1.Image = Properties.Resources.sssr4;
                BTNOurTrigger.Enabled = false;
                PCBox1.Visible = true;
            }
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
                try
                {
                    MainForm.GridHeight = Convert.ToInt32(TBHeight.Text);
                    MainForm.GridWidth = Convert.ToInt32(TBWidth.Text);
                    if (MainForm.GridHeight * MainForm.GridWidth > Convert.ToInt32(TBMines.Text) && Convert.ToInt32(TBMines.Text) > 0)
                    {
                        MainForm.MineCount = Convert.ToInt32(TBMines.Text);
                    }
                    else
                    {
                        MessageBox.Show("Can't have no mines or mines equal to or more than the fields!");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong input, try again!");
                    return;
                }
            }
            if (TBLives.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(TBLives.Text) > 0 && Convert.ToInt32(TBLives.Text) < MainForm.MineCount)
                    {
                        MainForm.Lives = Convert.ToInt32(TBLives.Text);
                    }
                    else
                    {
                        MessageBox.Show("Atleast 1 live and not more or equal to the number of mines");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong input, try again!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter lives!");
                return;
            }
            MainForm.Play = true;
            this.Close();
        }

        bool Mousedown;
        Point LastLocation;

        private void BTNOur_MouseDown(object sender, MouseEventArgs e)
        {
            Mousedown = true;
            LastLocation = e.Location;
        }

        private void BTNOur_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X, (this.Location.Y - LastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void BTNOur_MouseUp(object sender, MouseEventArgs e)
        {
            Mousedown = false;
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTNOurTrigger_Click(object sender, EventArgs e)
        {
            if (MainForm.OurBool == true)
            {

            }
            else
            {
                if (ClickCount == 0)
                {
                    this.BackColor = Color.Red;
                    TBHeight.BackColor = Color.Gold;
                    TBLives.BackColor = Color.Gold;
                    TBWidth.BackColor = Color.Gold;
                    TBMines.BackColor = Color.Gold;
                    BTNOk.BackColor = Color.Gold;
                    BTNMinimize.ForeColor = Color.Yellow;
                    BTNMinimize.BackColor = Color.Transparent;
                    BTNMinimize.FlatAppearance.MouseOverBackColor = Color.Red;
                    BTNMinimize.FlatAppearance.MouseDownBackColor = Color.Red;
                    BTNClose.ForeColor = Color.Yellow;
                    BTNClose.BackColor = Color.Transparent;
                    BTNClose.FlatAppearance.MouseOverBackColor = Color.Red;
                    BTNClose.FlatAppearance.MouseDownBackColor = Color.Red;
                    BTNOur.ForeColor = Color.Gold;
                    label4.ForeColor = Color.Gold;
                    BTNOurTrigger.Enabled = false;
                    PCBox1.Visible = true;
                    PCBox1.Image = Properties.Resources.sssr4;
                    //BTNOurTrigger.SendToBack();
                    MainForm.OurBool = true;
                    MainForm.Play = true;
                    player.SoundLocation = @"...\...\Resources\National Anthem of USSR.wav";
                    player.Play();
                }
                else
                {
                    ClickCount--;
                }
            }
        }
    }
}