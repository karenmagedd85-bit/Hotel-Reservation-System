namespace HotelSystem
{
    partial class RoomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      //// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomsForm));
            lblTitle = new Label();
            lblsubtitle = new Label();
            lblroomnumber = new Label();
            txtRoomNumber = new TextBox();
            lblroomtype = new Label();
            cmbRoomType = new ComboBox();
            lblprice = new Label();
            txtPrice = new TextBox();
            lblstatus = new Label();
            cmbStatus = new ComboBox();
            btnadd = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnclear = new Button();
            dgvRooms = new DataGridView();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colRoomType = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblsearch = new Label();
            txtSearch = new TextBox();
            pnlsidebar = new Panel();
            piclogout = new PictureBox();
            btnlogout = new Button();
            picCustomers = new PictureBox();
            picReservations = new PictureBox();
            picReports = new PictureBox();
            picPayment = new PictureBox();
            picRooms = new PictureBox();
            picDashboard = new PictureBox();
            btnReports = new Button();
            btnCustomers = new Button();
            btnPayment = new Button();
            btnReservations = new Button();
            btnRooms = new Button();
            btnDashboard = new Button();
            piclogo = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlHeaderRoomManagement = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            pnlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            pnlHeaderRoomManagement.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(381, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rooms Management";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblsubtitle
            // 
            lblsubtitle.AutoSize = true;
            lblsubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsubtitle.ForeColor = Color.Gray;
            lblsubtitle.Location = new Point(25, 60);
            lblsubtitle.Margin = new Padding(4, 0, 4, 0);
            lblsubtitle.Name = "lblsubtitle";
            lblsubtitle.Size = new Size(287, 23);
            lblsubtitle.TabIndex = 1;
            lblsubtitle.Text = "manage hotel rooms and availability";
            // 
            // lblroomnumber
            // 
            lblroomnumber.AutoSize = true;
            lblroomnumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblroomnumber.Location = new Point(423, 183);
            lblroomnumber.Margin = new Padding(4, 0, 4, 0);
            lblroomnumber.Name = "lblroomnumber";
            lblroomnumber.Size = new Size(125, 23);
            lblroomnumber.TabIndex = 2;
            lblroomnumber.Text = "Room number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Location = new Point(555, 178);
            txtRoomNumber.Margin = new Padding(4, 5, 4, 5);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(239, 27);
            txtRoomNumber.TabIndex = 3;
            txtRoomNumber.TextChanged += txtroomnumber_TextChanged;
            // 
            // lblroomtype
            // 
            lblroomtype.AutoSize = true;
            lblroomtype.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblroomtype.Location = new Point(423, 225);
            lblroomtype.Margin = new Padding(4, 0, 4, 0);
            lblroomtype.Name = "lblroomtype";
            lblroomtype.Size = new Size(94, 23);
            lblroomtype.TabIndex = 4;
            lblroomtype.Text = "room type";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double", "Suite" });
            cmbRoomType.Location = new Point(555, 218);
            cmbRoomType.Margin = new Padding(4, 5, 4, 5);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(160, 28);
            cmbRoomType.TabIndex = 5;
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblprice.Location = new Point(423, 268);
            lblprice.Margin = new Padding(4, 0, 4, 0);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(130, 23);
            lblprice.TabIndex = 6;
            lblprice.Text = "price per night";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(555, 268);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(132, 27);
            txtPrice.TabIndex = 7;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.Location = new Point(423, 314);
            lblstatus.Margin = new Padding(4, 0, 4, 0);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(112, 23);
            lblstatus.TabIndex = 8;
            lblstatus.Text = "Room Status";
            lblstatus.Click += lblstatus_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Reserved", "Maintenance" });
            cmbStatus.Location = new Point(555, 308);
            cmbStatus.Margin = new Padding(4, 5, 4, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(160, 28);
            cmbStatus.TabIndex = 9;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(23, 107, 135);
            btnadd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(555, 366);
            btnadd.Margin = new Padding(4, 5, 4, 5);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(147, 62);
            btnadd.TabIndex = 10;
            btnadd.Text = "Add room";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(23, 107, 135);
            btndelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.White;
            btndelete.Location = new Point(925, 366);
            btndelete.Margin = new Padding(4, 5, 4, 5);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(147, 62);
            btndelete.TabIndex = 11;
            btndelete.Text = "delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(23, 107, 135);
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = Color.White;
            btnupdate.Location = new Point(743, 366);
            btnupdate.Margin = new Padding(4, 5, 4, 5);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(147, 62);
            btnupdate.TabIndex = 12;
            btnupdate.Text = "update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(23, 107, 135);
            btnclear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.ForeColor = Color.White;
            btnclear.Location = new Point(1100, 366);
            btnclear.Margin = new Padding(4, 5, 4, 5);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(147, 62);
            btnclear.TabIndex = 13;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Columns.AddRange(new DataGridViewColumn[] { colRoomNumber, colRoomType, colPrice, colStatus });
            dgvRooms.Location = new Point(461, 483);
            dgvRooms.Margin = new Padding(4, 5, 4, 5);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(1133, 431);
            dgvRooms.TabIndex = 14;
            // 
            // colRoomNumber
            // 
            colRoomNumber.HeaderText = "Room Number";
            colRoomNumber.MinimumWidth = 6;
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colRoomType
            // 
            colRoomType.HeaderText = "Room Type";
            colRoomType.MinimumWidth = 6;
            colRoomType.Name = "colRoomType";
            colRoomType.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsearch.Location = new Point(457, 438);
            lblsearch.Margin = new Padding(4, 0, 4, 0);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(115, 23);
            lblsearch.TabIndex = 15;
            lblsearch.Text = "search rooms";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(597, 438);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(132, 27);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtsearch_TextChanged;
            // 
            // pnlsidebar
            // 
            pnlsidebar.BackColor = Color.FromArgb(6, 40, 62);
            pnlsidebar.Controls.Add(piclogout);
            pnlsidebar.Controls.Add(btnlogout);
            pnlsidebar.Controls.Add(picCustomers);
            pnlsidebar.Controls.Add(picReservations);
            pnlsidebar.Controls.Add(picReports);
            pnlsidebar.Controls.Add(picPayment);
            pnlsidebar.Controls.Add(picRooms);
            pnlsidebar.Controls.Add(picDashboard);
            pnlsidebar.Controls.Add(btnReports);
            pnlsidebar.Controls.Add(btnCustomers);
            pnlsidebar.Controls.Add(btnPayment);
            pnlsidebar.Controls.Add(btnReservations);
            pnlsidebar.Controls.Add(btnRooms);
            pnlsidebar.Controls.Add(btnDashboard);
            pnlsidebar.Controls.Add(piclogo);
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Location = new Point(0, 0);
            pnlsidebar.Margin = new Padding(4, 5, 4, 5);
            pnlsidebar.Name = "pnlsidebar";
            pnlsidebar.Size = new Size(400, 1163);
            pnlsidebar.TabIndex = 17;
            pnlsidebar.Paint += pnlsidebar_Paint;
            // 
            // piclogout
            // 
            piclogout.Image = (Image)resources.GetObject("piclogout.Image");
            piclogout.Location = new Point(10, 1050);
            piclogout.Margin = new Padding(3, 4, 3, 4);
            piclogout.Name = "piclogout";
            piclogout.Size = new Size(35, 35);
            piclogout.SizeMode = PictureBoxSizeMode.Zoom;
            piclogout.TabIndex = 32;
            piclogout.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.AutoSize = true;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(50, 1037);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(288, 62);
            btnlogout.TabIndex = 17;
            btnlogout.Text = "Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = true;
            // 
            // picCustomers
            // 
            picCustomers.BackColor = Color.Transparent;
            picCustomers.Image = (Image)resources.GetObject("picCustomers.Image");
            picCustomers.Location = new Point(10, 620);
            picCustomers.Margin = new Padding(4, 5, 4, 5);
            picCustomers.Name = "picCustomers";
            picCustomers.Size = new Size(35, 35);
            picCustomers.SizeMode = PictureBoxSizeMode.Zoom;
            picCustomers.TabIndex = 31;
            picCustomers.TabStop = false;
            // 
            // picReservations
            // 
            picReservations.BackColor = Color.Transparent;
            picReservations.Image = (Image)resources.GetObject("picReservations.Image");
            picReservations.Location = new Point(10, 720);
            picReservations.Margin = new Padding(4, 5, 4, 5);
            picReservations.Name = "picReservations";
            picReservations.Size = new Size(35, 35);
            picReservations.SizeMode = PictureBoxSizeMode.Zoom;
            picReservations.TabIndex = 30;
            picReservations.TabStop = false;
            // 
            // picReports
            // 
            picReports.BackColor = Color.Transparent;
            picReports.Image = (Image)resources.GetObject("picReports.Image");
            picReports.Location = new Point(10, 920);
            picReports.Margin = new Padding(4, 5, 4, 5);
            picReports.Name = "picReports";
            picReports.Size = new Size(35, 35);
            picReports.SizeMode = PictureBoxSizeMode.Zoom;
            picReports.TabIndex = 29;
            picReports.TabStop = false;
            // 
            // picPayment
            // 
            picPayment.BackColor = Color.Transparent;
            picPayment.Image = (Image)resources.GetObject("picPayment.Image");
            picPayment.Location = new Point(10, 820);
            picPayment.Margin = new Padding(4, 5, 4, 5);
            picPayment.Name = "picPayment";
            picPayment.Size = new Size(35, 35);
            picPayment.SizeMode = PictureBoxSizeMode.Zoom;
            picPayment.TabIndex = 28;
            picPayment.TabStop = false;
            // 
            // picRooms
            // 
            picRooms.BackColor = Color.Transparent;
            picRooms.Image = (Image)resources.GetObject("picRooms.Image");
            picRooms.Location = new Point(10, 520);
            picRooms.Margin = new Padding(4, 5, 4, 5);
            picRooms.Name = "picRooms";
            picRooms.Size = new Size(35, 35);
            picRooms.SizeMode = PictureBoxSizeMode.Zoom;
            picRooms.TabIndex = 27;
            picRooms.TabStop = false;
            // 
            // picDashboard
            // 
            picDashboard.BackColor = Color.Transparent;
            picDashboard.Image = (Image)resources.GetObject("picDashboard.Image");
            picDashboard.Location = new Point(10, 420);
            picDashboard.Margin = new Padding(4, 5, 4, 5);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(35, 35);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 26;
            picDashboard.TabStop = false;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(50, 900);
            btnReports.Margin = new Padding(4, 5, 4, 5);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(340, 70);
            btnReports.TabIndex = 25;
            btnReports.Text = "Reports And Statistics";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(50, 600);
            btnCustomers.Margin = new Padding(4, 5, 4, 5);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(340, 70);
            btnCustomers.TabIndex = 24;
            btnCustomers.Text = "Customer Management";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(50, 800);
            btnPayment.Margin = new Padding(4, 5, 4, 5);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(340, 70);
            btnPayment.TabIndex = 23;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnReservations
            // 
            btnReservations.FlatAppearance.BorderSize = 0;
            btnReservations.FlatStyle = FlatStyle.Flat;
            btnReservations.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservations.ForeColor = Color.White;
            btnReservations.Location = new Point(50, 700);
            btnReservations.Margin = new Padding(4, 5, 4, 5);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(340, 70);
            btnReservations.TabIndex = 22;
            btnReservations.Text = "Reservation Management";
            btnReservations.TextAlign = ContentAlignment.MiddleLeft;
            btnReservations.UseVisualStyleBackColor = true;
            // 
            // btnRooms
            // 
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.ForeColor = Color.White;
            btnRooms.Location = new Point(50, 500);
            btnRooms.Margin = new Padding(4, 5, 4, 5);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(340, 70);
            btnRooms.TabIndex = 20;
            btnRooms.Text = "Room Management";
            btnRooms.TextAlign = ContentAlignment.MiddleLeft;
            btnRooms.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(50, 400);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(340, 70);
            btnDashboard.TabIndex = 19;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // piclogo
            // 
            piclogo.BackColor = Color.Transparent;
            piclogo.Image = (Image)resources.GetObject("piclogo.Image");
            piclogo.Location = new Point(20, 20);
            piclogo.Margin = new Padding(4, 5, 4, 5);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(350, 350);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 19;
            piclogo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(809, 108);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 18;
            // 
            // pnlHeaderRoomManagement
            // 
            pnlHeaderRoomManagement.BackColor = Color.FromArgb(6, 40, 62);
            pnlHeaderRoomManagement.Controls.Add(lblTitle);
            pnlHeaderRoomManagement.Controls.Add(lblsubtitle);
            pnlHeaderRoomManagement.Location = new Point(398, 0);
            pnlHeaderRoomManagement.Name = "pnlHeaderRoomManagement";
            pnlHeaderRoomManagement.Size = new Size(1252, 140);
            pnlHeaderRoomManagement.TabIndex = 19;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 1163);
            Controls.Add(pnlHeaderRoomManagement);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlsidebar);
            Controls.Add(txtSearch);
            Controls.Add(lblsearch);
            Controls.Add(dgvRooms);
            Controls.Add(btnclear);
            Controls.Add(btnupdate);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Controls.Add(cmbStatus);
            Controls.Add(lblstatus);
            Controls.Add(txtPrice);
            Controls.Add(lblprice);
            Controls.Add(cmbRoomType);
            Controls.Add(lblroomtype);
            Controls.Add(txtRoomNumber);
            Controls.Add(lblroomnumber);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RoomsForm";
            Text = "RoomsForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            pnlsidebar.ResumeLayout(false);
            pnlsidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            pnlHeaderRoomManagement.ResumeLayout(false);
            pnlHeaderRoomManagement.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.PictureBox picCustomers;
        private System.Windows.Forms.PictureBox picReservations;
        private System.Windows.Forms.PictureBox picReports;
        private System.Windows.Forms.PictureBox picPayment;
        private System.Windows.Forms.PictureBox picRooms;
        private System.Windows.Forms.PictureBox picDashboard;
        private Panel pnlHeaderRoomManagement;
        private Button btnlogout;
        private PictureBox piclogout;
    }
}

