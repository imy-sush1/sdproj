namespace Prefrerence_And_Security
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGeneral = new Button();
            btnLogs = new Button();
            btnBackupAndRestore = new Button();
            btnPermission = new Button();
            btnSecurity = new Button();
            btnPreference = new Button();
            btnNotification = new Button();
            MainPanel = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnGeneral
            // 
            btnGeneral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGeneral.BackColor = Color.Transparent;
            btnGeneral.DialogResult = DialogResult.OK;
            btnGeneral.FlatAppearance.BorderSize = 0;
            btnGeneral.FlatStyle = FlatStyle.Flat;
            btnGeneral.ForeColor = Color.Gray;
            btnGeneral.Location = new Point(66, 123);
            btnGeneral.Margin = new Padding(3, 2, 3, 2);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(143, 22);
            btnGeneral.TabIndex = 7;
            btnGeneral.Text = "General";
            btnGeneral.TextAlign = ContentAlignment.MiddleLeft;
            btnGeneral.UseVisualStyleBackColor = false;
            btnGeneral.Click += btnGeneral_Click;
            // 
            // btnLogs
            // 
            btnLogs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogs.BackColor = Color.Transparent;
            btnLogs.DialogResult = DialogResult.OK;
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.ForeColor = Color.Gray;
            btnLogs.Location = new Point(66, 284);
            btnLogs.Margin = new Padding(3, 2, 3, 2);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(143, 29);
            btnLogs.TabIndex = 6;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.UseVisualStyleBackColor = false;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnBackupAndRestore
            // 
            btnBackupAndRestore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBackupAndRestore.BackColor = Color.Transparent;
            btnBackupAndRestore.DialogResult = DialogResult.OK;
            btnBackupAndRestore.FlatAppearance.BorderSize = 0;
            btnBackupAndRestore.FlatStyle = FlatStyle.Flat;
            btnBackupAndRestore.ForeColor = Color.Gray;
            btnBackupAndRestore.Location = new Point(66, 257);
            btnBackupAndRestore.Margin = new Padding(3, 2, 3, 2);
            btnBackupAndRestore.Name = "btnBackupAndRestore";
            btnBackupAndRestore.Size = new Size(143, 22);
            btnBackupAndRestore.TabIndex = 5;
            btnBackupAndRestore.Text = "Back up and Restore";
            btnBackupAndRestore.TextAlign = ContentAlignment.MiddleLeft;
            btnBackupAndRestore.UseVisualStyleBackColor = false;
            btnBackupAndRestore.Click += btnBackupAndRestore_Click;
            // 
            // btnPermission
            // 
            btnPermission.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPermission.BackColor = Color.Transparent;
            btnPermission.DialogResult = DialogResult.OK;
            btnPermission.FlatAppearance.BorderSize = 0;
            btnPermission.FlatStyle = FlatStyle.Flat;
            btnPermission.ForeColor = Color.Gray;
            btnPermission.Location = new Point(66, 203);
            btnPermission.Margin = new Padding(3, 2, 3, 2);
            btnPermission.Name = "btnPermission";
            btnPermission.Size = new Size(143, 22);
            btnPermission.TabIndex = 3;
            btnPermission.Text = "Permissions";
            btnPermission.TextAlign = ContentAlignment.MiddleLeft;
            btnPermission.UseVisualStyleBackColor = false;
            btnPermission.Click += btnPermission_Cilck;
            // 
            // btnSecurity
            // 
            btnSecurity.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSecurity.BackColor = Color.Transparent;
            btnSecurity.DialogResult = DialogResult.OK;
            btnSecurity.FlatAppearance.BorderSize = 0;
            btnSecurity.FlatStyle = FlatStyle.Flat;
            btnSecurity.ForeColor = Color.Gray;
            btnSecurity.Location = new Point(66, 176);
            btnSecurity.Margin = new Padding(3, 2, 3, 2);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(143, 22);
            btnSecurity.TabIndex = 2;
            btnSecurity.Text = "Security";
            btnSecurity.TextAlign = ContentAlignment.MiddleLeft;
            btnSecurity.UseVisualStyleBackColor = false;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnPreference
            // 
            btnPreference.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPreference.BackColor = Color.Transparent;
            btnPreference.DialogResult = DialogResult.OK;
            btnPreference.FlatAppearance.BorderSize = 0;
            btnPreference.FlatStyle = FlatStyle.Flat;
            btnPreference.ForeColor = Color.Gray;
            btnPreference.Location = new Point(66, 150);
            btnPreference.Margin = new Padding(3, 2, 3, 2);
            btnPreference.Name = "btnPreference";
            btnPreference.Size = new Size(143, 22);
            btnPreference.TabIndex = 1;
            btnPreference.Text = "Preference";
            btnPreference.TextAlign = ContentAlignment.MiddleLeft;
            btnPreference.UseVisualStyleBackColor = false;
            btnPreference.Click += btnPreference_Click;
            // 
            // btnNotification
            // 
            btnNotification.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNotification.BackColor = Color.Transparent;
            btnNotification.DialogResult = DialogResult.OK;
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.ForeColor = Color.Gray;
            btnNotification.Location = new Point(66, 230);
            btnNotification.Margin = new Padding(3, 2, 3, 2);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(143, 22);
            btnNotification.TabIndex = 4;
            btnNotification.Text = "Notifications";
            btnNotification.TextAlign = ContentAlignment.MiddleLeft;
            btnNotification.UseVisualStyleBackColor = false;
            btnNotification.Click += btnNotification_Click;
            // 
            // MainPanel
            // 
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Location = new Point(274, 56);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1071, 700);
            MainPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Location = new Point(39, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 696);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 778);
            Controls.Add(btnGeneral);
            Controls.Add(MainPanel);
            Controls.Add(btnLogs);
            Controls.Add(btnBackupAndRestore);
            Controls.Add(btnPermission);
            Controls.Add(btnNotification);
            Controls.Add(btnSecurity);
            Controls.Add(btnPreference);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogs;
        private Button btnBackupAndRestore;
        private Button btnPermission;
        private Button btnSecurity;
        private Button btnPreference;
        private Button btnNotification;
        private Button btnGeneral;
        private Panel MainPanel;
        private Panel panel1;
    }
}
