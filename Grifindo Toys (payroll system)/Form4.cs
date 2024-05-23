using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Gridview_allemployee : Form
    {
        public Gridview_allemployee()
        {
            InitializeComponent();
        }


        private void Gridview_allemployee_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-R94K3DV\\SQLEXPRESS01;Initial Catalog=\"Grifindo Toys (payroll system)\";Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select employee_id, employee_name, e_mail, contact_number, gender, salary, allowances, overtime_hourly_rate  from  Employee", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gridview_allemp.DataSource = dataTable;
                    }
                }
            }
            gridview_allemp.ReadOnly = true;    //prevents the user from altering or deleting data in the gridview

            //proper headings for columns are assigned 
            gridview_allemp.Columns["employee_id"].HeaderText = "Employee ID";
            gridview_allemp.Columns["employee_name"].HeaderText = "Employee Name";
            gridview_allemp.Columns["e_mail"].HeaderText = "Email";
            gridview_allemp.Columns["contact_number"].HeaderText = "Contact Number";
            gridview_allemp.Columns["gender"].HeaderText = "Gender";
            gridview_allemp.Columns["salary"].HeaderText = "Salary (£)";
            gridview_allemp.Columns["allowances"].HeaderText = "Allowances (£)";
            gridview_allemp.Columns["overtime_hourly_rate"].HeaderText = "Overtime Hourly Rate (£)";
        }


        //closes the current form
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
