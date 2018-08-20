namespace VMSUI
{
    partial class _FrmCostumersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FrmCostumersReport));
            this.panelcostumersreport = new Telerik.WinControls.UI.RadPanel();
            this.dgvcustomersearch = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtboxsearch = new Telerik.WinControls.UI.RadTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btngetdatedreport = new System.Windows.Forms.Button();
            this.VehilceSystem = new VMSUI.VehilceSystem();
            this.spSearchCostumersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spSearchCostumersTableAdapter = new VMSUI.VehilceSystemTableAdapters.spSearchCostumersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelcostumersreport)).BeginInit();
            this.panelcostumersreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomersearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomersearch.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehilceSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSearchCostumersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcostumersreport
            // 
            this.panelcostumersreport.Controls.Add(this.dgvcustomersearch);
            this.panelcostumersreport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelcostumersreport.Location = new System.Drawing.Point(0, 146);
            this.panelcostumersreport.Name = "panelcostumersreport";
            this.panelcostumersreport.Size = new System.Drawing.Size(1114, 539);
            this.panelcostumersreport.TabIndex = 0;
            this.panelcostumersreport.Text = "radPanel1";
            // 
            // dgvcustomersearch
            // 
            this.dgvcustomersearch.AutoSizeRows = true;
            this.dgvcustomersearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcustomersearch.EnableFastScrolling = true;
            this.dgvcustomersearch.Location = new System.Drawing.Point(0, 0);
            // 
            // dgvcustomersearch
            // 
            this.dgvcustomersearch.MasterTemplate.AllowAddNewRow = false;
            this.dgvcustomersearch.MasterTemplate.AllowColumnReorder = false;
            this.dgvcustomersearch.MasterTemplate.AllowDeleteRow = false;
            this.dgvcustomersearch.MasterTemplate.AllowEditRow = false;
            this.dgvcustomersearch.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgvcustomersearch.MasterTemplate.EnableFiltering = true;
            this.dgvcustomersearch.Name = "dgvcustomersearch";
            this.dgvcustomersearch.ReadOnly = true;
            this.dgvcustomersearch.Size = new System.Drawing.Size(1114, 539);
            this.dgvcustomersearch.TabIndex = 19;
            this.dgvcustomersearch.Text = "radGridView1";
            this.dgvcustomersearch.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgvcustomersearch_CellDoubleClick);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(35, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(175, 22);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "search costumers By Name";
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.Location = new System.Drawing.Point(233, 31);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(125, 24);
            this.txtboxsearch.TabIndex = 2;
            this.txtboxsearch.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(233, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(781, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get all Customers Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngetdatedreport
            // 
            this.btngetdatedreport.Location = new System.Drawing.Point(781, 34);
            this.btngetdatedreport.Name = "btngetdatedreport";
            this.btngetdatedreport.Size = new System.Drawing.Size(192, 39);
            this.btngetdatedreport.TabIndex = 5;
            this.btngetdatedreport.Text = "Get Dated Costumers";
            this.btngetdatedreport.UseVisualStyleBackColor = true;
            this.btngetdatedreport.Click += new System.EventHandler(this.btngetdatedreport_Click);
            // 
            // VehilceSystem
            // 
            this.VehilceSystem.DataSetName = "VehilceSystem";
            this.VehilceSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSearchCostumersBindingSource
            // 
            this.spSearchCostumersBindingSource.DataMember = "spSearchCostumers";
            this.spSearchCostumersBindingSource.DataSource = this.VehilceSystem;
            // 
            // spSearchCostumersTableAdapter
            // 
            this.spSearchCostumersTableAdapter.ClearBeforeFill = true;
            // 
            // _FrmCostumersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 685);
            this.Controls.Add(this.btngetdatedreport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.panelcostumersreport);
            this.Name = "_FrmCostumersReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Costumers Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this._FrmCostumersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelcostumersreport)).EndInit();
            this.panelcostumersreport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomersearch.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomersearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehilceSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSearchCostumersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel panelcostumersreport;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtboxsearch;
        private System.Windows.Forms.Button btnSearch;
        private Telerik.WinControls.UI.RadGridView dgvcustomersearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btngetdatedreport;
        private System.Windows.Forms.BindingSource spSearchCostumersBindingSource;
        private VehilceSystem VehilceSystem;
        private VehilceSystemTableAdapters.spSearchCostumersTableAdapter spSearchCostumersTableAdapter;
    }
}