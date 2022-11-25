namespace MovieTownFinalProject
{
    partial class MovieManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieManagerForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieNameLabel = new System.Windows.Forms.Label();
            this.movieGenreLabel = new System.Windows.Forms.Label();
            this.movieRoomLabel = new System.Windows.Forms.Label();
            this.movieDateLabel = new System.Windows.Forms.Label();
            this.movieTimeLabel = new System.Windows.Forms.Label();
            this.movieTicketlabel = new System.Windows.Forms.Label();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.movieTicketTextBox = new System.Windows.Forms.TextBox();
            this.movieShowTimeTextBox = new System.Windows.Forms.TextBox();
            this.movieDateTextBox = new System.Windows.Forms.TextBox();
            this.movieRoomTextBox = new System.Windows.Forms.TextBox();
            this.movieGenreTextBox = new System.Windows.Forms.TextBox();
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
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieLabel.Location = new System.Drawing.Point(266, 351);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(209, 25);
            this.movieLabel.TabIndex = 5;
            this.movieLabel.Text = "Select Movie Details";
            // 
            // movieNameLabel
            // 
            this.movieNameLabel.AutoSize = true;
            this.movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieNameLabel.Location = new System.Drawing.Point(35, 481);
            this.movieNameLabel.Name = "movieNameLabel";
            this.movieNameLabel.Size = new System.Drawing.Size(139, 25);
            this.movieNameLabel.TabIndex = 6;
            this.movieNameLabel.Text = "Movie Name:";
            // 
            // movieGenreLabel
            // 
            this.movieGenreLabel.AutoSize = true;
            this.movieGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieGenreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieGenreLabel.Location = new System.Drawing.Point(35, 536);
            this.movieGenreLabel.Name = "movieGenreLabel";
            this.movieGenreLabel.Size = new System.Drawing.Size(142, 25);
            this.movieGenreLabel.TabIndex = 7;
            this.movieGenreLabel.Text = "Movie Genre:";
            // 
            // movieRoomLabel
            // 
            this.movieRoomLabel.AutoSize = true;
            this.movieRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieRoomLabel.Location = new System.Drawing.Point(35, 591);
            this.movieRoomLabel.Name = "movieRoomLabel";
            this.movieRoomLabel.Size = new System.Drawing.Size(138, 25);
            this.movieRoomLabel.TabIndex = 8;
            this.movieRoomLabel.Text = "Movie Room:";
            // 
            // movieDateLabel
            // 
            this.movieDateLabel.AutoSize = true;
            this.movieDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieDateLabel.Location = new System.Drawing.Point(35, 646);
            this.movieDateLabel.Name = "movieDateLabel";
            this.movieDateLabel.Size = new System.Drawing.Size(128, 25);
            this.movieDateLabel.TabIndex = 9;
            this.movieDateLabel.Text = "Movie Date:";
            // 
            // movieTimeLabel
            // 
            this.movieTimeLabel.AutoSize = true;
            this.movieTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieTimeLabel.Location = new System.Drawing.Point(35, 701);
            this.movieTimeLabel.Name = "movieTimeLabel";
            this.movieTimeLabel.Size = new System.Drawing.Size(191, 25);
            this.movieTimeLabel.TabIndex = 10;
            this.movieTimeLabel.Text = "Movie Show Time:";
            // 
            // movieTicketlabel
            // 
            this.movieTicketlabel.AutoSize = true;
            this.movieTicketlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTicketlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieTicketlabel.Location = new System.Drawing.Point(35, 756);
            this.movieTicketlabel.Name = "movieTicketlabel";
            this.movieTicketlabel.Size = new System.Drawing.Size(183, 25);
            this.movieTicketlabel.TabIndex = 11;
            this.movieTicketlabel.Text = "Total Ticket Sold:";
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.movieNameTextBox.Location = new System.Drawing.Point(271, 481);
            this.movieNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(295, 23);
            this.movieNameTextBox.TabIndex = 12;
            this.movieNameTextBox.Text = "Enter Movie Name";
            // 
            // movieTicketTextBox
            // 
            this.movieTicketTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieTicketTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTicketTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.movieTicketTextBox.Location = new System.Drawing.Point(271, 758);
            this.movieTicketTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieTicketTextBox.Name = "movieTicketTextBox";
            this.movieTicketTextBox.ReadOnly = true;
            this.movieTicketTextBox.Size = new System.Drawing.Size(295, 23);
            this.movieTicketTextBox.TabIndex = 13;
            this.movieTicketTextBox.Text = "N/A";
            // 
            // movieShowTimeTextBox
            // 
            this.movieShowTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieShowTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieShowTimeTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.movieShowTimeTextBox.Location = new System.Drawing.Point(271, 703);
            this.movieShowTimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieShowTimeTextBox.Name = "movieShowTimeTextBox";
            this.movieShowTimeTextBox.Size = new System.Drawing.Size(295, 23);
            this.movieShowTimeTextBox.TabIndex = 14;
            this.movieShowTimeTextBox.Text = "Enter Show Time";
            // 
            // movieDateTextBox
            // 
            this.movieDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDateTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.movieDateTextBox.Location = new System.Drawing.Point(271, 646);
            this.movieDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieDateTextBox.Name = "movieDateTextBox";
            this.movieDateTextBox.Size = new System.Drawing.Size(295, 23);
            this.movieDateTextBox.TabIndex = 15;
            this.movieDateTextBox.Text = "Enter Movie Dates";
            // 
            // movieRoomTextBox
            // 
            this.movieRoomTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieRoomTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieRoomTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.movieRoomTextBox.Location = new System.Drawing.Point(271, 591);
            this.movieRoomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieRoomTextBox.Name = "movieRoomTextBox";
            this.movieRoomTextBox.Size = new System.Drawing.Size(295, 23);
            this.movieRoomTextBox.TabIndex = 16;
            this.movieRoomTextBox.Text = "Enter Movie Room";
            // 
            // movieGenreTextBox
            // 
            this.movieGenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieGenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieGenreTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.movieGenreTextBox.Location = new System.Drawing.Point(271, 536);
            this.movieGenreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieGenreTextBox.Name = "movieGenreTextBox";
            this.movieGenreTextBox.Size = new System.Drawing.Size(295, 23);
            this.movieGenreTextBox.TabIndex = 17;
            this.movieGenreTextBox.Text = "Enter Movie Genre";
            // 
            // MovieManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.movieGenreTextBox);
            this.Controls.Add(this.movieRoomTextBox);
            this.Controls.Add(this.movieDateTextBox);
            this.Controls.Add(this.movieShowTimeTextBox);
            this.Controls.Add(this.movieTicketTextBox);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(this.movieTicketlabel);
            this.Controls.Add(this.movieTimeLabel);
            this.Controls.Add(this.movieDateLabel);
            this.Controls.Add(this.movieRoomLabel);
            this.Controls.Add(this.movieGenreLabel);
            this.Controls.Add(this.movieNameLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "MovieManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieManager";
            this.Load += new System.EventHandler(this.MovieManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label movieNameLabel;
        private System.Windows.Forms.Label movieGenreLabel;
        private System.Windows.Forms.Label movieRoomLabel;
        private System.Windows.Forms.Label movieDateLabel;
        private System.Windows.Forms.Label movieTimeLabel;
        private System.Windows.Forms.Label movieTicketlabel;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.TextBox movieTicketTextBox;
        private System.Windows.Forms.TextBox movieShowTimeTextBox;
        private System.Windows.Forms.TextBox movieDateTextBox;
        private System.Windows.Forms.TextBox movieRoomTextBox;
        private System.Windows.Forms.TextBox movieGenreTextBox;
    }
}