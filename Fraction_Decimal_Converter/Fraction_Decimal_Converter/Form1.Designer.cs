namespace Fraction_Decimal_Converter
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
            this.nud_Numerator = new System.Windows.Forms.NumericUpDown();
            this.nud_Denominator = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Numerator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Denominator)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Numerator
            // 
            this.nud_Numerator.Location = new System.Drawing.Point(126, 160);
            this.nud_Numerator.Name = "nud_Numerator";
            this.nud_Numerator.Size = new System.Drawing.Size(120, 26);
            this.nud_Numerator.TabIndex = 0;
            this.nud_Numerator.ValueChanged += new System.EventHandler(this.nud_Numerator_ValueChanged);
            // 
            // nud_Denominator
            // 
            this.nud_Denominator.Location = new System.Drawing.Point(126, 242);
            this.nud_Denominator.Name = "nud_Denominator";
            this.nud_Denominator.Size = new System.Drawing.Size(120, 26);
            this.nud_Denominator.TabIndex = 1;
            this.nud_Denominator.ValueChanged += new System.EventHandler(this.nud_Denominator_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "-----------------------";
            // 
            // btn_Equal
            // 
            this.btn_Equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Equal.Location = new System.Drawing.Point(287, 189);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(103, 54);
            this.btn_Equal.TabIndex = 3;
            this.btn_Equal.Text = "Equals";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Result.Location = new System.Drawing.Point(473, 196);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(97, 34);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.Text = "Result";
            this.lbl_Result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Denominator);
            this.Controls.Add(this.nud_Numerator);
            this.Name = "Form1";
            this.Text = "Daniel | Fraction Converter";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Numerator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Denominator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Numerator;
        private System.Windows.Forms.NumericUpDown nud_Denominator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Label lbl_Result;
    }
}

