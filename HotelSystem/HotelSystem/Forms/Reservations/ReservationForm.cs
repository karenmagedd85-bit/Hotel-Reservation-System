
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
            Nav.Wire(this);
            LoadReservations();
            SetupSidebarHover();
            ApplyResponsiveLayout();
        }

        // Load Fake Data
        private void LoadReservations()
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
        }

        // Add Reservation Row
        private void AddReservation(
            string id,
            string customer,
            string room,
            string checkIn,
            string checkOut,
            string status)
        {
            dgvReservations.Rows.Add(
                id, customer, room, checkIn, checkOut, status
            );
        }

        private void FrmReservationManagement_Load(object sender, EventArgs e)
        {
        }

        private void lblGrandHotel_Click(object sender, EventArgs e)
        {
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
        }

        private void lblBooking_Click(object sender, EventArgs e)
        {

        }

        private void picboxReservInfo_Click(object sender, EventArgs e)
        {
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        // =====================================
        // SIDEBAR HOVER & ACTIVE PAGE
        // =====================================

        private readonly Color normalColor = Color.FromArgb(6, 40, 62);
        private readonly Color hoverColor = Color.FromArgb(20, 65, 90);
        private readonly Color activeColor = Color.FromArgb(30, 83, 115);
        private readonly Color pressedColor = Color.FromArgb(3, 28, 45);

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
            this.MinimumSize = new Size(1100, 750);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Fixed sidebar
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Width = 400;

            // Resize layout whenever the form changes size
            this.Resize += (s, e) => ArrangeReservationControls();

            ArrangeReservationControls();
        }

        private void ArrangeReservationControls()
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            int sidebarWidth = pnlSidebar.Width;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int leftMargin = sidebarWidth + 20;
            int rightMargin = 25;
            int availableWidth = formWidth - leftMargin - rightMargin;

            // Header
            panel1.Location = new Point(sidebarWidth, 0);
            panel1.Size = new Size(formWidth - sidebarWidth, 140);

            // Reservation information panel
            int panelY = 155;
            int panelHeight = 350;

            pnlNewReservation.Location = new Point(leftMargin, panelY);
            pnlNewReservation.Size = new Size(availableWidth, panelHeight);

            // Divide the reservation fields into 3 columns
            int innerMargin = 22;
            int columnGap = 25;
            int columnWidth = (availableWidth - (innerMargin * 2) - (columnGap * 2)) / 3;

            int col1 = innerMargin;
            int col2 = col1 + columnWidth + columnGap;
            int col3 = col2 + columnWidth + columnGap;

            // First row
            lblAdults.Location = new Point(col1, 70);
            cmbAdults.Location = new Point(col1, 102);
            cmbAdults.Width = columnWidth;

            lblRoom.Location = new Point(col2, 70);
            cmbRooms.Location = new Point(col2, 102);
            cmbRooms.Width = columnWidth;

            lblChildren.Location = new Point(col3, 70);
            txtRoomType.Location = new Point(col3, 102);
            txtRoomType.Width = columnWidth;

            // Second row
            lblFrom.Location = new Point(col1, 180);
            dtpFrom.Location = new Point(col1, 209);
            dtpFrom.Width = columnWidth;

            lblTo.Location = new Point(col2, 180);
            dtpTo.Location = new Point(col2, 209);
            dtpTo.Width = columnWidth;

            lblReservationID.Location = new Point(col3, 180);
            textBox1.Location = new Point(col3, 209);
            textBox1.Width = columnWidth;

            // Buttons
            btnConfirmReg.Location = new Point(
                col1, 275
            );

            btnConfirmReg.Size = new Size(
                Math.Max(180, columnWidth), 55
            );

            btnCancel.Location = new Point(
                col3, 275
            );

            btnCancel.Size = new Size(
                columnWidth, 55
            );

            // Search
            int searchY = panelY + panelHeight + 15;

            txtSearch.Location = new Point(leftMargin, searchY);
            txtSearch.Width = Math.Min(350, availableWidth);

            // Reservations table
            int gridY = searchY + 50;
            int gridHeight = Math.Max(150, formHeight - gridY - 25);

            dgvReservations.Location = new Point(leftMargin, gridY);
            dgvReservations.Size = new Size(availableWidth, gridHeight);
            dgvReservations.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvReservations.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
