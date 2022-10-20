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
                MessageBox.Show("Masz błąd dsn");
            }
            connection.Close();
        }
        private void loadQuenstions()
        {
            buttonAnsw1.Show();
            buttonAnsw2.Show();
            buttonAnsw3.Show();
            buttonAnsw4.Show();
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
            scoreLabel.Text = score.ToString();
            loadQuenstions();
        }
        private void buttonAnsw2_Click(object sender, EventArgs e)
        {

            answer = "B";
            checkanswer();
            scoreLabel.Text = score.ToString();
            loadQuenstions();
        }
        private void buttonAnsw3_Click(object sender, EventArgs e)
        {

            answer = "C";
            checkanswer();
            scoreLabel.Text = score.ToString();
            loadQuenstions();
        }
        private void buttonAnsw4_Click(object sender, EventArgs e)
        {

            answer = "D";
            checkanswer();
            scoreLabel.Text = score.ToString();
            loadQuenstions();
        }

        private void halfonhalf_Click(object sender, EventArgs e)
        {
            connection.Open();
            int buttonValue=0,i=0;
            string rightAnswer;
            string[] buttonTextValue = { buttonAnsw1.Text, buttonAnsw2.Text, buttonAnsw3.Text, buttonAnsw4.Text };
            Button[] answerButtons = { buttonAnsw1, buttonAnsw2, buttonAnsw3, buttonAnsw4 };
            string selectquery = "SELECT Right_Answer FROM Questions WHERE id =" + n;
            SqlCommand cmd = new SqlCommand(selectquery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rightAnswer = reader.GetValue(0).ToString();
                for (i = 0; i < answerButtons.Length; i++)
                {
                    if (buttonTextValue[i] != rightAnswer)
                    {
                        answerButtons[i].Hide();
                    }
                }
                switch (rightAnswer)
                { 
                    case "A":
                        buttonValue = 0;
                        break;
                    case "B":
                        buttonValue = 1;
                        break;
                    case "C":
                        buttonValue = 2;
                        break;
                    case "D":
                        buttonValue = 3;
                        break;

                }
                ShowButton(buttonValue);
            }
        }

        void ShowButton(int buttonValue)
        {
            Random random = new Random();
            int drawButton;
            do
            {
                drawButton = random.Next(0,4);
            } while (drawButton == buttonValue);
            switch (drawButton)
            {
                case 0:
                    buttonAnsw1.Show();
                    break;
                case 1:
                    buttonAnsw2.Show();
                    break;
                case 2:
                    buttonAnsw3.Show();
                    break;
                case 3:
                    buttonAnsw4.Show();
                    break;
            }
            connection.Close();
        }

        private void btnOmit_Click(object sender, EventArgs e)
        {
            scoreLabel.Text = (score - 100).ToString();
            loadQuenstions();
        }
    }
}
