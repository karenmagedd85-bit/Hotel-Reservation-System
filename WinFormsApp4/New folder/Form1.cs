using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class PaymentForm1 : Form
    {
        public PaymentForm1()
        {
            InitializeComponent();
            LoadPayments();
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

        private void rbBankTransfer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {

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
    }
}
