namespace Consultation.App.Views
{
    partial class LogInView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInView));
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ForgotPasswordButton = new Button();
            ShowPassButton = new Button();
            ErrorPassLabel = new Label();
            resultlabel1 = new Label();
            label3 = new Label();
            GoogleSignInButton = new Button();
            SignInButton = new Button();
            PasswordTextBoxV2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label2 = new Label();
            SignInTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBoxV2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SignInTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = SystemColors.ControlLight;
            gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Red, Color.Orange);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(2, 2);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(708, 528);
            gradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(425, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 228);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(ForgotPasswordButton);
            panel1.Controls.Add(ShowPassButton);
            panel1.Controls.Add(ErrorPassLabel);
            panel1.Controls.Add(resultlabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(GoogleSignInButton);
            panel1.Controls.Add(SignInButton);
            panel1.Controls.Add(PasswordTextBoxV2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SignInTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 528);
            panel1.TabIndex = 1;
            // 
            // ForgotPasswordButton
            // 
            ForgotPasswordButton.BackColor = Color.Transparent;
            ForgotPasswordButton.FlatAppearance.BorderSize = 0;
            ForgotPasswordButton.FlatStyle = FlatStyle.Flat;
            ForgotPasswordButton.Font = new Font("Inter", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgotPasswordButton.Location = new Point(3, 493);
            ForgotPasswordButton.Name = "ForgotPasswordButton";
            ForgotPasswordButton.Size = new Size(152, 32);
            ForgotPasswordButton.TabIndex = 8;
            ForgotPasswordButton.Text = "Forgot Password?";
            ForgotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // ShowPassButton
            // 
            ShowPassButton.Font = new Font("Inter", 12F);
            ShowPassButton.Image = (Image)resources.GetObject("ShowPassButton.Image");
            ShowPassButton.Location = new Point(314, 269);
            ShowPassButton.Name = "ShowPassButton";
            ShowPassButton.Size = new Size(27, 23);
            ShowPassButton.TabIndex = 10;
            ShowPassButton.UseVisualStyleBackColor = true;
            ShowPassButton.Click += ShowPassButton_Click;
            // 
            // ErrorPassLabel
            // 
            ErrorPassLabel.AutoSize = true;
            ErrorPassLabel.Font = new Font("Inter", 12F);
            ErrorPassLabel.Location = new Point(49, 276);
            ErrorPassLabel.Name = "ErrorPassLabel";
            ErrorPassLabel.Size = new Size(0, 23);
            ErrorPassLabel.TabIndex = 9;
            // 
            // resultlabel1
            // 
            resultlabel1.AutoSize = true;
            resultlabel1.Font = new Font("Inter", 12F);
            resultlabel1.ForeColor = Color.Black;
            resultlabel1.Location = new Point(49, 185);
            resultlabel1.Name = "resultlabel1";
            resultlabel1.Size = new Size(0, 23);
            resultlabel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F);
            label3.Location = new Point(167, 382);
            label3.Name = "label3";
            label3.Size = new Size(28, 23);
            label3.TabIndex = 7;
            label3.Text = "Or";
            // 
            // GoogleSignInButton
            // 
            GoogleSignInButton.BackColor = Color.Brown;
            GoogleSignInButton.FlatStyle = FlatStyle.Flat;
            GoogleSignInButton.Font = new Font("Inter", 12F);
            GoogleSignInButton.ForeColor = Color.White;
            GoogleSignInButton.Location = new Point(83, 415);
            GoogleSignInButton.Name = "GoogleSignInButton";
            GoogleSignInButton.Size = new Size(197, 40);
            GoogleSignInButton.TabIndex = 6;
            GoogleSignInButton.Text = "Sign-In with Google";
            GoogleSignInButton.UseVisualStyleBackColor = false;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Brown;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Inter", 12F);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(83, 328);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(197, 40);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign-In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // PasswordTextBoxV2
            // 
            PasswordTextBoxV2.BeforeTouchSize = new Size(307, 27);
            PasswordTextBoxV2.Font = new Font("Inter", 12F);
            PasswordTextBoxV2.Location = new Point(36, 267);
            PasswordTextBoxV2.Name = "PasswordTextBoxV2";
            PasswordTextBoxV2.PasswordChar = '*';
            PasswordTextBoxV2.Size = new Size(307, 27);
            PasswordTextBoxV2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(36, 232);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // SignInTextBox
            // 
            SignInTextBox.BeforeTouchSize = new Size(307, 27);
            SignInTextBox.Font = new Font("Inter", 12F);
            SignInTextBox.Location = new Point(36, 175);
            SignInTextBox.Name = "SignInTextBox";
            SignInTextBox.Size = new Size(307, 27);
            SignInTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(36, 140);
            label1.Name = "label1";
            label1.Size = new Size(262, 23);
            label1.TabIndex = 1;
            label1.Text = "Sign-In with Umindanao Account:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(295, 95);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 532);
            Controls.Add(panel1);
            Controls.Add(gradientPanel1);
            Name = "LogInView";
            StartPosition = FormStartPosition.CenterScreen;
            Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
            Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            Load += Log_In_Load;
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordTextBoxV2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SignInTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SignInTextBox;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Button GoogleSignInButton;
        private Button SignInButton;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTextBoxV2;
        private Label label2;
        private Label ErrorPassLabel;
        private Label resultlabel1;
        private Button ForgotPasswordButton;
        private Button ShowPassButton;
    }
}