
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class loginpage : Form
    {
        private string selectedRole = "";

        public loginpage()
        {
            InitializeComponent();

            // Password hidden by default
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

            this.Resize -= loginpage_Resize;
            this.Resize += loginpage_Resize;

            // Initial button design
            StyleRoleButton(btnAdmin);
            StyleRoleButton(btnReception);

            loginpage_Resize(this, EventArgs.Empty);
        }

        // Button Design
        private void StyleRoleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;

            btn.BackColor = Color.FromArgb(10, 45, 65);
            btn.ForeColor = Color.White;

            btn.FlatAppearance.BorderSize = 0;

            btn.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(10, 45, 65);

            btn.FlatAppearance.MouseDownBackColor =
                Color.FromArgb(10, 45, 65);

            btn.Cursor = Cursors.Hand;
        }

        // Rounded Buttons
        private void MakeButtonRounded(Button btn, int radius)
        {
            if (btn.Width <= 0 || btn.Height <= 0)
                return;

            int r = Math.Min(radius,
                Math.Min(btn.Width, btn.Height) / 2);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, r * 2, r * 2, 180, 90);

            path.AddArc(btn.Width - r * 2, 0,
                r * 2, r * 2, 270, 90);

            path.AddArc(btn.Width - r * 2,
                btn.Height - r * 2,
                r * 2, r * 2, 0, 90);

            path.AddArc(0, btn.Height - r * 2,
                r * 2, r * 2, 90, 90);

            path.CloseFigure();

            if (btn.Region != null)
                btn.Region.Dispose();

            btn.Region = new Region(path);

            path.Dispose();
        }

        // Admin Selection
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            selectedRole = "Admin";

            btnAdmin.FlatAppearance.BorderSize = 3;
            btnAdmin.FlatAppearance.BorderColor = Color.Gold;

            btnReception.FlatAppearance.BorderSize = 0;
        }

        // Receptionist Selection
        private void btnReception_Click(object sender, EventArgs e)
        {
            selectedRole = "Receptionist";

            btnReception.FlatAppearance.BorderSize = 3;
            btnReception.FlatAppearance.BorderColor = Color.Gold;

            btnAdmin.FlatAppearance.BorderSize = 0;
        }

        // Show / Hide Password
        private void chkshowpassword_CheckedChanged(
            object sender, EventArgs e)
        {
            if (chkshowpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '\0';
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        // Responsive Form
        private void loginpage_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Sidebar
            pnlSidebarBar.Width = (int)(formWidth * 0.24);
            pnlSidebarBar.Height = formHeight;

            // Main Panel
            pnlmain.Left = pnlSidebarBar.Width;
            pnlmain.Top = 0;

            pnlmain.Width = formWidth - pnlSidebarBar.Width;
            pnlmain.Height = formHeight;

            // Center
            int centerX = pnlSidebarBar.Width +
                (pnlmain.Width / 2);

            // Welcome
            lblwelcome.Left = 20;

            // Role Buttons
            int buttonWidth = (int)(pnlmain.Width * 0.40);

            btnAdmin.Width = buttonWidth;
            btnReception.Width = buttonWidth;

            btnAdmin.Left = (int)(pnlmain.Width * 0.01);

            btnReception.Left = btnAdmin.Right + 10;

            // Username
            lblusername.Left =
                centerX - lblusername.Width / 2;

            txtusername.Left =
                centerX - txtusername.Width / 2;

            // Password
            lblpassword.Left =
                centerX - lblpassword.Width / 2;

            txtpassword.Left =
                centerX - txtpassword.Width / 2;

            // Show Password
            chkshowpassword.Left =
                centerX - chkshowpassword.Width / 2;

            // Login
            btnlogin.Left =
                centerX - btnlogin.Width / 2;

            // Rounded Corners
            MakeButtonRounded(btnAdmin, 30);
            MakeButtonRounded(btnReception, 30);
        }

        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
