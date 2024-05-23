namespace Grifindo_Toys__payroll_system_
{
    partial class Settings
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
            this.lbl_settings = new System.Windows.Forms.Label();
            this.lbl_daterange = new System.Windows.Forms.Label();
            this.lbl_begindate = new System.Windows.Forms.Label();
            this.lbl_enddate = new System.Windows.Forms.Label();
            this.lbl_leavesperyear = new System.Windows.Forms.Label();
            this.dtpkr_cyclebegindate = new System.Windows.Forms.DateTimePicker();
            this.dtpkr_cycleenddate = new System.Windows.Forms.DateTimePicker();
            this.txtb_daterange = new System.Windows.Forms.TextBox();
            this.txtb_leavesperyear = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_settings
            // 
            this.lbl_settings.AutoSize = true;
            this.lbl_settings.Font = new System.Drawing.Font("HP Simplified Hans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.Location = new System.Drawing.Point(27, 20);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(187, 32);
            this.lbl_settings.TabIndex = 0;
            this.lbl_settings.Text = "Date settings";
            // 
            // lbl_daterange
            // 
            this.lbl_daterange.AutoSize = true;
            this.lbl_daterange.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_daterange.Location = new System.Drawing.Point(29, 86);
            this.lbl_daterange.Name = "lbl_daterange";
            this.lbl_daterange.Size = new System.Drawing.Size(222, 24);
            this.lbl_daterange.TabIndex = 1;
            this.lbl_daterange.Text = "Salary cycle - date range";
            // 
            // lbl_begindate
            // 
            this.lbl_begindate.AutoSize = true;
            this.lbl_begindate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_begindate.Location = new System.Drawing.Point(29, 128);
            this.lbl_begindate.Name = "lbl_begindate";
            this.lbl_begindate.Size = new System.Drawing.Size(209, 24);
            this.lbl_begindate.TabIndex = 2;
            this.lbl_begindate.Text = "Salary cycle begin date";
            // 
            // lbl_enddate
            // 
            this.lbl_enddate.AutoSize = true;
            this.lbl_enddate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enddate.Location = new System.Drawing.Point(29, 172);
            this.lbl_enddate.Name = "lbl_enddate";
            this.lbl_enddate.Size = new System.Drawing.Size(192, 24);
            this.lbl_enddate.TabIndex = 3;
            this.lbl_enddate.Text = "Salary cycle end date";
            // 
            // lbl_leavesperyear
            // 
            this.lbl_leavesperyear.AutoSize = true;
            this.lbl_leavesperyear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leavesperyear.Location = new System.Drawing.Point(29, 218);
            this.lbl_leavesperyear.Name = "lbl_leavesperyear";
            this.lbl_leavesperyear.Size = new System.Drawing.Size(237, 24);
            this.lbl_leavesperyear.TabIndex = 4;
            this.lbl_leavesperyear.Text = "Number of leaves per year";
            // 
            // dtpkr_cyclebegindate
            // 
            this.dtpkr_cyclebegindate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_cyclebegindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_cyclebegindate.Location = new System.Drawing.Point(310, 127);
            this.dtpkr_cyclebegindate.Name = "dtpkr_cyclebegindate";
            this.dtpkr_cyclebegindate.Size = new System.Drawing.Size(281, 24);
            this.dtpkr_cyclebegindate.TabIndex = 5;
            // 
            // dtpkr_cycleenddate
            // 
            this.dtpkr_cycleenddate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_cycleenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkr_cycleenddate.Location = new System.Drawing.Point(310, 171);
            this.dtpkr_cycleenddate.Name = "dtpkr_cycleenddate";
            this.dtpkr_cycleenddate.Size = new System.Drawing.Size(281, 24);
            this.dtpkr_cycleenddate.TabIndex = 6;
            // 
            // txtb_daterange
            // 
            this.txtb_daterange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_daterange.Location = new System.Drawing.Point(310, 82);
            this.txtb_daterange.Name = "txtb_daterange";
            this.txtb_daterange.Size = new System.Drawing.Size(281, 28);
            this.txtb_daterange.TabIndex = 7;
            // 
            // txtb_leavesperyear
            // 
            this.txtb_leavesperyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_leavesperyear.Location = new System.Drawing.Point(310, 214);
            this.txtb_leavesperyear.Name = "txtb_leavesperyear";
            this.txtb_leavesperyear.Size = new System.Drawing.Size(281, 28);
            this.txtb_leavesperyear.TabIndex = 8;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(171, 300);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(128, 36);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(334, 300);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 36);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(663, 359);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txtb_leavesperyear);
            this.Controls.Add(this.txtb_daterange);
            this.Controls.Add(this.dtpkr_cycleenddate);
            this.Controls.Add(this.dtpkr_cyclebegindate);
            this.Controls.Add(this.lbl_leavesperyear);
            this.Controls.Add(this.lbl_enddate);
            this.Controls.Add(this.lbl_begindate);
            this.Controls.Add(this.lbl_daterange);
            this.Controls.Add(this.lbl_settings);
            this.Name = "Settings";
            this.Text = "Date settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_settings;
        private System.Windows.Forms.Label lbl_daterange;
        private System.Windows.Forms.Label lbl_begindate;
        private System.Windows.Forms.Label lbl_enddate;
        private System.Windows.Forms.Label lbl_leavesperyear;
        private System.Windows.Forms.DateTimePicker dtpkr_cyclebegindate;
        private System.Windows.Forms.DateTimePicker dtpkr_cycleenddate;
        private System.Windows.Forms.TextBox txtb_daterange;
        private System.Windows.Forms.TextBox txtb_leavesperyear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
    }
}