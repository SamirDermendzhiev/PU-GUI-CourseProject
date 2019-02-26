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
        static int width = 10;
        static int height = 10;
        static int MineCount = 10;
        static int Lives = 3;
        int MinesLeft = MineCount;
        int LivesLeft = Lives;
        int FieldSize = 23;
        int FreeSpace = 35;
        int MineCheck = 0;
        int FieldsLeft = width * height;
        Random rnd = new Random();
        List<Button> Fields = new List<Button>(height * width);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateFields();
            SetMines();
            LBLLives.Text = LivesLeft.ToString();
        }

        private void CreateFields()
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    int index = h * width + w;
                    Fields.Add(new Button());
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
                        if (btn.BackColor == Color.Gray)
                        {
                            btn.Visible = false;
                            if ((string)btn.Tag == "Mine")
                            {
                                if (btn.BackColor == Color.Gray)
                                {
                                    MessageBox.Show("You don't want to do that...(Lives: " + (LivesLeft - 1) + ")");
                                    LivesLeft--;
                                    MinesLeft--;
                                    btn.Visible = true;
                                    btn.BackColor = Color.Red;
                                }
                                if (LivesLeft == 0)
                                {
                                    MessageBox.Show("You lose!");
                                    foreach (Button Field in Fields)
                                    {
                                        Field.Enabled = false;
                                        if ((string)Field.Tag == "Mine")
                                        {
                                            Field.Visible = false;
                                        }
                                    }
                                }
                            }
                            
                            FieldsLeft--;
                            CheckForMines(index);
                        }
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
                            }
                            else
                            {
                                btn.BackColor = Color.Gray;
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
                }
                else
                {
                    i--;
                }
            }
        }

        private void CheckForMines(int index)
        {
            #region Checks
            WhereTocheck(index);
            if (MineCheck == 0)
            {
                ClickIfEmpty(index);
            }
            #endregion
            Label MinesAround = new Label();
            MinesAround.Location = Fields[index].Location;
            MinesAround.Size = new Size(FieldSize, FieldSize);
            if (MineCheck != 0)
            {
                MinesAround.Text = MineCheck.ToString();
            }
            MinesAround.Font = new Font("Microsoft Sans Serif", 10);
            MinesAround.TextAlign = ContentAlignment.MiddleCenter;
            MinesAround.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(MinesAround);
            MineCheck = 0;
            MinesAround.MouseDown += new MouseEventHandler(Field_MiddleMouse);
            void Field_MiddleMouse(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Middle)
                {
                    ClickIfEmpty(index);
                }
            }
            if (FieldsLeft == MinesLeft)
            {            
                foreach (Button Field in Fields)
                {
                    Field.BackColor = Color.Red;
                    Field.Enabled = false;
                }
                MessageBox.Show("You win!");
            }
        }
        #region Methods for checks
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
        #endregion

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 9;
            height = 9;
            MineCount = 10;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            height = 16;
            width = 16;
            MineCount = 40;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 30;
            height = 16;
            MineCount = 99;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FieldsLeft = height * width;
            Fields.Clear();
            this.Controls.Clear();
            this.InitializeComponent();
            CreateFields();
            SetMines();
            LivesLeft = Lives;
            MinesLeft = MineCount;
            LBLLives.Text = LivesLeft.ToString();
        }

        private void ClickIfEmpty(int index)
        {
            if (index < width)
            {
                if (index == 0)
                {
                    Fields[index + 1].PerformClick();
                    Fields[index + width].PerformClick();
                    Fields[index + (width + 1)].PerformClick();
                }
                else if (index == width - 1)
                {
                    Fields[index - 1].PerformClick();
                    Fields[index + (width - 1)].PerformClick();
                    Fields[index + width].PerformClick();
                }
                else
                {
                    Fields[index + width].PerformClick();
                    Fields[index + (width + 1)].PerformClick();
                    Fields[index + (width - 1)].PerformClick();
                    Fields[index + 1].PerformClick();
                    Fields[index - 1].PerformClick();
                }
            }
            else if (index >= width * (height - 1) && index < width * height)
            {
                if (index == width * (height - 1))
                {
                    Fields[index - width].PerformClick();
                    Fields[index - (width - 1)].PerformClick();
                    Fields[index + 1].PerformClick();
                }
                else if (index == (width * height) - 1)
                {
                    Fields[index - (width + 1)].PerformClick();
                    Fields[index - width].PerformClick();
                    Fields[index - 1].PerformClick();
                }
                else
                {
                    Fields[index - width].PerformClick();
                    Fields[index - (width + 1)].PerformClick();
                    Fields[index - (width - 1)].PerformClick();
                    Fields[index - 1].PerformClick();
                    Fields[index + 1].PerformClick();
                }
            }
            else if ((index - (width - 1)) % width == 0)
            {
                Fields[index - width].PerformClick();
                Fields[index - (width + 1)].PerformClick();
                Fields[index - 1].PerformClick();
                Fields[index + (width - 1)].PerformClick();
                Fields[index + width].PerformClick();
            }
            else if (index % width == 0)
            {
                Fields[index - width].PerformClick();
                Fields[index - (width - 1)].PerformClick();
                Fields[index + 1].PerformClick();
                Fields[index + (width + 1)].PerformClick();
                Fields[index + width].PerformClick();
            }
            else
            {
                Fields[index - width].PerformClick();
                Fields[index - (width - 1)].PerformClick();
                Fields[index + 1].PerformClick();
                Fields[index + (width + 1)].PerformClick();
                Fields[index + width].PerformClick();
                Fields[index + (width - 1)].PerformClick();
                Fields[index - 1].PerformClick();
                Fields[index - (width + 1)].PerformClick();
            }
        }
        private void WhereTocheck(int index)
        {
            if (index < width)
            {
                if (index == 0)
                {
                    CheckRight(index);
                    CheckLower(index);
                    CheckLowerRight(index);
                }
                else if (index == width - 1)
                {
                    CheckLeft(index);
                    CheckLowerLeft(index);
                    CheckLower(index);
                }
                else
                {
                    CheckLeft(index);
                    CheckRight(index);
                    CheckLowerLeft(index);
                    CheckLower(index);
                    CheckLowerRight(index);
                }
            }
            else if (index >= width * (height - 1) && index < width * height)
            {
                if (index == width * (height - 1))
                {
                    CheckUp(index);
                    CheckUperRight(index);
                    CheckRight(index);
                }
                else if (index == (width * height) - 1)
                {
                    CheckUperLeft(index);
                    CheckUp(index);
                    CheckLeft(index);
                }
                else
                {
                    CheckUperLeft(index);
                    CheckUp(index);
                    CheckUperRight(index);
                    CheckLeft(index);
                    CheckRight(index);
                }
            }
            else if ((index - (width - 1)) % width == 0)
            {
                CheckUp(index);
                CheckUperLeft(index);
                CheckLeft(index);
                CheckLowerLeft(index);
                CheckLower(index);
            }
            else if (index % width == 0)
            {
                CheckUp(index);
                CheckUperRight(index);
                CheckRight(index);
                CheckLowerRight(index);
                CheckLower(index);
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
            }
        }
    }
}