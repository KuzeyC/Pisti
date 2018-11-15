using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System;

namespace Pisti
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;
        private int port;
        private string query;
        MySqlCommand command;

        public DBConnect()
        {
            //Testing the database locally.
            server = "localhost";
            database = "leaderboard";
            username = "root";
            password = "";
            port = 3306;
            
            string connectionString = "datasource=" + server + ";database=" + database + ";username=" + username + ";password=" + password;
            connection = new MySqlConnection(connectionString);
        }
        
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public void Insert(string name)
        {
            query = "INSERT INTO scores (name, score, difficulty, timestamp) VALUES('" + name + "', '" + Game.finalScore + "', '" + ConvertDifficulty(Game.difficulty) + "', CURRENT_TIMESTAMP)";
            
            OpenConnection();
            
            command = new MySqlCommand(query, connection);
            
            command.ExecuteNonQuery();
            
            CloseConnection();
        }
        
        public List<string>[] Select()
        {
            query = "SELECT * FROM scores WHERE difficulty = '" + ConvertDifficulty(Game.difficulty) + "' ORDER BY score DESC";
            
            List<string>[] list = new List<string>[4];
            for (int i = 0; i < 4; i++)
            {
                list[i] = new List<string>();
            }
            
            OpenConnection();
            
            command = new MySqlCommand(query, connection);
            
            MySqlDataReader dataReader = command.ExecuteReader();
            
            while (dataReader.Read())
            {
                list[0].Add(dataReader["id"].ToString());
                list[1].Add(dataReader["name"].ToString());
                list[2].Add(dataReader["score"].ToString());
                list[3].Add(dataReader["timestamp"].ToString());
            }
            
            dataReader.Close();
            
            CloseConnection();
            
            return list;
        }
        
        public static string ConvertDifficulty(int difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    return "easy";
                case 2:
                    return "medium";
                case 3:
                    return "hard";
                case 4:
                    return "extreme";
            }
            return "Difficulty Error.";
        }
    }
}
