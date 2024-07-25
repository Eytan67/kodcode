using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekTest04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Day newDay = new Day();
            newDay.DayStr = CmbBxDay.Text;
            newDay.DayMonth = CnbBxDayInMonth.Text;
            newDay.Month = CnbBxMonth.Text;
            newDay.Year = CnbBxYear.Text;
            Manager.AddQuery(newDay);
            TxtRes.Text = newDay.Result;
        }
    }
}
