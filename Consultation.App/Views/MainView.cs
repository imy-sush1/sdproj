using Consultation.App.Views.IViews;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultation.App.Views
{
    public partial class MainView : SfForm, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            profilePanel.BackColor = Color.FromArgb(50, 0, 0, 0);
            buttonDashboard.Click += (s, e) => DashboardEvent?.Invoke(s, e);
            buttonConsultation.Click += (s, e) => ConsultationEvent?.Invoke(s, e);
            buttonBulletin.Click += (s, e) => BulletinEvent?.Invoke(s, e);
            buttonSFManagement.Click += (s, e) => SFManagementEvent?.Invoke(s, e);
            buttonReports.Click += (s, e) => ReportsEvent?.Invoke(s, e);
            buttonPreference.Click += (s, e) => PreferenceEvent?.Invoke(s, e);

        }

        public event EventHandler DashboardEvent;
        public event EventHandler ConsultationEvent;
        public event EventHandler BulletinEvent;
        public event EventHandler SFManagementEvent;
        public event EventHandler ReportsEvent;
        public event EventHandler PreferenceEvent;

        public void Header(string header)
        {
            this.Text = header;
        }
        public void SetMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
