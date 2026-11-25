using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class LoginForm : Form
    {
        private string selectedRole = "Admin";

        public LoginForm()
        {
            InitializeComponent();

            // Hide password by default
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.PasswordChar = '\0';
            chkshowpassword.Checked = false;

            // Connect events only once
            chkshowpassword.CheckedChanged -= chkshowpassword_CheckedChanged;
            chkshowpassword.CheckedChanged += chkshowpassword_CheckedChanged;

            btnAdmin.Click -= btnAdmin_Click;
            btnAdmin.Click += btnAdmin_Click;

            btnReception.Click -= btnReception_Click;
            btnReception.Click += btnReception_Click;

            btnlogin.Click -= btnlogin_Click;
            btnlogin.Click += btnlogin_Click;

            this.AcceptButton = btnlogin;

            // Initial role-button appearance
            StyleRoleButton(btnAdmin, selectedRole == "Admin");
            StyleRoleButton(btnReception, selectedRole == "Receptionist");
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !chkshowpassword.Checked;
            txtpassword.PasswordChar = '\0';
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";
            StyleRoleButton(btnAdmin, true);
            StyleRoleButton(btnReception, false);
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            selectedRole = "Receptionist";
            StyleRoleButton(btnAdmin, false);
            StyleRoleButton(btnReception, true);
        }

        private void StyleRoleButton(Button button, bool isSelected)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = isSelected ? 2 : 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(23, 107, 135);
            button.BackColor = isSelected ? Color.FromArgb(221, 240, 249) : Color.White;
            button.ForeColor = Color.FromArgb(6, 40, 62);
            button.Cursor = Cursors.Hand;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Save the selected user role
            Session.Start(txtusername.Text.Trim(), selectedRole);

            // Open Dashboard through Navigation
            Nav.Go(AppPage.Dashboard, this);
        }

        // Kept in case the Designer already references this event.
        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {
        }

        // Kept in case the Designer or existing project references this event.
        private void loginpage_Resize(object sender, EventArgs e)
        {
        }
    }
}