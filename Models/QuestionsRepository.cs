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
            &[] Select;
            &[] Update;
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
    }
}