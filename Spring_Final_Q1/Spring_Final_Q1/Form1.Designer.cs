namespace Spring_Final_Q1
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.txb_n1 = new System.Windows.Forms.TextBox();
            this.txb_n2 = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_result.Location = new System.Drawing.Point(12, 334);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(66, 25);
            this.lbl_result.TabIndex = 0;
            this.lbl_result.Text = "Result";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_result.Visible = false;
            this.lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // txb_n1
            // 
            this.txb_n1.Location = new System.Drawing.Point(236, 105);
            this.txb_n1.Name = "txb_n1";
            this.txb_n1.Size = new System.Drawing.Size(100, 26);
            this.txb_n1.TabIndex = 1;
            // 
            // txb_n2
            // 
            this.txb_n2.Location = new System.Drawing.Point(566, 105);
            this.txb_n2.Name = "txb_n2";
            this.txb_n2.Size = new System.Drawing.Size(100, 26);
            this.txb_n2.TabIndex = 2;
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_generate.Location = new System.Drawing.Point(392, 202);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(128, 77);
            this.btn_generate.TabIndex = 3;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(338, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter 2 integers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txb_n2);
            this.Controls.Add(this.txb_n1);
            this.Controls.Add(this.lbl_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txb_n1;
        private System.Windows.Forms.TextBox txb_n2;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label1;
    }
}

