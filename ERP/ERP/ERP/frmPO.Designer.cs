namespace ERP
{
    partial class frmPO
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
            this.pnlGeneratePO = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.cmbPOStatus = new System.Windows.Forms.ComboBox();
            this.cmbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.cmbDeptID = new System.Windows.Forms.ComboBox();
            this.cmbVendorID = new System.Windows.Forms.ComboBox();
            this.dtpPODate = new System.Windows.Forms.DateTimePicker();
            this.txtPOID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDelStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDeliveredQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.cmbProductID = new System.Windows.Forms.ComboBox();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlApprovePO = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnDisapprove = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.APdgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.APbtnSearch = new System.Windows.Forms.Button();
            this.APdtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.APcmbPOStatus = new System.Windows.Forms.ComboBox();
            this.APcmbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.APcmbApprovedBy = new System.Windows.Forms.ComboBox();
            this.ApcmbVendor = new System.Windows.Forms.ComboBox();
            this.APdtpPOdate = new System.Windows.Forms.DateTimePicker();
            this.APtxtPOID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.APtxtRefNo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generatePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approvePOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pODeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAssignVendor = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnAssignVenor = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.AdgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.AssignbtnSearch = new System.Windows.Forms.Button();
            this.AdtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.AcmbPOStatus = new System.Windows.Forms.ComboBox();
            this.AcmbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.AcmbApprovedBy = new System.Windows.Forms.ComboBox();
            this.AcmbVendor = new System.Windows.Forms.ComboBox();
            this.AdtpPODate = new System.Windows.Forms.DateTimePicker();
            this.AtxtPOID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.AtxtRefNo = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pnlPODelivery = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.GRNdgvproducts = new System.Windows.Forms.DataGridView();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.GRNbtnSave = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.GRNbtnSearch = new System.Windows.Forms.Button();
            this.GRNdtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.GRNcmbStatus = new System.Windows.Forms.ComboBox();
            this.GRNcmbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.GRNcmbApprovedBy = new System.Windows.Forms.ComboBox();
            this.GRNtxtVendor = new System.Windows.Forms.ComboBox();
            this.GRNdtpPOID = new System.Windows.Forms.DateTimePicker();
            this.GRNtxtPOID = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.GRNtxtRefNo = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.pnlGeneratePO.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlApprovePO.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.APdgvProducts)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAssignVendor.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdgvProducts)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.pnlPODelivery.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRNdgvproducts)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneratePO
            // 
            this.pnlGeneratePO.Controls.Add(this.groupBox1);
            this.pnlGeneratePO.Controls.Add(this.groupBox4);
            this.pnlGeneratePO.Controls.Add(this.groupBox3);
            this.pnlGeneratePO.Controls.Add(this.groupBox2);
            this.pnlGeneratePO.Location = new System.Drawing.Point(585, 48);
            this.pnlGeneratePO.Name = "pnlGeneratePO";
            this.pnlGeneratePO.Size = new System.Drawing.Size(846, 700);
            this.pnlGeneratePO.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDeliveryTime);
            this.groupBox1.Controls.Add(this.cmbPOStatus);
            this.groupBox1.Controls.Add(this.cmbDeliveryStatus);
            this.groupBox1.Controls.Add(this.cmbDeptID);
            this.groupBox1.Controls.Add(this.cmbVendorID);
            this.groupBox1.Controls.Add(this.dtpPODate);
            this.groupBox1.Controls.Add(this.txtPOID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRefNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 251);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate PO";
            // 
            // dtpDeliveryTime
            // 
            this.dtpDeliveryTime.Enabled = false;
            this.dtpDeliveryTime.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.dtpDeliveryTime.Location = new System.Drawing.Point(144, 191);
            this.dtpDeliveryTime.Name = "dtpDeliveryTime";
            this.dtpDeliveryTime.Size = new System.Drawing.Size(251, 21);
            this.dtpDeliveryTime.TabIndex = 28;
            // 
            // cmbPOStatus
            // 
            this.cmbPOStatus.Enabled = false;
            this.cmbPOStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.cmbPOStatus.FormattingEnabled = true;
            this.cmbPOStatus.Location = new System.Drawing.Point(144, 218);
            this.cmbPOStatus.Name = "cmbPOStatus";
            this.cmbPOStatus.Size = new System.Drawing.Size(251, 22);
            this.cmbPOStatus.TabIndex = 27;
            // 
            // cmbDeliveryStatus
            // 
            this.cmbDeliveryStatus.Enabled = false;
            this.cmbDeliveryStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.cmbDeliveryStatus.FormattingEnabled = true;
            this.cmbDeliveryStatus.Location = new System.Drawing.Point(144, 164);
            this.cmbDeliveryStatus.Name = "cmbDeliveryStatus";
            this.cmbDeliveryStatus.Size = new System.Drawing.Size(251, 22);
            this.cmbDeliveryStatus.TabIndex = 26;
            // 
            // cmbDeptID
            // 
            this.cmbDeptID.Enabled = false;
            this.cmbDeptID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.cmbDeptID.FormattingEnabled = true;
            this.cmbDeptID.Location = new System.Drawing.Point(144, 137);
            this.cmbDeptID.Name = "cmbDeptID";
            this.cmbDeptID.Size = new System.Drawing.Size(251, 22);
            this.cmbDeptID.TabIndex = 25;
            // 
            // cmbVendorID
            // 
            this.cmbVendorID.Enabled = false;
            this.cmbVendorID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.cmbVendorID.FormattingEnabled = true;
            this.cmbVendorID.Location = new System.Drawing.Point(144, 110);
            this.cmbVendorID.Name = "cmbVendorID";
            this.cmbVendorID.Size = new System.Drawing.Size(251, 22);
            this.cmbVendorID.TabIndex = 24;
            // 
            // dtpPODate
            // 
            this.dtpPODate.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.dtpPODate.Location = new System.Drawing.Point(144, 58);
            this.dtpPODate.Name = "dtpPODate";
            this.dtpPODate.Size = new System.Drawing.Size(251, 21);
            this.dtpPODate.TabIndex = 23;
            // 
            // txtPOID
            // 
            this.txtPOID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.txtPOID.ForeColor = System.Drawing.Color.Black;
            this.txtPOID.Location = new System.Drawing.Point(144, 32);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.Size = new System.Drawing.Size(251, 21);
            this.txtPOID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "PO ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reference #";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vendor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "PO Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(19, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Approved By";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.txtRefNo.ForeColor = System.Drawing.Color.Black;
            this.txtRefNo.Location = new System.Drawing.Point(144, 84);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(251, 21);
            this.txtRefNo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(19, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Delivery Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(19, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Delivery Date";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvProduct);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(3, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(826, 370);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PO Details";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 22);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(820, 345);
            this.dgvProduct.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(419, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 62);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(126, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(278, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(138, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cmbDelStatus);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtDeliveredQty);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtOrderQty);
            this.groupBox2.Controls.Add(this.cmbProductID);
            this.groupBox2.Controls.Add(this.btnAddProducts);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(419, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 186);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Product";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(146, 153);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbDelStatus
            // 
            this.cmbDelStatus.Enabled = false;
            this.cmbDelStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.cmbDelStatus.FormattingEnabled = true;
            this.cmbDelStatus.Items.AddRange(new object[] {
            "",
            "Pending",
            "Delivered",
            "OnHold",
            "Issue In Product",
            "Returned"});
            this.cmbDelStatus.Location = new System.Drawing.Point(153, 107);
            this.cmbDelStatus.Name = "cmbDelStatus";
            this.cmbDelStatus.Size = new System.Drawing.Size(251, 22);
            this.cmbDelStatus.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(28, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Delivery Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(30, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Delivered Qty";
            // 
            // txtDeliveredQty
            // 
            this.txtDeliveredQty.Enabled = false;
            this.txtDeliveredQty.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.txtDeliveredQty.ForeColor = System.Drawing.Color.Black;
            this.txtDeliveredQty.Location = new System.Drawing.Point(153, 80);
            this.txtDeliveredQty.Name = "txtDeliveredQty";
            this.txtDeliveredQty.Size = new System.Drawing.Size(251, 21);
            this.txtDeliveredQty.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ordered Qty";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.txtOrderQty.ForeColor = System.Drawing.Color.Black;
            this.txtOrderQty.Location = new System.Drawing.Point(153, 53);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(251, 21);
            this.txtOrderQty.TabIndex = 28;
            // 
            // cmbProductID
            // 
            this.cmbProductID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.Location = new System.Drawing.Point(153, 25);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(251, 22);
            this.cmbProductID.TabIndex = 28;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.Location = new System.Drawing.Point(278, 153);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(126, 23);
            this.btnAddProducts.TabIndex = 22;
            this.btnAddProducts.Text = "Add Product to PO";
            this.btnAddProducts.UseVisualStyleBackColor = true;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(30, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Product ID";
            // 
            // pnlApprovePO
            // 
            this.pnlApprovePO.Controls.Add(this.groupBox7);
            this.pnlApprovePO.Controls.Add(this.groupBox6);
            this.pnlApprovePO.Controls.Add(this.groupBox5);
            this.pnlApprovePO.Location = new System.Drawing.Point(1049, 86);
            this.pnlApprovePO.Name = "pnlApprovePO";
            this.pnlApprovePO.Size = new System.Drawing.Size(569, 704);
            this.pnlApprovePO.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnDisapprove);
            this.groupBox7.Controls.Add(this.btnApprove);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Navy;
            this.groupBox7.Location = new System.Drawing.Point(421, 10);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(139, 103);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Actions";
            // 
            // btnDisapprove
            // 
            this.btnDisapprove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDisapprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisapprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisapprove.Location = new System.Drawing.Point(6, 62);
            this.btnDisapprove.Name = "btnDisapprove";
            this.btnDisapprove.Size = new System.Drawing.Size(126, 23);
            this.btnDisapprove.TabIndex = 2;
            this.btnDisapprove.Text = "DisApprove";
            this.btnDisapprove.UseVisualStyleBackColor = true;
            this.btnDisapprove.Click += new System.EventHandler(this.btnDisapprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(6, 30);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(126, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.APdgvProducts);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Navy;
            this.groupBox6.Location = new System.Drawing.Point(5, 298);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(555, 370);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "PO Details";
            // 
            // APdgvProducts
            // 
            this.APdgvProducts.AllowUserToAddRows = false;
            this.APdgvProducts.AllowUserToDeleteRows = false;
            this.APdgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.APdgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.APdgvProducts.Location = new System.Drawing.Point(3, 22);
            this.APdgvProducts.Name = "APdgvProducts";
            this.APdgvProducts.ReadOnly = true;
            this.APdgvProducts.Size = new System.Drawing.Size(549, 345);
            this.APdgvProducts.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.APbtnSearch);
            this.groupBox5.Controls.Add(this.APdtpDeliveryDate);
            this.groupBox5.Controls.Add(this.APcmbPOStatus);
            this.groupBox5.Controls.Add(this.APcmbDeliveryStatus);
            this.groupBox5.Controls.Add(this.APcmbApprovedBy);
            this.groupBox5.Controls.Add(this.ApcmbVendor);
            this.groupBox5.Controls.Add(this.APdtpPOdate);
            this.groupBox5.Controls.Add(this.APtxtPOID);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.APtxtRefNo);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(5, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 289);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PO Approvals";
            // 
            // APbtnSearch
            // 
            this.APbtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.APbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.APbtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APbtnSearch.Location = new System.Drawing.Point(269, 59);
            this.APbtnSearch.Name = "APbtnSearch";
            this.APbtnSearch.Size = new System.Drawing.Size(126, 23);
            this.APbtnSearch.TabIndex = 33;
            this.APbtnSearch.Text = "Search";
            this.APbtnSearch.UseVisualStyleBackColor = true;
            this.APbtnSearch.Click += new System.EventHandler(this.APbtnSearch_Click);
            // 
            // APdtpDeliveryDate
            // 
            this.APdtpDeliveryDate.Enabled = false;
            this.APdtpDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APdtpDeliveryDate.Location = new System.Drawing.Point(144, 223);
            this.APdtpDeliveryDate.Name = "APdtpDeliveryDate";
            this.APdtpDeliveryDate.Size = new System.Drawing.Size(251, 21);
            this.APdtpDeliveryDate.TabIndex = 28;
            // 
            // APcmbPOStatus
            // 
            this.APcmbPOStatus.Enabled = false;
            this.APcmbPOStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APcmbPOStatus.FormattingEnabled = true;
            this.APcmbPOStatus.Location = new System.Drawing.Point(144, 250);
            this.APcmbPOStatus.Name = "APcmbPOStatus";
            this.APcmbPOStatus.Size = new System.Drawing.Size(251, 22);
            this.APcmbPOStatus.TabIndex = 27;
            // 
            // APcmbDeliveryStatus
            // 
            this.APcmbDeliveryStatus.Enabled = false;
            this.APcmbDeliveryStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APcmbDeliveryStatus.FormattingEnabled = true;
            this.APcmbDeliveryStatus.Location = new System.Drawing.Point(144, 196);
            this.APcmbDeliveryStatus.Name = "APcmbDeliveryStatus";
            this.APcmbDeliveryStatus.Size = new System.Drawing.Size(251, 22);
            this.APcmbDeliveryStatus.TabIndex = 26;
            // 
            // APcmbApprovedBy
            // 
            this.APcmbApprovedBy.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APcmbApprovedBy.FormattingEnabled = true;
            this.APcmbApprovedBy.Location = new System.Drawing.Point(144, 169);
            this.APcmbApprovedBy.Name = "APcmbApprovedBy";
            this.APcmbApprovedBy.Size = new System.Drawing.Size(251, 22);
            this.APcmbApprovedBy.TabIndex = 25;
            // 
            // ApcmbVendor
            // 
            this.ApcmbVendor.Enabled = false;
            this.ApcmbVendor.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.ApcmbVendor.FormattingEnabled = true;
            this.ApcmbVendor.Location = new System.Drawing.Point(144, 142);
            this.ApcmbVendor.Name = "ApcmbVendor";
            this.ApcmbVendor.Size = new System.Drawing.Size(251, 22);
            this.ApcmbVendor.TabIndex = 24;
            // 
            // APdtpPOdate
            // 
            this.APdtpPOdate.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APdtpPOdate.Location = new System.Drawing.Point(144, 90);
            this.APdtpPOdate.Name = "APdtpPOdate";
            this.APdtpPOdate.Size = new System.Drawing.Size(251, 21);
            this.APdtpPOdate.TabIndex = 23;
            // 
            // APtxtPOID
            // 
            this.APtxtPOID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APtxtPOID.ForeColor = System.Drawing.Color.Black;
            this.APtxtPOID.Location = new System.Drawing.Point(144, 32);
            this.APtxtPOID.Name = "APtxtPOID";
            this.APtxtPOID.Size = new System.Drawing.Size(251, 21);
            this.APtxtPOID.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(19, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "PO ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(21, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(21, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Reference #";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(21, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 15);
            this.label18.TabIndex = 3;
            this.label18.Text = "Vendor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(19, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "PO Status";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(19, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 15);
            this.label20.TabIndex = 5;
            this.label20.Text = "Approved By";
            // 
            // APtxtRefNo
            // 
            this.APtxtRefNo.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.APtxtRefNo.ForeColor = System.Drawing.Color.Black;
            this.APtxtRefNo.Location = new System.Drawing.Point(144, 116);
            this.APtxtRefNo.Name = "APtxtRefNo";
            this.APtxtRefNo.Size = new System.Drawing.Size(251, 21);
            this.APtxtRefNo.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(19, 203);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 15);
            this.label21.TabIndex = 6;
            this.label21.Text = "Delivery Status";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(19, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 15);
            this.label22.TabIndex = 7;
            this.label22.Text = "Delivery Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePOToolStripMenuItem,
            this.approvePOToolStripMenuItem,
            this.assignVendorToolStripMenuItem,
            this.pODeliveryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generatePOToolStripMenuItem
            // 
            this.generatePOToolStripMenuItem.Name = "generatePOToolStripMenuItem";
            this.generatePOToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.generatePOToolStripMenuItem.Text = "GeneratePO";
            this.generatePOToolStripMenuItem.Click += new System.EventHandler(this.generatePOToolStripMenuItem_Click);
            // 
            // approvePOToolStripMenuItem
            // 
            this.approvePOToolStripMenuItem.Name = "approvePOToolStripMenuItem";
            this.approvePOToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.approvePOToolStripMenuItem.Text = "Approve PO";
            this.approvePOToolStripMenuItem.Click += new System.EventHandler(this.approvePOToolStripMenuItem_Click);
            // 
            // assignVendorToolStripMenuItem
            // 
            this.assignVendorToolStripMenuItem.Name = "assignVendorToolStripMenuItem";
            this.assignVendorToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.assignVendorToolStripMenuItem.Text = "Assign Vendor";
            this.assignVendorToolStripMenuItem.Click += new System.EventHandler(this.assignVendorToolStripMenuItem_Click);
            // 
            // pODeliveryToolStripMenuItem
            // 
            this.pODeliveryToolStripMenuItem.Name = "pODeliveryToolStripMenuItem";
            this.pODeliveryToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.pODeliveryToolStripMenuItem.Text = "PO Delivery / GRN";
            this.pODeliveryToolStripMenuItem.Click += new System.EventHandler(this.pODeliveryToolStripMenuItem_Click);
            // 
            // pnlAssignVendor
            // 
            this.pnlAssignVendor.Controls.Add(this.groupBox8);
            this.pnlAssignVendor.Controls.Add(this.groupBox9);
            this.pnlAssignVendor.Controls.Add(this.groupBox10);
            this.pnlAssignVendor.Location = new System.Drawing.Point(987, 206);
            this.pnlAssignVendor.Name = "pnlAssignVendor";
            this.pnlAssignVendor.Size = new System.Drawing.Size(569, 704);
            this.pnlAssignVendor.TabIndex = 33;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnAssignVenor);
            this.groupBox8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Navy;
            this.groupBox8.Location = new System.Drawing.Point(421, 10);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(139, 75);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Actions";
            // 
            // btnAssignVenor
            // 
            this.btnAssignVenor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAssignVenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignVenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignVenor.Location = new System.Drawing.Point(6, 30);
            this.btnAssignVenor.Name = "btnAssignVenor";
            this.btnAssignVenor.Size = new System.Drawing.Size(126, 23);
            this.btnAssignVenor.TabIndex = 1;
            this.btnAssignVenor.Text = "Assign Vendor";
            this.btnAssignVenor.UseVisualStyleBackColor = true;
            this.btnAssignVenor.Click += new System.EventHandler(this.btnAssignVenor_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.AdgvProducts);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.Navy;
            this.groupBox9.Location = new System.Drawing.Point(5, 298);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(555, 370);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "PO Details";
            // 
            // AdgvProducts
            // 
            this.AdgvProducts.AllowUserToAddRows = false;
            this.AdgvProducts.AllowUserToDeleteRows = false;
            this.AdgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdgvProducts.Location = new System.Drawing.Point(3, 22);
            this.AdgvProducts.Name = "AdgvProducts";
            this.AdgvProducts.ReadOnly = true;
            this.AdgvProducts.Size = new System.Drawing.Size(549, 345);
            this.AdgvProducts.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.AssignbtnSearch);
            this.groupBox10.Controls.Add(this.AdtpDeliveryDate);
            this.groupBox10.Controls.Add(this.AcmbPOStatus);
            this.groupBox10.Controls.Add(this.AcmbDeliveryStatus);
            this.groupBox10.Controls.Add(this.AcmbApprovedBy);
            this.groupBox10.Controls.Add(this.AcmbVendor);
            this.groupBox10.Controls.Add(this.AdtpPODate);
            this.groupBox10.Controls.Add(this.AtxtPOID);
            this.groupBox10.Controls.Add(this.label2);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.AtxtRefNo);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.Navy;
            this.groupBox10.Location = new System.Drawing.Point(5, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(410, 289);
            this.groupBox10.TabIndex = 29;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "PO Assign Vendor";
            // 
            // AssignbtnSearch
            // 
            this.AssignbtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AssignbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignbtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignbtnSearch.Location = new System.Drawing.Point(269, 59);
            this.AssignbtnSearch.Name = "AssignbtnSearch";
            this.AssignbtnSearch.Size = new System.Drawing.Size(126, 23);
            this.AssignbtnSearch.TabIndex = 33;
            this.AssignbtnSearch.Text = "Search";
            this.AssignbtnSearch.UseVisualStyleBackColor = true;
            this.AssignbtnSearch.Click += new System.EventHandler(this.AssignbtnSearch_Click);
            // 
            // AdtpDeliveryDate
            // 
            this.AdtpDeliveryDate.Enabled = false;
            this.AdtpDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AdtpDeliveryDate.Location = new System.Drawing.Point(144, 223);
            this.AdtpDeliveryDate.Name = "AdtpDeliveryDate";
            this.AdtpDeliveryDate.Size = new System.Drawing.Size(251, 21);
            this.AdtpDeliveryDate.TabIndex = 28;
            // 
            // AcmbPOStatus
            // 
            this.AcmbPOStatus.Enabled = false;
            this.AcmbPOStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AcmbPOStatus.FormattingEnabled = true;
            this.AcmbPOStatus.Location = new System.Drawing.Point(144, 250);
            this.AcmbPOStatus.Name = "AcmbPOStatus";
            this.AcmbPOStatus.Size = new System.Drawing.Size(251, 22);
            this.AcmbPOStatus.TabIndex = 27;
            // 
            // AcmbDeliveryStatus
            // 
            this.AcmbDeliveryStatus.Enabled = false;
            this.AcmbDeliveryStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AcmbDeliveryStatus.FormattingEnabled = true;
            this.AcmbDeliveryStatus.Location = new System.Drawing.Point(144, 196);
            this.AcmbDeliveryStatus.Name = "AcmbDeliveryStatus";
            this.AcmbDeliveryStatus.Size = new System.Drawing.Size(251, 22);
            this.AcmbDeliveryStatus.TabIndex = 26;
            // 
            // AcmbApprovedBy
            // 
            this.AcmbApprovedBy.Enabled = false;
            this.AcmbApprovedBy.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AcmbApprovedBy.FormattingEnabled = true;
            this.AcmbApprovedBy.Location = new System.Drawing.Point(144, 169);
            this.AcmbApprovedBy.Name = "AcmbApprovedBy";
            this.AcmbApprovedBy.Size = new System.Drawing.Size(251, 22);
            this.AcmbApprovedBy.TabIndex = 25;
            // 
            // AcmbVendor
            // 
            this.AcmbVendor.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AcmbVendor.FormattingEnabled = true;
            this.AcmbVendor.Location = new System.Drawing.Point(144, 142);
            this.AcmbVendor.Name = "AcmbVendor";
            this.AcmbVendor.Size = new System.Drawing.Size(251, 22);
            this.AcmbVendor.TabIndex = 24;
            // 
            // AdtpPODate
            // 
            this.AdtpPODate.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AdtpPODate.Location = new System.Drawing.Point(144, 90);
            this.AdtpPODate.Name = "AdtpPODate";
            this.AdtpPODate.Size = new System.Drawing.Size(251, 21);
            this.AdtpPODate.TabIndex = 23;
            // 
            // AtxtPOID
            // 
            this.AtxtPOID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AtxtPOID.ForeColor = System.Drawing.Color.Black;
            this.AtxtPOID.Location = new System.Drawing.Point(144, 32);
            this.AtxtPOID.Name = "AtxtPOID";
            this.AtxtPOID.Size = new System.Drawing.Size(251, 21);
            this.AtxtPOID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "PO ID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(21, 95);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 15);
            this.label23.TabIndex = 1;
            this.label23.Text = "Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(21, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "Reference #";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(21, 149);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 15);
            this.label25.TabIndex = 3;
            this.label25.Text = "Vendor";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(19, 257);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 15);
            this.label26.TabIndex = 4;
            this.label26.Text = "PO Status";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(19, 176);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 15);
            this.label27.TabIndex = 5;
            this.label27.Text = "Approved By";
            // 
            // AtxtRefNo
            // 
            this.AtxtRefNo.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.AtxtRefNo.ForeColor = System.Drawing.Color.Black;
            this.AtxtRefNo.Location = new System.Drawing.Point(144, 116);
            this.AtxtRefNo.Name = "AtxtRefNo";
            this.AtxtRefNo.Size = new System.Drawing.Size(251, 21);
            this.AtxtRefNo.TabIndex = 12;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(19, 203);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 15);
            this.label28.TabIndex = 6;
            this.label28.Text = "Delivery Status";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(19, 230);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 15);
            this.label29.TabIndex = 7;
            this.label29.Text = "Delivery Date";
            // 
            // pnlPODelivery
            // 
            this.pnlPODelivery.Controls.Add(this.groupBox11);
            this.pnlPODelivery.Controls.Add(this.groupBox12);
            this.pnlPODelivery.Controls.Add(this.groupBox14);
            this.pnlPODelivery.Location = new System.Drawing.Point(0, 27);
            this.pnlPODelivery.Name = "pnlPODelivery";
            this.pnlPODelivery.Size = new System.Drawing.Size(579, 700);
            this.pnlPODelivery.TabIndex = 31;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.GRNdgvproducts);
            this.groupBox11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.ForeColor = System.Drawing.Color.Navy;
            this.groupBox11.Location = new System.Drawing.Point(3, 289);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(573, 342);
            this.groupBox11.TabIndex = 30;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "PO Details";
            // 
            // GRNdgvproducts
            // 
            this.GRNdgvproducts.AllowUserToAddRows = false;
            this.GRNdgvproducts.AllowUserToDeleteRows = false;
            this.GRNdgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRNdgvproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRNdgvproducts.Location = new System.Drawing.Point(3, 22);
            this.GRNdgvproducts.Name = "GRNdgvproducts";
            this.GRNdgvproducts.ReadOnly = true;
            this.GRNdgvproducts.Size = new System.Drawing.Size(567, 317);
            this.GRNdgvproducts.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.GRNbtnSave);
            this.groupBox12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.ForeColor = System.Drawing.Color.Navy;
            this.groupBox12.Location = new System.Drawing.Point(419, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(145, 69);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Actions";
            // 
            // GRNbtnSave
            // 
            this.GRNbtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GRNbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRNbtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNbtnSave.Location = new System.Drawing.Point(6, 27);
            this.GRNbtnSave.Name = "GRNbtnSave";
            this.GRNbtnSave.Size = new System.Drawing.Size(126, 23);
            this.GRNbtnSave.TabIndex = 1;
            this.GRNbtnSave.Text = "Delivered";
            this.GRNbtnSave.UseVisualStyleBackColor = true;
            this.GRNbtnSave.Click += new System.EventHandler(this.GRNbtnSave_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.GRNbtnSearch);
            this.groupBox14.Controls.Add(this.GRNdtpDeliveryDate);
            this.groupBox14.Controls.Add(this.GRNcmbStatus);
            this.groupBox14.Controls.Add(this.GRNcmbDeliveryStatus);
            this.groupBox14.Controls.Add(this.GRNcmbApprovedBy);
            this.groupBox14.Controls.Add(this.GRNtxtVendor);
            this.groupBox14.Controls.Add(this.GRNdtpPOID);
            this.groupBox14.Controls.Add(this.GRNtxtPOID);
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.label34);
            this.groupBox14.Controls.Add(this.label35);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Controls.Add(this.label37);
            this.groupBox14.Controls.Add(this.label38);
            this.groupBox14.Controls.Add(this.GRNtxtRefNo);
            this.groupBox14.Controls.Add(this.label39);
            this.groupBox14.Controls.Add(this.label40);
            this.groupBox14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.ForeColor = System.Drawing.Color.Navy;
            this.groupBox14.Location = new System.Drawing.Point(3, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(410, 280);
            this.groupBox14.TabIndex = 24;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "PO Delivery / GRN";
            // 
            // GRNbtnSearch
            // 
            this.GRNbtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GRNbtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRNbtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRNbtnSearch.Location = new System.Drawing.Point(269, 59);
            this.GRNbtnSearch.Name = "GRNbtnSearch";
            this.GRNbtnSearch.Size = new System.Drawing.Size(126, 23);
            this.GRNbtnSearch.TabIndex = 34;
            this.GRNbtnSearch.Text = "Search";
            this.GRNbtnSearch.UseVisualStyleBackColor = true;
            this.GRNbtnSearch.Click += new System.EventHandler(this.GRNbtnSearch_Click);
            // 
            // GRNdtpDeliveryDate
            // 
            this.GRNdtpDeliveryDate.Enabled = false;
            this.GRNdtpDeliveryDate.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNdtpDeliveryDate.Location = new System.Drawing.Point(144, 223);
            this.GRNdtpDeliveryDate.Name = "GRNdtpDeliveryDate";
            this.GRNdtpDeliveryDate.Size = new System.Drawing.Size(251, 21);
            this.GRNdtpDeliveryDate.TabIndex = 28;
            // 
            // GRNcmbStatus
            // 
            this.GRNcmbStatus.Enabled = false;
            this.GRNcmbStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNcmbStatus.FormattingEnabled = true;
            this.GRNcmbStatus.Location = new System.Drawing.Point(144, 250);
            this.GRNcmbStatus.Name = "GRNcmbStatus";
            this.GRNcmbStatus.Size = new System.Drawing.Size(251, 22);
            this.GRNcmbStatus.TabIndex = 27;
            // 
            // GRNcmbDeliveryStatus
            // 
            this.GRNcmbDeliveryStatus.Enabled = false;
            this.GRNcmbDeliveryStatus.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNcmbDeliveryStatus.FormattingEnabled = true;
            this.GRNcmbDeliveryStatus.Items.AddRange(new object[] {
            "",
            "Delivered"});
            this.GRNcmbDeliveryStatus.Location = new System.Drawing.Point(144, 196);
            this.GRNcmbDeliveryStatus.Name = "GRNcmbDeliveryStatus";
            this.GRNcmbDeliveryStatus.Size = new System.Drawing.Size(251, 22);
            this.GRNcmbDeliveryStatus.TabIndex = 26;
            // 
            // GRNcmbApprovedBy
            // 
            this.GRNcmbApprovedBy.Enabled = false;
            this.GRNcmbApprovedBy.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNcmbApprovedBy.FormattingEnabled = true;
            this.GRNcmbApprovedBy.Location = new System.Drawing.Point(144, 169);
            this.GRNcmbApprovedBy.Name = "GRNcmbApprovedBy";
            this.GRNcmbApprovedBy.Size = new System.Drawing.Size(251, 22);
            this.GRNcmbApprovedBy.TabIndex = 25;
            // 
            // GRNtxtVendor
            // 
            this.GRNtxtVendor.Enabled = false;
            this.GRNtxtVendor.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNtxtVendor.FormattingEnabled = true;
            this.GRNtxtVendor.Location = new System.Drawing.Point(144, 142);
            this.GRNtxtVendor.Name = "GRNtxtVendor";
            this.GRNtxtVendor.Size = new System.Drawing.Size(251, 22);
            this.GRNtxtVendor.TabIndex = 24;
            // 
            // GRNdtpPOID
            // 
            this.GRNdtpPOID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNdtpPOID.Location = new System.Drawing.Point(144, 90);
            this.GRNdtpPOID.Name = "GRNdtpPOID";
            this.GRNdtpPOID.Size = new System.Drawing.Size(251, 21);
            this.GRNdtpPOID.TabIndex = 23;
            // 
            // GRNtxtPOID
            // 
            this.GRNtxtPOID.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNtxtPOID.ForeColor = System.Drawing.Color.Black;
            this.GRNtxtPOID.Location = new System.Drawing.Point(144, 32);
            this.GRNtxtPOID.Name = "GRNtxtPOID";
            this.GRNtxtPOID.Size = new System.Drawing.Size(251, 21);
            this.GRNtxtPOID.TabIndex = 10;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(19, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(39, 15);
            this.label33.TabIndex = 0;
            this.label33.Text = "PO ID";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(21, 95);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(30, 15);
            this.label34.TabIndex = 1;
            this.label34.Text = "Date";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(21, 122);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 15);
            this.label35.TabIndex = 2;
            this.label35.Text = "Reference #";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(21, 149);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 15);
            this.label36.TabIndex = 3;
            this.label36.Text = "Vendor";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(19, 257);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 15);
            this.label37.TabIndex = 4;
            this.label37.Text = "PO Status";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(19, 176);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 15);
            this.label38.TabIndex = 5;
            this.label38.Text = "Approved By";
            // 
            // GRNtxtRefNo
            // 
            this.GRNtxtRefNo.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.GRNtxtRefNo.ForeColor = System.Drawing.Color.Black;
            this.GRNtxtRefNo.Location = new System.Drawing.Point(144, 116);
            this.GRNtxtRefNo.Name = "GRNtxtRefNo";
            this.GRNtxtRefNo.Size = new System.Drawing.Size(251, 21);
            this.GRNtxtRefNo.TabIndex = 12;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(19, 203);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(80, 15);
            this.label39.TabIndex = 6;
            this.label39.Text = "Delivery Status";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 8.5F, System.Drawing.FontStyle.Italic);
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(19, 230);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(74, 15);
            this.label40.TabIndex = 7;
            this.label40.Text = "Delivery Date";
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 661);
            this.Controls.Add(this.pnlGeneratePO);
            this.Controls.Add(this.pnlPODelivery);
            this.Controls.Add(this.pnlAssignVendor);
            this.Controls.Add(this.pnlApprovePO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPO";
            this.Text = "frmPO";
            this.Load += new System.EventHandler(this.frmPO_Load);
            this.pnlGeneratePO.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlApprovePO.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.APdgvProducts)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAssignVendor.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdgvProducts)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.pnlPODelivery.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRNdgvproducts)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGeneratePO;
        private System.Windows.Forms.Panel pnlApprovePO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generatePOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approvePOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pODeliveryToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPOID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPODate;
        private System.Windows.Forms.ComboBox cmbVendorID;
        private System.Windows.Forms.ComboBox cmbDeptID;
        private System.Windows.Forms.ComboBox cmbPOStatus;
        private System.Windows.Forms.ComboBox cmbDeliveryStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDelStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDeliveredQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker APdtpDeliveryDate;
        private System.Windows.Forms.ComboBox APcmbPOStatus;
        private System.Windows.Forms.ComboBox APcmbDeliveryStatus;
        private System.Windows.Forms.ComboBox APcmbApprovedBy;
        private System.Windows.Forms.ComboBox ApcmbVendor;
        private System.Windows.Forms.DateTimePicker APdtpPOdate;
        private System.Windows.Forms.TextBox APtxtPOID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox APtxtRefNo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button APbtnSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView APdgvProducts;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDisapprove;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Panel pnlAssignVendor;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnAssignVenor;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView AdgvProducts;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button AssignbtnSearch;
        private System.Windows.Forms.DateTimePicker AdtpDeliveryDate;
        private System.Windows.Forms.ComboBox AcmbPOStatus;
        private System.Windows.Forms.ComboBox AcmbDeliveryStatus;
        private System.Windows.Forms.ComboBox AcmbApprovedBy;
        private System.Windows.Forms.ComboBox AcmbVendor;
        private System.Windows.Forms.DateTimePicker AdtpPODate;
        private System.Windows.Forms.TextBox AtxtPOID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox AtxtRefNo;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel pnlPODelivery;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView GRNdgvproducts;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button GRNbtnSave;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.DateTimePicker GRNdtpDeliveryDate;
        private System.Windows.Forms.ComboBox GRNcmbStatus;
        private System.Windows.Forms.ComboBox GRNcmbDeliveryStatus;
        private System.Windows.Forms.ComboBox GRNcmbApprovedBy;
        private System.Windows.Forms.ComboBox GRNtxtVendor;
        private System.Windows.Forms.DateTimePicker GRNdtpPOID;
        private System.Windows.Forms.TextBox GRNtxtPOID;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox GRNtxtRefNo;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button GRNbtnSearch;
    }
}