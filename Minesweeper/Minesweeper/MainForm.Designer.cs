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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LBLLives = new System.Windows.Forms.Label();
            this.LBLFlags = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBLTime = new System.Windows.Forms.Label();
            this.BTNClose = new System.Windows.Forms.Button();
            this.BTNMinimize = new System.Windows.Forms.Button();
            this.PCBox1 = new System.Windows.Forms.PictureBox();
            this.BTNMinesweeper = new System.Windows.Forms.Button();
            this.BTNGame = new System.Windows.Forms.Button();
            this.BTNReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PCBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLLives
            // 
            this.LBLLives.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LBLLives.AutoSize = true;
            this.LBLLives.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLives.Location = new System.Drawing.Point(75, 49);
            this.LBLLives.Name = "LBLLives";
            this.LBLLives.Size = new System.Drawing.Size(54, 12);
            this.LBLLives.TabIndex = 2;
            this.LBLLives.Text = "Lives: 0";
            // 
            // LBLFlags
            // 
            this.LBLFlags.AutoSize = true;
            this.LBLFlags.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFlags.Location = new System.Drawing.Point(4, 49);
            this.LBLFlags.Name = "LBLFlags";
            this.LBLFlags.Size = new System.Drawing.Size(54, 12);
            this.LBLFlags.TabIndex = 3;
            this.LBLFlags.Text = "Flags: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBLTime
            // 
            this.LBLTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTime.Location = new System.Drawing.Point(135, 49);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(45, 12);
            this.LBLTime.TabIndex = 4;
            this.LBLTime.Text = "Time: 0";
            // 
            // BTNClose
            // 
            this.BTNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNClose.BackColor = System.Drawing.Color.Aqua;
            this.BTNClose.FlatAppearance.BorderSize = 0;
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.ForeColor = System.Drawing.Color.Black;
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
            this.BTNMinimize.BackColor = System.Drawing.Color.Teal;
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
            // PCBox1
            // 
            this.PCBox1.BackColor = System.Drawing.Color.Teal;
            this.PCBox1.Image = global::Minesweeper.Properties.Resources.Mine;
            this.PCBox1.Location = new System.Drawing.Point(0, 0);
            this.PCBox1.Name = "PCBox1";
            this.PCBox1.Size = new System.Drawing.Size(23, 23);
            this.PCBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBox1.TabIndex = 10;
            this.PCBox1.TabStop = false;
            // 
            // BTNMinesweeper
            // 
            this.BTNMinesweeper.BackColor = System.Drawing.Color.Teal;
            this.BTNMinesweeper.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNMinesweeper.FlatAppearance.BorderSize = 0;
            this.BTNMinesweeper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BTNMinesweeper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BTNMinesweeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMinesweeper.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMinesweeper.Image = ((System.Drawing.Image)(resources.GetObject("BTNMinesweeper.Image")));
            this.BTNMinesweeper.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            // BTNGame
            // 
            this.BTNGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGame.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGame.Image = ((System.Drawing.Image)(resources.GetObject("BTNGame.Image")));
            this.BTNGame.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTNGame.Location = new System.Drawing.Point(0, 23);
            this.BTNGame.Name = "BTNGame";
            this.BTNGame.Size = new System.Drawing.Size(91, 23);
            this.BTNGame.TabIndex = 6;
            this.BTNGame.Text = "Game";
            this.BTNGame.UseVisualStyleBackColor = true;
            this.BTNGame.Click += new System.EventHandler(this.BTNGame_Click);
            // 
            // BTNReset
            // 
            this.BTNReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReset.Font = new System.Drawing.Font("Ninja Naruto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReset.Image = global::Minesweeper.Properties.Resources.iconfinder_update_678134;
            this.BTNReset.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BTNReset.Location = new System.Drawing.Point(112, 23);
            this.BTNReset.Name = "BTNReset";
            this.BTNReset.Size = new System.Drawing.Size(86, 23);
            this.BTNReset.TabIndex = 5;
            this.BTNReset.Text = "Reset";
            this.BTNReset.UseVisualStyleBackColor = true;
            this.BTNReset.Click += new System.EventHandler(this.BTNReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(198, 138);
            this.Controls.Add(this.PCBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PCBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLLives;
        private System.Windows.Forms.Label LBLFlags;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBLTime;
        private System.Windows.Forms.Button BTNGame;
        private System.Windows.Forms.Button BTNMinesweeper;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Button BTNMinimize;
        private System.Windows.Forms.PictureBox PCBox1;
        private System.Windows.Forms.Button BTNReset;
    }
}

