using Consultation.App.Views.Controls.ConsultationManagement;
using Guna.UI2.WinForms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using System;
using System.Windows.Forms;

namespace Consultation.App.ConsultationManagement
{
    public partial class EditSchedule : Form
    {

        private ConsultationCard cardToEdit;
        public EditSchedule(ConsultationCard cardToEdit)
        {
            InitializeComponent();

            this.cardToEdit = cardToEdit;

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cardToEdit.Data = new ConsultationData
            {
                Name = StudentName.Text,
                IDNumber = Idnumber.Text,
                CourseCode = CourseCode.Text,
                Location = Location.Text,
                Faculty = Faculty.Text,
                Time = TextBoxtime.Text,
                Notes = Notes.Text,
                Date = Date.Text,

            };

            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelHours_Click(object sender, EventArgs e)
        {
            int hours = int.Parse(LabelHours.Text);
            hours = hours % 12 + 1;
            LabelHours.Text = hours.ToString("");

        }

        private void LabelMinutes_MouseClick(object sender, MouseEventArgs e)
        {
            int minutes = int.Parse(LabelMinutes.Text);
            int tens = minutes / 10;
            int ones = minutes % 10;

            if (e.X < LabelMinutes.Width / 2)
                minutes = (minutes + 10) % 60;
            else
                minutes = (minutes + 1) % 60;

            LabelMinutes.Text = minutes.ToString("00");

        }

        private void LabelAMPM_Click(object sender, EventArgs e)
        {
            LabelAMPM.Text = LabelAMPM.Text == "AM" ? "PM" : "AM";

        }

        private void UpdateTime()
        {
            TextBoxtime.Text = LabelHours.Text + " : " + LabelMinutes.Text + " " + LabelAMPM.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateTime();
            Paneltime.Visible = false;
        }

        private void TextBoxtime_Click(object sender, EventArgs e)
        {
            Paneltime.Left = TextBoxtime.Left + (TextBoxtime.Width - Paneltime.Width) / 2;
            Paneltime.Top = TextBoxtime.Bottom;
            Paneltime.Visible = true;
            LabelMinutes.Focus();
        }

    }
}