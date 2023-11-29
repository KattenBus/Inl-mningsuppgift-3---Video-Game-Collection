namespace Video_Game_collection___Inlämning_3
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            greetingLabel = new Label();
            gameTitleLabel = new Label();
            gameTitleTextBox = new TextBox();
            plattformLabel = new Label();
            releaseYearLabel = new Label();
            genreLabel = new Label();
            genreComboBox = new ComboBox();
            addGameButton = new Button();
            viewStatsButton = new Button();
            viewGameListButton = new Button();
            releaseYearComboBox = new ComboBox();
            plattformComboBox = new ComboBox();
            saveProgramButton = new Button();
            gamePicturePictureBox = new PictureBox();
            addPictureLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)gamePicturePictureBox).BeginInit();
            SuspendLayout();
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            greetingLabel.Location = new Point(12, 9);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(493, 37);
            greetingLabel.TabIndex = 0;
            greetingLabel.Text = "Welcome! Add a game to the collection!";
            // 
            // gameTitleLabel
            // 
            gameTitleLabel.AutoSize = true;
            gameTitleLabel.Location = new Point(27, 151);
            gameTitleLabel.Name = "gameTitleLabel";
            gameTitleLabel.Size = new Size(29, 15);
            gameTitleLabel.TabIndex = 1;
            gameTitleLabel.Text = "Title";
            // 
            // gameTitleTextBox
            // 
            gameTitleTextBox.Location = new Point(27, 169);
            gameTitleTextBox.Name = "gameTitleTextBox";
            gameTitleTextBox.Size = new Size(150, 23);
            gameTitleTextBox.TabIndex = 1;
            // 
            // plattformLabel
            // 
            plattformLabel.AutoSize = true;
            plattformLabel.Location = new Point(27, 195);
            plattformLabel.Name = "plattformLabel";
            plattformLabel.Size = new Size(57, 15);
            plattformLabel.TabIndex = 3;
            plattformLabel.Text = "Plattform";
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.AutoSize = true;
            releaseYearLabel.Location = new Point(27, 283);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new Size(71, 15);
            releaseYearLabel.TabIndex = 6;
            releaseYearLabel.Text = "Release Year";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(27, 239);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(38, 15);
            genreLabel.TabIndex = 7;
            genreLabel.Text = "Genre";
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Action", "Action RPG", "Action/Adventure", "Beat'Em Up", "Educational", "Fighting", "Horror", "Indie", "JRPG", "Music and Rythm", "Party Game", "Plattformer", "Point and Click", "Puzzle", "Racing", "RPG", "Shoot'Em Up", "Shooter", "Sport", "Strategy RPG", "Survival", "Visual Novel" });
            genreComboBox.Location = new Point(27, 257);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(121, 23);
            genreComboBox.Sorted = true;
            genreComboBox.TabIndex = 3;
            // 
            // addGameButton
            // 
            addGameButton.Location = new Point(652, 377);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new Size(164, 140);
            addGameButton.TabIndex = 5;
            addGameButton.Text = "Add Game";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += addGameButton_Click;
            // 
            // viewStatsButton
            // 
            viewStatsButton.Location = new Point(129, 443);
            viewStatsButton.Name = "viewStatsButton";
            viewStatsButton.Size = new Size(136, 74);
            viewStatsButton.TabIndex = 8;
            viewStatsButton.Text = "View Stats";
            viewStatsButton.UseVisualStyleBackColor = true;
            viewStatsButton.Click += viewStatsButton_Click;
            // 
            // viewGameListButton
            // 
            viewGameListButton.Location = new Point(12, 442);
            viewGameListButton.Name = "viewGameListButton";
            viewGameListButton.Size = new Size(111, 74);
            viewGameListButton.TabIndex = 9;
            viewGameListButton.Text = "Game List";
            viewGameListButton.UseVisualStyleBackColor = true;
            viewGameListButton.Click += viewGameListButton_Click;
            // 
            // releaseYearComboBox
            // 
            releaseYearComboBox.FormattingEnabled = true;
            releaseYearComboBox.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970" });
            releaseYearComboBox.Location = new Point(27, 301);
            releaseYearComboBox.MaxDropDownItems = 5;
            releaseYearComboBox.Name = "releaseYearComboBox";
            releaseYearComboBox.Size = new Size(121, 23);
            releaseYearComboBox.TabIndex = 4;
            // 
            // plattformComboBox
            // 
            plattformComboBox.BackColor = SystemColors.Window;
            plattformComboBox.DropDownWidth = 180;
            plattformComboBox.FormattingEnabled = true;
            plattformComboBox.Items.AddRange(new object[] { "3DO", "Amiga CD32", "Atari 2600", "Atari 5200", "Atari Jaguar", "ColecoVision", "Intellivision", "Neo Geo", "NES", "Nintendo 3DS", "Nintendo 64", "Nintendo DS", "Nintendo GameBoy", "Nintendo GameBoy Advance", "Nintendo GameBoy Colour", "Nintendo GameCube", "Nintendo Switch", "Nintendo Virtual Boy", "Nintendo Wii", "Nintendo Wii-U", "Nokia NGAGE", "Ouya", "PC", "Phillips CD-i", "Playstation 1", "Playstation 2", "Playstation 3", "Playstation 4", "Playstation 5", "SEGA DreamCast", "SEGA MasterSystem", "SEGA MegaDrive", "SEGA Saturn", "Sony PSP", "Sony PSVITA", "Super Nintendo", "TurboGrafx-16(PC-Engine)", "Vectrex", "Xbox", "Xbox 360", "Xbox one", "Xbox Series S/X" });
            plattformComboBox.Location = new Point(27, 213);
            plattformComboBox.Name = "plattformComboBox";
            plattformComboBox.Size = new Size(121, 23);
            plattformComboBox.Sorted = true;
            plattformComboBox.TabIndex = 2;
            // 
            // saveProgramButton
            // 
            saveProgramButton.Location = new Point(485, 441);
            saveProgramButton.Name = "saveProgramButton";
            saveProgramButton.Size = new Size(161, 75);
            saveProgramButton.TabIndex = 6;
            saveProgramButton.Text = "Save Project";
            saveProgramButton.UseVisualStyleBackColor = true;
            saveProgramButton.Click += saveProgramButton_Click;
            // 
            // gamePicturePictureBox
            // 
            gamePicturePictureBox.BorderStyle = BorderStyle.FixedSingle;
            gamePicturePictureBox.Cursor = Cursors.Hand;
            gamePicturePictureBox.Location = new Point(203, 169);
            gamePicturePictureBox.Name = "gamePicturePictureBox";
            gamePicturePictureBox.Size = new Size(200, 200);
            gamePicturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            gamePicturePictureBox.TabIndex = 10;
            gamePicturePictureBox.TabStop = false;
            gamePicturePictureBox.Click += gamePicturePictureBox_Click;
            // 
            // addPictureLabel
            // 
            addPictureLabel.AutoSize = true;
            addPictureLabel.Location = new Point(203, 372);
            addPictureLabel.Name = "addPictureLabel";
            addPictureLabel.Size = new Size(189, 15);
            addPictureLabel.TabIndex = 11;
            addPictureLabel.Text = "Click in the frame to add a picture!";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 529);
            Controls.Add(addPictureLabel);
            Controls.Add(gamePicturePictureBox);
            Controls.Add(saveProgramButton);
            Controls.Add(plattformComboBox);
            Controls.Add(releaseYearComboBox);
            Controls.Add(viewGameListButton);
            Controls.Add(viewStatsButton);
            Controls.Add(addGameButton);
            Controls.Add(genreComboBox);
            Controls.Add(genreLabel);
            Controls.Add(releaseYearLabel);
            Controls.Add(plattformLabel);
            Controls.Add(gameTitleTextBox);
            Controls.Add(gameTitleLabel);
            Controls.Add(greetingLabel);
            Name = "mainWindow";
            Text = "mainWindow";
            FormClosing += mainWindow_FormClosing;
            ((System.ComponentModel.ISupportInitialize)gamePicturePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetingLabel;
        private Label gameTitleLabel;
        private TextBox gameTitleTextBox;
        private Label plattformLabel;
        private Label releaseYearLabel;
        private Label genreLabel;
        private ComboBox genreComboBox;
        private Button addGameButton;
        private Button viewStatsButton;
        private Button viewGameListButton;
        private ComboBox releaseYearComboBox;
        private ComboBox plattformComboBox;
        private Button saveProgramButton;
        private PictureBox gamePicturePictureBox;
        private Label addPictureLabel;
    }
}