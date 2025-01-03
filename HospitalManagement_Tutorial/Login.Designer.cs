namespace HospitalManagement_Tutorial
{
    partial class Login
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
            top_panel = new Panel();
            app_title_text = new Label();
            loginButton = new Button();
            username_input_textbox = new TextBox();
            password_input_textbox = new TextBox();
            username_text = new TextBox();
            password_text = new TextBox();
            clear_button = new Button();
            top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // top_panel
            // 
            top_panel.BackColor = Color.Purple;
            top_panel.BorderStyle = BorderStyle.FixedSingle;
            top_panel.Controls.Add(app_title_text);
            top_panel.Dock = DockStyle.Top;
            top_panel.Location = new Point(0, 0);
            top_panel.Name = "top_panel";
            top_panel.Size = new Size(406, 70);
            top_panel.TabIndex = 0;
            top_panel.Paint += panel1_Paint;
            // 
            // app_title_text
            // 
            app_title_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            app_title_text.AutoSize = true;
            app_title_text.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            app_title_text.ForeColor = Color.Coral;
            app_title_text.Location = new Point(172, 18);
            app_title_text.Name = "app_title_text";
            app_title_text.Size = new Size(66, 35);
            app_title_text.TabIndex = 0;
            app_title_text.Text = "HMS";
            app_title_text.TextAlign = ContentAlignment.TopCenter;
            app_title_text.Click += label1_Click;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.Purple;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.Coral;
            loginButton.Location = new Point(84, 243);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(219, 47);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // username_input_textbox
            // 
            username_input_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            username_input_textbox.Location = new Point(84, 117);
            username_input_textbox.Name = "username_input_textbox";
            username_input_textbox.Size = new Size(228, 27);
            username_input_textbox.TabIndex = 2;
            username_input_textbox.TextChanged += textBox1_TextChanged;
            // 
            // password_input_textbox
            // 
            password_input_textbox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            password_input_textbox.Location = new Point(84, 179);
            password_input_textbox.Name = "password_input_textbox";
            password_input_textbox.Size = new Size(228, 27);
            password_input_textbox.TabIndex = 3;
            // 
            // username_text
            // 
            username_text.BackColor = SystemColors.Control;
            username_text.BorderStyle = BorderStyle.None;
            username_text.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username_text.Location = new Point(84, 95);
            username_text.Name = "username_text";
            username_text.ReadOnly = true;
            username_text.Size = new Size(100, 19);
            username_text.TabIndex = 4;
            username_text.Text = "Username";
            username_text.TextChanged += textBox3_TextChanged;
            // 
            // password_text
            // 
            password_text.BackColor = SystemColors.Control;
            password_text.BorderStyle = BorderStyle.None;
            password_text.Font = new Font("UD Digi Kyokasho N-B", 12F, FontStyle.Bold, GraphicsUnit.Point);
            password_text.Location = new Point(84, 154);
            password_text.Name = "password_text";
            password_text.ReadOnly = true;
            password_text.Size = new Size(100, 19);
            password_text.TabIndex = 5;
            password_text.Text = "Password";
            password_text.TextChanged += textBox1_TextChanged_1;
            // 
            // clear_button
            // 
            clear_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clear_button.BackColor = SystemColors.Control;
            clear_button.Font = new Font("UD Digi Kyokasho N-B", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            clear_button.ForeColor = Color.Purple;
            clear_button.Location = new Point(154, 314);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 37);
            clear_button.TabIndex = 6;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(clear_button);
            Controls.Add(password_text);
            Controls.Add(username_text);
            Controls.Add(password_input_textbox);
            Controls.Add(username_input_textbox);
            Controls.Add(loginButton);
            Controls.Add(top_panel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            top_panel.ResumeLayout(false);
            top_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel top_panel;
        private Label app_title_text;
        private Button loginButton;
        private TextBox username_input_textbox;
        private TextBox password_input_textbox;
        private TextBox username_text;
        private TextBox password_text;
        private Button clear_button;
    }
}