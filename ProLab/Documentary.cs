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
    public partial class Documentary : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public Documentary(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKuscular_Click(object sender, EventArgs e)
        {
            int movieId = 31;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnMissionBlue_Click(object sender, EventArgs e)
        {
            int movieId = 17;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnDreamBig_Click(object sender, EventArgs e)
        {
            int movieId = 19;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnChassingCoral_Click(object sender, EventArgs e)
        {
            int movieId = 20;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
