namespace VMSUI
{
    partial class FrmBooking
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
            this.windows7Theme1 = new Telerik.WinControls.Themes.Windows7Theme();
            this.BooingTabcontrol = new System.Windows.Forms.TabControl();
            this.Addbookingtabpage = new System.Windows.Forms.TabPage();
            this.bookingbottompanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bookingtoppanel = new System.Windows.Forms.Panel();
            this.cmboboxduration = new System.Windows.Forms.ComboBox();
            this.dtenddate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dtstrtdate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtboxtotalrate = new Telerik.WinControls.UI.RadTextBox();
            this.txtboxbaserate = new Telerik.WinControls.UI.RadTextBox();
            this.txtboxcnic = new Telerik.WinControls.UI.RadTextBox();
            this.txtboxSelectedratecard = new Telerik.WinControls.UI.RadTextBox();
            this.txtboxselectedvehicle = new Telerik.WinControls.UI.RadTextBox();
            this.txtboxcustomername = new Telerik.WinControls.UI.RadTextBox();
            this.btnBooking = new Telerik.WinControls.UI.RadButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewbookingtabpage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBookings = new Telerik.WinControls.UI.RadGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvbookingcustomers = new Telerik.WinControls.UI.RadGridView();
            this.dgvbookingvehicle = new Telerik.WinControls.UI.RadGridView();
            this.dgvbookingratecard = new Telerik.WinControls.UI.RadGridView();
            this.BooingTabcontrol.SuspendLayout();
            this.Addbookingtabpage.SuspendLayout();
            this.bookingbottompanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.bookingtoppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtenddate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtstrtdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxtotalrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxbaserate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxcnic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxSelectedratecard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxselectedvehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxcustomername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.viewbookingtabpage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingcustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingcustomers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingvehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingvehicle.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingratecard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingratecard.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BooingTabcontrol
            // 
            this.BooingTabcontrol.Controls.Add(this.Addbookingtabpage);
            this.BooingTabcontrol.Controls.Add(this.viewbookingtabpage);
            this.BooingTabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooingTabcontrol.Location = new System.Drawing.Point(0, 0);
            this.BooingTabcontrol.Name = "BooingTabcontrol";
            this.BooingTabcontrol.SelectedIndex = 0;
            this.BooingTabcontrol.Size = new System.Drawing.Size(1332, 779);
            this.BooingTabcontrol.TabIndex = 0;
            // 
            // Addbookingtabpage
            // 
            this.Addbookingtabpage.Controls.Add(this.bookingbottompanel);
            this.Addbookingtabpage.Controls.Add(this.bookingtoppanel);
            this.Addbookingtabpage.Location = new System.Drawing.Point(4, 25);
            this.Addbookingtabpage.Name = "Addbookingtabpage";
            this.Addbookingtabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Addbookingtabpage.Size = new System.Drawing.Size(1324, 750);
            this.Addbookingtabpage.TabIndex = 0;
            this.Addbookingtabpage.Text = "Add Booking";
            this.Addbookingtabpage.UseVisualStyleBackColor = true;
            // 
            // bookingbottompanel
            // 
            this.bookingbottompanel.Controls.Add(this.tableLayoutPanel2);
            this.bookingbottompanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingbottompanel.Location = new System.Drawing.Point(3, 295);
            this.bookingbottompanel.Name = "bookingbottompanel";
            this.bookingbottompanel.Size = new System.Drawing.Size(1318, 452);
            this.bookingbottompanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.2574F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.67578F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.06682F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvbookingratecard, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvbookingvehicle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvbookingcustomers, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1318, 452);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // bookingtoppanel
            // 
            this.bookingtoppanel.Controls.Add(this.cmboboxduration);
            this.bookingtoppanel.Controls.Add(this.dtenddate);
            this.bookingtoppanel.Controls.Add(this.dtstrtdate);
            this.bookingtoppanel.Controls.Add(this.txtboxtotalrate);
            this.bookingtoppanel.Controls.Add(this.txtboxbaserate);
            this.bookingtoppanel.Controls.Add(this.txtboxcnic);
            this.bookingtoppanel.Controls.Add(this.txtboxSelectedratecard);
            this.bookingtoppanel.Controls.Add(this.txtboxselectedvehicle);
            this.bookingtoppanel.Controls.Add(this.txtboxcustomername);
            this.bookingtoppanel.Controls.Add(this.btnBooking);
            this.bookingtoppanel.Controls.Add(this.label8);
            this.bookingtoppanel.Controls.Add(this.label7);
            this.bookingtoppanel.Controls.Add(this.radLabel1);
            this.bookingtoppanel.Controls.Add(this.label6);
            this.bookingtoppanel.Controls.Add(this.label5);
            this.bookingtoppanel.Controls.Add(this.label4);
            this.bookingtoppanel.Controls.Add(this.label3);
            this.bookingtoppanel.Controls.Add(this.label2);
            this.bookingtoppanel.Controls.Add(this.label1);
            this.bookingtoppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookingtoppanel.Location = new System.Drawing.Point(3, 3);
            this.bookingtoppanel.Name = "bookingtoppanel";
            this.bookingtoppanel.Size = new System.Drawing.Size(1318, 292);
            this.bookingtoppanel.TabIndex = 0;
            // 
            // cmboboxduration
            // 
            this.cmboboxduration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboboxduration.FormattingEnabled = true;
            this.cmboboxduration.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Montly"});
            this.cmboboxduration.Location = new System.Drawing.Point(147, 240);
            this.cmboboxduration.Name = "cmboboxduration";
            this.cmboboxduration.Size = new System.Drawing.Size(175, 24);
            this.cmboboxduration.TabIndex = 16;
            this.cmboboxduration.SelectedIndexChanged += new System.EventHandler(this.cmboboxduration_SelectedIndexChanged);
            // 
            // dtenddate
            // 
            this.dtenddate.Culture = new System.Globalization.CultureInfo("en-PK");
            this.dtenddate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtenddate.Location = new System.Drawing.Point(147, 184);
            this.dtenddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtenddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtenddate.Name = "dtenddate";
            this.dtenddate.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtenddate.Size = new System.Drawing.Size(175, 24);
            this.dtenddate.TabIndex = 15;
            this.dtenddate.TabStop = false;
            this.dtenddate.Text = "radDateTimePicker2";
            this.dtenddate.Value = new System.DateTime(2018, 8, 27, 15, 16, 35, 456);
            // 
            // dtstrtdate
            // 
            this.dtstrtdate.Culture = new System.Globalization.CultureInfo("en-PK");
            this.dtstrtdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtstrtdate.Location = new System.Drawing.Point(147, 141);
            this.dtstrtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtstrtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtstrtdate.Name = "dtstrtdate";
            this.dtstrtdate.NullDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtstrtdate.Size = new System.Drawing.Size(175, 24);
            this.dtstrtdate.TabIndex = 14;
            this.dtstrtdate.TabStop = false;
            this.dtstrtdate.Text = "radDateTimePicker1";
            this.dtstrtdate.Value = new System.DateTime(2018, 8, 27, 15, 16, 32, 21);
            // 
            // txtboxtotalrate
            // 
            this.txtboxtotalrate.Enabled = false;
            this.txtboxtotalrate.Location = new System.Drawing.Point(524, 136);
            this.txtboxtotalrate.Name = "txtboxtotalrate";
            this.txtboxtotalrate.Size = new System.Drawing.Size(175, 24);
            this.txtboxtotalrate.TabIndex = 12;
            this.txtboxtotalrate.TabStop = false;
            // 
            // txtboxbaserate
            // 
            this.txtboxbaserate.Enabled = false;
            this.txtboxbaserate.Location = new System.Drawing.Point(524, 67);
            this.txtboxbaserate.Name = "txtboxbaserate";
            this.txtboxbaserate.Size = new System.Drawing.Size(175, 24);
            this.txtboxbaserate.TabIndex = 12;
            this.txtboxbaserate.TabStop = false;
            // 
            // txtboxcnic
            // 
            this.txtboxcnic.Enabled = false;
            this.txtboxcnic.Location = new System.Drawing.Point(524, 19);
            this.txtboxcnic.Name = "txtboxcnic";
            this.txtboxcnic.Size = new System.Drawing.Size(175, 24);
            this.txtboxcnic.TabIndex = 12;
            this.txtboxcnic.TabStop = false;
            // 
            // txtboxSelectedratecard
            // 
            this.txtboxSelectedratecard.Enabled = false;
            this.txtboxSelectedratecard.Location = new System.Drawing.Point(147, 97);
            this.txtboxSelectedratecard.Name = "txtboxSelectedratecard";
            this.txtboxSelectedratecard.Size = new System.Drawing.Size(175, 24);
            this.txtboxSelectedratecard.TabIndex = 13;
            this.txtboxSelectedratecard.TabStop = false;
            // 
            // txtboxselectedvehicle
            // 
            this.txtboxselectedvehicle.Enabled = false;
            this.txtboxselectedvehicle.Location = new System.Drawing.Point(147, 58);
            this.txtboxselectedvehicle.Name = "txtboxselectedvehicle";
            this.txtboxselectedvehicle.Size = new System.Drawing.Size(175, 24);
            this.txtboxselectedvehicle.TabIndex = 12;
            this.txtboxselectedvehicle.TabStop = false;
            // 
            // txtboxcustomername
            // 
            this.txtboxcustomername.Enabled = false;
            this.txtboxcustomername.Location = new System.Drawing.Point(147, 19);
            this.txtboxcustomername.Name = "txtboxcustomername";
            this.txtboxcustomername.Size = new System.Drawing.Size(175, 24);
            this.txtboxcustomername.TabIndex = 11;
            this.txtboxcustomername.TabStop = false;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(524, 228);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(197, 46);
            this.btnBooking.TabIndex = 10;
            this.btnBooking.Text = "Add Booking";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Base Rate";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(437, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 22);
            this.radLabel1.TabIndex = 7;
            this.radLabel1.Text = "CNIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Booking Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected Rate Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers Name";
            // 
            // viewbookingtabpage
            // 
            this.viewbookingtabpage.Controls.Add(this.tableLayoutPanel1);
            this.viewbookingtabpage.Location = new System.Drawing.Point(4, 25);
            this.viewbookingtabpage.Name = "viewbookingtabpage";
            this.viewbookingtabpage.Padding = new System.Windows.Forms.Padding(3);
            this.viewbookingtabpage.Size = new System.Drawing.Size(1324, 750);
            this.viewbookingtabpage.TabIndex = 1;
            this.viewbookingtabpage.Text = "View Bookings";
            this.viewbookingtabpage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBookings, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.25269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.74731F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1318, 744);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoSizeRows = true;
            this.dgvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookings.Location = new System.Drawing.Point(3, 3);
            // 
            // dgvBookings
            // 
            this.dgvBookings.MasterTemplate.AllowAddNewRow = false;
            this.dgvBookings.MasterTemplate.AllowDeleteRow = false;
            this.dgvBookings.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.MasterTemplate.EnableFiltering = true;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.Size = new System.Drawing.Size(1312, 353);
            this.dgvBookings.TabIndex = 2;
            this.dgvBookings.Text = "radGridView1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 45);
            this.label9.TabIndex = 17;
            this.label9.Text = "Select Customer";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(441, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(312, 45);
            this.label10.TabIndex = 18;
            this.label10.Text = "Select Rate Card";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(845, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 45);
            this.label11.TabIndex = 19;
            this.label11.Text = "Select Vehicle";
            // 
            // dgvbookingcustomers
            // 
            this.dgvbookingcustomers.AutoSizeRows = true;
            this.dgvbookingcustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvbookingcustomers.Location = new System.Drawing.Point(3, 48);
            // 
            // dgvbookingcustomers
            // 
            this.dgvbookingcustomers.MasterTemplate.AllowAddNewRow = false;
            this.dgvbookingcustomers.MasterTemplate.AllowDeleteRow = false;
            this.dgvbookingcustomers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvbookingcustomers.MasterTemplate.EnableFiltering = true;
            this.dgvbookingcustomers.Name = "dgvbookingcustomers";
            this.dgvbookingcustomers.ReadOnly = true;
            this.dgvbookingcustomers.Size = new System.Drawing.Size(432, 401);
            this.dgvbookingcustomers.TabIndex = 21;
            this.dgvbookingcustomers.Text = "radGridView1";
            this.dgvbookingcustomers.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvbookingcustomers_CellDoubleClick);
            // 
            // dgvbookingvehicle
            // 
            this.dgvbookingvehicle.AutoSizeRows = true;
            this.dgvbookingvehicle.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvbookingvehicle.Location = new System.Drawing.Point(845, 48);
            // 
            // dgvbookingvehicle
            // 
            this.dgvbookingvehicle.MasterTemplate.AllowAddNewRow = false;
            this.dgvbookingvehicle.MasterTemplate.AllowDeleteRow = false;
            this.dgvbookingvehicle.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvbookingvehicle.MasterTemplate.EnableFiltering = true;
            this.dgvbookingvehicle.Name = "dgvbookingvehicle";
            this.dgvbookingvehicle.ReadOnly = true;
            this.dgvbookingvehicle.Size = new System.Drawing.Size(433, 401);
            this.dgvbookingvehicle.TabIndex = 22;
            this.dgvbookingvehicle.Text = "radGridView1";
            this.dgvbookingvehicle.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvbookingvehicle_CellDoubleClick);
            // 
            // dgvbookingratecard
            // 
            this.dgvbookingratecard.AutoSizeRows = true;
            this.dgvbookingratecard.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvbookingratecard.Location = new System.Drawing.Point(441, 48);
            // 
            // dgvbookingratecard
            // 
            this.dgvbookingratecard.MasterTemplate.AllowAddNewRow = false;
            this.dgvbookingratecard.MasterTemplate.AllowDeleteRow = false;
            this.dgvbookingratecard.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvbookingratecard.MasterTemplate.EnableFiltering = true;
            this.dgvbookingratecard.Name = "dgvbookingratecard";
            this.dgvbookingratecard.ReadOnly = true;
            this.dgvbookingratecard.Size = new System.Drawing.Size(398, 401);
            this.dgvbookingratecard.TabIndex = 23;
            this.dgvbookingratecard.Text = "radGridView1";
            this.dgvbookingratecard.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvbookingratecard_CellDoubleClick);
            // 
            // FrmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 779);
            this.Controls.Add(this.BooingTabcontrol);
            this.Name = "FrmBooking";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BooingTabcontrol.ResumeLayout(false);
            this.Addbookingtabpage.ResumeLayout(false);
            this.bookingbottompanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.bookingtoppanel.ResumeLayout(false);
            this.bookingtoppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtenddate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtstrtdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxtotalrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxbaserate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxcnic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxSelectedratecard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxselectedvehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxcustomername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.viewbookingtabpage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingcustomers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingcustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingvehicle.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingvehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingratecard.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbookingratecard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Windows7Theme windows7Theme1;
        private System.Windows.Forms.TabControl BooingTabcontrol;
        private System.Windows.Forms.TabPage Addbookingtabpage;
        private System.Windows.Forms.Panel bookingbottompanel;
        private System.Windows.Forms.Panel bookingtoppanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage viewbookingtabpage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnBooking;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker dtenddate;
        private Telerik.WinControls.UI.RadDateTimePicker dtstrtdate;
        private Telerik.WinControls.UI.RadTextBox txtboxtotalrate;
        private Telerik.WinControls.UI.RadTextBox txtboxbaserate;
        private Telerik.WinControls.UI.RadTextBox txtboxcnic;
        private Telerik.WinControls.UI.RadTextBox txtboxSelectedratecard;
        private Telerik.WinControls.UI.RadTextBox txtboxselectedvehicle;
        private Telerik.WinControls.UI.RadTextBox txtboxcustomername;
        private System.Windows.Forms.ComboBox cmboboxduration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadGridView dgvBookings;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Telerik.WinControls.UI.RadGridView dgvbookingratecard;
        private Telerik.WinControls.UI.RadGridView dgvbookingvehicle;
        private Telerik.WinControls.UI.RadGridView dgvbookingcustomers;
    }
}