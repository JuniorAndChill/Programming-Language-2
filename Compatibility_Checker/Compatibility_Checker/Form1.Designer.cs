namespace Compatibility_Checker
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
            this.gbx_Age = new System.Windows.Forms.GroupBox();
            this.rdb_Child = new System.Windows.Forms.RadioButton();
            this.rdb_Adult = new System.Windows.Forms.RadioButton();
            this.rdb_Senior = new System.Windows.Forms.RadioButton();
            this.gbx_Aura = new System.Windows.Forms.GroupBox();
            this.rdb_Blue = new System.Windows.Forms.RadioButton();
            this.rdb_Green = new System.Windows.Forms.RadioButton();
            this.rdb_Red = new System.Windows.Forms.RadioButton();
            this.gbx_Traits = new System.Windows.Forms.GroupBox();
            this.clb_Traits = new System.Windows.Forms.CheckedListBox();
            this.btn_Age = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.btn_Traits = new System.Windows.Forms.Button();
            this.bar_Progress = new System.Windows.Forms.ProgressBar();
            this.lbl_Compatibility = new System.Windows.Forms.Label();
            this.nud_Pets = new System.Windows.Forms.NumericUpDown();
            this.lbl_Pets = new System.Windows.Forms.Label();
            this.gbx_Age.SuspendLayout();
            this.gbx_Aura.SuspendLayout();
            this.gbx_Traits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pets)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Age
            // 
            this.gbx_Age.Controls.Add(this.btn_Age);
            this.gbx_Age.Controls.Add(this.rdb_Senior);
            this.gbx_Age.Controls.Add(this.rdb_Adult);
            this.gbx_Age.Controls.Add(this.rdb_Child);
            this.gbx_Age.Location = new System.Drawing.Point(55, 99);
            this.gbx_Age.Name = "gbx_Age";
            this.gbx_Age.Size = new System.Drawing.Size(205, 176);
            this.gbx_Age.TabIndex = 0;
            this.gbx_Age.TabStop = false;
            this.gbx_Age.Text = "Age (Adds 5, 10, 15)";
            this.gbx_Age.Enter += new System.EventHandler(this.gbx_Age_Enter);
            // 
            // rdb_Child
            // 
            this.rdb_Child.AutoSize = true;
            this.rdb_Child.Location = new System.Drawing.Point(3, 29);
            this.rdb_Child.Name = "rdb_Child";
            this.rdb_Child.Size = new System.Drawing.Size(69, 24);
            this.rdb_Child.TabIndex = 0;
            this.rdb_Child.Text = "Child";
            this.rdb_Child.UseVisualStyleBackColor = true;
            // 
            // rdb_Adult
            // 
            this.rdb_Adult.AutoSize = true;
            this.rdb_Adult.Location = new System.Drawing.Point(3, 59);
            this.rdb_Adult.Name = "rdb_Adult";
            this.rdb_Adult.Size = new System.Drawing.Size(71, 24);
            this.rdb_Adult.TabIndex = 1;
            this.rdb_Adult.Text = "Adult";
            this.rdb_Adult.UseVisualStyleBackColor = true;
            // 
            // rdb_Senior
            // 
            this.rdb_Senior.AutoSize = true;
            this.rdb_Senior.Location = new System.Drawing.Point(3, 89);
            this.rdb_Senior.Name = "rdb_Senior";
            this.rdb_Senior.Size = new System.Drawing.Size(80, 24);
            this.rdb_Senior.TabIndex = 2;
            this.rdb_Senior.Text = "Senior";
            this.rdb_Senior.UseVisualStyleBackColor = true;
            // 
            // gbx_Aura
            // 
            this.gbx_Aura.Controls.Add(this.btn_Color);
            this.gbx_Aura.Controls.Add(this.rdb_Blue);
            this.gbx_Aura.Controls.Add(this.rdb_Green);
            this.gbx_Aura.Controls.Add(this.rdb_Red);
            this.gbx_Aura.Location = new System.Drawing.Point(715, 99);
            this.gbx_Aura.Name = "gbx_Aura";
            this.gbx_Aura.Size = new System.Drawing.Size(225, 176);
            this.gbx_Aura.TabIndex = 3;
            this.gbx_Aura.TabStop = false;
            this.gbx_Aura.Text = "Color of Aura (Adds 5)";
            this.gbx_Aura.Enter += new System.EventHandler(this.gbx_Aura_Enter);
            // 
            // rdb_Blue
            // 
            this.rdb_Blue.AutoSize = true;
            this.rdb_Blue.Location = new System.Drawing.Point(3, 89);
            this.rdb_Blue.Name = "rdb_Blue";
            this.rdb_Blue.Size = new System.Drawing.Size(66, 24);
            this.rdb_Blue.TabIndex = 2;
            this.rdb_Blue.TabStop = true;
            this.rdb_Blue.Text = "Blue";
            this.rdb_Blue.UseVisualStyleBackColor = true;
            // 
            // rdb_Green
            // 
            this.rdb_Green.AutoSize = true;
            this.rdb_Green.Location = new System.Drawing.Point(3, 59);
            this.rdb_Green.Name = "rdb_Green";
            this.rdb_Green.Size = new System.Drawing.Size(79, 24);
            this.rdb_Green.TabIndex = 1;
            this.rdb_Green.TabStop = true;
            this.rdb_Green.Text = "Green";
            this.rdb_Green.UseVisualStyleBackColor = true;
            // 
            // rdb_Red
            // 
            this.rdb_Red.AutoSize = true;
            this.rdb_Red.Location = new System.Drawing.Point(3, 29);
            this.rdb_Red.Name = "rdb_Red";
            this.rdb_Red.Size = new System.Drawing.Size(64, 24);
            this.rdb_Red.TabIndex = 0;
            this.rdb_Red.TabStop = true;
            this.rdb_Red.Text = "Red";
            this.rdb_Red.UseVisualStyleBackColor = true;
            // 
            // gbx_Traits
            // 
            this.gbx_Traits.Controls.Add(this.btn_Traits);
            this.gbx_Traits.Controls.Add(this.clb_Traits);
            this.gbx_Traits.Location = new System.Drawing.Point(363, 99);
            this.gbx_Traits.Name = "gbx_Traits";
            this.gbx_Traits.Size = new System.Drawing.Size(230, 336);
            this.gbx_Traits.TabIndex = 4;
            this.gbx_Traits.TabStop = false;
            this.gbx_Traits.Text = "Traits (Adds 1 each)";
            this.gbx_Traits.Enter += new System.EventHandler(this.gbx_Traits_Enter);
            // 
            // clb_Traits
            // 
            this.clb_Traits.FormattingEnabled = true;
            this.clb_Traits.Items.AddRange(new object[] {
            "Fun",
            "Intellegent",
            "Adventurous",
            "Honest",
            "Understanding",
            "Responsible",
            "Enjoys Food",
            "Kind",
            "Movie Lover",
            "Clean"});
            this.clb_Traits.Location = new System.Drawing.Point(6, 29);
            this.clb_Traits.Name = "clb_Traits";
            this.clb_Traits.Size = new System.Drawing.Size(218, 234);
            this.clb_Traits.TabIndex = 0;
            // 
            // btn_Age
            // 
            this.btn_Age.Location = new System.Drawing.Point(23, 132);
            this.btn_Age.Name = "btn_Age";
            this.btn_Age.Size = new System.Drawing.Size(134, 35);
            this.btn_Age.TabIndex = 5;
            this.btn_Age.Text = "Submit Age";
            this.btn_Age.UseVisualStyleBackColor = true;
            this.btn_Age.Click += new System.EventHandler(this.btn_Age_Click);
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(29, 132);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(134, 35);
            this.btn_Color.TabIndex = 6;
            this.btn_Color.Text = "Submit Color";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_Traits
            // 
            this.btn_Traits.Location = new System.Drawing.Point(34, 281);
            this.btn_Traits.Name = "btn_Traits";
            this.btn_Traits.Size = new System.Drawing.Size(134, 35);
            this.btn_Traits.TabIndex = 6;
            this.btn_Traits.Text = "Submit";
            this.btn_Traits.UseVisualStyleBackColor = true;
            this.btn_Traits.Click += new System.EventHandler(this.btn_Traits_Click);
            // 
            // bar_Progress
            // 
            this.bar_Progress.Location = new System.Drawing.Point(218, 544);
            this.bar_Progress.Name = "bar_Progress";
            this.bar_Progress.Size = new System.Drawing.Size(791, 37);
            this.bar_Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bar_Progress.TabIndex = 5;
            this.bar_Progress.Click += new System.EventHandler(this.bar_Progress_Click);
            // 
            // lbl_Compatibility
            // 
            this.lbl_Compatibility.AutoSize = true;
            this.lbl_Compatibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Compatibility.Location = new System.Drawing.Point(12, 544);
            this.lbl_Compatibility.Name = "lbl_Compatibility";
            this.lbl_Compatibility.Size = new System.Drawing.Size(200, 37);
            this.lbl_Compatibility.TabIndex = 6;
            this.lbl_Compatibility.Text = "Compatibility";
            // 
            // nud_Pets
            // 
            this.nud_Pets.Location = new System.Drawing.Point(745, 389);
            this.nud_Pets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pets.Name = "nud_Pets";
            this.nud_Pets.Size = new System.Drawing.Size(120, 26);
            this.nud_Pets.TabIndex = 7;
            this.nud_Pets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Pets.ValueChanged += new System.EventHandler(this.nud_Pets_ValueChanged);
            // 
            // lbl_Pets
            // 
            this.lbl_Pets.AutoSize = true;
            this.lbl_Pets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Pets.Location = new System.Drawing.Point(754, 365);
            this.lbl_Pets.Name = "lbl_Pets";
            this.lbl_Pets.Size = new System.Drawing.Size(105, 20);
            this.lbl_Pets.TabIndex = 8;
            this.lbl_Pets.Text = "Pets (Adds 1)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 628);
            this.Controls.Add(this.lbl_Pets);
            this.Controls.Add(this.nud_Pets);
            this.Controls.Add(this.lbl_Compatibility);
            this.Controls.Add(this.bar_Progress);
            this.Controls.Add(this.gbx_Traits);
            this.Controls.Add(this.gbx_Aura);
            this.Controls.Add(this.gbx_Age);
            this.Name = "Form1";
            this.Text = "Daniel Compatibility";
            this.gbx_Age.ResumeLayout(false);
            this.gbx_Age.PerformLayout();
            this.gbx_Aura.ResumeLayout(false);
            this.gbx_Aura.PerformLayout();
            this.gbx_Traits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Age;
        private System.Windows.Forms.RadioButton rdb_Senior;
        private System.Windows.Forms.RadioButton rdb_Adult;
        private System.Windows.Forms.RadioButton rdb_Child;
        private System.Windows.Forms.GroupBox gbx_Aura;
        private System.Windows.Forms.RadioButton rdb_Blue;
        private System.Windows.Forms.RadioButton rdb_Green;
        private System.Windows.Forms.RadioButton rdb_Red;
        private System.Windows.Forms.GroupBox gbx_Traits;
        private System.Windows.Forms.CheckedListBox clb_Traits;
        private System.Windows.Forms.Button btn_Age;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.Button btn_Traits;
        private System.Windows.Forms.ProgressBar bar_Progress;
        private System.Windows.Forms.Label lbl_Compatibility;
        private System.Windows.Forms.NumericUpDown nud_Pets;
        private System.Windows.Forms.Label lbl_Pets;
    }
}

