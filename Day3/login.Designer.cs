namespace Day3
{
    partial class login
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
            btn_clear = new Button();
            bt_login = new Button();
            cb_showPass = new CheckBox();
            txt_pass = new TextBox();
            label2 = new Label();
            txt_username = new TextBox();
            Username = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.FromArgb(116, 86, 174);
            btn_clear.Location = new Point(42, 401);
            btn_clear.Margin = new Padding(4, 3, 4, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(270, 46);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.FromArgb(116, 86, 174);
            bt_login.Cursor = Cursors.Hand;
            bt_login.FlatAppearance.BorderSize = 0;
            bt_login.FlatStyle = FlatStyle.Flat;
            bt_login.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.ForeColor = Color.White;
            bt_login.Location = new Point(42, 329);
            bt_login.Margin = new Padding(4, 3, 4, 3);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(270, 46);
            bt_login.TabIndex = 4;
            bt_login.Text = "LOGIN";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // cb_showPass
            // 
            cb_showPass.AutoSize = true;
            cb_showPass.Cursor = Cursors.Hand;
            cb_showPass.FlatStyle = FlatStyle.Flat;
            cb_showPass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            cb_showPass.Location = new Point(24, 268);
            cb_showPass.Margin = new Padding(5, 3, 5, 3);
            cb_showPass.Name = "cb_showPass";
            cb_showPass.Size = new Size(175, 32);
            cb_showPass.TabIndex = 3;
            cb_showPass.Text = "Show Password";
            cb_showPass.UseVisualStyleBackColor = true;
            cb_showPass.CheckedChanged += cb_showPass_CheckedChanged;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(230, 231, 233);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(14, 227);
            txt_pass.Margin = new Padding(5, 3, 5, 3);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(315, 36);
            txt_pass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.Location = new Point(18, 187);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(16, 147);
            txt_username.Margin = new Padding(5, 3, 5, 3);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(315, 36);
            txt_username.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            Username.Location = new Point(16, 106);
            Username.Margin = new Padding(5, 0, 5, 0);
            Username.Name = "Username";
            Username.Size = new Size(106, 28);
            Username.TabIndex = 8;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(127, 46);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(114, 86, 174);
            label5.Location = new Point(111, 504);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 6;
            label5.Text = "Create Account";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 476);
            label4.Name = "label4";
            label4.Size = new Size(169, 23);
            label4.TabIndex = 18;
            label4.Text = "Don't Have Account";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 562);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_clear);
            Controls.Add(bt_login);
            Controls.Add(cb_showPass);
            Controls.Add(txt_pass);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(Username);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clear;
        private Button bt_login;
        private CheckBox cb_showPass;
        private TextBox txt_pass;
        private Label label2;
        private TextBox txt_username;
        private Label Username;
        private Label label1;
        private Label label5;
        private Label label4;
    }
}