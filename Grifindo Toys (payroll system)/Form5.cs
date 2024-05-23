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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R94K3DV\\SQLEXPRESS01;Initial Catalog=\"Grifindo Toys (payroll system)\";Integrated Security=True");

        public Salary()
        {
            InitializeComponent();
        }


        private bool dateValidationCheck = false;   //boolean used to make sure the user did not forget to validate date, before calculating the salary
        private bool employeeSelectionCheck = false;    //boolean used to make sure the user did not forget to select an employee, before calculating the salary


        private void clearform()
        {
            dtbkr_begindate.Value = DateTime.Now;
            dtpkr_enddate.Value = DateTime.Now;
            txtb_leavesperyear.Clear();
            txtb_daterange.Clear();
            txtb_days.Clear();
            txtb_taxrate.Clear();
            txtb_leavestaken.Clear();
            txtb_absentdays.Clear();
            txtb_overtimehours.Clear();
            txtb_holidays.Clear();
            txtb_basepay.Clear();
            txtb_nopay.Clear();
            txtb_grosspay.Clear();
            txtb_currency4.Clear();
            txtb_currency5.Clear();
            txtb_currency6.Clear();
        }


        private void clearemployee()
        {
            cmb_employeeid.Text = "";
            txtb_employeename.Clear();
            txtb_salary.Clear();
            txtb_allowances.Clear();
            txtb_overtimehourlyrate.Clear();
            txtb_currency1.Clear();
            txtb_currency2.Clear();
            txtb_currency3.Clear();
        }


        private void fillcombobox()
        {
            string sqlEmployeeId = "select employee_id from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployeeId, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_employeeid.DataSource = dt;
            cmb_employeeid.DisplayMember = "employee_id";
            cmb_employeeid.ValueMember = "employee_id";
        }


        private void Salary_Load(object sender, EventArgs e)
        {
            fillcombobox();
            txtb_percentage.Text = "%";
        }


        private void btn_validatedate_Click(object sender, EventArgs e)
        {
            try
            {
                string validatedate;
                validatedate = "select cycle_begin_date, cycle_end_date, leaves_per_year from Settings";
                con.Open();
                SqlCommand cmd = new SqlCommand(validatedate, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                DateTime dbBeginDate = dr.GetDateTime(0);
                DateTime dbEndDate = dr.GetDateTime(1);
                int dbLeavesPerYear = dr.GetInt32(2);

                DateTime enteredBeginDate = dtbkr_begindate.Value.Date;
                DateTime enteredEndDate = dtpkr_enddate.Value.Date;
                string i = txtb_leavesperyear.Text;
                int enteredLeavesPerYear = int.Parse(i);

                if (dbBeginDate == enteredBeginDate && dbEndDate == enteredEndDate && dbLeavesPerYear == enteredLeavesPerYear)
                {
                    TimeSpan t;
                    DateTime beginDate = Convert.ToDateTime(dbBeginDate);
                    DateTime endDate = Convert.ToDateTime(dbEndDate);
                    t = endDate - beginDate;
                    int dateRange;
                    dateRange = t.Days;
                    txtb_daterange.Text = (dateRange + 1).ToString();
                    txtb_days.Text = "days";
                    dateValidationCheck = true;

                    MessageBox.Show("Date validation successful!", "Date validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please check if the information you have entered are correct\nAnd if they are, please update the date settings and then calculate the salary", "Date validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateValidationCheck = false;
                }
                con.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }


        private void btn_selectemployee_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeSearch;
                employeeSearch = "select employee_name, salary, allowances, overtime_hourly_rate from Employee where employee_id='" + cmb_employeeid.Text + "'";
                SqlCommand cmd = new SqlCommand(employeeSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtb_employeename.Text = dr["employee_name"].ToString();
                    txtb_currency1.Text = "£";
                    txtb_currency2.Text = "£";
                    txtb_currency3.Text = "£";
                    txtb_salary.Text = dr["salary"].ToString();
                    txtb_allowances.Text = dr["allowances"].ToString();
                    txtb_overtimehourlyrate.Text = dr["overtime_hourly_rate"].ToString();
                    employeeSelectionCheck = true;
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearemployee();
                    employeeSelectionCheck = false;
                }
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_salary_Click(object sender, EventArgs e)
        {
            if (dateValidationCheck == false)
            {
                MessageBox.Show("Please validate date before calculating the salary", "Date not validated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (employeeSelectionCheck == false)
            {
                MessageBox.Show("Please select an employee before calculating the salary", "Employee not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtb_taxrate.Text) || string.IsNullOrEmpty(txtb_leavestaken.Text) || string.IsNullOrEmpty(txtb_absentdays.Text) || string.IsNullOrEmpty(txtb_overtimehours.Text) || string.IsNullOrEmpty(txtb_holidays.Text))
            {
                MessageBox.Show("Please fill in all required details", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!int.TryParse(txtb_taxrate.Text, out _) && !float.TryParse(txtb_taxrate.Text, out float _))
            {
                MessageBox.Show("The tax rate entered is invalid", "Invalid detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtb_leavestaken.Text, out int _) || !int.TryParse(txtb_absentdays.Text, out int _) || !int.TryParse(txtb_overtimehours.Text, out int _) || !int.TryParse(txtb_holidays.Text, out int _))
            {
                MessageBox.Show("Please check if all the information entered in the 'Salary detalis entry' are valid", "Invalid detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int dateRange = int.Parse(txtb_daterange.Text);
            int leavesPerYear = int.Parse(txtb_leavesperyear.Text);
            float salary = float.Parse(txtb_salary.Text);
            float allowances = float.Parse(txtb_allowances.Text);
            float otHourlyRate = float.Parse(txtb_overtimehourlyrate.Text);
            int leavesTaken = int.Parse(txtb_leavestaken.Text);
            int absentDays = int.Parse(txtb_absentdays.Text);
            int otHours = int.Parse(txtb_overtimehours.Text);
            
            /* Obtaining the remaining leaves for the employee from the database
               It is assumed that a component of the system would be available to add,delete,... remaining leaves for an employee */
            int remainingLeaves;
            string remainingLeavesSearch;
            remainingLeavesSearch = "select remaining_leaves from EmployeeLeavesTrack where employee_id='" + cmb_employeeid.Text + "'";
            SqlCommand cmd = new SqlCommand(remainingLeavesSearch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string rl = dr["remaining_leaves"].ToString();
                remainingLeaves = int.Parse(rl);
            }
            else
            {
                MessageBox.Show("Could not find the quantity 'remaining leaves' for the selected employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();

            // calculating the actual absent days and updating the leaves taken for the employee inorder to calculate the no pay value
            int updatedRemainingLeaves;
            int totalAbsentDays;
            int salaryMonth = dtpkr_enddate.Value.Month;
            if (salaryMonth == 1)
            {
                int x = leavesPerYear - leavesTaken;
                if (x >= 0)
                {
                    updatedRemainingLeaves = x;
                    totalAbsentDays = absentDays;
                }
                else
                {
                    updatedRemainingLeaves = 0;
                    int additionalAbsentDays = Math.Abs(x);
                    totalAbsentDays = absentDays + additionalAbsentDays;
                }
            }
            else
            {
                int y = remainingLeaves - leavesTaken;
                if (y >= 0)
                {
                    updatedRemainingLeaves = y;
                    totalAbsentDays = absentDays;
                }
                else
                {
                    updatedRemainingLeaves = 0;
                    int additionalAbsentDays = Math.Abs(y);
                    totalAbsentDays = absentDays + additionalAbsentDays;
                }
            }

            float noPay;
            noPay = salary * (totalAbsentDays / (float)dateRange);

            float basePay;
            basePay = salary + allowances + (otHourlyRate * otHours);

            float grossPay;
            if (int.TryParse(txtb_taxrate.Text, out int t))
            {
                int taxRate = t;
                grossPay = basePay - (noPay + basePay * (taxRate/100f));
            }
            else
            {
                float taxRate = float.Parse(txtb_taxrate.Text);
                grossPay = basePay - (noPay + basePay * (taxRate/100f));
            }

            txtb_nopay.Text = noPay.ToString("F2");
            txtb_currency5.Text = "£";
            txtb_basepay.Text = basePay.ToString("F2");
            txtb_currency4.Text = "£";
            txtb_grosspay.Text = grossPay.ToString("F2");
            txtb_currency6.Text = "£";

            //updating the remaining leaves for the employee in the database
            try
            {
                string dbUpdateleaves;
                dbUpdateleaves = "update EmployeeLeavesTrack set remaining_leaves = '" + updatedRemainingLeaves + "' where employee_id = '" + cmb_employeeid.Text + "'";
                SqlCommand cmd2 = new SqlCommand(dbUpdateleaves, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        // recording the salary calculated in the database
        private void btn_salaryrecord_Click(object sender, EventArgs e)
        {
            string salaryMonth = dtpkr_enddate.Value.ToString("MMM");
            string salaryYear = dtpkr_enddate.Value.ToString("yyyy");
            string employeeId = cmb_employeeid.Text;

            string salaryCode = employeeId + salaryMonth + salaryYear;
            string salaryMonthAndYear = salaryMonth + salaryYear;

            try
            {   
                string salaryRegister;
                salaryRegister = "insert into Salary (salary_code, employee_id, employee_name, salary_month, no_pay, base_pay, gross_pay) values ('" + salaryCode + "', '" + cmb_employeeid.Text + "', '" + txtb_employeename.Text + "', '" + salaryMonthAndYear + "', '" + txtb_nopay.Text + "', '" + txtb_basepay.Text + "', '" + txtb_grosspay.Text + "')";
                
                SqlCommand cmd = new SqlCommand(salaryRegister, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The calculated salary has been added", "New salary record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearemployee();
                clearform();
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
