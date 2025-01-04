namespace HospitalManagement_Tutorial
{
    partial class PatientForm
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            patientGV = new DataGridView();
            PatAddress = new TextBox();
            PatPhone = new TextBox();
            PatName = new TextBox();
            PatID = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            app_title_text = new Label();
            PatAge = new TextBox();
            PatGender = new ComboBox();
            PatBlood = new ComboBox();
            PatDisease = new TextBox();
            ((System.ComponentModel.ISupportInitialize)patientGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Coral;
            button4.Location = new Point(25, 568);
            button4.Name = "button4";
            button4.Size = new Size(109, 52);
            button4.TabIndex = 19;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Coral;
            button3.Location = new Point(147, 511);
            button3.Name = "button3";
            button3.Size = new Size(109, 52);
            button3.TabIndex = 18;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(216, 443);
            button2.Name = "button2";
            button2.Size = new Size(109, 52);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(83, 443);
            button1.Name = "button1";
            button1.Size = new Size(109, 52);
            button1.TabIndex = 16;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // patientGV
            // 
            patientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientGV.Location = new Point(463, 132);
            patientGV.Name = "patientGV";
            patientGV.ReadOnly = true;
            patientGV.RowTemplate.Height = 25;
            patientGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            patientGV.Size = new Size(688, 448);
            patientGV.TabIndex = 15;
            patientGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // PatAddress
            // 
            PatAddress.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatAddress.Location = new Point(104, 213);
            PatAddress.Name = "PatAddress";
            PatAddress.Size = new Size(221, 29);
            PatAddress.TabIndex = 14;
            PatAddress.Text = "PatientAddress";
            // 
            // PatPhone
            // 
            PatPhone.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatPhone.Location = new Point(104, 248);
            PatPhone.Name = "PatPhone";
            PatPhone.Size = new Size(221, 29);
            PatPhone.TabIndex = 13;
            PatPhone.Text = "PatientPhone";
            // 
            // PatName
            // 
            PatName.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatName.Location = new Point(104, 178);
            PatName.Name = "PatName";
            PatName.Size = new Size(221, 29);
            PatName.TabIndex = 12;
            PatName.Text = "PatientName";
            // 
            // PatID
            // 
            PatID.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatID.Location = new Point(104, 143);
            PatID.Name = "PatID";
            PatID.Size = new Size(221, 29);
            PatID.TabIndex = 11;
            PatID.Text = "Patientid";
            PatID.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(app_title_text);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 100);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(505, 69);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 2;
            label1.Text = "PATIENT LIST";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // app_title_text
            // 
            app_title_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            app_title_text.AutoSize = true;
            app_title_text.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            app_title_text.ForeColor = Color.Coral;
            app_title_text.Location = new Point(444, 29);
            app_title_text.Name = "app_title_text";
            app_title_text.Size = new Size(378, 31);
            app_title_text.TabIndex = 1;
            app_title_text.Text = "HOSPITAL MANAGEMENT SYSTEM";
            app_title_text.TextAlign = ContentAlignment.TopCenter;
            // 
            // PatAge
            // 
            PatAge.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatAge.Location = new Point(104, 283);
            PatAge.Name = "PatAge";
            PatAge.Size = new Size(221, 29);
            PatAge.TabIndex = 20;
            PatAge.Text = "PatientAge";
            // 
            // PatGender
            // 
            PatGender.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatGender.FormattingEnabled = true;
            PatGender.Items.AddRange(new object[] { "Male", "Female" });
            PatGender.Location = new Point(147, 318);
            PatGender.Name = "PatGender";
            PatGender.Size = new Size(121, 30);
            PatGender.TabIndex = 21;
            PatGender.Text = "Gender";
            // 
            // PatBlood
            // 
            PatBlood.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatBlood.FormattingEnabled = true;
            PatBlood.Items.AddRange(new object[] { "A", "B", "O", "AB" });
            PatBlood.Location = new Point(147, 354);
            PatBlood.Name = "PatBlood";
            PatBlood.Size = new Size(121, 30);
            PatBlood.TabIndex = 22;
            PatBlood.Text = "BloodGroup";
            // 
            // PatDisease
            // 
            PatDisease.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatDisease.Location = new Point(104, 390);
            PatDisease.Name = "PatDisease";
            PatDisease.Size = new Size(221, 29);
            PatDisease.TabIndex = 23;
            PatDisease.Text = "MajorDisease";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 626);
            Controls.Add(PatDisease);
            Controls.Add(PatBlood);
            Controls.Add(PatGender);
            Controls.Add(PatAge);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(patientGV);
            Controls.Add(PatAddress);
            Controls.Add(PatPhone);
            Controls.Add(PatName);
            Controls.Add(PatID);
            Controls.Add(panel1);
            Name = "PatientForm";
            Text = "Form1";
            Load += PatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)patientGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView patientGV;
        private TextBox PatAddress;
        private TextBox PatPhone;
        private TextBox PatName;
        private TextBox PatID;
        private Panel panel1;
        private Label label1;
        private Label app_title_text;
        private TextBox PatAge;
        private ComboBox PatGender;
        private ComboBox PatBlood;
        private TextBox PatDisease;
    }
}