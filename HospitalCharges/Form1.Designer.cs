namespace HospitalCharges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBaseFee = new System.Windows.Forms.TextBox();
            this.textBoxMedFee = new System.Windows.Forms.TextBox();
            this.textBoxSurgFee = new System.Windows.Forms.TextBox();
            this.textBoxLabFee = new System.Windows.Forms.TextBox();
            this.textBoxRehabFee = new System.Windows.Forms.TextBox();
            this.textBoxTotalFee = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days in hospitial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physical rehab. fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Charges";
            // 
            // textBoxBaseFee
            // 
            this.textBoxBaseFee.Location = new System.Drawing.Point(133, 9);
            this.textBoxBaseFee.Name = "textBoxBaseFee";
            this.textBoxBaseFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseFee.TabIndex = 6;
            // 
            // textBoxMedFee
            // 
            this.textBoxMedFee.Location = new System.Drawing.Point(133, 35);
            this.textBoxMedFee.Name = "textBoxMedFee";
            this.textBoxMedFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedFee.TabIndex = 7;
            // 
            // textBoxSurgFee
            // 
            this.textBoxSurgFee.Location = new System.Drawing.Point(133, 63);
            this.textBoxSurgFee.Name = "textBoxSurgFee";
            this.textBoxSurgFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurgFee.TabIndex = 8;
            // 
            // textBoxLabFee
            // 
            this.textBoxLabFee.Location = new System.Drawing.Point(133, 89);
            this.textBoxLabFee.Name = "textBoxLabFee";
            this.textBoxLabFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxLabFee.TabIndex = 9;
            // 
            // textBoxRehabFee
            // 
            this.textBoxRehabFee.Location = new System.Drawing.Point(133, 115);
            this.textBoxRehabFee.Name = "textBoxRehabFee";
            this.textBoxRehabFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxRehabFee.TabIndex = 10;
            // 
            // textBoxTotalFee
            // 
            this.textBoxTotalFee.Location = new System.Drawing.Point(133, 146);
            this.textBoxTotalFee.Name = "textBoxTotalFee";
            this.textBoxTotalFee.ReadOnly = true;
            this.textBoxTotalFee.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalFee.TabIndex = 11;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(10, 189);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(68, 52);
            this.buttonCalc.TabIndex = 12;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(109, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 52);
            this.button4.TabIndex = 15;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 52);
            this.button5.TabIndex = 16;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(10, 265);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 290);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxTotalFee);
            this.Controls.Add(this.textBoxRehabFee);
            this.Controls.Add(this.textBoxLabFee);
            this.Controls.Add(this.textBoxSurgFee);
            this.Controls.Add(this.textBoxMedFee);
            this.Controls.Add(this.textBoxBaseFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospitial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBaseFee;
        private System.Windows.Forms.TextBox textBoxMedFee;
        private System.Windows.Forms.TextBox textBoxSurgFee;
        private System.Windows.Forms.TextBox textBoxLabFee;
        private System.Windows.Forms.TextBox textBoxRehabFee;
        private System.Windows.Forms.TextBox textBoxTotalFee;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelStatus;
    }
}

