namespace VMSUI
{
    partial class _FrmCustomersDatewiseReport
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
            this.gettheCustomersfromdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehilceSystem = new VMSUI.VehilceSystem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnload = new System.Windows.Forms.Button();
            this.dtto = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gettheCustomersfromdateTableAdapter = new VMSUI.VehilceSystemTableAdapters.GettheCustomersfromdateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gettheCustomersfromdateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehilceSystem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gettheCustomersfromdateBindingSource
            // 
            this.gettheCustomersfromdateBindingSource.DataMember = "GettheCustomersfromdate";
            this.gettheCustomersfromdateBindingSource.DataSource = this.vehilceSystem;
            // 
            // vehilceSystem
            // 
            this.vehilceSystem.DataSetName = "VehilceSystem";
            this.vehilceSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnload);
            this.panel1.Controls.Add(this.dtto);
            this.panel1.Controls.Add(this.dtfrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 139);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(361, 62);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(145, 38);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // dtto
            // 
            this.dtto.Location = new System.Drawing.Point(136, 77);
            this.dtto.Name = "dtto";
            this.dtto.Size = new System.Drawing.Size(200, 22);
            this.dtto.TabIndex = 1;
            // 
            // dtfrom
            // 
            this.dtfrom.Location = new System.Drawing.Point(136, 12);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 22);
            this.dtfrom.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "getcostumersfromdate";
            reportDataSource1.Value = this.gettheCustomersfromdateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMSUI.Reporting.reportCustomersDated.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(574, 236);
            this.reportViewer1.TabIndex = 1;
            // 
            // gettheCustomersfromdateTableAdapter
            // 
            this.gettheCustomersfromdateTableAdapter.ClearBeforeFill = true;
            // 
            // _FrmCustomersDatewiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 375);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "_FrmCustomersDatewiseReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Customers Datewise Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._FrmCustomersDatewiseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gettheCustomersfromdateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehilceSystem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.DateTimePicker dtto;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.BindingSource gettheCustomersfromdateBindingSource;
        private VehilceSystem vehilceSystem;
        private VehilceSystemTableAdapters.GettheCustomersfromdateTableAdapter gettheCustomersfromdateTableAdapter;
        //     private VehilceSystemTableAdapters.CostomerFromDateTableAdapter CostomerFromDateTableAdapter;
    }
}