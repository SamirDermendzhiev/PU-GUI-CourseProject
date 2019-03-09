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
            this.TBFieldSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RBEasy
            // 
            this.RBEasy.AutoSize = true;
            this.RBEasy.Location = new System.Drawing.Point(13, 14);
            this.RBEasy.Name = "RBEasy";
            this.RBEasy.Size = new System.Drawing.Size(48, 17);
            this.RBEasy.TabIndex = 0;
            this.RBEasy.TabStop = true;
            this.RBEasy.Text = "Easy";
            this.RBEasy.UseVisualStyleBackColor = true;
            this.RBEasy.CheckedChanged += new System.EventHandler(this.RBEasy_CheckedChanged);
            // 
            // RBMedium
            // 
            this.RBMedium.AutoSize = true;
            this.RBMedium.Location = new System.Drawing.Point(13, 37);
            this.RBMedium.Name = "RBMedium";
            this.RBMedium.Size = new System.Drawing.Size(62, 17);
            this.RBMedium.TabIndex = 1;
            this.RBMedium.TabStop = true;
            this.RBMedium.Text = "Medium";
            this.RBMedium.UseVisualStyleBackColor = true;
            this.RBMedium.CheckedChanged += new System.EventHandler(this.RBMedium_CheckedChanged);
            // 
            // RBHard
            // 
            this.RBHard.AutoSize = true;
            this.RBHard.Location = new System.Drawing.Point(13, 61);
            this.RBHard.Name = "RBHard";
            this.RBHard.Size = new System.Drawing.Size(48, 17);
            this.RBHard.TabIndex = 2;
            this.RBHard.TabStop = true;
            this.RBHard.Text = "Hard";
            this.RBHard.UseVisualStyleBackColor = true;
            this.RBHard.CheckedChanged += new System.EventHandler(this.RBHard_CheckedChanged);
            // 
            // BTNOk
            // 
            this.BTNOk.Location = new System.Drawing.Point(13, 84);
            this.BTNOk.Name = "BTNOk";
            this.BTNOk.Size = new System.Drawing.Size(75, 23);
            this.BTNOk.TabIndex = 3;
            this.BTNOk.Text = "OK";
            this.BTNOk.UseVisualStyleBackColor = true;
            this.BTNOk.Click += new System.EventHandler(this.BTNOk_Click);
            // 
            // RBCustom
            // 
            this.RBCustom.AutoSize = true;
            this.RBCustom.Location = new System.Drawing.Point(150, 14);
            this.RBCustom.Name = "RBCustom";
            this.RBCustom.Size = new System.Drawing.Size(60, 17);
            this.RBCustom.TabIndex = 4;
            this.RBCustom.TabStop = true;
            this.RBCustom.Text = "Custom";
            this.RBCustom.UseVisualStyleBackColor = true;
            // 
            // TBHeight
            // 
            this.TBHeight.Location = new System.Drawing.Point(150, 37);
            this.TBHeight.Name = "TBHeight";
            this.TBHeight.Size = new System.Drawing.Size(100, 20);
            this.TBHeight.TabIndex = 5;
            // 
            // TBWidth
            // 
            this.TBWidth.Location = new System.Drawing.Point(150, 64);
            this.TBWidth.Name = "TBWidth";
            this.TBWidth.Size = new System.Drawing.Size(100, 20);
            this.TBWidth.TabIndex = 6;
            // 
            // TBMines
            // 
            this.TBMines.Location = new System.Drawing.Point(150, 91);
            this.TBMines.Name = "TBMines";
            this.TBMines.Size = new System.Drawing.Size(100, 20);
            this.TBMines.TabIndex = 7;
            // 
            // TBLives
            // 
            this.TBLives.Location = new System.Drawing.Point(48, 120);
            this.TBLives.Name = "TBLives";
            this.TBLives.Size = new System.Drawing.Size(100, 20);
            this.TBLives.TabIndex = 8;
            this.TBLives.Text = "3";
            // 
            // TBFieldSize
            // 
            this.TBFieldSize.Location = new System.Drawing.Point(214, 120);
            this.TBFieldSize.Name = "TBFieldSize";
            this.TBFieldSize.Size = new System.Drawing.Size(100, 20);
            this.TBFieldSize.TabIndex = 9;
            this.TBFieldSize.Text = "23";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mines";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Lives";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Field size";
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 289);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBFieldSize);
            this.Controls.Add(this.TBLives);
            this.Controls.Add(this.TBMines);
            this.Controls.Add(this.TBWidth);
            this.Controls.Add(this.TBHeight);
            this.Controls.Add(this.RBCustom);
            this.Controls.Add(this.BTNOk);
            this.Controls.Add(this.RBHard);
            this.Controls.Add(this.RBMedium);
            this.Controls.Add(this.RBEasy);
            this.Name = "Difficulty";
            this.Text = "Difficulty";
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
        private System.Windows.Forms.TextBox TBFieldSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}