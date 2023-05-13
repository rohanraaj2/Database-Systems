
namespace Northwind
{
    partial class Master
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
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.productGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.tbShipCountry = new System.Windows.Forms.TextBox();
            this.tbFreight = new System.Windows.Forms.TextBox();
            this.tbShipPostalCode = new System.Windows.Forms.TextBox();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.tbShipRegion = new System.Windows.Forms.TextBox();
            this.tbShipCompanyID = new System.Windows.Forms.TextBox();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.tbShipCompany = new System.Windows.Forms.TextBox();
            this.tbShipCity = new System.Windows.Forms.TextBox();
            this.tbShipAddress = new System.Windows.Forms.TextBox();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblShipPostalCode = new System.Windows.Forms.Label();
            this.lblShipCountry = new System.Windows.Forms.Label();
            this.lblShipRegion = new System.Windows.Forms.Label();
            this.lblShipCity = new System.Windows.Forms.Label();
            this.lblShippedAddress = new System.Windows.Forms.Label();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblShipCompanyID = new System.Windows.Forms.Label();
            this.lblShipCompany = new System.Windows.Forms.Label();
            this.shippersGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDetailsGrid = new System.Windows.Forms.DataGridView();
            this.employeeGrid = new System.Windows.Forms.DataGridView();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippersGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.tbCustomerName);
            this.customerGroupBox.Controls.Add(this.tbCustomerID);
            this.customerGroupBox.Controls.Add(this.lblCustomerName);
            this.customerGroupBox.Controls.Add(this.lblCustomerID);
            this.customerGroupBox.Controls.Add(this.customerGrid);
            this.customerGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.customerGroupBox.Location = new System.Drawing.Point(479, 26);
            this.customerGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerGroupBox.Size = new System.Drawing.Size(441, 368);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customers";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(201, 276);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(200, 26);
            this.tbCustomerName.TabIndex = 7;
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(201, 238);
            this.tbCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.Size = new System.Drawing.Size(200, 26);
            this.tbCustomerID.TabIndex = 6;
            this.tbCustomerID.TextChanged += new System.EventHandler(this.tbCustomerID_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(24, 282);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerName.TabIndex = 5;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(24, 238);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(95, 20);
            this.lblCustomerID.TabIndex = 4;
            this.lblCustomerID.Text = "CustomerID";
            // 
            // customerGrid
            // 
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Location = new System.Drawing.Point(27, 26);
            this.customerGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.RowHeadersWidth = 51;
            this.customerGrid.RowTemplate.Height = 24;
            this.customerGrid.Size = new System.Drawing.Size(375, 188);
            this.customerGrid.TabIndex = 1;
            this.customerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiscount);
            this.groupBox2.Controls.Add(this.tbDiscount);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.tbProductName);
            this.groupBox2.Controls.Add(this.tbProductID);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.lblProductID);
            this.groupBox2.Controls.Add(this.tbUnitPrice);
            this.groupBox2.Controls.Add(this.tbQuantity);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.productGrid);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(974, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(524, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(291, 289);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(72, 20);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Text = "Discount";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(382, 282);
            this.tbDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(113, 26);
            this.tbDiscount.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(295, 331);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(142, 234);
            this.tbProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(113, 26);
            this.tbProductName.TabIndex = 15;
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(142, 186);
            this.tbProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(113, 26);
            this.tbProductID.TabIndex = 14;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(18, 238);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(106, 20);
            this.lblProductName.TabIndex = 13;
            this.lblProductName.Text = "ProductName";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(18, 190);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(81, 20);
            this.lblProductID.TabIndex = 12;
            this.lblProductID.Text = "ProductID";
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(382, 232);
            this.tbUnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(113, 26);
            this.tbUnitPrice.TabIndex = 11;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(382, 190);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(113, 26);
            this.tbQuantity.TabIndex = 10;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(291, 234);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(73, 20);
            this.lblUnitPrice.TabIndex = 9;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(291, 190);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.lblProductID_Click);
            // 
            // productGrid
            // 
            this.productGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrid.Location = new System.Drawing.Point(26, 26);
            this.productGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productGrid.Name = "productGrid";
            this.productGrid.RowHeadersWidth = 51;
            this.productGrid.RowTemplate.Height = 24;
            this.productGrid.Size = new System.Drawing.Size(475, 148);
            this.productGrid.TabIndex = 2;
            this.productGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGrid_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtShippedDate);
            this.groupBox3.Controls.Add(this.tbShipCountry);
            this.groupBox3.Controls.Add(this.tbFreight);
            this.groupBox3.Controls.Add(this.tbShipPostalCode);
            this.groupBox3.Controls.Add(this.tbShipName);
            this.groupBox3.Controls.Add(this.tbShipRegion);
            this.groupBox3.Controls.Add(this.tbShipCompanyID);
            this.groupBox3.Controls.Add(this.lblShippedDate);
            this.groupBox3.Controls.Add(this.tbShipCompany);
            this.groupBox3.Controls.Add(this.tbShipCity);
            this.groupBox3.Controls.Add(this.tbShipAddress);
            this.groupBox3.Controls.Add(this.lblFreight);
            this.groupBox3.Controls.Add(this.lblShipPostalCode);
            this.groupBox3.Controls.Add(this.lblShipCountry);
            this.groupBox3.Controls.Add(this.lblShipRegion);
            this.groupBox3.Controls.Add(this.lblShipCity);
            this.groupBox3.Controls.Add(this.lblShippedAddress);
            this.groupBox3.Controls.Add(this.lblShipName);
            this.groupBox3.Controls.Add(this.lblShipCompanyID);
            this.groupBox3.Controls.Add(this.lblShipCompany);
            this.groupBox3.Controls.Add(this.shippersGrid);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Location = new System.Drawing.Point(34, 401);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(602, 385);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shippers";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dtShippedDate
            // 
            this.dtShippedDate.Location = new System.Drawing.Point(138, 350);
            this.dtShippedDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtShippedDate.Name = "dtShippedDate";
            this.dtShippedDate.Size = new System.Drawing.Size(146, 26);
            this.dtShippedDate.TabIndex = 22;
            // 
            // tbShipCountry
            // 
            this.tbShipCountry.Location = new System.Drawing.Point(428, 348);
            this.tbShipCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipCountry.Name = "tbShipCountry";
            this.tbShipCountry.Size = new System.Drawing.Size(146, 26);
            this.tbShipCountry.TabIndex = 22;
            // 
            // tbFreight
            // 
            this.tbFreight.Location = new System.Drawing.Point(138, 311);
            this.tbFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.Size = new System.Drawing.Size(146, 26);
            this.tbFreight.TabIndex = 26;
            // 
            // tbShipPostalCode
            // 
            this.tbShipPostalCode.Location = new System.Drawing.Point(428, 309);
            this.tbShipPostalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipPostalCode.Name = "tbShipPostalCode";
            this.tbShipPostalCode.Size = new System.Drawing.Size(146, 26);
            this.tbShipPostalCode.TabIndex = 21;
            // 
            // tbShipName
            // 
            this.tbShipName.Location = new System.Drawing.Point(138, 271);
            this.tbShipName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(146, 26);
            this.tbShipName.TabIndex = 25;
            // 
            // tbShipRegion
            // 
            this.tbShipRegion.Location = new System.Drawing.Point(428, 269);
            this.tbShipRegion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipRegion.Name = "tbShipRegion";
            this.tbShipRegion.Size = new System.Drawing.Size(146, 26);
            this.tbShipRegion.TabIndex = 20;
            // 
            // tbShipCompanyID
            // 
            this.tbShipCompanyID.Location = new System.Drawing.Point(138, 221);
            this.tbShipCompanyID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipCompanyID.Name = "tbShipCompanyID";
            this.tbShipCompanyID.Size = new System.Drawing.Size(146, 26);
            this.tbShipCompanyID.TabIndex = 24;
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(14, 346);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(103, 20);
            this.lblShippedDate.TabIndex = 14;
            this.lblShippedDate.Text = "ShippedDate";
            // 
            // tbShipCompany
            // 
            this.tbShipCompany.Location = new System.Drawing.Point(138, 179);
            this.tbShipCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipCompany.Name = "tbShipCompany";
            this.tbShipCompany.Size = new System.Drawing.Size(146, 26);
            this.tbShipCompany.TabIndex = 23;
            // 
            // tbShipCity
            // 
            this.tbShipCity.Location = new System.Drawing.Point(428, 219);
            this.tbShipCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipCity.Name = "tbShipCity";
            this.tbShipCity.Size = new System.Drawing.Size(146, 26);
            this.tbShipCity.TabIndex = 19;
            // 
            // tbShipAddress
            // 
            this.tbShipAddress.Location = new System.Drawing.Point(428, 176);
            this.tbShipAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbShipAddress.Name = "tbShipAddress";
            this.tbShipAddress.Size = new System.Drawing.Size(146, 26);
            this.tbShipAddress.TabIndex = 18;
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(14, 311);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(59, 20);
            this.lblFreight.TabIndex = 13;
            this.lblFreight.Text = "Freight";
            // 
            // lblShipPostalCode
            // 
            this.lblShipPostalCode.AutoSize = true;
            this.lblShipPostalCode.Location = new System.Drawing.Point(305, 311);
            this.lblShipPostalCode.Name = "lblShipPostalCode";
            this.lblShipPostalCode.Size = new System.Drawing.Size(123, 20);
            this.lblShipPostalCode.TabIndex = 12;
            this.lblShipPostalCode.Text = "ShipPostalCode";
            // 
            // lblShipCountry
            // 
            this.lblShipCountry.AutoSize = true;
            this.lblShipCountry.Location = new System.Drawing.Point(304, 348);
            this.lblShipCountry.Name = "lblShipCountry";
            this.lblShipCountry.Size = new System.Drawing.Size(96, 20);
            this.lblShipCountry.TabIndex = 11;
            this.lblShipCountry.Text = "ShipCountry";
            // 
            // lblShipRegion
            // 
            this.lblShipRegion.AutoSize = true;
            this.lblShipRegion.Location = new System.Drawing.Point(305, 269);
            this.lblShipRegion.Name = "lblShipRegion";
            this.lblShipRegion.Size = new System.Drawing.Size(92, 20);
            this.lblShipRegion.TabIndex = 10;
            this.lblShipRegion.Text = "ShipRegion";
            // 
            // lblShipCity
            // 
            this.lblShipCity.AutoSize = true;
            this.lblShipCity.Location = new System.Drawing.Point(304, 219);
            this.lblShipCity.Name = "lblShipCity";
            this.lblShipCity.Size = new System.Drawing.Size(67, 20);
            this.lblShipCity.TabIndex = 9;
            this.lblShipCity.Text = "ShipCity";
            // 
            // lblShippedAddress
            // 
            this.lblShippedAddress.AutoSize = true;
            this.lblShippedAddress.Location = new System.Drawing.Point(305, 179);
            this.lblShippedAddress.Name = "lblShippedAddress";
            this.lblShippedAddress.Size = new System.Drawing.Size(100, 20);
            this.lblShippedAddress.TabIndex = 8;
            this.lblShippedAddress.Text = "ShipAddress";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(14, 274);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(83, 20);
            this.lblShipName.TabIndex = 7;
            this.lblShipName.Text = "ShipName";
            // 
            // lblShipCompanyID
            // 
            this.lblShipCompanyID.AutoSize = true;
            this.lblShipCompanyID.Location = new System.Drawing.Point(14, 228);
            this.lblShipCompanyID.Name = "lblShipCompanyID";
            this.lblShipCompanyID.Size = new System.Drawing.Size(125, 20);
            this.lblShipCompanyID.TabIndex = 6;
            this.lblShipCompanyID.Text = "ShipCompanyID";
            // 
            // lblShipCompany
            // 
            this.lblShipCompany.AutoSize = true;
            this.lblShipCompany.Location = new System.Drawing.Point(14, 182);
            this.lblShipCompany.Name = "lblShipCompany";
            this.lblShipCompany.Size = new System.Drawing.Size(108, 20);
            this.lblShipCompany.TabIndex = 5;
            this.lblShipCompany.Text = "ShipCompany";
            // 
            // shippersGrid
            // 
            this.shippersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shippersGrid.Location = new System.Drawing.Point(17, 26);
            this.shippersGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shippersGrid.Name = "shippersGrid";
            this.shippersGrid.RowHeadersWidth = 51;
            this.shippersGrid.RowTemplate.Height = 24;
            this.shippersGrid.Size = new System.Drawing.Size(557, 112);
            this.shippersGrid.TabIndex = 1;
            this.shippersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shippersGrid_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbTotal);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.dtRequiredDate);
            this.groupBox4.Controls.Add(this.dtOrderDate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.orderDetailsGrid);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.Location = new System.Drawing.Point(662, 401);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(837, 311);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OrderDetails";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(27, 274);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(113, 26);
            this.tbTotal.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 241);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 20);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "OrderTotal";
            // 
            // dtRequiredDate
            // 
            this.dtRequiredDate.Location = new System.Drawing.Point(27, 182);
            this.dtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtRequiredDate.Name = "dtRequiredDate";
            this.dtRequiredDate.Size = new System.Drawing.Size(231, 26);
            this.dtRequiredDate.TabIndex = 21;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.Location = new System.Drawing.Point(27, 91);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(231, 26);
            this.dtOrderDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "RequiredDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "OrderDate";
            // 
            // orderDetailsGrid
            // 
            this.orderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsGrid.Location = new System.Drawing.Point(313, 52);
            this.orderDetailsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderDetailsGrid.Name = "orderDetailsGrid";
            this.orderDetailsGrid.RowHeadersWidth = 51;
            this.orderDetailsGrid.RowTemplate.Height = 24;
            this.orderDetailsGrid.Size = new System.Drawing.Size(501, 242);
            this.orderDetailsGrid.TabIndex = 0;
            this.orderDetailsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDetailsGrid_CellContentClick);
            // 
            // employeeGrid
            // 
            this.employeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGrid.Location = new System.Drawing.Point(17, 26);
            this.employeeGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeGrid.Name = "employeeGrid";
            this.employeeGrid.RowHeadersWidth = 51;
            this.employeeGrid.RowTemplate.Height = 24;
            this.employeeGrid.Size = new System.Drawing.Size(361, 188);
            this.employeeGrid.TabIndex = 0;
            this.employeeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGrid_CellContentClick);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(14, 238);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(96, 20);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "EmployeeID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmployeeName);
            this.groupBox1.Controls.Add(this.tbEmployeeID);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.employeeGrid);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(404, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(178, 276);
            this.tbEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(200, 26);
            this.tbEmployeeName.TabIndex = 3;
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Location = new System.Drawing.Point(178, 230);
            this.tbEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.Size = new System.Drawing.Size(200, 26);
            this.tbEmployeeID.TabIndex = 2;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(14, 282);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(121, 20);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(662, 741);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(385, 45);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1100, 740);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(385, 45);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 826);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Master";
            this.Text = "Master";
            this.Load += new System.EventHandler(this.Master_Load);
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippersGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView employeeGrid;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView productGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.DataGridView orderDetailsGrid;
        private System.Windows.Forms.DateTimePicker dtRequiredDate;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtShippedDate;
        private System.Windows.Forms.TextBox tbShipCountry;
        private System.Windows.Forms.TextBox tbFreight;
        private System.Windows.Forms.TextBox tbShipPostalCode;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.TextBox tbShipRegion;
        private System.Windows.Forms.TextBox tbShipCompanyID;
        private System.Windows.Forms.Label lblShippedDate;
        private System.Windows.Forms.TextBox tbShipCompany;
        private System.Windows.Forms.TextBox tbShipCity;
        private System.Windows.Forms.TextBox tbShipAddress;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblShipPostalCode;
        private System.Windows.Forms.Label lblShipCountry;
        private System.Windows.Forms.Label lblShipRegion;
        private System.Windows.Forms.Label lblShipCity;
        private System.Windows.Forms.Label lblShippedAddress;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.Label lblShipCompanyID;
        private System.Windows.Forms.Label lblShipCompany;
        private System.Windows.Forms.DataGridView shippersGrid;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
    }
}