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
    public partial class MainForm : Form
    {
        static int width = 30;
        static int height = 16;
        int FieldSize = 23;
        int FreeSpace = 35;
        int MineCount = 99;
        int MineCheck = 0;
        int FieldsLeft = width * height;
        Random rnd = new Random();
        public Button[] Fields = new Button[width * height];

        public MainForm()
        {
            InitializeComponent();
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateFields();
            SetMines();
        }

        private void CreateFields()
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    int index = h * width + w;
                    Fields[index] = new Button();
                    Fields[index].Location = new Point(2 + w * FieldSize, FreeSpace + h * FieldSize);
                    Fields[index].Size = new Size(FieldSize, FieldSize);
                    Fields[index].BackColor = Color.Gray;
                    Fields[index].FlatStyle = FlatStyle.Flat;
                    Fields[index].FlatAppearance.BorderSize = 1;
                    Fields[index].FlatAppearance.BorderColor = Color.Black;
                    this.Controls.Add(Fields[h * width + w]);                  
                    Fields[index].Click += new EventHandler(Field_Click);
                    void Field_Click(object sender, EventArgs e)
                    {
                        Button btn = (Button)sender;
                        btn.Visible = false;
                        FieldsLeft--;
                        CheckForMines(index);
                    }
                    Fields[index].MouseDown += new MouseEventHandler(Field_RightClick);
                    void Field_RightClick(object sender, MouseEventArgs e)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            Button btn = (Button)sender;

                            if (btn.BackColor != Color.Red)
                            {
                                btn.BackColor = Color.Red;
                                btn.Enabled = false;
                            }
                            else
                            {
                                btn.BackColor = SystemColors.Control;
                                btn.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void SetMines()
        {
            for (int i = 0; i < MineCount; i++)
            {
                int a = rnd.Next(0, width * height);
                if ((string)Fields[a].Tag != "Mine")
                {
                    PictureBox Mine = new PictureBox();
                    Mine.Location = Fields[a].Location;
                    Mine.Size = new Size(FieldSize, FieldSize);
                    Mine.Image = Minesweeper.Properties.Resources.Mine;
                    Mine.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(Mine);
                    Fields[a].Tag = "Mine";
                    Fields[a].Click += new EventHandler(Mine_Click);
                    void Mine_Click(object sender, EventArgs e)
                    {
                        MessageBox.Show("Kaboom!");
                    }
                }
            }
        }

        private void CheckForMines(int index)
        {
            if (index < width)
            {
                if (index == 0)
                {
                    CheckRight(index);
                    CheckLower(index);
                    CheckLowerRight(index);
                    if (MineCheck == 0)
                    {
                        Fields[index + 1].PerformClick();
                        Fields[index + width].PerformClick();
                        Fields[index + (width + 1)].PerformClick();
                    }
                }
                else if (index == width - 1)
                {
                    CheckLeft(index);
                    CheckLowerLeft(index);
                    CheckLower(index);
                    if (MineCheck == 0)
                    {
                        Fields[index - 1].PerformClick();
                        Fields[index + (width - 1)].PerformClick();
                        Fields[index + width].PerformClick();
                    }
                }
                else
                {
                    CheckLeft(index);
                    CheckRight(index);
                    CheckLowerLeft(index);
                    CheckLower(index);
                    CheckLowerRight(index);
                    if (MineCheck == 0)
                    {
                        Fields[index + width].PerformClick();
                        Fields[index + (width + 1)].PerformClick();
                        Fields[index + (width - 1)].PerformClick();
                        Fields[index + 1].PerformClick();
                        Fields[index - 1].PerformClick();
                    }
                }
            }
            else if (index >= width * (height - 1) && index < width * height)
            {
                if (index == width * (height - 1))
                {
                    CheckUp(index);
                    CheckUperRight(index);
                    CheckRight(index);
                    if (MineCheck==0)
                    {
                        Fields[index - width].PerformClick();
                        Fields[index - (width-1)].PerformClick();
                        Fields[index + 1].PerformClick();
                    }
                }
                else if (index == (width * height) - 1)
                {
                    CheckUperLeft(index);
                    CheckUp(index);
                    CheckLeft(index);
                    if (MineCheck==0)
                    {
                        Fields[index - (width+1)].PerformClick();
                        Fields[index - width].PerformClick();
                        Fields[index - 1].PerformClick();
                    }
                }
                else
                {
                    CheckUperLeft(index);
                    CheckUp(index);
                    CheckUperRight(index);
                    CheckLeft(index);
                    CheckRight(index);
                    if (MineCheck==0)
                    {
                        Fields[index - width].PerformClick();
                        Fields[index - (width+1)].PerformClick();
                        Fields[index - (width-1)].PerformClick();
                        Fields[index - 1].PerformClick();
                        Fields[index + 1].PerformClick();
                    }
                }
            }
            else if ((index - (width - 1)) % width == 0)
            {
                CheckUp(index);
                CheckUperLeft(index);
                CheckLeft(index);
                CheckLowerLeft(index);
                CheckLower(index);
                if (MineCheck==0)
                {
                    Fields[index - width].PerformClick();
                    Fields[index - (width+1)].PerformClick();
                    Fields[index - 1].PerformClick();
                    Fields[index + (width-1)].PerformClick();
                    Fields[index + width].PerformClick();
                }
            }
            else if (index % width == 0)
            {
                CheckUp(index);
                CheckUperRight(index);
                CheckRight(index);
                CheckLowerRight(index);
                CheckLower(index);
                if (MineCheck==0)
                {
                    Fields[index - width].PerformClick();
                    Fields[index - (width-1)].PerformClick();
                    Fields[index + 1].PerformClick();
                    Fields[index + (width+1)].PerformClick();
                    Fields[index + width].PerformClick();
                }
            }
            else
            {
                CheckUp(index);
                CheckUperRight(index);
                CheckRight(index);
                CheckLowerRight(index);
                CheckLower(index);
                CheckLowerLeft(index);
                CheckLeft(index);
                CheckUperLeft(index);
                if (MineCheck==0)
                {
                    Fields[index - width].PerformClick();
                    Fields[index - (width-1)].PerformClick();
                    Fields[index + 1].PerformClick();
                    Fields[index + (width+1)].PerformClick();
                    Fields[index + width].PerformClick();
                    Fields[index + (width-1)].PerformClick();
                    Fields[index - 1].PerformClick();
                    Fields[index - (width+1)].PerformClick();
                }
            }
            Label MinesAround = new Label();
            MinesAround.Location = Fields[index].Location;
            MinesAround.Size = new Size(FieldSize, FieldSize);
            if (MineCheck != 0)
            {
                MinesAround.Text = MineCheck.ToString();
            }    
            MinesAround.Font = new Font("Microsoft Sans Serif",10);
            MinesAround.TextAlign= ContentAlignment.MiddleCenter;
            MinesAround.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(MinesAround);
            MineCheck = 0;
            if (FieldsLeft == MineCount)
            {
                MessageBox.Show("You win!");
            }
        }

        void CheckUp(int index)
        {
            if ((string)Fields[index - width].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckUperRight(int index)
        {
            if ((string)Fields[index - (width - 1)].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckRight(int index)
        {
            if ((string)Fields[index + 1].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckLowerRight(int index)
        {
            if ((string)Fields[index + (width + 1)].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckLower(int index)
        {
            if ((string)Fields[index + width].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckLowerLeft(int index)
        {
            if ((string)Fields[index + (width - 1)].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckLeft(int index)
        {
            if ((string)Fields[index - 1].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        void CheckUperLeft(int index)
        {
            if ((string)Fields[index - (width + 1)].Tag == "Mine")
            {
                MineCheck++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fields.
        }
    }
}