namespace Minesweeper
{
    partial class Difficulty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RBEasy = new System.Windows.Forms.RadioButton();
            this.RBMedium = new System.Windows.Forms.RadioButton();
            this.RBHard = new System.Windows.Forms.RadioButton();
            this.BTNOk = new System.Windows.Forms.Button();
            this.RBCustom = new System.Windows.Forms.RadioButton();
            this.TBHeight = new System.Windows.Forms.TextBox();
            this.TBWidth = new System.Windows.Forms.TextBox();
            this.TBMines = new System.Windows.Forms.TextBox();
            this.TBLives = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNOur = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.BTNMinimize = new System.Windows.Forms.Button();
            this.BTNOurTrigger = new System.Windows.Forms.Button();
            this.PCBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RBEasy
            // 
            this.RBEasy.AutoSize = true;
            this.RBEasy.BackColor = System.Drawing.Color.Transparent;
            this.RBEasy.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBEasy.Location = new System.Drawing.Point(10, 75);
            this.RBEasy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RBEasy.Name = "RBEasy";
            this.RBEasy.Size = new System.Drawing.Size(53, 18);
            this.RBEasy.TabIndex = 0;
            this.RBEasy.TabStop = true;
            this.RBEasy.Text = "Easy";
            this.RBEasy.UseVisualStyleBackColor = false;
            this.RBEasy.CheckedChanged += new System.EventHandler(this.RBEasy_CheckedChanged);
            // 
            // RBMedium
            // 
            this.RBMedium.AutoSize = true;
            this.RBMedium.BackColor = System.Drawing.Color.Transparent;
            this.RBMedium.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMedium.Location = new System.Drawing.Point(10, 103);
            this.RBMedium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RBMedium.Name = "RBMedium";
            this.RBMedium.Size = new System.Drawing.Size(72, 18);
            this.RBMedium.TabIndex = 1;
            this.RBMedium.TabStop = true;
            this.RBMedium.Text = "Medium";
            this.RBMedium.UseVisualStyleBackColor = false;
            this.RBMedium.CheckedChanged += new System.EventHandler(this.RBMedium_CheckedChanged);
            // 
            // RBHard
            // 
            this.RBHard.AutoSize = true;
            this.RBHard.BackColor = System.Drawing.Color.Transparent;
            this.RBHard.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBHard.Location = new System.Drawing.Point(10, 129);
            this.RBHard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RBHard.Name = "RBHard";
            this.RBHard.Size = new System.Drawing.Size(55, 18);
            this.RBHard.TabIndex = 2;
            this.RBHard.TabStop = true;
            this.RBHard.Text = "Hard";
            this.RBHard.UseVisualStyleBackColor = false;
            this.RBHard.CheckedChanged += new System.EventHandler(this.RBHard_CheckedChanged);
            // 
            // BTNOk
            // 
            this.BTNOk.BackColor = System.Drawing.Color.DarkCyan;
            this.BTNOk.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOk.Location = new System.Drawing.Point(678, 348);
            this.BTNOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNOk.Name = "BTNOk";
            this.BTNOk.Size = new System.Drawing.Size(99, 30);
            this.BTNOk.TabIndex = 3;
            this.BTNOk.Text = "OK";
            this.BTNOk.UseVisualStyleBackColor = false;
            this.BTNOk.Click += new System.EventHandler(this.BTNOk_Click);
            // 
            // RBCustom
            // 
            this.RBCustom.AutoSize = true;
            this.RBCustom.BackColor = System.Drawing.Color.Transparent;
            this.RBCustom.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCustom.Location = new System.Drawing.Point(475, 54);
            this.RBCustom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RBCustom.Name = "RBCustom";
            this.RBCustom.Size = new System.Drawing.Size(71, 18);
            this.RBCustom.TabIndex = 4;
            this.RBCustom.TabStop = true;
            this.RBCustom.Text = "Custom";
            this.RBCustom.UseVisualStyleBackColor = false;
            // 
            // TBHeight
            // 
            this.TBHeight.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TBHeight.Location = new System.Drawing.Point(634, 51);
            this.TBHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBHeight.Name = "TBHeight";
            this.TBHeight.Size = new System.Drawing.Size(132, 21);
            this.TBHeight.TabIndex = 5;
            // 
            // TBWidth
            // 
            this.TBWidth.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TBWidth.Location = new System.Drawing.Point(634, 79);
            this.TBWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(46, 21);
            this.TBWidth.TabIndex = 6;
            // 
            // TBMines
            // 
            this.TBMines.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TBMines.Location = new System.Drawing.Point(634, 110);
            this.TBMines.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBMines.Name = "TBMines";
            this.TBMines.Size = new System.Drawing.Size(46, 21);
            this.TBMines.TabIndex = 7;
            // 
            // TBLives
            // 
            this.TBLives.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TBLives.Location = new System.Drawing.Point(98, 349);
            this.TBLives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBLives.Name = "TBLives";
            this.TBLives.Size = new System.Drawing.Size(132, 21);
            this.TBLives.TabIndex = 8;
            this.TBLives.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(578, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Ninja Naruto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(35, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lives";
            // 
            // BTNOur
            // 
            this.BTNOur.BackColor = System.Drawing.Color.Transparent;
            this.BTNOur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNOur.FlatAppearance.BorderSize = 0;
            this.BTNOur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNOur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNOur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOur.ForeColor = System.Drawing.Color.SpringGreen;
            this.BTNOur.Location = new System.Drawing.Point(0, 0);
            this.BTNOur.Name = "BTNOur";
            this.BTNOur.Size = new System.Drawing.Size(798, 44);
            this.BTNOur.TabIndex = 15;
            this.BTNOur.Text = "DIFFICULTY";
            this.BTNOur.UseVisualStyleBackColor = false;
            this.BTNOur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTNOur_MouseDown);
            this.BTNOur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTNOur_MouseMove);
            this.BTNOur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTNOur_MouseUp);
            // 
            // BTNClose
            // 
            this.BTNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNClose.BackColor = System.Drawing.Color.Aqua;
            this.BTNClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.ForeColor = System.Drawing.Color.Black;
            this.BTNClose.Location = new System.Drawing.Point(765, 0);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(33, 31);
            this.BTNClose.TabIndex = 16;
            this.BTNClose.Text = "X";
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // BTNMinimize
            // 
            this.BTNMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNMinimize.BackColor = System.Drawing.Color.Teal;
            this.BTNMinimize.FlatAppearance.BorderSize = 0;
            this.BTNMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMinimize.Location = new System.Drawing.Point(735, 0);
            this.BTNMinimize.Name = "BTNMinimize";
            this.BTNMinimize.Size = new System.Drawing.Size(31, 31);
            this.BTNMinimize.TabIndex = 17;
            this.BTNMinimize.Text = "_";
            this.BTNMinimize.UseVisualStyleBackColor = false;
            this.BTNMinimize.Click += new System.EventHandler(this.BTNMinimize_Click);
            // 
            // BTNOurTrigger
            // 
            this.BTNOurTrigger.BackColor = System.Drawing.Color.Transparent;
            this.BTNOurTrigger.FlatAppearance.BorderSize = 0;
            this.BTNOurTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BTNOurTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNOurTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOurTrigger.Location = new System.Drawing.Point(0, -2);
            this.BTNOurTrigger.Name = "BTNOurTrigger";
            this.BTNOurTrigger.Size = new System.Drawing.Size(46, 46);
            this.BTNOurTrigger.TabIndex = 18;
            this.BTNOurTrigger.UseVisualStyleBackColor = false;
            this.BTNOurTrigger.Click += new System.EventHandler(this.BTNOurTrigger_Click);
            // 
            // PCBox1
            // 
            this.PCBox1.BackColor = System.Drawing.Color.Transparent;
            this.PCBox1.Location = new System.Drawing.Point(0, -2);
            this.PCBox1.Name = "PCBox1";
            this.PCBox1.Size = new System.Drawing.Size(46, 46);
            this.PCBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBox1.TabIndex = 19;
            this.PCBox1.TabStop = false;
            this.PCBox1.Visible = false;
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::Minesweeper.Properties.Resources.Soldiers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 396);
            this.Controls.Add(this.PCBox1);
            this.Controls.Add(this.BTNOurTrigger);
            this.Controls.Add(this.BTNMinimize);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNOur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBLives);
            this.Controls.Add(this.TBMines);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.TBHeight);
            this.Controls.Add(this.RBCustom);
            this.Controls.Add(this.BTNOk);
            this.Controls.Add(this.RBHard);
            this.Controls.Add(this.RBMedium);
            this.Controls.Add(this.RBEasy);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Ninja Naruto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
            ((System.ComponentModel.ISupportInitialize)(this.PCBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBEasy;
        private System.Windows.Forms.RadioButton RBMedium;
        private System.Windows.Forms.RadioButton RBHard;
        private System.Windows.Forms.Button BTNOk;
        private System.Windows.Forms.RadioButton RBCustom;
        private System.Windows.Forms.TextBox TBHeight;
        private System.Windows.Forms.TextBox TBWidth;
        private System.Windows.Forms.TextBox TBMines;
        private System.Windows.Forms.TextBox TBLives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNOur;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Button BTNMinimize;
        private System.Windows.Forms.Button BTNOurTrigger;
        private System.Windows.Forms.PictureBox PCBox1;
    }
}