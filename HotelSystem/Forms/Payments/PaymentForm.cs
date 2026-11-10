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
    public partial class PaymentForm : Form
    {

        public PaymentForm()
        {
            InitializeComponent();

            Nav.Wire(this);

            SetupSidebarHover();
            ApplyResponsiveLayout();
        }
        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPaidTitle_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BK003_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void RbBankTransfer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
       
            if (rbCreditCard.Checked)
            {
                rbBankTransfer.Checked = false;
                rbCash.Checked = false;
            }
        }

        private void rbBankTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBankTransfer.Checked)
            {
                rbCreditCard.Checked = false;
                rbCash.Checked = false;
            }
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked)
            {
                rbCreditCard.Checked = false;
                rbBankTransfer.Checked = false;
            }
        }
        

        private void faCreditCard_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

        }

        private void picclear_Click(object sender, EventArgs e)
        {

        }

        private void Picture_Click(object sender, EventArgs e)
        {

        }

        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panelpayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pichome_Click(object sender, EventArgs e)
        {

        }
        private void LoadPayments()
        {
            dgvPayments.Rows.Clear();

            dgvPayments.Rows.Add(
                "P001", "Ahmed Khaled", "R001",
                "6,000", "Card", "Paid");

            dgvPayments.Rows.Add(
                "P002", "Sara Mohamed", "R002",
                "3,000", "Cash", "Paid");

            dgvPayments.Rows.Add(
                "P003", "Omar Hassan", "R003",
                "5,000", "Card", "Pending");

            dgvPayments.Rows.Add(
                "P004", "Nour Adel", "R004",
                "4,000", "Cash", "Paid");

            dgvPayments.Rows.Add(
                "P005", "Youssef Tarek", "R005",
                "6,000", "Card", "Refunded");
        }

        private void PaymentForm_Load(object sender, EventArgs e)
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
            this.MinimumSize = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Sidebar
            panlsidebar.Dock = DockStyle.Left;
            panlsidebar.Width = 400;

            // Re-arrange everything when the window is resized
            this.Resize += (sender, e) => ArrangePaymentControls();

            ArrangePaymentControls();
        }

        private void ArrangePaymentControls()
        {
            if (this.WindowState == FormWindowState.Minimized)
                return;

            int sidebarWidth = panlsidebar.Width;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int margin = 20;
            int gap = 10;

            int contentWidth = formWidth - sidebarWidth;

            // Header
            pnlHeader.Location = new Point(sidebarWidth, 0);
            pnlHeader.Size = new Size(contentWidth, 140);

            // Four statistic cards - equal widths
            int cardsWidth = contentWidth - (margin * 2);
            int cardWidth = (cardsWidth - (gap * 3)) / 4;
            int cardsTop = 160;
            int cardHeight = 85;

            RoundedPanel[] cards =
            {
        panelTotal,
        panelpaid,
        panelPending,
        panelCancelled
    };

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Location = new Point(
                    sidebarWidth + margin + i * (cardWidth + gap),
                    cardsTop
                );

                cards[i].Size = new Size(cardWidth, cardHeight);
            }

            // Main content area
            int contentTop = cardsTop + cardHeight + 15;
            int contentHeight = Math.Max(200, formHeight - contentTop - 15);

            // Payment form on the left
            int recordWidth = 420;

            panelRecord.Location = new Point(
                sidebarWidth + margin,
                contentTop
            );

            panelRecord.Size = new Size(
                recordWidth,
                contentHeight
            );

            // Allow scrolling inside the payment form if needed
            panelRecord.AutoScroll = true;

            // Keep the payment form header across the panel
            panelRecordHeader.Dock = DockStyle.Top;
            panelRecordHeader.BringToFront();

            // Payments table on the right
            int tableX = sidebarWidth + margin + recordWidth + gap;
            int tableWidth = formWidth - tableX - margin;

            dgvPayments.Location = new Point(tableX, contentTop);
            dgvPayments.Size = new Size(
                Math.Max(250, tableWidth),
                contentHeight
            );

            dgvPayments.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
