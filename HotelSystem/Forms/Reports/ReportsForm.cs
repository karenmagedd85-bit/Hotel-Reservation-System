
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;

namespace HotelSystem
{
    public partial class ReportsForm : Form
    {
        // =====================================
        // SIDEBAR COLORS
        // =====================================

        private readonly Color normalColor = Color.FromArgb(6, 40, 62);
        private readonly Color hoverColor = Color.FromArgb(20, 65, 90);
        private readonly Color activeColor = Color.FromArgb(30, 83, 115);
        private readonly Color pressedColor = Color.FromArgb(3, 28, 45);
    

        // =====================================
        // CONSTRUCTOR
        // =====================================

        public ReportsForm()
        {
            InitializeComponent();

            Nav.Wire(this);

            SetupSidebarHover();
            ApplyResponsiveLayout();
        }

        // =====================================
        // SIDEBAR BUTTONS
        // =====================================




        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBookingChart();
            CreateRoomTypesCard();
            LoadRevenueChart();
        }

        // =====================================
        // 1. BOOKING STATUS DOUGHNUT
        // =====================================

        private void LoadBookingChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            chart1.BackColor = Color.White;

            ChartArea area = new ChartArea("BookingArea");
            area.BackColor = Color.White;

            chart1.ChartAreas.Add(area);

            Series series = new Series("Booking Status");

            series.ChartType = SeriesChartType.Doughnut;

            series.Points.AddXY("Confirmed", 65);
            series.Points.AddXY("Pending", 20);
            series.Points.AddXY("Cancelled", 15);

            series.IsValueShownAsLabel = true;
            series["DoughnutHoleSize"] = "60";
            series["PieLabelStyle"] = "Inside";

            series.Font = new Font("Segoe UI", 9);

            series.Points[0].Color = Color.Green;
            series.Points[1].Color = Color.Orange;
            series.Points[2].Color = Color.Red;

            series.Points[0].LegendText = "Confirmed";
            series.Points[1].LegendText = "Pending";
            series.Points[2].LegendText = "Cancelled";

            chart1.Series.Add(series);

            Legend legend = new Legend();
            legend.ForeColor = Color.Black;
            legend.Font = new Font("Segoe UI", 8);

            chart1.Legends.Add(legend);
        }

        // =====================================
        // 2. TOP ROOM TYPES
        // =====================================

        private void CreateRoomTypesCard()
        {
            Control oldCard =
                chart2.Parent.Controls["pnlTopRoomTypes"];

            if (oldCard != null)
            {
                chart2.Parent.Controls.Remove(oldCard);
                oldCard.Dispose();
            }

            Panel card = new Panel();

            card.Name = "pnlTopRoomTypes";
            card.Size = new Size(
    chart2.Parent.ClientSize.Width - 16,
    chart2.Parent.ClientSize.Height - 100);
            card.Location = chart2.Location;
            card.Anchor =
    AnchorStyles.Top |
    AnchorStyles.Bottom |
    AnchorStyles.Left |
    AnchorStyles.Right;
            card.BackColor = Color.White;

            card.Parent = chart2.Parent;

            chart2.Visible = false;

            Label subtitle = new Label();

            subtitle.Text = "By Rooms";
            subtitle.Font = new Font("Segoe UI", 8);
            subtitle.ForeColor = Color.Gray;
            subtitle.Location = new Point(15, 15);
            subtitle.AutoSize = true;

            card.Controls.Add(subtitle);

            AddRoomBar(card, "Single", 40, 45);
            AddRoomBar(card, "Double", 35, 85);
            AddRoomBar(card, "Suite", 25, 125);

            card.BringToFront();
        }

        private void AddRoomBar(
            Panel card,
            string room,
            int percentage,
            int y)
        {
            int barWidth = card.Width - 40;

            Label roomName = new Label();

            roomName.Text = room;
            roomName.Location = new Point(15, y);
            roomName.AutoSize = true;
            roomName.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            Label percent = new Label();

            percent.Text = percentage + "%";
            percent.Location = new Point(barWidth - 5, y);
            percent.AutoSize = true;
            percent.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            Panel backgroundBar = new Panel();

            backgroundBar.Location =
                new Point(15, y + 22);

            backgroundBar.Size =
                new Size(barWidth, 11);

            backgroundBar.BackColor =
                Color.FromArgb(230, 233, 237);

            Panel greenBar = new Panel();

            greenBar.Location = new Point(0, 0);

            greenBar.Size = new Size(
                (int)(barWidth * percentage / 100.0),
                11
            );

            greenBar.BackColor =
                Color.FromArgb(0, 135, 65);

            backgroundBar.Controls.Add(greenBar);

            card.Controls.Add(roomName);
            card.Controls.Add(percent);
            card.Controls.Add(backgroundBar);
        }

        // =====================================
        // 3. REVENUE BY MONTH - WHITE CHART
        // =====================================

        private void LoadRevenueChart()
        {
            // Remove old chart
            Control oldChart =
                chartRevenue.Controls["revenueChart"];

            if (oldChart != null)
            {
                chartRevenue.Controls.Remove(oldChart);
                oldChart.Dispose();
            }

            // White background
            chartRevenue.BackColor = Color.White;

            Chart revenueChart = new Chart();

            revenueChart.Name = "revenueChart";
            revenueChart.Dock = DockStyle.Fill;
            revenueChart.BackColor = Color.White;
            revenueChart.BorderlineWidth = 0;
            revenueChart.Padding = new Padding(5);

            // CHART TITLE

            Title title = new Title();

            title.Text = "Revenue by Month";

            title.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            title.ForeColor = Color.Black;

            title.Alignment =
                ContentAlignment.TopLeft;

            title.Docking = Docking.Top;

            revenueChart.Titles.Add(title);

            // CHART AREA

            ChartArea area =
                new ChartArea("RevenueArea");

            area.BackColor = Color.White;

            // X AXIS

            area.AxisX.Interval = 1;

            area.AxisX.LabelStyle.ForeColor =
                Color.Black;

            area.AxisX.LabelStyle.Font =
                new Font("Segoe UI", 9);

            area.AxisX.MajorGrid.Enabled = false;

            area.AxisX.LineColor =
                Color.FromArgb(200, 200, 200);

            area.AxisX.MajorTickMark.Enabled = false;

            // Y AXIS

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 50000;
            area.AxisY.Interval = 10000;

            area.AxisY.LabelStyle.ForeColor =
                Color.Black;

            area.AxisY.LabelStyle.Font =
                new Font("Segoe UI", 8);

            area.AxisY.LabelStyle.Format = "$#,##0";

            area.AxisY.MajorGrid.Enabled = true;

            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(230, 233, 237);

            area.AxisY.LineColor = Color.Transparent;

            area.AxisY.MajorTickMark.Enabled = false;

            area.AxisY.IsStartedFromZero = true;

            revenueChart.ChartAreas.Add(area);

            // REVENUE DATA

            Series series = new Series("Revenue");

            series.ChartType =
                SeriesChartType.Column;

            series.Color =
                Color.FromArgb(38, 150, 245);

            series.BorderWidth = 0;

            series["PointWidth"] = "0.65";

            series.IsXValueIndexed = true;

            series.IsValueShownAsLabel = false;

            // MONTHLY REVENUE

            series.Points.AddXY("Jan", 22000);
            series.Points.AddXY("Feb", 29000);
            series.Points.AddXY("Mar", 26000);
            series.Points.AddXY("Apr", 36000);
            series.Points.AddXY("May", 42000);
            series.Points.AddXY("Jun", 50000);

            revenueChart.Series.Add(series);

            // ADD TO PANEL

            chartRevenue.Controls.Add(revenueChart);

            revenueChart.BringToFront();
        }

        // =====================================
        // OTHER EVENTS
        // =====================================

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void lblReservationsGrowth_Click(object sender, EventArgs e)
        {
        }

        private void pnlMonthlyRevenue_Paint(object sender, PaintEventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void lblRoomTypes_Click(object sender, EventArgs e)
        {
        }

        private void chart2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
        }

        private void lblRoomManagement_Click(object sender, EventArgs e)
        {
        }

        // =====================================
        // SIDEBAR HOVER & ACTIVE PAGE
        // =====================================

       
        private void SetupSidebarHover()
        {
            foreach (Control c in GetAllControls(this))
            {
                bool isSidebarItem =
                    c is Button ||
                    (c is Label &&
                     (c.Name.StartsWith("btn", StringComparison.OrdinalIgnoreCase) ||
                      c.Name.StartsWith("lab", StringComparison.OrdinalIgnoreCase)));

                if (!isSidebarItem)
                    continue;

                AppPage? targetPage = GetPageFromText(c.Text);

                if (targetPage == null)
                    continue;

                bool isActive = targetPage.Value == GetCurrentPage();

                c.BackColor = isActive ? activeColor : normalColor;
                c.ForeColor = Color.White;
                c.Cursor = Cursors.Hand;

                if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = hoverColor;
                    btn.FlatAppearance.MouseDownBackColor = pressedColor;
                    btn.UseVisualStyleBackColor = false;
                }

                c.MouseEnter += (sender, e) =>
                {
                    c.BackColor = hoverColor;
                    c.ForeColor = Color.White;
                };

                c.MouseLeave += (sender, e) =>
                {
                    c.BackColor = isActive ? activeColor : normalColor;
                    c.ForeColor = Color.White;
                };
            }
        }

        // Get all controls inside the form
        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;

                foreach (Control child in GetAllControls(control))
                    yield return child;
            }
        }

        // Identify page from button text
        private AppPage? GetPageFromText(string text)
        {
            switch (text.Trim().ToLowerInvariant())
            {
                case "dashboard":
                    return AppPage.Dashboard;

                case "room management":
                case "rooms":
                case "room managment":
                    return AppPage.Rooms;

                case "customer management":
                case "customer":
                case "customers":
                    return AppPage.Customers;

                case "reservation management":
                case "reservation":
                case "reservations":
                    return AppPage.Reservations;

                case "payment":
                case "payments":
                    return AppPage.Payments;

                case "reports and statistics":
                case "report and statistics":
                case "reports and analytics":
                    return AppPage.Reports;


                default:
                    return null;
            }
        }

        // Identify currently opened form
        private AppPage GetCurrentPage()
        {
            if (this is DashboardForm)
                return AppPage.Dashboard;

            if (this is RoomsForm)
                return AppPage.Rooms;

            if (this is CustomersForm)
                return AppPage.Customers;

            if (this is ReservationForm)
                return AppPage.Reservations;

            if (this is PaymentForm)
                return AppPage.Payments;

            if (this is ReportsForm)
                return AppPage.Reports;

            return AppPage.Login;
        }


        private void ApplyResponsiveLayout()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Sidebar
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Width = 400;

            // Recalculate layout whenever the form is resized
            this.Resize += (s, e) => LayoutReports();

            LayoutReports();
        }

        private void LayoutReports()
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            int sidebarWidth = pnlSideBar.Width;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Header
            pnlHeader.Location = new Point(sidebarWidth, 0);
            pnlHeader.Size = new Size(
                formWidth - sidebarWidth,
                140
            );

            // Main content dimensions
            int startX = sidebarWidth + 25;
            int rightMargin = 25;
            int gap = 15;
            int topY = 200;

            int availableWidth = formWidth - startX - rightMargin;

            int rightWidth = Math.Max(300, (int)(availableWidth * 0.30));
            int leftWidth = availableWidth - rightWidth - gap;

            int rightX = startX + leftWidth + gap;

            // Statistics cards
            int cardGap = 10;
            int cardWidth = (leftWidth - cardGap) / 2;
            int cardHeight = 144;

            pnlRevenue.Location = new Point(startX, topY);
            pnlRevenue.Size = new Size(cardWidth, cardHeight);

            pnlOccupancy.Location = new Point(
                startX + cardWidth + cardGap, topY
            );
            pnlOccupancy.Size = new Size(cardWidth, cardHeight);

            pnlReservation.Location = new Point(
                startX, topY + cardHeight + 10
            );
            pnlReservation.Size = new Size(cardWidth, cardHeight);

            pnlTotalGuests.Location = new Point(
                startX + cardWidth + cardGap,
                topY + cardHeight + 10
            );
            pnlTotalGuests.Size = new Size(cardWidth, cardHeight);

            // Revenue chart
            int chartY = topY + (cardHeight * 2) + 35;
            int chartHeight = Math.Max(250, formHeight - chartY - 25);

            pnlChartRevenue.Location = new Point(startX, chartY);
            pnlChartRevenue.Size = new Size(leftWidth, chartHeight);

            chartRevenue.Dock = DockStyle.Fill;

            // Booking Status
            int rightCardHeight = 300;

            pnlBookingStatus.Location = new Point(rightX, topY);
            pnlBookingStatus.Size = new Size(rightWidth, rightCardHeight);

            chart1.Location = new Point(7, 60);
            chart1.Size = new Size(
                rightWidth - 14,
                rightCardHeight - 70
            );

            // Top Room Types
            int roomTypesY = topY + rightCardHeight + 15;
            int roomTypesHeight = Math.Max(
                220,
                formHeight - roomTypesY - 25
            );

            pnlTopRoomTypes.Location = new Point(rightX, roomTypesY);
            pnlTopRoomTypes.Size = new Size(rightWidth, roomTypesHeight);
        }


    }
}
