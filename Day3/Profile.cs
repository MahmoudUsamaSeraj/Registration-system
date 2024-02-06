using Day3.Models;
using System.Data;

namespace Day3
{
    public partial class Profile : Form
    {
        TaskContext db;
        int _id;
       
        public Profile(int id)
        {
            InitializeComponent();
            db = new TaskContext();
            _id = id;

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            dgv_news.DataSource = db.News.Where(s => s.AuthorId == _id).Select(s => new
            {
                s.Id,
                s.Title,
                s.Description,
                s.Bref,
                Cat_Name = s.catalog.Name,
                s.AuthorId.Value,
                AuthorName = s.author.Name,
                s.Time,
                s.Date,

            }).ToList();
            cb_catalog.DataSource = db.Catalogs.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            dgv_news.DataSource = db.News.Select(s => new
            {
                s.Id,
                s.Title,
                s.Description,
                s.AuthorId,
                AuthorName = s.author.Name,
                s.Bref,
                Cat_Name = s.catalog.Name,
                s.Time,
                s.Date,
            }).ToList();
            cb_catalog.DataSource = db.Catalogs.ToList();
            cb_catalog.DisplayMember = "Name";
            cb_catalog.ValueMember = "Id";
            btn_delete.Visible = false;
            btn_edit.Visible = false;
        }
        TimeSpan t = DateTime.Now.TimeOfDay;
        private void btn_add_Click(object sender, EventArgs e)
        {
            News n = new News()
            {
                Title = txt_title.Text,
                Description = txt_desc.Text,
                Bref = txt_bref.Text,
                Cat_Id = (int)cb_catalog.SelectedValue,
                AuthorId = _id,
                Date = DateTime.Now,
                Time = new TimeSpan(t.Hours, t.Minutes, t.Seconds),


            };
            db.News.Add(n);
            db.SaveChanges();
            MessageBox.Show("News Added Succesfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_bref.Text = txt_title.Text = txt_desc.Text = "";
            cb_catalog.SelectedItem = -1;

            dgv_news.DataSource = db.News.Where(s => s.AuthorId == _id).Select(s => new
            {
                s.Id,
                s.Title,
                s.Description,
                s.AuthorId,
                AuthorName = s.author.Name,
                s.Bref,
                Cat_Name = s.catalog.Name,
                s.Time,
                s.Date,
            }).ToList();
        }

        int currentId;

        private void dgv_news_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentId = (int)dgv_news.SelectedRows[0].Cells[0].Value;
            News news = db.News.Where(n => n.Id == currentId).SingleOrDefault();
            txt_title.Text = news.Title ?? "";
            txt_bref.Text = news.Bref ?? "";
            txt_desc.Text = news.Description ?? "";
            cb_catalog.SelectedValue = news.Cat_Id ?? -1;

            btn_showAll.Visible = false;
            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_edit.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            News n = db.News.Find(currentId);
            if (n.AuthorId == _id)
            {
                n.Title = txt_title.Text;
                n.Description = txt_desc.Text;
                n.Bref = txt_bref.Text;
                n.Cat_Id = (int)cb_catalog.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("News Updated Succesfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_bref.Text = txt_title.Text = txt_desc.Text = "";
                cb_catalog.SelectedItem = -1;
                dgv_news.DataSource = db.News.Where(s => s.AuthorId == _id).Select(s => new
                {
                    s.Id,
                    s.Title,
                    s.Description,
                    s.AuthorId,
                    AuthorName = s.author.Name,
                    s.Bref,
                    Cat_Name = s.catalog.Name,
                    s.Time,
                    s.Date,
                }).ToList();
                btn_showAll.Visible = true;
                btn_add.Visible = true;
                btn_delete.Visible = false;
                btn_edit.Visible = false;
            }
            else
            {
                MessageBox.Show("You Can't Update Other Author News", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            News n = db.News.Find(currentId);
            if (MessageBox.Show("Are You Sure You Want To Delete News ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (n.AuthorId == _id)
                {
                    db.Remove(n);
                    db.SaveChanges();
                    MessageBox.Show("Newx Deleted Succesfully ", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_bref.Text = txt_title.Text = txt_desc.Text = "";
                    cb_catalog.SelectedItem = -1;
                    dgv_news.DataSource = db.News.Where(s => s.AuthorId == _id).Select(s => new
                    {
                        s.Id,
                        s.Title,
                        s.Description,
                        s.AuthorId,
                        AuthorName = s.author.Name,
                        s.Bref,
                        Cat_Name = s.catalog.Name,
                        s.Time,
                        s.Date,
                    }).ToList();
                    btn_showAll.Visible = true;
                    btn_add.Visible = true;
                    btn_delete.Visible = false;
                    btn_edit.Visible = false;
                }
                else
                {
                    MessageBox.Show("You Can't Delete Other Author News", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_prof_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorProfile a = new AuthorProfile(_id);
            a.ShowDialog();
            this.Close();   

        }
    }
}
