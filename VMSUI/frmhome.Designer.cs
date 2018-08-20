namespace VMSUI
{
    partial class frmhome
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
            this.btncustumer = new System.Windows.Forms.Button();
            this.btnvehicle = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnRatecard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btncustumer
            // 
            this.btncustumer.Location = new System.Drawing.Point(242, 138);
            this.btncustumer.Name = "btncustumer";
            this.btncustumer.Size = new System.Drawing.Size(173, 127);
            this.btncustumer.TabIndex = 0;
            this.btncustumer.Text = "Customer";
            this.btncustumer.UseVisualStyleBackColor = true;
            this.btncustumer.Click += new System.EventHandler(this.btncustumer_Click);
            // 
            // btnvehicle
            // 
            this.btnvehicle.Location = new System.Drawing.Point(446, 138);
            this.btnvehicle.Name = "btnvehicle";
            this.btnvehicle.Size = new System.Drawing.Size(190, 127);
            this.btnvehicle.TabIndex = 1;
            this.btnvehicle.Text = "vehicle";
            this.btnvehicle.UseVisualStyleBackColor = true;
            this.btnvehicle.Click += new System.EventHandler(this.btnvehicle_Click);
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(242, 298);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(190, 127);
            this.btnreports.TabIndex = 2;
            this.btnreports.Text = "Reports";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnRatecard
            // 
            this.btnRatecard.Location = new System.Drawing.Point(446, 298);
            this.btnRatecard.Name = "btnRatecard";
            this.btnRatecard.Size = new System.Drawing.Size(190, 127);
            this.btnRatecard.TabIndex = 3;
            this.btnRatecard.Text = "Rate Card";
            this.btnRatecard.UseVisualStyleBackColor = true;
            this.btnRatecard.Click += new System.EventHandler(this.btnRatecard_Click);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.btnRatecard);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btnvehicle);
            this.Controls.Add(this.btncustumer);
            this.Name = "frmhome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncustumer;
        private System.Windows.Forms.Button btnvehicle;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnRatecard;
    }
}