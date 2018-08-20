namespace VMSUI
{
    partial class _FrmReports
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
            this.btncustomersreport = new System.Windows.Forms.Button();
            this.btnVehicleReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btncustomersreport
            // 
            this.btncustomersreport.Location = new System.Drawing.Point(437, 99);
            this.btncustomersreport.Name = "btncustomersreport";
            this.btncustomersreport.Size = new System.Drawing.Size(161, 37);
            this.btncustomersreport.TabIndex = 3;
            this.btncustomersreport.Text = "customers report";
            this.btncustomersreport.UseVisualStyleBackColor = true;
            this.btncustomersreport.Click += new System.EventHandler(this.btncustomersreport_Click);
            // 
            // btnVehicleReports
            // 
            this.btnVehicleReports.Location = new System.Drawing.Point(437, 211);
            this.btnVehicleReports.Name = "btnVehicleReports";
            this.btnVehicleReports.Size = new System.Drawing.Size(161, 37);
            this.btnVehicleReports.TabIndex = 6;
            this.btnVehicleReports.Text = "Vehicle Reports";
            this.btnVehicleReports.UseVisualStyleBackColor = true;
            this.btnVehicleReports.Click += new System.EventHandler(this.btnVehicleReports_Click);
            // 
            // _FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 673);
            this.Controls.Add(this.btnVehicleReports);
            this.Controls.Add(this.btncustomersreport);
            this.Name = "_FrmReports";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncustomersreport;
        private System.Windows.Forms.Button btnVehicleReports;
    }
}