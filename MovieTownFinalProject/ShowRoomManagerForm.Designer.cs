namespace MovieTownFinalProject
{
    partial class ShowRoomManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRoomManagerForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.showRoomLabel = new System.Windows.Forms.Label();
            this.roomCapacityTextBox = new System.Windows.Forms.TextBox();
            this.showTimeRoomTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.roomAvailibleLabel = new System.Windows.Forms.Label();
            this.roomCapacityLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(121, 63);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(501, 236);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(35, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(74, 50);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // showRoomLabel
            // 
            this.showRoomLabel.AutoSize = true;
            this.showRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.showRoomLabel.Location = new System.Drawing.Point(235, 351);
            this.showRoomLabel.Name = "showRoomLabel";
            this.showRoomLabel.Size = new System.Drawing.Size(266, 25);
            this.showRoomLabel.TabIndex = 6;
            this.showRoomLabel.Text = "Select Show Room Details";
            // 
            // roomCapacityTextBox
            // 
            this.roomCapacityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomCapacityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.roomCapacityTextBox.Location = new System.Drawing.Point(266, 538);
            this.roomCapacityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomCapacityTextBox.Name = "roomCapacityTextBox";
            this.roomCapacityTextBox.Size = new System.Drawing.Size(295, 23);
            this.roomCapacityTextBox.TabIndex = 39;
            this.roomCapacityTextBox.Text = "Enter Room Capacity";
            // 
            // showTimeRoomTextBox
            // 
            this.showTimeRoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTimeRoomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeRoomTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.showTimeRoomTextBox.Location = new System.Drawing.Point(266, 593);
            this.showTimeRoomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.showTimeRoomTextBox.Name = "showTimeRoomTextBox";
            this.showTimeRoomTextBox.Size = new System.Drawing.Size(295, 23);
            this.showTimeRoomTextBox.TabIndex = 38;
            this.showTimeRoomTextBox.Text = "Enter Room Availibility";
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.roomNameTextBox.Location = new System.Drawing.Point(266, 481);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(295, 23);
            this.roomNameTextBox.TabIndex = 35;
            this.roomNameTextBox.Text = "Enter Room Number";
            // 
            // roomAvailibleLabel
            // 
            this.roomAvailibleLabel.AutoSize = true;
            this.roomAvailibleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomAvailibleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.roomAvailibleLabel.Location = new System.Drawing.Point(30, 591);
            this.roomAvailibleLabel.Name = "roomAvailibleLabel";
            this.roomAvailibleLabel.Size = new System.Drawing.Size(177, 25);
            this.roomAvailibleLabel.TabIndex = 32;
            this.roomAvailibleLabel.Text = "Room Availibility:";
            // 
            // roomCapacityLabel
            // 
            this.roomCapacityLabel.AutoSize = true;
            this.roomCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCapacityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.roomCapacityLabel.Location = new System.Drawing.Point(30, 536);
            this.roomCapacityLabel.Name = "roomCapacityLabel";
            this.roomCapacityLabel.Size = new System.Drawing.Size(165, 25);
            this.roomCapacityLabel.TabIndex = 31;
            this.roomCapacityLabel.Text = "Room Capacity:";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.roomNameLabel.Location = new System.Drawing.Point(30, 481);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(136, 25);
            this.roomNameLabel.TabIndex = 30;
            this.roomNameLabel.Text = "Room Name:";
            // 
            // ShowRoomManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.roomCapacityTextBox);
            this.Controls.Add(this.showTimeRoomTextBox);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.roomAvailibleLabel);
            this.Controls.Add(this.roomCapacityLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.showRoomLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "ShowRoomManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowRoom";
            this.Load += new System.EventHandler(this.ShowRoomManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label showRoomLabel;
        private System.Windows.Forms.TextBox roomCapacityTextBox;
        private System.Windows.Forms.TextBox showTimeRoomTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label roomAvailibleLabel;
        private System.Windows.Forms.Label roomCapacityLabel;
        private System.Windows.Forms.Label roomNameLabel;
    }
}