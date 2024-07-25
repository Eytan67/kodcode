using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;


namespace Hospitality
{
    internal class HostHandler
    {
        private static string _AddPath = "C:\\Users\\user\\source\\repos\\Hospitality\\SQL\\AddCategory.sql";
        private static string _GetCategorysPath = "C:\\Users\\user\\source\\repos\\Hospitality\\SQL\\GetCategorys.sql";
        private static string _GetOrdersPath = "C:\\Users\\user\\source\\repos\\Hospitality\\SQL\\GetOrders.sql";
        private static string _deletePath = "C:\\Users\\user\\source\\repos\\Hospitality\\SQL\\DeleteCategory.sql";
        private static string _searchPath = "C:\\Users\\user\\source\\repos\\Hospitality\\SQL\\SearchCategory.sql";

        public static void AddCategory(string category)
        {
            string scriptSQL = File.ReadAllText(_AddPath);

            string[] parameters = { "@CategoryName" };
            string[] values = { category };
            DBConnection.runSQL(scriptSQL, parameters, values);

        }

        public static void DeleteCategory(string category)
        {
            string scriptSQL = File.ReadAllText(_deletePath);

            string[] parameters = { "@categoryName" };
            string[] values = { category };
            DBConnection.runSQL(scriptSQL, parameters, values);

        }

        public static List<string> SearchCategorys(string str)
        {
            string scriptSQL = File.ReadAllText(_searchPath);

            return DBConnection.RunSQL(scriptSQL, "@str", str);

        }
        
        public static List<string> GetAllCategorys()
        {
            string scriptSQL = File.ReadAllText(_GetCategorysPath);
            return DBConnection.RunSQL(scriptSQL);

        }
        //public static SqlDataReader CloneCategorys()
        //{
        //    string scriptSQL = File.ReadAllText(_GetCategorysPath);
        //    return DBConnection.runSQL(scriptSQL);
        //}

        public static DataTable CloneOrdersTable(string categoryName) 
        {
            string scriptSQL = File.ReadAllText(_GetOrdersPath);

            DataTable dt = new DataTable();
            DBConnection.RunSQL(scriptSQL, dt, "@categoryName", categoryName);
            return dt;            
        }
    }
}
