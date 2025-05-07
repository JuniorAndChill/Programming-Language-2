namespace Spring_Final_Q2
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
            this.tbx_Letter = new System.Windows.Forms.TextBox();
            this.tbx_Number = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Shift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Letter
            // 
            this.tbx_Letter.Location = new System.Drawing.Point(110, 131);
            this.tbx_Letter.Name = "tbx_Letter";
            this.tbx_Letter.Size = new System.Drawing.Size(100, 26);
            this.tbx_Letter.TabIndex = 0;
            // 
            // tbx_Number
            // 
            this.tbx_Number.Location = new System.Drawing.Point(381, 131);
            this.tbx_Number.Name = "tbx_Number";
            this.tbx_Number.Size = new System.Drawing.Size(100, 26);
            this.tbx_Number.TabIndex = 1;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(248, 327);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(106, 20);
            this.lbl_Result.TabIndex = 2;
            this.lbl_Result.Text = "Shifted Letter";
            // 
            // btn_Shift
            // 
            this.btn_Shift.Location = new System.Drawing.Point(252, 217);
            this.btn_Shift.Name = "btn_Shift";
            this.btn_Shift.Size = new System.Drawing.Size(89, 63);
            this.btn_Shift.TabIndex = 3;
            this.btn_Shift.Text = "Shift";
            this.btn_Shift.UseVisualStyleBackColor = true;
            this.btn_Shift.Click += new System.EventHandler(this.btn_Shift_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.btn_Shift);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.tbx_Number);
            this.Controls.Add(this.tbx_Letter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Letter;
        private System.Windows.Forms.TextBox tbx_Number;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Shift;
    }
}

