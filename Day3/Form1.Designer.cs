namespace Day3
{
    partial class Form1
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
            label1 = new Label();
            Username = new Label();
            txt_username = new TextBox();
            txt_pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_confirm = new TextBox();
            cb_showPass = new CheckBox();
            btn_register = new Button();
            btn_clear = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_name = new TextBox();
            label7 = new Label();
            txt_age = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(53, 53);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 0;
            label1.Text = "Registeration";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            Username.Location = new Point(53, 121);
            Username.Margin = new Padding(4, 0, 4, 0);
            Username.Name = "Username";
            Username.Size = new Size(106, 28);
            Username.TabIndex = 1;
            Username.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(230, 231, 233);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(53, 156);
            txt_username.Margin = new Padding(4, 3, 4, 3);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(252, 31);
            txt_username.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(230, 231, 233);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(50, 226);
            txt_pass.Margin = new Padding(4, 3, 4, 3);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(252, 31);
            txt_pass.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.Location = new Point(53, 191);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 261);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 3;
            label3.Text = "Confirm Password";
            // 
            // txt_confirm
            // 
            txt_confirm.BackColor = Color.FromArgb(230, 231, 233);
            txt_confirm.BorderStyle = BorderStyle.None;
            txt_confirm.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirm.Location = new Point(48, 294);
            txt_confirm.Margin = new Padding(4, 3, 4, 3);
            txt_confirm.Multiline = true;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '*';
            txt_confirm.Size = new Size(252, 31);
            txt_confirm.TabIndex = 3;
            txt_confirm.TextChanged += textBox2_TextChanged;
            // 
            // cb_showPass
            // 
            cb_showPass.AutoSize = true;
            cb_showPass.Cursor = Cursors.Hand;
            cb_showPass.FlatStyle = FlatStyle.Flat;
            cb_showPass.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            cb_showPass.Location = new Point(58, 328);
            cb_showPass.Margin = new Padding(4, 3, 4, 3);
            cb_showPass.Name = "cb_showPass";
            cb_showPass.Size = new Size(175, 32);
            cb_showPass.TabIndex = 4;
            cb_showPass.Text = "Show Password";
            cb_showPass.UseVisualStyleBackColor = true;
            cb_showPass.CheckedChanged += cb_showPass_CheckedChanged;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.FromArgb(116, 86, 174);
            btn_register.Cursor = Cursors.Hand;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.White;
            btn_register.Location = new Point(72, 536);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(216, 40);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.FromArgb(116, 86, 174);
            btn_clear.Location = new Point(72, 600);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(216, 40);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 656);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 7;
            label4.Text = "Already Have Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(114, 86, 174);
            label5.Location = new Point(151, 685);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 9;
            label5.Text = "LOGIN";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label6.Location = new Point(53, 373);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 28);
            label6.TabIndex = 1;
            label6.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(230, 231, 233);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(53, 408);
            txt_name.Margin = new Padding(4, 3, 4, 3);
            txt_name.Multiline = true;
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(252, 31);
            txt_name.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label7.Location = new Point(53, 443);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 28);
            label7.TabIndex = 3;
            label7.Text = "Age";
            // 
            // txt_age
            // 
            txt_age.BackColor = Color.FromArgb(230, 231, 233);
            txt_age.BorderStyle = BorderStyle.None;
            txt_age.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_age.Location = new Point(50, 478);
            txt_age.Margin = new Padding(4, 3, 4, 3);
            txt_age.Multiline = true;
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(252, 31);
            txt_age.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 744);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(cb_showPass);
            Controls.Add(txt_confirm);
            Controls.Add(txt_age);
            Controls.Add(txt_pass);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(label6);
            Controls.Add(txt_username);
            Controls.Add(Username);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Username;
        private TextBox txt_username;
        private TextBox txt_pass;
        private Label label2;
        private Label label3;
        private TextBox txt_confirm;
        private CheckBox cb_showPass;
        private Button btn_register;
        private Button btn_clear;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_name;
        private Label label7;
        private TextBox txt_age;
    }
}
