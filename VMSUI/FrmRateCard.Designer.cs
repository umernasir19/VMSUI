namespace VMSUI
{
    partial class FrmRateCard
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtboxratecardname = new System.Windows.Forms.TextBox();
            this.comboBoxMaker = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.txtboxbaserate = new System.Windows.Forms.TextBox();
            this.txtBoxDailyRate = new System.Windows.Forms.TextBox();
            this.txtBoxWeeklyRate = new System.Windows.Forms.TextBox();
            this.txtBoxMonthlyRate = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnaddratecard = new Telerik.WinControls.UI.RadButton();
            this.radiobtninactive = new System.Windows.Forms.RadioButton();
            this.radiobtnactive = new System.Windows.Forms.RadioButton();
            this.dtenddate = new System.Windows.Forms.DateTimePicker();
            this.dtstrtdate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvratecard = new Telerik.WinControls.UI.RadGridView();
            this.dtstarttime = new System.Windows.Forms.DateTimePicker();
            this.dtendtime = new System.Windows.Forms.DateTimePicker();
            this.lblstrt = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddratecard)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvratecard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvratecard.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(428, 17);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // txtboxratecardname
            // 
            this.txtboxratecardname.Location = new System.Drawing.Point(428, 124);
            this.txtboxratecardname.Name = "txtboxratecardname";
            this.txtboxratecardname.Size = new System.Drawing.Size(200, 22);
            this.txtboxratecardname.TabIndex = 1;
            // 
            // comboBoxMaker
            // 
            this.comboBoxMaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaker.FormattingEnabled = true;
            this.comboBoxMaker.Location = new System.Drawing.Point(428, 47);
            this.comboBoxMaker.Name = "comboBoxMaker";
            this.comboBoxMaker.Size = new System.Drawing.Size(200, 24);
            this.comboBoxMaker.TabIndex = 2;
            this.comboBoxMaker.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(428, 77);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 24);
            this.comboBoxModel.TabIndex = 3;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // txtboxbaserate
            // 
            this.txtboxbaserate.Location = new System.Drawing.Point(428, 172);
            this.txtboxbaserate.Name = "txtboxbaserate";
            this.txtboxbaserate.Size = new System.Drawing.Size(200, 22);
            this.txtboxbaserate.TabIndex = 4;
            // 
            // txtBoxDailyRate
            // 
            this.txtBoxDailyRate.Location = new System.Drawing.Point(428, 222);
            this.txtBoxDailyRate.Name = "txtBoxDailyRate";
            this.txtBoxDailyRate.Size = new System.Drawing.Size(200, 22);
            this.txtBoxDailyRate.TabIndex = 5;
            // 
            // txtBoxWeeklyRate
            // 
            this.txtBoxWeeklyRate.Location = new System.Drawing.Point(428, 271);
            this.txtBoxWeeklyRate.Name = "txtBoxWeeklyRate";
            this.txtBoxWeeklyRate.Size = new System.Drawing.Size(200, 22);
            this.txtBoxWeeklyRate.TabIndex = 6;
            // 
            // txtBoxMonthlyRate
            // 
            this.txtBoxMonthlyRate.Location = new System.Drawing.Point(428, 333);
            this.txtBoxMonthlyRate.Name = "txtBoxMonthlyRate";
            this.txtBoxMonthlyRate.Size = new System.Drawing.Size(200, 22);
            this.txtBoxMonthlyRate.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 619);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblend);
            this.tabPage1.Controls.Add(this.lblstrt);
            this.tabPage1.Controls.Add(this.dtendtime);
            this.tabPage1.Controls.Add(this.dtstarttime);
            this.tabPage1.Controls.Add(this.btnaddratecard);
            this.tabPage1.Controls.Add(this.radiobtninactive);
            this.tabPage1.Controls.Add(this.radiobtnactive);
            this.tabPage1.Controls.Add(this.dtenddate);
            this.tabPage1.Controls.Add(this.dtstrtdate);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxCategory);
            this.tabPage1.Controls.Add(this.txtBoxMonthlyRate);
            this.tabPage1.Controls.Add(this.txtboxratecardname);
            this.tabPage1.Controls.Add(this.txtBoxWeeklyRate);
            this.tabPage1.Controls.Add(this.comboBoxMaker);
            this.tabPage1.Controls.Add(this.txtBoxDailyRate);
            this.tabPage1.Controls.Add(this.comboBoxModel);
            this.tabPage1.Controls.Add(this.txtboxbaserate);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1384, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Rate Card";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnaddratecard
            // 
            this.btnaddratecard.Location = new System.Drawing.Point(428, 515);
            this.btnaddratecard.Name = "btnaddratecard";
            this.btnaddratecard.Size = new System.Drawing.Size(200, 43);
            this.btnaddratecard.TabIndex = 23;
            this.btnaddratecard.Text = "Add Rate Card";
            this.btnaddratecard.Click += new System.EventHandler(this.btnaddratecard_Click);
            // 
            // radiobtninactive
            // 
            this.radiobtninactive.AutoSize = true;
            this.radiobtninactive.Location = new System.Drawing.Point(556, 460);
            this.radiobtninactive.Name = "radiobtninactive";
            this.radiobtninactive.Size = new System.Drawing.Size(79, 23);
            this.radiobtninactive.TabIndex = 22;
            this.radiobtninactive.TabStop = true;
            this.radiobtninactive.Text = "InActive";
            this.radiobtninactive.UseVisualStyleBackColor = true;
            // 
            // radiobtnactive
            // 
            this.radiobtnactive.AutoSize = true;
            this.radiobtnactive.Location = new System.Drawing.Point(428, 460);
            this.radiobtnactive.Name = "radiobtnactive";
            this.radiobtnactive.Size = new System.Drawing.Size(67, 23);
            this.radiobtnactive.TabIndex = 21;
            this.radiobtnactive.TabStop = true;
            this.radiobtnactive.Text = "Active";
            this.radiobtnactive.UseVisualStyleBackColor = true;
            // 
            // dtenddate
            // 
            this.dtenddate.Location = new System.Drawing.Point(428, 414);
            this.dtenddate.Name = "dtenddate";
            this.dtenddate.Size = new System.Drawing.Size(200, 22);
            this.dtenddate.TabIndex = 20;
            this.dtenddate.ValueChanged += new System.EventHandler(this.dtenddate_ValueChanged);
            // 
            // dtstrtdate
            // 
            this.dtstrtdate.Location = new System.Drawing.Point(428, 374);
            this.dtstrtdate.Name = "dtstrtdate";
            this.dtstrtdate.Size = new System.Drawing.Size(200, 22);
            this.dtstrtdate.TabIndex = 19;
            this.dtstrtdate.ValueChanged += new System.EventHandler(this.dtstrtdate_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 462);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Active/InActive";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter Maker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Monthly Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Weekly Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Daily Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Base Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rate Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Category";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvratecard);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1384, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Rate Cards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvratecard
            // 
            this.dgvratecard.AutoSizeRows = true;
            this.dgvratecard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvratecard.Location = new System.Drawing.Point(3, 3);
            // 
            // dgvratecard
            // 
            this.dgvratecard.MasterTemplate.AllowAddNewRow = false;
            this.dgvratecard.MasterTemplate.AllowDeleteRow = false;
            this.dgvratecard.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvratecard.MasterTemplate.EnableFiltering = true;
            this.dgvratecard.Name = "dgvratecard";
            this.dgvratecard.ReadOnly = true;
            this.dgvratecard.Size = new System.Drawing.Size(1378, 584);
            this.dgvratecard.TabIndex = 2;
            this.dgvratecard.Text = "radGridView1";
            this.dgvratecard.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvratecard_CellDoubleClick);
            this.dgvratecard.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.dgvratecard_CommandCellClick_1);
            // 
            // dtstarttime
            // 
            this.dtstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtstarttime.Location = new System.Drawing.Point(913, 375);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.ShowUpDown = true;
            this.dtstarttime.Size = new System.Drawing.Size(200, 22);
            this.dtstarttime.TabIndex = 24;
            this.dtstarttime.Visible = false;
            this.dtstarttime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtendtime
            // 
            this.dtendtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtendtime.Location = new System.Drawing.Point(913, 418);
            this.dtendtime.Name = "dtendtime";
            this.dtendtime.ShowUpDown = true;
            this.dtendtime.Size = new System.Drawing.Size(200, 22);
            this.dtendtime.TabIndex = 25;
            this.dtendtime.Visible = false;
            this.dtendtime.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblstrt
            // 
            this.lblstrt.AutoSize = true;
            this.lblstrt.Location = new System.Drawing.Point(748, 375);
            this.lblstrt.Name = "lblstrt";
            this.lblstrt.Size = new System.Drawing.Size(69, 19);
            this.lblstrt.TabIndex = 26;
            this.lblstrt.Text = "Start time";
            this.lblstrt.Visible = false;
            this.lblstrt.Click += new System.EventHandler(this.lblstrt_Click);
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(748, 418);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(65, 19);
            this.lblend.TabIndex = 27;
            this.lblend.Text = "End Time";
            this.lblend.Visible = false;
            // 
            // FrmRateCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 619);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRateCard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RateCard Module";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRateCard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddratecard)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvratecard.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvratecard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox txtboxratecardname;
        private System.Windows.Forms.ComboBox comboBoxMaker;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.TextBox txtboxbaserate;
        private System.Windows.Forms.TextBox txtBoxDailyRate;
        private System.Windows.Forms.TextBox txtBoxWeeklyRate;
        private System.Windows.Forms.TextBox txtBoxMonthlyRate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiobtninactive;
        private System.Windows.Forms.RadioButton radiobtnactive;
        private System.Windows.Forms.DateTimePicker dtenddate;
        private System.Windows.Forms.DateTimePicker dtstrtdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Telerik.WinControls.UI.RadButton btnaddratecard;
        private Telerik.WinControls.UI.RadGridView dgvratecard;
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Label lblstrt;
        private System.Windows.Forms.DateTimePicker dtendtime;
    }
}