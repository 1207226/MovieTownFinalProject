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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageShowTimeForm));
            System.Windows.Forms.Label showtimeIdLabel;
            System.Windows.Forms.Label movieIdLabel;
            System.Windows.Forms.Label roomIdLabel;
            System.Windows.Forms.Label showtimeLabel;
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.showRoomLabel = new System.Windows.Forms.Label();
            this.movieTownDbDataSet = new MovieTownFinalProject.MovieTownDbDataSet();
            this.showtimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showtimeTableAdapter = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.ShowtimeTableAdapter();
            this.tableAdapterManager = new MovieTownFinalProject.MovieTownDbDataSetTableAdapters.TableAdapterManager();
            this.showtimeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showtimeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.showtimeIdTextBox = new System.Windows.Forms.TextBox();
            this.movieIdTextBox = new System.Windows.Forms.TextBox();
            this.roomIdTextBox = new System.Windows.Forms.TextBox();
            this.showtimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            showtimeIdLabel = new System.Windows.Forms.Label();
            movieIdLabel = new System.Windows.Forms.Label();
            roomIdLabel = new System.Windows.Forms.Label();
            showtimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingNavigator)).BeginInit();
            this.showtimeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(87, 51);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(376, 192);
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
            this.backButton.Location = new System.Drawing.Point(26, 23);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 41);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // showRoomLabel
            // 
            this.showRoomLabel.AutoSize = true;
            this.showRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.showRoomLabel.Location = new System.Drawing.Point(178, 285);
            this.showRoomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showRoomLabel.Name = "showRoomLabel";
            this.showRoomLabel.Size = new System.Drawing.Size(213, 20);
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
            // showtimeBindingNavigator
            // 
            this.showtimeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.showtimeBindingNavigator.AutoSize = false;
            this.showtimeBindingNavigator.BindingSource = this.showtimeBindingSource;
            this.showtimeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.showtimeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.showtimeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.showtimeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.showtimeBindingNavigatorSaveItem});
            this.showtimeBindingNavigator.Location = new System.Drawing.Point(87, 324);
            this.showtimeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.showtimeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.showtimeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.showtimeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.showtimeBindingNavigator.Name = "showtimeBindingNavigator";
            this.showtimeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.showtimeBindingNavigator.Size = new System.Drawing.Size(376, 25);
            this.showtimeBindingNavigator.TabIndex = 42;
            this.showtimeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // showtimeBindingNavigatorSaveItem
            // 
            this.showtimeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showtimeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("showtimeBindingNavigatorSaveItem.Image")));
            this.showtimeBindingNavigatorSaveItem.Name = "showtimeBindingNavigatorSaveItem";
            this.showtimeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.showtimeBindingNavigatorSaveItem.Text = "Save Data";
            this.showtimeBindingNavigatorSaveItem.Click += new System.EventHandler(this.ShowtimeBindingNavigatorSaveItem_Click);
            // 
            // showtimeIdLabel
            // 
            showtimeIdLabel.AutoSize = true;
            showtimeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showtimeIdLabel.Location = new System.Drawing.Point(84, 382);
            showtimeIdLabel.Name = "showtimeIdLabel";
            showtimeIdLabel.Size = new System.Drawing.Size(113, 20);
            showtimeIdLabel.TabIndex = 42;
            showtimeIdLabel.Text = "Showtime Id:";
            // 
            // showtimeIdTextBox
            // 
            this.showtimeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "ShowtimeId", true));
            this.showtimeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeIdTextBox.Location = new System.Drawing.Point(263, 379);
            this.showtimeIdTextBox.Name = "showtimeIdTextBox";
            this.showtimeIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.showtimeIdTextBox.TabIndex = 43;
            // 
            // movieIdLabel
            // 
            movieIdLabel.AutoSize = true;
            movieIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            movieIdLabel.Location = new System.Drawing.Point(85, 435);
            movieIdLabel.Name = "movieIdLabel";
            movieIdLabel.Size = new System.Drawing.Size(81, 20);
            movieIdLabel.TabIndex = 44;
            movieIdLabel.Text = "Movie Id:";
            // 
            // movieIdTextBox
            // 
            this.movieIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "MovieId", true));
            this.movieIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIdTextBox.Location = new System.Drawing.Point(263, 432);
            this.movieIdTextBox.Name = "movieIdTextBox";
            this.movieIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.movieIdTextBox.TabIndex = 45;
            // 
            // roomIdLabel
            // 
            roomIdLabel.AutoSize = true;
            roomIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roomIdLabel.Location = new System.Drawing.Point(84, 493);
            roomIdLabel.Name = "roomIdLabel";
            roomIdLabel.Size = new System.Drawing.Size(82, 20);
            roomIdLabel.TabIndex = 46;
            roomIdLabel.Text = "Room Id:";
            // 
            // roomIdTextBox
            // 
            this.roomIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.showtimeBindingSource, "RoomId", true));
            this.roomIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomIdTextBox.Location = new System.Drawing.Point(263, 490);
            this.roomIdTextBox.Name = "roomIdTextBox";
            this.roomIdTextBox.Size = new System.Drawing.Size(200, 26);
            this.roomIdTextBox.TabIndex = 47;
            // 
            // showtimeLabel
            // 
            showtimeLabel.AutoSize = true;
            showtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showtimeLabel.Location = new System.Drawing.Point(83, 547);
            showtimeLabel.Name = "showtimeLabel";
            showtimeLabel.Size = new System.Drawing.Size(92, 20);
            showtimeLabel.TabIndex = 48;
            showtimeLabel.Text = "Showtime:";
            // 
            // showtimeDateTimePicker
            // 
            this.showtimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.showtimeBindingSource, "Showtime", true));
            this.showtimeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeDateTimePicker.Location = new System.Drawing.Point(182, 542);
            this.showtimeDateTimePicker.Name = "showtimeDateTimePicker";
            this.showtimeDateTimePicker.Size = new System.Drawing.Size(281, 26);
            this.showtimeDateTimePicker.TabIndex = 49;
            // 
            // ManageShowTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(549, 687);
            this.Controls.Add(showtimeIdLabel);
            this.Controls.Add(this.showtimeIdTextBox);
            this.Controls.Add(movieIdLabel);
            this.Controls.Add(this.movieIdTextBox);
            this.Controls.Add(roomIdLabel);
            this.Controls.Add(this.roomIdTextBox);
            this.Controls.Add(showtimeLabel);
            this.Controls.Add(this.showtimeDateTimePicker);
            this.Controls.Add(this.showtimeBindingNavigator);
            this.Controls.Add(this.showRoomLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageShowTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageShowTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTownDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showtimeBindingNavigator)).EndInit();
            this.showtimeBindingNavigator.ResumeLayout(false);
            this.showtimeBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator showtimeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton showtimeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox showtimeIdTextBox;
        private System.Windows.Forms.TextBox movieIdTextBox;
        private System.Windows.Forms.TextBox roomIdTextBox;
        private System.Windows.Forms.DateTimePicker showtimeDateTimePicker;
    }
}