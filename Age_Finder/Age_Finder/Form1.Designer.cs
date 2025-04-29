namespace Age_Finder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.dtp_DOD = new System.Windows.Forms.DateTimePicker();
            this.lbl_DOD = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(57, 73);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(270, 26);
            this.dtp_DOB.TabIndex = 0;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Location = new System.Drawing.Point(65, 38);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(148, 20);
            this.lbl_DOB.TabIndex = 1;
            this.lbl_DOB.Text = "Select Date of Birth";
            // 
            // dtp_DOD
            // 
            this.dtp_DOD.Location = new System.Drawing.Point(511, 72);
            this.dtp_DOD.Name = "dtp_DOD";
            this.dtp_DOD.Size = new System.Drawing.Size(277, 26);
            this.dtp_DOD.TabIndex = 2;
            // 
            // lbl_DOD
            // 
            this.lbl_DOD.AutoSize = true;
            this.lbl_DOD.Location = new System.Drawing.Point(507, 38);
            this.lbl_DOD.Name = "lbl_DOD";
            this.lbl_DOD.Size = new System.Drawing.Size(159, 20);
            this.lbl_DOD.TabIndex = 3;
            this.lbl_DOD.Text = "Select Date of Death";
            // 
            // btn_Calc
            // 
            this.btn_Calc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Calc.Location = new System.Drawing.Point(552, 158);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(105, 38);
            this.btn_Calc.TabIndex = 4;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Result.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Result.Location = new System.Drawing.Point(50, 364);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(607, 37);
            this.lbl_Result.TabIndex = 5;
            this.lbl_Result.Text = "How old was the person when they died? ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.lbl_DOD);
            this.Controls.Add(this.dtp_DOD);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.dtp_DOB);
            this.Name = "Form1";
            this.Text = "Daniel | Age Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.DateTimePicker dtp_DOD;
        private System.Windows.Forms.Label lbl_DOD;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label lbl_Result;
    }
}

