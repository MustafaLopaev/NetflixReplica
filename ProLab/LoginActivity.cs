using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace ProLab
{
    public partial class LoginActivity : Form
    {
        string sqlConnectionString = @"Data Source = (LocalDB)\ProLab; Initial Catalog = userTable; Integrated Security=True;";

        public string SqlConnectionString { get => sqlConnectionString; set => sqlConnectionString = value; }

        public LoginActivity()
        {
            InitializeComponent();

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select count(*) from userInfo where Email='"
                + textBoxEmail.Text + "'and Password='" + textBoxPassword.Text + "'", SqlConnectionString);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows[0][0].ToString() != "1")
                MessageBox.Show("Password/Username is not correct!", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var emailTrimmed = textBoxEmail.Text;

                emailTrimmed = new string((from c in emailTrimmed
                                           where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                                           select c
                ).ToArray());
                this.Hide();
                MainActivity mainActivity = new MainActivity(emailTrimmed, sqlConnectionString);
                mainActivity.Show();
            }
            
            /*
            this.Hide();
            MainActivity mainActivity = new MainActivity(" ");
            mainActivity.Show();
            */
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterActivity registerActivity = new RegisterActivity(sqlConnectionString);
            registerActivity.Show();
        }

        private void textBoxPassword_OnValueChanged(object sender, EventArgs e)
        {
            textBoxPassword.isPassword = true;
        }
    }
}
