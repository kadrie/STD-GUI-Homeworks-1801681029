namespace Rock_Scissors_Paper
{
    partial class Form1
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
            this.pBPaper = new System.Windows.Forms.PictureBox();
            this.pBScissors = new System.Windows.Forms.PictureBox();
            this.pBStone = new System.Windows.Forms.PictureBox();
            this.pBPlayer = new System.Windows.Forms.PictureBox();
            this.pBComputer = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblChosenPic = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEnteredUsername = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResultUser = new System.Windows.Forms.Label();
            this.lblResultComp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBComputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pBPaper
            // 
            this.pBPaper.Image = global::Rock_Scissors_Paper.Properties.Resources.paper;
            this.pBPaper.Location = new System.Drawing.Point(596, 321);
            this.pBPaper.Name = "pBPaper";
            this.pBPaper.Size = new System.Drawing.Size(165, 104);
            this.pBPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBPaper.TabIndex = 4;
            this.pBPaper.TabStop = false;
            this.pBPaper.Click += new System.EventHandler(this.pBPaper_Click);
            // 
            // pBScissors
            // 
            this.pBScissors.Image = global::Rock_Scissors_Paper.Properties.Resources.scissors;
            this.pBScissors.Location = new System.Drawing.Point(382, 321);
            this.pBScissors.Name = "pBScissors";
            this.pBScissors.Size = new System.Drawing.Size(137, 104);
            this.pBScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBScissors.TabIndex = 3;
            this.pBScissors.TabStop = false;
            this.pBScissors.Click += new System.EventHandler(this.pBScissors_Click);
            // 
            // pBStone
            // 
            this.pBStone.Image = global::Rock_Scissors_Paper.Properties.Resources.stone;
            this.pBStone.Location = new System.Drawing.Point(145, 321);
            this.pBStone.Name = "pBStone";
            this.pBStone.Size = new System.Drawing.Size(167, 104);
            this.pBStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBStone.TabIndex = 2;
            this.pBStone.TabStop = false;
            this.pBStone.Click += new System.EventHandler(this.pBStone_Click);
            // 
            // pBPlayer
            // 
            this.pBPlayer.Location = new System.Drawing.Point(160, 140);
            this.pBPlayer.Name = "pBPlayer";
            this.pBPlayer.Size = new System.Drawing.Size(133, 93);
            this.pBPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBPlayer.TabIndex = 1;
            this.pBPlayer.TabStop = false;
            // 
            // pBComputer
            // 
            this.pBComputer.Location = new System.Drawing.Point(713, 140);
            this.pBComputer.Name = "pBComputer";
            this.pBComputer.Size = new System.Drawing.Size(154, 93);
            this.pBComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBComputer.TabIndex = 0;
            this.pBComputer.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblUsername.Location = new System.Drawing.Point(263, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(145, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Enter your username:";
            // 
            // lblChosenPic
            // 
            this.lblChosenPic.AutoSize = true;
            this.lblChosenPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChosenPic.Location = new System.Drawing.Point(379, 284);
            this.lblChosenPic.Name = "lblChosenPic";
            this.lblChosenPic.Size = new System.Drawing.Size(139, 17);
            this.lblChosenPic.TabIndex = 6;
            this.lblChosenPic.Text = "Choose your picture:";
            // 
            // tBUsername
            // 
            this.tBUsername.Location = new System.Drawing.Point(431, 41);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(149, 20);
            this.tBUsername.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnStart.Location = new System.Drawing.Point(443, 77);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblResult.Location = new System.Drawing.Point(440, 182);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 17);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Result:";
            // 
            // lblEnteredUsername
            // 
            this.lblEnteredUsername.AutoSize = true;
            this.lblEnteredUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEnteredUsername.Location = new System.Drawing.Point(169, 107);
            this.lblEnteredUsername.Name = "lblEnteredUsername";
            this.lblEnteredUsername.Size = new System.Drawing.Size(73, 17);
            this.lblEnteredUsername.TabIndex = 11;
            this.lblEnteredUsername.Text = "Username";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblComputer.Location = new System.Drawing.Point(725, 107);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(69, 17);
            this.lblComputer.TabIndex = 12;
            this.lblComputer.Text = "Computer";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClose.Location = new System.Drawing.Point(804, 390);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnReset.Location = new System.Drawing.Point(804, 321);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblResultUser
            // 
            this.lblResultUser.AutoSize = true;
            this.lblResultUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblResultUser.Location = new System.Drawing.Point(372, 219);
            this.lblResultUser.Name = "lblResultUser";
            this.lblResultUser.Size = new System.Drawing.Size(24, 26);
            this.lblResultUser.TabIndex = 15;
            this.lblResultUser.Text = "0";
            // 
            // lblResultComp
            // 
            this.lblResultComp.AutoSize = true;
            this.lblResultComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblResultComp.Location = new System.Drawing.Point(526, 219);
            this.lblResultComp.Name = "lblResultComp";
            this.lblResultComp.Size = new System.Drawing.Size(24, 26);
            this.lblResultComp.TabIndex = 16;
            this.lblResultComp.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.lblResultComp);
            this.Controls.Add(this.lblResultUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblEnteredUsername);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.lblChosenPic);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pBPaper);
            this.Controls.Add(this.pBScissors);
            this.Controls.Add(this.pBStone);
            this.Controls.Add(this.pBPlayer);
            this.Controls.Add(this.pBComputer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBComputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBComputer;
        private System.Windows.Forms.PictureBox pBPlayer;
        private System.Windows.Forms.PictureBox pBStone;
        private System.Windows.Forms.PictureBox pBScissors;
        private System.Windows.Forms.PictureBox pBPaper;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblChosenPic;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEnteredUsername;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResultUser;
        private System.Windows.Forms.Label lblResultComp;
    }
}

