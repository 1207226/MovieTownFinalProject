namespace MovieTownFinalProject
{
    partial class ManageShowTimeForm
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
            System.Windows.Forms.Label showtimeIdLabel;
            System.Windows.Forms.Label movieIdLabel;
            System.Windows.Forms.Label roomIdLabel;
            System.Windows.Forms.Label showtimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageShowTimeForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.showRoomLabel = new System.Windows.Forms.Label();
            this.movieTownDbDataSet = new MovieTownFinalProject.MovieTownDbDataSet();
            this.showtimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showtimeTableAdapter = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.ShowtimeTableAdapter();
            this.tableAdapterManager = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager();
            this.showtimeIdTextBox = new System.Windows.Forms.TextBox();
            this.movieIdTextBox = new System.Windows.Forms.TextBox();
            this.roomIdTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showTimeListView = new System.Windows.Forms.ListView();
            this.addShowTimeButton = new System.Windows.Forms.Button();
            this.editShowTimeButton = new System.Windows.Forms.Button();
            this.deleteShowTimeButton = new System.Windows.Forms.Button();
            this.saveShowTimeButton = new System.Windows.Forms.Button();
            showtimeIdLabel = new System.Windows.Forms.Label();
            movieIdLabel = new System.Windows.Forms.Label();
            roomIdLabel = new System.Windows.Forms.Label();
            showtimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // showtimeIdLabel
            // 
            showtimeIdLabel.AutoSize = true;
            showtimeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showtimeIdLabel.Location = new System.Drawing.Point(112, 602);
            showtimeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            showtimeIdLabel.Name = "showtimeIdLabel";
            showtimeIdLabel.Size = new System.Drawing.Size(137, 25);
            showtimeIdLabel.TabIndex = 42;
            showtimeIdLabel.Text = "Showtime Id:";
            // 
            // movieIdLabel
            // 
            movieIdLabel.AutoSize = true;
            movieIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movieIdLabel.Location = new System.Drawing.Point(112, 652);
            movieIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            movieIdLabel.Name = "movieIdLabel";
            movieIdLabel.Size = new System.Drawing.Size(83, 25);
            movieIdLabel.TabIndex = 44;
            movieIdLabel.Text = "Movie :";
            // 
            // roomIdLabel
            // 
            roomIdLabel.AutoSize = true;
            roomIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomIdLabel.Location = new System.Drawing.Point(115, 707);
            roomIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roomIdLabel.Name = "roomIdLabel";
            roomIdLabel.Size = new System.Drawing.Size(80, 25);
            roomIdLabel.TabIndex = 46;
            roomIdLabel.Text = "Room :";
            // 
            // showtimeLabel
            // 
            showtimeLabel.AutoSize = true;
            showtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showtimeLabel.Location = new System.Drawing.Point(112, 756);
            showtimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            showtimeLabel.Name = "showtimeLabel";
            showtimeLabel.Size = new System.Drawing.Size(113, 25);
            showtimeLabel.TabIndex = 48;
            showtimeLabel.Text = "Showtime:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(116, 63);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(501, 236);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
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
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // showRoomLabel
            // 
            this.showRoomLabel.AutoSize = true;
            this.showRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.showRoomLabel.Location = new System.Drawing.Point(237, 304);
            this.showRoomLabel.Name = "showRoomLabel";
            this.showRoomLabel.Size = new System.Drawing.Size(259, 25);
            this.showRoomLabel.TabIndex = 7;
            this.showRoomLabel.Text = "Select Show Time Details";
            // 
            // movieTownDbDataSet
            // 
            this.movieTownDbDataSet.DataSetName = "MovieTownDbDataSet";
            this.movieTownDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showtimeBindingSource
            // 
            this.showtimeBindingSource.DataMember = "Showtime";
            this.showtimeBindingSource.DataSource = this.movieTownDbDataSet;
            // 
            // showtimeTableAdapter
            // 
            this.showtimeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.ShowtimeTableAdapter = this.showtimeTableAdapter;
            this.tableAdapterManager.UpdateOrder = MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // showtimeIdTextBox
            // 
            this.showtimeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "ShowtimeId", true));
            this.showtimeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeIdTextBox.Location = new System.Drawing.Point(351, 599);
            this.showtimeIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.showtimeIdTextBox.Name = "showtimeIdTextBox";
            this.showtimeIdTextBox.Size = new System.Drawing.Size(265, 30);
            this.showtimeIdTextBox.TabIndex = 43;
            // 
            // movieIdTextBox
            // 
            this.movieIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "MovieId", true));
            this.movieIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIdTextBox.Location = new System.Drawing.Point(351, 649);
            this.movieIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieIdTextBox.Name = "movieIdTextBox";
            this.movieIdTextBox.Size = new System.Drawing.Size(265, 30);
            this.movieIdTextBox.TabIndex = 45;
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "RoomId", true));
            this.roomIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdTextBox.Location = new System.Drawing.Point(351, 704);
            this.roomIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(265, 30);
            this.roomIdTextBox.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "RoomId", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(352, 753);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 30);
            this.textBox1.TabIndex = 49;
            // 
            // showTimeListView
            // 
            this.showTimeListView.HideSelection = false;
            this.showTimeListView.Location = new System.Drawing.Point(116, 397);
            this.showTimeListView.Name = "showTimeListView";
            this.showTimeListView.Size = new System.Drawing.Size(501, 178);
            this.showTimeListView.TabIndex = 50;
            this.showTimeListView.UseCompatibleStateImageBehavior = false;
            // 
            // addShowTimeButton
            // 
            this.addShowTimeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.addShowTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addShowTimeButton.FlatAppearance.BorderSize = 0;
            this.addShowTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addShowTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addShowTimeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addShowTimeButton.Location = new System.Drawing.Point(116, 342);
            this.addShowTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addShowTimeButton.Name = "addShowTimeButton";
            this.addShowTimeButton.Size = new System.Drawing.Size(127, 38);
            this.addShowTimeButton.TabIndex = 51;
            this.addShowTimeButton.Text = "Add";
            this.addShowTimeButton.UseVisualStyleBackColor = false;
            // 
            // editShowTimeButton
            // 
            this.editShowTimeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.editShowTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editShowTimeButton.FlatAppearance.BorderSize = 0;
            this.editShowTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editShowTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editShowTimeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editShowTimeButton.Location = new System.Drawing.Point(304, 342);
            this.editShowTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.editShowTimeButton.Name = "editShowTimeButton";
            this.editShowTimeButton.Size = new System.Drawing.Size(127, 38);
            this.editShowTimeButton.TabIndex = 52;
            this.editShowTimeButton.Text = "Edit";
            this.editShowTimeButton.UseVisualStyleBackColor = false;
            // 
            // deleteShowTimeButton
            // 
            this.deleteShowTimeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.deleteShowTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteShowTimeButton.FlatAppearance.BorderSize = 0;
            this.deleteShowTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteShowTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteShowTimeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteShowTimeButton.Location = new System.Drawing.Point(490, 342);
            this.deleteShowTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteShowTimeButton.Name = "deleteShowTimeButton";
            this.deleteShowTimeButton.Size = new System.Drawing.Size(127, 38);
            this.deleteShowTimeButton.TabIndex = 53;
            this.deleteShowTimeButton.Text = "Delete";
            this.deleteShowTimeButton.UseVisualStyleBackColor = false;
            // 
            // saveShowTimeButton
            // 
            this.saveShowTimeButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.saveShowTimeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveShowTimeButton.FlatAppearance.BorderSize = 0;
            this.saveShowTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveShowTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveShowTimeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveShowTimeButton.Location = new System.Drawing.Point(303, 795);
            this.saveShowTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveShowTimeButton.Name = "saveShowTimeButton";
            this.saveShowTimeButton.Size = new System.Drawing.Size(127, 38);
            this.saveShowTimeButton.TabIndex = 54;
            this.saveShowTimeButton.Text = "Save";
            this.saveShowTimeButton.UseVisualStyleBackColor = false;
            // 
            // ManageShowTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.saveShowTimeButton);
            this.Controls.Add(this.deleteShowTimeButton);
            this.Controls.Add(this.editShowTimeButton);
            this.Controls.Add(this.addShowTimeButton);
            this.Controls.Add(this.showTimeListView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(showtimeIdLabel);
            this.Controls.Add(this.showtimeIdTextBox);
            this.Controls.Add(movieIdLabel);
            this.Controls.Add(this.movieIdTextBox);
            this.Controls.Add(roomIdLabel);
            this.Controls.Add(this.roomIdTextBox);
            this.Controls.Add(showtimeLabel);
            this.Controls.Add(this.showRoomLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageShowTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageShowTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label showRoomLabel;
        private MovieTownDbDataSet movieTownDbDataSet;
        private System.Windows.Forms.BindingSource showtimeBindingSource;
        private MovieTownDbDataSetTableAdapters.ShowtimeTableAdapter showtimeTableAdapter;
        private MovieTownDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox showtimeIdTextBox;
        private System.Windows.Forms.TextBox movieIdTextBox;
        private System.Windows.Forms.TextBox roomIdTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView showTimeListView;
        private System.Windows.Forms.Button addShowTimeButton;
        private System.Windows.Forms.Button editShowTimeButton;
        private System.Windows.Forms.Button deleteShowTimeButton;
        private System.Windows.Forms.Button saveShowTimeButton;
    }
}