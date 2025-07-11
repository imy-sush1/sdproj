
namespace Prefrerence_And_Security
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }


        

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            loadform(new General());
            btnGeneral.ForeColor = Color.Red;
            btnPermission.ForeColor = Color.Gray;
            btnSecurity.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Gray;
            btnNotification.ForeColor = Color.Gray;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnLogs.ForeColor = Color.Gray;
        }
        private void btnPreference_Click(object sender, EventArgs e)
        {
            loadform(new Preference());
            btnGeneral.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Red;
            btnSecurity.ForeColor = Color.Gray;
            btnPermission.ForeColor = Color.Gray;
            btnNotification.ForeColor = Color.Gray;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnLogs.ForeColor = Color.Gray;
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            btnGeneral.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Gray;
            btnSecurity.ForeColor = Color.Red;
            btnPermission.ForeColor = Color.Gray;
            btnNotification.ForeColor = Color.Gray;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnLogs.ForeColor = Color.Gray;
        }

        private void btnPermission_Cilck(object sender, EventArgs e)
        {
            btnGeneral.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Gray;
            btnSecurity.ForeColor = Color.Gray;
            btnPermission.ForeColor = Color.Red;
            btnNotification.ForeColor = Color.Gray;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnLogs.ForeColor = Color.Gray;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            btnGeneral.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Gray;
            btnSecurity.ForeColor = Color.Gray;
            btnPermission.ForeColor = Color.Gray;
            btnNotification.ForeColor = Color.Red;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnLogs.ForeColor = Color.Gray;
        }

        private void btnBackupAndRestore_Click(object sender, EventArgs e)
        {
            btnGeneral.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Gray;
            btnSecurity.ForeColor = Color.Gray;
            btnPermission.ForeColor = Color.Gray;
            btnNotification.ForeColor = Color.Gray;
            btnBackupAndRestore.ForeColor = Color.Red;
            btnLogs.ForeColor = Color.Gray;
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            btnGeneral.ForeColor = Color.Gray;
            btnPreference.ForeColor = Color.Gray;
            btnSecurity.ForeColor = Color.Gray;
            btnPermission.ForeColor = Color.Gray;
            btnNotification.ForeColor = Color.Gray;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnLogs.ForeColor = Color.Red;
        }
    }
}
