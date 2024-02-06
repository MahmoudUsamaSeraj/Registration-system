namespace Day3
{
    partial class AuthorProfile
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
            label1 = new Label();
            txt_age = new TextBox();
            lbl_age = new Label();
            txt_name = new TextBox();
            lbl_name = new Label();
            lbl_user = new Label();
            txt_user = new TextBox();
            btn_conpass = new Button();
            btn_update = new Button();
            lbl_pass2 = new Label();
            txt_oldpass2 = new TextBox();
            lbl_pass = new Label();
            txt_oldpass1 = new TextBox();
            lbl_newPass = new Label();
            txt_newpass = new TextBox();
            btn_back = new Button();
            cb_showPass = new CheckBox();
            btn_out = new Button();
            cb_newpass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(362, 61);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 9;
            label1.Text = "Author Profile";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_age
            // 
            txt_age.BackColor = Color.FromArgb(230, 231, 233);
            txt_age.BorderStyle = BorderStyle.None;
            txt_age.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(362, 168);
            txt_age.Margin = new Padding(4, 3, 4, 3);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(252, 31);
            txt_age.TabIndex = 13;
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_age.Location = new Point(365, 133);
            lbl_age.Margin = new Padding(4, 0, 4, 0);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(49, 28);
            lbl_age.TabIndex = 11;
            lbl_age.Text = "Age";
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(230, 231, 233);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(86, 168);
            txt_name.Margin = new Padding(4, 3, 4, 3);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(252, 31);
            txt_name.TabIndex = 12;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_name.Location = new Point(86, 133);
            lbl_name.Margin = new Padding(4, 0, 4, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(68, 28);
            lbl_name.TabIndex = 10;
            lbl_name.Text = "Name";
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_user.Location = new Point(646, 133);
            lbl_user.Margin = new Padding(4, 0, 4, 0);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(106, 28);
            lbl_user.TabIndex = 11;
            lbl_user.Text = "Username";
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.FromArgb(230, 231, 233);
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_user.Location = new Point(643, 168);
            txt_user.Margin = new Padding(4, 3, 4, 3);
            txt_user.Multiline = true;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(252, 31);
            txt_user.TabIndex = 13;
            // 
            // btn_conpass
            // 
            btn_conpass.BackColor = Color.FromArgb(116, 86, 174);
            btn_conpass.Cursor = Cursors.Hand;
            btn_conpass.FlatAppearance.BorderSize = 0;
            btn_conpass.FlatStyle = FlatStyle.Flat;
            btn_conpass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_conpass.ForeColor = Color.White;
            btn_conpass.Location = new Point(383, 438);
            btn_conpass.Name = "btn_conpass";
            btn_conpass.Size = new Size(216, 40);
            btn_conpass.TabIndex = 24;
            btn_conpass.Text = "Confirm Password";
            btn_conpass.UseVisualStyleBackColor = false;
            btn_conpass.Click += btn_conpass_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.FromArgb(116, 86, 174);
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(383, 438);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(216, 40);
            btn_update.TabIndex = 24;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // lbl_pass2
            // 
            lbl_pass2.AutoSize = true;
            lbl_pass2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_pass2.Location = new Point(530, 291);
            lbl_pass2.Margin = new Padding(4, 0, 4, 0);
            lbl_pass2.Name = "lbl_pass2";
            lbl_pass2.Size = new Size(182, 28);
            lbl_pass2.TabIndex = 11;
            lbl_pass2.Text = "Confirm Password";
            // 
            // txt_oldpass2
            // 
            txt_oldpass2.BackColor = Color.FromArgb(230, 231, 233);
            txt_oldpass2.BorderStyle = BorderStyle.None;
            txt_oldpass2.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_oldpass2.Location = new Point(526, 326);
            txt_oldpass2.Margin = new Padding(4, 3, 4, 3);
            txt_oldpass2.Multiline = true;
            txt_oldpass2.Name = "txt_oldpass2";
            txt_oldpass2.PasswordChar = '*';
            txt_oldpass2.Size = new Size(252, 31);
            txt_oldpass2.TabIndex = 13;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_pass.Location = new Point(213, 291);
            lbl_pass.Margin = new Padding(4, 0, 4, 0);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(100, 28);
            lbl_pass.TabIndex = 11;
            lbl_pass.Text = "Password";
            // 
            // txt_oldpass1
            // 
            txt_oldpass1.BackColor = Color.FromArgb(230, 231, 233);
            txt_oldpass1.BorderStyle = BorderStyle.None;
            txt_oldpass1.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_oldpass1.Location = new Point(210, 326);
            txt_oldpass1.Margin = new Padding(4, 3, 4, 3);
            txt_oldpass1.Multiline = true;
            txt_oldpass1.Name = "txt_oldpass1";
            txt_oldpass1.PasswordChar = '*';
            txt_oldpass1.Size = new Size(252, 31);
            txt_oldpass1.TabIndex = 13;
            // 
            // lbl_newPass
            // 
            lbl_newPass.AutoSize = true;
            lbl_newPass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            lbl_newPass.Location = new Point(365, 215);
            lbl_newPass.Margin = new Padding(4, 0, 4, 0);
            lbl_newPass.Name = "lbl_newPass";
            lbl_newPass.Size = new Size(149, 28);
            lbl_newPass.TabIndex = 11;
            lbl_newPass.Text = "New Password";
            // 
            // txt_newpass
            // 
            txt_newpass.BackColor = Color.FromArgb(230, 231, 233);
            txt_newpass.BorderStyle = BorderStyle.None;
            txt_newpass.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_newpass.Location = new Point(362, 250);
            txt_newpass.Margin = new Padding(4, 3, 4, 3);
            txt_newpass.Multiline = true;
            txt_newpass.Name = "txt_newpass";
            txt_newpass.PasswordChar = '*';
            txt_newpass.Size = new Size(252, 31);
            txt_newpass.TabIndex = 13;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(116, 86, 174);
            btn_back.Location = new Point(47, 438);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(216, 40);
            btn_back.TabIndex = 25;
            btn_back.Text = "Back To News";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // cb_showPass
            // 
            cb_showPass.AutoSize = true;
            cb_showPass.Cursor = Cursors.Hand;
            cb_showPass.FlatStyle = FlatStyle.Flat;
            cb_showPass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            cb_showPass.Location = new Point(213, 363);
            cb_showPass.Margin = new Padding(5, 3, 5, 3);
            cb_showPass.Name = "cb_showPass";
            cb_showPass.Size = new Size(175, 32);
            cb_showPass.TabIndex = 26;
            cb_showPass.Text = "Show Password";
            cb_showPass.UseVisualStyleBackColor = true;
            cb_showPass.CheckedChanged += cb_showPass_CheckedChanged;
            // 
            // btn_out
            // 
            btn_out.BackColor = Color.White;
            btn_out.Cursor = Cursors.Hand;
            btn_out.FlatStyle = FlatStyle.Flat;
            btn_out.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_out.ForeColor = Color.FromArgb(116, 86, 174);
            btn_out.Location = new Point(733, 438);
            btn_out.Name = "btn_out";
            btn_out.Size = new Size(216, 40);
            btn_out.TabIndex = 25;
            btn_out.Text = "Sign Out";
            btn_out.UseVisualStyleBackColor = false;
            btn_out.Click += btn_out_Click;
            // 
            // cb_newpass
            // 
            cb_newpass.AutoSize = true;
            cb_newpass.Cursor = Cursors.Hand;
            cb_newpass.FlatStyle = FlatStyle.Flat;
            cb_newpass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            cb_newpass.Location = new Point(643, 248);
            cb_newpass.Margin = new Padding(5, 3, 5, 3);
            cb_newpass.Name = "cb_newpass";
            cb_newpass.Size = new Size(175, 32);
            cb_newpass.TabIndex = 26;
            cb_newpass.Text = "Show Password";
            cb_newpass.UseVisualStyleBackColor = true;
            cb_newpass.CheckedChanged += cb_newpass_CheckedChanged;
            // 
            // AuthorProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(cb_newpass);
            Controls.Add(cb_showPass);
            Controls.Add(btn_out);
            Controls.Add(btn_back);
            Controls.Add(btn_update);
            Controls.Add(btn_conpass);
            Controls.Add(txt_newpass);
            Controls.Add(lbl_newPass);
            Controls.Add(txt_oldpass1);
            Controls.Add(lbl_pass);
            Controls.Add(txt_oldpass2);
            Controls.Add(lbl_pass2);
            Controls.Add(txt_user);
            Controls.Add(lbl_user);
            Controls.Add(txt_age);
            Controls.Add(lbl_age);
            Controls.Add(txt_name);
            Controls.Add(lbl_name);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AuthorProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthorProfile";
            Load += AuthorProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_age;
        private Label lbl_age;
        private TextBox txt_name;
        private Label lbl_name;
        private Label lbl_user;
        private TextBox txt_user;
        private Button btn_conpass;
        private Button btn_pass;
        private Button btn_update;
        private Label lbl_pass2;
        private TextBox txt_oldpass2;
        private Label lbl_pass;
        private TextBox txt_oldpass1;
        private Label lbl_newPass;
        private TextBox txt_newpass;
        private Button btn_back;
        private CheckBox cb_showPass;
        private Button btn_out;
        private CheckBox cb_newpass;
    }
}