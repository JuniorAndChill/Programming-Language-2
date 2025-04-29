namespace PopSongs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txb_SongName = new System.Windows.Forms.TextBox();
            this.txb_Artist = new System.Windows.Forms.TextBox();
            this.txb_Year = new System.Windows.Forms.TextBox();
            this.txb_Label = new System.Windows.Forms.TextBox();
            this.txb_Duration = new System.Windows.Forms.TextBox();
            this.btn_AddSong = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Label = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.txb_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_SongName
            // 
            this.txb_SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txb_SongName.Location = new System.Drawing.Point(503, 130);
            this.txb_SongName.Name = "txb_SongName";
            this.txb_SongName.Size = new System.Drawing.Size(382, 44);
            this.txb_SongName.TabIndex = 0;
            // 
            // txb_Artist
            // 
            this.txb_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txb_Artist.Location = new System.Drawing.Point(503, 203);
            this.txb_Artist.Name = "txb_Artist";
            this.txb_Artist.Size = new System.Drawing.Size(382, 44);
            this.txb_Artist.TabIndex = 1;
            // 
            // txb_Year
            // 
            this.txb_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txb_Year.Location = new System.Drawing.Point(503, 272);
            this.txb_Year.Name = "txb_Year";
            this.txb_Year.Size = new System.Drawing.Size(382, 44);
            this.txb_Year.TabIndex = 2;
            // 
            // txb_Label
            // 
            this.txb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txb_Label.Location = new System.Drawing.Point(503, 344);
            this.txb_Label.Name = "txb_Label";
            this.txb_Label.Size = new System.Drawing.Size(382, 44);
            this.txb_Label.TabIndex = 3;
            // 
            // txb_Duration
            // 
            this.txb_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txb_Duration.Location = new System.Drawing.Point(503, 421);
            this.txb_Duration.Name = "txb_Duration";
            this.txb_Duration.Size = new System.Drawing.Size(382, 44);
            this.txb_Duration.TabIndex = 4;
            // 
            // btn_AddSong
            // 
            this.btn_AddSong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AddSong.Location = new System.Drawing.Point(626, 488);
            this.btn_AddSong.Name = "btn_AddSong";
            this.btn_AddSong.Size = new System.Drawing.Size(129, 44);
            this.btn_AddSong.TabIndex = 5;
            this.btn_AddSong.Text = "Add Song";
            this.btn_AddSong.UseVisualStyleBackColor = true;
            this.btn_AddSong.Click += new System.EventHandler(this.btn_AddSong_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Title.Location = new System.Drawing.Point(310, 137);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(187, 37);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "Song Name";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Artist.Location = new System.Drawing.Point(310, 210);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(186, 37);
            this.lbl_Artist.TabIndex = 7;
            this.lbl_Artist.Text = "Artist Name";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Year.Location = new System.Drawing.Point(365, 275);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(85, 37);
            this.lbl_Year.TabIndex = 8;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_Label
            // 
            this.lbl_Label.AutoSize = true;
            this.lbl_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Label.Location = new System.Drawing.Point(356, 351);
            this.lbl_Label.Name = "lbl_Label";
            this.lbl_Label.Size = new System.Drawing.Size(95, 37);
            this.lbl_Label.TabIndex = 9;
            this.lbl_Label.Text = "Label";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_Duration.Location = new System.Drawing.Point(338, 428);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(139, 37);
            this.lbl_Duration.TabIndex = 10;
            this.lbl_Duration.Text = "Duration";
            // 
            // txb_Result
            // 
            this.txb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txb_Result.Location = new System.Drawing.Point(583, 549);
            this.txb_Result.Multiline = true;
            this.txb_Result.Name = "txb_Result";
            this.txb_Result.ReadOnly = true;
            this.txb_Result.Size = new System.Drawing.Size(429, 230);
            this.txb_Result.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1229, 805);
            this.Controls.Add(this.txb_Result);
            this.Controls.Add(this.lbl_Duration);
            this.Controls.Add(this.lbl_Label);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_AddSong);
            this.Controls.Add(this.txb_Duration);
            this.Controls.Add(this.txb_Label);
            this.Controls.Add(this.txb_Year);
            this.Controls.Add(this.txb_Artist);
            this.Controls.Add(this.txb_SongName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_SongName;
        private System.Windows.Forms.TextBox txb_Artist;
        private System.Windows.Forms.TextBox txb_Year;
        private System.Windows.Forms.TextBox txb_Label;
        private System.Windows.Forms.TextBox txb_Duration;
        private System.Windows.Forms.Button btn_AddSong;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Label;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.TextBox txb_Result;
    }
}

