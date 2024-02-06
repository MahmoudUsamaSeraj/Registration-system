using Day3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3
{

    public partial class AuthorProfile : Form
    {
        TaskContext db;
        int _id;
        public AuthorProfile(int id)
        {
            InitializeComponent();
            db = new TaskContext();
            _id = id;
        }

        private void AuthorProfile_Load(object sender, EventArgs e)
        {
            lbl_age.Visible = lbl_name.Visible = lbl_newPass.Visible = btn_update.Visible = txt_age.Visible = txt_name.Visible = txt_newpass.Visible = lbl_user.Visible = txt_user.Visible= cb_newpass.Visible = false;

        }

        private void btn_conpass_Click(object sender, EventArgs e)
        {
            if (txt_oldpass1.Text == txt_oldpass2.Text)
            {
                var a = db.Authors.Find(_id);
                if (a.Password == txt_oldpass1.Text)
                {
                    MessageBox.Show("Data Will Appear To Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_age.Visible = lbl_name.Visible = lbl_newPass.Visible = btn_update.Visible = txt_age.Visible = txt_name.Visible = txt_newpass.Visible = lbl_user.Visible = txt_user.Visible= cb_newpass.Visible = true;
                    txt_name.Text = a.Name;
                    txt_age.Text = a.Age.ToString();
                    txt_user.Text = a.UserName;
                    lbl_pass.Visible = lbl_pass2.Visible = btn_conpass.Visible = txt_oldpass1.Visible = txt_oldpass2.Visible = cb_showPass.Visible = false;

                }
                else
                {
                    MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Password Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var a = db.Authors.Find(_id);
            a.UserName = txt_user.Text;
            a.Age = int.Parse(txt_age.Text);
            a.Name = txt_name.Text;
            a.Password = txt_newpass.Text;
            db.SaveChanges();
            txt_newpass.Text = "";
            MessageBox.Show("Data Updated Succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbl_age.Visible = lbl_name.Visible = lbl_newPass.Visible = btn_update.Visible = txt_age.Visible = txt_name.Visible = txt_newpass.Visible = lbl_user.Visible = txt_user.Visible=cb_newpass.Visible = false;
            lbl_pass.Visible = lbl_pass2.Visible = btn_conpass.Visible = txt_oldpass1.Visible = txt_oldpass2.Visible=cb_showPass.Visible = true;
            txt_oldpass1.Text = txt_oldpass2.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Profile(_id).ShowDialog();
            this.Close();
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                txt_oldpass1.PasswordChar = '\0';
                txt_oldpass2.PasswordChar = '\0';
            }
            else
            {
                txt_oldpass1.PasswordChar = '*';
                txt_oldpass2.PasswordChar = '*';
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();
            this.Close();
        }

        private void cb_newpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_newpass.Checked)
            {
                txt_newpass.PasswordChar = '\0';

            }
            else
            {
                txt_newpass.PasswordChar= '*';
            }
        }
    }
}
