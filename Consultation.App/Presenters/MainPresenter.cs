using Consultation.App.Views.IViews;
using Consultation.App.Views.TestViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Consultation.App.Views;

namespace Consultation.App.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;

        // Enum to identify each child form
        private enum ChildForms
        {
            Dashboard,
            Bulletin,
            Consultation,
            SFManagement,
            Reports,
            Preference
        }

        // Track currently active form and its type
        private ChildForms _currentForm;
        private Form _activeForm;

        // Store child form instances for reuse
        private readonly Dictionary<ChildForms, Form> _childForms = new();

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;

            // Hook up event handlers
            _mainView.DashboardEvent += DashboardEvent;
            _mainView.BulletinEvent += BulletinEvent;
            _mainView.ConsultationEvent += ConsultationEvent;
            _mainView.SFManagementEvent += SFManagementEvent;
            _mainView.ReportsEvent += ReportsEvent;
            _mainView.PreferenceEvent += PreferenceEvent;

            // Load default child form
            LoadChildForm(ChildForms.Dashboard);
            _currentForm = ChildForms.Dashboard;
        }

        // Event handlers
        private void DashboardEvent(object? sender, EventArgs e)
        {
            if (_currentForm != ChildForms.Dashboard)
            {
                LoadChildForm(ChildForms.Dashboard);
                _currentForm = ChildForms.Dashboard;
            }
        }

        private void BulletinEvent(object? sender, EventArgs e)
        {
            if (_currentForm != ChildForms.Bulletin)
            {
                LoadChildForm(ChildForms.Bulletin);
                _currentForm = ChildForms.Bulletin;
            }
        }

        private void ConsultationEvent(object? sender, EventArgs e)
        {
            _mainView.SetMessage("Consultation Event Triggered");
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

        // Load and display child form
        private void LoadChildForm(ChildForms formType)
        {
            // Hide currently active form
            if (_activeForm != null && !_activeForm.IsDisposed)
            {
                _activeForm.Hide();
            }

            // Create or reuse the child form
            if (!_childForms.TryGetValue(formType, out var form) || form.IsDisposed)
            {
                form = CreateFormByType(formType);
                _childForms[formType] = form;
            }

            // Set MDI properties
            form.MdiParent = (Form)_mainView; // Consider exposing MdiParentForm from IMainView
            form.Dock = DockStyle.Fill;
            form.ShowInTaskbar = false;
            form.BringToFront();
            form.Show();

            _activeForm = form;
        }

        // Factory method to create forms
        private Form CreateFormByType(ChildForms formType)
        {
            return formType switch
            {
                ChildForms.Dashboard => new DashboardView(),
                ChildForms.Bulletin => new BulletinView(),
                _ => new Form() { Text = "Not Implemented" }
            };
        }
    }
}
