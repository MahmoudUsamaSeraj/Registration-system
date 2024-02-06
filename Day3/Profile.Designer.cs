namespace Day3
{
    partial class Profile
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
            txt_desc = new TextBox();
            label2 = new Label();
            txt_title = new TextBox();
            Username = new Label();
            label3 = new Label();
            txt_bref = new TextBox();
            cb_catalog = new ComboBox();
            label4 = new Label();
            dgv_news = new DataGridView();
            btn_showAll = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            btn_prof = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_news).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(451, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 8;
            label1.Text = "News";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_desc
            // 
            txt_desc.BackColor = Color.FromArgb(230, 231, 233);
            txt_desc.BorderStyle = BorderStyle.None;
            txt_desc.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_desc.Location = new Point(664, 117);
            txt_desc.Margin = new Padding(5, 3, 5, 3);
            txt_desc.Multiline = true;
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(315, 36);
            txt_desc.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label2.Location = new Point(668, 77);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 16;
            label2.Text = "Description";
            // 
            // txt_title
            // 
            txt_title.BackColor = Color.FromArgb(230, 231, 233);
            txt_title.BorderStyle = BorderStyle.None;
            txt_title.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_title.Location = new Point(14, 117);
            txt_title.Margin = new Padding(5, 3, 5, 3);
            txt_title.Multiline = true;
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(315, 36);
            txt_title.TabIndex = 15;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            Username.Location = new Point(14, 76);
            Username.Margin = new Padding(5, 0, 5, 0);
            Username.Name = "Username";
            Username.Size = new Size(55, 28);
            Username.TabIndex = 14;
            Username.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label3.Location = new Point(343, 77);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 16;
            label3.Text = "Bref";
            // 
            // txt_bref
            // 
            txt_bref.BackColor = Color.FromArgb(230, 231, 233);
            txt_bref.BorderStyle = BorderStyle.None;
            txt_bref.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_bref.Location = new Point(339, 117);
            txt_bref.Margin = new Padding(5, 3, 5, 3);
            txt_bref.Multiline = true;
            txt_bref.Name = "txt_bref";
            txt_bref.Size = new Size(315, 36);
            txt_bref.TabIndex = 17;
            // 
            // cb_catalog
            // 
            cb_catalog.BackColor = Color.FromArgb(230, 231, 233);
            cb_catalog.FlatStyle = FlatStyle.Flat;
            cb_catalog.Font = new Font("MS UI Gothic", 16.2F);
            cb_catalog.ForeColor = SystemColors.WindowText;
            cb_catalog.FormattingEnabled = true;
            cb_catalog.Location = new Point(14, 199);
            cb_catalog.Name = "cb_catalog";
            cb_catalog.Size = new Size(315, 35);
            cb_catalog.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 168);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 14;
            label4.Text = "Catalog";
            // 
            // dgv_news
            // 
            dgv_news.BackgroundColor = Color.FromArgb(230, 231, 233);
            dgv_news.BorderStyle = BorderStyle.None;
            dgv_news.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_news.Location = new Point(12, 281);
            dgv_news.Name = "dgv_news";
            dgv_news.RowHeadersWidth = 51;
            dgv_news.Size = new Size(642, 210);
            dgv_news.TabIndex = 19;
            dgv_news.RowHeaderMouseDoubleClick += dgv_news_RowHeaderMouseDoubleClick;
            // 
            // btn_showAll
            // 
            btn_showAll.BackColor = Color.FromArgb(116, 86, 174);
            btn_showAll.Cursor = Cursors.Hand;
            btn_showAll.FlatAppearance.BorderSize = 0;
            btn_showAll.FlatStyle = FlatStyle.Flat;
            btn_showAll.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_showAll.ForeColor = Color.White;
            btn_showAll.Location = new Point(714, 231);
            btn_showAll.Name = "btn_showAll";
            btn_showAll.Size = new Size(216, 40);
            btn_showAll.TabIndex = 21;
            btn_showAll.Text = "Show All News";
            btn_showAll.UseVisualStyleBackColor = false;
            btn_showAll.Click += btn_showAll_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.FromArgb(116, 86, 174);
            btn_delete.Location = new Point(714, 450);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(216, 40);
            btn_delete.TabIndex = 20;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(116, 86, 174);
            btn_add.Cursor = Cursors.Hand;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(714, 304);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(216, 40);
            btn_add.TabIndex = 21;
            btn_add.Text = "Add News";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(116, 86, 174);
            btn_edit.Cursor = Cursors.Hand;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(714, 377);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(216, 40);
            btn_edit.TabIndex = 21;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_prof
            // 
            btn_prof.BackColor = Color.White;
            btn_prof.Cursor = Cursors.Hand;
            btn_prof.FlatStyle = FlatStyle.Flat;
            btn_prof.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_prof.ForeColor = Color.FromArgb(116, 86, 174);
            btn_prof.Location = new Point(772, 12);
            btn_prof.Name = "btn_prof";
            btn_prof.Size = new Size(216, 40);
            btn_prof.TabIndex = 20;
            btn_prof.Text = "Author Profile";
            btn_prof.UseVisualStyleBackColor = false;
            btn_prof.Click += btn_prof_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 518);
            Controls.Add(btn_prof);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(btn_showAll);
            Controls.Add(dgv_news);
            Controls.Add(cb_catalog);
            Controls.Add(txt_bref);
            Controls.Add(label3);
            Controls.Add(txt_desc);
            Controls.Add(label2);
            Controls.Add(txt_title);
            Controls.Add(label4);
            Controls.Add(Username);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_news).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_desc;
        private Label label2;
        private TextBox txt_title;
        private Label Username;
        private Label label3;
        private TextBox txt_bref;
        private ComboBox cb_catalog;
        private Label label4;
        private DataGridView dgv_news;
        private Button btn_showAll;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_prof;
    }
}