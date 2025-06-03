using Consultation.App.Views.IViews;
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

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;

            _mainView.DashboardEvent += DashboardEvent;
            _mainView.ConsultationEvent += ConsultationEvent;
            _mainView.BulletinEvent += BulletinEvent;
            _mainView.SFManagementEvent += SFManagementEvent;
            _mainView.ReportsEvent += ReportsEvent;
            _mainView.PreferenceEvent += PreferenceEvent;
        }
        private void DashboardEvent(object? sender, EventArgs e)
        {

        }
        private void ConsultationEvent(object? sender, EventArgs e)
        {

        }
        private void BulletinEvent(object? sender, EventArgs e)
        {

        }
        private void SFManagementEvent(object? sender, EventArgs e)
        {

        }
        private void ReportsEvent(object? sender, EventArgs e)
        {

        }
        private void PreferenceEvent(object? sender, EventArgs e)
        {

        }
    }
}
