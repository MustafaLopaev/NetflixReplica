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
    public partial class Romantic : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public Romantic(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelibal_Click(object sender, EventArgs e)
        {
            int movieId = 44;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnHowIMetYourMother_Click(object sender, EventArgs e)
        {
            int movieId = 54;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnLeylaileMecnun_Click(object sender, EventArgs e)
        {
            int movieId = 55;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnBeniBöyleSev_Click(object sender, EventArgs e)
        {
            int movieId = 56;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnAtiye_Click(object sender, EventArgs e)
        {
            int movieId = 58;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
