using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Consultation.Dashboard
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();

            this.Size = new Size(700, 910);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;

            // for the Date
            guna2DatePicker1.HoverState.FillColor = Color.White;
            guna2DatePicker1.Anchor = AnchorStyles.None;
            guna2DatePicker1.Format = DateTimePickerFormat.Custom;
            guna2DatePicker1.CustomFormat = " ";  // Blank until selection
            guna2DatePicker1.ValueChanged += (s, e) =>
            {
                guna2DatePicker1.Format = DateTimePickerFormat.Custom;
                guna2DatePicker1.CustomFormat = "MM/dd/yy";
            };
            guna2DatePicker1.TextAlign = HorizontalAlignment.Center;

            // for the Time
            guna2TimePicker2.HoverState.FillColor = Color.White;
            guna2TimePicker2.Anchor = AnchorStyles.None;
            guna2TimePicker2.Format = DateTimePickerFormat.Custom;
            guna2TimePicker2.CustomFormat = " ";
            guna2TimePicker2.ValueChanged += (s, e) =>
            {
                guna2TimePicker2.Format = DateTimePickerFormat.Custom;
                guna2TimePicker2.CustomFormat = "hh:mm tt";
            };
            guna2TimePicker2.TextAlign = HorizontalAlignment.Center;



        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
