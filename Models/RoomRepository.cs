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
    }
} 