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
    public partial class ScienceNature : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public ScienceNature(string emailTrimmed, string connecter)
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

        private void btn72SevimliHayvan_Click(object sender, EventArgs e)
        {
            int movieId = 30;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnMarstaKesif_Click(object sender, EventArgs e)
        {
            int movieId = 32;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnPandemic_Click(object sender, EventArgs e)
        {
            int movieId = 33;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
