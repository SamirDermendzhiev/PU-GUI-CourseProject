using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainForm : Form
    {
        //Main things needed for game
        public static int GridWidth = 10;
        public static int GridHeight = 10;
        public static int MineCount =10;
        public static int Lives = 3;
        //For timer
        bool EndGame = false;
        //Form visibility
        public static int FieldSize = 23;
        int FreeSpace = 65;    
        //Displaying number of mines around        
        int MineCheck = 0;
        //Curent game session items
        int FieldsLeft = GridWidth * GridHeight;
        int FlagsCount = MineCount;
        int LivesLeft = Lives;
        int Time = 0;        
        int Score = 0;
        //Mines
        Random rnd = new Random();
        //Fields
        CustomButton[][] Fields = new CustomButton[1][];

        public MainForm()
        {
            InitializeComponent();
            BTNMinimize.Location = new Point(BTNClose.Location.X - 26, BTNClose.Location.Y);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            CreateFields();
            SetMines();
            LBLLives.Text = LivesLeft.ToString();
            LBLFlags.Text = FlagsCount.ToString();
        }

        private void CreateFields()
        {
            Array.Resize<CustomButton[]>(ref Fields, GridHeight);
            for (int i = 0; i < GridHeight; i++)
            {
                Fields[i] = new CustomButton[GridWidth];
            }          
            for (int h = 0; h < GridHeight; h++)
            {
                for (int w = 0; w < GridWidth; w++)
                {
                    Fields[h][w] = new CustomButton();
                    Fields[h][w].Location = new Point(2/*Two pixels from the left*/ + w * FieldSize, FreeSpace/*Space at the top*/ + h * FieldSize);
                    Fields[h][w].Size = new Size(FieldSize, FieldSize);
                    Fields[h][w].BackColor = Color.Gray;
                    Fields[h][w].FlatStyle = FlatStyle.Flat;
                    Fields[h][w].FlatAppearance.BorderSize = 1;
                    Fields[h][w].FlatAppearance.BorderColor = Color.Black;
                    Fields[h][w].H = h;
                    Fields[h][w].W = w;
                    this.Controls.Add(Fields[h][w]);
                    Fields[h][w].Click += new EventHandler(Field_Click);
                    void Field_Click(object sender, EventArgs e)
                    {
                        CustomButton btn = (CustomButton)sender;                        
                        //Can't click flagged fields
                        if (btn.Flag == false)
                        {
                            btn.Visible = false;
                            if (btn.Mine == true)
                            {
                                MessageBox.Show("You don't want to do that...(Lives: " + (LivesLeft - 1) + ")");
                                LivesLeft--;
                                FieldsLeft++;
                                LBLLives.Text = LivesLeft.ToString();
                                btn.Visible = true;
                                btn.Flag = true;
                                btn.BackColor = Color.Red;
                                FlagsCount--;
                                LBLFlags.Text = FlagsCount.ToString();                               
                                if (LivesLeft == 0)
                                {
                                    EndGame = true;
                                    MessageBox.Show("You lose!");
                                    foreach (CustomButton[] Row in Fields)
                                    {
                                        foreach (CustomButton Field in Row)
                                        {
                                            if (Field != null)
                                            {
                                                Field.Enabled = false;
                                                if (Field.Mine == true && Field.Flag == false)
                                                {
                                                    Field.Visible = false;
                                                }
                                                if (Field.Mine == false && Field.Flag == true)
                                                {
                                                    Field.Visible = false;
                                                    PictureBox NotMine = new PictureBox();
                                                    NotMine.Location = Field.Location;
                                                    NotMine.Size = new Size(FieldSize, FieldSize);
                                                    NotMine.Image = Minesweeper.Properties.Resources.MineCrossed;
                                                    NotMine.SizeMode = PictureBoxSizeMode.StretchImage;
                                                    this.Controls.Add(NotMine);
                                                }                                              
                                            }                                        
                                        }
                                    }
                                }
                            }
                            FieldsLeft--;
                            if (btn.Mine == false)
                            {
                                CheckForMines(btn.H, btn.W);
                            }                            
                        }
                    }
                    Fields[h][w].MouseDown += new MouseEventHandler(Field_RightClick);
                    void Field_RightClick(object sender, MouseEventArgs e)
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            CustomButton btn = (CustomButton)sender;

                            if (btn.Flag == false && FlagsCount > 0)
                            {
                                btn.BackColor = Color.Red;
                                btn.Flag = true;
                                FlagsCount--;
                                LBLFlags.Text = FlagsCount.ToString();
                            }
                            else if (btn.Flag == true)
                            {
                                btn.BackColor = Color.Gray;
                                btn.Flag = false;
                                FlagsCount++;
                                LBLFlags.Text = FlagsCount.ToString();
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
                int h = rnd.Next(0, GridHeight);
                int w = rnd.Next(0, GridWidth);
                if (Fields[h][w].Mine == false && (string)Fields[h][w].Tag != "First")   
                {
                    PictureBox Mine = new PictureBox();
                    Mine.Location = Fields[h][w].Location;
                    Mine.Size = new Size(FieldSize, FieldSize);
                    Mine.Image = Minesweeper.Properties.Resources.Mine;
                    Mine.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(Mine);
                    Fields[h][w].Mine = true;
                }
                else
                {
                    i--;
                }
            }
        } 

        private void CheckForMines(int h, int w)
        {
            CheckElement(h - 1, w);
            CheckElement(h - 1, w + 1);
            CheckElement(h, w + 1);
            CheckElement(h + 1, w + 1);
            CheckElement(h + 1, w);
            CheckElement(h + 1, w - 1);
            CheckElement(h, w - 1);
            CheckElement(h - 1, w - 1);
            Label MinesAround = new Label();
            MinesAround.Location = Fields[h][w].Location;
            MinesAround.Size = new Size(FieldSize, FieldSize);
            MinesAround.Font = new Font("Microsoft Sans Serif", 10);
            MinesAround.TextAlign = ContentAlignment.MiddleCenter;
            MinesAround.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(MinesAround);
            if (MineCheck != 0)
            {
                MinesAround.Text = MineCheck.ToString();
            }
            if (MineCheck == 0)
            {
                ClickEmpty(h, w);
            }
            MineCheck = 0;
            MinesAround.MouseDown += new MouseEventHandler(Field_MiddleMouse);
            void Field_MiddleMouse(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Middle)
                {
                    ClickEmpty(h, w);
                }
            }
            if (FieldsLeft == MineCount)
            {
                EndGame = true;
                foreach (CustomButton[] Row in Fields)
                {
                    foreach (CustomButton Field in Row)
                    {
                        if (Field!=null)
                        {
                            Field.BackColor = Color.Red;
                            Field.Enabled = false;         
                        }                        
                    }
                }
                LBLFlags.Text = "0";
                Score = Time + Lives + (Lives - LivesLeft);                
                MessageBox.Show("You win!\n Score:"+Score);                
            }
        }

        private void CheckElement(int h, int w)
        {
            try
            {
                if (Fields[h][w].Mine == true)
                {
                    MineCheck++;
                }
            }
            catch (Exception)
            {

            }
        }

        private void ClickAround(int h, int w)
        {
            try
            {
                Fields[h][w].PerformClick();
            }
            catch (Exception)
            {

            }
        }

        private void ClickEmpty(int h, int w)
        {
            ClickAround(h - 1, w);
            ClickAround(h - 1, w + 1);
            ClickAround(h, w + 1);
            ClickAround(h + 1, w + 1);
            ClickAround(h + 1, w);
            ClickAround(h + 1, w - 1);
            ClickAround(h, w - 1);
            ClickAround(h - 1, w - 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (EndGame==false)
            {
                Time++;
                LBLTime.Text = Time.ToString();
            }           
        }

        private void BTNReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Fields.Length; i++)
            {
                Array.Clear(Fields[i], 0, Fields[i].Length);
            }
            this.Controls.Clear();
            this.InitializeComponent();
            FieldsLeft = GridHeight * GridWidth;
            EndGame = false;
            CreateFields();
            SetMines();
            LivesLeft = Lives;
            FlagsCount = MineCount;
            LBLLives.Text = LivesLeft.ToString();
            LBLFlags.Text = FlagsCount.ToString();
            Time = 0;
            Score = 0;
        }

        private void BTNGame_Click(object sender, EventArgs e)
        {
            Difficulty diff = new Difficulty();
            diff.Show();
        }

        bool Mousedown;
        Point LastLocation;

        private void BTNMinesweeper_MouseDown(object sender, MouseEventArgs e)
        {
            Mousedown = true;
            LastLocation = e.Location;
        }

        private void BTNMinesweeper_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - LastLocation.X) + e.X, (this.Location.Y - LastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void BTNMinesweeper_MouseUp(object sender, MouseEventArgs e)
        {
            Mousedown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNMinimize_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;          
        }
    }

    class CustomButton : Button
    {
        public int H;
        public int W;
        public bool Mine;
        public bool Flag;
    }
}