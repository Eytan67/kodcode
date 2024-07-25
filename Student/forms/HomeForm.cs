using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void CmbBxCources_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstBxCources.Items.Add(CmbBxCources.SelectedItem.ToString());

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (TxtNameField.Text.Length > 0)
            {
                List<string> list = new List<string>();
                foreach (var _iterator in LstBxCources.Items)
                {
                    string item = _iterator.ToString();
                    list.Add(item);
                }
                if(list.Count > 0)
                {
                    StudentHandler.AddCourseStudentLinq(TxtNameField.Text, list);
                }
            }
        }

        private void Display()
        {
            List<string> list = new List<string>();

            list = StudentHandler.GetCourses();
            foreach (string s in list)
            {
                CmbBxCources.Items.Add(s);
            }

        }


    }
}
