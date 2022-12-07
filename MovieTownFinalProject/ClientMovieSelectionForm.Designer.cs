namespace MovieTownFinalProject
{
    partial class ClientMovieSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMovieSelectionForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.ticketPurchaseLable = new System.Windows.Forms.Label();
            this.availibilityButton = new System.Windows.Forms.Button();
            this.reduceTicketButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.movieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.showtimeListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(116, 63);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(501, 236);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.welcomeLabel.Location = new System.Drawing.Point(260, 325);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(212, 25);
            this.welcomeLabel.TabIndex = 10;
            this.welcomeLabel.Text = "Select a Date & Movie";
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logOutButton.Location = new System.Drawing.Point(303, 766);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(127, 38);
            this.logOutButton.TabIndex = 11;
            this.logOutButton.Text = "Log-Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // ticketPurchaseLable
            // 
            this.ticketPurchaseLable.AutoSize = true;
            this.ticketPurchaseLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPurchaseLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.ticketPurchaseLable.Location = new System.Drawing.Point(354, 630);
            this.ticketPurchaseLable.Name = "ticketPurchaseLable";
            this.ticketPurchaseLable.Size = new System.Drawing.Size(24, 25);
            this.ticketPurchaseLable.TabIndex = 12;
            this.ticketPurchaseLable.Text = "0";
            // 
            // availibilityButton
            // 
            this.availibilityButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.availibilityButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availibilityButton.FlatAppearance.BorderSize = 0;
            this.availibilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availibilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availibilityButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.availibilityButton.Location = new System.Drawing.Point(302, 690);
            this.availibilityButton.Margin = new System.Windows.Forms.Padding(4);
            this.availibilityButton.Name = "availibilityButton";
            this.availibilityButton.Size = new System.Drawing.Size(129, 38);
            this.availibilityButton.TabIndex = 13;
            this.availibilityButton.Text = "Check Availibility";
            this.availibilityButton.UseVisualStyleBackColor = false;
            this.availibilityButton.Click += new System.EventHandler(this.AvailibilityButton_Click);
            // 
            // reduceTicketButton
            // 
            this.reduceTicketButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.reduceTicketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reduceTicketButton.FlatAppearance.BorderSize = 0;
            this.reduceTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduceTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduceTicketButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reduceTicketButton.Location = new System.Drawing.Point(253, 622);
            this.reduceTicketButton.Margin = new System.Windows.Forms.Padding(4);
            this.reduceTicketButton.Name = "reduceTicketButton";
            this.reduceTicketButton.Size = new System.Drawing.Size(37, 38);
            this.reduceTicketButton.TabIndex = 14;
            this.reduceTicketButton.Text = "-";
            this.reduceTicketButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(257, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select Ticket Number";
            // 
            // movieDateTimePicker
            // 
            this.movieDateTimePicker.Location = new System.Drawing.Point(116, 372);
            this.movieDateTimePicker.MinDate = new System.DateTime(2022, 12, 7, 9, 30, 54, 0);
            this.movieDateTimePicker.Name = "movieDateTimePicker";
            this.movieDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.movieDateTimePicker.TabIndex = 17;
            this.movieDateTimePicker.Value = new System.DateTime(2022, 12, 7, 9, 30, 54, 0);
            this.movieDateTimePicker.ValueChanged += new System.EventHandler(this.MovieDateTimePicker_ValueChanged);
            // 
            // addTicketButton
            // 
            this.addTicketButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addTicketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTicketButton.FlatAppearance.BorderSize = 0;
            this.addTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTicketButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addTicketButton.Location = new System.Drawing.Point(443, 622);
            this.addTicketButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(37, 38);
            this.addTicketButton.TabIndex = 19;
            this.addTicketButton.Text = "+";
            this.addTicketButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addTicketButton.UseVisualStyleBackColor = false;
            // 
            // showtimeListBox
            // 
            this.showtimeListBox.FormattingEnabled = true;
            this.showtimeListBox.ItemHeight = 16;
            this.showtimeListBox.Location = new System.Drawing.Point(116, 421);
            this.showtimeListBox.Name = "showtimeListBox";
            this.showtimeListBox.Size = new System.Drawing.Size(501, 148);
            this.showtimeListBox.TabIndex = 20;
            // 
            // ClientMovieSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.showtimeListBox);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.movieDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reduceTicketButton);
            this.Controls.Add(this.availibilityButton);
            this.Controls.Add(this.ticketPurchaseLable);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "ClientMovieSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientMovieSelectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label ticketPurchaseLable;
        private System.Windows.Forms.Button availibilityButton;
        private System.Windows.Forms.Button reduceTicketButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker movieDateTimePicker;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.ListBox showtimeListBox;
    }
}