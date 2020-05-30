using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab
{
    public partial class ScienceFictionFantastic : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public ScienceFictionFantastic(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLOTRTwoTowers_Click(object sender, EventArgs e)
        {
            int movieId = 4;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnLOTRTheReturnoftheKing_Click(object sender, EventArgs e)
        {
            int movieId = 8;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnTheDarkKnight_Click(object sender, EventArgs e)
        {
            int movieId = 6;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnHarryPotterOlümYadigarları_Click(object sender, EventArgs e)
        {
            int movieId = 12;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnArifV216_Click(object sender, EventArgs e)
        {
            int movieId = 24;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnTheMask_Click(object sender, EventArgs e)
        {
            int movieId = 5;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
