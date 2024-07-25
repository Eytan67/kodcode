using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class form1 : Form
    {
        private Employee[] employees = new Employee[0];
        public form1()
        {
            InitializeComponent();
            CodeField.Text = employees.Length.ToString();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is Panel)
                {
                    foreach (Control r in c.Controls)
                    {
                        if (r is RadioButton)
                        {
                            ((RadioButton)r).Checked = false;
                        }
                    }
                }
            }
            CodeField.Text = employees.Length.ToString();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = CreateNewEmployee();
                IncreaseEmployeeErea();
                employees[employees.Length - 1] = newEmployee;
                Display(newEmployee.Code);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            employees[int.Parse(CodeField.Text)] = null;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CollectFormData(employees[int.Parse(CodeField.Text)]);
        }
        private void BtnNxt_Click(object sender, EventArgs e)
        {
            int nxtIdx = (int.Parse(CodeField.Text) + 1 + employees.Length) % employees.Length;
            Display(nxtIdx);
        }
        private void BtnPrv_Click(object sender, EventArgs e)
        {
            int nxtIdx = (int.Parse(CodeField.Text) - 1 + employees.Length) % employees.Length;
            Display(nxtIdx);
        }
        private void BtnSearchByCode_Click(object sender, EventArgs e)
        {
            SearchPopup searchPopUp = new SearchPopup("plise enter code");
            if (searchPopUp.ShowDialog() == DialogResult.OK)
            {
                SearchBiCode(int.Parse(searchPopUp.Inpot));
            }
        }
        private void BtnSearchById_Click(object sender, EventArgs e)
        {
            SearchPopup searchPopUp = new SearchPopup("plise enter id");
            if (searchPopUp.ShowDialog() == DialogResult.OK)
            {
                SearchById(searchPopUp.Inpot);
            }
        }

        private void IncreaseEmployeeErea()
        {
            Employee[] temp = new Employee[employees.Length + 1];
            for (int i = 0; i < employees.Length; ++i)
            {
                temp[i] = employees[i];
            }
            employees = temp;
        }

        private Employee CreateNewEmployee()
        {
            Employee newEmployee = new Employee();

            newEmployee.Code = employees.Length;
            CollectFormData(newEmployee);
            return newEmployee;
        }

        private void CollectFormData(Employee employee)
        {
            employee.Id = IdField.Text;
            employee.FirstName = FNameField.Text;
            employee.LastName = LNameField.Text;
            employee.Date = DateTime.Parse(DTimeField.Text);
            employee.Street = StreetField.Text;
            employee.Number = int.Parse(NumberField.Text);
            employee.City = CityField.Text;
            employee.IsMale = RdBtnMale.Checked;
            employee.MaritalStatus = PnlMaritalStatus.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            employee.Landline = int.Parse(LandlineField.Text);
            employee.CellPhone = int.Parse(CellPhoneField.Text);
        }

        private void Display(int idx)
        {
            if (idx >= employees.Length || employees[idx] == null)
            {
                MessageBox.Show("Cannot find this employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IdField.Text = employees[idx].Id;
            FNameField.Text = employees[idx].FirstName;
            LNameField.Text = employees[idx].LastName;
            DTimeField.Text = employees[idx].Date.ToString();
            AgeField.Text = employees[idx].Age.ToString();
            StreetField.Text = employees[idx].Street;
            NumberField.Text = employees[idx].Number.ToString();
            CityField.Text = employees[idx].City;
            RdBtnMale.Checked = employees[idx].IsMale;
            PnlMaritalStatus.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == employees[idx].MaritalStatus).Checked = true;
            LandlineField.Text = employees[idx].Landline.ToString();
            CellPhoneField.Text = employees[idx].CellPhone.ToString();
            CodeField.Text = employees[idx].Code.ToString();
        }
        private void Display(Employee employee)
        {
            if (employee == null)
            {
                MessageBox.Show("Cannot find this employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IdField.Text = employee.Id;
            FNameField.Text = employee.FirstName;
            LNameField.Text = employee.LastName;
            DTimeField.Text = employee.Date.ToString();
            AgeField.Text = employee.Age.ToString();
            StreetField.Text = employee.Street;
            NumberField.Text = employee.Number.ToString();
            CityField.Text = employee.City;
            if (employee.IsMale) { RdBtnMale.Checked = true; }else {RdBtnFemale.Checked = true;}
            PnlMaritalStatus.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == employee.MaritalStatus).Checked = true;
            LandlineField.Text = employee.Landline.ToString();
            CellPhoneField.Text = employee.CellPhone.ToString();
            CodeField.Text = employee.Code.ToString();
        }

        private void SearchById(string id)
        {
            Employee res = Array.Find(employees, x => x.Id == id);
            if (res == null)
            {
                Console.WriteLine("no find!");
                return;
            }
            Display(res.Code);
        }

        private void SearchBiCode(int code)
        {
            int Code = 0;
            if (code >= employees.Length || employees[code] == null)
            {
                Console.WriteLine("No find");
                return;
            }
            Display(Code);
        }

    }
}
