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
    public partial class Anime : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public Anime(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBeyblade_Click(object sender, EventArgs e)
        {
            int movieId = 65;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnSonic_Click(object sender, EventArgs e)
        {
            int movieId = 66;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
