using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.forms
{
    public partial class CreateCourceForm : Form
    {
        public CreateCourceForm()
        {
            InitializeComponent();
        }
        private void CreateCourceForm_Load(object sender, EventArgs e)
        {
            Display();
        }
        private void CmbBxChooseTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstBxTopices.Items.Add(CmbBxChooseTopic.SelectedItem.ToString());
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (CheckAllTxtbx())
            {
                SystemHandler.createCorse(TxtNameOfCource.Text
                    , DateTime.Parse(DtpStartDate.Text)
                    , int.Parse(TxtNumOfDays.Text)
                    , int.Parse(TxtNumOfHours.Text)
                    , float.Parse(TxtCoursePrice.Text)
                    );
                List<string> list = new List<string>();
                foreach (var _iterator in LstBxTopices.Items)
                {
                    string item = _iterator.ToString();
                    list.Add(item);
                }
                SystemHandler.AddCourseTopicLinq(TxtNameOfCource.Text, list);

            }
        }

        private bool CheckAllTxtbx()
        {
            return true;

        }

        private void Display()
        {
            List<string> list = new List<string>();

            list = SystemHandler.GetTopics();
            foreach (string s in list)
            {
                CmbBxChooseTopic.Items.Add(s);
            }

        }


    }
}
