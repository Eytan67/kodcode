using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
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

        public static void RunSQLAddLecturer(string sql, string lecturerParameter, string lectorer, string salaryParameter, float salary)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(lecturerParameter, lectorer);
                    cmd.Parameters.AddWithValue(salaryParameter, salary);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static void RunSQLAddTopic(string sql, string topicParameter, string topic, string hoursParameter, int hors, string lecturerParameter, string lecturer)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(topicParameter, topic);
                    cmd.Parameters.AddWithValue(hoursParameter, hors);
                    cmd.Parameters.AddWithValue(lecturerParameter, lecturer);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static void RunSQLCreateCourse(string sql
            , string courseNameParameter, string courseName
            , string startDateParameter, DateTime startDate
            , string numOfDaysParameter, int numOfDays
            , string numOfHoursParameter, int numOfHours
            , string coursePriceParameter, float coursePrice)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(courseNameParameter, courseName);
                    cmd.Parameters.AddWithValue(startDateParameter, startDate);
                    cmd.Parameters.AddWithValue(numOfDaysParameter, numOfDays);
                    cmd.Parameters.AddWithValue(numOfHoursParameter, numOfHours);
                    cmd.Parameters.AddWithValue(coursePriceParameter, coursePrice);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        public static List<string> RunSQLGetTopics(string sql)
        {
            if (Connect())
            {
                try
                {
                    List<string> topicsList = new List<string>();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            topicsList.Add(reader["topicName"].ToString());
                        }
                    }
                    return topicsList;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return null;
        }

        public static void RunSQLAddCourseTopicLinq(string sql, string courseNameParameter, string courseName, string topicParameter, string topic)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _sqlConnection;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(courseNameParameter, courseName);
                    cmd.Parameters.AddWithValue(topicParameter, topic);

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
