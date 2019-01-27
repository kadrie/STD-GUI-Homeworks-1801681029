namespace GuessTheNumber
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
            this.cBLevels = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.pBUpOrDown = new System.Windows.Forms.PictureBox();
            this.pBResult = new System.Windows.Forms.PictureBox();
            this.lblChooseLevel = new System.Windows.Forms.Label();
            this.lblGuessTheRandomNum = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBUpOrDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBResult)).BeginInit();
            this.SuspendLayout();
            // 
            // cBLevels
            // 
            this.cBLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBLevels.FormattingEnabled = true;
            this.cBLevels.Items.AddRange(new object[] {
            "0-20",
            "20-50",
            "50-100"});
            this.cBLevels.Location = new System.Drawing.Point(168, 70);
            this.cBLevels.Name = "cBLevels";
            this.cBLevels.Size = new System.Drawing.Size(121, 21);
            this.cBLevels.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPlay.Location = new System.Drawing.Point(377, 70);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbUserInput
            // 
            this.tbUserInput.Location = new System.Drawing.Point(78, 244);
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(138, 20);
            this.tbUserInput.TabIndex = 2;
            // 
            // pBUpOrDown
            // 
            this.pBUpOrDown.Image = global::GuessTheNumber.Properties.Resources.images;
            this.pBUpOrDown.Location = new System.Drawing.Point(264, 214);
            this.pBUpOrDown.Name = "pBUpOrDown";
            this.pBUpOrDown.Size = new System.Drawing.Size(188, 159);
            this.pBUpOrDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBUpOrDown.TabIndex = 4;
            this.pBUpOrDown.TabStop = false;
            // 
            // pBResult
            // 
            this.pBResult.Image = global::GuessTheNumber.Properties.Resources.Paula_Barrett_Thumbs_Up_Actions;
            this.pBResult.Location = new System.Drawing.Point(520, 214);
            this.pBResult.Name = "pBResult";
            this.pBResult.Size = new System.Drawing.Size(179, 159);
            this.pBResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBResult.TabIndex = 3;
            this.pBResult.TabStop = false;
            // 
            // lblChooseLevel
            // 
            this.lblChooseLevel.AutoSize = true;
            this.lblChooseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChooseLevel.Location = new System.Drawing.Point(165, 30);
            this.lblChooseLevel.Name = "lblChooseLevel";
            this.lblChooseLevel.Size = new System.Drawing.Size(89, 17);
            this.lblChooseLevel.TabIndex = 5;
            this.lblChooseLevel.Text = "Choose level";
            // 
            // lblGuessTheRandomNum
            // 
            this.lblGuessTheRandomNum.AutoSize = true;
            this.lblGuessTheRandomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGuessTheRandomNum.Location = new System.Drawing.Point(39, 214);
            this.lblGuessTheRandomNum.Name = "lblGuessTheRandomNum";
            this.lblGuessTheRandomNum.Size = new System.Drawing.Size(177, 17);
            this.lblGuessTheRandomNum.TabIndex = 6;
            this.lblGuessTheRandomNum.Text = "Guess the random number";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(78, 303);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(78, 13);
            this.lblCounter.TabIndex = 7;
            this.lblCounter.Text = "Number of tries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblGuessTheRandomNum);
            this.Controls.Add(this.lblChooseLevel);
            this.Controls.Add(this.pBUpOrDown);
            this.Controls.Add(this.pBResult);
            this.Controls.Add(this.tbUserInput);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cBLevels);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBUpOrDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBLevels;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbUserInput;
        private System.Windows.Forms.PictureBox pBResult;
        private System.Windows.Forms.PictureBox pBUpOrDown;
        private System.Windows.Forms.Label lblChooseLevel;
        private System.Windows.Forms.Label lblGuessTheRandomNum;
        private System.Windows.Forms.Label lblCounter;
    }
}

