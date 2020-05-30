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
    public partial class Drama : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public Drama(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBiziHatirla_Click(object sender, EventArgs e)
        {
            int movieId = 43;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnDangal_Click(object sender, EventArgs e)
        {
            int movieId = 46;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnDelibal_Click(object sender, EventArgs e)
        {
            int movieId = 44;
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
