﻿namespace Movie_Bonanza
{
    partial class SelectionForm
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
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(114, 69);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(124, 199);
            this.MoviesListBox.Sorted = true;
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.Click += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(111, 53);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(78, 13);
            this.CurrentMoviesLabel.TabIndex = 1;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.MoviePictureBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(274, 69);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(415, 240);
            this.YourSelectionGroupBox.TabIndex = 2;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MoviePictureBox.InitialImage = global::Movie_Bonanza.Properties.Resources.cedarrapids;
            this.MoviePictureBox.Location = new System.Drawing.Point(18, 26);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(128, 198);
            this.MoviePictureBox.TabIndex = 6;
            this.MoviePictureBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(167, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Title";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(331, 69);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(28, 13);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(167, 69);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(324, 88);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(53, 20);
            this.CostTextBox.TabIndex = 2;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(167, 88);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(151, 20);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(167, 40);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(210, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the movies you wish to STREAM from the list below";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(614, 315);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.TabIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Items.AddRange(new object[] {
            "Comedy ",
            "Drama",
            "Action",
            "Sci-Fi",
            "Horror",
            "Thriller",
            "Family",
            "New Release"});
            this.CategoryListBox.Location = new System.Drawing.Point(13, 69);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(76, 108);
            this.CategoryListBox.TabIndex = 5;
            this.CategoryListBox.Click += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(10, 53);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(49, 13);
            this.CategoryLbl.TabIndex = 6;
            this.CategoryLbl.Text = "Category";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 345);
            this.ControlBox = false;
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.MoviesListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection";
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Label CategoryLbl;
        public System.Windows.Forms.TextBox CostTextBox;
        public System.Windows.Forms.TextBox CategoryTextBox;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.PictureBox MoviePictureBox;
        public System.Windows.Forms.Button NextButton;
    }
}

