using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Game_collection___Inlämning_3
{

    public partial class ViewStats : Form
    {
        private List<VideoGame> videoGames;
        public ViewStats(List<VideoGame> games)
        {
            InitializeComponent();
            videoGames = games;
            DisplayPlattformStats();
            DisplayPlattformStatsTotalGames();
        }
        private void DisplayPlattformStats()
        {
            var platformCounts = videoGames.GroupBy(game => game.Plattform).Select(group => $"{group.Key}: {group.Count()} games");

            platformStatsLabel.Text = $"Platform Stats:\n{string.Join("\n", platformCounts)}";

        }
        private void DisplayPlattformStatsTotalGames()
        {
            plattformStatsTotalLabel.Text = $"Total Games: {videoGames.Count}";
        }
    }
}
