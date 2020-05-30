using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;

namespace ProLab
{
    public partial class Player : Form
    {
        
        private int totalSeconds;
        static public string tableName;
        static public int movieId;
        static public string sqlConnectionString;

        public Player(string emailTrimmed, int userChoose, string connecter)
        {
            tableName = emailTrimmed;
            movieId = userChoose;
            sqlConnectionString = connecter;
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.timerMovie.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.timerMovie.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();
            if (labelTime.Text.Length < 8)
            {
                labelTime.Text = "0" + labelTime.Text;
            }
            string q = "UPDATE " + tableName + " SET WatchTime = '" + labelTime.Text + "' WHERE MovieId = " + movieId;

            SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Close();
            
        }

        private void Player_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            sqlConnection.Open();
            // add tableName
            string getMovie = "SELECT MovieName, EpisodeNum, MovieLen FROM Movies WHERE MovieId = " + movieId;
            string MovieName = null, EpisodeNum = null, MovieLen = null;
            string q = "Select WatchTime, Rating, MovieName from " + tableName + " where MovieId = " + movieId;

            SqlCommand getData = new SqlCommand(getMovie, sqlConnection);
            SqlDataReader dac = getData.ExecuteReader();

            while (dac.Read())
            {
                MovieName = dac.GetValue(0).ToString();
                EpisodeNum = dac.GetValue(1).ToString();
                MovieLen = dac.GetValue(2).ToString();
            }
            dac.Close();
            try
            {
                string movieInfo = "insert into "
                                   + tableName
                                   + " (MovieId, MovieName, WatchDate, WatchTime, Episode, Rating) "
                                   + "values("
                                   + movieId + ", '"
                                   + MovieName
                                   + "' , ' " + DateTime.Now.ToString("dd/MM/yyyy") + " ', '" + MovieLen + "', 1, 0)";
                SqlCommand insertData = new SqlCommand(movieInfo, sqlConnection);
                insertData.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {

            }

            SqlCommand cmd = new SqlCommand(q, sqlConnection);
            SqlDataReader da = cmd.ExecuteReader();
            string time = null;

            while (da.Read())
            {
                time = da.GetValue(0).ToString();
                movieRating.Text = da.GetValue(1).ToString();
                labelMovie.Text = da.GetValue(2).ToString();
            }

            sqlConnection.Close();
            
            int hours = Int32.Parse(time.Substring(0, 2));
            
            int minutes = Int32.Parse(time.Substring(3, 2));
            
            int seconds = Int32.Parse(time.Substring(6, 2));

            totalSeconds = hours * 3600 + minutes * 60 + seconds;
            this.timerMovie.Enabled = true;
        }

        

        private void btnRating_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            string q = "UPDATE " + tableName + " SET Rating = '" + movieRating.Text + "' WHERE MovieId = " + movieId;
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timerMovie_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int hours = totalSeconds / 3600;
                int minutes = (totalSeconds - hours * 3600) / 60;
                int seconds = (totalSeconds - hours * 3600 - minutes * 60);

                this.labelTime.Text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                this.timerMovie.Stop();
                MessageBox.Show("Movie End");
            }
        }
    }
}
