namespace HospitalManagement_Tutorial
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            app_title_text = new Label();
            label1 = new Label();
            progressBar = new ProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // app_title_text
            // 
            app_title_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            app_title_text.AutoSize = true;
            app_title_text.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            app_title_text.ForeColor = Color.Coral;
            app_title_text.Location = new Point(215, 52);
            app_title_text.Name = "app_title_text";
            app_title_text.Size = new Size(378, 31);
            app_title_text.TabIndex = 2;
            app_title_text.Text = "HOSPITAL MANAGEMENT SYSTEM";
            app_title_text.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(297, 102);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 3;
            label1.Text = "Version 1.0";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(260, 161);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(248, 56);
            progressBar.TabIndex = 4;
            progressBar.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho N-B", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(325, 272);
            label2.Name = "label2";
            label2.Size = new Size(126, 31);
            label2.TabIndex = 5;
            label2.Text = "by Xcoga";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(label1);
            Controls.Add(app_title_text);
            Name = "SplashForm";
            Text = "SplashForm";
            FormClosing += SplashForm_FormClosing;
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label app_title_text;
        private Label label1;
        private ProgressBar progressBar;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}