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
    public partial class ChildFamily : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public ChildFamily(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPokemon_Click(object sender, EventArgs e)
        {
            int movieId = 34;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnSirinler_Click(object sender, EventArgs e)
        {
            int movieId = 35;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnAlvinSincaplar_Click(object sender, EventArgs e)
        {
            int movieId = 37;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnScoobyDoo_Click(object sender, EventArgs e)
        {
            int movieId = 38;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnKungFiPanda_Click(object sender, EventArgs e)
        {
            int movieId = 39;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnMrBean_Click(object sender, EventArgs e)
        {
            int movieId = 40;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
