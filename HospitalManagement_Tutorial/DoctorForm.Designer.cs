namespace HospitalManagement_Tutorial
{
    partial class DoctorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            app_title_text = new Label();
            DocID = new TextBox();
            DocName = new TextBox();
            DocPass = new TextBox();
            DocExperience = new TextBox();
            DoctorGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(505, 69);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 2;
            label1.Text = "DOCTOR LIST";
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
            // DocID
            // 
            DocID.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DocID.Location = new Point(104, 148);
            DocID.Name = "DocID";
            DocID.Size = new Size(221, 29);
            DocID.TabIndex = 1;
            DocID.Text = "Doctorid";
            // 
            // DocName
            // 
            DocName.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DocName.Location = new Point(104, 202);
            DocName.Name = "DocName";
            DocName.Size = new Size(221, 29);
            DocName.TabIndex = 2;
            DocName.Text = "Doctor Name";
            // 
            // DocPass
            // 
            DocPass.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DocPass.Location = new Point(104, 310);
            DocPass.Name = "DocPass";
            DocPass.Size = new Size(221, 29);
            DocPass.TabIndex = 3;
            DocPass.Text = "Doctor Password";
            DocPass.TextChanged += textBox3_TextChanged;
            // 
            // DocExperience
            // 
            DocExperience.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DocExperience.Location = new Point(104, 257);
            DocExperience.Name = "DocExperience";
            DocExperience.Size = new Size(221, 29);
            DocExperience.TabIndex = 4;
            DocExperience.Text = "YearsOfExperience";
            // 
            // DoctorGV
            // 
            DoctorGV.AllowUserToAddRows = false;
            DoctorGV.AllowUserToDeleteRows = false;
            DoctorGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dataGridViewCellStyle1.Font = new Font("UD Digi Kyokasho N-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DoctorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DoctorGV.Location = new Point(463, 126);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("UD Digi Kyokasho N-B", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DoctorGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DoctorGV.RowTemplate.Height = 25;
            DoctorGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DoctorGV.Size = new Size(688, 448);
            DoctorGV.TabIndex = 5;
            DoctorGV.CellContentClick += DoctorGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(104, 370);
            button1.Name = "button1";
            button1.Size = new Size(109, 52);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(219, 370);
            button2.Name = "button2";
            button2.Size = new Size(109, 52);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Coral;
            button3.Location = new Point(159, 471);
            button3.Name = "button3";
            button3.Size = new Size(109, 52);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.Font = new Font("UD Digi Kyokasho N-B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Coral;
            button4.Location = new Point(25, 562);
            button4.Name = "button4";
            button4.Size = new Size(109, 52);
            button4.TabIndex = 9;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 626);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocExperience);
            Controls.Add(DocPass);
            Controls.Add(DocName);
            Controls.Add(DocID);
            Controls.Add(panel1);
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label app_title_text;
        private Label label1;
        private TextBox DocID;
        private TextBox DocName;
        private TextBox DocPass;
        private TextBox DocExperience;
        private DataGridView DoctorGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}