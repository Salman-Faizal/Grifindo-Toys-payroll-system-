using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Login_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R94K3DV\\SQLEXPRESS01;Initial Catalog=\"Grifindo Toys (payroll system)\";Integrated Security=True");


        public Login_Form()
        {
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string userAuthentication = "select count(*) from Login_details where username = '" + txtb_username.Text + "' and password = '" + txtb_password.Text + "'";
            SqlCommand checkCmd = new SqlCommand(userAuthentication, con);
            con.Open();
            int existingCount = (int)checkCmd.ExecuteScalar();
            con.Close();
            if (existingCount > 0)
            {
                MessageBox.Show("Login successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Main_form enterSystem = new Main_form();
                this.Hide();
                enterSystem.Show();
            }
            else
            {
                MessageBox.Show("Username or password entered is invalid", "Login failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtb_username.Clear();
                txtb_password.Clear();
            }
        }
    }
}
