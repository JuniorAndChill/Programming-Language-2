namespace Spring_Final_Q3
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
            this.pbx_Animal = new System.Windows.Forms.PictureBox();
            this.btn_Rand = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Animal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_Animal
            // 
            this.pbx_Animal.Image = global::Spring_Final_Q3.Properties.Resources._5_Jaguar;
            this.pbx_Animal.Location = new System.Drawing.Point(567, 109);
            this.pbx_Animal.Name = "pbx_Animal";
            this.pbx_Animal.Size = new System.Drawing.Size(303, 301);
            this.pbx_Animal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Animal.TabIndex = 0;
            this.pbx_Animal.TabStop = false;
            // 
            // btn_Rand
            // 
            this.btn_Rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Rand.Location = new System.Drawing.Point(214, 172);
            this.btn_Rand.Name = "btn_Rand";
            this.btn_Rand.Size = new System.Drawing.Size(218, 167);
            this.btn_Rand.TabIndex = 1;
            this.btn_Rand.Text = "Random";
            this.btn_Rand.UseVisualStyleBackColor = true;
            this.btn_Rand.Click += new System.EventHandler(this.btn_Rand_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(639, 450);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(55, 20);
            this.lbl_Result.TabIndex = 2;
            this.lbl_Result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 589);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Rand);
            this.Controls.Add(this.pbx_Animal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Animal;
        private System.Windows.Forms.Button btn_Rand;
        private System.Windows.Forms.Label lbl_Result;
    }
}

