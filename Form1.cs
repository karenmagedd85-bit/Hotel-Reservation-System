using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
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

    }
}

