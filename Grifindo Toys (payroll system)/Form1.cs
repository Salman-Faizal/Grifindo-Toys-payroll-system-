using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grifindo_Toys__payroll_system_
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-R94K3DV\\SQLEXPRESS01;Initial Catalog=\"Grifindo Toys (payroll system)\";Integrated Security=True");


        public Employee()
        {
            InitializeComponent();
        }


        private void Clear()    //used to clear all data from the form and focus curor on employee id combo box
        {
            cmb_employeeid.Text = "";
            txtb_name.Clear();
            txtb_email.Clear();
            txtb_contactnumber.Clear();
            txtb_salary.Clear();
            txtb_allowances.Clear();
            txtb_overtimehourlyrate.Clear();
            rdbtn_male.Checked = false;
            rdbtn_female.Checked = false;
            picb_employeephoto.Image = null;
            cmb_employeeid.Focus();
        }


        private void FillCombobox()     //used to display employee id's in the combo box drop down
        {
            string sqlEmployeeId = "select employee_id from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployeeId, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_employeeid.DataSource = dt;
            cmb_employeeid.DisplayMember = "employee_id";
            cmb_employeeid.ValueMember = "employee_id";
        }



        private string selectedImagePath = null;    //string used to store an image path

        private void btn_selectphoto_Click(object sender, EventArgs e)      //allows user to select images from his/her local device
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                UpdateEmployeePhoto(selectedImagePath);
            }
        }


        private void UpdateEmployeePhoto(string selectedImagePath)      //used to display the selected image on the picture box for employee photo
        {
            picb_employeephoto.Image = Image.FromFile(selectedImagePath);
        }


        private void Employee_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeSearch;
                employeeSearch = "select * from Employee where employee_id='" + cmb_employeeid.Text + "'";
                SqlCommand cmd = new SqlCommand(employeeSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtb_name.Text = dr["employee_name"].ToString();
                    txtb_email.Text = dr["e_mail"].ToString();
                    txtb_contactnumber.Text = dr["contact_number"].ToString();
                    txtb_salary.Text = "£" + dr["salary"].ToString();
                    txtb_allowances.Text = "£" + dr["allowances"].ToString();
                    txtb_overtimehourlyrate.Text = "£" + dr["overtime_hourly_rate"].ToString();
                    if (dr["gender"].Equals("M"))
                        rdbtn_male.Checked = true;
                    else
                        rdbtn_female.Checked = true;
                    if (!dr.IsDBNull(dr.GetOrdinal("employee_photo")))
                    {
                        byte[] photoData = (byte[])dr["employee_photo"];
                        using (MemoryStream ms = new MemoryStream(photoData))
                        {
                            picb_employeephoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picb_employeephoto.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                }
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] photoData = null;    //initializing photodata to be null so that the user has the option to avoid adding an employee photo when registering an employee
                if (!string.IsNullOrEmpty(selectedImagePath))   //checking if an image is selected 
                {
                    photoData = File.ReadAllBytes(selectedImagePath);   // converts image into binary data format so that the image could be stored in the database
                }

                string gender;
                if (rdbtn_male.Checked == true)
                    gender = "M";
                else
                    gender = "F";

                string employeeUpdate;
                employeeUpdate = "update Employee set employee_name = '" + txtb_name.Text + "', e_mail = '" + txtb_email.Text + "', contact_number = '" + txtb_contactnumber.Text + "', gender = '" + gender + "', salary = '" + txtb_salary.Text + "', allowances = '" + txtb_allowances.Text + "', overtime_hourly_rate = '" + txtb_overtimehourlyrate.Text + "', employee_photo = @photoData where employee_id = '" + cmb_employeeid.Text + "'";
                SqlCommand cmd = new SqlCommand(employeeUpdate, con);

                //allows passing a null value to the database if photoData is null
                SqlParameter photoParameter = new SqlParameter("@photoData", SqlDbType.VarBinary);
                if (photoData == null)
                    photoParameter.Value = DBNull.Value;
                else
                    photoParameter.Value = (object)photoData;
                cmd.Parameters.Add(photoParameter);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee record updated", "Employee update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                con.Close();

                selectedImagePath = null;   //making sure that the image path is no longer saved in the global variable 
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                // primary key validation
                string EmployeeIdValidation = "select count(*) from Employee where employee_id = '" + cmb_employeeid.Text + "'";
                SqlCommand checkCmd = new SqlCommand(EmployeeIdValidation, con);

                con.Open();
                int existingCount = (int)checkCmd.ExecuteScalar();  //obtaining the number of matches for the entered employee id with the employee id's already existing in the database
                con.Close();
                if (existingCount > 0)
                {
                    MessageBox.Show("Employee ID already exists! Please choose a different ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                // making sure there are no any null values for (not null) data in the database
                if (string.IsNullOrEmpty(cmb_employeeid.Text) || string.IsNullOrEmpty(txtb_name.Text) || string.IsNullOrEmpty(txtb_email.Text) || string.IsNullOrEmpty(txtb_contactnumber.Text) || string.IsNullOrEmpty(txtb_salary.Text) || string.IsNullOrEmpty(txtb_allowances.Text) || string.IsNullOrEmpty(txtb_overtimehourlyrate.Text) || (!rdbtn_male.Checked && !rdbtn_female.Checked))
                {
                    MessageBox.Show("Please fill in all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                byte[] photoData = null;
                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    photoData = File.ReadAllBytes(selectedImagePath);
                }
                
                string gender;
                if (rdbtn_male.Checked == true)
                    gender = "M";
                else
                    gender = "F";
                
                string employeeInsert;
                employeeInsert = "insert into Employee (employee_id, employee_name, e_mail, contact_number, gender, salary, allowances, overtime_hourly_rate,employee_photo) values ('" + cmb_employeeid.Text + "','" + txtb_name.Text + "','" + txtb_email.Text + "','" + txtb_contactnumber.Text + "','" + gender + "','" + txtb_salary.Text + "','" + txtb_allowances.Text + "','" + txtb_overtimehourlyrate.Text + "', @photodata)";
                SqlCommand cmd = new SqlCommand(employeeInsert, con);

                SqlParameter photoParameter = new SqlParameter("@photoData", SqlDbType.VarBinary);
                if (photoData == null)
                    photoParameter.Value = DBNull.Value;
                else
                    photoParameter.Value = (object)photoData;
                cmd.Parameters.Add(photoParameter);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The new employee record has been registered", "New record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record ''" + cmb_employeeid.Text + "''?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string employeeDelete;
                employeeDelete = "delete from Employee where employee_id = '" + cmb_employeeid.Text + "'";
                SqlCommand cmd = new SqlCommand(employeeDelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee record deleted", "Employee removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                con.Close();
            }
        }


        private void lnklbl_viewallemployees_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gridview_allemployee allEmployeeForm = new Gridview_allemployee();
            allEmployeeForm.Show();
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Main_form redirectForm = new Main_form();
            this.Hide();
            redirectForm.Show();
        }
    }
}
