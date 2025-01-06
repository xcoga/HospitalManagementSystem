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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
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
            diagnsummary = new Panel();
            printBtn = new Button();
            Medicineslbl = new TextBox();
            Symptomslbl = new TextBox();
            Diagnosislbl = new TextBox();
            PatientNamelbl = new TextBox();
            Filler4 = new Label();
            Filler2 = new Label();
            filler3 = new Label();
            Filler = new Label();
            label4 = new Label();
            label3 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            diagnsummary.SuspendLayout();
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
            DiagnosisGV.Location = new Point(51, 394);
            DiagnosisGV.MultiSelect = false;
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.ReadOnly = true;
            DiagnosisGV.RowTemplate.Height = 25;
            DiagnosisGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DiagnosisGV.Size = new Size(1158, 210);
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
            button2.Click += button2_Click;
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
            DiagnosisListTb.Location = new Point(519, 360);
            DiagnosisListTb.Name = "DiagnosisListTb";
            DiagnosisListTb.Size = new Size(210, 31);
            DiagnosisListTb.TabIndex = 18;
            DiagnosisListTb.Text = "Diagnosis List";
            DiagnosisListTb.TextAlign = ContentAlignment.TopCenter;
            // 
            // diagnsummary
            // 
            diagnsummary.Controls.Add(printBtn);
            diagnsummary.Controls.Add(Medicineslbl);
            diagnsummary.Controls.Add(Symptomslbl);
            diagnsummary.Controls.Add(Diagnosislbl);
            diagnsummary.Controls.Add(PatientNamelbl);
            diagnsummary.Controls.Add(Filler4);
            diagnsummary.Controls.Add(Filler2);
            diagnsummary.Controls.Add(filler3);
            diagnsummary.Controls.Add(Filler);
            diagnsummary.Controls.Add(label4);
            diagnsummary.Controls.Add(label3);
            diagnsummary.Location = new Point(530, 106);
            diagnsummary.Name = "diagnsummary";
            diagnsummary.Size = new Size(679, 237);
            diagnsummary.TabIndex = 19;
            // 
            // printBtn
            // 
            printBtn.BackColor = Color.Purple;
            printBtn.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            printBtn.ForeColor = Color.Coral;
            printBtn.Location = new Point(295, 195);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(88, 39);
            printBtn.TabIndex = 20;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = false;
            printBtn.Click += button5_Click;
            // 
            // Medicineslbl
            // 
            Medicineslbl.Location = new Point(389, 149);
            Medicineslbl.Multiline = true;
            Medicineslbl.Name = "Medicineslbl";
            Medicineslbl.Size = new Size(274, 48);
            Medicineslbl.TabIndex = 12;
            // 
            // Symptomslbl
            // 
            Symptomslbl.Location = new Point(60, 149);
            Symptomslbl.Multiline = true;
            Symptomslbl.Name = "Symptomslbl";
            Symptomslbl.Size = new Size(232, 48);
            Symptomslbl.TabIndex = 11;
            // 
            // Diagnosislbl
            // 
            Diagnosislbl.Location = new Point(389, 83);
            Diagnosislbl.Multiline = true;
            Diagnosislbl.Name = "Diagnosislbl";
            Diagnosislbl.Size = new Size(274, 42);
            Diagnosislbl.TabIndex = 10;
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.Location = new Point(60, 83);
            PatientNamelbl.Multiline = true;
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(222, 42);
            PatientNamelbl.TabIndex = 9;
            // 
            // Filler4
            // 
            Filler4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Filler4.AutoSize = true;
            Filler4.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Filler4.ForeColor = Color.Coral;
            Filler4.Location = new Point(389, 128);
            Filler4.Name = "Filler4";
            Filler4.Size = new Size(80, 18);
            Filler4.TabIndex = 8;
            Filler4.Text = "Medicines";
            Filler4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Filler2
            // 
            Filler2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Filler2.AutoSize = true;
            Filler2.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Filler2.ForeColor = Color.Coral;
            Filler2.Location = new Point(389, 62);
            Filler2.Name = "Filler2";
            Filler2.Size = new Size(80, 18);
            Filler2.TabIndex = 7;
            Filler2.Text = "Diagnosis";
            Filler2.TextAlign = ContentAlignment.TopCenter;
            Filler2.Click += label7_Click;
            // 
            // filler3
            // 
            filler3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filler3.AutoSize = true;
            filler3.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filler3.ForeColor = Color.Coral;
            filler3.Location = new Point(60, 128);
            filler3.Name = "filler3";
            filler3.Size = new Size(72, 18);
            filler3.TabIndex = 6;
            filler3.Text = "Symptoms";
            filler3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Filler
            // 
            Filler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Filler.AutoSize = true;
            Filler.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Filler.ForeColor = Color.Coral;
            Filler.Location = new Point(60, 62);
            Filler.Name = "Filler";
            Filler.Size = new Size(96, 18);
            Filler.TabIndex = 5;
            Filler.Text = "PatientName";
            Filler.TextAlign = ContentAlignment.TopCenter;
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
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 626);
            Controls.Add(diagnsummary);
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
            FormClosing += DiagnosisForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            diagnsummary.ResumeLayout(false);
            diagnsummary.PerformLayout();
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
        private Panel diagnsummary;
        private Label label3;
        private Label Filler2;
        private Label filler3;
        private Label Filler;
        private Label label4;
        private Label Filler4;
        private TextBox Medicineslbl;
        private TextBox Symptomslbl;
        private TextBox Diagnosislbl;
        private TextBox PatientNamelbl;
        private Button printBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}