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
    public partial class CategoriesActivity : Form
    {
        public string tableName;
        public string sqlConnectionString;
        public CategoriesActivity(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainActivity mainActivity = new MainActivity(tableName, sqlConnectionString);
            mainActivity.Show();
        }
    }
}
