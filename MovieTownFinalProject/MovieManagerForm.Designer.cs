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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label showtimeIdLabel;
            System.Windows.Forms.Label movieNameLabel;
            System.Windows.Forms.Label movieGenreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieManagerForm));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieTownDbDataSet = new MovieTownFinalProject.MovieTownDbDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager();
            this.movieIdTextBox = new System.Windows.Forms.TextBox();
            this.movieNameTextBox = new System.Windows.Forms.TextBox();
            this.movieGenreComboBox = new System.Windows.Forms.ComboBox();
            this.movieSaveButton = new System.Windows.Forms.Button();
            this.movieAddButton = new System.Windows.Forms.Button();
            this.movieDeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            showtimeIdLabel = new System.Windows.Forms.Label();
            movieNameLabel = new System.Windows.Forms.Label();
            movieGenreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // showtimeIdLabel
            // 
            showtimeIdLabel.AutoSize = true;
            showtimeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showtimeIdLabel.Location = new System.Drawing.Point(112, 649);
            showtimeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            showtimeIdLabel.Name = "showtimeIdLabel";
            showtimeIdLabel.Size = new System.Drawing.Size(101, 25);
            showtimeIdLabel.TabIndex = 44;
            showtimeIdLabel.Text = "Movie Id:";
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movieNameLabel.Location = new System.Drawing.Point(112, 698);
            movieNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new System.Drawing.Size(139, 25);
            movieNameLabel.TabIndex = 46;
            movieNameLabel.Text = "Movie Name:";
            // 
            // movieGenreLabel
            // 
            movieGenreLabel.AutoSize = true;
            movieGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movieGenreLabel.Location = new System.Drawing.Point(112, 740);
            movieGenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            movieGenreLabel.Name = "movieGenreLabel";
            movieGenreLabel.Size = new System.Drawing.Size(142, 25);
            movieGenreLabel.TabIndex = 48;
            movieGenreLabel.Text = "Movie Genre:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(115, 63);
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
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 50);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.movieLabel.Location = new System.Drawing.Point(251, 347);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(209, 25);
            this.movieLabel.TabIndex = 5;
            this.movieLabel.Text = "Select Movie Details";
            // 
            // movieTownDbDataSet
            // 
            this.movieTownDbDataSet.DataSetName = "MovieTownDbDataSet";
            this.movieTownDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.movieTownDbDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.GenreTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.ShowtimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieIdTextBox
            // 
            this.movieIdTextBox.Enabled = false;
            this.movieIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIdTextBox.Location = new System.Drawing.Point(351, 645);
            this.movieIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieIdTextBox.Name = "movieIdTextBox";
            this.movieIdTextBox.Size = new System.Drawing.Size(265, 30);
            this.movieIdTextBox.TabIndex = 45;
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Enabled = false;
            this.movieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameTextBox.Location = new System.Drawing.Point(351, 694);
            this.movieNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(265, 30);
            this.movieNameTextBox.TabIndex = 47;
            // 
            // movieGenreComboBox
            // 
            this.movieGenreComboBox.Enabled = false;
            this.movieGenreComboBox.FormattingEnabled = true;
            this.movieGenreComboBox.Location = new System.Drawing.Point(351, 744);
            this.movieGenreComboBox.Name = "movieGenreComboBox";
            this.movieGenreComboBox.Size = new System.Drawing.Size(265, 24);
            this.movieGenreComboBox.TabIndex = 49;
            // 
            // movieSaveButton
            // 
            this.movieSaveButton.Location = new System.Drawing.Point(541, 790);
            this.movieSaveButton.Name = "movieSaveButton";
            this.movieSaveButton.Size = new System.Drawing.Size(75, 29);
            this.movieSaveButton.TabIndex = 50;
            this.movieSaveButton.Text = "Save";
            this.movieSaveButton.UseVisualStyleBackColor = true;
            this.movieSaveButton.Click += new System.EventHandler(this.movieSaveButton_Click);
            // 
            // movieAddButton
            // 
            this.movieAddButton.Location = new System.Drawing.Point(117, 396);
            this.movieAddButton.Name = "movieAddButton";
            this.movieAddButton.Size = new System.Drawing.Size(75, 26);
            this.movieAddButton.TabIndex = 51;
            this.movieAddButton.Text = "Add";
            this.movieAddButton.UseVisualStyleBackColor = true;
            this.movieAddButton.Click += new System.EventHandler(this.MovieAddButton_Click);
            // 
            // movieDeleteButton
            // 
            this.movieDeleteButton.Location = new System.Drawing.Point(321, 396);
            this.movieDeleteButton.Name = "movieDeleteButton";
            this.movieDeleteButton.Size = new System.Drawing.Size(75, 26);
            this.movieDeleteButton.TabIndex = 52;
            this.movieDeleteButton.Text = "Delete";
            this.movieDeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(541, 396);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 29);
            this.EditButton.TabIndex = 53;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 16;
            this.MovieListBox.Location = new System.Drawing.Point(117, 444);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(499, 180);
            this.MovieListBox.TabIndex = 54;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(732, 846);
            this.Controls.Add(this.MovieListBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.movieDeleteButton);
            this.Controls.Add(this.movieAddButton);
            this.Controls.Add(this.movieSaveButton);
            this.Controls.Add(this.movieGenreComboBox);
            this.Controls.Add(movieGenreLabel);
            this.Controls.Add(movieNameLabel);
            this.Controls.Add(this.movieNameTextBox);
            this.Controls.Add(showtimeIdLabel);
            this.Controls.Add(this.movieIdTextBox);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieManager";
            this.Load += new System.EventHandler(this.MovieManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label movieLabel;
        private MovieTownDbDataSet movieTownDbDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private MovieTownDbDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private MovieTownDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox movieIdTextBox;
        private System.Windows.Forms.TextBox movieNameTextBox;
        private System.Windows.Forms.ComboBox movieGenreComboBox;
        private System.Windows.Forms.Button movieSaveButton;
        private System.Windows.Forms.Button movieAddButton;
        private System.Windows.Forms.Button movieDeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox MovieListBox;
    }
}