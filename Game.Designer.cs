
namespace DemoWindowsFormApp
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacterPower = new System.Windows.Forms.Label();
            this.lblCharacterHistory = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.txtCharacterPower = new System.Windows.Forms.TextBox();
            this.txtCharacterHistory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(281, 19);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 108);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 960);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(1028, 395);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(0, 55);
            this.lblCharacterName.TabIndex = 2;
            this.lblCharacterName.Click += new System.EventHandler(this.lblCharacterName_Click);
            // 
            // lblCharacterPower
            // 
            this.lblCharacterPower.AutoSize = true;
            this.lblCharacterPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterPower.Location = new System.Drawing.Point(1028, 541);
            this.lblCharacterPower.Name = "lblCharacterPower";
            this.lblCharacterPower.Size = new System.Drawing.Size(0, 55);
            this.lblCharacterPower.TabIndex = 3;
            this.lblCharacterPower.Click += new System.EventHandler(this.lblCharacterPower_Click);
            // 
            // lblCharacterHistory
            // 
            this.lblCharacterHistory.AutoSize = true;
            this.lblCharacterHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterHistory.Location = new System.Drawing.Point(984, 709);
            this.lblCharacterHistory.Name = "lblCharacterHistory";
            this.lblCharacterHistory.Size = new System.Drawing.Size(0, 55);
            this.lblCharacterHistory.TabIndex = 4;
            this.lblCharacterHistory.Click += new System.EventHandler(this.lblCharacterHistory_Click);
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(1498, 395);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(300, 31);
            this.txtCharacterName.TabIndex = 5;
            this.txtCharacterName.TextChanged += new System.EventHandler(this.txtCharacterName_TextChanged);
            // 
            // txtCharacterPower
            // 
            this.txtCharacterPower.Location = new System.Drawing.Point(1507, 565);
            this.txtCharacterPower.Name = "txtCharacterPower";
            this.txtCharacterPower.Size = new System.Drawing.Size(300, 31);
            this.txtCharacterPower.TabIndex = 6;
            this.txtCharacterPower.TextChanged += new System.EventHandler(this.txtCharacterPower_TextChanged);
            // 
            // txtCharacterHistory
            // 
            this.txtCharacterHistory.Location = new System.Drawing.Point(1776, 730);
            this.txtCharacterHistory.Name = "txtCharacterHistory";
            this.txtCharacterHistory.Size = new System.Drawing.Size(220, 31);
            this.txtCharacterHistory.TabIndex = 7;
            this.txtCharacterHistory.TextChanged += new System.EventHandler(this.txtCharacterHistory_TextChanged);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2128, 1292);
            this.Controls.Add(this.txtCharacterHistory);
            this.Controls.Add(this.txtCharacterPower);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterHistory);
            this.Controls.Add(this.lblCharacterPower);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game Character";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label lblCharacterPower;
        private System.Windows.Forms.Label lblCharacterHistory;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.TextBox txtCharacterPower;
        private System.Windows.Forms.TextBox txtCharacterHistory;
    }
}

