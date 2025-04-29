namespace Fraction_Calc
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
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Den1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Den2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.lbl_ResultN = new System.Windows.Forms.Label();
            this.lbl_ResultD = new System.Windows.Forms.Label();
            this.btn_Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Num1
            // 
            this.txt_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Num1.Location = new System.Drawing.Point(77, 128);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 35);
            this.txt_Num1.TabIndex = 0;
            // 
            // txt_Den1
            // 
            this.txt_Den1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Den1.Location = new System.Drawing.Point(77, 202);
            this.txt_Den1.Name = "txt_Den1";
            this.txt_Den1.Size = new System.Drawing.Size(100, 35);
            this.txt_Den1.TabIndex = 1;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Num2.Location = new System.Drawing.Point(371, 128);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 35);
            this.txt_Num2.TabIndex = 2;
            // 
            // txt_Den2
            // 
            this.txt_Den2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Den2.Location = new System.Drawing.Point(371, 202);
            this.txt_Den2.Name = "txt_Den2";
            this.txt_Den2.Size = new System.Drawing.Size(100, 35);
            this.txt_Den2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "--------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "--------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "--------------------";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(61, 323);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(121, 74);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Location = new System.Drawing.Point(286, 323);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(121, 74);
            this.btn_Sub.TabIndex = 10;
            this.btn_Sub.Text = "Subtract";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.Location = new System.Drawing.Point(487, 323);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Size = new System.Drawing.Size(121, 74);
            this.btn_Mult.TabIndex = 11;
            this.btn_Mult.Text = "Multiply";
            this.btn_Mult.UseVisualStyleBackColor = true;
            this.btn_Mult.Click += new System.EventHandler(this.btn_Mult_Click);
            // 
            // lbl_ResultN
            // 
            this.lbl_ResultN.AutoSize = true;
            this.lbl_ResultN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ResultN.Location = new System.Drawing.Point(691, 134);
            this.lbl_ResultN.Name = "lbl_ResultN";
            this.lbl_ResultN.Size = new System.Drawing.Size(99, 29);
            this.lbl_ResultN.TabIndex = 12;
            this.lbl_ResultN.Text = "ResultN";
            // 
            // lbl_ResultD
            // 
            this.lbl_ResultD.AutoSize = true;
            this.lbl_ResultD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_ResultD.Location = new System.Drawing.Point(691, 208);
            this.lbl_ResultD.Name = "lbl_ResultD";
            this.lbl_ResultD.Size = new System.Drawing.Size(98, 29);
            this.lbl_ResultD.TabIndex = 13;
            this.lbl_ResultD.Text = "ResultD";
            // 
            // btn_Div
            // 
            this.btn_Div.Location = new System.Drawing.Point(696, 323);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(121, 74);
            this.btn_Div.TabIndex = 14;
            this.btn_Div.Text = "Divide";
            this.btn_Div.UseVisualStyleBackColor = true;
            this.btn_Div.Click += new System.EventHandler(this.btn_Div_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.lbl_ResultD);
            this.Controls.Add(this.lbl_ResultN);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Den2);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Den1);
            this.Controls.Add(this.txt_Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Den1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Den2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.Label lbl_ResultN;
        private System.Windows.Forms.Label lbl_ResultD;
        private System.Windows.Forms.Button btn_Div;
    }
}

