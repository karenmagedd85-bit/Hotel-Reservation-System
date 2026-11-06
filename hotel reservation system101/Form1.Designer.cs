namespace hotel_reservation_system101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblsubtitle = new System.Windows.Forms.Label();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlsidebar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.picDashboard = new System.Windows.Forms.PictureBox();
            this.picRooms = new System.Windows.Forms.PictureBox();
            this.picPayment = new System.Windows.Forms.PictureBox();
            this.picReports = new System.Windows.Forms.PictureBox();
            this.picReservations = new System.Windows.Forms.PictureBox();
            this.picCustomers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(307, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "rooms management";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblsubtitle
            // 
            this.lblsubtitle.AutoSize = true;
            this.lblsubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitle.Location = new System.Drawing.Point(317, 80);
            this.lblsubtitle.Name = "lblsubtitle";
            this.lblsubtitle.Size = new System.Drawing.Size(220, 17);
            this.lblsubtitle.TabIndex = 1;
            this.lblsubtitle.Text = "manage hotel rooms and availability";
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomnumber.Location = new System.Drawing.Point(317, 119);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(96, 17);
            this.lblroomnumber.TabIndex = 2;
            this.lblroomnumber.Text = "Room number";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(416, 116);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(180, 20);
            this.txtRoomNumber.TabIndex = 3;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.txtroomnumber_TextChanged);
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(317, 146);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(72, 17);
            this.lblroomtype.TabIndex = 4;
            this.lblroomtype.Text = "room type";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Suite"});
            this.cmbRoomType.Location = new System.Drawing.Point(416, 142);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomType.TabIndex = 5;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(317, 174);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(99, 17);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "price per night";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(416, 174);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(317, 204);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(86, 17);
            this.lblstatus.TabIndex = 8;
            this.lblstatus.Text = "Room Status";
            this.lblstatus.Click += new System.EventHandler(this.lblstatus_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Reserved",
            "Maintenance"});
            this.cmbStatus.Location = new System.Drawing.Point(416, 200);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(416, 238);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 40);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Add room";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(694, 238);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 40);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(557, 238);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 40);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(825, 238);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 40);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomNumber,
            this.colRoomType,
            this.colPrice,
            this.colStatus});
            this.dgvRooms.Location = new System.Drawing.Point(346, 314);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(850, 280);
            this.dgvRooms.TabIndex = 14;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.HeaderText = "Room Number";
            this.colRoomNumber.Name = "colRoomNumber";
            this.colRoomNumber.ReadOnly = true;
            // 
            // colRoomType
            // 
            this.colRoomType.HeaderText = "Room Type";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(343, 285);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(90, 17);
            this.lblsearch.TabIndex = 15;
            this.lblsearch.Text = "search rooms";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(448, 285);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // pnlsidebar
            // 
            this.pnlsidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.pnlsidebar.Controls.Add(this.picCustomers);
            this.pnlsidebar.Controls.Add(this.picReservations);
            this.pnlsidebar.Controls.Add(this.picReports);
            this.pnlsidebar.Controls.Add(this.picPayment);
            this.pnlsidebar.Controls.Add(this.picRooms);
            this.pnlsidebar.Controls.Add(this.picDashboard);
            this.pnlsidebar.Controls.Add(this.btnReports);
            this.pnlsidebar.Controls.Add(this.btnCustomers);
            this.pnlsidebar.Controls.Add(this.btnPayment);
            this.pnlsidebar.Controls.Add(this.btnReservations);
            this.pnlsidebar.Controls.Add(this.button2);
            this.pnlsidebar.Controls.Add(this.btnRooms);
            this.pnlsidebar.Controls.Add(this.btnDashboard);
            this.pnlsidebar.Controls.Add(this.piclogo);
            this.pnlsidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlsidebar.Name = "pnlsidebar";
            this.pnlsidebar.Size = new System.Drawing.Size(293, 780);
            this.pnlsidebar.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(607, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // piclogo
            // 
            this.piclogo.BackColor = System.Drawing.Color.Transparent;
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(21, 14);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(240, 240);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 19;
            this.piclogo.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(36, 270);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(257, 50);
            this.btnDashboard.TabIndex = 19;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.White;
            this.btnRooms.Location = new System.Drawing.Point(36, 320);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(257, 50);
            this.btnRooms.TabIndex = 20;
            this.btnRooms.Text = "Room Management";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(35, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Customer Management";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnReservations
            // 
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.White;
            this.btnReservations.Location = new System.Drawing.Point(36, 423);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(254, 50);
            this.btnReservations.TabIndex = 22;
            this.btnReservations.Text = "Reservation Management";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(36, 470);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(254, 50);
            this.btnPayment.TabIndex = 23;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(36, 370);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(257, 50);
            this.btnCustomers.TabIndex = 24;
            this.btnCustomers.Text = "Customer Management";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(36, 520);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(254, 50);
            this.btnReports.TabIndex = 25;
            this.btnReports.Text = "Reports And Statistics";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // picDashboard
            // 
            this.picDashboard.BackColor = System.Drawing.Color.Transparent;
            this.picDashboard.Image = ((System.Drawing.Image)(resources.GetObject("picDashboard.Image")));
            this.picDashboard.Location = new System.Drawing.Point(10, 280);
            this.picDashboard.Name = "picDashboard";
            this.picDashboard.Size = new System.Drawing.Size(28, 28);
            this.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDashboard.TabIndex = 26;
            this.picDashboard.TabStop = false;
            // 
            // picRooms
            // 
            this.picRooms.BackColor = System.Drawing.Color.Transparent;
            this.picRooms.Image = ((System.Drawing.Image)(resources.GetObject("picRooms.Image")));
            this.picRooms.Location = new System.Drawing.Point(10, 330);
            this.picRooms.Name = "picRooms";
            this.picRooms.Size = new System.Drawing.Size(28, 28);
            this.picRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRooms.TabIndex = 27;
            this.picRooms.TabStop = false;
            // 
            // picPayment
            // 
            this.picPayment.BackColor = System.Drawing.Color.Transparent;
            this.picPayment.Image = ((System.Drawing.Image)(resources.GetObject("picPayment.Image")));
            this.picPayment.Location = new System.Drawing.Point(10, 480);
            this.picPayment.Name = "picPayment";
            this.picPayment.Size = new System.Drawing.Size(28, 28);
            this.picPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPayment.TabIndex = 28;
            this.picPayment.TabStop = false;
            // 
            // picReports
            // 
            this.picReports.BackColor = System.Drawing.Color.Transparent;
            this.picReports.Image = ((System.Drawing.Image)(resources.GetObject("picReports.Image")));
            this.picReports.Location = new System.Drawing.Point(10, 530);
            this.picReports.Name = "picReports";
            this.picReports.Size = new System.Drawing.Size(28, 28);
            this.picReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReports.TabIndex = 29;
            this.picReports.TabStop = false;
            // 
            // picReservations
            // 
            this.picReservations.BackColor = System.Drawing.Color.Transparent;
            this.picReservations.Image = ((System.Drawing.Image)(resources.GetObject("picReservations.Image")));
            this.picReservations.Location = new System.Drawing.Point(10, 430);
            this.picReservations.Name = "picReservations";
            this.picReservations.Size = new System.Drawing.Size(28, 28);
            this.picReservations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReservations.TabIndex = 30;
            this.picReservations.TabStop = false;
            // 
            // picCustomers
            // 
            this.picCustomers.BackColor = System.Drawing.Color.Transparent;
            this.picCustomers.Image = ((System.Drawing.Image)(resources.GetObject("picCustomers.Image")));
            this.picCustomers.Location = new System.Drawing.Point(10, 380);
            this.picCustomers.Name = "picCustomers";
            this.picCustomers.Size = new System.Drawing.Size(28, 28);
            this.picCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomers.TabIndex = 31;
            this.picCustomers.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 781);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlsidebar);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblroomnumber);
            this.Controls.Add(this.lblsubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblsubtitle;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlsidebar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.PictureBox picCustomers;
        private System.Windows.Forms.PictureBox picReservations;
        private System.Windows.Forms.PictureBox picReports;
        private System.Windows.Forms.PictureBox picPayment;
        private System.Windows.Forms.PictureBox picRooms;
        private System.Windows.Forms.PictureBox picDashboard;
    }
}

