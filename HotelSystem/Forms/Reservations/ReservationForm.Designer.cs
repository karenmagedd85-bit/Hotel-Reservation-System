namespace HotelSystem
{
    partial class ReservationForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            pnlSidebar = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picRoom = new PictureBox();
            picDashboard = new PictureBox();
            picBoxHotelLogo = new PictureBox();
            btnReports = new Button();
            btnPayments = new Button();
            btnReservation = new Button();
            btnCustomer = new Button();
            btnRoom = new Button();
            btnDashboard = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtSearch = new TextBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dgvReservations = new DataGridView();
            colResID = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colRoom = new DataGridViewTextBoxColumn();
            colCheckIn = new DataGridViewTextBoxColumn();
            colCheckOut = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            pnlNewReservation = new Panel();
            btnConfirmReg = new Button();
            btnCancel = new Button();
            lblReservationID = new Label();
            textBox1 = new TextBox();
            txtRoomType = new TextBox();
            cmbAdults = new ComboBox();
            lblAdults = new Label();
            lblChildren = new Label();
            cmbRooms = new ComboBox();
            lblRoom = new Label();
            lblReservationInfo = new Label();
            panel1 = new Panel();
            btnlogout = new Button();
            piclogout = new PictureBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHotelLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            pnlNewReservation.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogout).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(6, 40, 62);
            pnlSidebar.Controls.Add(piclogout);
            pnlSidebar.Controls.Add(btnlogout);
            pnlSidebar.Controls.Add(pictureBox4);
            pnlSidebar.Controls.Add(pictureBox3);
            pnlSidebar.Controls.Add(pictureBox2);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(picRoom);
            pnlSidebar.Controls.Add(picDashboard);
            pnlSidebar.Controls.Add(picBoxHotelLogo);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnPayments);
            pnlSidebar.Controls.Add(btnReservation);
            pnlSidebar.Controls.Add(btnCustomer);
            pnlSidebar.Controls.Add(btnRoom);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(400, 1175);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 920);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 820);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 720);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 620);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // picRoom
            // 
            picRoom.Image = (Image)resources.GetObject("picRoom.Image");
            picRoom.Location = new Point(10, 520);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(35, 35);
            picRoom.SizeMode = PictureBoxSizeMode.Zoom;
            picRoom.TabIndex = 9;
            picRoom.TabStop = false;
            // 
            // picDashboard
            // 
            picDashboard.Image = (Image)resources.GetObject("picDashboard.Image");
            picDashboard.Location = new Point(10, 420);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(35, 35);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 8;
            picDashboard.TabStop = false;
            // 
            // picBoxHotelLogo
            // 
            picBoxHotelLogo.Image = (Image)resources.GetObject("picBoxHotelLogo.Image");
            picBoxHotelLogo.Location = new Point(20, 20);
            picBoxHotelLogo.Name = "picBoxHotelLogo";
            picBoxHotelLogo.Size = new Size(350, 350);
            picBoxHotelLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxHotelLogo.TabIndex = 7;
            picBoxHotelLogo.TabStop = false;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 90, 145);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 43, 80);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(50, 900);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(320, 70);
            btnReports.TabIndex = 6;
            btnReports.TabStop = false;
            btnReports.Text = "Reports and Statistics";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnPayments
            // 
            btnPayments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPayments.Cursor = Cursors.Hand;
            btnPayments.FlatAppearance.BorderSize = 0;
            btnPayments.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 90, 145);
            btnPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 43, 80);
            btnPayments.FlatStyle = FlatStyle.Flat;
            btnPayments.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayments.ForeColor = Color.White;
            btnPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayments.Location = new Point(50, 800);
            btnPayments.Name = "btnPayments";
            btnPayments.Size = new Size(320, 70);
            btnPayments.TabIndex = 5;
            btnPayments.TabStop = false;
            btnPayments.Text = "Payments";
            btnPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayments.UseVisualStyleBackColor = false;
            btnPayments.Click += btnPayments_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.FromArgb(49, 90, 145);
            btnReservation.Cursor = Cursors.Hand;
            btnReservation.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 75, 125);
            btnReservation.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 105, 165);
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(50, 700);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(340, 70);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "Reservation Management";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 90, 145);
            btnCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 43, 80);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(50, 600);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(320, 70);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "Customer Management";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRoom
            // 
            btnRoom.AutoSize = true;
            btnRoom.BackColor = Color.Transparent;
            btnRoom.Cursor = Cursors.Hand;
            btnRoom.FlatAppearance.BorderSize = 0;
            btnRoom.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 90, 145);
            btnRoom.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 43, 80);
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoom.ForeColor = Color.White;
            btnRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoom.ImageKey = "02_room_management.png";
            btnRoom.Location = new Point(50, 500);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(340, 70);
            btnRoom.TabIndex = 2;
            btnRoom.Text = "Room Management";
            btnRoom.TextAlign = ContentAlignment.MiddleLeft;
            btnRoom.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoom.UseVisualStyleBackColor = false;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 90, 145);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 43, 80);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.ImageKey = "(none)";
            btnDashboard.Location = new Point(50, 400);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(340, 70);
            btnDashboard.TabIndex = 1;
            btnDashboard.TabStop = false;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(466, 50);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Reservation Management";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(25, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(345, 23);
            lblSubtitle.TabIndex = 8;
            lblSubtitle.Text = "Create, update, and track room reservations";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(148, 163, 184);
            txtSearch.Location = new Point(465, 522);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(249, 27);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "Search by Customer, Room or ID...";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrom.ForeColor = Color.FromArgb(51, 65, 85);
            lblFrom.Location = new Point(22, 180);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(78, 23);
            lblFrom.TabIndex = 11;
            lblFrom.Text = "Check In";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(22, 209);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(320, 27);
            dtpFrom.TabIndex = 12;
            // 
            // dtpTo
            // 
            dtpTo.CalendarMonthBackground = Color.White;
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(377, 209);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(327, 27);
            dtpTo.TabIndex = 13;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTo.ForeColor = Color.Black;
            lblTo.Location = new Point(377, 180);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(93, 23);
            lblTo.TabIndex = 14;
            lblTo.Text = "Check Out";
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.ColumnHeadersHeight = 40;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReservations.Columns.AddRange(new DataGridViewColumn[] { colResID, colCustomer, colRoom, colCheckIn, colCheckOut, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.GridColor = Color.FromArgb(226, 232, 240);
            dgvReservations.Location = new Point(465, 573);
            dgvReservations.MultiSelect = false;
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.RowHeadersWidth = 62;
            dgvReservations.RowTemplate.Height = 28;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(1081, 525);
            dgvReservations.TabIndex = 15;
            // 
            // colResID
            // 
            colResID.FillWeight = 50F;
            colResID.HeaderText = "Reservation ID";
            colResID.MinimumWidth = 8;
            colResID.Name = "colResID";
            colResID.ReadOnly = true;
            colResID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCustomer
            // 
            colCustomer.FillWeight = 110F;
            colCustomer.HeaderText = "Customer Name";
            colCustomer.MinimumWidth = 8;
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            colCustomer.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRoom
            // 
            colRoom.FillWeight = 75F;
            colRoom.HeaderText = "Room No.";
            colRoom.MinimumWidth = 8;
            colRoom.Name = "colRoom";
            colRoom.ReadOnly = true;
            colRoom.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCheckIn
            // 
            colCheckIn.FillWeight = 105F;
            colCheckIn.HeaderText = "Check In";
            colCheckIn.MinimumWidth = 8;
            colCheckIn.Name = "colCheckIn";
            colCheckIn.ReadOnly = true;
            colCheckIn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colCheckOut
            // 
            colCheckOut.FillWeight = 105F;
            colCheckOut.HeaderText = "Check Out";
            colCheckOut.MinimumWidth = 8;
            colCheckOut.Name = "colCheckOut";
            colCheckOut.ReadOnly = true;
            colCheckOut.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 85F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlNewReservation
            // 
            pnlNewReservation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlNewReservation.BorderStyle = BorderStyle.FixedSingle;
            pnlNewReservation.Controls.Add(btnConfirmReg);
            pnlNewReservation.Controls.Add(btnCancel);
            pnlNewReservation.Controls.Add(lblReservationID);
            pnlNewReservation.Controls.Add(textBox1);
            pnlNewReservation.Controls.Add(txtRoomType);
            pnlNewReservation.Controls.Add(cmbAdults);
            pnlNewReservation.Controls.Add(lblAdults);
            pnlNewReservation.Controls.Add(lblChildren);
            pnlNewReservation.Controls.Add(cmbRooms);
            pnlNewReservation.Controls.Add(lblRoom);
            pnlNewReservation.Controls.Add(lblReservationInfo);
            pnlNewReservation.Controls.Add(lblFrom);
            pnlNewReservation.Controls.Add(dtpFrom);
            pnlNewReservation.Controls.Add(dtpTo);
            pnlNewReservation.Controls.Add(lblTo);
            pnlNewReservation.Location = new Point(410, 146);
            pnlNewReservation.Name = "pnlNewReservation";
            pnlNewReservation.Size = new Size(1081, 358);
            pnlNewReservation.TabIndex = 17;
            // 
            // btnConfirmReg
            // 
            btnConfirmReg.BackColor = Color.FromArgb(0, 100, 150);
            btnConfirmReg.Cursor = Cursors.Hand;
            btnConfirmReg.FlatStyle = FlatStyle.Flat;
            btnConfirmReg.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmReg.ForeColor = Color.White;
            btnConfirmReg.Location = new Point(128, 286);
            btnConfirmReg.Name = "btnConfirmReg";
            btnConfirmReg.Size = new Size(346, 64);
            btnConfirmReg.TabIndex = 18;
            btnConfirmReg.Text = "Confirm Regestration";
            btnConfirmReg.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(210, 55, 55);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(762, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 64);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblReservationID
            // 
            lblReservationID.AutoSize = true;
            lblReservationID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationID.Location = new Point(748, 180);
            lblReservationID.Name = "lblReservationID";
            lblReservationID.Size = new Size(127, 23);
            lblReservationID.TabIndex = 34;
            lblReservationID.Text = "Reservation ID";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 243, 249);
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(748, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(351, 30);
            textBox1.TabIndex = 33;
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.FromArgb(240, 243, 249);
            txtRoomType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomType.Location = new Point(748, 102);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ReadOnly = true;
            txtRoomType.Size = new Size(351, 30);
            txtRoomType.TabIndex = 32;
            // 
            // cmbAdults
            // 
            cmbAdults.BackColor = Color.White;
            cmbAdults.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAdults.ForeColor = Color.FromArgb(20, 35, 55);
            cmbAdults.FormattingEnabled = true;
            cmbAdults.Location = new Point(22, 102);
            cmbAdults.Name = "cmbAdults";
            cmbAdults.Size = new Size(320, 31);
            cmbAdults.TabIndex = 31;
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdults.Location = new Point(22, 70);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(87, 23);
            lblAdults.TabIndex = 30;
            lblAdults.Text = "Customer";
            // 
            // lblChildren
            // 
            lblChildren.AutoSize = true;
            lblChildren.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildren.Location = new Point(748, 70);
            lblChildren.Name = "lblChildren";
            lblChildren.Size = new Size(100, 23);
            lblChildren.TabIndex = 29;
            lblChildren.Text = "Room Type";
            // 
            // cmbRooms
            // 
            cmbRooms.BackColor = Color.White;
            cmbRooms.ForeColor = Color.FromArgb(20, 35, 55);
            cmbRooms.FormattingEnabled = true;
            cmbRooms.Location = new Point(377, 102);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(336, 28);
            cmbRooms.TabIndex = 27;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(377, 70);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(57, 23);
            lblRoom.TabIndex = 26;
            lblRoom.Text = "Room";
            // 
            // lblReservationInfo
            // 
            lblReservationInfo.AutoSize = true;
            lblReservationInfo.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationInfo.ForeColor = Color.FromArgb(30, 45, 65);
            lblReservationInfo.Location = new Point(29, 21);
            lblReservationInfo.Name = "lblReservationInfo";
            lblReservationInfo.Size = new Size(264, 30);
            lblReservationInfo.TabIndex = 22;
            lblReservationInfo.Text = "Reservation Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 40, 62);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblSubtitle);
            panel1.Location = new Point(410, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1240, 140);
            panel1.TabIndex = 18;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(6, 40, 62);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(50, 1034);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(288, 62);
            btnlogout.TabIndex = 17;
            btnlogout.Text = "Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // piclogout
            // 
            piclogout.BackColor = Color.Transparent;
            piclogout.Image = (Image)resources.GetObject("piclogout.Image");
            piclogout.Location = new Point(10, 1045);
            piclogout.Margin = new Padding(3, 4, 3, 4);
            piclogout.Name = "piclogout";
            piclogout.Size = new Size(40, 40);
            piclogout.SizeMode = PictureBoxSizeMode.Zoom;
            piclogout.TabIndex = 19;
            piclogout.TabStop = false;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1645, 1175);
            Controls.Add(panel1);
            Controls.Add(pnlNewReservation);
            Controls.Add(dgvReservations);
            Controls.Add(pnlSidebar);
            Controls.Add(txtSearch);
            MinimumSize = new Size(978, 691);
            Name = "ReservationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation Management";
            WindowState = FormWindowState.Maximized;
            Load += FrmReservationManagement_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxHotelLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            pnlNewReservation.ResumeLayout(false);
            pnlNewReservation.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogout).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.PictureBox picBoxHotelLogo;
        private System.Windows.Forms.Panel pnlNewReservation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmReg;
        private System.Windows.Forms.Label lblReservationInfo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbAdults;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private Button btnlogout;
        private PictureBox piclogout;
    }
}

