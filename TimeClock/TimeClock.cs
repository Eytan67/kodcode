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
    public partial class TimeClock : Form
    {
        public TimeClock(string id)
        {
            InitializeComponent();
            DataTable dataTable = EmployeeHandler.DisplayTimeClok(id);
            timeClockGrid.DataSource = dataTable;
        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DataTable dataTable = EmployeeHandler.DisplayTimeClok(4);
        //    timeClockGrid.DataSource = dataTable;
        //}
    }
}
