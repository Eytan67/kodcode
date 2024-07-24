using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TimeClock
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection; 
        static string connectionString = "server = DESKTOP-SPE4L58\\SQLSERVER;initial catalog=TimeClock; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static string runSQL(string sql, string[] parameters, string[] values)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(parameters[i], values[i]);
                    }
                    return cmd.ExecuteScalar().ToString();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return "fail to conect!";
        }

        public static void runSQL(string sql, DataTable dt, string id) 
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", id);
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
