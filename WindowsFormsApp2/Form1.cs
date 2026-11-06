
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Hotelmanagement : Form
    {
        public Hotelmanagement()
        {
            InitializeComponent();
            this.Resize += (sender, e) => ResizeDashboard();
        }

        // ==========================================
        // FORM LOAD
        // ==========================================


        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureDashboard();
            ApplySidebarHover();
            ResizeDashboard();

            LockRows();
        }

        private void LockRows()
        {
            dgvRecentReservations.RowHeadersWidthSizeMode =
    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgvRecentReservations.AllowUserToResizeRows = false;

            foreach (DataGridViewRow row in dgvRecentReservations.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
                row.Height = 40;
            }
            dgvRecentReservations.AllowUserToResizeRows = false;
            dgvRecentReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvRecentReservations.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewRow row in dgvRecentReservations.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
                row.Height = 40;
            }
        }


        // ==========================================
        // DASHBOARD CONFIGURATION
        // ==========================================

        private void ConfigureDashboard()
        {
            ApplyRoundedPanels();
            ConfigureRoomOccupancyChart();
            ConfigureBookingsChart();
            ConfigureReservationsTable(); }
        private void ResizeDashboard()
        {
            int sidebarWidth = pnlSidebar.Width;
            int contentWidth = this.ClientSize.Width - sidebarWidth;

            int margin = 15;
            int gap = 12;

            // Header
            pnlHeader.Location = new Point(sidebarWidth, 0);
            pnlHeader.Width = contentWidth;

            // Four Cards
            int cardWidth = (contentWidth - (margin * 2) - (gap * 3)) / 4;

            Panel[] cards =
            {
        pnltotalrooms,
        pnlavaliblerooms,
        pnloccupiedrooms,
        pnltotalbooking
    };

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Location = new Point(
                    sidebarWidth + margin + i * (cardWidth + gap), 115);

                cards[i].Size = new Size(cardWidth, 115);
            }

            // Charts
            int chartWidth = (contentWidth - (margin * 2) - gap) / 2;

            pnlRoomOccupancy.Location =
                new Point(sidebarWidth + margin, 245);

            pnlRoomOccupancy.Size = new Size(chartWidth, 250);

            pnlBookingsOverview.Location =
                new Point(sidebarWidth + margin + chartWidth + gap, 245);

            pnlBookingsOverview.Size = new Size(chartWidth, 250);
            chartroomoccupancy.Location = new Point(0, 36);
            chartroomoccupancy.Size = new Size(
                pnlRoomOccupancy.Width,
                pnlRoomOccupancy.Height - 36);

            chart1.Location = new Point(0, 36);
            chart1.Size = new Size(
                pnlBookingsOverview.Width,
                pnlBookingsOverview.Height - 36);

            // Reservations
            // Recent Reservations - Fill remaining screen space
            int tableTop = 505;

            pnlRecentReservations.Location =
                new Point(sidebarWidth + margin, tableTop);

            pnlRecentReservations.Size = new Size(
                contentWidth - margin * 2,
                Math.Max(150, this.ClientSize.Height - tableTop - 15)
            );

            dgvRecentReservations.Location = new Point(0, 39);

            dgvRecentReservations.Size = new Size(
                pnlRecentReservations.Width - 2,
                pnlRecentReservations.Height - 41
            );

            // Fixed row height and prevent user resizing
            dgvRecentReservations.AllowUserToResizeRows = false;
            dgvRecentReservations.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvRecentReservations.RowTemplate.Height = 40;

            foreach (DataGridViewRow row in dgvRecentReservations.Rows)
            {
                row.Height = 40;
                row.Resizable = DataGridViewTriState.False;
            }
        }


        // ==========================================
        // SIDEBAR HOVER EFFECT
        // ==========================================

        private void ApplySidebarHover()
        {
            ApplyButtonHover(btnDashboard);
            ApplyButtonHover(btnRoomManagement);
            ApplyButtonHover(btnCustomerManagement);
            ApplyButtonHover(btnReservationManagement);
            ApplyButtonHover(btnPayment);
            ApplyButtonHover(btnReportsandStatistics);
            
        }

        private void ApplyButtonHover(Button btn)
        {
            Color originalBackColor = btn.BackColor;
            Color originalForeColor = btn.ForeColor;

            Color hoverBackColor =
                Color.FromArgb(25, 75, 105);

            btn.UseVisualStyleBackColor = false;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (sender, e) =>
            {
                btn.BackColor = hoverBackColor;
                btn.ForeColor = Color.White;
            };

            btn.MouseLeave += (sender, e) =>
            {
                btn.BackColor = originalBackColor;
                btn.ForeColor = originalForeColor;
            };
        }

        // ==========================================
        // ROUNDED PANELS
        // ==========================================

        private void ApplyRoundedPanels()
        {
            string[] panelNames =
            {
                "pnltotalrooms",
                "pnlavaliblerooms",
                "pnloccupiedrooms",
                "pnltotalbooking",
                "pnlRoomOccupancy",
                "pnlBookingsOverview",
                "pnlRecentReservations"
            };

            foreach (string name in panelNames)
            {
                Panel panel = FindControl<Panel>(name);

                if (panel != null)
                {
                    MakeRounded(
                        panel,
                        15,
                        Color.FromArgb(220, 225, 235),
                        1
                    );
                }
            }
        }

        private void MakeRounded(
            Panel panel,
            int radius,
            Color borderColor,
            int borderSize)
        {
            Action updateShape = () =>
            {
                if (panel.Width <= 0 || panel.Height <= 0)
                    return;

                Rectangle rect = new Rectangle(
                    0, 0,
                    panel.Width - 1,
                    panel.Height - 1
                );

                int r = Math.Min(
                    radius,
                    Math.Min(rect.Width, rect.Height) / 2
                );

                using (GraphicsPath path = CreateRoundPath(rect, r))
                {
                    Region oldRegion = panel.Region;
                    panel.Region = new Region(path);

                    if (oldRegion != null)
                        oldRegion.Dispose();
                }

                panel.Invalidate();
            };

            panel.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode =
                    SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(
                    0, 0,
                    panel.Width - 1,
                    panel.Height - 1
                );

                int r = Math.Min(
                    radius,
                    Math.Min(rect.Width, rect.Height) / 2
                );

                using (GraphicsPath path = CreateRoundPath(rect, r))
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };

            panel.Resize += (sender, e) => updateShape();

            updateShape();
        }

        private GraphicsPath CreateRoundPath(
            Rectangle rect,
            int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            path.AddArc(
                rect.X, rect.Y,
                diameter, diameter, 180, 90
            );

            path.AddArc(
                rect.Right - diameter,
                rect.Y,
                diameter, diameter, 270, 90
            );

            path.AddArc(
                rect.Right - diameter,
                rect.Bottom - diameter,
                diameter, diameter, 0, 90
            );

            path.AddArc(
                rect.X,
                rect.Bottom - diameter,
                diameter, diameter, 90, 90
            );

            path.CloseFigure();

            return path;
        }

        // ==========================================
        // ROOM OCCUPANCY DOUGHNUT CHART
        // ==========================================

        private void ConfigureRoomOccupancyChart()
        {
            chartroomoccupancy.Series.Clear();
            chartroomoccupancy.ChartAreas.Clear();
            chartroomoccupancy.Legends.Clear();

            ChartArea area = new ChartArea("RoomArea");
            area.BackColor = Color.Transparent;

            chartroomoccupancy.ChartAreas.Add(area);

            Legend legend = new Legend("RoomLegend");
            legend.Docking = Docking.Right;
            legend.BackColor = Color.Transparent;
            legend.Font = new Font("Segoe UI", 9);

            chartroomoccupancy.Legends.Add(legend);

            Series series = new Series("Occupancy");

            series.ChartType = SeriesChartType.Doughnut;
            series.ChartArea = "RoomArea";
            series.Legend = "RoomLegend";
            series["DoughnutRadius"] = "65";

            DataPoint occupied = new DataPoint();
            occupied.SetValueY(385);
            occupied.Color = Color.RoyalBlue;
            occupied.LegendText = "Occupied";

            DataPoint available = new DataPoint();
            available.SetValueY(115);
            available.Color = Color.LightSteelBlue;
            available.LegendText = "Available";

            series.Points.Add(occupied);
            series.Points.Add(available);

            chartroomoccupancy.Series.Add(series);
            chartroomoccupancy.BackColor = Color.Transparent;
        }

        // ==========================================
        // BOOKINGS OVERVIEW CHART
        // ==========================================

        private void ConfigureBookingsChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            ChartArea area = new ChartArea("BookingsArea");

            area.BackColor = Color.Transparent;

            area.AxisX.Interval = 1;
            area.AxisX.IsLabelAutoFit = false;
            area.AxisX.LabelStyle.IsStaggered = false;
            area.AxisX.LabelStyle.Angle = 0;
            area.AxisX.LabelStyle.Font =
                new Font("Segoe UI", 8);

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 30;
            area.AxisY.Interval = 5;

            area.AxisX.MajorGrid.Enabled = false;

            area.AxisY.MajorGrid.LineColor =
                Color.FromArgb(230, 235, 240);

            chart1.ChartAreas.Add(area);

            Series series = new Series("Bookings");

            series.ChartType = SeriesChartType.Column;
            series.ChartArea = "BookingsArea";
            series.Color = Color.RoyalBlue;

            series.Points.AddXY("Jan", 12);
            series.Points.AddXY("Feb", 16);
            series.Points.AddXY("Mar", 14);
            series.Points.AddXY("Apr", 20);
            series.Points.AddXY("May", 24);
            series.Points.AddXY("June", 22);

            chart1.Series.Add(series);
            chart1.BackColor = Color.Transparent;
        }

        // ==========================================
        // RECENT RESERVATIONS TABLE
        // ==========================================

        private void ConfigureReservationsTable()
        {
            dgvRecentReservations.ReadOnly = true;

            dgvRecentReservations.AllowUserToAddRows = false;
            dgvRecentReservations.AllowUserToDeleteRows = false;
            dgvRecentReservations.AllowUserToOrderColumns = false;
            dgvRecentReservations.AllowUserToResizeRows = false;

            dgvRecentReservations.RowHeadersVisible = false;
            dgvRecentReservations.MultiSelect = false;

            dgvRecentReservations.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRecentReservations.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecentReservations.BackgroundColor = Color.White;
            dgvRecentReservations.BorderStyle = BorderStyle.None;

            dgvRecentReservations.EnableHeadersVisualStyles = false;

            dgvRecentReservations.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(11, 45, 66);

            dgvRecentReservations.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvRecentReservations.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvRecentReservations.ColumnHeadersHeight = 40;
            dgvRecentReservations.RowTemplate.Height = 35;

            dgvRecentReservations.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvRecentReservations.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 234, 245);

            dgvRecentReservations.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            if (dgvRecentReservations.Rows.Count == 0)
            {
                AddReservation("B00124", "Ahmed Hassan", "101",
                    "01-11-2026", "04-11-2026", "Confirmed");

                AddReservation("B00125", "Sara Mohamed", "205",
                    "01-11-2026", "03-11-2026", "Checked In");

                AddReservation("B00126", "Omar Ali", "310",
                    "02-11-2026", "05-11-2026", "Pending");

                AddReservation("B00127", "Nada Mahmoud", "402",
                    "03-11-2026", "06-11-2026", "Confirmed");

                AddReservation("B00128", "Mariam Adel", "215",
                    "04-11-2026", "07-11-2026", "Confirmed");
                AddReservation("B00129", "Youssef Adel", "108",
                "05-11-2026", "08-11-2026", "Confirmed");

                AddReservation("B00130", "Laila Mostafa", "220",
                    "05-11-2026", "09-11-2026", "Pending");

                AddReservation("B00131", "Karim Samir", "315",
                    "06-11-2026", "10-11-2026", "Checked In");

                AddReservation("B00132", "Mona Ashraf", "405",
                    "06-11-2026", "11-11-2026", "Confirmed");

                AddReservation("B00133", "Adam Hany", "212",
                    "07-11-2026", "12-11-2026", "Pending");
            }
        }

        private void AddReservation(
            string bookingID,
            string customer,
            string room,
            string checkIn,
            string checkOut,
            string status)
        {
            int rowIndex = dgvRecentReservations.Rows.Add(
                bookingID,
                customer,
                room,
                checkIn,
                checkOut,
                status
            );

            DataGridViewCell statusCell =
                dgvRecentReservations.Rows[rowIndex]
                .Cells["colStatus"];

            if (status == "Confirmed")
                statusCell.Style.ForeColor = Color.Green;

            else if (status == "Pending")
                statusCell.Style.ForeColor = Color.DarkOrange;

            else if (status == "Checked In")
                statusCell.Style.ForeColor = Color.RoyalBlue;

            statusCell.Style.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
        }

        // ==========================================
        // FIND CONTROL
        // ==========================================

        private T FindControl<T>(string name)
            where T : Control
        {
            return this.Controls
                .Find(name, true)
                .FirstOrDefault() as T;
        }

        // ==========================================
        // EXISTING EVENTS
        // ==========================================

        private void btnRoomManagement_Click(object sender, EventArgs e)
        {
        }

        private void btnReportsandStatistics_Click(object sender, EventArgs e)
        {
        }

        private void piclogo_Click(object sender, EventArgs e)
        {
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbloccupiedrooms_Click(object sender, EventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private void dgvRecentReservations_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOccupancyPercentage_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
