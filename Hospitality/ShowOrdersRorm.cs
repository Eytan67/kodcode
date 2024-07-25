using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitality
{
    public partial class ShowOrdersRorm : Form
    {
        private List<string> categorysList;
        private int idx = 0;
        public ShowOrdersRorm(List<string> categorys)
        {
            InitializeComponent();
            categorysList = categorys;
        }

        private void ShowOrdersRorm_Load(object sender, EventArgs e)
        {
            DisplayOrders(categorysList[idx]);
        }

        private void DisplayOrders(string categoryName)
        {
            LblCategoryName.Text = categorysList[idx];
            DataTable dt = HostHandler.CloneOrdersTable(categoryName);
            DataGVShowOrders.DataSource = dt;
        }

        private void BtnPrv_Click(object sender, EventArgs e)
        {
            idx = (idx - 1 + categorysList.Count) % categorysList.Count;
            DisplayOrders(categorysList[idx]);
        }

        private void BtnNxt_Click(object sender, EventArgs e)
        {
            idx = (idx + 1) % categorysList.Count;
            DisplayOrders(categorysList[idx]);
        }


    }
}
