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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label roomIdLabel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label numberOfSeatsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowRoomManagerForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.showRoomLabel = new System.Windows.Forms.Label();
            this.movieTownDbDataSet = new MovieTownFinalProject.MovieTownDbDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.RoomTableAdapter();
            this.tableAdapterManager = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager();
            this.roomIdTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.editRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.saveRoomButton = new System.Windows.Forms.Button();
            this.RoomListBox = new System.Windows.Forms.ListBox();
            roomIdLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            numberOfSeatsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomIdLabel
            // 
            roomIdLabel.AutoSize = true;
            roomIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomIdLabel.Location = new System.Drawing.Point(119, 624);
            roomIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomIdLabel.Name = "roomIdLabel";
            roomIdLabel.Size = new System.Drawing.Size(98, 25);
            roomIdLabel.TabIndex = 42;
            roomIdLabel.Text = "Room Id:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomNameLabel.Location = new System.Drawing.Point(119, 680);
            roomNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(136, 25);
            roomNameLabel.TabIndex = 44;
            roomNameLabel.Text = "Room Name:";
            // 
            // numberOfSeatsLabel
            // 
            numberOfSeatsLabel.AutoSize = true;
            numberOfSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberOfSeatsLabel.Location = new System.Drawing.Point(119, 735);
            numberOfSeatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            numberOfSeatsLabel.Size = new System.Drawing.Size(185, 25);
            numberOfSeatsLabel.TabIndex = 46;
            numberOfSeatsLabel.Text = "Number Of Seats:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.InitialImage")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(116, 63);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 50);
            this.backButton.TabIndex = 5;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // showRoomLabel
            // 
            this.showRoomLabel.AutoSize = true;
            this.showRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.showRoomLabel.Location = new System.Drawing.Point(233, 317);
            this.showRoomLabel.Name = "showRoomLabel";
            this.showRoomLabel.Size = new System.Drawing.Size(266, 25);
            this.showRoomLabel.TabIndex = 6;
            this.showRoomLabel.Text = "Select Show Room Details";
            // 
            // movieTownDbDataSet
            // 
            this.movieTownDbDataSet.DataSetName = "MovieTownDbDataSet";
            this.movieTownDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.movieTownDbDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.ShowtimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomId", true));
            this.roomIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdTextBox.Location = new System.Drawing.Point(372, 624);
            this.roomIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(244, 30);
            this.roomIdTextBox.TabIndex = 43;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomName", true));
            this.roomNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameTextBox.Location = new System.Drawing.Point(372, 684);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(244, 30);
            this.roomNameTextBox.TabIndex = 45;
            // 
            // numberOfSeatsTextBox
            // 
            this.numberOfSeatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "NumberOfSeats", true));
            this.numberOfSeatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSeatsTextBox.Location = new System.Drawing.Point(372, 740);
            this.numberOfSeatsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            this.numberOfSeatsTextBox.Size = new System.Drawing.Size(244, 30);
            this.numberOfSeatsTextBox.TabIndex = 47;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRoomButton.FlatAppearance.BorderSize = 0;
            this.deleteRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoomButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteRoomButton.Location = new System.Drawing.Point(490, 365);
            this.deleteRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(127, 38);
            this.deleteRoomButton.TabIndex = 57;
            this.deleteRoomButton.Text = "Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = false;
            // 
            // editRoomButton
            // 
            this.editRoomButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.editRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editRoomButton.FlatAppearance.BorderSize = 0;
            this.editRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editRoomButton.Location = new System.Drawing.Point(304, 365);
            this.editRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.editRoomButton.Name = "editRoomButton";
            this.editRoomButton.Size = new System.Drawing.Size(127, 38);
            this.editRoomButton.TabIndex = 56;
            this.editRoomButton.Text = "Edit";
            this.editRoomButton.UseVisualStyleBackColor = false;
            // 
            // addRoomButton
            // 
            this.addRoomButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRoomButton.FlatAppearance.BorderSize = 0;
            this.addRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addRoomButton.Location = new System.Drawing.Point(116, 365);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(127, 38);
            this.addRoomButton.TabIndex = 55;
            this.addRoomButton.Text = "Add";
            this.addRoomButton.UseVisualStyleBackColor = false;
            // 
            // saveRoomButton
            // 
            this.saveRoomButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveRoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveRoomButton.FlatAppearance.BorderSize = 0;
            this.saveRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRoomButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveRoomButton.Location = new System.Drawing.Point(303, 787);
            this.saveRoomButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveRoomButton.Name = "saveRoomButton";
            this.saveRoomButton.Size = new System.Drawing.Size(127, 38);
            this.saveRoomButton.TabIndex = 58;
            this.saveRoomButton.Text = "Save";
            this.saveRoomButton.UseVisualStyleBackColor = false;
            // 
            // RoomListBox
            // 
            this.RoomListBox.FormattingEnabled = true;
            this.RoomListBox.ItemHeight = 16;
            this.RoomListBox.Location = new System.Drawing.Point(116, 426);
            this.RoomListBox.Name = "RoomListBox";
            this.RoomListBox.Size = new System.Drawing.Size(501, 180);
            this.RoomListBox.TabIndex = 59;
            // 
            // ShowRoomManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.RoomListBox);
            this.Controls.Add(this.saveRoomButton);
            this.Controls.Add(this.deleteRoomButton);
            this.Controls.Add(this.editRoomButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(roomIdLabel);
            this.Controls.Add(this.roomIdTextBox);
            this.Controls.Add(roomNameLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(numberOfSeatsLabel);
            this.Controls.Add(this.numberOfSeatsTextBox);
            this.Controls.Add(this.showRoomLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowRoomManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowRoom";
            this.Load += new System.EventHandler(this.ShowRoomManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label showRoomLabel;
        private MovieTownDbDataSet movieTownDbDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private MovieTownDbDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private MovieTownDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox roomIdTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.TextBox numberOfSeatsTextBox;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button editRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button saveRoomButton;
        private System.Windows.Forms.ListBox RoomListBox;
    }
}