namespace WindowsFormsApp5
{
    partial class loginpage
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
            this.pnlSidebarBar = new System.Windows.Forms.Panel();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.iconPicreceptionist = new FontAwesome.Sharp.IconPictureBox();
            this.iconPicadmin = new FontAwesome.Sharp.IconPictureBox();
            this.btnReception = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.chkshowpassword = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pnlSidebarBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.pnlmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicreceptionist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebarBar
            // 
            this.pnlSidebarBar.AutoSize = true;
            this.pnlSidebarBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.pnlSidebarBar.Controls.Add(this.piclogo);
            this.pnlSidebarBar.Location = new System.Drawing.Point(1, -7);
            this.pnlSidebarBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebarBar.Name = "pnlSidebarBar";
            this.pnlSidebarBar.Size = new System.Drawing.Size(377, 1024);
            this.pnlSidebarBar.TabIndex = 0;
            // 
            // piclogo
            // 
            this.piclogo.Image = global::WindowsFormsApp5.Properties.Resources.Grand_Hotel_Management_Logo;
            this.piclogo.Location = new System.Drawing.Point(14, 140);
            this.piclogo.Margin = new System.Windows.Forms.Padding(4);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(356, 575);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.pnlmain.Controls.Add(this.iconPicreceptionist);
            this.pnlmain.Controls.Add(this.iconPicadmin);
            this.pnlmain.Controls.Add(this.btnReception);
            this.pnlmain.Controls.Add(this.btnAdmin);
            this.pnlmain.Controls.Add(this.label1);
            this.pnlmain.Controls.Add(this.lblwelcome);
            this.pnlmain.Location = new System.Drawing.Point(379, -7);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1367, 1039);
            this.pnlmain.TabIndex = 1;
            this.pnlmain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmain_Paint);
            // 
            // iconPicreceptionist
            // 
            this.iconPicreceptionist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.iconPicreceptionist.IconChar = FontAwesome.Sharp.IconChar.Blackboard;
            this.iconPicreceptionist.IconColor = System.Drawing.Color.White;
            this.iconPicreceptionist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicreceptionist.IconSize = 116;
            this.iconPicreceptionist.Location = new System.Drawing.Point(848, 261);
            this.iconPicreceptionist.Margin = new System.Windows.Forms.Padding(4);
            this.iconPicreceptionist.Name = "iconPicreceptionist";
            this.iconPicreceptionist.Size = new System.Drawing.Size(116, 118);
            this.iconPicreceptionist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicreceptionist.TabIndex = 5;
            this.iconPicreceptionist.TabStop = false;
            // 
            // iconPicadmin
            // 
            this.iconPicadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.iconPicadmin.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPicadmin.IconColor = System.Drawing.Color.White;
            this.iconPicadmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicadmin.IconSize = 116;
            this.iconPicadmin.Location = new System.Drawing.Point(240, 261);
            this.iconPicadmin.Margin = new System.Windows.Forms.Padding(4);
            this.iconPicadmin.Name = "iconPicadmin";
            this.iconPicadmin.Size = new System.Drawing.Size(116, 118);
            this.iconPicadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPicadmin.TabIndex = 4;
            this.iconPicadmin.TabStop = false;
            // 
            // btnReception
            // 
            this.btnReception.BackColor = System.Drawing.Color.White;
            this.btnReception.FlatAppearance.BorderSize = 0;
            this.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReception.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.Location = new System.Drawing.Point(633, 223);
            this.btnReception.Margin = new System.Windows.Forms.Padding(4);
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(602, 262);
            this.btnReception.TabIndex = 3;
            this.btnReception.Text = "RECEPTIONIST";
            this.btnReception.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReception.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(12, 223);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(602, 262);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your Role";
            // 
            // lblwelcome
            // 
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(17, 28);
            this.lblwelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(645, 75);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Welcome Back!";
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // lblusername
            // 
            this.lblusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(714, 570);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(414, 51);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(714, 695);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(414, 51);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(715, 621);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(410, 34);
            this.txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(720, 763);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(396, 34);
            this.txtpassword.TabIndex = 5;
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.AutoSize = true;
            this.chkshowpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.chkshowpassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpassword.Location = new System.Drawing.Point(729, 827);
            this.chkshowpassword.Margin = new System.Windows.Forms.Padding(4);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(148, 27);
            this.chkshowpassword.TabIndex = 6;
            this.chkshowpassword.Text = "Show Password";
            this.chkshowpassword.UseVisualStyleBackColor = false;
            this.chkshowpassword.CheckedChanged += new System.EventHandler(this.chkshowpassword_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(762, 886);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(308, 61);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 1015);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chkshowpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.pnlSidebarBar);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginpage";
            this.Text = "login page";
            this.pnlSidebarBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicreceptionist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicadmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

