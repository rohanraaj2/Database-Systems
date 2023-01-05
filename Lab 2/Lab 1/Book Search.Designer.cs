namespace Lab_1
{
    partial class Book_Search
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
            this.label4 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.check_issue = new System.Windows.Forms.CheckBox();
            this.book_type = new System.Windows.Forms.GroupBox();
            this.journal = new System.Windows.Forms.RadioButton();
            this.txtbook = new System.Windows.Forms.RadioButton();
            this.refbook = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.book_type.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Category:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "Database Systems",
            "OOP",
            "Artificial Intelligence"});
            this.category.Location = new System.Drawing.Point(165, 43);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(222, 28);
            this.category.TabIndex = 9;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title:";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(165, 86);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(358, 26);
            this.title.TabIndex = 16;
            // 
            // check_issue
            // 
            this.check_issue.AutoSize = true;
            this.check_issue.Location = new System.Drawing.Point(165, 123);
            this.check_issue.Name = "check_issue";
            this.check_issue.Size = new System.Drawing.Size(83, 24);
            this.check_issue.TabIndex = 17;
            this.check_issue.Text = "Issued";
            this.check_issue.UseVisualStyleBackColor = true;
            // 
            // book_type
            // 
            this.book_type.Controls.Add(this.journal);
            this.book_type.Controls.Add(this.txtbook);
            this.book_type.Controls.Add(this.refbook);
            this.book_type.Location = new System.Drawing.Point(572, 28);
            this.book_type.Name = "book_type";
            this.book_type.Size = new System.Drawing.Size(184, 122);
            this.book_type.TabIndex = 18;
            this.book_type.TabStop = false;
            this.book_type.Text = "Type";
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
            // 
            // refbook
            // 
            this.refbook.AutoSize = true;
            this.refbook.Location = new System.Drawing.Point(10, 26);
            this.refbook.Name = "refbook";
            this.refbook.Size = new System.Drawing.Size(150, 24);
            this.refbook.TabIndex = 0;
            this.refbook.TabStop = true;
            this.refbook.Text = "Reference Book";
            this.refbook.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(670, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(644, 157);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 22;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(549, 560);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 23;
            this.button5.Text = "View";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.check_issue);
            this.groupBox1.Controls.Add(this.book_type);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(765, 202);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(18, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(765, 308);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(10, 31);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(744, 244);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Book_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Book_Search";
            this.Text = "Book_Search";
            this.Load += new System.EventHandler(this.Book_Search_Load);
            this.book_type.ResumeLayout(false);
            this.book_type.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.CheckBox check_issue;
        private System.Windows.Forms.GroupBox book_type;
        private System.Windows.Forms.RadioButton journal;
        private System.Windows.Forms.RadioButton txtbook;
        private System.Windows.Forms.RadioButton refbook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}