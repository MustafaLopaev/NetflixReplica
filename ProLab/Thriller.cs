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
    public partial class Thriller : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public Thriller(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnCriminal_Click(object sender, EventArgs e)
        {
            int movieId = 64;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            int movieId = 68;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnDaVinciSifresi_Click(object sender, EventArgs e)
        {
            int movieId = 49;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnJaws_Click(object sender, EventArgs e)
        {
            int movieId = 48;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
