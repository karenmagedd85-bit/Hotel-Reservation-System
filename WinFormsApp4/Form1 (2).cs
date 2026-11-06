
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FrmReservationManagement : Form
    {
        public FrmReservationManagement()
        {
            InitializeComponent();
            LoadReservations();
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
    }
}
