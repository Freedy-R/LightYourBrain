using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightYourBrain
{
    public partial class QuestionsForm_main : Form
    {
        
        public QuestionsForm_main()
        {
            InitializeComponent();
            
        }


        SqlCommand cmd;
        int n = 1;
        int score = 0;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\Question.mdf" + ";Integrated Security=True;");
        string answer;

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = "Your Score: " + score;
            connection.Open();
                string selectquery = "SELECT Question FROM Questions WHERE id =" + n;
                SqlCommand cmd = new SqlCommand(selectquery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                questionLabel.Text=reader.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("Masz błąd dsn");
            }
            connection.Close();
        }
        private void loadQuenstions()
        {
            n++;
            connection.Open();
            string selectquery = "SELECT Question FROM Questions WHERE id =" + n;
            SqlCommand cmd = new SqlCommand(selectquery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                questionLabel.Text = reader.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("WYGRAŁEŚ ALBO NIE. NIE WIEM W SUMIE BO JESTEM TYLKO SZTYWNYM NAPISANYM TEKSTEM KTÓRY NIE WIE ILE MASZ PUNKTÓW B).");
            }
            connection.Close();
        }
        private void checkanswer()
        {
            string rightAnswer;
            connection.Open();
            string selectquery = "SELECT Right_Answer FROM Questions WHERE id =" + n;
            SqlCommand cmd = new SqlCommand(selectquery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               rightAnswer = reader.GetValue(0).ToString();
               if (rightAnswer == answer)
                {
                    MessageBox.Show("Dobrze, następne pytanie");
                    score += 100;
                }
                else
                {
                    MessageBox.Show("Źle, następne pytanie");
                }

            }
            else
            {
               MessageBox.Show("Błąd");
            }
            connection.Close();
            
        }

        private void buttonAnsw1_Click(object sender, EventArgs e)
        {
            
            answer = "A";
            checkanswer();
            scoreLabel.Text = "Your Score: " + score;
            loadQuenstions();
        }
        private void buttonAnsw2_Click(object sender, EventArgs e)
        {
            
            answer = "B";
            checkanswer();
            scoreLabel.Text = "Your Score: " + score;
            loadQuenstions();
        }
        private void buttonAnsw3_Click(object sender, EventArgs e)
        {
            
            answer = "C";
            checkanswer();
            scoreLabel.Text = "Your Score: " + score;
            loadQuenstions();
        }
        private void buttonAnsw4_Click(object sender, EventArgs e)
        {
            
            answer = "D";
            checkanswer();
            scoreLabel.Text = "Your Score: " + score;
            loadQuenstions();
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}
