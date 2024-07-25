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
    public partial class Form1 : Form
    {
        private List<string> guestsList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayGuests();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (TxtGuestNameInpot.Text.Length > 0)
            {
                if(!guestsList.Contains(TxtGuestNameInpot.Text))
                GuestHandler.AddGuest(TxtGuestNameInpot.Text);
                FrmCategory frmCategory = new FrmCategory(TxtGuestNameInpot.Text);
                frmCategory.ShowDialog();
                this.Close();
            }
        }
        private void LstBxGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBxGuests.SelectedItem != null)
            {
                string selectedName = LstBxGuests.SelectedItem.ToString();
                TxtGuestNameInpot.Text = selectedName;
            }
        }
        private void DisplayGuests()
        {
            SqlDataReader reader = GuestHandler.CloneGuests();
            LstBxGuests.Items.Clear();
            while (reader.Read())
            {
                LstBxGuests.Items.Add(reader["GuestName"].ToString());
                guestsList.Add(reader["GuestName"].ToString());
            }
            TxtGuestNameInpot.Clear();
        }


    }
}
