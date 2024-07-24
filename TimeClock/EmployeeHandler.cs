using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace TimeClock
{
    internal class EmployeeHandler
    {
        private static string _loginPath = "C:\\Users\\user\\source\\repos\\TimeClock\\SQL\\login.sql";
        private static string _changePasswordPath = "C:\\Users\\user\\source\\repos\\TimeClock\\SQL\\changPass.sql";
        private static string _displayTimeClock = "C:\\Users\\user\\source\\repos\\TimeClock\\SQL\\displayTimeClock.sql";

        private static string _loginSQL = File.ReadAllText(_loginPath);
        private static string _changePasswordSQL = File.ReadAllText(_changePasswordPath);
        private static string _displayTimeClockSQL = File.ReadAllText(_displayTimeClock);

        public static string Login(string id, string fullName,string password)
        {
            string[] parameters = { "@id", "@full_name", "@password" };
            string[] values = { id, fullName, password };
            string res = DBConnection.runSQL(_loginSQL, parameters, values);
            return res;
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            if(newPass != confirmPass)
            {
                throw new Exception("validat your passowrd");
            }
            string[] parameters = { "@id", "@oldPass", "@newPass" };
            string[] values = { id, oldPass, newPass };
            string res = DBConnection.runSQL( _changePasswordSQL, parameters, values);
            return res;
        }
        public static DataTable DisplayTimeClok(string id) 
        {
            DataTable dt = new DataTable();
            DBConnection.runSQL(_displayTimeClockSQL, dt, id);

            return dt;
        }
    }
}
