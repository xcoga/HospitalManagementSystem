namespace HospitalManagement_Tutorial
{
    partial class DiagnosisForm
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
            panel1 = new Panel();
            label1 = new Label();
            app_title_text = new Label();
            DiagnosisGV = new DataGridView();
            MedicinesTb = new TextBox();
            DiagnosisTb = new TextBox();
            SymptomsTb = new TextBox();
            PatientNameTb = new TextBox();
            DiagIdTb = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PatientIdTb = new ComboBox();
            DiagnosisListTb = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(505, 69);
            label1.Name = "label1";
            label1.Size = new Size(238, 31);
            label1.TabIndex = 2;
            label1.Text = "DOCTOR DIAGNOSIS";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            // DiagnosisGV
            // 
            DiagnosisGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiagnosisGV.Location = new Point(51, 367);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.ReadOnly = true;
            DiagnosisGV.RowTemplate.Height = 25;
            DiagnosisGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DiagnosisGV.Size = new Size(1158, 237);
            DiagnosisGV.TabIndex = 6;
            DiagnosisGV.CellContentClick += DiagnosisGV_CellContentClick;
            // 
            // MedicinesTb
            // 
            MedicinesTb.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MedicinesTb.Location = new Point(278, 204);
            MedicinesTb.Name = "MedicinesTb";
            MedicinesTb.Size = new Size(221, 29);
            MedicinesTb.TabIndex = 8;
            MedicinesTb.Text = "Medicines";
            // 
            // DiagnosisTb
            // 
            DiagnosisTb.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DiagnosisTb.Location = new Point(278, 169);
            DiagnosisTb.Name = "DiagnosisTb";
            DiagnosisTb.Size = new Size(221, 29);
            DiagnosisTb.TabIndex = 9;
            DiagnosisTb.Text = "Diagnosis";
            // 
            // SymptomsTb
            // 
            SymptomsTb.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SymptomsTb.Location = new Point(278, 133);
            SymptomsTb.Name = "SymptomsTb";
            SymptomsTb.Size = new Size(221, 29);
            SymptomsTb.TabIndex = 10;
            SymptomsTb.Text = "Symptoms";
            // 
            // PatientNameTb
            // 
            PatientNameTb.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatientNameTb.Location = new Point(51, 204);
            PatientNameTb.Name = "PatientNameTb";
            PatientNameTb.Size = new Size(221, 29);
            PatientNameTb.TabIndex = 11;
            PatientNameTb.Text = "PatientName";
            // 
            // DiagIdTb
            // 
            DiagIdTb.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DiagIdTb.Location = new Point(51, 133);
            DiagIdTb.Name = "DiagIdTb";
            DiagIdTb.Size = new Size(221, 29);
            DiagIdTb.TabIndex = 12;
            DiagIdTb.Text = "DiagnosisID";
            DiagIdTb.TextChanged += textBox6_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Coral;
            button4.Location = new Point(189, 309);
            button4.Name = "button4";
            button4.Size = new Size(109, 52);
            button4.TabIndex = 16;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Coral;
            button3.Location = new Point(315, 251);
            button3.Name = "button3";
            button3.Size = new Size(109, 52);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(189, 251);
            button2.Name = "button2";
            button2.Size = new Size(109, 52);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(74, 251);
            button1.Name = "button1";
            button1.Size = new Size(109, 52);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PatientIdTb
            // 
            PatientIdTb.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PatientIdTb.FormattingEnabled = true;
            PatientIdTb.Location = new Point(91, 168);
            PatientIdTb.Name = "PatientIdTb";
            PatientIdTb.Size = new Size(121, 30);
            PatientIdTb.TabIndex = 17;
            PatientIdTb.Text = "PatientID";
            PatientIdTb.SelectedIndexChanged += PatientIdTb_SelectedIndexChanged;
            // 
            // DiagnosisListTb
            // 
            DiagnosisListTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiagnosisListTb.AutoSize = true;
            DiagnosisListTb.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DiagnosisListTb.ForeColor = Color.Coral;
            DiagnosisListTb.Location = new Point(519, 330);
            DiagnosisListTb.Name = "DiagnosisListTb";
            DiagnosisListTb.Size = new Size(210, 31);
            DiagnosisListTb.TabIndex = 18;
            DiagnosisListTb.Text = "Diagnosis List";
            DiagnosisListTb.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(530, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 221);
            panel2.TabIndex = 19;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Coral;
            label8.Location = new Point(389, 128);
            label8.Name = "label8";
            label8.Size = new Size(80, 18);
            label8.TabIndex = 8;
            label8.Text = "Medicines";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(389, 62);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 7;
            label7.Text = "Diagnosis";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(60, 128);
            label6.Name = "label6";
            label6.Size = new Size(72, 18);
            label6.TabIndex = 6;
            label6.Text = "Symptoms";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(60, 62);
            label5.Name = "label5";
            label5.Size = new Size(96, 18);
            label5.TabIndex = 5;
            label5.Text = "PatientName";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(587, 10);
            label4.Name = "label4";
            label4.Size = new Size(40, 18);
            label4.TabIndex = 4;
            label4.Text = "Date";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(201, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 31);
            label3.TabIndex = 3;
            label3.Text = "DIAGNOSIS SUMMARY";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 626);
            Controls.Add(panel2);
            Controls.Add(DiagnosisListTb);
            Controls.Add(PatientIdTb);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DiagIdTb);
            Controls.Add(PatientNameTb);
            Controls.Add(SymptomsTb);
            Controls.Add(DiagnosisTb);
            Controls.Add(MedicinesTb);
            Controls.Add(DiagnosisGV);
            Controls.Add(panel1);
            Name = "DiagnosisForm";
            Text = "DiagnosisForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label app_title_text;
        private DataGridView DiagnosisGV;
        private TextBox MedicinesTb;
        private TextBox DiagnosisTb;
        private TextBox SymptomsTb;
        private TextBox PatientNameTb;
        private TextBox DiagIdTb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox PatientIdTb;
        private Label DiagnosisListTb;
        private Panel panel2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
    }
}