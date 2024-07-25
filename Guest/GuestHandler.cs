using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Guest
{
    internal class GuestHandler
    {
        private static string _AddPath = "C:\\Users\\user\\source\\repos\\Guest\\SQL\\AddGuest.sql";
        private static string _GetGuestsPath = "C:\\Users\\user\\source\\repos\\Guest\\SQL\\GetGuests.sql";
        private static string _GetCategoryPath = "C:\\Users\\user\\source\\repos\\Guest\\SQL\\GetCategorys.sql";
        private static string _GetOrdersPath = "C:\\Users\\user\\source\\repos\\Guest\\SQL\\GetOrders.sql";
        private static string _GetMyOrdersPath = "C:\\Users\\user\\source\\repos\\Guest\\SQL\\GeyMyOrders.sql";
        private static string _addOrder = "C:\\Users\\user\\source\\repos\\Guest\\SQL\\AddOrder.sql";
        public static void AddGuest(string guest)
        {
            string scriptSQL = File.ReadAllText(_AddPath);

            string[] parameters = { "@GuestName" };
            string[] values = { guest };
            DBConnection.runSQL(scriptSQL, parameters, values);
        }
        public static SqlDataReader CloneGuests()
        {
            string scriptSQL = File.ReadAllText(_GetGuestsPath);
            return DBConnection.runSQL(scriptSQL);
        }
        public static List<string> GetCategorys()
        {
            List<string> categories = new List<string>();
            string scriptSQL = File.ReadAllText(_GetCategoryPath);

            SqlDataReader reader = DBConnection.runSQL(scriptSQL);
            while (reader.Read())
            {
                categories.Add(reader["CategoryName"].ToString());
            }
            return categories;
        }
        public static void GetOrders(DataTable dtOrders, DataTable dtMyOrders, string categoryName, string gustName)
        {
            string scriptSQLForAllOrders = File.ReadAllText(_GetOrdersPath);
            string scriptSQLForMyOrders = File.ReadAllText(_GetMyOrdersPath);

            string[] parameters = { "@categoryName", "@GuestName" };
            string[] values = { categoryName, gustName };

            DBConnection.runSQL(scriptSQLForAllOrders, dtOrders, parameters, values);
            DBConnection.runSQL(scriptSQLForMyOrders, dtMyOrders, parameters, values);

        }
        public static void AddOrder(string guestName, string categoryName, string dish)
        {
            string scriptSQL = File.ReadAllText(_addOrder);
            string[] parameters = { "@guestName", "@categoryName", "@foodName" };
            string[] values = { guestName, categoryName, dish };
            DBConnection.runSQL(scriptSQL, parameters, values);
        }
    }

}

//public static void GetOrders(DataTable dtOrders, DataTable dtMyOrders, string gustName, string categoryName)
//{
//    string scriptSQL = File.ReadAllText(_GetOrdersPath);
//    string[] parameters = { "@categoryName" };
//    string[] values = { categoryName };


//    SqlDataReader reader = DBConnection.runSQL(scriptSQL, pa);
//    DataTable selectedDt;
//    for (int i = 0; i < reader.FieldCount; i++)
//    {
//        dtOrders.Columns.Add(reader.GetName(i));
//        dtMyOrders.Columns.Add(reader.GetName(i));
//    }
//    while (reader.Read())
//    {
//        if (reader["GuestName"].ToString() == gustName)
//            selectedDt = dtMyOrders;
//        else
//            selectedDt = dtOrders;

//        DataRow row = selectedDt.NewRow();

//        for (int i = 0; i < reader.FieldCount; i++)
//        {
//            row[i] = reader.GetValue(i);
//        }

//        selectedDt.Rows.Add(row);
//    }
//}
