using PrjLaundry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Nunez
{
    public partial class FormCustomerEdit : Form
    {
        // Properties to get/set the values
        private int CustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }

        private GlobalProcedures proc;

        public FormCustomerEdit(int customer_id, string fullName, DateTime birthdate, string gender, string address, string contactNo,
            string emailAddress)
        {
            InitializeComponent();
            proc = new GlobalProcedures();
            proc.fncConnectToDatabase();

            CustomerId = customer_id;
            txtFullName.Text = fullName;
            dtmBirthdate.Value = birthdate;
            // Set the ComboBox's value based on gender
            if (gender == "Male")
                cmbGender.SelectedItem = "Male";
            else if (gender == "Female")
                cmbGender.SelectedItem = "Female";
            txtAddress.Text = address;
            txtContactNo.Text = contactNo;
            txtEmailAddress.Text = emailAddress;
        }

        private void Init()
        {
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCustomer back = new FormCustomer();
            this.Hide();
            back.Show();
        }

        public void procUpdateCustomer(int id)
        {
            try
            {
                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procUpdateCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // When edit is clicked, store the shit data
            FullName = txtFullName.Text;
            Birthdate = dtmBirthdate.Value;
            Gender = cmbGender.SelectedItem.ToString();
            Address = txtAddress.Text;
            ContactNo = txtContactNo.Text;
            EmailAddress = txtEmailAddress.Text;
            
            DialogResult = DialogResult.OK;  // Indicate that editing is successful
            procEditCustomer();
            Close();
        }

        public void procEditCustomer()
        {
            try
            {
                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procEditCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                proc.sqlCommand.Parameters.AddWithValue("@p_id", CustomerId);
                proc.sqlCommand.Parameters.AddWithValue("@p_fullname", FullName);
                proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", Birthdate);
                proc.sqlCommand.Parameters.AddWithValue("@p_gender", Gender);
                proc.sqlCommand.Parameters.AddWithValue("@p_address", Address);
                proc.sqlCommand.Parameters.AddWithValue("@p_contactno", ContactNo);
                proc.sqlCommand.Parameters.AddWithValue("@p_emailadd", EmailAddress);
                proc.sqlCommand.Parameters.AddWithValue("@p_cust_photo", "");
                proc.sqlCommand.ExecuteNonQuery();
                
                MessageBox.Show("Record updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
                // procGetCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}