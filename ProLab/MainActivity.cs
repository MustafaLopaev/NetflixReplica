using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProLab
{
    public partial class MainActivity : Form
    {
        public string tableName;

        public string sqlConnectionString;
        public MainActivity(string emailTrimmed, string connecter)
        {
            sqlConnectionString = connecter;
            tableName = emailTrimmed;
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            
            panelCategoriesSubmenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelCategoriesSubmenu.Visible == true)
                panelCategoriesSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        
        //hideSubMenu();

        private Form activeForm = null;
        private void openChildFrom(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCategoriesSubmenu);
        }

        private void btnActionAdventure_Click(object sender, EventArgs e)
        {
            openChildFrom(new ActionAdventure(tableName, sqlConnectionString));
            
            hideSubMenu();
        }

        private void btnDocumentary_Click(object sender, EventArgs e)
        {
            openChildFrom(new Documentary(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnScienceFictionFantastic_Click(object sender, EventArgs e)
        {
            openChildFrom(new ScienceFictionFantastic(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnRomantic_Click(object sender, EventArgs e)
        {
            openChildFrom(new Romantic(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnRealityProgram_Click(object sender, EventArgs e)
        {
            openChildFrom(new RealityProgram(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnAnime_Click(object sender, EventArgs e)
        {
            openChildFrom(new Anime(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnComedy_Click(object sender, EventArgs e)
        {
            openChildFrom(new Comedy(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnScienceNature_Click(object sender, EventArgs e)
        {
            openChildFrom(new ScienceNature(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnChildFamily_Click(object sender, EventArgs e)
        {
            openChildFrom(new ChildFamily(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnDrama_Click(object sender, EventArgs e)
        {
            openChildFrom(new Drama(tableName, sqlConnectionString));

            hideSubMenu();
        }

        private void btnThriller_Click(object sender, EventArgs e)
        {
            openChildFrom(new Thriller(tableName, sqlConnectionString));
            hideSubMenu();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();

            string getMovie = "SELECT MovieId FROM Movies WHERE MovieName = '" + textBoxSearch.Text + "'";

            SqlCommand getData = new SqlCommand(getMovie, sqlConnection);
            SqlDataReader dac = getData.ExecuteReader();
            string Id = null;
            while (dac.Read())
            {
                Id = dac.GetValue(0).ToString();
            }
            try
            {
                int movieId = Int32.Parse(Id);
                Player player = new Player(tableName, movieId, sqlConnectionString);
                player.Show();
            }
            catch (Exception)
            {

            }

            sqlConnection.Close();
        }
    }
}
