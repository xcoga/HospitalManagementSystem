namespace HospitalManagement_Tutorial
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            doctorPicture = new PictureBox();
            patientPicture = new PictureBox();
            diagnosisPicture = new PictureBox();
            doctorLabel = new Label();
            patientLabel = new Label();
            diagnosisLabel = new Label();
            logoutIcon = new PictureBox();
            logoutLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)doctorPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diagnosisPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("UD Digi Kyokasho N-B", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 43);
            label1.Name = "label1";
            label1.Size = new Size(513, 43);
            label1.TabIndex = 0;
            label1.Text = "Hospital Management System";
            // 
            // doctorPicture
            // 
            doctorPicture.BackColor = SystemColors.Control;
            doctorPicture.Image = (Image)resources.GetObject("doctorPicture.Image");
            doctorPicture.Location = new Point(457, 120);
            doctorPicture.Name = "doctorPicture";
            doctorPicture.Size = new Size(100, 86);
            doctorPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            doctorPicture.TabIndex = 1;
            doctorPicture.TabStop = false;
            doctorPicture.Click += doctorPicture_Click;
            // 
            // patientPicture
            // 
            patientPicture.Image = (Image)resources.GetObject("patientPicture.Image");
            patientPicture.Location = new Point(457, 259);
            patientPicture.Name = "patientPicture";
            patientPicture.Size = new Size(100, 80);
            patientPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            patientPicture.TabIndex = 2;
            patientPicture.TabStop = false;
            patientPicture.Click += patientPicture_Click;
            // 
            // diagnosisPicture
            // 
            diagnosisPicture.Image = (Image)resources.GetObject("diagnosisPicture.Image");
            diagnosisPicture.Location = new Point(457, 394);
            diagnosisPicture.Name = "diagnosisPicture";
            diagnosisPicture.Size = new Size(100, 76);
            diagnosisPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            diagnosisPicture.TabIndex = 3;
            diagnosisPicture.TabStop = false;
            diagnosisPicture.Click += diagnosisPicture_Click;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.BackColor = Color.Transparent;
            doctorLabel.Font = new Font("UD Digi Kyokasho N-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            doctorLabel.Location = new Point(595, 147);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(76, 24);
            doctorLabel.TabIndex = 4;
            doctorLabel.Text = "Doctor";
            doctorLabel.Click += doctorLabel_Click;
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.BackColor = Color.Transparent;
            patientLabel.Font = new Font("UD Digi Kyokasho N-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            patientLabel.Location = new Point(595, 290);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(87, 24);
            patientLabel.TabIndex = 5;
            patientLabel.Text = "Patient";
            patientLabel.Click += label2_Click;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.BackColor = Color.Transparent;
            diagnosisLabel.Font = new Font("UD Digi Kyokasho N-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            diagnosisLabel.Location = new Point(595, 422);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new Size(109, 24);
            diagnosisLabel.TabIndex = 6;
            diagnosisLabel.Text = "Diagnosis";
            diagnosisLabel.Click += diagnosisLabel_Click;
            // 
            // logoutIcon
            // 
            logoutIcon.BackColor = Color.SkyBlue;
            logoutIcon.Image = (Image)resources.GetObject("logoutIcon.Image");
            logoutIcon.Location = new Point(958, 483);
            logoutIcon.Name = "logoutIcon";
            logoutIcon.Size = new Size(70, 61);
            logoutIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            logoutIcon.TabIndex = 7;
            logoutIcon.TabStop = false;
            logoutIcon.Click += logoutIcon_Click;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.BackColor = Color.Transparent;
            logoutLabel.Font = new Font("UD Digi Kyokasho N-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            logoutLabel.Location = new Point(958, 556);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(76, 24);
            logoutLabel.TabIndex = 8;
            logoutLabel.Text = "Logout";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1082, 599);
            Controls.Add(logoutLabel);
            Controls.Add(logoutIcon);
            Controls.Add(diagnosisLabel);
            Controls.Add(patientLabel);
            Controls.Add(doctorLabel);
            Controls.Add(diagnosisPicture);
            Controls.Add(patientPicture);
            Controls.Add(doctorPicture);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            FormClosing += Home_FormClosing;
            ((System.ComponentModel.ISupportInitialize)doctorPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)diagnosisPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox doctorPicture;
        private PictureBox patientPicture;
        private PictureBox diagnosisPicture;
        private Label doctorLabel;
        private Label patientLabel;
        private Label diagnosisLabel;
        private PictureBox logoutIcon;
        private Label logoutLabel;
    }
}