using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Dashboard : Form
    {
        // TODO: Specify the connection string for connecting the front end to the backend.
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = Northwind ;Integrated Security = SSPI ";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LoadOrders()
        {
            // TODO: Complete the function LoadOrders
            // SQL Query to Select all records from orders table in the descending order of order date
            con.Open();
            string sql = "Select * from Orders order by OrderDate desc";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable d = new DataTable();
            da.Fill(d);
            cm.Dispose();
            con.Close();
            dataGridView1.DataSource = d;
            
            
        }

        private void DeleteOrder(string orderid)
        {
            con.Open();
            // TODO: Complete the function DeleteOrder 
            // SQL query to Delete the from the order and order details table
            string sql = "Delete [Order Details] where @orderid = orderid; Delete orders where @orderid = orderid; ";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            cm.Parameters.AddWithValue("@orderid", orderid);
            cm.ExecuteNonQuery();
            cm.Dispose();
            con.Close();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            LoadOrders();
            dataGridView1.Columns.Add(deleteButton);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if click is on new row or header row
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == dataGridView1.Columns["dataGridViewDeleteButton"].Index)
            {
                var data = dataGridView1.Rows[e.RowIndex];
                MessageBox.Show(data.Cells[0].Value.ToString());

   
                DeleteOrder (data.Cells[0].Value.ToString());

                

                dataGridView1.Columns.Remove("dataGridViewDeleteButton");
                dataGridView1.DataSource = null;

                LoadOrders();

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                
                dataGridView1.Columns.Add(deleteButton);
                
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Master m = new Master();
            m.ShowDialog();

            dataGridView1.Columns.Remove("dataGridViewDeleteButton");
            dataGridView1.DataSource = null;

           
            LoadOrders();

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteButton);
        }
    }
}
