namespace Prime_Number_Generator
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.lbl_Daniel_Title = new System.Windows.Forms.Label();
            this.txb_Limit = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_LimitSet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_generate.Location = new System.Drawing.Point(958, 192);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(170, 62);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // lbl_Daniel_Title
            // 
            this.lbl_Daniel_Title.AutoSize = true;
            this.lbl_Daniel_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lbl_Daniel_Title.Location = new System.Drawing.Point(58, 48);
            this.lbl_Daniel_Title.Name = "lbl_Daniel_Title";
            this.lbl_Daniel_Title.Size = new System.Drawing.Size(1148, 82);
            this.lbl_Daniel_Title.TabIndex = 1;
            this.lbl_Daniel_Title.Text = "Daniel\'s Prime Number Generator";
            // 
            // txb_Limit
            // 
            this.txb_Limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txb_Limit.Location = new System.Drawing.Point(711, 192);
            this.txb_Limit.Name = "txb_Limit";
            this.txb_Limit.Size = new System.Drawing.Size(174, 62);
            this.txb_Limit.TabIndex = 2;
            this.txb_Limit.TextChanged += new System.EventHandler(this.txb_Limit_TextChanged);
            // 
            // lbl_Result
            // 
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Result.Location = new System.Drawing.Point(12, 283);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(1234, 732);
            this.lbl_Result.TabIndex = 3;
            this.lbl_Result.Text = "Results: ";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Result.Visible = false;
            this.lbl_Result.Click += new System.EventHandler(this.lbl_Result_Click);
            // 
            // lbl_LimitSet
            // 
            this.lbl_LimitSet.AutoSize = true;
            this.lbl_LimitSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_LimitSet.Location = new System.Drawing.Point(137, 199);
            this.lbl_LimitSet.Name = "lbl_LimitSet";
            this.lbl_LimitSet.Size = new System.Drawing.Size(552, 55);
            this.lbl_LimitSet.TabIndex = 4;
            this.lbl_LimitSet.Text = "Prime numbers from 1 to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(259, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "**Enter 2-1000**";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1258, 1024);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_LimitSet);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txb_Limit);
            this.Controls.Add(this.lbl_Daniel_Title);
            this.Controls.Add(this.btn_generate);
            this.Name = "Form1";
            this.Text = "Prime Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label lbl_Daniel_Title;
        private System.Windows.Forms.TextBox txb_Limit;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_LimitSet;
        private System.Windows.Forms.Label label1;
    }
}

