
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        // =====================================
        // SIDEBAR COLORS
        // =====================================

        private Color normalColor = Color.FromArgb(6, 40, 62);
        private Color hoverColor = Color.FromArgb(20, 65, 90);
        private Color activeColor = Color.FromArgb(30, 83, 115);
        private Color pressedColor = Color.FromArgb(3, 28, 45);

        // =====================================
        // CONSTRUCTOR
        // =====================================

        public Form1()
        {
            InitializeComponent();

            SetupSidebarButtons();
        }

        // =====================================
        // SIDEBAR BUTTONS
        // =====================================

        private void SetupSidebarButtons()
        {
            Button[] buttons =
            {
                btnDashboard,
                btnReservation,
                btnRoomManagment,
                btnCustomer,
                btnPayment,
                btnReport
            };

            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;

                btn.FlatAppearance.BorderSize = 0;

                btn.BackColor = normalColor;
                btn.ForeColor = Color.White;

                btn.FlatAppearance.MouseOverBackColor = hoverColor;

                btn.FlatAppearance.MouseDownBackColor = pressedColor;

                btn.Cursor = Cursors.Hand;

                btn.TextAlign = ContentAlignment.MiddleLeft;

                btn.Click += SidebarButton_Click;
            }

            // Dashboard selected when application starts
            SetActiveButton(btnDashboard);
        }

        // =====================================
        // ACTIVE BUTTON
        // =====================================

        private void SetActiveButton(Button selectedButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnReservation,
                btnRoomManagment,
                btnCustomer,
                btnPayment,
                btnReport
            };

            foreach (Button btn in buttons)
            {
                btn.BackColor = normalColor;
            }

            selectedButton.BackColor = activeColor;
        }

        // =====================================
        // BUTTON CLICK EVENT
        // =====================================

        private void SidebarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            SetActiveButton(clickedButton);
        }

        // =====================================
        // FORM LOAD
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
            card.Size = chart2.Size;
            card.Location = chart2.Location;
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
    }
}
