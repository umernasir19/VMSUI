namespace VMSUI.Reporting
{
    partial class _PrintVehicleFromToReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spGetVehiclesFromDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehilceSystem = new VMSUI.VehilceSystem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnloadReport = new Telerik.WinControls.UI.RadButton();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.spGetVehiclesFromDateTableAdapter = new VMSUI.VehilceSystemTableAdapters.spGetVehiclesFromDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spGetVehiclesFromDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehilceSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnloadReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // spGetVehiclesFromDateBindingSource
            // 
            this.spGetVehiclesFromDateBindingSource.DataMember = "spGetVehiclesFromDate";
            this.spGetVehiclesFromDateBindingSource.DataSource = this.vehilceSystem;
            // 
            // vehilceSystem
            // 
            this.vehilceSystem.DataSetName = "VehilceSystem";
            this.vehilceSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spGetVehiclesFromDateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMSUI.Reporting.VehiclefromtoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1066, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.dtto);
            this.radPanel1.Controls.Add(this.label2);
            this.radPanel1.Controls.Add(this.btnloadReport);
            this.radPanel1.Controls.Add(this.dtfrom);
            this.radPanel1.Controls.Add(this.label1);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1066, 105);
            this.radPanel1.TabIndex = 6;
            // 
            // dtto
            // 
            this.dtto.Location = new System.Drawing.Point(528, 34);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(200, 22);
            this.dtto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "To Date";
            // 
            // btnloadReport
            // 
            this.btnloadReport.Location = new System.Drawing.Point(753, 34);
            this.btnloadReport.Name = "btnloadReport";
            this.btnloadReport.Size = new System.Drawing.Size(174, 35);
            this.btnloadReport.TabIndex = 8;
            this.btnloadReport.Text = "Load Report";
            this.btnloadReport.Click += new System.EventHandler(this.btnloadReport_Click_1);
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(198, 38);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 22);
            this.dtfrom.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "From Date";
            // 
            // spGetVehiclesFromDateTableAdapter
            // 
            this.spGetVehiclesFromDateTableAdapter.ClearBeforeFill = true;
            // 
            // _PrintVehicleFromToReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 583);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.radPanel1);
            this.Name = "_PrintVehicleFromToReports";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Vehicle DateWise Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._PrintReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spGetVehiclesFromDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehilceSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnloadReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGetVehiclesFromDateBindingSource;
        private VehilceSystem vehilceSystem;
        private VehilceSystemTableAdapters.spGetVehiclesFromDateTableAdapter spGetVehiclesFromDateTableAdapter;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadButton btnloadReport;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.Label label1;
    }
}