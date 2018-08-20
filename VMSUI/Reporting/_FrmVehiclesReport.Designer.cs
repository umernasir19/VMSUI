namespace VMSUI
{
    partial class _FrmVehiclesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FrmVehiclesReport));
            this.vehclereportpanel = new Telerik.WinControls.UI.RadPanel();
            this.dgvvhclereports = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtboxsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnGeneratereport = new System.Windows.Forms.Button();
            this.btngetallvehiclereport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehclereportpanel)).BeginInit();
            this.vehclereportpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvhclereports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvhclereports.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // vehclereportpanel
            // 
            this.vehclereportpanel.Controls.Add(this.dgvvhclereports);
            this.vehclereportpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehclereportpanel.Location = new System.Drawing.Point(0, 153);
            this.vehclereportpanel.Name = "vehclereportpanel";
            this.vehclereportpanel.Size = new System.Drawing.Size(1173, 798);
            this.vehclereportpanel.TabIndex = 0;
            // 
            // dgvvhclereports
            // 
            this.dgvvhclereports.AutoSizeRows = true;
            this.dgvvhclereports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvvhclereports.Location = new System.Drawing.Point(0, 0);
            // 
            // dgvvhclereports
            // 
            this.dgvvhclereports.MasterTemplate.AllowAddNewRow = false;
            this.dgvvhclereports.MasterTemplate.AllowColumnReorder = false;
            this.dgvvhclereports.MasterTemplate.AllowDeleteRow = false;
            this.dgvvhclereports.MasterTemplate.AllowEditRow = false;
            this.dgvvhclereports.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvvhclereports.MasterTemplate.EnableFiltering = true;
            this.dgvvhclereports.Name = "dgvvhclereports";
            this.dgvvhclereports.Size = new System.Drawing.Size(1173, 798);
            this.dgvvhclereports.TabIndex = 1;
            this.dgvvhclereports.Text = "radGridView1";
            this.dgvvhclereports.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvvhclereports_CellDoubleClick);
            this.dgvvhclereports.Click += new System.EventHandler(this.dgvvhclereports_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(28, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(206, 22);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Search Vehicle By Number Plate";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.Location = new System.Drawing.Point(297, 32);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(172, 22);
            this.txtboxsearch.TabIndex = 2;
            this.txtboxsearch.TextChanged += new System.EventHandler(this.txtboxsearch_TextChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(297, 60);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(172, 41);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnGeneratereport
            // 
            this.btnGeneratereport.Location = new System.Drawing.Point(583, 32);
            this.btnGeneratereport.Name = "btnGeneratereport";
            this.btnGeneratereport.Size = new System.Drawing.Size(172, 41);
            this.btnGeneratereport.TabIndex = 4;
            this.btnGeneratereport.Text = "Get Date Wise Report";
            this.btnGeneratereport.UseVisualStyleBackColor = true;
            this.btnGeneratereport.Click += new System.EventHandler(this.btnGeneratereport_Click);
            // 
            // btngetallvehiclereport
            // 
            this.btngetallvehiclereport.Location = new System.Drawing.Point(761, 32);
            this.btngetallvehiclereport.Name = "btngetallvehiclereport";
            this.btngetallvehiclereport.Size = new System.Drawing.Size(172, 41);
            this.btngetallvehiclereport.TabIndex = 5;
            this.btngetallvehiclereport.Text = "Get All Vehicle Report";
            this.btngetallvehiclereport.UseVisualStyleBackColor = true;
            this.btngetallvehiclereport.Click += new System.EventHandler(this.btngetallvehiclereport_Click);
            // 
            // _FrmVehiclesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 951);
            this.Controls.Add(this.btngetallvehiclereport);
            this.Controls.Add(this.btnGeneratereport);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.vehclereportpanel);
            this.Name = "_FrmVehiclesReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Vehicles Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._FrmVehiclesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehclereportpanel)).EndInit();
            this.vehclereportpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvhclereports.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvhclereports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel vehclereportpanel;
        private Telerik.WinControls.UI.RadGridView dgvvhclereports;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.TextBox txtboxsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnGeneratereport;
        private System.Windows.Forms.Button btngetallvehiclereport;
    }
}