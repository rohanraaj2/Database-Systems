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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] SubCat1 = 
            {
            "ERD",
            "SQL",
            "OLAP",
            "Data Mining",
            };
            string[] SubCat2 = 
            {
            "C++",
            "Java",
            };
            string[] SubCat3 = 
            {
            "Machine Learning",
            "Robotics",
            "Computer Vision",
            };
            if (category.SelectedIndex == 0)
            {
                sub_category.Items.AddRange(SubCat1);
            }
            else if (category.SelectedIndex == 1)
            {
                sub_category.Items.Clear();
                sub_category.Items.AddRange(SubCat2);
            }
            else if (category.SelectedIndex == 2)
            {
                sub_category.Items.Clear();
                sub_category.Items.AddRange(SubCat3);
            }
        }

        private void sub_category_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = author_name.Text;
            lstofauthors.Items.Add(author);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstofauthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_issue.Checked == true)
            {
                issuer.Enabled = true;
                issue_date.Enabled = true;

            }
            else
            {
                issuer.Enabled = false;
                issue_date.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int diff = DateTime.Compare(DateTime.Today.Date, date.Value);
            int diff2 = DateTime.Compare(date.Value, issue_date_box.Value);
            int diff3 = DateTime.Compare(DateTime.Today.Date, issue_date_box.Value);
            if ((isbn.Text.Length > 12) || (diff < 0))

            {
                MessageBox.Show("The Length of ISBN is greater than 12 or Purchase Date is greater than today", "Confirmation", MessageBoxButtons.OK);
            }
            else if ((journal.Checked == true) && (lstofauthors.Items.Count > 0))
            {
                MessageBox.Show("Book of Journal Type should have no authors.", "Confirmation", MessageBoxButtons.OK);
            }
            else if (((txtbook.Checked == true) || (refbook.Checked == true)) && (lstofauthors.Items.Count == 0))
            {
                MessageBox.Show("Reference and Textbook should have atleast one author", "Confirmation", MessageBoxButtons.OK);
            }

            else
            {
                if (check_issue.Checked == true)
                {
                    if ((issuer_name.Text.Length > 0) && (diff2 < 0) && (diff3 > 0))
                    {
                        MessageBox.Show("Book added successfully", "Confirmation", MessageBoxButtons.OK);
                    }
                    
                }
                else if (check_issue.Checked == false)
                {
                    MessageBox.Show("Book added successfully", "Confirmation", MessageBoxButtons.OK);
                }
            }
        }

        private void book_type_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbook_CheckedChanged(object sender, EventArgs e)
        {

        }
        }
    }