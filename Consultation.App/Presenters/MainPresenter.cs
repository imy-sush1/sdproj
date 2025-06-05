using Consultation.App.Views.IViews;
using Consultation.App.Views.TestViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.App.Presenters
{
    public class MainPresenter
    {
        private IMainView _mainView;
        private enum Forms
        {
            Dashboard,
            Consultation,
            Bulletin,
            SFManagement,
            Reports,
            Preference
        }
        private Forms _currentForm;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;

            _mainView.DashboardEvent += DashboardEvent;
            _mainView.ConsultationEvent += ConsultationEvent;
            _mainView.BulletinEvent += BulletinEvent;
            _mainView.SFManagementEvent += SFManagementEvent;
            _mainView.ReportsEvent += ReportsEvent;
            _mainView.PreferenceEvent += PreferenceEvent;

            LoadChildForm(new DashboardView());
            _currentForm = Forms.Dashboard;
        }
        private void DashboardEvent(object? sender, EventArgs e)
        {
            if(!(_currentForm.Equals(Forms.Dashboard)))
            {
                DashboardView dashboardView = new DashboardView();
                LoadChildForm(dashboardView);
                _currentForm = Forms.Dashboard;
            }
    
        }
        private void ConsultationEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Consultation Event Triggered");
        }
        private void BulletinEvent(object? sender, EventArgs e)
        {
            if (!(_currentForm.Equals(Forms.Bulletin)))
            {
                BulletinView bulletinView = new BulletinView();
                LoadChildForm(bulletinView);
                _currentForm = Forms.Bulletin;
            }
                
           // _mainView.SetMessage("Bulletin Event Triggered");
        }
        private void SFManagementEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("SF Management Event Triggered");
        }
        private void ReportsEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Reports Event Triggered");
        }
        private void PreferenceEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Preference Event Triggered");
        }

        public void LoadChildForm(Form childForm)
        {
            childForm.MdiParent = (Form)_mainView;
            childForm.Dock = DockStyle.Fill;
            //childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowInTaskbar = false;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
