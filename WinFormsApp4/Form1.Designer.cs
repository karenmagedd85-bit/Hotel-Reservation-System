namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlSideBar = new Panel();
            btnReport = new Button();
            btnPayment = new Button();
            btnReservation = new Button();
            btnCustomer = new Button();
            btnRoomManagment = new Button();
            btnDashboard = new Button();
            ReservationLogo = new PictureBox();
            PaymentLogo = new PictureBox();
            ReportLogo = new PictureBox();
            CustomerLogo = new PictureBox();
            RoomManageLogo = new PictureBox();
            DashboardLogo = new PictureBox();
            logo = new PictureBox();
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            lblAdmin = new Label();
            lblNumRevenue = new Label();
            lblTotalRevenue = new Label();
            iconTotalRevenue = new FontAwesome.Sharp.IconPictureBox();
            lblRevenueRate = new Label();
            lblOccupancrRate = new Label();
            lblNumOccupancy = new Label();
            lblOccupancyRateText = new Label();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlRevenue = new RoundedPanel();
            pnlTotalGuests = new RoundedPanel();
            lblTotalGuestsRate = new Label();
            lblTotalGuests = new Label();
            lblNumGuests = new Label();
            iconTotalGuests = new FontAwesome.Sharp.IconPictureBox();
            pnlOccupancy = new RoundedPanel();
            iconOccupancy = new FontAwesome.Sharp.IconPictureBox();
            pnlReservation = new RoundedPanel();
            lblReservationRate = new Label();
            iconTotalReservation = new FontAwesome.Sharp.IconPictureBox();
            lblNumReservation = new Label();
            lblTotalReservation = new Label();
            pnlChartRevenue = new RoundedPanel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlBookingStatus = new RoundedPanel();
            lblBookingStatus = new Label();
            lblRoomTypes = new Label();
            pnlTopRoomTypes = new RoundedPanel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReservationLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReportLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomerLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomManageLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DashboardLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconTotalRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            pnlRevenue.SuspendLayout();
            pnlTotalGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalGuests).BeginInit();
            pnlOccupancy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconOccupancy).BeginInit();
            pnlReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalReservation).BeginInit();
            pnlChartRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            pnlBookingStatus.SuspendLayout();
            pnlTopRoomTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(6, 40, 62);
            pnlSideBar.Controls.Add(btnReport);
            pnlSideBar.Controls.Add(btnPayment);
            pnlSideBar.Controls.Add(btnReservation);
            pnlSideBar.Controls.Add(btnCustomer);
            pnlSideBar.Controls.Add(btnRoomManagment);
            pnlSideBar.Controls.Add(btnDashboard);
            pnlSideBar.Controls.Add(ReservationLogo);
            pnlSideBar.Controls.Add(PaymentLogo);
            pnlSideBar.Controls.Add(ReportLogo);
            pnlSideBar.Controls.Add(CustomerLogo);
            pnlSideBar.Controls.Add(RoomManageLogo);
            pnlSideBar.Controls.Add(DashboardLogo);
            pnlSideBar.Controls.Add(logo);
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(293, 780);
            pnlSideBar.TabIndex = 0;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Transparent;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 28, 45);
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 65, 90);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(35, 520);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(254, 50);
            btnReport.TabIndex = 27;
            btnReport.Text = "Report and Statistics";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.Transparent;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 28, 45);
            btnPayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 65, 90);
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(35, 470);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(254, 50);
            btnPayment.TabIndex = 26;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.Transparent;
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 28, 45);
            btnReservation.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 65, 90);
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(35, 420);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(257, 50);
            btnReservation.TabIndex = 25;
            btnReservation.Text = "Reservation";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 28, 45);
            btnCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 65, 90);
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(35, 370);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(257, 50);
            btnCustomer.TabIndex = 24;
            btnCustomer.Text = "Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRoomManagment
            // 
            btnRoomManagment.BackColor = Color.Transparent;
            btnRoomManagment.FlatAppearance.BorderSize = 0;
            btnRoomManagment.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 28, 45);
            btnRoomManagment.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 65, 90);
            btnRoomManagment.FlatStyle = FlatStyle.Flat;
            btnRoomManagment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomManagment.ForeColor = Color.White;
            btnRoomManagment.Location = new Point(35, 320);
            btnRoomManagment.Name = "btnRoomManagment";
            btnRoomManagment.Size = new Size(257, 50);
            btnRoomManagment.TabIndex = 23;
            btnRoomManagment.Text = "Room Management";
            btnRoomManagment.TextAlign = ContentAlignment.MiddleLeft;
            btnRoomManagment.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 28, 45);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 65, 90);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(35, 270);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(254, 50);
            btnDashboard.TabIndex = 22;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // ReservationLogo
            // 
            ReservationLogo.BackColor = Color.Transparent;
            ReservationLogo.Image = (Image)resources.GetObject("ReservationLogo.Image");
            ReservationLogo.Location = new Point(10, 430);
            ReservationLogo.Name = "ReservationLogo";
            ReservationLogo.Size = new Size(28, 28);
            ReservationLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ReservationLogo.TabIndex = 21;
            ReservationLogo.TabStop = false;
            // 
            // PaymentLogo
            // 
            PaymentLogo.BackColor = Color.Transparent;
            PaymentLogo.Image = (Image)resources.GetObject("PaymentLogo.Image");
            PaymentLogo.Location = new Point(10, 480);
            PaymentLogo.Name = "PaymentLogo";
            PaymentLogo.Size = new Size(28, 28);
            PaymentLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PaymentLogo.TabIndex = 20;
            PaymentLogo.TabStop = false;
            // 
            // ReportLogo
            // 
            ReportLogo.BackColor = Color.Transparent;
            ReportLogo.Image = (Image)resources.GetObject("ReportLogo.Image");
            ReportLogo.Location = new Point(10, 530);
            ReportLogo.Name = "ReportLogo";
            ReportLogo.Size = new Size(28, 28);
            ReportLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ReportLogo.TabIndex = 19;
            ReportLogo.TabStop = false;
            // 
            // CustomerLogo
            // 
            CustomerLogo.BackColor = Color.Transparent;
            CustomerLogo.Image = (Image)resources.GetObject("CustomerLogo.Image");
            CustomerLogo.Location = new Point(10, 380);
            CustomerLogo.Name = "CustomerLogo";
            CustomerLogo.Size = new Size(28, 28);
            CustomerLogo.SizeMode = PictureBoxSizeMode.Zoom;
            CustomerLogo.TabIndex = 15;
            CustomerLogo.TabStop = false;
            // 
            // RoomManageLogo
            // 
            RoomManageLogo.BackColor = Color.Transparent;
            RoomManageLogo.Image = (Image)resources.GetObject("RoomManageLogo.Image");
            RoomManageLogo.Location = new Point(10, 330);
            RoomManageLogo.Name = "RoomManageLogo";
            RoomManageLogo.Size = new Size(28, 28);
            RoomManageLogo.SizeMode = PictureBoxSizeMode.Zoom;
            RoomManageLogo.TabIndex = 13;
            RoomManageLogo.TabStop = false;
            // 
            // DashboardLogo
            // 
            DashboardLogo.BackColor = Color.Transparent;
            DashboardLogo.Image = (Image)resources.GetObject("DashboardLogo.Image");
            DashboardLogo.Location = new Point(10, 280);
            DashboardLogo.Name = "DashboardLogo";
            DashboardLogo.Size = new Size(28, 28);
            DashboardLogo.SizeMode = PictureBoxSizeMode.Zoom;
            DashboardLogo.TabIndex = 10;
            DashboardLogo.TabStop = false;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Hotel_Statistics_and_Report.Properties.Resources.Grand_Hotel_Management_Logo;
            logo.Location = new Point(21, 14);
            logo.Name = "logo";
            logo.Size = new Size(240, 240);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 9;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click_1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(25, 25, 25);
            lblPageTitle.Location = new Point(296, 2);
            lblPageTitle.Margin = new Padding(0);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(282, 50);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Hotel Statistics";
            lblPageTitle.Click += lblPageTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(305, 44);
            lblSubtitle.Margin = new Padding(0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(180, 23);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Performance Overview";
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.Location = new Point(1296, 666);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(125, 23);
            lblAdmin.TabIndex = 3;
            lblAdmin.Text = "Admin Officer";
            // 
            // lblNumRevenue
            // 
            lblNumRevenue.AutoSize = true;
            lblNumRevenue.BackColor = Color.Transparent;
            lblNumRevenue.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRevenue.Location = new Point(16, 60);
            lblNumRevenue.Name = "lblNumRevenue";
            lblNumRevenue.Size = new Size(158, 50);
            lblNumRevenue.TabIndex = 1;
            lblNumRevenue.Text = "$85,400";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.BackColor = Color.Transparent;
            lblTotalRevenue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(16, 111);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(116, 23);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "Total Revenue";
            // 
            // iconTotalRevenue
            // 
            iconTotalRevenue.BackColor = Color.Transparent;
            iconTotalRevenue.ForeColor = Color.FromArgb(24, 44, 73);
            iconTotalRevenue.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            iconTotalRevenue.IconColor = Color.FromArgb(24, 44, 73);
            iconTotalRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalRevenue.IconSize = 40;
            iconTotalRevenue.Location = new Point(16, 19);
            iconTotalRevenue.Name = "iconTotalRevenue";
            iconTotalRevenue.Size = new Size(40, 40);
            iconTotalRevenue.TabIndex = 3;
            iconTotalRevenue.TabStop = false;
            // 
            // lblRevenueRate
            // 
            lblRevenueRate.AutoSize = true;
            lblRevenueRate.BackColor = Color.Honeydew;
            lblRevenueRate.ForeColor = Color.Green;
            lblRevenueRate.Location = new Point(201, 74);
            lblRevenueRate.Name = "lblRevenueRate";
            lblRevenueRate.Size = new Size(58, 20);
            lblRevenueRate.TabIndex = 2;
            lblRevenueRate.Text = "+10.9%";
            // 
            // lblOccupancrRate
            // 
            lblOccupancrRate.AutoSize = true;
            lblOccupancrRate.BackColor = Color.Honeydew;
            lblOccupancrRate.ForeColor = Color.Green;
            lblOccupancrRate.Location = new Point(208, 74);
            lblOccupancrRate.Name = "lblOccupancrRate";
            lblOccupancrRate.Size = new Size(58, 20);
            lblOccupancrRate.TabIndex = 2;
            lblOccupancrRate.Text = "+20.9%";
            lblOccupancrRate.Click += label7_Click;
            // 
            // lblNumOccupancy
            // 
            lblNumOccupancy.AutoSize = true;
            lblNumOccupancy.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOccupancy.Location = new Point(16, 62);
            lblNumOccupancy.Name = "lblNumOccupancy";
            lblNumOccupancy.Size = new Size(96, 50);
            lblNumOccupancy.TabIndex = 1;
            lblNumOccupancy.Text = "78%";
            // 
            // lblOccupancyRateText
            // 
            lblOccupancyRateText.AutoSize = true;
            lblOccupancyRateText.BackColor = Color.Transparent;
            lblOccupancyRateText.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOccupancyRateText.Location = new Point(16, 111);
            lblOccupancyRateText.Name = "lblOccupancyRateText";
            lblOccupancyRateText.Size = new Size(133, 23);
            lblOccupancyRateText.TabIndex = 0;
            lblOccupancyRateText.Text = "Occupancy Rate";
            // 
            // chartRevenue
            // 
            chartRevenue.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRevenue.Legends.Add(legend1);
            chartRevenue.Location = new Point(16, 15);
            chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRevenue.Series.Add(series1);
            chartRevenue.Size = new Size(498, 318);
            chartRevenue.TabIndex = 9;
            chartRevenue.Text = "revenues";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.BorderColor = Color.FromArgb(36, 74, 112);
            pnlRevenue.BorderRadius = 20;
            pnlRevenue.BorderSize = 5;
            pnlRevenue.Controls.Add(lblRevenueRate);
            pnlRevenue.Controls.Add(lblTotalRevenue);
            pnlRevenue.Controls.Add(lblNumRevenue);
            pnlRevenue.Controls.Add(iconTotalRevenue);
            pnlRevenue.Location = new Point(305, 80);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(274, 144);
            pnlRevenue.TabIndex = 4;
            // 
            // pnlTotalGuests
            // 
            pnlTotalGuests.BackColor = Color.White;
            pnlTotalGuests.BorderColor = Color.FromArgb(36, 74, 112);
            pnlTotalGuests.BorderRadius = 20;
            pnlTotalGuests.BorderSize = 5;
            pnlTotalGuests.Controls.Add(lblTotalGuestsRate);
            pnlTotalGuests.Controls.Add(lblTotalGuests);
            pnlTotalGuests.Controls.Add(lblNumGuests);
            pnlTotalGuests.Controls.Add(iconTotalGuests);
            pnlTotalGuests.Location = new Point(585, 227);
            pnlTotalGuests.Name = "pnlTotalGuests";
            pnlTotalGuests.Size = new Size(274, 144);
            pnlTotalGuests.TabIndex = 9;
            // 
            // lblTotalGuestsRate
            // 
            lblTotalGuestsRate.AutoSize = true;
            lblTotalGuestsRate.BackColor = Color.Honeydew;
            lblTotalGuestsRate.ForeColor = Color.Green;
            lblTotalGuestsRate.Location = new Point(201, 74);
            lblTotalGuestsRate.Name = "lblTotalGuestsRate";
            lblTotalGuestsRate.Size = new Size(58, 20);
            lblTotalGuestsRate.TabIndex = 2;
            lblTotalGuestsRate.Text = "+10.9%";
            // 
            // lblTotalGuests
            // 
            lblTotalGuests.AutoSize = true;
            lblTotalGuests.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGuests.Location = new Point(16, 112);
            lblTotalGuests.Name = "lblTotalGuests";
            lblTotalGuests.Size = new Size(102, 23);
            lblTotalGuests.TabIndex = 0;
            lblTotalGuests.Text = "Total Guests";
            // 
            // lblNumGuests
            // 
            lblNumGuests.AutoSize = true;
            lblNumGuests.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumGuests.Location = new Point(16, 62);
            lblNumGuests.Name = "lblNumGuests";
            lblNumGuests.Size = new Size(85, 50);
            lblNumGuests.TabIndex = 1;
            lblNumGuests.Text = "420";
            // 
            // iconTotalGuests
            // 
            iconTotalGuests.BackColor = Color.White;
            iconTotalGuests.ForeColor = Color.FromArgb(24, 44, 73);
            iconTotalGuests.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconTotalGuests.IconColor = Color.FromArgb(24, 44, 73);
            iconTotalGuests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalGuests.IconSize = 40;
            iconTotalGuests.Location = new Point(16, 19);
            iconTotalGuests.Name = "iconTotalGuests";
            iconTotalGuests.Size = new Size(40, 40);
            iconTotalGuests.TabIndex = 3;
            iconTotalGuests.TabStop = false;
            // 
            // pnlOccupancy
            // 
            pnlOccupancy.BackColor = Color.White;
            pnlOccupancy.BorderColor = Color.FromArgb(36, 74, 112);
            pnlOccupancy.BorderRadius = 20;
            pnlOccupancy.BorderSize = 5;
            pnlOccupancy.Controls.Add(lblOccupancrRate);
            pnlOccupancy.Controls.Add(iconOccupancy);
            pnlOccupancy.Controls.Add(lblNumOccupancy);
            pnlOccupancy.Controls.Add(lblOccupancyRateText);
            pnlOccupancy.Location = new Point(585, 81);
            pnlOccupancy.Name = "pnlOccupancy";
            pnlOccupancy.Size = new Size(274, 144);
            pnlOccupancy.TabIndex = 5;
            // 
            // iconOccupancy
            // 
            iconOccupancy.BackColor = Color.Transparent;
            iconOccupancy.ForeColor = Color.FromArgb(24, 44, 73);
            iconOccupancy.IconChar = FontAwesome.Sharp.IconChar.Bed;
            iconOccupancy.IconColor = Color.FromArgb(24, 44, 73);
            iconOccupancy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconOccupancy.IconSize = 40;
            iconOccupancy.Location = new Point(16, 19);
            iconOccupancy.Name = "iconOccupancy";
            iconOccupancy.Size = new Size(40, 40);
            iconOccupancy.TabIndex = 4;
            iconOccupancy.TabStop = false;
            // 
            // pnlReservation
            // 
            pnlReservation.BackColor = Color.White;
            pnlReservation.BorderColor = Color.FromArgb(36, 74, 112);
            pnlReservation.BorderRadius = 20;
            pnlReservation.BorderSize = 5;
            pnlReservation.Controls.Add(lblReservationRate);
            pnlReservation.Controls.Add(iconTotalReservation);
            pnlReservation.Controls.Add(lblNumReservation);
            pnlReservation.Controls.Add(lblTotalReservation);
            pnlReservation.Location = new Point(305, 227);
            pnlReservation.Name = "pnlReservation";
            pnlReservation.Size = new Size(274, 144);
            pnlReservation.TabIndex = 10;
            // 
            // lblReservationRate
            // 
            lblReservationRate.AutoSize = true;
            lblReservationRate.BackColor = Color.Honeydew;
            lblReservationRate.ForeColor = Color.Green;
            lblReservationRate.Location = new Point(208, 74);
            lblReservationRate.Name = "lblReservationRate";
            lblReservationRate.Size = new Size(47, 20);
            lblReservationRate.TabIndex = 2;
            lblReservationRate.Text = "+40%";
            // 
            // iconTotalReservation
            // 
            iconTotalReservation.BackColor = Color.Transparent;
            iconTotalReservation.ForeColor = Color.FromArgb(24, 44, 73);
            iconTotalReservation.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            iconTotalReservation.IconColor = Color.FromArgb(24, 44, 73);
            iconTotalReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalReservation.IconSize = 40;
            iconTotalReservation.Location = new Point(16, 19);
            iconTotalReservation.Name = "iconTotalReservation";
            iconTotalReservation.Size = new Size(40, 40);
            iconTotalReservation.TabIndex = 4;
            iconTotalReservation.TabStop = false;
            // 
            // lblNumReservation
            // 
            lblNumReservation.AutoSize = true;
            lblNumReservation.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumReservation.Location = new Point(16, 62);
            lblNumReservation.Name = "lblNumReservation";
            lblNumReservation.Size = new Size(116, 50);
            lblNumReservation.TabIndex = 1;
            lblNumReservation.Text = "1,250";
            // 
            // lblTotalReservation
            // 
            lblTotalReservation.AutoSize = true;
            lblTotalReservation.BackColor = Color.Transparent;
            lblTotalReservation.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservation.Location = new Point(16, 111);
            lblTotalReservation.Name = "lblTotalReservation";
            lblTotalReservation.Size = new Size(139, 23);
            lblTotalReservation.TabIndex = 0;
            lblTotalReservation.Text = "Total Reservation";
            // 
            // pnlChartRevenue
            // 
            pnlChartRevenue.BackColor = Color.White;
            pnlChartRevenue.BorderColor = Color.FromArgb(36, 74, 112);
            pnlChartRevenue.BorderRadius = 20;
            pnlChartRevenue.BorderSize = 5;
            pnlChartRevenue.Controls.Add(chartRevenue);
            pnlChartRevenue.Location = new Point(305, 377);
            pnlChartRevenue.Name = "pnlChartRevenue";
            pnlChartRevenue.Size = new Size(554, 384);
            pnlChartRevenue.TabIndex = 11;
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(7, 60);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(345, 247);
            chart1.TabIndex = 12;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // pnlBookingStatus
            // 
            pnlBookingStatus.BackColor = Color.White;
            pnlBookingStatus.BorderColor = Color.FromArgb(36, 74, 112);
            pnlBookingStatus.BorderRadius = 20;
            pnlBookingStatus.BorderSize = 5;
            pnlBookingStatus.Controls.Add(lblBookingStatus);
            pnlBookingStatus.Controls.Add(chart1);
            pnlBookingStatus.Location = new Point(865, 80);
            pnlBookingStatus.Name = "pnlBookingStatus";
            pnlBookingStatus.Size = new Size(355, 317);
            pnlBookingStatus.TabIndex = 13;
            // 
            // lblBookingStatus
            // 
            lblBookingStatus.AutoSize = true;
            lblBookingStatus.BackColor = Color.Transparent;
            lblBookingStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookingStatus.Location = new Point(23, 18);
            lblBookingStatus.Name = "lblBookingStatus";
            lblBookingStatus.Size = new Size(177, 31);
            lblBookingStatus.TabIndex = 16;
            lblBookingStatus.Text = "Booking Status";
            // 
            // lblRoomTypes
            // 
            lblRoomTypes.AutoSize = true;
            lblRoomTypes.BackColor = Color.Transparent;
            lblRoomTypes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomTypes.Location = new Point(23, 23);
            lblRoomTypes.Name = "lblRoomTypes";
            lblRoomTypes.Size = new Size(188, 31);
            lblRoomTypes.TabIndex = 15;
            lblRoomTypes.Text = "Top Room Types";
            lblRoomTypes.Click += lblRoomTypes_Click;
            // 
            // pnlTopRoomTypes
            // 
            pnlTopRoomTypes.BackColor = Color.White;
            pnlTopRoomTypes.BorderColor = Color.FromArgb(36, 74, 112);
            pnlTopRoomTypes.BorderRadius = 20;
            pnlTopRoomTypes.BorderSize = 5;
            pnlTopRoomTypes.Controls.Add(chart2);
            pnlTopRoomTypes.Controls.Add(lblRoomTypes);
            pnlTopRoomTypes.Location = new Point(865, 408);
            pnlTopRoomTypes.Name = "pnlTopRoomTypes";
            pnlTopRoomTypes.Size = new Size(355, 353);
            pnlTopRoomTypes.TabIndex = 14;
            // 
            // chart2
            // 
            chart2.BackColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart2.Legends.Add(legend3);
            chart2.Location = new Point(8, 88);
            chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart2.Series.Add(series3);
            chart2.Size = new Size(340, 215);
            chart2.TabIndex = 16;
            chart2.Text = "chart2";
            chart2.Click += chart2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 773);
            Controls.Add(pnlTopRoomTypes);
            Controls.Add(pnlBookingStatus);
            Controls.Add(pnlChartRevenue);
            Controls.Add(pnlReservation);
            Controls.Add(pnlOccupancy);
            Controls.Add(pnlTotalGuests);
            Controls.Add(pnlRevenue);
            Controls.Add(lblAdmin);
            Controls.Add(lblSubtitle);
            Controls.Add(lblPageTitle);
            Controls.Add(pnlSideBar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Statistics andReport";
            Load += Form1_Load;
            pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReservationLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReportLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomerLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomManageLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)DashboardLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconTotalRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlTotalGuests.ResumeLayout(false);
            pnlTotalGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalGuests).EndInit();
            pnlOccupancy.ResumeLayout(false);
            pnlOccupancy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconOccupancy).EndInit();
            pnlReservation.ResumeLayout(false);
            pnlReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalReservation).EndInit();
            pnlChartRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            pnlBookingStatus.ResumeLayout(false);
            pnlBookingStatus.PerformLayout();
            pnlTopRoomTypes.ResumeLayout(false);
            pnlTopRoomTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSideBar;
        private Label lblPageTitle;
        private Label lblSubtitle;
        private Label lblAdmin;
        private Label lblRevenueRate;
        private Label lblNumRevenue;
        private Label lblTotalRevenue;
        private Label lblOccupancrRate;
        private Label lblNumOccupancy;
        private Label lblOccupancyRateText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private FontAwesome.Sharp.IconPictureBox iconTotalRevenue;
        private RoundedPanel pnlRevenue;
        private RoundedPanel pnlTotalGuests;
        private Label lblTotalGuestsRate;
        private Label lblTotalGuests;
        private Label lblNumGuests;
        private FontAwesome.Sharp.IconPictureBox iconTotalGuests;
        private RoundedPanel pnlOccupancy;
        private FontAwesome.Sharp.IconPictureBox iconOccupancy;
        private RoundedPanel pnlReservation;
        private Label lblReservationRate;
        private Label lblNumReservation;
        private Label lblTotalReservation;
        private FontAwesome.Sharp.IconPictureBox iconTotalReservation;
        private RoundedPanel pnlChartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RoundedPanel pnlBookingStatus;
        private RoundedPanel pnlTopRoomTypes;
        private Label lblRoomTypes;
        private Label lblBookingStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private PictureBox logo;
        private PictureBox DashboardLogo;
        private PictureBox RoomManageLogo;
        private PictureBox CustomerLogo;
        private PictureBox ReservationLogo;
        private PictureBox PaymentLogo;
        private PictureBox ReportLogo;
        private Button btnDashboard;
        private Button btnReport;
        private Button btnPayment;
        private Button btnReservation;
        private Button btnCustomer;
        private Button btnRoomManagment;
    }
}
