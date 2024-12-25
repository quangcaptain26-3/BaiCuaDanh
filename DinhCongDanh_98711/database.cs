using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinhCongDanh_98711
{
    class database
    {
        private static string sqlConnection = @"Data Source=LAPTOP-P1S55MPK\SQLEXPRESS;Initial Catalog=DinhBuiCongDanh_98711;Integrated Security=True;";
        private static SqlConnection connection;

        public static DataTable Query(string sql)
        {
            connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
        public static DataTable Query(string sql, Dictionary<string, object> dictionary)
        {
            connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            foreach (string key in dictionary.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, dictionary[key]);
            }
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        public static void Execute(string sql)
        {
            connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Execute(string sql, Dictionary<string, object> dictionary)
        {
            connection = new SqlConnection(sqlConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            foreach (string key in dictionary.Keys)
            {
                command.Parameters.AddWithValue(key, dictionary[key]);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
