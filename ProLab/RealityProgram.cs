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
    public partial class RealityProgram : Form
    {
        public string tableName;
        public string sqlConnectionString;

        public RealityProgram(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDunyaninEnSiradisiEvleri_Click(object sender, EventArgs e)
        {
            int movieId = 69;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnCarMasters_Click(object sender, EventArgs e)
        {
            int movieId = 70;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnBasketballOrNothing_Click(object sender, EventArgs e)
        {
            int movieId = 72;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnSiradisiKulubeler_Click(object sender, EventArgs e)
        {
            int movieId = 74;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnGrandDesigns_Click(object sender, EventArgs e)
        {
            int movieId = 71;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }

        private void btnTheBigFamilyCooking_Click(object sender, EventArgs e)
        {
            int movieId = 73;
            Player player = new Player(tableName, movieId, sqlConnectionString);
            player.Show();
        }
    }
}
