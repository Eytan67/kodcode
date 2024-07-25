using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    internal class DBConnection
    {
        private static SqlConnection _sqlConnection;
        private static string _connectionString = "server = DESKTOP-SPE4L58\\SQLSERVER;initial catalog=CourseSystem; user id=sa; password=1234;TrustServerCertificate=Yes";
        public static bool Connect()
        {
            try
            {
                if (_sqlConnection == null)
                    _sqlConnection = new SqlConnection(_connectionString);
                if (_sqlConnection.State == ConnectionState.Closed)
                    _sqlConnection.Open();
                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }

        }

        public static List<string> RunSQLGetCourses(string sql)
        {
            if (Connect())
            {
                try
                {
                    List<string> coursesList = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coursesList.Add(reader["coursName"].ToString());
                        }
                    }
                    return coursesList;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        public static void RunSQLAddStudent(string sql, string nameParameter, string name)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(nameParameter, name);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static void RunSQLAddCourseStudentLinq(string sql, string nameParameter, string name, string courseNameParameter, string courseName)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(nameParameter, name);
                    cmd.Parameters.AddWithValue(courseNameParameter, courseName);


                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


    }

   
}
