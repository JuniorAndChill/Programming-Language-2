using System;
using System.Windows.Forms;

namespace uno_ColorAdd
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
            this.drawButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.unoButton = new System.Windows.Forms.Button();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.discardPilePanel = new System.Windows.Forms.Panel();
            this.zoomedCardPictureBox = new System.Windows.Forms.PictureBox();
            this.playerHandPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.playerHandPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.playerHandPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.playerHandPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.deckPilePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.zoomedCardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(462, 505);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(100, 50);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Draw Card";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Visible = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(591, 505);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 50);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play Card";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Visible = false;
            // 
            // unoButton
            // 
            this.unoButton.Location = new System.Drawing.Point(719, 505);
            this.unoButton.Name = "unoButton";
            this.unoButton.Size = new System.Drawing.Size(100, 50);
            this.unoButton.TabIndex = 6;
            this.unoButton.Text = "UNO!";
            this.unoButton.UseVisualStyleBackColor = true;
            this.unoButton.Visible = false;
            // 
            // currentPlayerLabel
            // 
            this.currentPlayerLabel.AutoSize = true;
            this.currentPlayerLabel.BackColor = System.Drawing.SystemColors.Window;
            this.currentPlayerLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currentPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentPlayerLabel.Location = new System.Drawing.Point(526, 212);
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            this.currentPlayerLabel.Size = new System.Drawing.Size(230, 37);
            this.currentPlayerLabel.TabIndex = 2;
            this.currentPlayerLabel.Text = "Player 1\'s Turn";
            this.currentPlayerLabel.Visible = false;
            // 
            // discardPilePanel
            // 
            this.discardPilePanel.BackColor = System.Drawing.Color.Honeydew;
            this.discardPilePanel.Location = new System.Drawing.Point(666, 293);
            this.discardPilePanel.Name = "discardPilePanel";
            this.discardPilePanel.Size = new System.Drawing.Size(100, 150);
            this.discardPilePanel.TabIndex = 3;
            this.discardPilePanel.Visible = false;
            // 
            // zoomedCardPictureBox
            // 
            this.zoomedCardPictureBox.Location = new System.Drawing.Point(96, 212);
            this.zoomedCardPictureBox.Name = "zoomedCardPictureBox";
            this.zoomedCardPictureBox.Size = new System.Drawing.Size(200, 300);
            this.zoomedCardPictureBox.TabIndex = 7;
            this.zoomedCardPictureBox.TabStop = false;
            this.zoomedCardPictureBox.Visible = false;
            // 
            // playerHandPanel1
            // 
            this.playerHandPanel1.Location = new System.Drawing.Point(12, 572);
            this.playerHandPanel1.Name = "playerHandPanel1";
            this.playerHandPanel1.Size = new System.Drawing.Size(600, 160);
            this.playerHandPanel1.TabIndex = 0;
            this.playerHandPanel1.Visible = false;
            // 
            // playerHandPanel2
            // 
            this.playerHandPanel2.Location = new System.Drawing.Point(666, 572);
            this.playerHandPanel2.Name = "playerHandPanel2";
            this.playerHandPanel2.Size = new System.Drawing.Size(600, 160);
            this.playerHandPanel2.TabIndex = 1;
            this.playerHandPanel2.Visible = false;
            // 
            // playerHandPanel3
            // 
            this.playerHandPanel3.Location = new System.Drawing.Point(12, 12);
            this.playerHandPanel3.Name = "playerHandPanel3";
            this.playerHandPanel3.Size = new System.Drawing.Size(600, 160);
            this.playerHandPanel3.TabIndex = 1;
            this.playerHandPanel3.Visible = false;
            // 
            // playerHandPanel4
            // 
            this.playerHandPanel4.Location = new System.Drawing.Point(666, 12);
            this.playerHandPanel4.Name = "playerHandPanel4";
            this.playerHandPanel4.Size = new System.Drawing.Size(600, 160);
            this.playerHandPanel4.TabIndex = 1;
            this.playerHandPanel4.Visible = false;
            // 
            // deckPilePanel
            // 
            this.deckPilePanel.Location = new System.Drawing.Point(512, 293);
            this.deckPilePanel.Name = "deckPilePanel";
            this.deckPilePanel.Size = new System.Drawing.Size(100, 150);
            this.deckPilePanel.TabIndex = 8;
            this.deckPilePanel.Visible = false;
            this.deckPilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.deckPilePanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.deckPilePanel);
            this.Controls.Add(this.playerHandPanel4);
            this.Controls.Add(this.playerHandPanel3);
            this.Controls.Add(this.playerHandPanel2);
            this.Controls.Add(this.playerHandPanel1);
            this.Controls.Add(this.zoomedCardPictureBox);
            this.Controls.Add(this.unoButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.discardPilePanel);
            this.Controls.Add(this.currentPlayerLabel);
            this.Name = "Form1";
            this.Text = "UNO! ColorAdd | Daniel\'s Final";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoomedCardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void deckPilePanel_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button unoButton;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Panel discardPilePanel;
        private System.Windows.Forms.PictureBox zoomedCardPictureBox;
        private FlowLayoutPanel playerHandPanel1;
        private FlowLayoutPanel playerHandPanel2;
        private FlowLayoutPanel playerHandPanel3;
        private FlowLayoutPanel playerHandPanel4;
        private Panel deckPilePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Panel panel2;
    }
}

