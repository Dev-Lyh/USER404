using System;
using System.Collections.Generic;
using MySqlConnector;

namespace USER404.Models
{
    public class RoomsRepository
    {
        private const string ConnectionData = "Database=user404;Data source=localhost;User Id=root;";

        /*
        ~public void TestandoConexao(){
            ~MySqlConnection Connection = new MySqlConnection(ConnectionData);
            ~Connection.Open();
            ~Console.WriteLine("Banco de dados deu certo... UHULL!!!");
            ~Connection.Close(); 
        ~}
        */

        /*
        ?CRUD : 
            &[V] INSERT - [V] SELECT - [] UPDATE - [] DELETE
        */

        /*  página de home (inserir os dados da sala/ ação de criar sala)*/

        public void insert(Rooms room){

            MySqlConnection Connection = new MySqlConnection(ConnectionData);
            Connection.Open();
            string Query = "INSERT INTO rooms(Pass) VALUES (@Pass)";
            
            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Pass", room.Pass);

            Command.ExecuteNonQuery();

            Connection.Close();
        }

        public List<Rooms> select(Rooms room){

            MySqlConnection Connection = new MySqlConnection(ConnectionData);
            Connection.Open();
            string Query = "SELECT Id FROM rooms";

            MySqlCommand Command = new MySqlCommand(Query, Connection);
            MySqlDataReader Reader = Command.ExecuteReader();

            List<Rooms> Lista = new List<Rooms>();

            while(Reader.Read()){
                
                Rooms roomFind = new Rooms();
                roomFind.Id = Reader.GetInt32("@Id");

                Lista.Add(roomFind);

            };

            Connection.Close();
            return Lista;
        }

        public void update(Rooms room){
            MySqlConnection Connection = new MySqlConnection();
            Connection.Open();

            string Query = "UPDATE rooms SET Pass=@Pass WHERE Id=@Id";

            MySqlCommand Command = new MySqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("Pass", room.Pass);

            Command.ExecuteNonQuery();

            Connection.Close();
        }

    }
} 