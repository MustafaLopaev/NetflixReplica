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
    public partial class ActionAdventure : Form
    {

        public string tableName;
        public string sqlConnectionString;

        public ActionAdventure(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnAssasinGreed_Click(object sender, EventArgs e)
        {
            int movieId = 2;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnRecepIvedik_Click(object sender, EventArgs e)
        {
            int movieId = 1;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            int movieId = 5;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnTheDarkKnight_Click(object sender, EventArgs e)
        {
            int movieId = 6;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnSherlockHolmes_Click(object sender, EventArgs e)
        {
            int movieId = 7;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnTransformers_Click(object sender, EventArgs e)
        {
            int movieId = 9;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
