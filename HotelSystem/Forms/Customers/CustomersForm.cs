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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            Nav.Wire(this);

            SetupSidebarHover();
            ApplyResponsiveLayout();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCustomersList_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picPayment_Click(object sender, EventArgs e)
        {

        }




        private int nextCustomerID = 1;
        private object dvgCustomers;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter customer name");
                txtFullName.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtPhone.Text, @"^01[0125][0-9]{8}$"))
            {
                MessageBox.Show("Enter a valid Egyptian phone number");
                txtPhone.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtNationalID.Text, @"^[0-9]{14}$"))
            {
                MessageBox.Show("National ID must be 14 digits");
                txtNationalID.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Enter a valid email");
                txtEmail.Focus();
                return;
            }

            dgvCustomers.Rows.Add(
                nextCustomerID++,
                txtFullName.Text,
                txtPhone.Text,
                txtEmail.Text,
                txtNationalID.Text
            );

            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtNationalID.Clear();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
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

        // =====================================
        // RESPONSIVE LAYOUT
        // =====================================

        private void ApplyResponsiveLayout()
        {
            // Allow resizing and maximizing
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(1100, 750);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Sidebar
            panel1.Dock = DockStyle.Left;
            panel1.Width = 400;

            // Header
            pnlHeader.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // Customer information panel
            pnlCustomerInfo.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // Customers list panel
            pnlCustomersList.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // DataGridView fills the customers list panel
            dgvCustomers.Dock = DockStyle.Fill;

            // Keep the list title visible above the table
            lblCustomersList.Dock = DockStyle.Top;
            lblCustomersList.Height = 45;
            lblCustomersList.TextAlign = ContentAlignment.MiddleLeft;

            // Input fields
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtNationalID.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Action buttons
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Table columns
            dgvCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}

