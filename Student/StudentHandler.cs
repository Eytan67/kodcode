using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student
{
    internal class StudentHandler
    {
        private static string _GetCources = "C:\\Users\\user\\source\\repos\\Student\\SQL\\GetCources.sql";
        private static string _AddStudent = "C:\\Users\\user\\source\\repos\\Student\\SQL\\AddStudent.sql";
        private static string _AddCourseStudentLinq = "C:\\Users\\user\\source\\repos\\Student\\SQL\\AddCourseStudentLinq.sql";
        private static string _GetDebt = "C:\\Users\\user\\source\\repos\\Student\\SQL\\GetDebt.sql";
        public static List<string> GetCourses()
        {
            string scriptSQL = File.ReadAllText(_GetCources);

            return DBConnection.RunSQLGetCourses(scriptSQL);
        }

        public static void AddCourseStudentLinq(string name, List<string> cources)
        {
            string scriptSQLAddStudent = File.ReadAllText(_AddStudent);
            string scriptSQLAddCourseStudentLinq = File.ReadAllText(_AddCourseStudentLinq);

            DBConnection.RunSQLAddStudent(scriptSQLAddStudent, "@studentName", name);

            foreach (string course in cources)
            {
                DBConnection.RunSQLAddCourseStudentLinq(scriptSQLAddCourseStudentLinq, "@studentName", name, "@coursName", course);
            }
        }

        //public static decimal GetDebt()
        //{
        //    string scriptSQL = File.ReadAllText(_GetDebt);

        //    return DBConnection.RunSqlGetDebt(scriptSQL);
        //}

    }
}
