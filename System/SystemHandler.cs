using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace System
{
    internal class SystemHandler
    {
        private static string _AddLecturerPath = "C:\\Users\\user\\source\\repos\\System\\SQL\\AddLecturer.sql";
        private static string _AddTopicPath = "C:\\Users\\user\\source\\repos\\System\\SQL\\AddTopic.sql";
        private static string _AddCourseTopicLinq = "C:\\Users\\user\\source\\repos\\System\\SQL\\AddCourseTopicLinq.sql";
        private static string _CreateCoursePath = "C:\\Users\\user\\source\\repos\\System\\SQL\\CreateCourse.sql";
        private static string _GetTopcsPath = "C:\\Users\\user\\source\\repos\\System\\SQL\\GetTopics.sql";

        public static void AddLecturer(string lectorer, float salary)
        {
            string scriptSQL = File.ReadAllText(_AddLecturerPath);

            DBConnection.RunSQLAddLecturer(scriptSQL, "@lectorer", lectorer, "@salary", salary);

        }

        public static void AddTopic(string topic, int hours, string lecturer)
        {
            string scriptSQL = File.ReadAllText(_AddTopicPath);

            DBConnection.RunSQLAddTopic(scriptSQL, "@topic", topic, "@hours", hours, "@lecturer", lecturer);

        }

        public static void createCorse(string courseName
            , DateTime startDate
            , int numOfDays
            , int numOfHours
            , float coursePrice)
        {
            string scriptSQL = File.ReadAllText(_CreateCoursePath);

            DBConnection.RunSQLCreateCourse(scriptSQL
                , "@courseName", courseName
                , "@startDate", startDate
                , "@numOfDays", numOfDays
                , "@numOfHours", numOfHours
                , "@coursePrice", coursePrice
                );

        }

        public static List<string> GetTopics()
        {
            string scriptSQL = File.ReadAllText(_GetTopcsPath);

            return DBConnection.RunSQLGetTopics(scriptSQL);
        }

        public static void AddCourseTopicLinq(string courseName, List<string> topics)
        {
            string scriptSQL = File.ReadAllText(_AddCourseTopicLinq);

            foreach (string topic in topics)
            {
                DBConnection.RunSQLAddCourseTopicLinq(scriptSQL, "@courseName", courseName, "@topic", topic);
            }
        }

    }

}
