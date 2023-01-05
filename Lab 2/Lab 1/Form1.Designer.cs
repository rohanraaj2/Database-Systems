namespace Lab_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sub_category = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstofauthors = new System.Windows.Forms.ListBox();
            this.author_name = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.book_type = new System.Windows.Forms.GroupBox();
            this.journal = new System.Windows.Forms.RadioButton();
            this.txtbook = new System.Windows.Forms.RadioButton();
            this.refbook = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.issue_date_box = new System.Windows.Forms.DateTimePicker();
            this.issuer_name = new System.Windows.Forms.TextBox();
            this.check_issue = new System.Windows.Forms.CheckBox();
            this.issue_date = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.issuer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.book_type.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Purchased On:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sub Category";
            // 
            // sub_category
            // 
            this.sub_category.DisplayMember = "SubCat1";
            this.sub_category.FormattingEnabled = true;
            this.sub_category.Location = new System.Drawing.Point(144, 168);
            this.sub_category.Name = "sub_category";
            this.sub_category.Size = new System.Drawing.Size(286, 28);
            this.sub_category.TabIndex = 7;
            this.sub_category.SelectedIndexChanged += new System.EventHandler(this.sub_category_SelectedIndexChanged);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Database Systems",
            "OOP",
            "Artificial Intelligence"});
            this.category.Location = new System.Drawing.Point(144, 134);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(286, 28);
            this.category.TabIndex = 8;
            this.category.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstofauthors);
            this.groupBox1.Controls.Add(this.author_name);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(32, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 188);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authors";
            // 
            // lstofauthors
            // 
            this.lstofauthors.FormattingEnabled = true;
            this.lstofauthors.ItemHeight = 20;
            this.lstofauthors.Location = new System.Drawing.Point(132, 63);
            this.lstofauthors.Name = "lstofauthors";
            this.lstofauthors.Size = new System.Drawing.Size(151, 104);
            this.lstofauthors.TabIndex = 18;
            this.lstofauthors.SelectedIndexChanged += new System.EventHandler(this.lstofauthors_SelectedIndexChanged);
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(132, 31);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(151, 26);
            this.author_name.TabIndex = 16;
            this.author_name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(303, 31);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(81, 31);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // book_type
            // 
            this.book_type.Controls.Add(this.journal);
            this.book_type.Controls.Add(this.txtbook);
            this.book_type.Controls.Add(this.refbook);
            this.book_type.Location = new System.Drawing.Point(32, 389);
            this.book_type.Name = "book_type";
            this.book_type.Size = new System.Drawing.Size(170, 103);
            this.book_type.TabIndex = 12;
            this.book_type.TabStop = false;
            this.book_type.Text = "Type";
            this.book_type.Enter += new System.EventHandler(this.book_type_Enter);
            // 
            // journal
            // 
            this.journal.AutoSize = true;
            this.journal.Location = new System.Drawing.Point(10, 78);
            this.journal.Name = "journal";
            this.journal.Size = new System.Drawing.Size(86, 24);
            this.journal.TabIndex = 2;
            this.journal.TabStop = true;
            this.journal.Text = "Journal";
            this.journal.UseVisualStyleBackColor = true;
            this.journal.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtbook
            // 
            this.txtbook.AutoSize = true;
            this.txtbook.Location = new System.Drawing.Point(10, 51);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(105, 24);
            this.txtbook.TabIndex = 1;
            this.txtbook.TabStop = true;
            this.txtbook.Text = "Text Book";
            this.txtbook.UseVisualStyleBackColor = true;
            this.txtbook.CheckedChanged += new System.EventHandler(this.txtbook_CheckedChanged);
            // 
            // refbook
            // 
            this.refbook.AutoSize = true;
            this.refbook.Location = new System.Drawing.Point(10, 25);
            this.refbook.Name = "refbook";
            this.refbook.Size = new System.Drawing.Size(150, 24);
            this.refbook.TabIndex = 0;
            this.refbook.TabStop = true;
            this.refbook.Text = "Reference Book";
            this.refbook.UseVisualStyleBackColor = true;
            this.refbook.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.issuer);
            this.groupBox3.Controls.Add(this.issue_date_box);
            this.groupBox3.Controls.Add(this.issuer_name);
            this.groupBox3.Controls.Add(this.check_issue);
            this.groupBox3.Controls.Add(this.issue_date);
            this.groupBox3.Location = new System.Drawing.Point(206, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 103);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issuance";
            // 
            // issue_date_box
            // 
            this.issue_date_box.Location = new System.Drawing.Point(104, 71);
            this.issue_date_box.Name = "issue_date_box";
            this.issue_date_box.Size = new System.Drawing.Size(121, 26);
            this.issue_date_box.TabIndex = 5;
            // 
            // issuer_name
            // 
            this.issuer_name.Location = new System.Drawing.Point(104, 43);
            this.issuer_name.Name = "issuer_name";
            this.issuer_name.Size = new System.Drawing.Size(121, 26);
            this.issuer_name.TabIndex = 4;
            this.issuer_name.TextChanged += new System.EventHandler(this.issuer_name_TextChanged);
            // 
            // check_issue
            // 
            this.check_issue.AutoSize = true;
            this.check_issue.Location = new System.Drawing.Point(10, 20);
            this.check_issue.Name = "check_issue";
            this.check_issue.Size = new System.Drawing.Size(83, 24);
            this.check_issue.TabIndex = 2;
            this.check_issue.Text = "Issued";
            this.check_issue.UseVisualStyleBackColor = true;
            this.check_issue.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // issue_date
            // 
            this.issue_date.AutoSize = true;
            this.issue_date.Location = new System.Drawing.Point(6, 75);
            this.issue_date.Name = "issue_date";
            this.issue_date.Size = new System.Drawing.Size(91, 20);
            this.issue_date.TabIndex = 0;
            this.issue_date.Text = "Issue Date:";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(144, 15);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(200, 26);
            this.isbn.TabIndex = 14;
            this.isbn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(144, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(286, 26);
            this.title.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 498);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(144, 92);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(286, 26);
            this.date.TabIndex = 18;
            // 
            // issuer
            // 
            this.issuer.AutoSize = true;
            this.issuer.Location = new System.Drawing.Point(6, 51);
            this.issuer.Name = "issuer";
            this.issuer.Size = new System.Drawing.Size(79, 20);
            this.issuer.TabIndex = 6;
            this.issuer.Text = "Issued to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 548);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.book_type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.sub_category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.book_type.ResumeLayout(false);
            this.book_type.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sub_category;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox book_type;
        private System.Windows.Forms.RadioButton journal;
        private System.Windows.Forms.RadioButton txtbook;
        private System.Windows.Forms.RadioButton refbook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox check_issue;
        private System.Windows.Forms.Label issue_date;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox issuer_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ListBox lstofauthors;
        private System.Windows.Forms.DateTimePicker issue_date_box;
        private System.Windows.Forms.Label issuer;
    }
}

