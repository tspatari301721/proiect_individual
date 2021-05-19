using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Inventariere
{
    class SQL
    {

        string connetionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True";

        //complecteaza datagrid
        public DataTable getData(string command)
        {
            SqlConnection connection = new SqlConnection(connetionString);
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand(command, connection);
            dt.Clear();
            da.Fill(dt);

            connection.Close();
            return dt;
        }

        //verificare utilizator
        public bool checkuser(string text)
        {
            
            string sqlExpression = "SELECT * FROM logins";
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    if (reader[0].ToString().Trim() == text)
                        return true;
                return false;
            }
        }

        //incarca informatia solicitata 
        public List<string> SQL_loadData(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<string> a = new List<string>();
                while (reader.Read())
                    a.Add(reader[0].ToString().Trim());

                connection.Close();
                return a;
            }
        }

        //adauga inregistrare noua
        public void SQLinsert(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();
                new SqlCommand(sqlExpression, connection).ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
