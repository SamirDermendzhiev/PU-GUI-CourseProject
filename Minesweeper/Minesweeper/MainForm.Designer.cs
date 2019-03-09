namespace Minesweeper
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.LBLLives = new System.Windows.Forms.Label();
            this.LBLFlags = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBLTime = new System.Windows.Forms.Label();
            this.BTNReset = new System.Windows.Forms.Button();
            this.BTNGame = new System.Windows.Forms.Button();
            this.BTNMinesweeper = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.BTNMinimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLLives
            // 
            this.LBLLives.AutoSize = true;
            this.LBLLives.Location = new System.Drawing.Point(47, 49);
            this.LBLLives.Name = "LBLLives";
            this.LBLLives.Size = new System.Drawing.Size(44, 13);
            this.LBLLives.TabIndex = 2;
            this.LBLLives.Text = "Lives: 0";
            // 
            // LBLFlags
            // 
            this.LBLFlags.AutoSize = true;
            this.LBLFlags.Location = new System.Drawing.Point(1, 50);
            this.LBLFlags.Name = "LBLFlags";
            this.LBLFlags.Size = new System.Drawing.Size(44, 13);
            this.LBLFlags.TabIndex = 3;
            this.LBLFlags.Text = "Flags: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Location = new System.Drawing.Point(97, 49);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(42, 13);
            this.LBLTime.TabIndex = 4;
            this.LBLTime.Text = "Time: 0";
            // 
            // BTNReset
            // 
            this.BTNReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReset.Location = new System.Drawing.Point(75, 23);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(75, 23);
            this.BTNReset.TabIndex = 5;
            this.BTNReset.Text = "Reset";
            this.BTNReset.UseVisualStyleBackColor = true;
            this.BTNReset.Click += new System.EventHandler(this.BTNReset_Click);
            // 
            // BTNGame
            // 
            this.BTNGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGame.Location = new System.Drawing.Point(0, 23);
            this.BTNGame.Name = "BTNGame";
            this.BTNGame.Size = new System.Drawing.Size(75, 23);
            this.BTNGame.TabIndex = 6;
            this.BTNGame.Text = "Game";
            this.BTNGame.UseVisualStyleBackColor = true;
            this.BTNGame.Click += new System.EventHandler(this.BTNGame_Click);
            // 
            // BTNMinesweeper
            // 
            this.BTNMinesweeper.BackColor = System.Drawing.Color.DimGray;
            this.BTNMinesweeper.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNMinesweeper.FlatAppearance.BorderSize = 0;
            this.BTNMinesweeper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.BTNMinesweeper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BTNMinesweeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMinesweeper.Location = new System.Drawing.Point(0, 0);
            this.BTNMinesweeper.Name = "BTNMinesweeper";
            this.BTNMinesweeper.Size = new System.Drawing.Size(198, 23);
            this.BTNMinesweeper.TabIndex = 7;
            this.BTNMinesweeper.Text = "Minesweeper";
            this.BTNMinesweeper.UseVisualStyleBackColor = false;
            this.BTNMinesweeper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTNMinesweeper_MouseDown);
            this.BTNMinesweeper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTNMinesweeper_MouseMove);
            this.BTNMinesweeper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BTNMinesweeper_MouseUp);
            // 
            // BTNClose
            // 
            this.BTNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNClose.BackColor = System.Drawing.Color.Red;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.ForeColor = System.Drawing.Color.White;
            this.BTNClose.Location = new System.Drawing.Point(172, 0);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(26, 23);
            this.BTNClose.TabIndex = 8;
            this.BTNClose.Text = "X";
            this.BTNClose.UseVisualStyleBackColor = false;
            this.BTNClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNMinimize
            // 
            this.BTNMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMinimize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNMinimize.BackColor = System.Drawing.Color.DimGray;
            this.BTNMinimize.FlatAppearance.BorderSize = 0;
            this.BTNMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMinimize.Location = new System.Drawing.Point(140, 0);
            this.BTNMinimize.Name = "BTNMinimize";
            this.BTNMinimize.Size = new System.Drawing.Size(26, 23);
            this.BTNMinimize.TabIndex = 9;
            this.BTNMinimize.Text = "__";
            this.BTNMinimize.UseVisualStyleBackColor = false;
            this.BTNMinimize.Click += new System.EventHandler(this.BTNMinimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(198, 138);
            this.Controls.Add(this.BTNMinimize);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNMinesweeper);
            this.Controls.Add(this.BTNGame);
            this.Controls.Add(this.BTNReset);
            this.Controls.Add(this.LBLTime);
            this.Controls.Add(this.LBLFlags);
            this.Controls.Add(this.LBLLives);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLLives;
        private System.Windows.Forms.Label LBLFlags;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBLTime;
        private System.Windows.Forms.Button BTNReset;
        private System.Windows.Forms.Button BTNGame;
        private System.Windows.Forms.Button BTNMinesweeper;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Button BTNMinimize;
    }
}

