using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Northwind
{
   
    public partial class Master : Form
    {
        // TODO: Specify the connection string for connecting the front end to the backend.
        const string constr = @"Data Source = ROHAN-PC\SPARTA; Initial Catalog = Northwind ;Integrated Security = SSPI ";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        


        public Master()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void employeeGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEmployeeID.Text = employeeGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbEmployeeName.Text = employeeGrid.Rows[e.RowIndex].Cells[1].Value.ToString()+" " +employeeGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void LoadEmployees()
        {
            // TODO: Complete the function LoadEmployees
            // SQL query to select EmployeeID, FirstName, LastName from Employees
            con.Open();
            string sql = "select EmployeeID, FirstName, LastName from Employees";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            employeeGrid.DataSource = dt;
            employeeGrid.BackgroundColor = Color.White;
            employeeGrid.RowHeadersVisible = false;
            employeeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadCustomers()
        {
            // TODO: Complete the function LoadCustomers
            // SQL query to select CustomerID, CustomerName from Customers
            con.Open();
            string sql = "select CustomerID, ContactName from Customers";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da1 = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            con.Close();
            customerGrid.DataSource = dt1;
            customerGrid.BackgroundColor = Color.White;
            customerGrid.RowHeadersVisible = false;
            customerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadProducts()
        {
            // TODO: Complete the function LoadProducts
            // SQL query to select ProductID, ProductName, UnitPrice from products which are not discontinued and units in stock are more than zero.
            con.Open();
            string sql = "select ProductID, ProductName, UnitPrice from products where discontinued = 0 and UnitsInStock > 0";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da2 = new SqlDataAdapter(cm);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            con.Close();
            productGrid.DataSource = dt2;
            productGrid.BackgroundColor = Color.White;
            productGrid.RowHeadersVisible = false;
            productGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadShippers()
        {
            //TODO: Complete the function LoadShippers
            // SQL query to select * from shippers.
            con.Open();
            cm = new SqlCommand("select * from shippers", con);
            SqlDataAdapter da3 = new SqlDataAdapter(cm);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            con.Close();
            shippersGrid.DataSource = dt3;
            shippersGrid.BackgroundColor = Color.White;
            shippersGrid.RowHeadersVisible = false;
            shippersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
 
        private void Master_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadCustomers();
            LoadProducts();
            LoadShippers();
            

         
            var productid = new DataGridViewTextBoxColumn();
            productid.Name = "ProductID";
            productid.HeaderText = "ProductID";

            var unitprice = new DataGridViewTextBoxColumn();
            unitprice.Name = "UnitPrice";
            unitprice.HeaderText = "UnitPrice";

            var quantity = new DataGridViewTextBoxColumn();
            quantity.Name = "Quantity";
            quantity.HeaderText = "Quantity";

            var discount = new DataGridViewTextBoxColumn();
            discount.Name = "Discount";
            discount.HeaderText = "Discount";

            orderDetailsGrid.Columns.Add(productid);
            orderDetailsGrid.Columns.Add(unitprice);
            orderDetailsGrid.Columns.Add(quantity);
            orderDetailsGrid.Columns.Add(discount);
            orderDetailsGrid.BackgroundColor = Color.White;
            orderDetailsGrid.RowHeadersVisible = false;
            orderDetailsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            tbCustomerID.Enabled = false;
            tbCustomerName.Enabled = false;
            tbProductID.Enabled = false;
            tbProductName.Enabled = false;
            tbEmployeeID.Enabled = false;
            tbEmployeeName.Enabled = false;
            tbShipCompany.Enabled = false;
            tbShipCompanyID.Enabled = false;
            tbTotal.Enabled = false;
            dtShippedDate.Format = DateTimePickerFormat.Custom;
            dtShippedDate.CustomFormat = "dd-MM-yyyy";
            

        }

        private void customerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCustomerID.Text = customerGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbCustomerName.Text = customerGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void lblProductID_Click(object sender, EventArgs e)
        {

        }

        private void productGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbProductID.Text = productGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbProductName.Text = productGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbProductID.TextLength > 0 && tbDiscount.TextLength > 0 && tbProductName.TextLength>0 && tbQuantity.TextLength > 0 && tbUnitPrice.TextLength > 0)
            {
                orderDetailsGrid.Rows.Add(tbProductID.Text.ToString(), tbUnitPrice.Text.ToString(), tbQuantity.Text.ToString(), tbDiscount.Text.ToString());
                tbProductID.Text = "";
                tbProductName.Text = "";
                tbQuantity.Text = "";
                tbUnitPrice.Text = "";
                tbDiscount.Text = "";

                decimal total = 0;
                for (int i = 0;  i < orderDetailsGrid.RowCount; i++)
                {
                    var unit = Convert.ToDecimal(orderDetailsGrid.Rows[i].Cells[1].Value);
                    var qty = Convert.ToDecimal(orderDetailsGrid.Rows[i].Cells[2].Value);
                    var disc = Convert.ToDecimal(orderDetailsGrid.Rows[i].Cells[3].Value);
                    total += (unit * qty) * (1 - disc);
                }
                tbTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please provide valid information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void shippersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbShipCompany.Text = shippersGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbShipCompanyID.Text = shippersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEmployeeID.Text = "";
            tbEmployeeName.Text = "";

            tbCustomerID.Text = "";
            tbCustomerName.Text = "";

            tbProductID.Text = "";
            tbProductName.Text = "";
            tbQuantity.Text = "";
            tbUnitPrice.Text = "";
            tbDiscount.Text = "";

            tbShipCompanyID.Text = "";
            tbShipCompany.Text = "";
            tbShipName.Text = "";
            tbFreight.Text = "";
            tbShipAddress.Text = "";
            tbShipCity.Text = "";
            tbShipRegion.Text = "";
            tbShipPostalCode.Text = "";
            tbShipCompany.Text = "";
            tbShipCountry.Text = "";
            tbTotal.Text = "";
            dtOrderDate.Value = DateTime.Now;
            dtRequiredDate.Value = DateTime.Now;
            dtShippedDate.Value = DateTime.Now;
            orderDetailsGrid.Rows.Clear();


        }

        private int GetMaxOrderID()
        {
            // TODO: Complete the function GetMaxOrderID
            // Query to get max(orderid) from the orders table.
            con.Open();
            string sql = "select max(orderID) from orders";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da5 = new SqlDataAdapter(cm);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            con.Close();

            int orderid = Convert.ToInt32(dt5.Rows[0].ItemArray[0].ToString());
            return orderid;

        }

        private void InsertOrdetails(int orderid)
        {
            // TODO: Complete the function InsertOrderDetails
            for (int i = 0; i < orderDetailsGrid.RowCount - 1; i++)
            {
                var pid = Convert.ToInt32(orderDetailsGrid.Rows[i].Cells[0].Value);
                var unit = Convert.ToDecimal(orderDetailsGrid.Rows[i].Cells[1].Value);
                var qty = Convert.ToDecimal(orderDetailsGrid.Rows[i].Cells[2].Value);
                var disc = Convert.ToDecimal(orderDetailsGrid.Rows[i].Cells[3].Value);

                // Insert into order details 
                // Sql query to insert into order details
                string sql = "insert into [Order Details] (ProductID, UnitPrice, Quantity, Discount) values (@pid, @unit, @qty, @disc)";
                con.Open();
                cm = new SqlCommand(sql, con);
                // Specify the values for the parameters. 
                cm.Parameters.AddWithValue("@pid", pid);
                cm.Parameters.AddWithValue("@unit", unit);
                cm.Parameters.AddWithValue("@qty", qty);
                cm.Parameters.AddWithValue("@disc", disc);
                cm.ExecuteNonQuery();
                con.Close();

            }

        }
        private void InsertOrder()
        {
            // TODO: Complete the function InsertOrder
            // Sql query to insert a new order.
            string sql = "INSERT INTO [Orders] ([CustomerID],[EmployeeID],[OrderDate],[RequiredDate],[ShippedDate],[ShipVia],[Freight],[ShipName],[ShipAddress],[ShipCity],[ShipRegion],[ShipPostalCode],[ShipCountry]) VALUES (@CustomerID,@EmployeeID,@OrderDate,@RequiredDate,@ShippedDate,@ShipVia,@Freight,@ShipName,@ShipAddress,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipCountry)";
            cm = new SqlCommand(sql, con);

            // Specify the value of the parameters
            con.Open();
            cm = new SqlCommand(sql, con);
            // Specify the value for the parameters.
            cm.Parameters.AddWithValue("@CustomerID", tbCustomerID.Text);
            cm.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(tbEmployeeID.Text));
            cm.Parameters.AddWithValue("@OrderDate", dtOrderDate.Value);
            cm.Parameters.AddWithValue("@RequiredDate", dtRequiredDate.Value);
            cm.Parameters.AddWithValue("@ShippedDate", dtShippedDate.Value);
            cm.Parameters.AddWithValue("@ShipVia", Convert.ToInt32(tbShipCompanyID.Text));
            cm.Parameters.AddWithValue("@Freight", Convert.ToDecimal(tbFreight.Text));
            cm.Parameters.AddWithValue("@ShipName", tbShipName.Text);
            cm.Parameters.AddWithValue("@ShipAddress", tbShipAddress.Text);
            cm.Parameters.AddWithValue("@ShipCity", tbShipCity.Text);
            cm.Parameters.AddWithValue("@ShipRegion", tbShipRegion.Text);
            cm.Parameters.AddWithValue("@ShipPostalCode", tbShipPostalCode.Text);
            cm.Parameters.AddWithValue("@ShipCountry", tbShipCountry.Text);
            cm.ExecuteNonQuery();
            con.Close();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Insert New Order.
            InsertOrder();
            // Get the Order ID for the new order.
            int orderid = GetMaxOrderID();
            // Insert Order Details.
            InsertOrdetails(orderid);
  
            MessageBox.Show("Your order has been successfully inserted. Your order number is "+ orderid.ToString());

            tbEmployeeID.Text = "";
            tbEmployeeName.Text = "";

            tbCustomerID.Text = "";
            tbCustomerName.Text = "";

            tbProductID.Text = "";
            tbProductName.Text = "";
            tbQuantity.Text = "";
            tbUnitPrice.Text = "";
            tbDiscount.Text = "";

            tbShipCompanyID.Text = "";
            tbShipCompany.Text = "";
            tbShipName.Text = "";
            tbFreight.Text = "";
            tbShipAddress.Text = "";
            tbShipCity.Text = "";
            tbShipRegion.Text = "";
            tbShipPostalCode.Text = "";
            tbShipCompany.Text = "";
            tbShipCountry.Text = "";
            tbTotal.Text = "";
            dtOrderDate.Value = DateTime.Now;
            dtRequiredDate.Value = DateTime.Now;
            dtShippedDate.Value = DateTime.Now;
            orderDetailsGrid.Rows.Clear();

            
            this.Close();


            
        }

        private void tbCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void orderDetailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
