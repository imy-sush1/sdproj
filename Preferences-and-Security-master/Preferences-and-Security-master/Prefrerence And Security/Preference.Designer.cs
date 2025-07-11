namespace Prefrerence_And_Security
{
    partial class Preference
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
            label2 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 406);
            label2.Name = "label2";
            label2.Size = new Size(303, 152);
            label2.TabIndex = 1;
            label2.Text = "TEST";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 886);
            panel1.TabIndex = 2;
            // 
            // Preference
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 886);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Preference";
            Text = "Preference";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
    }
}