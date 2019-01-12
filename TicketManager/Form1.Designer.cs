namespace TicketManager
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
            this.txtBoxAmountOfTickets = new System.Windows.Forms.TextBox();
            this.btnValidateMyOrder = new System.Windows.Forms.Button();
            this.rdBtnKids = new System.Windows.Forms.RadioButton();
            this.rdBtnStudents = new System.Windows.Forms.RadioButton();
            this.rdBtnUniStudent = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxAmountOfTickets
            // 
            this.txtBoxAmountOfTickets.Location = new System.Drawing.Point(213, 178);
            this.txtBoxAmountOfTickets.Name = "txtBoxAmountOfTickets";
            this.txtBoxAmountOfTickets.Size = new System.Drawing.Size(140, 20);
            this.txtBoxAmountOfTickets.TabIndex = 0;
            this.txtBoxAmountOfTickets.Text = "Въведете брой билети";
            
            // 
            // btnValidateMyOrder
            // 
            this.btnValidateMyOrder.Location = new System.Drawing.Point(391, 175);
            this.btnValidateMyOrder.Name = "btnValidateMyOrder";
            this.btnValidateMyOrder.Size = new System.Drawing.Size(75, 23);
            this.btnValidateMyOrder.TabIndex = 1;
            this.btnValidateMyOrder.Text = "Купувам";
            this.btnValidateMyOrder.UseVisualStyleBackColor = true;
            this.btnValidateMyOrder.Click += new System.EventHandler(this.btnValidateMyOrder_Click);
            // 
            // rdBtnKids
            // 
            this.rdBtnKids.AutoSize = true;
            this.rdBtnKids.Location = new System.Drawing.Point(213, 99);
            this.rdBtnKids.Name = "rdBtnKids";
            this.rdBtnKids.Size = new System.Drawing.Size(128, 17);
            this.rdBtnKids.TabIndex = 2;
            this.rdBtnKids.TabStop = true;
            this.rdBtnKids.Text = "Детски билет - 3 лв.";
            this.rdBtnKids.UseVisualStyleBackColor = true;
           
            // 
            // rdBtnStudents
            // 
            this.rdBtnStudents.AutoSize = true;
            this.rdBtnStudents.Location = new System.Drawing.Point(213, 122);
            this.rdBtnStudents.Name = "rdBtnStudents";
            this.rdBtnStudents.Size = new System.Drawing.Size(92, 17);
            this.rdBtnStudents.TabIndex = 3;
            this.rdBtnStudents.TabStop = true;
            this.rdBtnStudents.Text = "Ученик - 4лв.";
            this.rdBtnStudents.UseVisualStyleBackColor = true;
            
            // 
            // rdBtnUniStudent
            // 
            this.rdBtnUniStudent.AutoSize = true;
            this.rdBtnUniStudent.Location = new System.Drawing.Point(213, 145);
            this.rdBtnUniStudent.Name = "rdBtnUniStudent";
            this.rdBtnUniStudent.Size = new System.Drawing.Size(95, 17);
            this.rdBtnUniStudent.TabIndex = 4;
            this.rdBtnUniStudent.TabStop = true;
            this.rdBtnUniStudent.Text = "Студент - 5лв.";
            this.rdBtnUniStudent.UseVisualStyleBackColor = true;
            
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(210, 232);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Крайна цена";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 404);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.rdBtnUniStudent);
            this.Controls.Add(this.rdBtnStudents);
            this.Controls.Add(this.rdBtnKids);
            this.Controls.Add(this.btnValidateMyOrder);
            this.Controls.Add(this.txtBoxAmountOfTickets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAmountOfTickets;
        private System.Windows.Forms.Button btnValidateMyOrder;
        private System.Windows.Forms.RadioButton rdBtnKids;
        private System.Windows.Forms.RadioButton rdBtnStudents;
        private System.Windows.Forms.RadioButton rdBtnUniStudent;
        private System.Windows.Forms.Label lblPrice;
    }
}

