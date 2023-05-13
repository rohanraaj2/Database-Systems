using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Book_Search : Form
    {
        public class Book
        {
            public string ISBN;
            public string Title;
            public int catIndex;
            public int subcatIndex;
            public string authors;
            public DateTime purchasedon;
            public int type;
            public bool isIssued;
            public string issuedTo;
            public DateTime issuedOn;

            public Book(string _ISBN, string _title, int _cat, int _subcat, string _authors, DateTime _purchasedOn, int _type, bool _isIssued, string _issuedTo, DateTime _issuedDate)
            {
                ISBN = _ISBN;
                Title = _title;
                catIndex = _cat;
                subcatIndex = _subcat;
                authors = _authors;
                purchasedon = _purchasedOn;
                type = _type;
                isIssued = _isIssued;
                issuedTo = _issuedTo;
                issuedOn = _issuedDate;

            }
        }
        List<Book> books = new List<Book>();

        public Book_Search()
        {
            InitializeComponent();
            books.Add(new Book("0201144719 9780201144710", "An introduction to database systems", 1, 1, "C J Date", Convert.ToDateTime("1 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015"))); books.Add(new Book("0805301453 9780805301458", "Fundamentals of database systems", 1, 1, "Ramez Elmasri; Sham Navathe", Convert.ToDateTime("10 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("1571690867 9781571690869", "Object oriented programming in Java", 2, 2, "Stephen Gilbert; Bill McCarty", Convert.ToDateTime("15 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("1842652478 9781842652473", "Object oriented programming using C++", 2, 1, "B Chandra", Convert.ToDateTime("16 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0070522618 9780070522619", "Artificial intelligence", 3, 2, "Elaine Rich", Convert.ToDateTime("20 jan 2015"), 1, false, "", Convert.ToDateTime("30 Nov 2015")));
            books.Add(new Book("0865760047 9780865760042", "The Handbook of artificial intelligence", 3, 2, "Avron Barr; Edward A Feigenbaum; Paul R Cohen", Convert.ToDateTime("22 jan 2015"), 2, false, "", Convert.ToDateTime("30 Nov 2015")));
            foreach (Book b in books)
            {

                if (b.catIndex == 1)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                }
                else if (b.catIndex == 2)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                }
                else
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                }
            }   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (category.SelectedIndex == 0)
            
            {
                foreach (Book b in books)
                {
                    if (b.catIndex == 1)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                }
                }
            }
            else if (category.SelectedIndex == 1)
            {
                foreach (Book b in books)
                {
                    if (b.catIndex == 2)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                }
                }
            }
            else if (category.SelectedIndex == 2)
                {
                foreach (Book b in books)
                {
                    if (b.catIndex == 3)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                }
                }
            }
             
            if (title.Text.Length > 0)
            {
                foreach (Book b in books)
                {
                    if (b.Title == title.Text)
                    {
                        if (b.catIndex == 1)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                }
                else if (b.catIndex == 2)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                }
                else
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                }
                    }
                }

            }
            if (refbook.Checked == true)
            {
                foreach (Book b in books)
                {
                    if (b.type == 1)
                    {
                        if (b.catIndex == 1)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                }
                else if (b.catIndex == 2)
                {
                    listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                }
                else
                {
                    listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                }
                    }
                }
            }
            else if (txtbook.Checked == true)
            {
                foreach (Book b in books)
                {
                    if (b.type == 2)
                    {
                        if (b.catIndex == 1)
                        {
                            listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                        }
                        else if (b.catIndex == 2)
                        {
                            listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                        }
                        else
                        {
                            listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                        }
                    }
                }
            }
            else if (journal.Checked == true)
            {
                foreach (Book b in books)
                {
                    if (b.type == 3)
                    {
                        if (b.catIndex == 1)
                        {
                            listBox1.Items.Add(b.ISBN + "/" + "Database Systems" + "/" + b.Title);
                        }
                        else if (b.catIndex == 2)
                        {
                            listBox1.Items.Add(b.ISBN + "/" + "OOP" + "/" + b.Title);
                        }
                        else
                        {
                            listBox1.Items.Add(b.ISBN + "/" + "Artificial Intelligence " + "/" + b.Title);
                        }
                    }
                }
            }
    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Do you really want to delete this book?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
               
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 view = new Form1();
            Book x = books[listBox1.SelectedIndex];
            view.Book_ISBN = x.ISBN;
            view.Book_category = x.catIndex;
            view.Book_Sub_Category = x.subcatIndex;
            view.Book_title = x.Title;
            view.Book_issued = x.isIssued;
            view.Book_Authors = x.authors;
            view.Book_type = x.type;
            view.Book_issuer = x.issuedTo;
            view.Book_Purchase_Date = x.purchasedon;
            view.Book_issue_date = x.issuedOn;
            view.ShowDialog();
        }

        private void Book_Search_Load(object sender, EventArgs e)
        {

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
