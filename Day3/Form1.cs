using Day3.Models;

namespace Day3
{
    public partial class Form1 : Form
    {
        TaskContext db;
        public Form1()
        {
            InitializeComponent();
            db = new TaskContext();
            txt_username.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (db.Authors.Any(s => s.UserName == txt_username.Text))
            {
                MessageBox.Show("Username Already Taken", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_username.Text == "" || txt_pass.Text == "" || txt_pass.Text != txt_confirm.Text)
                {
                    MessageBox.Show("Register Failed Please Try Again", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_username.Text = txt_pass.Text = txt_confirm.Text = "";
                }
                else if (txt_pass.Text == txt_confirm.Text)
                {
                    Author a = new Author()
                    {
                        UserName = txt_username.Text,
                        Password = txt_pass.Text
                        ,
                        Name = txt_name.Text,
                        Age = int.Parse(txt_age.Text)
                    };
                    db.Add(a);
                    db.SaveChanges();
                    MessageBox.Show("Author Added Succesfuly", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_username.Text = txt_pass.Text = txt_confirm.Text = "";
                    txt_name.Text = txt_age.Text = "";
                    txt_username.Focus();

                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = txt_pass.Text = txt_confirm.Text= txt_name.Text =txt_age.Text= "";
            txt_username.Focus();
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPass.Checked)
            {
                txt_pass.PasswordChar = '\0';
                txt_confirm.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
                txt_confirm.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().ShowDialog();
            this.Close();
        }
    }
}
