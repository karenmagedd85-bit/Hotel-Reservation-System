namespace HotelSystem
{
    partial class CustomersForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlCustomerInfo = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtNationalID = new TextBox();
            lblNationalID = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblCustomerInfo = new Label();
            panel1 = new Panel();
            btnlogout = new Button();
            picStatisticsLogo = new PictureBox();
            btnStatistics = new Button();
            btnPayment = new Button();
            btnReservation = new Button();
            btnCustomerManagement = new Button();
            btnRoomManagment = new Button();
            btnDashboard = new Button();
            piclogout = new PictureBox();
            picPayment = new PictureBox();
            picReservationManagement = new PictureBox();
            piccustomermanagement = new PictureBox();
            picRoomManagment = new PictureBox();
            picDashboard = new PictureBox();
            piclogo = new PictureBox();
            pnlCustomersList = new Panel();
            dgvCustomers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNationalID = new DataGridViewTextBoxColumn();
            lblCustomersList = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlHeader.SuspendLayout();
            pnlCustomerInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStatisticsLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piclogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picReservationManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piccustomermanagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRoomManagment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            pnlCustomersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(6, 40, 62);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(398, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1252, 140);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.FromArgb(6, 40, 62);
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(25, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(406, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your hotel customers and their information";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(445, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customers Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.Click += lblTitle_Click;
            // 
            // pnlCustomerInfo
            // 
            pnlCustomerInfo.BackColor = Color.White;
            pnlCustomerInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomerInfo.Controls.Add(btnClear);
            pnlCustomerInfo.Controls.Add(btnDelete);
            pnlCustomerInfo.Controls.Add(btnUpdate);
            pnlCustomerInfo.Controls.Add(btnAdd);
            pnlCustomerInfo.Controls.Add(txtEmail);
            pnlCustomerInfo.Controls.Add(lblEmail);
            pnlCustomerInfo.Controls.Add(txtNationalID);
            pnlCustomerInfo.Controls.Add(lblNationalID);
            pnlCustomerInfo.Controls.Add(txtPhone);
            pnlCustomerInfo.Controls.Add(lblPhone);
            pnlCustomerInfo.Controls.Add(txtFullName);
            pnlCustomerInfo.Controls.Add(lblFullName);
            pnlCustomerInfo.Controls.Add(lblCustomerInfo);
            pnlCustomerInfo.Location = new Point(410, 146);
            pnlCustomerInfo.Name = "pnlCustomerInfo";
            pnlCustomerInfo.Size = new Size(1240, 329);
            pnlCustomerInfo.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1133, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(85, 35);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 83, 83);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1042, 274);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(23, 43, 77);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(155, 274);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(35, 138, 145);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(19, 274);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 30);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(22, 154);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(108, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email Address";
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(560, 185);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Size = new Size(301, 30);
            txtNationalID.TabIndex = 6;
            // 
            // lblNationalID
            // 
            lblNationalID.AutoSize = true;
            lblNationalID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNationalID.ForeColor = Color.FromArgb(64, 64, 64);
            lblNationalID.Location = new Point(556, 154);
            lblNationalID.Name = "lblNationalID";
            lblNationalID.Size = new Size(89, 20);
            lblNationalID.TabIndex = 5;
            lblNationalID.Text = "National ID";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(560, 104);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(301, 30);
            txtPhone.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(64, 64, 64);
            lblPhone.Location = new Point(556, 75);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(115, 20);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone Number";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(22, 104);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(306, 30);
            txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.White;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(64, 64, 64);
            lblFullName.Location = new Point(22, 75);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(80, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.AutoSize = true;
            lblCustomerInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerInfo.ForeColor = Color.FromArgb(23, 43, 77);
            lblCustomerInfo.Location = new Point(16, 16);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(253, 31);
            lblCustomerInfo.TabIndex = 0;
            lblCustomerInfo.Text = "Customer Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(6, 40, 62);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(picStatisticsLogo);
            panel1.Controls.Add(btnStatistics);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnCustomerManagement);
            panel1.Controls.Add(btnRoomManagment);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(piclogout);
            panel1.Controls.Add(picPayment);
            panel1.Controls.Add(picReservationManagement);
            panel1.Controls.Add(piccustomermanagement);
            panel1.Controls.Add(picRoomManagment);
            panel1.Controls.Add(picDashboard);
            panel1.Controls.Add(piclogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1200);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(6, 40, 62);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(50, 1034);
            btnlogout.Margin = new Padding(3, 4, 3, 4);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(288, 62);
            btnlogout.TabIndex = 17;
            btnlogout.Text = "Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // picStatisticsLogo
            // 
            picStatisticsLogo.BackColor = Color.Transparent;
            picStatisticsLogo.Image = (Image)resources.GetObject("picStatisticsLogo.Image");
            picStatisticsLogo.Location = new Point(10, 920);
            picStatisticsLogo.Name = "picStatisticsLogo";
            picStatisticsLogo.Size = new Size(35, 35);
            picStatisticsLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picStatisticsLogo.TabIndex = 25;
            picStatisticsLogo.TabStop = false;
            // 
            // btnStatistics
            // 
            btnStatistics.BackColor = Color.FromArgb(6, 40, 62);
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistics.Location = new Point(50, 900);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(340, 70);
            btnStatistics.TabIndex = 24;
            btnStatistics.Text = "Reports and Statistics";
            btnStatistics.TextAlign = ContentAlignment.MiddleLeft;
            btnStatistics.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(6, 40, 62);
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(50, 800);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(340, 70);
            btnPayment.TabIndex = 23;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.FromArgb(6, 40, 62);
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(50, 700);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(340, 70);
            btnReservation.TabIndex = 22;
            btnReservation.Text = "Reservation Management";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = Color.FromArgb(6, 40, 62);
            btnCustomerManagement.FlatAppearance.BorderSize = 0;
            btnCustomerManagement.FlatStyle = FlatStyle.Flat;
            btnCustomerManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerManagement.ForeColor = Color.White;
            btnCustomerManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagement.Location = new Point(50, 600);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(340, 70);
            btnCustomerManagement.TabIndex = 21;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagement.UseVisualStyleBackColor = false;
            // 
            // btnRoomManagment
            // 
            btnRoomManagment.BackColor = Color.FromArgb(6, 40, 62);
            btnRoomManagment.FlatAppearance.BorderSize = 0;
            btnRoomManagment.FlatStyle = FlatStyle.Flat;
            btnRoomManagment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomManagment.ForeColor = Color.White;
            btnRoomManagment.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomManagment.Location = new Point(50, 500);
            btnRoomManagment.Name = "btnRoomManagment";
            btnRoomManagment.Size = new Size(340, 70);
            btnRoomManagment.TabIndex = 20;
            btnRoomManagment.Text = "Room Management";
            btnRoomManagment.TextAlign = ContentAlignment.MiddleLeft;
            btnRoomManagment.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(6, 40, 62);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(50, 400);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(340, 70);
            btnDashboard.TabIndex = 19;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // piclogout
            // 
            piclogout.BackColor = Color.Transparent;
            piclogout.Enabled = false;
            piclogout.Image = (Image)resources.GetObject("piclogout.Image");
            piclogout.Location = new Point(10, 1045);
            piclogout.Margin = new Padding(3, 4, 3, 4);
            piclogout.Name = "piclogout";
            piclogout.Size = new Size(40, 40);
            piclogout.SizeMode = PictureBoxSizeMode.Zoom;
            piclogout.TabIndex = 13;
            piclogout.TabStop = false;
            // 
            // picPayment
            // 
            picPayment.BackColor = Color.Transparent;
            picPayment.Image = Properties.Resources.White_Credit_Card_Icon;
            picPayment.Location = new Point(10, 820);
            picPayment.Name = "picPayment";
            picPayment.Size = new Size(35, 35);
            picPayment.SizeMode = PictureBoxSizeMode.Zoom;
            picPayment.TabIndex = 10;
            picPayment.TabStop = false;
            picPayment.Click += picPayment_Click;
            // 
            // picReservationManagement
            // 
            picReservationManagement.BackColor = Color.Transparent;
            picReservationManagement.Image = Properties.Resources.White_Calendar_Icon_with_Date_Dots;
            picReservationManagement.Location = new Point(10, 720);
            picReservationManagement.Name = "picReservationManagement";
            picReservationManagement.Size = new Size(35, 35);
            picReservationManagement.SizeMode = PictureBoxSizeMode.Zoom;
            picReservationManagement.TabIndex = 9;
            picReservationManagement.TabStop = false;
            // 
            // piccustomermanagement
            // 
            piccustomermanagement.BackColor = Color.Transparent;
            piccustomermanagement.Image = Properties.Resources.White_Team_Group_Icon__1_;
            piccustomermanagement.Location = new Point(10, 620);
            piccustomermanagement.Name = "piccustomermanagement";
            piccustomermanagement.Size = new Size(35, 35);
            piccustomermanagement.SizeMode = PictureBoxSizeMode.Zoom;
            piccustomermanagement.TabIndex = 8;
            piccustomermanagement.TabStop = false;
            // 
            // picRoomManagment
            // 
            picRoomManagment.BackColor = Color.Transparent;
            picRoomManagment.Image = Properties.Resources.White_Bed_Icon_Silhouette;
            picRoomManagment.Location = new Point(10, 520);
            picRoomManagment.Name = "picRoomManagment";
            picRoomManagment.Size = new Size(35, 35);
            picRoomManagment.SizeMode = PictureBoxSizeMode.Zoom;
            picRoomManagment.TabIndex = 7;
            picRoomManagment.TabStop = false;
            // 
            // picDashboard
            // 
            picDashboard.BackColor = Color.Transparent;
            picDashboard.BackgroundImageLayout = ImageLayout.None;
            picDashboard.Image = Properties.Resources.White_Home_Icon_on_Transparent_Background;
            picDashboard.Location = new Point(10, 420);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(35, 35);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 6;
            picDashboard.TabStop = false;
            // 
            // piclogo
            // 
            piclogo.BackColor = Color.Transparent;
            piclogo.Image = Properties.Resources.Grand_Hotel_Management_Logo;
            piclogo.Location = new Point(20, 20);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(350, 350);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // pnlCustomersList
            // 
            pnlCustomersList.BorderStyle = BorderStyle.FixedSingle;
            pnlCustomersList.Controls.Add(dgvCustomers);
            pnlCustomersList.Controls.Add(lblCustomersList);
            pnlCustomersList.ForeColor = Color.White;
            pnlCustomersList.Location = new Point(410, 481);
            pnlCustomersList.Name = "pnlCustomersList";
            pnlCustomersList.Size = new Size(1240, 576);
            pnlCustomersList.TabIndex = 3;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(23, 43, 77);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgvCustomers.ColumnHeadersHeight = 45;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { Column1, colFullName, colPhone, colEmail, colNationalID });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(35, 138, 145);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle18;
            dgvCustomers.GridColor = Color.FromArgb(226, 232, 240);
            dgvCustomers.Location = new Point(-1, 45);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 45;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(1236, 530);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Number of customer";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email Address";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNationalID
            // 
            colNationalID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNationalID.DataPropertyName = "NationalID";
            colNationalID.HeaderText = "National ID";
            colNationalID.MinimumWidth = 6;
            colNationalID.Name = "colNationalID";
            colNationalID.ReadOnly = true;
            // 
            // lblCustomersList
            // 
            lblCustomersList.AutoSize = true;
            lblCustomersList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomersList.ForeColor = Color.FromArgb(23, 43, 77);
            lblCustomersList.Location = new Point(20, 11);
            lblCustomersList.Name = "lblCustomersList";
            lblCustomersList.Size = new Size(171, 31);
            lblCustomersList.TabIndex = 0;
            lblCustomersList.Text = "Customers List";
            lblCustomersList.Click += lblCustomersList_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(1645, 1105);
            Controls.Add(pnlCustomersList);
            Controls.Add(panel1);
            Controls.Add(pnlCustomerInfo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 5, 3, 5);
            Name = "CustomersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers Management";
            Load += CustomersForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCustomerInfo.ResumeLayout(false);
            pnlCustomerInfo.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStatisticsLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)piclogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)picReservationManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)piccustomermanagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRoomManagment).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            pnlCustomersList.ResumeLayout(false);
            pnlCustomersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlCustomerInfo;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlCustomersList;
        private System.Windows.Forms.Label lblCustomersList;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.PictureBox picPayment;
        private System.Windows.Forms.PictureBox picReservationManagement;
        private System.Windows.Forms.PictureBox piccustomermanagement;
        private System.Windows.Forms.PictureBox picRoomManagment;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.PictureBox piclogout;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Button btnDashboard;
        private Button btnPayment;
        private Button btnReservation;
        private Button btnCustomerManagement;
        private Button btnRoomManagment;
        private PictureBox picStatisticsLogo;
        private Button btnStatistics;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colNationalID;
        private Button btnlogout;
    }
}

