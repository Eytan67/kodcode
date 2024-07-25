using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void BtnAddLecturer_Click(object sender, EventArgs e)
        {
            IsShowLecturerInpotPlace();

        }

        private void BtnEnterLecturer_Click(object sender, EventArgs e)
        {
            if(TxtLecturerName.Text.Length > 0 && TxtLecturerSalary.Text.Length > 0)
            {
                SystemHandler.AddLecturer(TxtLecturerName.Text, float.Parse(TxtLecturerSalary.Text));
                IsShowLecturerInpotPlace();
            }

        }

        public void IsShowLecturerInpotPlace()
        {
            LblLecturerName.Visible = !(LblLecturerName.Visible);
            TxtLecturerName.Visible = !(TxtLecturerName.Visible);

            LblLecturerSalary.Visible = !(LblLecturerSalary.Visible);
            TxtLecturerSalary.Visible = !(TxtLecturerSalary.Visible);

            BtnEnterLecturer.Visible = !(BtnEnterLecturer.Visible);

        }


        private void AddTopic_Click(object sender, EventArgs e)
        {
            IsVisibleTopicInpotPlace();

        }

        private void BtnEnterTopic_Click(object sender, EventArgs e)
        {
            SystemHandler.AddTopic(TxtTopicName.Text, int.Parse(TxtTopicHours.Text), TxtTopicLecturer.Text);
            IsVisibleTopicInpotPlace() ;
        }

        public void IsVisibleTopicInpotPlace()
        {
            LblTopicName.Visible = !(LblTopicName.Visible);
            TxtTopicName.Visible = !(TxtTopicName.Visible);

            LblTopicHours.Visible = !(LblTopicHours.Visible);
            TxtTopicHours.Visible = !(TxtTopicHours.Visible);

            LblTopicLecturer.Visible = !(LblTopicLecturer.Visible);
            TxtTopicLecturer.Visible = !(TxtTopicLecturer.Visible);

            BtnEnterTopic.Visible = !(BtnEnterTopic.Visible);

        }

        private void BtnCreateCource_Click(object sender, EventArgs e)
        {
            CreateCourceForm createCourceForm = new CreateCourceForm();
            createCourceForm.ShowDialog();
        }
    }
}
