namespace Grifindo_Toys__payroll_system_
{
    partial class Main_form
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
            this.btn_salaryform = new System.Windows.Forms.Button();
            this.btn_settingsform = new System.Windows.Forms.Button();
            this.btn_employeeform = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salaryform
            // 
            this.btn_salaryform.BackColor = System.Drawing.Color.White;
            this.btn_salaryform.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salaryform.Location = new System.Drawing.Point(219, 104);
            this.btn_salaryform.Name = "btn_salaryform";
            this.btn_salaryform.Size = new System.Drawing.Size(225, 44);
            this.btn_salaryform.TabIndex = 1;
            this.btn_salaryform.Text = "Calculate salary";
            this.btn_salaryform.UseVisualStyleBackColor = false;
            this.btn_salaryform.Click += new System.EventHandler(this.btn_salaryform_Click);
            // 
            // btn_settingsform
            // 
            this.btn_settingsform.BackColor = System.Drawing.Color.White;
            this.btn_settingsform.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settingsform.Location = new System.Drawing.Point(219, 163);
            this.btn_settingsform.Name = "btn_settingsform";
            this.btn_settingsform.Size = new System.Drawing.Size(225, 44);
            this.btn_settingsform.TabIndex = 2;
            this.btn_settingsform.Text = "Settings";
            this.btn_settingsform.UseVisualStyleBackColor = false;
            this.btn_settingsform.Click += new System.EventHandler(this.btn_settingsform_Click);
            // 
            // btn_employeeform
            // 
            this.btn_employeeform.BackColor = System.Drawing.Color.White;
            this.btn_employeeform.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employeeform.Location = new System.Drawing.Point(219, 223);
            this.btn_employeeform.Name = "btn_employeeform";
            this.btn_employeeform.Size = new System.Drawing.Size(225, 44);
            this.btn_employeeform.TabIndex = 3;
            this.btn_employeeform.Text = "Employee details";
            this.btn_employeeform.UseVisualStyleBackColor = false;
            this.btn_employeeform.Click += new System.EventHandler(this.btn_employeeform_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("HP Simplified Hans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(108, 31);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(469, 32);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Grifindo Toys - salary management";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(266, 355);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(118, 34);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.White;
            this.btn_reports.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.Location = new System.Drawing.Point(219, 284);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(225, 44);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "Salary reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(696, 401);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_employeeform);
            this.Controls.Add(this.btn_settingsform);
            this.Controls.Add(this.btn_salaryform);
            this.Name = "Main_form";
            this.Load += new System.EventHandler(this.Main_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salaryform;
        private System.Windows.Forms.Button btn_settingsform;
        private System.Windows.Forms.Button btn_employeeform;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_reports;
    }
}