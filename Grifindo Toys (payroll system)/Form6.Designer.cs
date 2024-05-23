namespace Grifindo_Toys__payroll_system_
{
    partial class Login_Form
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
            this.lbl_mainheading = new System.Windows.Forms.Label();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.grpb_login = new System.Windows.Forms.GroupBox();
            this.grpb_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_mainheading
            // 
            this.lbl_mainheading.AutoSize = true;
            this.lbl_mainheading.Font = new System.Drawing.Font("HP Simplified Hans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainheading.Location = new System.Drawing.Point(134, 9);
            this.lbl_mainheading.Name = "lbl_mainheading";
            this.lbl_mainheading.Size = new System.Drawing.Size(186, 32);
            this.lbl_mainheading.TabIndex = 0;
            this.lbl_mainheading.Text = "Grifindo Toys";
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(156, 50);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(149, 23);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "payroll system";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(6, 34);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(96, 24);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(6, 79);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 24);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // txtb_username
            // 
            this.txtb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_username.Location = new System.Drawing.Point(141, 30);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(195, 28);
            this.txtb_username.TabIndex = 4;
            // 
            // txtb_password
            // 
            this.txtb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_password.Location = new System.Drawing.Point(141, 75);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.PasswordChar = '*';
            this.txtb_password.Size = new System.Drawing.Size(195, 28);
            this.txtb_password.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(108, 137);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(137, 35);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // grpb_login
            // 
            this.grpb_login.Controls.Add(this.lbl_password);
            this.grpb_login.Controls.Add(this.btn_login);
            this.grpb_login.Controls.Add(this.lbl_username);
            this.grpb_login.Controls.Add(this.txtb_password);
            this.grpb_login.Controls.Add(this.txtb_username);
            this.grpb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_login.Location = new System.Drawing.Point(61, 99);
            this.grpb_login.Name = "grpb_login";
            this.grpb_login.Size = new System.Drawing.Size(356, 187);
            this.grpb_login.TabIndex = 7;
            this.grpb_login.TabStop = false;
            this.grpb_login.Text = "System login";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(475, 321);
            this.Controls.Add(this.grpb_login);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.lbl_mainheading);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.grpb_login.ResumeLayout(false);
            this.grpb_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainheading;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.TextBox txtb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox grpb_login;
    }
}