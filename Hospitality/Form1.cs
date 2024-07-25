using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Form1 : Form
    {
        private List<string> categorysList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCategorys();
        }

        private void BtnEnterCategory_Click(object sender, EventArgs e)
        {
            if (TxtCategoryInpot.Text.Length > 0)
            {
                HostHandler.AddCategory(TxtCategoryInpot.Text);
                TxtCategoryInpot.Text = "";
                DisplayCategorys();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            HostHandler.DeleteCategory(TxtCategoryInpot.Text);
            TxtCategoryInpot.Text = "";
            DisplayCategorys();
        }
        private void BtnShowOrders_Click(object sender, EventArgs e)
        {
            ShowOrdersRorm showOrdersRorm = new ShowOrdersRorm(categorysList);
            showOrdersRorm.ShowDialog();
        }
        private void LstBxCategorys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBxCategorys.SelectedItem != null)
            {
                string selectedName = LstBxCategorys.SelectedItem.ToString();
                TxtCategoryInpot.Text = selectedName;
            }
        }
        private void TxtCategoryInpot_TextChanged(object sender, EventArgs e)
        {
            DisplayCategorys(TxtCategoryInpot.Text);
        }


        private void DisplayCategorys(string str = null)
        {
            if (str == null)
                categorysList = HostHandler.GetAllCategorys();
            else
                categorysList = HostHandler.SearchCategorys(TxtCategoryInpot.Text);

            LstBxCategorys.Items.Clear();
            foreach (string category in categorysList)
            {
                LstBxCategorys.Items.Add(category);
            }

        }
    }
}
