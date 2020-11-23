namespace VideoRentalProject
{
    partial class MainForm
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.LoadMovies = new System.Windows.Forms.Button();
            this.FirstNBox = new System.Windows.Forms.TextBox();
            this.LastNBox = new System.Windows.Forms.TextBox();
            this.AddBox = new System.Windows.Forms.TextBox();
            this.PhBox = new System.Windows.Forms.TextBox();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.CIdBox = new System.Windows.Forms.TextBox();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.MIdBox = new System.Windows.Forms.TextBox();
            this.ReturnMovieBtn = new System.Windows.Forms.Button();
            this.IssueMovieBtn = new System.Windows.Forms.Button();
            this.LoadRentedMovies = new System.Windows.Forms.Button();
            this.PopCustBtn = new System.Windows.Forms.Button();
            this.PopMovBtn = new System.Windows.Forms.Button();
            this.RCostBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.RatiBox = new System.Windows.Forms.TextBox();
            this.CopBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.PLBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.RCLabel = new System.Windows.Forms.Label();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.UpdMovieBtn = new System.Windows.Forms.Button();
            this.DltMovieBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(16, 15);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(109, 66);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Customers";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(16, 89);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 51;
            this.MainGrid.Size = new System.Drawing.Size(872, 361);
            this.MainGrid.TabIndex = 1;
            this.MainGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick_1);
            // 
            // LoadMovies
            // 
            this.LoadMovies.Location = new System.Drawing.Point(133, 15);
            this.LoadMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadMovies.Name = "LoadMovies";
            this.LoadMovies.Size = new System.Drawing.Size(109, 66);
            this.LoadMovies.TabIndex = 2;
            this.LoadMovies.Text = "Load Movies";
            this.LoadMovies.UseVisualStyleBackColor = true;
            this.LoadMovies.Click += new System.EventHandler(this.LoadMovies_Click);
            // 
            // FirstNBox
            // 
            this.FirstNBox.Location = new System.Drawing.Point(504, 495);
            this.FirstNBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FirstNBox.Name = "FirstNBox";
            this.FirstNBox.Size = new System.Drawing.Size(132, 22);
            this.FirstNBox.TabIndex = 3;
            // 
            // LastNBox
            // 
            this.LastNBox.Location = new System.Drawing.Point(363, 546);
            this.LastNBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LastNBox.Name = "LastNBox";
            this.LastNBox.Size = new System.Drawing.Size(132, 22);
            this.LastNBox.TabIndex = 4;
            this.LastNBox.TextChanged += new System.EventHandler(this.LNTBox_TextChanged);
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(504, 546);
            this.AddBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(132, 22);
            this.AddBox.TabIndex = 5;
            this.AddBox.TextChanged += new System.EventHandler(this.AdTBox_TextChanged);
            // 
            // PhBox
            // 
            this.PhBox.Location = new System.Drawing.Point(645, 546);
            this.PhBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhBox.Name = "PhBox";
            this.PhBox.Size = new System.Drawing.Size(132, 22);
            this.PhBox.TabIndex = 6;
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(504, 475);
            this.FNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(76, 17);
            this.FNLabel.TabIndex = 7;
            this.FNLabel.Text = "First Name";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(359, 527);
            this.LNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(76, 17);
            this.LNLabel.TabIndex = 8;
            this.LNLabel.Text = "Last Name";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(500, 527);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(60, 17);
            this.AdLabel.TabIndex = 9;
            this.AdLabel.Text = "Address";
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(641, 527);
            this.PhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(49, 17);
            this.PhLabel.TabIndex = 10;
            this.PhLabel.Text = "Phone";
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.Location = new System.Drawing.Point(16, 473);
            this.AddCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(83, 66);
            this.AddCustBtn.TabIndex = 11;
            this.AddCustBtn.Text = "Add Customer";
            this.AddCustBtn.UseVisualStyleBackColor = true;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.Location = new System.Drawing.Point(107, 473);
            this.UpdCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(83, 66);
            this.UpdCustBtn.TabIndex = 12;
            this.UpdCustBtn.Text = "Update Customer";
            this.UpdCustBtn.UseVisualStyleBackColor = true;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(363, 475);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(85, 17);
            this.CustIDLabel.TabIndex = 14;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // CIdBox
            // 
            this.CIdBox.Enabled = false;
            this.CIdBox.Location = new System.Drawing.Point(363, 495);
            this.CIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CIdBox.Name = "CIdBox";
            this.CIdBox.Size = new System.Drawing.Size(132, 22);
            this.CIdBox.TabIndex = 13;
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.Location = new System.Drawing.Point(197, 473);
            this.DltCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(83, 66);
            this.DltCustBtn.TabIndex = 15;
            this.DltCustBtn.Text = "Delete Customer";
            this.DltCustBtn.UseVisualStyleBackColor = true;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(386, 598);
            this.MovieIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(62, 17);
            this.MovieIDLabel.TabIndex = 17;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // MIdBox
            // 
            this.MIdBox.Enabled = false;
            this.MIdBox.Location = new System.Drawing.Point(363, 619);
            this.MIdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MIdBox.Name = "MIdBox";
            this.MIdBox.Size = new System.Drawing.Size(132, 22);
            this.MIdBox.TabIndex = 16;
            this.MIdBox.TextChanged += new System.EventHandler(this.MovieIDTBox_TextChanged);
            // 
            // ReturnMovieBtn
            // 
            this.ReturnMovieBtn.Location = new System.Drawing.Point(779, 15);
            this.ReturnMovieBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnMovieBtn.Name = "ReturnMovieBtn";
            this.ReturnMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.ReturnMovieBtn.TabIndex = 18;
            this.ReturnMovieBtn.Text = "Return Movie";
            this.ReturnMovieBtn.UseVisualStyleBackColor = true;
            this.ReturnMovieBtn.Click += new System.EventHandler(this.ReturnMovieBtn_Click);
            // 
            // IssueMovieBtn
            // 
            this.IssueMovieBtn.Location = new System.Drawing.Point(661, 15);
            this.IssueMovieBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IssueMovieBtn.Name = "IssueMovieBtn";
            this.IssueMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.IssueMovieBtn.TabIndex = 19;
            this.IssueMovieBtn.Text = "Issue Movie";
            this.IssueMovieBtn.UseVisualStyleBackColor = true;
            this.IssueMovieBtn.Click += new System.EventHandler(this.IssueMovieBtn_Click);
            // 
            // LoadRentedMovies
            // 
            this.LoadRentedMovies.Location = new System.Drawing.Point(251, 15);
            this.LoadRentedMovies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadRentedMovies.Name = "LoadRentedMovies";
            this.LoadRentedMovies.Size = new System.Drawing.Size(109, 66);
            this.LoadRentedMovies.TabIndex = 20;
            this.LoadRentedMovies.Text = "Load Rented Movies";
            this.LoadRentedMovies.UseVisualStyleBackColor = true;
            this.LoadRentedMovies.Click += new System.EventHandler(this.LoadRentedMovies_Click);
            // 
            // PopCustBtn
            // 
            this.PopCustBtn.Location = new System.Drawing.Point(504, 15);
            this.PopCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopCustBtn.Name = "PopCustBtn";
            this.PopCustBtn.Size = new System.Drawing.Size(89, 66);
            this.PopCustBtn.TabIndex = 22;
            this.PopCustBtn.Text = "Popular Customer";
            this.PopCustBtn.UseVisualStyleBackColor = true;
            this.PopCustBtn.Click += new System.EventHandler(this.PopCustBtn_Click);
            // 
            // PopMovBtn
            // 
            this.PopMovBtn.Location = new System.Drawing.Point(407, 15);
            this.PopMovBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopMovBtn.Name = "PopMovBtn";
            this.PopMovBtn.Size = new System.Drawing.Size(89, 66);
            this.PopMovBtn.TabIndex = 23;
            this.PopMovBtn.Text = "Popular Movie";
            this.PopMovBtn.UseVisualStyleBackColor = true;
            this.PopMovBtn.Click += new System.EventHandler(this.PopMovBtn_Click);
            // 
            // RCostBox
            // 
            this.RCostBox.Location = new System.Drawing.Point(362, 678);
            this.RCostBox.Margin = new System.Windows.Forms.Padding(4);
            this.RCostBox.Name = "RCostBox";
            this.RCostBox.Size = new System.Drawing.Size(132, 22);
            this.RCostBox.TabIndex = 24;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(827, 619);
            this.YearBox.Margin = new System.Windows.Forms.Padding(4);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(132, 22);
            this.YearBox.TabIndex = 25;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(670, 619);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(132, 22);
            this.TitleBox.TabIndex = 26;
            // 
            // RatiBox
            // 
            this.RatiBox.Location = new System.Drawing.Point(507, 619);
            this.RatiBox.Margin = new System.Windows.Forms.Padding(4);
            this.RatiBox.Name = "RatiBox";
            this.RatiBox.Size = new System.Drawing.Size(132, 22);
            this.RatiBox.TabIndex = 27;
            // 
            // CopBox
            // 
            this.CopBox.Location = new System.Drawing.Point(507, 678);
            this.CopBox.Margin = new System.Windows.Forms.Padding(4);
            this.CopBox.Name = "CopBox";
            this.CopBox.Size = new System.Drawing.Size(132, 22);
            this.CopBox.TabIndex = 28;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(827, 678);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(132, 22);
            this.GenreBox.TabIndex = 29;
            // 
            // PLBox
            // 
            this.PLBox.Location = new System.Drawing.Point(661, 678);
            this.PLBox.Margin = new System.Windows.Forms.Padding(4);
            this.PLBox.Name = "PLBox";
            this.PLBox.Size = new System.Drawing.Size(132, 22);
            this.PLBox.TabIndex = 30;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(531, 598);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 17);
            this.RatingLabel.TabIndex = 31;
            this.RatingLabel.Text = "Rating";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(705, 598);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 32;
            this.TitleLabel.Text = "Title";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(863, 598);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(38, 17);
            this.YearLabel.TabIndex = 33;
            this.YearLabel.Text = "Year";
            // 
            // RCLabel
            // 
            this.RCLabel.AutoSize = true;
            this.RCLabel.Location = new System.Drawing.Point(386, 657);
            this.RCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RCLabel.Name = "RCLabel";
            this.RCLabel.Size = new System.Drawing.Size(85, 17);
            this.RCLabel.TabIndex = 34;
            this.RCLabel.Text = "Rental_Cost";
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.AutoSize = true;
            this.CopiesLabel.Location = new System.Drawing.Point(531, 657);
            this.CopiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(51, 17);
            this.CopiesLabel.TabIndex = 35;
            this.CopiesLabel.Text = "Copies";
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Location = new System.Drawing.Point(708, 657);
            this.PlotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(32, 17);
            this.PlotLabel.TabIndex = 36;
            this.PlotLabel.Text = "Plot";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(863, 657);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 17);
            this.GenreLabel.TabIndex = 37;
            this.GenreLabel.Text = "Genre";
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Location = new System.Drawing.Point(13, 586);
            this.AddMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(83, 66);
            this.AddMovieBtn.TabIndex = 38;
            this.AddMovieBtn.Text = "Add Movie";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // UpdMovieBtn
            // 
            this.UpdMovieBtn.Location = new System.Drawing.Point(116, 586);
            this.UpdMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdMovieBtn.Name = "UpdMovieBtn";
            this.UpdMovieBtn.Size = new System.Drawing.Size(83, 66);
            this.UpdMovieBtn.TabIndex = 39;
            this.UpdMovieBtn.Text = "Update Movie";
            this.UpdMovieBtn.UseVisualStyleBackColor = true;
            this.UpdMovieBtn.Click += new System.EventHandler(this.UpdMovieBtn_Click);
            // 
            // DltMovieBtn
            // 
            this.DltMovieBtn.Location = new System.Drawing.Point(218, 586);
            this.DltMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DltMovieBtn.Name = "DltMovieBtn";
            this.DltMovieBtn.Size = new System.Drawing.Size(83, 66);
            this.DltMovieBtn.TabIndex = 40;
            this.DltMovieBtn.Text = "Delete Movie";
            this.DltMovieBtn.UseVisualStyleBackColor = true;
            this.DltMovieBtn.Click += new System.EventHandler(this.DltMovieBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 713);
            this.Controls.Add(this.DltMovieBtn);
            this.Controls.Add(this.UpdMovieBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.CopiesLabel);
            this.Controls.Add(this.RCLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.PLBox);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.CopBox);
            this.Controls.Add(this.RatiBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.RCostBox);
            this.Controls.Add(this.PopMovBtn);
            this.Controls.Add(this.PopCustBtn);
            this.Controls.Add(this.LoadRentedMovies);
            this.Controls.Add(this.IssueMovieBtn);
            this.Controls.Add(this.ReturnMovieBtn);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.MIdBox);
            this.Controls.Add(this.DltCustBtn);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.CIdBox);
            this.Controls.Add(this.UpdCustBtn);
            this.Controls.Add(this.AddCustBtn);
            this.Controls.Add(this.PhLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.LNLabel);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.PhBox);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.LastNBox);
            this.Controls.Add(this.FirstNBox);
            this.Controls.Add(this.LoadMovies);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.LoadBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Video Rental";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button LoadMovies;
        private System.Windows.Forms.TextBox FirstNBox;
        private System.Windows.Forms.TextBox LastNBox;
        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.TextBox PhBox;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox CIdBox;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.TextBox MIdBox;
        private System.Windows.Forms.Button ReturnMovieBtn;
        private System.Windows.Forms.Button IssueMovieBtn;
        private System.Windows.Forms.Button LoadRentedMovies;
        private System.Windows.Forms.Button PopCustBtn;
        private System.Windows.Forms.Button PopMovBtn;
        private System.Windows.Forms.TextBox RCostBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox RatiBox;
        private System.Windows.Forms.TextBox CopBox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox PLBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label RCLabel;
        private System.Windows.Forms.Label CopiesLabel;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.Button UpdMovieBtn;
        private System.Windows.Forms.Button DltMovieBtn;
    }
}

