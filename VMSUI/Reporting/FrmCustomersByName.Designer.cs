namespace VMSUI.Reporting
{
    partial class FrmCustomersByName
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vehilceSystem = new VMSUI.VehilceSystem();
            this.gettheCostumersbynameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gettheCostumersbynameTableAdapter = new VMSUI.VehilceSystemTableAdapters.GettheCostumersbynameTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vehilceSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettheCostumersbynameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gettheCostumersbynameBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VMSUI.ReportCostumersName.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // vehilceSystem
            // 
            this.vehilceSystem.DataSetName = "VehilceSystem";
            this.vehilceSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gettheCostumersbynameBindingSource
            // 
            this.gettheCostumersbynameBindingSource.DataMember = "GettheCostumersbyname";
            this.gettheCostumersbynameBindingSource.DataSource = this.vehilceSystem;
            // 
            // gettheCostumersbynameTableAdapter
            // 
            this.gettheCostumersbynameTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCustomersByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmCustomersByName";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Costumers Report By Name";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCustomersByName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehilceSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettheCostumersbynameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gettheCostumersbynameBindingSource;
        private VehilceSystem vehilceSystem;
        private VehilceSystemTableAdapters.GettheCostumersbynameTableAdapter gettheCostumersbynameTableAdapter;
    }
}