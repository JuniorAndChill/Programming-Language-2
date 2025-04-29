namespace RandomCountrySelector
{
    partial class Random_Country_Gen
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
            this.cbx_Country = new System.Windows.Forms.ComboBox();
            this.lbx_Country = new System.Windows.Forms.ListBox();
            this.btn_Random = new System.Windows.Forms.Button();
            this.tbx_Entry = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbx_Country
            // 
            this.cbx_Country.FormattingEnabled = true;
            this.cbx_Country.Items.AddRange(new object[] {
            "Australia",
            "Brazil",
            "Canada",
            "China",
            "Egypt",
            "France",
            "Germany",
            "India",
            "Italy",
            "Japan",
            "Mexico",
            "Nigeria",
            "South Africa",
            "United Kingdom",
            "United States"});
            this.cbx_Country.Location = new System.Drawing.Point(622, 131);
            this.cbx_Country.Name = "cbx_Country";
            this.cbx_Country.Size = new System.Drawing.Size(223, 28);
            this.cbx_Country.TabIndex = 0;
            this.cbx_Country.SelectedIndexChanged += new System.EventHandler(this.cbx_Country_SelectedIndexChanged);
            // 
            // lbx_Country
            // 
            this.lbx_Country.FormattingEnabled = true;
            this.lbx_Country.ItemHeight = 20;
            this.lbx_Country.Items.AddRange(new object[] {
            "Australia",
            "Brazil",
            "Canada",
            "China",
            "Egypt",
            "France",
            "Germany",
            "India",
            "Italy",
            "Japan",
            "Mexico",
            "Nigeria",
            "South Africa",
            "United Kingdom",
            "United States"});
            this.lbx_Country.Location = new System.Drawing.Point(31, 131);
            this.lbx_Country.Name = "lbx_Country";
            this.lbx_Country.ScrollAlwaysVisible = true;
            this.lbx_Country.Size = new System.Drawing.Size(157, 484);
            this.lbx_Country.TabIndex = 1;
            this.lbx_Country.SelectedIndexChanged += new System.EventHandler(this.lbx_Country_SelectedIndexChanged);
            // 
            // btn_Random
            // 
            this.btn_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Random.Location = new System.Drawing.Point(680, 577);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(119, 38);
            this.btn_Random.TabIndex = 2;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // tbx_Entry
            // 
            this.tbx_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbx_Entry.Location = new System.Drawing.Point(194, 61);
            this.tbx_Entry.Name = "tbx_Entry";
            this.tbx_Entry.Size = new System.Drawing.Size(406, 35);
            this.tbx_Entry.TabIndex = 3;
            this.tbx_Entry.TextChanged += new System.EventHandler(this.tbx_Entry_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Add.Location = new System.Drawing.Point(622, 51);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 45);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Result.Location = new System.Drawing.Point(263, 551);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(411, 64);
            this.lbl_Result.TabIndex = 5;
            this.lbl_Result.Text = "Result";
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Result.Visible = false;
            this.lbl_Result.Click += new System.EventHandler(this.lbl_Result_Click);
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Country.Location = new System.Drawing.Point(46, 59);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(129, 37);
            this.lbl_Country.TabIndex = 6;
            this.lbl_Country.Text = "Country";
            // 
            // Random_Country_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 652);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_Entry);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.lbx_Country);
            this.Controls.Add(this.cbx_Country);
            this.Name = "Random_Country_Gen";
            this.Text = "Daniel Random Country Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Country;
        private System.Windows.Forms.ListBox lbx_Country;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.TextBox tbx_Entry;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Label lbl_Country;
    }
}

