namespace Consultation.App.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            label3 = new Label();
            buttonPreference = new Button();
            buttonReports = new Button();
            label2 = new Label();
            buttonSFManagement = new Button();
            buttonConsultation = new Button();
            buttonBulletin = new Button();
            label1 = new Label();
            buttonDashboard = new Button();
            profilePanel = new Panel();
            labelProfileRole = new Label();
            labelProfileName = new Label();
            pictureBoxProfile = new PictureBox();
            pictureBoxLogo = new PictureBox();
            label4 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)sidePanel).BeginInit();
            sidePanel.SuspendLayout();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ActiveCaption;
            sidePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.FromArgb(117, 7, 39), Color.FromArgb(197, 62, 63));
            sidePanel.Border3DStyle = Border3DStyle.Flat;
            sidePanel.BorderStyle = BorderStyle.None;
            sidePanel.Controls.Add(label3);
            sidePanel.Controls.Add(buttonPreference);
            sidePanel.Controls.Add(buttonReports);
            sidePanel.Controls.Add(label2);
            sidePanel.Controls.Add(buttonSFManagement);
            sidePanel.Controls.Add(buttonConsultation);
            sidePanel.Controls.Add(buttonBulletin);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(buttonDashboard);
            sidePanel.Controls.Add(profilePanel);
            sidePanel.Controls.Add(pictureBoxLogo);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.ControlText;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(260, 1041);
            sidePanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(24, 600);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 11;
            label3.Text = "Settings";
            // 
            // buttonPreference
            // 
            buttonPreference.BackColor = Color.Transparent;
            buttonPreference.FlatAppearance.BorderSize = 0;
            buttonPreference.FlatStyle = FlatStyle.Flat;
            buttonPreference.Font = new Font("Inter", 11.25F);
            buttonPreference.ForeColor = SystemColors.ControlLightLight;
            buttonPreference.Image = Properties.Icons.lsicon__setting_outline;
            buttonPreference.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPreference.Location = new Point(30, 640);
            buttonPreference.Name = "buttonPreference";
            buttonPreference.Size = new Size(228, 56);
            buttonPreference.TabIndex = 10;
            buttonPreference.Text = "Preference and Security";
            buttonPreference.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPreference.UseVisualStyleBackColor = false;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.Transparent;
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Inter", 11.25F);
            buttonReports.ForeColor = SystemColors.ControlLightLight;
            buttonReports.Image = Properties.Icons.streamline__graph_bar_increase;
            buttonReports.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReports.Location = new Point(30, 512);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(228, 42);
            buttonReports.TabIndex = 9;
            buttonReports.Text = "Reports";
            buttonReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReports.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(24, 424);
            label2.Name = "label2";
            label2.Size = new Size(134, 27);
            label2.TabIndex = 7;
            label2.Text = "Management";
            // 
            // buttonSFManagement
            // 
            buttonSFManagement.BackColor = Color.Transparent;
            buttonSFManagement.FlatAppearance.BorderSize = 0;
            buttonSFManagement.FlatStyle = FlatStyle.Flat;
            buttonSFManagement.Font = new Font("Inter", 11.25F);
            buttonSFManagement.ForeColor = SystemColors.ControlLightLight;
            buttonSFManagement.Image = Properties.Icons.material_symbols__groups_2;
            buttonSFManagement.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSFManagement.Location = new Point(30, 464);
            buttonSFManagement.Name = "buttonSFManagement";
            buttonSFManagement.Size = new Size(228, 48);
            buttonSFManagement.TabIndex = 6;
            buttonSFManagement.Text = "Students and Faculty";
            buttonSFManagement.TextAlign = ContentAlignment.MiddleLeft;
            buttonSFManagement.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSFManagement.UseVisualStyleBackColor = false;
            // 
            // buttonConsultation
            // 
            buttonConsultation.BackColor = Color.Transparent;
            buttonConsultation.FlatAppearance.BorderSize = 0;
            buttonConsultation.FlatStyle = FlatStyle.Flat;
            buttonConsultation.Font = new Font("Inter", 11.25F);
            buttonConsultation.ForeColor = SystemColors.ControlLightLight;
            buttonConsultation.Image = Properties.Icons.material_symbols__chat_bubble_outline;
            buttonConsultation.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultation.Location = new Point(30, 328);
            buttonConsultation.Name = "buttonConsultation";
            buttonConsultation.Size = new Size(228, 48);
            buttonConsultation.TabIndex = 5;
            buttonConsultation.Text = "Consulation";
            buttonConsultation.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultation.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsultation.UseVisualStyleBackColor = false;
            // 
            // buttonBulletin
            // 
            buttonBulletin.BackColor = Color.Transparent;
            buttonBulletin.FlatAppearance.BorderSize = 0;
            buttonBulletin.FlatStyle = FlatStyle.Flat;
            buttonBulletin.Font = new Font("Inter", 11.25F);
            buttonBulletin.ForeColor = SystemColors.ControlLightLight;
            buttonBulletin.Image = Properties.Icons.material_symbols__format_list_bulleted;
            buttonBulletin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBulletin.Location = new Point(30, 280);
            buttonBulletin.Name = "buttonBulletin";
            buttonBulletin.Size = new Size(228, 42);
            buttonBulletin.TabIndex = 4;
            buttonBulletin.Text = "Bulletin";
            buttonBulletin.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBulletin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Inter", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(24, 192);
            label1.Name = "label1";
            label1.Size = new Size(58, 27);
            label1.TabIndex = 3;
            label1.Text = "Main";
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Transparent;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Inter", 11.25F);
            buttonDashboard.ForeColor = SystemColors.ControlLightLight;
            buttonDashboard.Image = Properties.Icons.material_symbols__dashboard_outline;
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(30, 232);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(228, 42);
            buttonDashboard.TabIndex = 2;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = false;
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(labelProfileRole);
            profilePanel.Controls.Add(labelProfileName);
            profilePanel.Controls.Add(pictureBoxProfile);
            profilePanel.Dock = DockStyle.Bottom;
            profilePanel.Location = new Point(0, 946);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(260, 95);
            profilePanel.TabIndex = 1;
            // 
            // labelProfileRole
            // 
            labelProfileRole.AutoSize = true;
            labelProfileRole.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProfileRole.Location = new Point(88, 48);
            labelProfileRole.Name = "labelProfileRole";
            labelProfileRole.Size = new Size(42, 22);
            labelProfileRole.TabIndex = 2;
            labelProfileRole.Text = "Role";
            // 
            // labelProfileName
            // 
            labelProfileName.AutoSize = true;
            labelProfileName.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProfileName.Location = new Point(88, 24);
            labelProfileName.Name = "labelProfileName";
            labelProfileName.Size = new Size(93, 22);
            labelProfileName.TabIndex = 1;
            labelProfileName.Text = "John Name";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackColor = Color.White;
            pictureBoxProfile.Location = new Point(16, 24);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(56, 56);
            pictureBoxProfile.TabIndex = 0;
            pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = Properties.Icons.LOGO_name__Custom___1_;
            pictureBoxLogo.Location = new Point(8, 40);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(248, 96);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Inter", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 29);
            label4.Name = "label4";
            label4.Size = new Size(200, 45);
            label4.TabIndex = 12;
            label4.Text = "Form Name";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label4);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(260, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1644, 100);
            materialCard1.TabIndex = 3;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(materialCard1);
            Controls.Add(sidePanel);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "MainView";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidePanel).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.GradientPanel sidePanel;
        private Panel profilePanel;
        private PictureBox pictureBoxLogo;
        private Button buttonDashboard;
        private Label label1;
        private Button buttonConsultation;
        private Button buttonBulletin;
        private Label label3;
        private Button buttonPreference;
        private Button buttonReports;
        private Label label2;
        private Button buttonSFManagement;
        private Label labelProfileRole;
        private Label labelProfileName;
        private PictureBox pictureBoxProfile;
        private Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}