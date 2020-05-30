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
    public partial class Comedy : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public Comedy(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSungerBob_Click(object sender, EventArgs e)
        {
            int movieId = 60;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnAngryBirds_Click(object sender, EventArgs e)
        {
            int movieId = 63;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnBossBaby_Click(object sender, EventArgs e)
        {
            int movieId = 57;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnKardesimBenim_Click(object sender, EventArgs e)
        {
            int movieId = 45;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

    }
}
