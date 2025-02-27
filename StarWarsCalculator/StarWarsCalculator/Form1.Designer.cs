namespace StarWarsCalculator
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
            this.txt_Input1 = new System.Windows.Forms.TextBox();
            this.txt_Input2 = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Remainder = new System.Windows.Forms.Button();
            this.lbl_DanielTitle = new System.Windows.Forms.Label();
            this.lbl_Input1 = new System.Windows.Forms.Label();
            this.lbl_Input2 = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Input1
            // 
            this.txt_Input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Input1.Location = new System.Drawing.Point(675, 296);
            this.txt_Input1.Multiline = true;
            this.txt_Input1.Name = "txt_Input1";
            this.txt_Input1.Size = new System.Drawing.Size(406, 57);
            this.txt_Input1.TabIndex = 0;
            this.txt_Input1.TextChanged += new System.EventHandler(this.txt_Input1_TextChanged);
            // 
            // txt_Input2
            // 
            this.txt_Input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_Input2.Location = new System.Drawing.Point(675, 404);
            this.txt_Input2.Multiline = true;
            this.txt_Input2.Name = "txt_Input2";
            this.txt_Input2.Size = new System.Drawing.Size(406, 57);
            this.txt_Input2.TabIndex = 1;
            this.txt_Input2.TextChanged += new System.EventHandler(this.txt_Input2_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(146)))), ((int)(((byte)(115)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(145)))), ((int)(((byte)(141)))));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.btn_Add.Location = new System.Drawing.Point(48, 542);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(224, 51);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(146)))), ((int)(((byte)(115)))));
            this.btn_Minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.btn_Minus.Location = new System.Drawing.Point(306, 542);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(224, 51);
            this.btn_Minus.TabIndex = 3;
            this.btn_Minus.Text = "SUBSTRACT";
            this.btn_Minus.UseVisualStyleBackColor = false;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(146)))), ((int)(((byte)(115)))));
            this.btn_Multiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.btn_Multiply.Location = new System.Drawing.Point(564, 542);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(224, 51);
            this.btn_Multiply.TabIndex = 4;
            this.btn_Multiply.Text = "MULTIPY";
            this.btn_Multiply.UseVisualStyleBackColor = false;
            this.btn_Multiply.Click += new System.EventHandler(this.btn_Multiply_Click);
            // 
            // btn_Divide
            // 
            this.btn_Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(146)))), ((int)(((byte)(115)))));
            this.btn_Divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.btn_Divide.Location = new System.Drawing.Point(830, 542);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(224, 51);
            this.btn_Divide.TabIndex = 5;
            this.btn_Divide.Text = "DIVIDE";
            this.btn_Divide.UseVisualStyleBackColor = false;
            this.btn_Divide.Click += new System.EventHandler(this.btn_Divide_Click);
            // 
            // btn_Remainder
            // 
            this.btn_Remainder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(146)))), ((int)(((byte)(115)))));
            this.btn_Remainder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.btn_Remainder.Location = new System.Drawing.Point(1089, 542);
            this.btn_Remainder.Name = "btn_Remainder";
            this.btn_Remainder.Size = new System.Drawing.Size(224, 51);
            this.btn_Remainder.TabIndex = 6;
            this.btn_Remainder.Text = "REMAINDER";
            this.btn_Remainder.UseVisualStyleBackColor = false;
            this.btn_Remainder.Click += new System.EventHandler(this.btn_Remainder_Click);
            // 
            // lbl_DanielTitle
            // 
            this.lbl_DanielTitle.AutoSize = true;
            this.lbl_DanielTitle.Font = new System.Drawing.Font("Elephant", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanielTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.lbl_DanielTitle.Location = new System.Drawing.Point(26, 67);
            this.lbl_DanielTitle.Name = "lbl_DanielTitle";
            this.lbl_DanielTitle.Size = new System.Drawing.Size(1258, 129);
            this.lbl_DanielTitle.TabIndex = 7;
            this.lbl_DanielTitle.Text = "Mandolorian Calculator";
            this.lbl_DanielTitle.Click += new System.EventHandler(this.DanielTitle_Click);
            // 
            // lbl_Input1
            // 
            this.lbl_Input1.AutoSize = true;
            this.lbl_Input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Input1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.lbl_Input1.Location = new System.Drawing.Point(175, 296);
            this.lbl_Input1.Name = "lbl_Input1";
            this.lbl_Input1.Size = new System.Drawing.Size(299, 46);
            this.lbl_Input1.TabIndex = 8;
            this.lbl_Input1.Text = "Enter 1st Input: ";
            // 
            // lbl_Input2
            // 
            this.lbl_Input2.AutoSize = true;
            this.lbl_Input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Input2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(26)))));
            this.lbl_Input2.Location = new System.Drawing.Point(175, 415);
            this.lbl_Input2.Name = "lbl_Input2";
            this.lbl_Input2.Size = new System.Drawing.Size(290, 46);
            this.lbl_Input2.TabIndex = 9;
            this.lbl_Input2.Text = "Enter 2nd Input";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_Result.Location = new System.Drawing.Point(405, 622);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(475, 69);
            this.lbl_Result.TabIndex = 10;
            this.lbl_Result.Text = "This is the way!: ";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Result.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1340, 794);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_Input2);
            this.Controls.Add(this.lbl_Input1);
            this.Controls.Add(this.lbl_DanielTitle);
            this.Controls.Add(this.btn_Remainder);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Input2);
            this.Controls.Add(this.txt_Input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Input1;
        private System.Windows.Forms.TextBox txt_Input2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Remainder;
        private System.Windows.Forms.Label lbl_DanielTitle;
        private System.Windows.Forms.Label lbl_Input1;
        private System.Windows.Forms.Label lbl_Input2;
        private System.Windows.Forms.Label lbl_Result;
    }
}

