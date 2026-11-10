namespace HotelSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebarBar = new Panel();
            piclogo = new PictureBox();
            pnlmain = new Panel();
            iconPicreceptionist = new FontAwesome.Sharp.IconPictureBox();
            iconPicadmin = new FontAwesome.Sharp.IconPictureBox();
            btnReception = new Button();
            btnAdmin = new Button();
            label1 = new Label();
            lblwelcome = new Label();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            lblusername = new Label();
            lblpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            chkshowpassword = new CheckBox();
            btnlogin = new Button();
            pnlSidebarBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicreceptionist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPicadmin).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebarBar
            // 
            pnlSidebarBar.AutoSize = true;
            pnlSidebarBar.BackColor = Color.FromArgb(6, 40, 62);
            pnlSidebarBar.Controls.Add(piclogo);
            pnlSidebarBar.Location = new Point(0, 0);
            pnlSidebarBar.Margin = new Padding(4);
            pnlSidebarBar.Name = "pnlSidebarBar";
            pnlSidebarBar.Size = new Size(400, 1200);
            pnlSidebarBar.TabIndex = 0;
            // 
            // piclogo
            // 
            piclogo.Image = Properties.Resources.Grand_Hotel_Management_Logo1;
            piclogo.Location = new Point(22, 171);
            piclogo.Margin = new Padding(4);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(356, 575);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // pnlmain
            // 
            pnlmain.BackColor = Color.FromArgb(221, 240, 249);
            pnlmain.Controls.Add(iconPicreceptionist);
            pnlmain.Controls.Add(iconPicadmin);
            pnlmain.Controls.Add(btnReception);
            pnlmain.Controls.Add(btnAdmin);
            pnlmain.Controls.Add(label1);
            pnlmain.Controls.Add(lblwelcome);
            pnlmain.Location = new Point(402, 0);
            pnlmain.Margin = new Padding(4);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(1700, 1500);
            pnlmain.TabIndex = 1;
            pnlmain.Paint += pnlmain_Paint;
            // 
            // iconPicreceptionist
            // 
            iconPicreceptionist.BackColor = Color.FromArgb(10, 45, 65);
            iconPicreceptionist.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            iconPicreceptionist.IconColor = Color.White;
            iconPicreceptionist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPicreceptionist.IconSize = 120;
            iconPicreceptionist.Location = new Point(872, 306);
            iconPicreceptionist.Margin = new Padding(4);
            iconPicreceptionist.Name = "iconPicreceptionist";
            iconPicreceptionist.Size = new Size(120, 120);
            iconPicreceptionist.SizeMode = PictureBoxSizeMode.Zoom;
            iconPicreceptionist.TabIndex = 5;
            iconPicreceptionist.TabStop = false;
            // 
            // iconPicadmin
            // 
            iconPicadmin.BackColor = Color.FromArgb(10, 45, 65);
            iconPicadmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            iconPicadmin.IconColor = Color.White;
            iconPicadmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPicadmin.IconSize = 116;
            iconPicadmin.Location = new Point(256, 306);
            iconPicadmin.Margin = new Padding(4);
            iconPicadmin.Name = "iconPicadmin";
            iconPicadmin.Size = new Size(116, 118);
            iconPicadmin.SizeMode = PictureBoxSizeMode.Zoom;
            iconPicadmin.TabIndex = 4;
            iconPicadmin.TabStop = false;
            // 
            // btnReception
            // 
            btnReception.BackColor = Color.White;
            btnReception.FlatAppearance.BorderSize = 0;
            btnReception.FlatStyle = FlatStyle.Flat;
            btnReception.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReception.Location = new Point(633, 223);
            btnReception.Margin = new Padding(4);
            btnReception.Name = "btnReception";
            btnReception.Size = new Size(600, 300);
            btnReception.TabIndex = 3;
            btnReception.Text = "RECEPTIONIST";
            btnReception.TextAlign = ContentAlignment.BottomCenter;
            btnReception.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.White;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(12, 223);
            btnAdmin.Margin = new Padding(4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(600, 300);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "ADMIN";
            btnAdmin.TextAlign = ContentAlignment.BottomCenter;
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 1;
            label1.Text = "Select Your Role";
            // 
            // lblwelcome
            // 
            lblwelcome.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(17, 28);
            lblwelcome.Margin = new Padding(4, 0, 4, 0);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(645, 75);
            lblwelcome.TabIndex = 0;
            lblwelcome.Text = "Welcome Back!";
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // lblusername
            // 
            lblusername.BackColor = Color.FromArgb(221, 240, 249);
            lblusername.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(714, 570);
            lblusername.Margin = new Padding(4, 0, 4, 0);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(414, 51);
            lblusername.TabIndex = 2;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.BackColor = Color.FromArgb(221, 240, 249);
            lblpassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(714, 695);
            lblpassword.Margin = new Padding(4, 0, 4, 0);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(414, 51);
            lblpassword.TabIndex = 3;
            lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(715, 621);
            txtusername.Margin = new Padding(4);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(410, 34);
            txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(720, 763);
            txtpassword.Margin = new Padding(4);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(396, 34);
            txtpassword.TabIndex = 5;
            // 
            // chkshowpassword
            // 
            chkshowpassword.AutoSize = true;
            chkshowpassword.BackColor = Color.FromArgb(221, 240, 249);
            chkshowpassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkshowpassword.Location = new Point(729, 827);
            chkshowpassword.Margin = new Padding(4);
            chkshowpassword.Name = "chkshowpassword";
            chkshowpassword.Size = new Size(148, 27);
            chkshowpassword.TabIndex = 6;
            chkshowpassword.Text = "Show Password";
            chkshowpassword.UseVisualStyleBackColor = false;
            chkshowpassword.CheckedChanged += chkshowpassword_CheckedChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(6, 40, 62);
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(762, 886);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(308, 61);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 1055);
            Controls.Add(btnlogin);
            Controls.Add(chkshowpassword);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(pnlmain);
            Controls.Add(pnlSidebarBar);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "login page";
            pnlSidebarBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            pnlmain.ResumeLayout(false);
            pnlmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPicreceptionist).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPicadmin).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebarBar;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnReception;
        private System.Windows.Forms.Button btnAdmin;
        private FontAwesome.Sharp.IconPictureBox iconPicadmin;
        private FontAwesome.Sharp.IconPictureBox iconPicreceptionist;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.CheckBox chkshowpassword;
        private System.Windows.Forms.Button btnlogin;
    }
}