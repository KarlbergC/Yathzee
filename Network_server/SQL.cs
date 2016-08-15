using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_server
{
    class SQL
    {
        const string CON_STR = "Data Source=(localdb)\\MsSqlLocalDb;Initial Catalog=Yahtzee;Integrated Security=True;Pooling=False";

        public static List<Highscore> LoadHighscores()
        {
            List<Highscore> highscores = new List<Highscore>();
            SqlConnection myConnection = new SqlConnection(CON_STR);
            SqlCommand myCommand = new SqlCommand("select * from Highscore order by Score", myConnection);

            try
            {
                myConnection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string userName = myReader["UserName"].ToString();
                    int highScore = Convert.ToInt32(myReader["Score"]);

                    highscores.Add(new Highscore(userName, highScore));
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                myConnection.Close();
            }

            return highscores;
        }

        public static void AddNewHighscore(string username, int highscore)
        {
            SqlConnection myConnection = new SqlConnection(CON_STR);
            SqlCommand command = new SqlCommand($"insert into Highscore (UserName,Score) values('{username}', '{highscore}')", myConnection);

            try
            {
                myConnection.Open();
                command.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}

