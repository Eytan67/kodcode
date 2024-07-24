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
    public partial class ChangePassowrdForm : Form
    {
        public ChangePassowrdForm()
        {
            InitializeComponent();
        }

        private void BttnEnter_Click(object sender, EventArgs e)
        {
            try{
                string res =  EmployeeHandler.ChangePassword(TxtIdField.Text, TxtOldPasField.Text, TxtNewPasField.Text, TxtConfirmField.Text);
                MessageBox.Show(res);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            this.Close();
        }
    }
}
