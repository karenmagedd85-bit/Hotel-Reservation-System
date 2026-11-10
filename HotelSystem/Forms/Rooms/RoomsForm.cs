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
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
            Nav.Wire(this);
            SetupSidebarHover();
            ApplyResponsiveLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtroomnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                if (row.IsNewRow) continue;

                bool match = false;

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    string value = row.Cells[i].Value?.ToString().ToLower() ?? "";

                    if (value.Contains(search))
                    {
                        match = true;
                        break;
                    }
                }

                row.Visible = match;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text.Trim();
            string roomType = cmbRoomType.Text;
            string price = txtPrice.Text.Trim();
            string status = cmbStatus.Text;

            if (roomNumber == "" || roomType == "" || price == "" || status == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(price, out decimal roomPrice) || roomPrice <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            dgvRooms.Rows.Add(roomNumber, roomType, roomPrice, status);

            MessageBox.Show("Room added successfully!");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room from the table first.");
                return;
            }

            string roomNumber = txtRoomNumber.Text.Trim();
            string roomType = cmbRoomType.Text;
            string price = txtPrice.Text.Trim();
            string status = cmbStatus.Text;

            if (roomNumber == "" || roomType == "" || price == "" || status == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(price, out decimal roomPrice) || roomPrice <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            DataGridViewRow row = dgvRooms.SelectedRows[0];

            row.Cells["colRoomNumber"].Value = roomNumber;
            row.Cells["colRoomType"].Value = roomType;
            row.Cells["colPrice"].Value = roomPrice;
            row.Cells["colStatus"].Value = status;

            MessageBox.Show("Room updated successfully!");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this room?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                dgvRooms.Rows.Remove(dgvRooms.SelectedRows[0]);
                MessageBox.Show("Room deleted successfully!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtRoomNumber.Clear();
            cmbRoomType.SelectedIndex = -1;
            txtPrice.Clear();
            cmbStatus.SelectedIndex = -1;
            dgvRooms.ClearSelection();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblstatus_Click(object sender, EventArgs e)
        {

        }

        private void pnlsidebar_Paint(object sender, PaintEventArgs e)
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
            // Form settings
            this.MinimumSize = new Size(1100, 750);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Sidebar stays fixed on the left
            pnlsidebar.Dock = DockStyle.Left;
            pnlsidebar.Width = 400;

            // Header expands horizontally
            pnlHeaderRoomManagement.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // Rooms table expands horizontally and vertically
            dgvRooms.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvRooms.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Search controls stay at the top
            lblsearch.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left;

            txtSearch.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left;

            // Room input controls
            lblroomnumber.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtRoomNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblroomtype.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbRoomType.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblprice.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            lblstatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cmbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Action buttons
            btnadd.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnupdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btndelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnclear.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }


    }
}
