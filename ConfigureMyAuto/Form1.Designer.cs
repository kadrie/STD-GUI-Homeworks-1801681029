namespace ConfigureMyAuto
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
            this.pBCars = new System.Windows.Forms.PictureBox();
            this.rBAlfa = new System.Windows.Forms.RadioButton();
            this.rBBmwM4 = new System.Windows.Forms.RadioButton();
            this.rBMustang = new System.Windows.Forms.RadioButton();
            this.chBABS = new System.Windows.Forms.CheckBox();
            this.chBFogLights = new System.Windows.Forms.CheckBox();
            this.chBChains = new System.Windows.Forms.CheckBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tBDiscount = new System.Windows.Forms.TextBox();
            this.tBFinalPrice = new System.Windows.Forms.TextBox();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.rBCreditCard = new System.Windows.Forms.RadioButton();
            this.rBCash = new System.Windows.Forms.RadioButton();
            this.rBCheck = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pBCars
            // 
            this.pBCars.Image = global::ConfigureMyAuto.Properties.Resources.alfa_romeo_gtv_illo_christianschulte_1530629520;
            this.pBCars.Location = new System.Drawing.Point(36, 12);
            this.pBCars.Name = "pBCars";
            this.pBCars.Size = new System.Drawing.Size(543, 333);
            this.pBCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCars.TabIndex = 0;
            this.pBCars.TabStop = false;
            // 
            // rBAlfa
            // 
            this.rBAlfa.AutoSize = true;
            this.rBAlfa.Location = new System.Drawing.Point(636, 57);
            this.rBAlfa.Name = "rBAlfa";
            this.rBAlfa.Size = new System.Drawing.Size(109, 17);
            this.rBAlfa.TabIndex = 1;
            this.rBAlfa.TabStop = true;
            this.rBAlfa.Text = "Alfa Romeo Giulia";
            this.rBAlfa.UseVisualStyleBackColor = true;
            this.rBAlfa.CheckedChanged += new System.EventHandler(this.rBAlfa_CheckedChanged);
            // 
            // rBBmwM4
            // 
            this.rBBmwM4.AutoSize = true;
            this.rBBmwM4.Location = new System.Drawing.Point(636, 80);
            this.rBBmwM4.Name = "rBBmwM4";
            this.rBBmwM4.Size = new System.Drawing.Size(70, 17);
            this.rBBmwM4.TabIndex = 2;
            this.rBBmwM4.TabStop = true;
            this.rBBmwM4.Text = "BMW M4";
            this.rBBmwM4.UseVisualStyleBackColor = true;
            this.rBBmwM4.CheckedChanged += new System.EventHandler(this.rBBmwM4_CheckedChanged);
            // 
            // rBMustang
            // 
            this.rBMustang.AutoSize = true;
            this.rBMustang.Location = new System.Drawing.Point(636, 103);
            this.rBMustang.Name = "rBMustang";
            this.rBMustang.Size = new System.Drawing.Size(128, 17);
            this.rBMustang.TabIndex = 3;
            this.rBMustang.TabStop = true;
            this.rBMustang.Text = "Ford Mustang Shelby ";
            this.rBMustang.UseVisualStyleBackColor = true;
            this.rBMustang.CheckedChanged += new System.EventHandler(this.rBMustang_CheckedChanged);
            // 
            // chBABS
            // 
            this.chBABS.AutoSize = true;
            this.chBABS.Location = new System.Drawing.Point(636, 172);
            this.chBABS.Name = "chBABS";
            this.chBABS.Size = new System.Drawing.Size(47, 17);
            this.chBABS.TabIndex = 4;
            this.chBABS.Text = "ABS";
            this.chBABS.UseVisualStyleBackColor = true;
            this.chBABS.CheckedChanged += new System.EventHandler(this.chBABS_CheckedChanged);
            // 
            // chBFogLights
            // 
            this.chBFogLights.AutoSize = true;
            this.chBFogLights.Location = new System.Drawing.Point(636, 195);
            this.chBFogLights.Name = "chBFogLights";
            this.chBFogLights.Size = new System.Drawing.Size(95, 17);
            this.chBFogLights.TabIndex = 5;
            this.chBFogLights.Text = "LED Fog lights";
            this.chBFogLights.UseVisualStyleBackColor = true;
            this.chBFogLights.CheckedChanged += new System.EventHandler(this.chBFogLights_CheckedChanged);
            // 
            // chBChains
            // 
            this.chBChains.AutoSize = true;
            this.chBChains.Location = new System.Drawing.Point(636, 218);
            this.chBChains.Name = "chBChains";
            this.chBChains.Size = new System.Drawing.Size(87, 17);
            this.chBChains.TabIndex = 6;
            this.chBChains.Text = "Snow chains";
            this.chBChains.UseVisualStyleBackColor = true;
            this.chBChains.CheckedChanged += new System.EventHandler(this.chBChains_CheckedChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblModel.Location = new System.Drawing.Point(633, 22);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(114, 17);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Choose a model.";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblExtras.Location = new System.Drawing.Point(633, 139);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(104, 17);
            this.lblExtras.TabIndex = 8;
            this.lblExtras.Text = "Optional Extras";
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(934, 44);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(118, 20);
            this.tBPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPrice.Location = new System.Drawing.Point(884, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDiscount.Location = new System.Drawing.Point(861, 79);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 17);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Discount:";
            // 
            // tBDiscount
            // 
            this.tBDiscount.Location = new System.Drawing.Point(934, 77);
            this.tBDiscount.Name = "tBDiscount";
            this.tBDiscount.Size = new System.Drawing.Size(117, 20);
            this.tBDiscount.TabIndex = 12;
            // 
            // tBFinalPrice
            // 
            this.tBFinalPrice.Location = new System.Drawing.Point(935, 136);
            this.tBFinalPrice.Name = "tBFinalPrice";
            this.tBFinalPrice.Size = new System.Drawing.Size(117, 20);
            this.tBFinalPrice.TabIndex = 13;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFinalPrice.Location = new System.Drawing.Point(850, 139);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(78, 17);
            this.lblFinalPrice.TabIndex = 14;
            this.lblFinalPrice.Text = "Final Price:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPayment.Location = new System.Drawing.Point(850, 193);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(174, 17);
            this.lblPayment.TabIndex = 15;
            this.lblPayment.Text = "Choose a way of payment:";
            // 
            // rBCreditCard
            // 
            this.rBCreditCard.AutoSize = true;
            this.rBCreditCard.Location = new System.Drawing.Point(853, 218);
            this.rBCreditCard.Name = "rBCreditCard";
            this.rBCreditCard.Size = new System.Drawing.Size(76, 17);
            this.rBCreditCard.TabIndex = 16;
            this.rBCreditCard.TabStop = true;
            this.rBCreditCard.Text = "Credit card";
            this.rBCreditCard.UseVisualStyleBackColor = true;
            // 
            // rBCash
            // 
            this.rBCash.AutoSize = true;
            this.rBCash.Location = new System.Drawing.Point(853, 241);
            this.rBCash.Name = "rBCash";
            this.rBCash.Size = new System.Drawing.Size(49, 17);
            this.rBCash.TabIndex = 17;
            this.rBCash.TabStop = true;
            this.rBCash.Text = "Cash";
            this.rBCash.UseVisualStyleBackColor = true;
            this.rBCash.CheckedChanged += new System.EventHandler(this.rBCash_CheckedChanged);
            // 
            // rBCheck
            // 
            this.rBCheck.AutoSize = true;
            this.rBCheck.Location = new System.Drawing.Point(853, 264);
            this.rBCheck.Name = "rBCheck";
            this.rBCheck.Size = new System.Drawing.Size(56, 17);
            this.rBCheck.TabIndex = 18;
            this.rBCheck.TabStop = true;
            this.rBCheck.Text = "Check";
            this.rBCheck.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCalculate.Location = new System.Drawing.Point(852, 99);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(199, 33);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate final price:";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 457);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rBCheck);
            this.Controls.Add(this.rBCash);
            this.Controls.Add(this.rBCreditCard);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.tBFinalPrice);
            this.Controls.Add(this.tBDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tBPrice);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.chBChains);
            this.Controls.Add(this.chBFogLights);
            this.Controls.Add(this.chBABS);
            this.Controls.Add(this.rBMustang);
            this.Controls.Add(this.rBBmwM4);
            this.Controls.Add(this.rBAlfa);
            this.Controls.Add(this.pBCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBCars;
        private System.Windows.Forms.RadioButton rBAlfa;
        private System.Windows.Forms.RadioButton rBBmwM4;
        private System.Windows.Forms.RadioButton rBMustang;
        private System.Windows.Forms.CheckBox chBABS;
        private System.Windows.Forms.CheckBox chBFogLights;
        private System.Windows.Forms.CheckBox chBChains;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox tBDiscount;
        private System.Windows.Forms.TextBox tBFinalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.RadioButton rBCreditCard;
        private System.Windows.Forms.RadioButton rBCash;
        private System.Windows.Forms.RadioButton rBCheck;
        private System.Windows.Forms.Button btnCalculate;
    }
}

