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
    public partial class RegisterActivity : Form
    {
        public string sqlConnectionString;
        

        public RegisterActivity(string connecter)
        {
            sqlConnectionString = connecter;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginActivity loginActivity = new LoginActivity();
            loginActivity.Show();
        }


        public string SqlConnectionString { get => sqlConnectionString; set => sqlConnectionString = value; }
        

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxUsername.Text == "")
                MessageBox.Show("Please fill the boxes! ");
            else if (textBoxPassword.Text != textBoxPassword.Text)
                MessageBox.Show("Passwords do not match! ");
            else if (int.TryParse(textBoxBirthDate.Text, out int n) == false)
                MessageBox.Show("Please Enter the correct Birth Year! ");
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(SqlConnectionString))
                {
                    string register = "insert into userInfo(Username, Email, Password, BirthDate)" +
                        " values (@Username, @Email, @Password, @BirthDate)";
                    var emailTrimmed = textBoxEmail.Text;

                    emailTrimmed = new string((from c in emailTrimmed
                                      where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                                      select c
                   ).ToArray());

                    string watchList = "CREATE TABLE " + emailTrimmed +
                        " (MovieId int NOT NULL, "+
                        "MovieName varchar(50) NOT NULL PRIMARY KEY," +
                        "WatchDate varchar(50) NOT NULL," +
                        "WatchTime varchar(50) NOT NULL," +
                        "Episode int," +
                        "Rating int);";

                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(watchList, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand = new SqlCommand(register, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    sqlCommand.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    sqlCommand.Parameters.AddWithValue("@BirthDate", textBoxBirthDate.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Registration is successful!");

                    


                    this.Hide();
                    CategoriesActivity categoriesActivity = new CategoriesActivity(emailTrimmed, sqlConnectionString);
                    categoriesActivity.Show();
                }
            }
        }

        private void textBoxEnterPassword_OnValueChanged(object sender, EventArgs e)
        {
            textBoxPassword.isPassword = true;
        }

        private void textBoxRePassword_OnValueChanged(object sender, EventArgs e)
        {
            textBoxRePassword.isPassword = true;
        }
    }
}
