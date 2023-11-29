using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Game_collection___Inlämning_3
{
    public partial class GameList : Form
    {
        public List<VideoGame> videoGames;
        private string originalTitle;
        public GameList(List<VideoGame> games)
        {
            InitializeComponent();
            videoGames = games;
            PopulateGameListListView();

            gameTitleGameListTextBox.Visible = false;
            plattformGameListTextBox.Visible = false;
            genreGameListTextBox.Visible = false;
            releaseYearGameListTextBox.Visible = false;

            gameTitleGameListLabel.Visible = false;
            plattformGameListLabel.Visible = false;
            genreGameListLabel.Visible = false;
            releaseYearGameListLabel.Visible = false;
            gameListPictureBox.Visible = false;
        }
        public void PopulateGameListListView()
        {
            foreach (VideoGame game in videoGames)
            {
                ListViewItem item = new ListViewItem(game.Title);
                gameListListView.Items.Add(item);
                item.SubItems.Add(game.Plattform);
                item.SubItems.Add(game.Genre);
                item.SubItems.Add(game.ReleaseYear);
            }
        }
        private void gameListListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                gameTitleGameListTextBox.Text = e.Item.Text;
                plattformGameListTextBox.Text = e.Item.SubItems[1].Text;
                genreGameListTextBox.Text = e.Item.SubItems[2].Text;
                releaseYearGameListTextBox.Text = e.Item.SubItems[3].Text;

                gameTitleGameListLabel.Text = e.Item.Text;
                plattformGameListLabel.Text = e.Item.SubItems[1].Text;
                genreGameListLabel.Text = e.Item.SubItems[2].Text;
                releaseYearGameListLabel.Text = e.Item.SubItems[3].Text;

                string imagePath = videoGames.FirstOrDefault(game => game.Title == e.Item.Text)?.ImagePath;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    gameListPictureBox.ImageLocation = imagePath;
                }
                else
                {
                    // Clear the image if imagePath is empty
                    gameListPictureBox.Image = null;
                }

                gameTitleGameListLabel.Visible = true;
                plattformGameListLabel.Visible = true;
                genreGameListLabel.Visible = true;
                releaseYearGameListLabel.Visible = true;
                gameListPictureBox.Visible = true;
            }
        }
        private void removeGameButton_Click(object sender, EventArgs e)
        {

            if (gameListListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedGame = gameListListView.SelectedItems[0];
                gameListListView.Items.Remove(selectedGame);

                VideoGame gameToRemove = videoGames.FirstOrDefault(game => game.Title == selectedGame.Text);
                videoGames.Remove(gameToRemove);

                gameTitleGameListTextBox.Clear();
                plattformGameListTextBox.Clear();
                genreGameListTextBox.Clear();
                releaseYearGameListTextBox.Clear();

                gameTitleGameListLabel.Visible = false;
                plattformGameListLabel.Visible = false;
                genreGameListLabel.Visible = false;
                releaseYearGameListLabel.Visible = false;
                gameListPictureBox.Visible = false;
            }
            else
            {
                MessageBox.Show("First choose a game to remove! or maybe there are no games to remove!");
            }
        }
        private void editGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (editGameButton.Text == "Edit Game")
                {
                    originalTitle = gameListListView.SelectedItems[0].Text;

                    editGameButton.Text = "Stop Edit";

                    gameTitleGameListTextBox.Visible = true;
                    plattformGameListTextBox.Visible = true;
                    genreGameListTextBox.Visible = true;
                    releaseYearGameListTextBox.Visible = true;
                    gameListPictureBox.Visible = true;
                }
                else
                {
                    gameTitleGameListTextBox.Visible = false;
                    plattformGameListTextBox.Visible = false;
                    genreGameListTextBox.Visible = false;
                    releaseYearGameListTextBox.Visible = false;

                    editGameButton.Text = "Edit Game";
                }
                if (gameListListView.SelectedItems.Count > 0)
                {
                    ListViewItem gameToEdit = gameListListView.SelectedItems[0];
                    gameToEdit.Text = gameTitleGameListTextBox.Text;
                    gameToEdit.SubItems[1].Text = plattformGameListTextBox.Text;
                    gameToEdit.SubItems[2].Text = genreGameListTextBox.Text;
                    gameToEdit.SubItems[3].Text = releaseYearGameListTextBox.Text;

                    VideoGame gameToUpdate = videoGames.FirstOrDefault(game => game.Title == originalTitle);
                    if (gameToUpdate != null)
                    {
                        gameToUpdate.Title = gameTitleGameListTextBox.Text;
                        gameToUpdate.Plattform = plattformGameListTextBox.Text;
                        gameToUpdate.Genre = genreGameListTextBox.Text;
                        gameToUpdate.ReleaseYear = releaseYearGameListTextBox.Text;
                    }
                }
            }
            catch
            {
                MessageBox.Show("First choose a game to edit! or maybe there are no games to edit!");
            }
            
        }
    }
}
