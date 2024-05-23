namespace Grifindo_Toys__payroll_system_
{
    partial class Reports
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grpb_monthlysalary = new System.Windows.Forms.GroupBox();
            this.btn_viewreport1 = new System.Windows.Forms.Button();
            this.lbl_employeeid1 = new System.Windows.Forms.Label();
            this.lbl_month1 = new System.Windows.Forms.Label();
            this.cmb_employeeid1 = new System.Windows.Forms.ComboBox();
            this.dtpkr_month1 = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grpb_monthlysalary.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(49, 206);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(624, 339);
            this.reportViewer1.TabIndex = 0;
            // 
            // grpb_monthlysalary
            // 
            this.grpb_monthlysalary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpb_monthlysalary.Controls.Add(this.dtpkr_month1);
            this.grpb_monthlysalary.Controls.Add(this.cmb_employeeid1);
            this.grpb_monthlysalary.Controls.Add(this.btn_viewreport1);
            this.grpb_monthlysalary.Controls.Add(this.lbl_employeeid1);
            this.grpb_monthlysalary.Controls.Add(this.lbl_month1);
            this.grpb_monthlysalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_monthlysalary.Location = new System.Drawing.Point(210, 31);
            this.grpb_monthlysalary.Name = "grpb_monthlysalary";
            this.grpb_monthlysalary.Size = new System.Drawing.Size(307, 155);
            this.grpb_monthlysalary.TabIndex = 1;
            this.grpb_monthlysalary.TabStop = false;
            this.grpb_monthlysalary.Text = "Monthly salary report";
            // 
            // btn_viewreport1
            // 
            this.btn_viewreport1.BackColor = System.Drawing.Color.White;
            this.btn_viewreport1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewreport1.Location = new System.Drawing.Point(36, 106);
            this.btn_viewreport1.Name = "btn_viewreport1";
            this.btn_viewreport1.Size = new System.Drawing.Size(152, 34);
            this.btn_viewreport1.TabIndex = 2;
            this.btn_viewreport1.Text = "View report";
            this.btn_viewreport1.UseVisualStyleBackColor = false;
            this.btn_viewreport1.Click += new System.EventHandler(this.btn_viewreport1_Click);
            // 
            // lbl_employeeid1
            // 
            this.lbl_employeeid1.AutoSize = true;
            this.lbl_employeeid1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeid1.Location = new System.Drawing.Point(6, 30);
            this.lbl_employeeid1.Name = "lbl_employeeid1";
            this.lbl_employeeid1.Size = new System.Drawing.Size(112, 23);
            this.lbl_employeeid1.TabIndex = 5;
            this.lbl_employeeid1.Text = "Employee Id";
            // 
            // lbl_month1
            // 
            this.lbl_month1.AutoSize = true;
            this.lbl_month1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month1.Location = new System.Drawing.Point(6, 65);
            this.lbl_month1.Name = "lbl_month1";
            this.lbl_month1.Size = new System.Drawing.Size(64, 23);
            this.lbl_month1.TabIndex = 6;
            this.lbl_month1.Text = "Month";
            // 
            // cmb_employeeid1
            // 
            this.cmb_employeeid1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_employeeid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_employeeid1.FormattingEnabled = true;
            this.cmb_employeeid1.Location = new System.Drawing.Point(154, 30);
            this.cmb_employeeid1.Name = "cmb_employeeid1";
            this.cmb_employeeid1.Size = new System.Drawing.Size(132, 28);
            this.cmb_employeeid1.TabIndex = 2;
            this.cmb_employeeid1.UseWaitCursor = true;
            // 
            // dtpkr_month1
            // 
            this.dtpkr_month1.Location = new System.Drawing.Point(154, 65);
            this.dtpkr_month1.Name = "dtpkr_month1";
            this.dtpkr_month1.Size = new System.Drawing.Size(132, 24);
            this.dtpkr_month1.TabIndex = 7;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(606, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 29);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "<---  Back  ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(731, 580);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.grpb_monthlysalary);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.grpb_monthlysalary.ResumeLayout(false);
            this.grpb_monthlysalary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox grpb_monthlysalary;
        private System.Windows.Forms.Button btn_viewreport1;
        private System.Windows.Forms.Label lbl_employeeid1;
        private System.Windows.Forms.Label lbl_month1;
        private System.Windows.Forms.DateTimePicker dtpkr_month1;
        private System.Windows.Forms.ComboBox cmb_employeeid1;
        private System.Windows.Forms.Button btn_cancel;
    }
}