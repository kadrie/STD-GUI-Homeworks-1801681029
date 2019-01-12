namespace ButtonCounter
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
            this.btnClickCounter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumberOfClicks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickCounter
            // 
            this.btnClickCounter.Location = new System.Drawing.Point(609, 124);
            this.btnClickCounter.Name = "btnClickCounter";
            this.btnClickCounter.Size = new System.Drawing.Size(215, 23);
            this.btnClickCounter.TabIndex = 0;
            this.btnClickCounter.Text = "change color";
            this.btnClickCounter.UseVisualStyleBackColor = true;
            this.btnClickCounter.Click += new System.EventHandler(this.btnClickCounter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(299, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumberOfClicks
            // 
            this.lblNumberOfClicks.AutoSize = true;
            this.lblNumberOfClicks.Location = new System.Drawing.Point(508, 215);
            this.lblNumberOfClicks.Name = "lblNumberOfClicks";
            this.lblNumberOfClicks.Size = new System.Drawing.Size(86, 13);
            this.lblNumberOfClicks.TabIndex = 2;
            this.lblNumberOfClicks.Text = "Number of clicks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 407);
            this.Controls.Add(this.lblNumberOfClicks);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClickCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickCounter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumberOfClicks;
    }
}

