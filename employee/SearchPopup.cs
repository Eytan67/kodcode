using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee
{
    public partial class SearchPopup : Form
    {
        public SearchPopup(string txt)
        {
            InitializeComponent();
            label1.Text = txt; 
        }
        private string _inpot;
        public string Inpot { get { return _inpot; } set { _inpot = value; } }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Inpot = IdInpot.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
