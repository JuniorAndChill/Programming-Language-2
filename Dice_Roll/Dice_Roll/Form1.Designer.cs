namespace Dice_Roll
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbx_Dice1 = new System.Windows.Forms.PictureBox();
            this.pbx_Dice2 = new System.Windows.Forms.PictureBox();
            this.pbx_Dice3 = new System.Windows.Forms.PictureBox();
            this.pbx_Dice4 = new System.Windows.Forms.PictureBox();
            this.pbx_Dice5 = new System.Windows.Forms.PictureBox();
            this.pbx_Dice6 = new System.Windows.Forms.PictureBox();
            this.pbx_Result = new System.Windows.Forms.PictureBox();
            this.btn_Roll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(152, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(626, 39);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(781, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbx_Dice1
            // 
            this.pbx_Dice1.Location = new System.Drawing.Point(152, 157);
            this.pbx_Dice1.Name = "pbx_Dice1";
            this.pbx_Dice1.Size = new System.Drawing.Size(65, 65);
            this.pbx_Dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Dice1.TabIndex = 2;
            this.pbx_Dice1.TabStop = false;
            // 
            // pbx_Dice2
            // 
            this.pbx_Dice2.Location = new System.Drawing.Point(248, 157);
            this.pbx_Dice2.Name = "pbx_Dice2";
            this.pbx_Dice2.Size = new System.Drawing.Size(65, 65);
            this.pbx_Dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Dice2.TabIndex = 3;
            this.pbx_Dice2.TabStop = false;
            // 
            // pbx_Dice3
            // 
            this.pbx_Dice3.Location = new System.Drawing.Point(345, 157);
            this.pbx_Dice3.Name = "pbx_Dice3";
            this.pbx_Dice3.Size = new System.Drawing.Size(65, 65);
            this.pbx_Dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Dice3.TabIndex = 4;
            this.pbx_Dice3.TabStop = false;
            // 
            // pbx_Dice4
            // 
            this.pbx_Dice4.Location = new System.Drawing.Point(445, 157);
            this.pbx_Dice4.Name = "pbx_Dice4";
            this.pbx_Dice4.Size = new System.Drawing.Size(65, 65);
            this.pbx_Dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Dice4.TabIndex = 5;
            this.pbx_Dice4.TabStop = false;
            // 
            // pbx_Dice5
            // 
            this.pbx_Dice5.Location = new System.Drawing.Point(549, 157);
            this.pbx_Dice5.Name = "pbx_Dice5";
            this.pbx_Dice5.Size = new System.Drawing.Size(65, 65);
            this.pbx_Dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Dice5.TabIndex = 6;
            this.pbx_Dice5.TabStop = false;
            // 
            // pbx_Dice6
            // 
            this.pbx_Dice6.Location = new System.Drawing.Point(644, 157);
            this.pbx_Dice6.Name = "pbx_Dice6";
            this.pbx_Dice6.Size = new System.Drawing.Size(65, 65);
            this.pbx_Dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Dice6.TabIndex = 7;
            this.pbx_Dice6.TabStop = false;
            // 
            // pbx_Result
            // 
            this.pbx_Result.Location = new System.Drawing.Point(152, 298);
            this.pbx_Result.Name = "pbx_Result";
            this.pbx_Result.Size = new System.Drawing.Size(300, 300);
            this.pbx_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_Result.TabIndex = 8;
            this.pbx_Result.TabStop = false;
            this.pbx_Result.Visible = false;
            // 
            // btn_Roll
            // 
            this.btn_Roll.Location = new System.Drawing.Point(560, 396);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(111, 107);
            this.btn_Roll.TabIndex = 9;
            this.btn_Roll.Text = "Roll!";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 656);
            this.Controls.Add(this.btn_Roll);
            this.Controls.Add(this.pbx_Result);
            this.Controls.Add(this.pbx_Dice6);
            this.Controls.Add(this.pbx_Dice5);
            this.Controls.Add(this.pbx_Dice4);
            this.Controls.Add(this.pbx_Dice3);
            this.Controls.Add(this.pbx_Dice2);
            this.Controls.Add(this.pbx_Dice1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Dice Roll! | Daniel";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Dice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbx_Dice1;
        private System.Windows.Forms.PictureBox pbx_Dice2;
        private System.Windows.Forms.PictureBox pbx_Dice3;
        private System.Windows.Forms.PictureBox pbx_Dice4;
        private System.Windows.Forms.PictureBox pbx_Dice5;
        private System.Windows.Forms.PictureBox pbx_Dice6;
        private System.Windows.Forms.PictureBox pbx_Result;
        private System.Windows.Forms.Button btn_Roll;
    }
}

