namespace AAVD___Proyecto_Final.Forms
{
    partial class Home_Menu
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
            this.pnlPrincipalMenu = new System.Windows.Forms.Panel();
            this.pnlSMCheckAndCancel = new System.Windows.Forms.Panel();
            this.btnSMCancelation = new System.Windows.Forms.Button();
            this.btnSMCheckOut = new System.Windows.Forms.Button();
            this.btnSMCheckIn = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnCRUDClient = new System.Windows.Forms.Button();
            this.pnlSMEmployeeManagment = new System.Windows.Forms.Panel();
            this.btnSMCRUDEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeManagment = new System.Windows.Forms.Button();
            this.pnlSMHotelManagment = new System.Windows.Forms.Panel();
            this.btnSMCRUDRooms = new System.Windows.Forms.Button();
            this.btnSMCRUDHotel = new System.Windows.Forms.Button();
            this.btnHotelManagment = new System.Windows.Forms.Button();
            this.pnlSMSystemReport = new System.Windows.Forms.Panel();
            this.btnSMHotelOccupancy = new System.Windows.Forms.Button();
            this.btnSMCustomerRecord = new System.Windows.Forms.Button();
            this.btnSMSalesReport = new System.Windows.Forms.Button();
            this.btnSystemReport = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlPrincipalMenu.SuspendLayout();
            this.pnlSMCheckAndCancel.SuspendLayout();
            this.pnlSMEmployeeManagment.SuspendLayout();
            this.pnlSMHotelManagment.SuspendLayout();
            this.pnlSMSystemReport.SuspendLayout();
            this.pnlTittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipalMenu
            // 
            this.pnlPrincipalMenu.AutoScroll = true;
            this.pnlPrincipalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlPrincipalMenu.Controls.Add(this.pnlSMCheckAndCancel);
            this.pnlPrincipalMenu.Controls.Add(this.btnReservations);
            this.pnlPrincipalMenu.Controls.Add(this.btnAddReservation);
            this.pnlPrincipalMenu.Controls.Add(this.btnCRUDClient);
            this.pnlPrincipalMenu.Controls.Add(this.pnlSMEmployeeManagment);
            this.pnlPrincipalMenu.Controls.Add(this.btnEmployeeManagment);
            this.pnlPrincipalMenu.Controls.Add(this.pnlSMHotelManagment);
            this.pnlPrincipalMenu.Controls.Add(this.btnHotelManagment);
            this.pnlPrincipalMenu.Controls.Add(this.pnlSMSystemReport);
            this.pnlPrincipalMenu.Controls.Add(this.btnSystemReport);
            this.pnlPrincipalMenu.Controls.Add(this.pnlLogo);
            this.pnlPrincipalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrincipalMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipalMenu.Name = "pnlPrincipalMenu";
            this.pnlPrincipalMenu.Size = new System.Drawing.Size(305, 1021);
            this.pnlPrincipalMenu.TabIndex = 0;
            // 
            // pnlSMCheckAndCancel
            // 
            this.pnlSMCheckAndCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlSMCheckAndCancel.Controls.Add(this.btnSMCancelation);
            this.pnlSMCheckAndCancel.Controls.Add(this.btnSMCheckOut);
            this.pnlSMCheckAndCancel.Controls.Add(this.btnSMCheckIn);
            this.pnlSMCheckAndCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSMCheckAndCancel.Location = new System.Drawing.Point(0, 921);
            this.pnlSMCheckAndCancel.Name = "pnlSMCheckAndCancel";
            this.pnlSMCheckAndCancel.Size = new System.Drawing.Size(284, 160);
            this.pnlSMCheckAndCancel.TabIndex = 10;
            // 
            // btnSMCancelation
            // 
            this.btnSMCancelation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCancelation.FlatAppearance.BorderSize = 0;
            this.btnSMCancelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCancelation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCancelation.Image = global::AAVD___Proyecto_Final.Properties.Resources.cancelation_icon;
            this.btnSMCancelation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCancelation.Location = new System.Drawing.Point(0, 100);
            this.btnSMCancelation.Name = "btnSMCancelation";
            this.btnSMCancelation.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCancelation.Size = new System.Drawing.Size(284, 50);
            this.btnSMCancelation.TabIndex = 2;
            this.btnSMCancelation.Text = "Cancel reservation";
            this.btnSMCancelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCancelation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCancelation.UseVisualStyleBackColor = true;
            this.btnSMCancelation.Click += new System.EventHandler(this.btnSMCancelation_Click);
            // 
            // btnSMCheckOut
            // 
            this.btnSMCheckOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCheckOut.FlatAppearance.BorderSize = 0;
            this.btnSMCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCheckOut.Image = global::AAVD___Proyecto_Final.Properties.Resources.CheckIn_icon;
            this.btnSMCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCheckOut.Location = new System.Drawing.Point(0, 50);
            this.btnSMCheckOut.Name = "btnSMCheckOut";
            this.btnSMCheckOut.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCheckOut.Size = new System.Drawing.Size(284, 50);
            this.btnSMCheckOut.TabIndex = 1;
            this.btnSMCheckOut.Text = "Check out";
            this.btnSMCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCheckOut.UseVisualStyleBackColor = true;
            this.btnSMCheckOut.Click += new System.EventHandler(this.btnSMCheckOut_Click);
            // 
            // btnSMCheckIn
            // 
            this.btnSMCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCheckIn.FlatAppearance.BorderSize = 0;
            this.btnSMCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCheckIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCheckIn.Image = global::AAVD___Proyecto_Final.Properties.Resources.CheckIn_icon;
            this.btnSMCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCheckIn.Location = new System.Drawing.Point(0, 0);
            this.btnSMCheckIn.Name = "btnSMCheckIn";
            this.btnSMCheckIn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCheckIn.Size = new System.Drawing.Size(284, 50);
            this.btnSMCheckIn.TabIndex = 0;
            this.btnSMCheckIn.Text = "Check in";
            this.btnSMCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCheckIn.UseVisualStyleBackColor = true;
            this.btnSMCheckIn.Click += new System.EventHandler(this.btnSMCheckIn_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReservations.Image = global::AAVD___Proyecto_Final.Properties.Resources.reservation_icon;
            this.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.Location = new System.Drawing.Point(0, 841);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(284, 80);
            this.btnReservations.TabIndex = 9;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnAddReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddReservation.FlatAppearance.BorderSize = 0;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddReservation.Image = global::AAVD___Proyecto_Final.Properties.Resources.reserva_icon;
            this.btnAddReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReservation.Location = new System.Drawing.Point(0, 761);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(284, 80);
            this.btnAddReservation.TabIndex = 8;
            this.btnAddReservation.Text = "Add reservation";
            this.btnAddReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnCRUDClient
            // 
            this.btnCRUDClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnCRUDClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCRUDClient.FlatAppearance.BorderSize = 0;
            this.btnCRUDClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCRUDClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCRUDClient.Image = global::AAVD___Proyecto_Final.Properties.Resources.Client_icon;
            this.btnCRUDClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRUDClient.Location = new System.Drawing.Point(0, 681);
            this.btnCRUDClient.Name = "btnCRUDClient";
            this.btnCRUDClient.Size = new System.Drawing.Size(284, 80);
            this.btnCRUDClient.TabIndex = 7;
            this.btnCRUDClient.Text = "Add / Edit / Delete Client";
            this.btnCRUDClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRUDClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCRUDClient.UseVisualStyleBackColor = false;
            this.btnCRUDClient.Click += new System.EventHandler(this.btnCRUDClient_Click);
            // 
            // pnlSMEmployeeManagment
            // 
            this.pnlSMEmployeeManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlSMEmployeeManagment.Controls.Add(this.btnSMCRUDEmployee);
            this.pnlSMEmployeeManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSMEmployeeManagment.Location = new System.Drawing.Point(0, 621);
            this.pnlSMEmployeeManagment.Name = "pnlSMEmployeeManagment";
            this.pnlSMEmployeeManagment.Size = new System.Drawing.Size(284, 60);
            this.pnlSMEmployeeManagment.TabIndex = 6;
            // 
            // btnSMCRUDEmployee
            // 
            this.btnSMCRUDEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCRUDEmployee.FlatAppearance.BorderSize = 0;
            this.btnSMCRUDEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCRUDEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCRUDEmployee.Image = global::AAVD___Proyecto_Final.Properties.Resources.Edit_hotel;
            this.btnSMCRUDEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCRUDEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnSMCRUDEmployee.Name = "btnSMCRUDEmployee";
            this.btnSMCRUDEmployee.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCRUDEmployee.Size = new System.Drawing.Size(284, 50);
            this.btnSMCRUDEmployee.TabIndex = 0;
            this.btnSMCRUDEmployee.Text = "Add / Edit / Delete Employee(s)";
            this.btnSMCRUDEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCRUDEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCRUDEmployee.UseVisualStyleBackColor = true;
            this.btnSMCRUDEmployee.Click += new System.EventHandler(this.btnSMCRUDEmployee_Click);
            // 
            // btnEmployeeManagment
            // 
            this.btnEmployeeManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnEmployeeManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployeeManagment.FlatAppearance.BorderSize = 0;
            this.btnEmployeeManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployeeManagment.Image = global::AAVD___Proyecto_Final.Properties.Resources.Employee_icon;
            this.btnEmployeeManagment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagment.Location = new System.Drawing.Point(0, 541);
            this.btnEmployeeManagment.Name = "btnEmployeeManagment";
            this.btnEmployeeManagment.Size = new System.Drawing.Size(284, 80);
            this.btnEmployeeManagment.TabIndex = 5;
            this.btnEmployeeManagment.Text = "Employee Managment";
            this.btnEmployeeManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeManagment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeManagment.UseVisualStyleBackColor = false;
            this.btnEmployeeManagment.Click += new System.EventHandler(this.btnEmployeeManagment_Click);
            // 
            // pnlSMHotelManagment
            // 
            this.pnlSMHotelManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlSMHotelManagment.Controls.Add(this.btnSMCRUDRooms);
            this.pnlSMHotelManagment.Controls.Add(this.btnSMCRUDHotel);
            this.pnlSMHotelManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSMHotelManagment.Location = new System.Drawing.Point(0, 431);
            this.pnlSMHotelManagment.Name = "pnlSMHotelManagment";
            this.pnlSMHotelManagment.Size = new System.Drawing.Size(284, 110);
            this.pnlSMHotelManagment.TabIndex = 4;
            // 
            // btnSMCRUDRooms
            // 
            this.btnSMCRUDRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCRUDRooms.FlatAppearance.BorderSize = 0;
            this.btnSMCRUDRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCRUDRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCRUDRooms.Image = global::AAVD___Proyecto_Final.Properties.Resources.Edit_hotel;
            this.btnSMCRUDRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCRUDRooms.Location = new System.Drawing.Point(0, 50);
            this.btnSMCRUDRooms.Name = "btnSMCRUDRooms";
            this.btnSMCRUDRooms.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCRUDRooms.Size = new System.Drawing.Size(284, 50);
            this.btnSMCRUDRooms.TabIndex = 1;
            this.btnSMCRUDRooms.Text = "Add / Edit / Delete Room(s)";
            this.btnSMCRUDRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCRUDRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCRUDRooms.UseVisualStyleBackColor = true;
            this.btnSMCRUDRooms.Click += new System.EventHandler(this.btnSMCRUDRooms_Click);
            // 
            // btnSMCRUDHotel
            // 
            this.btnSMCRUDHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCRUDHotel.FlatAppearance.BorderSize = 0;
            this.btnSMCRUDHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCRUDHotel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCRUDHotel.Image = global::AAVD___Proyecto_Final.Properties.Resources.Edit_hotel;
            this.btnSMCRUDHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCRUDHotel.Location = new System.Drawing.Point(0, 0);
            this.btnSMCRUDHotel.Name = "btnSMCRUDHotel";
            this.btnSMCRUDHotel.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCRUDHotel.Size = new System.Drawing.Size(284, 50);
            this.btnSMCRUDHotel.TabIndex = 0;
            this.btnSMCRUDHotel.Text = "Add / Edit / Delete Hotel";
            this.btnSMCRUDHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCRUDHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCRUDHotel.UseVisualStyleBackColor = true;
            this.btnSMCRUDHotel.Click += new System.EventHandler(this.btnSMCRUDHotel_Click);
            // 
            // btnHotelManagment
            // 
            this.btnHotelManagment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnHotelManagment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHotelManagment.FlatAppearance.BorderSize = 0;
            this.btnHotelManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelManagment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHotelManagment.Image = global::AAVD___Proyecto_Final.Properties.Resources.hotel_icon;
            this.btnHotelManagment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelManagment.Location = new System.Drawing.Point(0, 351);
            this.btnHotelManagment.Name = "btnHotelManagment";
            this.btnHotelManagment.Size = new System.Drawing.Size(284, 80);
            this.btnHotelManagment.TabIndex = 3;
            this.btnHotelManagment.Text = "Hotel Managment";
            this.btnHotelManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelManagment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHotelManagment.UseVisualStyleBackColor = false;
            this.btnHotelManagment.Click += new System.EventHandler(this.btnHotelManagment_Click);
            // 
            // pnlSMSystemReport
            // 
            this.pnlSMSystemReport.Controls.Add(this.btnSMHotelOccupancy);
            this.pnlSMSystemReport.Controls.Add(this.btnSMCustomerRecord);
            this.pnlSMSystemReport.Controls.Add(this.btnSMSalesReport);
            this.pnlSMSystemReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSMSystemReport.Location = new System.Drawing.Point(0, 191);
            this.pnlSMSystemReport.Name = "pnlSMSystemReport";
            this.pnlSMSystemReport.Size = new System.Drawing.Size(284, 160);
            this.pnlSMSystemReport.TabIndex = 2;
            // 
            // btnSMHotelOccupancy
            // 
            this.btnSMHotelOccupancy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSMHotelOccupancy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMHotelOccupancy.FlatAppearance.BorderSize = 0;
            this.btnSMHotelOccupancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMHotelOccupancy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMHotelOccupancy.Image = global::AAVD___Proyecto_Final.Properties.Resources.hotel_occupancy_icon;
            this.btnSMHotelOccupancy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMHotelOccupancy.Location = new System.Drawing.Point(0, 100);
            this.btnSMHotelOccupancy.Name = "btnSMHotelOccupancy";
            this.btnSMHotelOccupancy.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMHotelOccupancy.Size = new System.Drawing.Size(284, 50);
            this.btnSMHotelOccupancy.TabIndex = 2;
            this.btnSMHotelOccupancy.Text = "Hotel Occupancy";
            this.btnSMHotelOccupancy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMHotelOccupancy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMHotelOccupancy.UseVisualStyleBackColor = false;
            this.btnSMHotelOccupancy.Click += new System.EventHandler(this.btnSMHotelOccupancy_Click);
            // 
            // btnSMCustomerRecord
            // 
            this.btnSMCustomerRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSMCustomerRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCustomerRecord.FlatAppearance.BorderSize = 0;
            this.btnSMCustomerRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCustomerRecord.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMCustomerRecord.Image = global::AAVD___Proyecto_Final.Properties.Resources.customer_historial_icon;
            this.btnSMCustomerRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCustomerRecord.Location = new System.Drawing.Point(0, 50);
            this.btnSMCustomerRecord.Name = "btnSMCustomerRecord";
            this.btnSMCustomerRecord.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMCustomerRecord.Size = new System.Drawing.Size(284, 50);
            this.btnSMCustomerRecord.TabIndex = 1;
            this.btnSMCustomerRecord.Text = "Customer record";
            this.btnSMCustomerRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCustomerRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMCustomerRecord.UseVisualStyleBackColor = false;
            this.btnSMCustomerRecord.Click += new System.EventHandler(this.btnSMCustomerRecord_Click);
            // 
            // btnSMSalesReport
            // 
            this.btnSMSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSMSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSMSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMSalesReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSMSalesReport.Image = global::AAVD___Proyecto_Final.Properties.Resources.sales_icon;
            this.btnSMSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMSalesReport.Location = new System.Drawing.Point(0, 0);
            this.btnSMSalesReport.Name = "btnSMSalesReport";
            this.btnSMSalesReport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSMSalesReport.Size = new System.Drawing.Size(284, 50);
            this.btnSMSalesReport.TabIndex = 0;
            this.btnSMSalesReport.Text = "Sales report";
            this.btnSMSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSMSalesReport.UseVisualStyleBackColor = false;
            this.btnSMSalesReport.Click += new System.EventHandler(this.btnSMSalesReport_Click);
            // 
            // btnSystemReport
            // 
            this.btnSystemReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSystemReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemReport.FlatAppearance.BorderSize = 0;
            this.btnSystemReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystemReport.Image = global::AAVD___Proyecto_Final.Properties.Resources.System_report;
            this.btnSystemReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemReport.Location = new System.Drawing.Point(0, 111);
            this.btnSystemReport.Name = "btnSystemReport";
            this.btnSystemReport.Size = new System.Drawing.Size(284, 80);
            this.btnSystemReport.TabIndex = 1;
            this.btnSystemReport.Text = "System report";
            this.btnSystemReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemReport.UseVisualStyleBackColor = false;
            this.btnSystemReport.Click += new System.EventHandler(this.btnSystemReport_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(284, 111);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.Color.Teal;
            this.pnlTittle.Controls.Add(this.lblTittle);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittle.Location = new System.Drawing.Point(305, 0);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(1021, 111);
            this.pnlTittle.TabIndex = 1;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(481, 42);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(109, 29);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "H O M E";
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(305, 111);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1021, 910);
            this.pnlChildForm.TabIndex = 2;
            // 
            // Home_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1326, 1021);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.pnlPrincipalMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(550, 600);
            this.Name = "Home_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home menu - [ Nombre por asignar ]";
            this.pnlPrincipalMenu.ResumeLayout(false);
            this.pnlSMCheckAndCancel.ResumeLayout(false);
            this.pnlSMEmployeeManagment.ResumeLayout(false);
            this.pnlSMHotelManagment.ResumeLayout(false);
            this.pnlSMSystemReport.ResumeLayout(false);
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipalMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlSMSystemReport;
        private System.Windows.Forms.Button btnSMSalesReport;
        private System.Windows.Forms.Button btnSMHotelOccupancy;
        private System.Windows.Forms.Button btnSMCustomerRecord;
        private System.Windows.Forms.Button btnHotelManagment;
        private System.Windows.Forms.Panel pnlSMHotelManagment;
        private System.Windows.Forms.Button btnSMCRUDHotel;
        private System.Windows.Forms.Button btnEmployeeManagment;
        private System.Windows.Forms.Button btnSMCRUDRooms;
        private System.Windows.Forms.Panel pnlSMEmployeeManagment;
        private System.Windows.Forms.Button btnCRUDClient;
        private System.Windows.Forms.Button btnSMCRUDEmployee;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Panel pnlSMCheckAndCancel;
        private System.Windows.Forms.Button btnSMCheckIn;
        private System.Windows.Forms.Button btnSMCancelation;
        private System.Windows.Forms.Button btnSMCheckOut;
        private System.Windows.Forms.Button btnSystemReport;
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}