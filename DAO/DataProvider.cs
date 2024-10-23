using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static string connectionString = "server=localhost;port=3306;database=quanlynhathuoc;user=root;password=;";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }

        // trả về dữ liệu DataTable (SELECT * )
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] listParams = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParams)
                        {
                            if (param.Contains("@"))
                            {
                                command.Parameters.AddWithValue(param, parameters[i]);
                                i++;
                            }
                        }
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(data);
                }
                connection.Close();
            }
            return data;
        }

        //INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] listParams = query.Split(' ');
                        int i = 0;
                        foreach (string param in listParams)
                        {
                            if (param.Contains("@"))
                            {
                                command.Parameters.AddWithValue(param, parameters[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return data;
        }

        //dùng cho các lệnh SELECT COUNT(*), MAX, SUM
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParams)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }

}
