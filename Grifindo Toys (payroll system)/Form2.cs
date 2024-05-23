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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Settings : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R94K3DV\\SQLEXPRESS01;Initial Catalog=\"Grifindo Toys (payroll system)\";Integrated Security=True");


        public Settings()
        {
            InitializeComponent();
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlDataDisplay;
                sqlDataDisplay = "select * from Settings";
                SqlCommand cmd = new SqlCommand(sqlDataDisplay, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                txtb_daterange.Text = dr["date_range"].ToString();
                txtb_leavesperyear.Text = dr["leaves_per_year"].ToString();
                dtpkr_cyclebegindate.Value = (DateTime)dr["cycle_begin_date"];
                dtpkr_cycleenddate.Value = (DateTime)dr["cycle_end_date"];

                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        //used to make sure the user only enteres numerical values in the textboxes for salary cycle date range and leaves per year 
        private void txtb_daterange_KeyPress(object sender, KeyPressEventArgs i)
        {
            if (!char.IsControl(i.KeyChar) && !char.IsDigit(i.KeyChar)) //identifies if the user has entered any keyboard characters other than number keys and control keys
                i.Handled = true;
        }

        private void txtb_leavesperyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime beginDate = dtpkr_cyclebegindate.Value;
                DateTime endDate = dtpkr_cycleenddate.Value;
                int dateRange;
                int leavesPerYear;
                if (int.TryParse(txtb_daterange.Text, out dateRange) && int.TryParse(txtb_leavesperyear.Text, out leavesPerYear))
                {
                    string sqlUpdate;
                    sqlUpdate = "update Settings set date_range = '" + dateRange + "', leaves_per_year = '" + leavesPerYear + "', cycle_begin_date = '" + beginDate + "', cycle_end_date = '" + endDate + "'";
                    SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Date settings updated", "Settings Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please make sure the details you have entered are valid and correct", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message); 
            }
        }


        //redirects the user to the main dashboard form and closes the current settings form
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Main_form redirectForm = new Main_form();
            this.Hide();
            redirectForm.Show();
        }
    }
}
