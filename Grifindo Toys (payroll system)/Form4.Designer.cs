namespace Grifindo_Toys__payroll_system_
{
    partial class Gridview_allemployee
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
            this.gridview_allemp = new System.Windows.Forms.DataGridView();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_allemp)).BeginInit();
            this.SuspendLayout();
            // 
            // gridview_allemp
            // 
            this.gridview_allemp.AllowUserToDeleteRows = false;
            this.gridview_allemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_allemp.Location = new System.Drawing.Point(35, 110);
            this.gridview_allemp.Name = "gridview_allemp";
            this.gridview_allemp.RowHeadersWidth = 51;
            this.gridview_allemp.RowTemplate.Height = 24;
            this.gridview_allemp.Size = new System.Drawing.Size(714, 187);
            this.gridview_allemp.TabIndex = 0;
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("HP Simplified Hans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(232, 28);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(284, 32);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "All employee records";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(302, 339);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(170, 35);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Gridview_allemployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(794, 386);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.gridview_allemp);
            this.Name = "Gridview_allemployee";
            this.Text = "Employee records";
            this.Load += new System.EventHandler(this.Gridview_allemployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridview_allemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridview_allemp;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Button btn_cancel;
    }
}