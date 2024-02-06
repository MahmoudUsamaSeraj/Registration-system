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
    public partial class login : Form
    {
        TaskContext db;
        public int id;
        public login()
        {
            InitializeComponent();
            db = new TaskContext();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            var author = db.Authors.FirstOrDefault(a => a.UserName == txt_username.Text && a.Password == txt_pass.Text);
            if (author != null)
            {
                MessageBox.Show($"Welcome {author.Name}", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
               id= author.Id;
                this.Hide();
                Profile p = new Profile(id);
                    p.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass.Text = "";
                txt_username.Text = "";
                txt_username.Focus();
            }
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_username.Text = "";
            txt_username.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }
    }
}
