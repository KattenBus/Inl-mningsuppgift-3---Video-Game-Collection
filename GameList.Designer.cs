namespace Video_Game_collection___Inlämning_3
{
    partial class GameList
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
            gameListListView = new ListView();
            Title = new ColumnHeader();
            editGameButton = new Button();
            removeGameButton = new Button();
            gameTitleGameListLabel = new Label();
            plattformGameListLabel = new Label();
            genreGameListLabel = new Label();
            releaseYearGameListLabel = new Label();
            gameTitleGameListTextBox = new TextBox();
            plattformGameListTextBox = new TextBox();
            genreGameListTextBox = new TextBox();
            releaseYearGameListTextBox = new TextBox();
            gameListPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameListPictureBox).BeginInit();
            SuspendLayout();
            // 
            // gameListListView
            // 
            gameListListView.Alignment = ListViewAlignment.Left;
            gameListListView.Columns.AddRange(new ColumnHeader[] { Title });
            gameListListView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gameListListView.Location = new Point(55, 26);
            gameListListView.Name = "gameListListView";
            gameListListView.Size = new Size(305, 407);
            gameListListView.Sorting = SortOrder.Ascending;
            gameListListView.TabIndex = 0;
            gameListListView.UseCompatibleStateImageBehavior = false;
            gameListListView.View = View.List;
            gameListListView.ItemSelectionChanged += gameListListView_ItemSelectionChanged;
            // 
            // Title
            // 
            Title.Text = "Title";
            Title.Width = 500;
            // 
            // editGameButton
            // 
            editGameButton.Location = new Point(55, 438);
            editGameButton.Name = "editGameButton";
            editGameButton.Size = new Size(144, 39);
            editGameButton.TabIndex = 5;
            editGameButton.Text = "Edit Game";
            editGameButton.UseVisualStyleBackColor = true;
            editGameButton.Click += editGameButton_Click;
            // 
            // removeGameButton
            // 
            removeGameButton.Location = new Point(220, 438);
            removeGameButton.Name = "removeGameButton";
            removeGameButton.Size = new Size(140, 39);
            removeGameButton.TabIndex = 6;
            removeGameButton.Text = "Remove Game";
            removeGameButton.UseVisualStyleBackColor = true;
            removeGameButton.Click += removeGameButton_Click;
            // 
            // gameTitleGameListLabel
            // 
            gameTitleGameListLabel.AutoSize = true;
            gameTitleGameListLabel.Font = new Font("Yamaha EBM 8", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            gameTitleGameListLabel.Location = new Point(394, 26);
            gameTitleGameListLabel.Name = "gameTitleGameListLabel";
            gameTitleGameListLabel.Size = new Size(222, 47);
            gameTitleGameListLabel.TabIndex = 8;
            gameTitleGameListLabel.Text = "GameTitle";
            // 
            // plattformGameListLabel
            // 
            plattformGameListLabel.AutoSize = true;
            plattformGameListLabel.Font = new Font("Yamaha EBM 8", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plattformGameListLabel.Location = new Point(394, 116);
            plattformGameListLabel.Name = "plattformGameListLabel";
            plattformGameListLabel.Size = new Size(169, 35);
            plattformGameListLabel.TabIndex = 9;
            plattformGameListLabel.Text = "Plattform";
            // 
            // genreGameListLabel
            // 
            genreGameListLabel.AutoSize = true;
            genreGameListLabel.Font = new Font("Yamaha EBM 8", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            genreGameListLabel.Location = new Point(394, 199);
            genreGameListLabel.Name = "genreGameListLabel";
            genreGameListLabel.Size = new Size(112, 35);
            genreGameListLabel.TabIndex = 10;
            genreGameListLabel.Text = "Genre";
            // 
            // releaseYearGameListLabel
            // 
            releaseYearGameListLabel.AutoSize = true;
            releaseYearGameListLabel.Font = new Font("Yamaha EBM 8", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            releaseYearGameListLabel.Location = new Point(394, 275);
            releaseYearGameListLabel.Name = "releaseYearGameListLabel";
            releaseYearGameListLabel.Size = new Size(225, 35);
            releaseYearGameListLabel.TabIndex = 11;
            releaseYearGameListLabel.Text = "Release Year";
            // 
            // gameTitleGameListTextBox
            // 
            gameTitleGameListTextBox.BackColor = Color.FromArgb(128, 255, 128);
            gameTitleGameListTextBox.Location = new Point(394, 367);
            gameTitleGameListTextBox.Name = "gameTitleGameListTextBox";
            gameTitleGameListTextBox.Size = new Size(150, 23);
            gameTitleGameListTextBox.TabIndex = 12;
            // 
            // plattformGameListTextBox
            // 
            plattformGameListTextBox.BackColor = Color.FromArgb(128, 255, 128);
            plattformGameListTextBox.Location = new Point(394, 396);
            plattformGameListTextBox.Name = "plattformGameListTextBox";
            plattformGameListTextBox.Size = new Size(100, 23);
            plattformGameListTextBox.TabIndex = 13;
            // 
            // genreGameListTextBox
            // 
            genreGameListTextBox.BackColor = Color.FromArgb(128, 255, 128);
            genreGameListTextBox.Location = new Point(394, 425);
            genreGameListTextBox.Name = "genreGameListTextBox";
            genreGameListTextBox.Size = new Size(100, 23);
            genreGameListTextBox.TabIndex = 14;
            // 
            // releaseYearGameListTextBox
            // 
            releaseYearGameListTextBox.BackColor = Color.FromArgb(128, 255, 128);
            releaseYearGameListTextBox.Location = new Point(394, 454);
            releaseYearGameListTextBox.Name = "releaseYearGameListTextBox";
            releaseYearGameListTextBox.Size = new Size(100, 23);
            releaseYearGameListTextBox.TabIndex = 15;
            // 
            // gameListPictureBox
            // 
            gameListPictureBox.BorderStyle = BorderStyle.FixedSingle;
            gameListPictureBox.Location = new Point(746, 90);
            gameListPictureBox.Name = "gameListPictureBox";
            gameListPictureBox.Size = new Size(300, 300);
            gameListPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gameListPictureBox.TabIndex = 16;
            gameListPictureBox.TabStop = false;
            // 
            // GameList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1058, 506);
            Controls.Add(gameListPictureBox);
            Controls.Add(releaseYearGameListTextBox);
            Controls.Add(genreGameListTextBox);
            Controls.Add(plattformGameListTextBox);
            Controls.Add(gameTitleGameListTextBox);
            Controls.Add(releaseYearGameListLabel);
            Controls.Add(genreGameListLabel);
            Controls.Add(plattformGameListLabel);
            Controls.Add(gameTitleGameListLabel);
            Controls.Add(removeGameButton);
            Controls.Add(editGameButton);
            Controls.Add(gameListListView);
            Name = "GameList";
            Text = "GameList";
            ((System.ComponentModel.ISupportInitialize)gameListPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button editGameButton;
        private Button removeGameButton;
        private ColumnHeader Title;
        public ListView gameListListView;
        private Label gameTitleGameListLabel;
        private Label plattformGameListLabel;
        private Label genreGameListLabel;
        private Label releaseYearGameListLabel;
        private TextBox gameTitleGameListTextBox;
        private TextBox plattformGameListTextBox;
        private TextBox genreGameListTextBox;
        private TextBox releaseYearGameListTextBox;
        private PictureBox gameListPictureBox;
    }
}