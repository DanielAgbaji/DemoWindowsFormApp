
namespace DemoWindowsFormApp
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacterPower = new System.Windows.Forms.Label();
            this.lblCharacterHistory = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(254, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 853);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(1021, 340);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(158, 55);
            this.lblCharacterName.TabIndex = 2;
            this.lblCharacterName.Text = "label1";
            this.lblCharacterName.Click += new System.EventHandler(this.lblCharacterName_Click);
            // 
            // lblCharacterPower
            // 
            this.lblCharacterPower.AutoSize = true;
            this.lblCharacterPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterPower.Location = new System.Drawing.Point(1021, 486);
            this.lblCharacterPower.Name = "lblCharacterPower";
            this.lblCharacterPower.Size = new System.Drawing.Size(158, 55);
            this.lblCharacterPower.TabIndex = 3;
            this.lblCharacterPower.Text = "label1";
            this.lblCharacterPower.Click += new System.EventHandler(this.lblCharacterPower_Click);
            // 
            // lblCharacterHistory
            // 
            this.lblCharacterHistory.AutoSize = true;
            this.lblCharacterHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterHistory.Location = new System.Drawing.Point(1021, 647);
            this.lblCharacterHistory.Name = "lblCharacterHistory";
            this.lblCharacterHistory.Size = new System.Drawing.Size(158, 55);
            this.lblCharacterHistory.TabIndex = 4;
            this.lblCharacterHistory.Text = "label1";
            this.lblCharacterHistory.Click += new System.EventHandler(this.lblCharacterHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2146, 1179);
            this.Controls.Add(this.lblCharacterHistory);
            this.Controls.Add(this.lblCharacterPower);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

