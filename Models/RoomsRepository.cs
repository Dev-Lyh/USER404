using System;
using System.Collections.Generic;
using MySqlConnector;

namespace USER404.Models
{
    public class RoomRepository
    {
        private const string ConnectionData = "Database=user404; Data source=localhost; User Id=root;";

        public void TestandoConexao(){
            MySqlConnection Connection = new MySqlConnection(ConnectionData);
            Connection.Open();
            Console.WriteLine("Banco de dados deu certo... UHULL!!!");
            Connection.Close(); 
        }

        /* CRUD : [V] INSERT - [] SELECT - [] UPDATE - [] DELETE*/

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

    }
} 