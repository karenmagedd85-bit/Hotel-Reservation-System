using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_reservation_system101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
