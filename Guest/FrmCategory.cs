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

namespace Guest
{
    public partial class FrmCategory : Form
    {
        private List<string> categorysList = new List<string>();
        private int idx;
        private DataTable dtOrders = new DataTable();
        private DataTable dtMyOrders = new DataTable();
        private string guestName;
        public FrmCategory(string name)
        {
            InitializeComponent();
            guestName = name;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            categorysList = GuestHandler.GetCategorys();
            DisplayOrders(categorysList[idx]);
        }

        private void DisplayOrders(string categoryName)
        {
            LblCategoryName.Text = categorysList[idx];

            dtOrders.Clear();
            dtMyOrders.Clear();

            GuestHandler.GetOrders(dtOrders, dtMyOrders, categorysList[idx], guestName);

            DataGVOrders.DataSource = dtOrders;
            DataGVMyOrders.DataSource = dtMyOrders;
        }

        private void BtnNxt_Click(object sender, EventArgs e)
        {
            idx = (idx + 1) % categorysList.Count;
            DisplayOrders(categorysList[idx]);
        }

        private void BtnPrv_Click(object sender, EventArgs e)
        {
            idx = (idx - 1 + categorysList.Count) % categorysList.Count;
            DisplayOrders(categorysList[idx]);
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            GuestHandler.AddOrder(guestName, categorysList[idx], TxtOrderInpot.Text);
            DisplayOrders(categorysList[idx]);
            ShowInpotPlace();
            TxtOrderInpot.Text = "";
        }

        private void BtnAddDish_Click(object sender, EventArgs e)
        {
            ShowInpotPlace();
        }

        private void DataGVOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOrderInpot.Text = DataGVOrders[e.ColumnIndex, e.RowIndex].Value.ToString();
            ShowInpotPlace();
        }
         public void ShowInpotPlace()
        {
            BtnAddOrder.Visible = !(BtnAddOrder.Visible);
            TxtOrderInpot.Visible = !(TxtOrderInpot.Visible);
        }

    }
}
