using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TxtIdField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (!(TxtIdField.Text.Length > 0) || !(TxtPassowrdField.Text.Length > 0))
            {
                return;
            }
            string res = EmployeeHandler.Login(TxtIdField.Text, TxtFullNameField.Text, TxtPassowrdField.Text);
            MessageBox.Show(res);
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassowrdForm changePassowrdForm = new ChangePassowrdForm();
            if (changePassowrdForm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeClock timeClock = new TimeClock(TxtIdField.Text);
            timeClock.ShowDialog();
        }
    }
}
