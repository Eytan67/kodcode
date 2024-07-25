using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitality
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = DESKTOP-SPE4L58\\SQLSERVER;initial catalog=Shabat; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {
                if (sqlConnection == null)
                    sqlConnection = new SqlConnection(connectionString);
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }

        }
        
        public static void runSQL(string sqlScript, string[] parameters, string[] values)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sqlScript;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i], values[i]);
                    }

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }

        //public static SqlDataReader runSQL(string sqlScript)
        //{
        //    if (Connect())
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand();
        //            cmd.Connection = sqlConnection;
        //            cmd.CommandText = sqlScript;
                    
        //            return cmd.ExecuteReader();
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    return null;
        //}
        public static List<string> RunSQL(string sqlScript)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    List<string> categorysList = new List<string>();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sqlScript;
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorysList.Add(reader["CategoryName"].ToString());
                        }
                    }
                    return categorysList;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null ;
        }

        public static List<string> RunSQL(string sqlScript, string parameter, string value)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sqlScript;
                    cmd.Parameters.AddWithValue(parameter, value);
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<string> res = new List<string>();
                    while (reader.Read())
                    {
                        res.Add(reader["CategoryName"].ToString());
                    }

                    reader.Close();
                    return res;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return null ;

        }

        public static void RunSQL(string sql, DataTable dt, string parameter, string categoryName)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(parameter, categoryName);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}
