using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace idkProject
{
    public class DatabaseHandler
    {
        string serverAddress;
        string username;
        string password;
        string databaseName;
        string connectionString;
        MySqlConnection connection;

        public DatabaseHandler()
        {

            serverAddress = "localhost";
            username = "root";
            password = "";
            databaseName = "GameDatabase";
            connectionString = $"Server={serverAddress};Database={databaseName};User={username};Password={password}";
            connection = new MySqlConnection(connectionString);

        }


        public List<game> ReadAll()
        {
            {
                List<game> games = new List<game>();
                try
                {
                    connection.Open();
                    string query = "select * from games";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader read = command.ExecuteReader();
                    while (read.Read())
                    {
                        game oneitem = new game();
                        oneitem.id = read.GetInt32(read.GetOrdinal("id"));
                        oneitem.name = read.GetString(read.GetOrdinal("name"));
                        oneitem.type = read.GetString(read.GetOrdinal("type"));
                        oneitem.price = read.GetInt32(read.GetOrdinal("price"));
                        games.Add(oneitem);

                    }

                    read.Close();
                    command.Dispose();
                    connection.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show("A hiba: " + e.Message);
                }
                return games;
            }
        }

        public void insertOneItem(game onegame)
        {
            try
            {
                connection.Open();
                string query = $"insert into games (id,name, type, price) values ('','{onegame.name}',{onegame.type},{onegame.price})";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }





        }
        public void deleteOneitem(int id)
        {
            try
            {
                connection.Open();
                string query = $"delete from games where id='{id}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

    }



    public class game
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int price { get; set; }
    }


}
