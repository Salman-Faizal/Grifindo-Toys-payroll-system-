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
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Data.Common;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Reports : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R94K3DV\\SQLEXPRESS01;Initial Catalog=\"Grifindo Toys (payroll system)\";Integrated Security=True");


        public Reports()
        {
            InitializeComponent();
        }


        private void fillcombobox()
        {
            string sqlEmployeeId = "select employee_id from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployeeId, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_employeeid1.DataSource = dt;
            cmb_employeeid1.DisplayMember = "employee_id";
            cmb_employeeid1.ValueMember = "employee_id";
        }


        private void Reports_Load(object sender, EventArgs e)
        {
            fillcombobox();

            dtpkr_month1.Format = DateTimePickerFormat.Custom;
            dtpkr_month1.CustomFormat = "MMM/yyyy";
            dtpkr_month1.ShowUpDown = true;

            this.reportViewer1.RefreshReport();
        }


        private void btn_viewreport1_Click(object sender, EventArgs e)
        {
            string selectedMonth = dtpkr_month1.Value.ToString("MMM");
            string selectedYear = dtpkr_month1.Value.ToString("yyyy");
            string salaryMonth = selectedMonth + selectedYear;

            try
            {
                string monthlySalary = "select base_pay, no_pay, gross_pay from Salary where employee_id = '" + cmb_employeeid1.Text + "' and salary_month = '" + salaryMonth + "'";
                SqlCommand cmd = new SqlCommand(monthlySalary, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("Monthly salary for the selected employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSetSalary", dt);
                string rdlcPath = "E:\\viva\\Grifindo Toys (payroll system)\\Grifindo Toys (payroll system)\\Report1.rdlc";
                reportViewer1.LocalReport.ReportPath = rdlcPath;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();

                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Main_form redirectForm = new Main_form();
            this.Hide();
            redirectForm.Show();
        }
    }
}
