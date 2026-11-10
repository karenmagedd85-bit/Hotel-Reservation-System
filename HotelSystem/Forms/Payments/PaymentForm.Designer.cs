namespace HotelSystem
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            panelRecord = new Panel();
            picclear = new FontAwesome.Sharp.IconPictureBox();
            picConfirm = new FontAwesome.Sharp.IconPictureBox();
            btnClear = new Button();
            btnConfirmPayment = new Button();
            cmbPaymentStatus = new ComboBox();
            lblPaymentStatus = new Label();
            panelCash = new Panel();
            faMoneyBill = new FontAwesome.Sharp.IconPictureBox();
            rbCash = new RadioButton();
            panelCredit = new Panel();
            faCreditCard = new FontAwesome.Sharp.IconPictureBox();
            rbCreditCard = new RadioButton();
            panelRecordHeader = new Panel();
            Piccredit2 = new FontAwesome.Sharp.IconPictureBox();
            lblRecordTitle = new Label();
            panelBank = new Panel();
            faLandmark = new FontAwesome.Sharp.IconPictureBox();
            rbBankTransfer = new RadioButton();
            lblPaymentMethod = new Label();
            txtPaymentAmount = new TextBox();
            lblPaymentAmount = new Label();
            txtTotalAmount = new TextBox();
            txtGuestName = new TextBox();
            lblTotalAmount = new Label();
            lblGuestName = new Label();
            cbReservationId = new ComboBox();
            lblReservationID = new Label();
            panlsidebar = new Panel();
            piclogout = new PictureBox();
            btnlogout = new Button();
            picreport = new PictureBox();
            picpayment = new PictureBox();
            picreservation = new PictureBox();
            piccustomer = new PictureBox();
            picbed = new PictureBox();
            pichome = new PictureBox();
            btnReports = new Button();
            btnPayment = new Button();
            btnReservation = new Button();
            btnCustomer = new Button();
            btnRoomManagement = new Button();
            btnDashboard = new Button();
            picLogo = new PictureBox();
            dgvPayments = new DataGridView();
            PaymentID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            ReservationID = new DataGridViewTextBoxColumn();
            txtAmount = new DataGridViewTextBoxColumn();
            PaymentMethod = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            panelTotal = new RoundedPanel();
            iconTotalPayments = new FontAwesome.Sharp.IconPictureBox();
            lblTotalNumber = new Label();
            lblTotalTitle = new Label();
            panelCancelled = new RoundedPanel();
            iconCancelled = new FontAwesome.Sharp.IconPictureBox();
            lblCancelledNumber = new Label();
            lblCancelledTitle = new Label();
            panelPending = new RoundedPanel();
            iconPendingPayments = new FontAwesome.Sharp.IconPictureBox();
            lblPendingNumber = new Label();
            lblPendingTitle = new Label();
            panelpaid = new RoundedPanel();
            iconPaidBookings = new FontAwesome.Sharp.IconPictureBox();
            lblPaidNumber = new Label();
            lblPaidTitle = new Label();
            lblSubtitle = new Label();
            lblPaymentForm = new Label();
            pnlHeader = new Panel();
            panelRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picclear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picConfirm).BeginInit();
            panelCash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)faMoneyBill).BeginInit();
            panelCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)faCreditCard).BeginInit();
            panelRecordHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Piccredit2).BeginInit();
            panelBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)faLandmark).BeginInit();
            panlsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picreport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picpayment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picreservation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piccustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pichome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalPayments).BeginInit();
            panelCancelled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCancelled).BeginInit();
            panelPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPendingPayments).BeginInit();
            panelpaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPaidBookings).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelRecord
            // 
            panelRecord.BorderStyle = BorderStyle.FixedSingle;
            panelRecord.Controls.Add(picclear);
            panelRecord.Controls.Add(picConfirm);
            panelRecord.Controls.Add(btnClear);
            panelRecord.Controls.Add(btnConfirmPayment);
            panelRecord.Controls.Add(cmbPaymentStatus);
            panelRecord.Controls.Add(lblPaymentStatus);
            panelRecord.Controls.Add(panelCash);
            panelRecord.Controls.Add(panelCredit);
            panelRecord.Controls.Add(panelRecordHeader);
            panelRecord.Controls.Add(panelBank);
            panelRecord.Controls.Add(lblPaymentMethod);
            panelRecord.Controls.Add(txtPaymentAmount);
            panelRecord.Controls.Add(lblPaymentAmount);
            panelRecord.Controls.Add(txtTotalAmount);
            panelRecord.Controls.Add(txtGuestName);
            panelRecord.Controls.Add(lblTotalAmount);
            panelRecord.Controls.Add(lblGuestName);
            panelRecord.Controls.Add(cbReservationId);
            panelRecord.Controls.Add(lblReservationID);
            panelRecord.Location = new Point(410, 301);
            panelRecord.Margin = new Padding(3, 4, 3, 4);
            panelRecord.Name = "panelRecord";
            panelRecord.Size = new Size(420, 750);
            panelRecord.TabIndex = 7;
            // 
            // picclear
            // 
            picclear.BackColor = Color.White;
            picclear.BorderStyle = BorderStyle.Fixed3D;
            picclear.ForeColor = SystemColors.ControlText;
            picclear.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            picclear.IconColor = SystemColors.ControlText;
            picclear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picclear.IconSize = 20;
            picclear.Location = new Point(249, 685);
            picclear.Margin = new Padding(3, 4, 3, 4);
            picclear.Name = "picclear";
            picclear.Size = new Size(20, 24);
            picclear.TabIndex = 20;
            picclear.TabStop = false;
            picclear.Click += picclear_Click;
            // 
            // picConfirm
            // 
            picConfirm.BackColor = Color.FromArgb(6, 40, 62);
            picConfirm.BorderStyle = BorderStyle.Fixed3D;
            picConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            picConfirm.IconColor = Color.White;
            picConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picConfirm.IconSize = 20;
            picConfirm.Location = new Point(11, 685);
            picConfirm.Margin = new Padding(3, 4, 3, 4);
            picConfirm.Name = "picConfirm";
            picConfirm.Size = new Size(20, 24);
            picConfirm.TabIndex = 19;
            picConfirm.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(210, 672);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 50);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.BackColor = Color.FromArgb(6, 40, 62);
            btnConfirmPayment.FlatStyle = FlatStyle.Flat;
            btnConfirmPayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(10, 672);
            btnConfirmPayment.Margin = new Padding(3, 4, 3, 4);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(190, 50);
            btnConfirmPayment.TabIndex = 17;
            btnConfirmPayment.Text = "Confirm Payment";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(64, 591);
            cmbPaymentStatus.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(332, 28);
            cmbPaymentStatus.TabIndex = 16;
            cmbPaymentStatus.Text = "Paid";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentStatus.Location = new Point(3, 331);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(398, 56);
            lblPaymentStatus.TabIndex = 15;
            lblPaymentStatus.Text = "Payment Status";
            // 
            // panelCash
            // 
            panelCash.BorderStyle = BorderStyle.FixedSingle;
            panelCash.Controls.Add(faMoneyBill);
            panelCash.Controls.Add(rbCash);
            panelCash.Location = new Point(275, 410);
            panelCash.Margin = new Padding(3, 4, 3, 4);
            panelCash.Name = "panelCash";
            panelCash.Size = new Size(130, 100);
            panelCash.TabIndex = 14;
            // 
            // faMoneyBill
            // 
            faMoneyBill.BackColor = SystemColors.Control;
            faMoneyBill.BorderStyle = BorderStyle.Fixed3D;
            faMoneyBill.ForeColor = SystemColors.ControlText;
            faMoneyBill.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            faMoneyBill.IconColor = SystemColors.ControlText;
            faMoneyBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            faMoneyBill.Location = new Point(50, 6);
            faMoneyBill.Margin = new Padding(3, 4, 3, 4);
            faMoneyBill.Name = "faMoneyBill";
            faMoneyBill.Size = new Size(32, 39);
            faMoneyBill.TabIndex = 13;
            faMoneyBill.TabStop = false;
            // 
            // rbCash
            // 
            rbCash.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCash.Location = new Point(5, 62);
            rbCash.Margin = new Padding(3, 4, 3, 4);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(94, 25);
            rbCash.TabIndex = 12;
            rbCash.Text = "Cash";
            rbCash.UseVisualStyleBackColor = true;
            rbCash.CheckedChanged += rbCash_CheckedChanged;
            // 
            // panelCredit
            // 
            panelCredit.BackColor = SystemColors.Control;
            panelCredit.BorderStyle = BorderStyle.FixedSingle;
            panelCredit.Controls.Add(faCreditCard);
            panelCredit.Controls.Add(rbCreditCard);
            panelCredit.Location = new Point(3, 410);
            panelCredit.Margin = new Padding(3, 4, 3, 4);
            panelCredit.Name = "panelCredit";
            panelCredit.Size = new Size(130, 100);
            panelCredit.TabIndex = 13;
            // 
            // faCreditCard
            // 
            faCreditCard.BackColor = SystemColors.Control;
            faCreditCard.BorderStyle = BorderStyle.Fixed3D;
            faCreditCard.ForeColor = SystemColors.ControlText;
            faCreditCard.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            faCreditCard.IconColor = SystemColors.ControlText;
            faCreditCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            faCreditCard.IconSize = 28;
            faCreditCard.Location = new Point(50, 6);
            faCreditCard.Margin = new Padding(3, 4, 3, 4);
            faCreditCard.Name = "faCreditCard";
            faCreditCard.Size = new Size(28, 34);
            faCreditCard.TabIndex = 1;
            faCreditCard.TabStop = false;
            faCreditCard.Click += faCreditCard_Click;
            // 
            // rbCreditCard
            // 
            rbCreditCard.BackColor = SystemColors.Control;
            rbCreditCard.Checked = true;
            rbCreditCard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCreditCard.Location = new Point(3, 62);
            rbCreditCard.Margin = new Padding(3, 4, 3, 4);
            rbCreditCard.Name = "rbCreditCard";
            rbCreditCard.Size = new Size(112, 25);
            rbCreditCard.TabIndex = 0;
            rbCreditCard.TabStop = true;
            rbCreditCard.Text = "Credit Card";
            rbCreditCard.UseVisualStyleBackColor = false;
            rbCreditCard.CheckedChanged += rbCreditCard_CheckedChanged;
            // 
            // panelRecordHeader
            // 
            panelRecordHeader.BackColor = Color.FromArgb(6, 40, 62);
            panelRecordHeader.BorderStyle = BorderStyle.FixedSingle;
            panelRecordHeader.Controls.Add(Piccredit2);
            panelRecordHeader.Controls.Add(lblRecordTitle);
            panelRecordHeader.Location = new Point(0, -1);
            panelRecordHeader.Margin = new Padding(3, 4, 3, 4);
            panelRecordHeader.Name = "panelRecordHeader";
            panelRecordHeader.Size = new Size(420, 77);
            panelRecordHeader.TabIndex = 0;
            // 
            // Piccredit2
            // 
            Piccredit2.BackColor = Color.FromArgb(7, 32, 50);
            Piccredit2.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            Piccredit2.IconColor = Color.White;
            Piccredit2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Piccredit2.IconSize = 40;
            Piccredit2.Location = new Point(6, 10);
            Piccredit2.Margin = new Padding(3, 4, 3, 4);
            Piccredit2.Name = "Piccredit2";
            Piccredit2.Size = new Size(40, 50);
            Piccredit2.TabIndex = 1;
            Piccredit2.TabStop = false;
            // 
            // lblRecordTitle
            // 
            lblRecordTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordTitle.ForeColor = Color.White;
            lblRecordTitle.Location = new Point(50, 12);
            lblRecordTitle.Name = "lblRecordTitle";
            lblRecordTitle.Size = new Size(200, 44);
            lblRecordTitle.TabIndex = 0;
            lblRecordTitle.Text = "Record Payment";
            // 
            // panelBank
            // 
            panelBank.BorderStyle = BorderStyle.FixedSingle;
            panelBank.Controls.Add(faLandmark);
            panelBank.Controls.Add(rbBankTransfer);
            panelBank.Location = new Point(139, 410);
            panelBank.Margin = new Padding(3, 4, 3, 4);
            panelBank.Name = "panelBank";
            panelBank.Size = new Size(130, 100);
            panelBank.TabIndex = 14;
            // 
            // faLandmark
            // 
            faLandmark.BackColor = SystemColors.Control;
            faLandmark.BorderStyle = BorderStyle.Fixed3D;
            faLandmark.ForeColor = SystemColors.ControlText;
            faLandmark.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            faLandmark.IconColor = SystemColors.ControlText;
            faLandmark.IconFont = FontAwesome.Sharp.IconFont.Auto;
            faLandmark.Location = new Point(50, 6);
            faLandmark.Margin = new Padding(3, 4, 3, 4);
            faLandmark.Name = "faLandmark";
            faLandmark.Size = new Size(32, 39);
            faLandmark.TabIndex = 12;
            faLandmark.TabStop = false;
            // 
            // rbBankTransfer
            // 
            rbBankTransfer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbBankTransfer.Location = new Point(5, 62);
            rbBankTransfer.Margin = new Padding(3, 4, 3, 4);
            rbBankTransfer.Name = "rbBankTransfer";
            rbBankTransfer.Size = new Size(123, 25);
            rbBankTransfer.TabIndex = 11;
            rbBankTransfer.Text = "Bank Transfer";
            rbBankTransfer.UseVisualStyleBackColor = true;
            rbBankTransfer.CheckedChanged += rbBankTransfer_CheckedChanged;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(3, 531);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(398, 56);
            lblPaymentMethod.TabIndex = 9;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.BackColor = Color.Gainsboro;
            txtPaymentAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentAmount.Location = new Point(228, 275);
            txtPaymentAmount.Margin = new Padding(3, 4, 3, 4);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(177, 27);
            txtPaymentAmount.TabIndex = 8;
            txtPaymentAmount.TextChanged += txtPaymentAmount_TextChanged;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentAmount.Location = new Point(3, 275);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(177, 35);
            lblPaymentAmount.TabIndex = 7;
            lblPaymentAmount.Text = "Payment Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.Gainsboro;
            txtTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(228, 212);
            txtTotalAmount.Margin = new Padding(3, 4, 3, 4);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(177, 27);
            txtTotalAmount.TabIndex = 6;
            txtTotalAmount.TextChanged += txtTotalAmount_TextChanged;
            // 
            // txtGuestName
            // 
            txtGuestName.BackColor = Color.Gainsboro;
            txtGuestName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestName.Location = new Point(228, 150);
            txtGuestName.Margin = new Padding(3, 4, 3, 4);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(177, 27);
            txtGuestName.TabIndex = 5;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(3, 212);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(177, 35);
            lblTotalAmount.TabIndex = 4;
            lblTotalAmount.Text = "Total Amount";
            lblTotalAmount.Click += label2_Click;
            // 
            // lblGuestName
            // 
            lblGuestName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestName.Location = new Point(3, 150);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(177, 35);
            lblGuestName.TabIndex = 3;
            lblGuestName.Text = "Guest Name";
            // 
            // cbReservationId
            // 
            cbReservationId.BackColor = Color.Gainsboro;
            cbReservationId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReservationId.FormattingEnabled = true;
            cbReservationId.Location = new Point(228, 88);
            cbReservationId.Margin = new Padding(3, 4, 3, 4);
            cbReservationId.Name = "cbReservationId";
            cbReservationId.Size = new Size(177, 28);
            cbReservationId.TabIndex = 2;
            cbReservationId.SelectedIndexChanged += BK003_SelectedIndexChanged;
            // 
            // lblReservationID
            // 
            lblReservationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReservationID.Location = new Point(3, 88);
            lblReservationID.Name = "lblReservationID";
            lblReservationID.Size = new Size(177, 35);
            lblReservationID.TabIndex = 1;
            lblReservationID.Text = "Reservation ID";
            // 
            // panlsidebar
            // 
            panlsidebar.BackColor = Color.FromArgb(6, 40, 62);
            panlsidebar.Controls.Add(piclogout);
            panlsidebar.Controls.Add(btnlogout);
            panlsidebar.Controls.Add(picreport);
            panlsidebar.Controls.Add(picpayment);
            panlsidebar.Controls.Add(picreservation);
            panlsidebar.Controls.Add(piccustomer);
            panlsidebar.Controls.Add(picbed);
            panlsidebar.Controls.Add(pichome);
            panlsidebar.Controls.Add(btnReports);
            panlsidebar.Controls.Add(btnPayment);
            panlsidebar.Controls.Add(btnReservation);
            panlsidebar.Controls.Add(btnCustomer);
            panlsidebar.Controls.Add(btnRoomManagement);
            panlsidebar.Controls.Add(btnDashboard);
            panlsidebar.Controls.Add(picLogo);
            panlsidebar.ForeColor = Color.White;
            panlsidebar.Location = new Point(0, 0);
            panlsidebar.Margin = new Padding(3, 4, 3, 4);
            panlsidebar.Name = "panlsidebar";
            panlsidebar.Size = new Size(400, 1200);
            panlsidebar.TabIndex = 9;
            // 
            // piclogout
            // 
            piclogout.Image = (Image)resources.GetObject("piclogout.Image");
            piclogout.Location = new Point(10, 1045);
            piclogout.Margin = new Padding(3, 4, 3, 4);
            piclogout.Name = "piclogout";
            piclogout.Size = new Size(40, 40);
            piclogout.SizeMode = PictureBoxSizeMode.Zoom;
            piclogout.TabIndex = 26;
            piclogout.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(6, 40, 62);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.Location = new Point(50, 1034);
            btnlogout.Margin = new Padding(3, 4, 3, 4);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(288, 62);
            btnlogout.TabIndex = 17;
            btnlogout.Text = "Logout";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // picreport
            // 
            picreport.BackColor = Color.Transparent;
            picreport.Image = (Image)resources.GetObject("picreport.Image");
            picreport.Location = new Point(10, 920);
            picreport.Margin = new Padding(3, 4, 3, 4);
            picreport.Name = "picreport";
            picreport.Size = new Size(35, 35);
            picreport.SizeMode = PictureBoxSizeMode.Zoom;
            picreport.TabIndex = 24;
            picreport.TabStop = false;
            // 
            // picpayment
            // 
            picpayment.BackColor = Color.Transparent;
            picpayment.Image = (Image)resources.GetObject("picpayment.Image");
            picpayment.Location = new Point(10, 820);
            picpayment.Margin = new Padding(3, 4, 3, 4);
            picpayment.Name = "picpayment";
            picpayment.Size = new Size(35, 35);
            picpayment.SizeMode = PictureBoxSizeMode.Zoom;
            picpayment.TabIndex = 23;
            picpayment.TabStop = false;
            // 
            // picreservation
            // 
            picreservation.BackColor = Color.Transparent;
            picreservation.Image = (Image)resources.GetObject("picreservation.Image");
            picreservation.Location = new Point(10, 720);
            picreservation.Margin = new Padding(3, 4, 3, 4);
            picreservation.Name = "picreservation";
            picreservation.Size = new Size(35, 35);
            picreservation.SizeMode = PictureBoxSizeMode.Zoom;
            picreservation.TabIndex = 22;
            picreservation.TabStop = false;
            // 
            // piccustomer
            // 
            piccustomer.BackColor = Color.Transparent;
            piccustomer.Image = (Image)resources.GetObject("piccustomer.Image");
            piccustomer.Location = new Point(10, 620);
            piccustomer.Margin = new Padding(3, 4, 3, 4);
            piccustomer.Name = "piccustomer";
            piccustomer.Size = new Size(35, 35);
            piccustomer.SizeMode = PictureBoxSizeMode.Zoom;
            piccustomer.TabIndex = 21;
            piccustomer.TabStop = false;
            // 
            // picbed
            // 
            picbed.BackColor = Color.Transparent;
            picbed.Image = (Image)resources.GetObject("picbed.Image");
            picbed.Location = new Point(10, 520);
            picbed.Margin = new Padding(3, 4, 3, 4);
            picbed.Name = "picbed";
            picbed.Size = new Size(35, 35);
            picbed.SizeMode = PictureBoxSizeMode.Zoom;
            picbed.TabIndex = 20;
            picbed.TabStop = false;
            // 
            // pichome
            // 
            pichome.BackColor = Color.Transparent;
            pichome.Image = (Image)resources.GetObject("pichome.Image");
            pichome.Location = new Point(10, 420);
            pichome.Margin = new Padding(3, 4, 3, 4);
            pichome.Name = "pichome";
            pichome.Size = new Size(35, 35);
            pichome.SizeMode = PictureBoxSizeMode.Zoom;
            pichome.TabIndex = 19;
            pichome.TabStop = false;
            pichome.Click += pichome_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(50, 900);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(340, 70);
            btnReports.TabIndex = 18;
            btnReports.Text = "Reports and Statistics";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(50, 800);
            btnPayment.Margin = new Padding(3, 4, 3, 4);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(340, 70);
            btnPayment.TabIndex = 17;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnReservation
            // 
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(50, 700);
            btnReservation.Margin = new Padding(3, 4, 3, 4);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(327, 70);
            btnReservation.TabIndex = 16;
            btnReservation.Text = "Reservation Management";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.Location = new Point(50, 600);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(340, 70);
            btnCustomer.TabIndex = 15;
            btnCustomer.Text = "Customer Managment";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRoomManagement
            // 
            btnRoomManagement.FlatAppearance.BorderSize = 0;
            btnRoomManagement.FlatStyle = FlatStyle.Flat;
            btnRoomManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomManagement.ForeColor = Color.White;
            btnRoomManagement.Location = new Point(50, 500);
            btnRoomManagement.Margin = new Padding(3, 4, 3, 4);
            btnRoomManagement.Name = "btnRoomManagement";
            btnRoomManagement.Size = new Size(340, 70);
            btnRoomManagement.TabIndex = 14;
            btnRoomManagement.Text = "Room Management";
            btnRoomManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnRoomManagement.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(50, 400);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(340, 70);
            btnDashboard.TabIndex = 13;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImageLayout = ImageLayout.None;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(20, 20);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(350, 350);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // dgvPayments
            // 
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { PaymentID, CustomerName, ReservationID, txtAmount, PaymentMethod, txtStatus });
            dgvPayments.Location = new Point(862, 301);
            dgvPayments.Margin = new Padding(3, 4, 3, 4);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.RowTemplate.Height = 24;
            dgvPayments.Size = new Size(500, 750);
            dgvPayments.TabIndex = 16;
            // 
            // PaymentID
            // 
            PaymentID.HeaderText = "Payment ID";
            PaymentID.MinimumWidth = 6;
            PaymentID.Name = "PaymentID";
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            // 
            // ReservationID
            // 
            ReservationID.HeaderText = "Res. ID";
            ReservationID.MinimumWidth = 6;
            ReservationID.Name = "ReservationID";
            // 
            // txtAmount
            // 
            txtAmount.HeaderText = "Amount (EGP)";
            txtAmount.MinimumWidth = 6;
            txtAmount.Name = "txtAmount";
            // 
            // PaymentMethod
            // 
            PaymentMethod.HeaderText = "Payment Method";
            PaymentMethod.MinimumWidth = 6;
            PaymentMethod.Name = "PaymentMethod";
            // 
            // txtStatus
            // 
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 6;
            txtStatus.Name = "txtStatus";
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(255, 220, 255);
            panelTotal.BorderColor = Color.FromArgb(36, 74, 112);
            panelTotal.BorderRadius = 15;
            panelTotal.BorderSize = 1;
            panelTotal.BorderStyle = BorderStyle.FixedSingle;
            panelTotal.Controls.Add(iconTotalPayments);
            panelTotal.Controls.Add(lblTotalNumber);
            panelTotal.Controls.Add(lblTotalTitle);
            panelTotal.Location = new Point(422, 194);
            panelTotal.Margin = new Padding(3, 4, 3, 4);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(230, 87);
            panelTotal.TabIndex = 8;
            // 
            // iconTotalPayments
            // 
            iconTotalPayments.BackColor = Color.FromArgb(255, 220, 255);
            iconTotalPayments.ForeColor = SystemColors.ControlText;
            iconTotalPayments.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconTotalPayments.IconColor = SystemColors.ControlText;
            iconTotalPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconTotalPayments.IconSize = 30;
            iconTotalPayments.Location = new Point(3, 21);
            iconTotalPayments.Margin = new Padding(3, 4, 3, 4);
            iconTotalPayments.Name = "iconTotalPayments";
            iconTotalPayments.Size = new Size(30, 38);
            iconTotalPayments.TabIndex = 14;
            iconTotalPayments.TabStop = false;
            // 
            // lblTotalNumber
            // 
            lblTotalNumber.AutoSize = true;
            lblTotalNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNumber.Location = new Point(62, 44);
            lblTotalNumber.Name = "lblTotalNumber";
            lblTotalNumber.Size = new Size(111, 23);
            lblTotalNumber.TabIndex = 1;
            lblTotalNumber.Text = "EGP 145,000";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTitle.Location = new Point(27, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(157, 28);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Payments";
            lblTotalTitle.Click += lblTotalTitle_Click;
            // 
            // panelCancelled
            // 
            panelCancelled.BackColor = Color.FromArgb(255, 220, 210);
            panelCancelled.BorderColor = Color.FromArgb(36, 74, 112);
            panelCancelled.BorderRadius = 15;
            panelCancelled.BorderSize = 1;
            panelCancelled.BorderStyle = BorderStyle.FixedSingle;
            panelCancelled.Controls.Add(iconCancelled);
            panelCancelled.Controls.Add(lblCancelledNumber);
            panelCancelled.Controls.Add(lblCancelledTitle);
            panelCancelled.Location = new Point(1125, 194);
            panelCancelled.Margin = new Padding(3, 4, 3, 4);
            panelCancelled.Name = "panelCancelled";
            panelCancelled.Size = new Size(230, 87);
            panelCancelled.TabIndex = 12;
            // 
            // iconCancelled
            // 
            iconCancelled.BackColor = Color.FromArgb(255, 220, 210);
            iconCancelled.ForeColor = SystemColors.ControlText;
            iconCancelled.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconCancelled.IconColor = SystemColors.ControlText;
            iconCancelled.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCancelled.IconSize = 30;
            iconCancelled.Location = new Point(3, 21);
            iconCancelled.Margin = new Padding(3, 4, 3, 4);
            iconCancelled.Name = "iconCancelled";
            iconCancelled.Size = new Size(30, 38);
            iconCancelled.TabIndex = 14;
            iconCancelled.TabStop = false;
            // 
            // lblCancelledNumber
            // 
            lblCancelledNumber.AutoSize = true;
            lblCancelledNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCancelledNumber.Location = new Point(62, 44);
            lblCancelledNumber.Name = "lblCancelledNumber";
            lblCancelledNumber.Size = new Size(20, 23);
            lblCancelledNumber.TabIndex = 1;
            lblCancelledNumber.Text = "3";
            // 
            // lblCancelledTitle
            // 
            lblCancelledTitle.AutoSize = true;
            lblCancelledTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCancelledTitle.Location = new Point(27, 0);
            lblCancelledTitle.Name = "lblCancelledTitle";
            lblCancelledTitle.Size = new Size(103, 28);
            lblCancelledTitle.TabIndex = 0;
            lblCancelledTitle.Text = "Cancelled";
            // 
            // panelPending
            // 
            panelPending.BackColor = Color.FromArgb(250, 200, 255);
            panelPending.BorderColor = Color.FromArgb(36, 74, 112);
            panelPending.BorderRadius = 15;
            panelPending.BorderSize = 1;
            panelPending.BorderStyle = BorderStyle.FixedSingle;
            panelPending.Controls.Add(iconPendingPayments);
            panelPending.Controls.Add(lblPendingNumber);
            panelPending.Controls.Add(lblPendingTitle);
            panelPending.Location = new Point(889, 194);
            panelPending.Margin = new Padding(3, 4, 3, 4);
            panelPending.Name = "panelPending";
            panelPending.Size = new Size(230, 87);
            panelPending.TabIndex = 11;
            // 
            // iconPendingPayments
            // 
            iconPendingPayments.BackColor = Color.FromArgb(250, 200, 255);
            iconPendingPayments.ForeColor = SystemColors.ControlText;
            iconPendingPayments.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconPendingPayments.IconColor = SystemColors.ControlText;
            iconPendingPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPendingPayments.IconSize = 30;
            iconPendingPayments.Location = new Point(3, 21);
            iconPendingPayments.Margin = new Padding(3, 4, 3, 4);
            iconPendingPayments.Name = "iconPendingPayments";
            iconPendingPayments.Size = new Size(30, 38);
            iconPendingPayments.TabIndex = 14;
            iconPendingPayments.TabStop = false;
            // 
            // lblPendingNumber
            // 
            lblPendingNumber.AutoSize = true;
            lblPendingNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingNumber.Location = new Point(62, 44);
            lblPendingNumber.Name = "lblPendingNumber";
            lblPendingNumber.Size = new Size(20, 23);
            lblPendingNumber.TabIndex = 1;
            lblPendingNumber.Text = "6";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingTitle.Location = new Point(27, 0);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(186, 28);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "Pending Payments";
            // 
            // panelpaid
            // 
            panelpaid.BackColor = Color.FromArgb(220, 255, 230);
            panelpaid.BorderColor = Color.FromArgb(36, 74, 112);
            panelpaid.BorderRadius = 15;
            panelpaid.BorderSize = 1;
            panelpaid.BorderStyle = BorderStyle.FixedSingle;
            panelpaid.Controls.Add(iconPaidBookings);
            panelpaid.Controls.Add(lblPaidNumber);
            panelpaid.Controls.Add(lblPaidTitle);
            panelpaid.Location = new Point(653, 194);
            panelpaid.Margin = new Padding(3, 4, 3, 4);
            panelpaid.Name = "panelpaid";
            panelpaid.Size = new Size(230, 87);
            panelpaid.TabIndex = 10;
            // 
            // iconPaidBookings
            // 
            iconPaidBookings.BackColor = Color.FromArgb(220, 255, 230);
            iconPaidBookings.ForeColor = SystemColors.ControlText;
            iconPaidBookings.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPaidBookings.IconColor = SystemColors.ControlText;
            iconPaidBookings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPaidBookings.IconSize = 30;
            iconPaidBookings.Location = new Point(3, 21);
            iconPaidBookings.Margin = new Padding(3, 4, 3, 4);
            iconPaidBookings.Name = "iconPaidBookings";
            iconPaidBookings.Size = new Size(30, 38);
            iconPaidBookings.TabIndex = 14;
            iconPaidBookings.TabStop = false;
            // 
            // lblPaidNumber
            // 
            lblPaidNumber.AutoSize = true;
            lblPaidNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaidNumber.Location = new Point(62, 44);
            lblPaidNumber.Name = "lblPaidNumber";
            lblPaidNumber.Size = new Size(30, 23);
            lblPaidNumber.TabIndex = 1;
            lblPaidNumber.Text = "32";
            // 
            // lblPaidTitle
            // 
            lblPaidTitle.AutoSize = true;
            lblPaidTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaidTitle.Location = new Point(27, 0);
            lblPaidTitle.Name = "lblPaidTitle";
            lblPaidTitle.Size = new Size(146, 28);
            lblPaidTitle.TabIndex = 0;
            lblPaidTitle.Text = "Paid Bookings";
            lblPaidTitle.Click += lblPaidTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(25, 60);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(271, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage and track hotel payments";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // lblPaymentForm
            // 
            lblPaymentForm.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentForm.ForeColor = Color.White;
            lblPaymentForm.Location = new Point(20, 10);
            lblPaymentForm.Name = "lblPaymentForm";
            lblPaymentForm.Size = new Size(176, 50);
            lblPaymentForm.TabIndex = 0;
            lblPaymentForm.Text = "Payment Method";
            lblPaymentForm.Click += PaymentForm_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(6, 40, 62);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblPaymentForm);
            pnlHeader.Location = new Point(399, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1251, 140);
            pnlHeader.TabIndex = 17;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 1055);
            Controls.Add(pnlHeader);
            Controls.Add(dgvPayments);
            Controls.Add(panelTotal);
            Controls.Add(panelCancelled);
            Controls.Add(panelPending);
            Controls.Add(panelpaid);
            Controls.Add(panlsidebar);
            Controls.Add(panelRecord);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PaymentForm";
            Text = "Payment Method";
            Load += PaymentForm_Load;
            panelRecord.ResumeLayout(false);
            panelRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picclear).EndInit();
            ((System.ComponentModel.ISupportInitialize)picConfirm).EndInit();
            panelCash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)faMoneyBill).EndInit();
            panelCredit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)faCreditCard).EndInit();
            panelRecordHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Piccredit2).EndInit();
            panelBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)faLandmark).EndInit();
            panlsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)piclogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picreport).EndInit();
            ((System.ComponentModel.ISupportInitialize)picpayment).EndInit();
            ((System.ComponentModel.ISupportInitialize)picreservation).EndInit();
            ((System.ComponentModel.ISupportInitialize)piccustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pichome).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconTotalPayments).EndInit();
            panelCancelled.ResumeLayout(false);
            panelCancelled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCancelled).EndInit();
            panelPending.ResumeLayout(false);
            panelPending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPendingPayments).EndInit();
            panelpaid.ResumeLayout(false);
            panelpaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPaidBookings).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTotalNumber;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblPaidNumber;
        private System.Windows.Forms.Label lblPaidTitle;
        private System.Windows.Forms.Label lblCancelledTitle;
        private System.Windows.Forms.Label lblCancelledNumber;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Panel panelRecordHeader;
        private System.Windows.Forms.Label lblRecordTitle;
        private FontAwesome.Sharp.IconPictureBox Piccredit2;
        private System.Windows.Forms.ComboBox cbReservationId;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Panel panelCredit;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Panel panelBank;
        private System.Windows.Forms.Panel panelCash;
        private FontAwesome.Sharp.IconPictureBox faCreditCard;
        private FontAwesome.Sharp.IconPictureBox faLandmark;
        private FontAwesome.Sharp.IconPictureBox faMoneyBill;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirmPayment;
        private FontAwesome.Sharp.IconPictureBox picConfirm;
        private FontAwesome.Sharp.IconPictureBox picclear;
        private RoundedPanel panelTotal;
        private System.Windows.Forms.Panel panlsidebar;
        private RoundedPanel panelpaid;
        private RoundedPanel panelPending;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingNumber;
        private RoundedPanel panelCancelled;
        private FontAwesome.Sharp.IconPictureBox iconTotalPayments;
        private FontAwesome.Sharp.IconPictureBox iconPaidBookings;
        private FontAwesome.Sharp.IconPictureBox iconPendingPayments;
        private FontAwesome.Sharp.IconPictureBox iconCancelled;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRoomManagement;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.PictureBox pichome;
        private System.Windows.Forms.PictureBox picbed;
        private System.Windows.Forms.PictureBox piccustomer;
        private System.Windows.Forms.PictureBox picreport;
        private System.Windows.Forms.PictureBox picpayment;
        private System.Windows.Forms.PictureBox picreservation;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatus;
        private Label lblSubtitle;
        private Label lblPaymentForm;
        private Panel pnlHeader;
        private Button btnlogout;
        private PictureBox piclogout;
    }
}


