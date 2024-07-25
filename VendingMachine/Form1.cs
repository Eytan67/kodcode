using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
            ClearFields();
            dataGridView2.ClearSelection();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0 && dataGridView2.CurrentRow != null)
            {
                DataGridViewRow selectedRow = dataGridView2.CurrentRow;
                DisplayDetails(selectedRow);
            }
        }

        private void BtnIncrese_Click(object sender, EventArgs e)
        {
            if (!(TxtPrice.Text.Length > 0))
            {
                TxtPrice.Text = "0.5";
            }
            else
            {
                TxtPrice.Text = (float.Parse(TxtPrice.Text) + 0.5).ToString();
            }
        }
        private void BtnDecrese_Click(object sender, EventArgs e)
        {
            if (!(TxtPrice.Text.Length > 0) || float.Parse(TxtPrice.Text) <= 0)
            {
                TxtPrice.Text = "0";
            }
            else
            {
                TxtPrice.Text = (float.Parse(TxtPrice.Text) - 0.5).ToString();
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (AreInputsValid())
            {
                Drink newDrink = new Drink(TxtDrinkName.Text
                    , float.Parse(CmbBxSuger.Text)
                    , float.Parse(CmbBxMilk.Text)
                    , float.Parse(CmbBxCocoa.Text)
                    , float.Parse(CmbBxCoffee.Text)
                    , float.Parse(TxtPrice.Text)
                    );
                Manager.AddNewDrink(newDrink);
                Display();
                ClearFields();
            }

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (AreInputsValid())
            {
                Drink newDrink = new Drink(TxtDrinkName.Text
                    , float.Parse(CmbBxSuger.Text)
                    , float.Parse(CmbBxMilk.Text)
                    , float.Parse(CmbBxCocoa.Text)
                    , float.Parse(CmbBxCoffee.Text)
                    , float.Parse(TxtPrice.Text)
                    );
                string oldName = dataGridView2.SelectedRows[0].Cells["name"].Value.ToString();
                Manager.UpdateDrink(oldName, newDrink);
                Display();
                ClearFields();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string oldName = dataGridView2.SelectedRows[0].Cells["name"].Value.ToString();
            Manager.Delete(oldName);
            Display();
            ClearFields();
        }

        private bool AreInputsValid()
        {
            foreach ( Control c in Controls)
            {
                if(c is TextBox && !(c.Text.Length > 0))
                {
                    return false;
                }
                if(c is ComboBox && ((ComboBox)c).SelectedItem == null)
                {
                    return false;
                }
            }

            return true;
        }
        private bool ClearFields()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedItem = null;
                }
            }

            return true;
        }
        private void Display()
        {
            dataGridView2.DataSource = Manager.GetData();

        }
        private void DisplayDetails(DataGridViewRow selectedRow)
        {
            TxtDrinkName.Text = selectedRow.Cells["name"].Value.ToString();
            TxtPrice.Text = selectedRow.Cells["price"].Value.ToString();
            CmbBxCocoa.Text = selectedRow.Cells["cocoa"].Value.ToString();
            CmbBxCoffee.Text = selectedRow.Cells["coffee"].Value.ToString();
            CmbBxMilk.Text = selectedRow.Cells["milk"].Value.ToString();
            CmbBxSuger.Text = selectedRow.Cells["suger"].Value.ToString();
        }






    }
}
