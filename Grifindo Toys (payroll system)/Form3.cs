using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }


        private void Main_form_Load(object sender, EventArgs e)
        {

        }


        private void btn_salaryform_Click(object sender, EventArgs e)
        {
            Salary openSalaryForm = new Salary();
            this.Hide();
            openSalaryForm.Show();
        }


        private void btn_settingsform_Click(object sender, EventArgs e)
        {
            Settings openSettingsForm = new Settings();
            this.Hide();
            openSettingsForm.Show();
        }


        private void btn_employeeform_Click(object sender, EventArgs e)
        {
            Employee openEmployeeForm = new Employee();
            this.Hide();
            openEmployeeForm.Show();
        }


        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reports openReportsForm = new Reports();
            this.Hide();
            openReportsForm.Show();
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
