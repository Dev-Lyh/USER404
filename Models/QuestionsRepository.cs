using System.Collections.Generic;
using MySqlConnector;

namespace USER404.Models
{
    public class QuestionsRepository
    {
        private const string ConnectionData = "Database=user404;Data source=localhost;User Id=root;";

        /*
        ?CRUD:
            &[V] Insert;
            &[V] Select;
            &[V] Update;
            &[] Delete;
        */

        public void insert(Questions question){
            MySqlConnection Connection = new MySqlConnection();
            Connection.Open();

            string Query = "INSERT INTO questions(Title, Room) VALUES (@Title, @Room)";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("Title", question.Title);
            Command.Parameters.AddWithValue("Room", question.Room);

            Command.ExecuteNonQuery();

            Connection.Close();
        }

        public List<Questions> select(Questions question){
            MySqlConnection Connection = new MySqlConnection();
            Connection.Open();

            string Query = "SELECT Title FROM questions";

            MySqlCommand Command = new MySqlCommand(Query, Connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            List<Questions> Lista = new List<Questions>();
            while(Reader.Read()){

                Questions questionFind = new Questions();

                questionFind.Title = Reader.GetString("@Title");

                Lista.Add(questionFind);

            }

            Connection.Close();
            return Lista;
        }

        public void update(Questions question){
            MySqlConnection Connection = new MySqlConnection();
            Connection.Open();

            string Query = "UPDATE questions SET Title=@Title WHERE Id=@Id";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("Title", question.Title);

            Command.ExecuteNonQuery();
            
            Connection.Close();
        }
    }
}