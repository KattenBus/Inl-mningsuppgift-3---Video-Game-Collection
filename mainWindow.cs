using Newtonsoft.Json;
using System.Windows.Forms;

namespace Video_Game_collection___Inlämning_3
{
    public partial class mainWindow : Form
    {
        public List<VideoGame> videoGames = new List<VideoGame>();
        public string filePath = Path.Combine(Application.StartupPath, "VideoGameList.json");
        public GameList gameListForm;
        public ViewStats viewStats;
        public string imagePath;
        private bool unsavedChanges = false;
        public mainWindow()
        {
            InitializeComponent();
            LoadGameProject();
        }
        private void addGameButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gameTitleTextBox.Text) &&
                !string.IsNullOrEmpty(plattformComboBox.Text) &&
                !string.IsNullOrEmpty(genreComboBox.Text) &&
                !string.IsNullOrEmpty(releaseYearComboBox.Text))
            {
                VideoGame newGame = new VideoGame
                (gameTitleTextBox.Text,
                plattformComboBox.Text,
                genreComboBox.Text,
                releaseYearComboBox.Text,
                imagePath);

                videoGames.Add(newGame);

                gameTitleTextBox.Clear();
                plattformComboBox.SelectedIndex = -1;
                genreComboBox.SelectedIndex = -1;
                releaseYearComboBox.SelectedIndex = -1;
                gamePicturePictureBox.Image = null;

                MessageBox.Show("Video Game added!");

                unsavedChanges = true;

            }
            else
            {
                MessageBox.Show("Please fill out all the fields!");
            }
        }
        private void viewStatsButton_Click(object sender, EventArgs e)
        {
            viewStats = new ViewStats(videoGames);
            viewStats.Show();
        }
        private void viewGameListButton_Click(object sender, EventArgs e)
        {
            gameListForm = new GameList(videoGames);
            gameListForm.Show();
        }
        public void saveProgramButton_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(videoGames);
            MessageBox.Show($"Saved Project to: {filePath}");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(json);
            }

            unsavedChanges = false;
        }
        public void LoadGameProject()
        {
            if (File.Exists(filePath))
            {
                string json;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    json = sr.ReadToEnd();
                    MessageBox.Show($"Loaded Project from: {filePath}");
                }

                videoGames = JsonConvert.DeserializeObject<List<VideoGame>>(json);
            }
            else
            {
                MessageBox.Show($"File not found: {filePath}");
            }
        }
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before closing?", "Friendly Reminder", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    saveProgramButton_Click(sender, e);
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void gamePicturePictureBox_Click(object sender, EventArgs e)
        {
            string initialDirectory = Path.Combine(Application.StartupPath, "VideoGamePictures");

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = initialDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                imagePath = Path.Combine("VideoGamePictures", fileName);

                gamePicturePictureBox.ImageLocation = imagePath;

                string destinationPath = Path.Combine(initialDirectory, Path.GetFileName(imagePath));

                if (!File.Exists(destinationPath))
                {
                    File.Copy(imagePath, destinationPath);

                    imagePath = destinationPath;
                }

            }
        }
    }
}