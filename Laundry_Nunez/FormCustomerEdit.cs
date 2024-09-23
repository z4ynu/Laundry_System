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

        private GlobalProcedures proc;

        public FormCustomerEdit()
        {
            InitializeComponent();
            proc = new GlobalProcedures();
            proc.fncConnectToDatabase();
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
            
        }

        public void procEditCustomer()
        {
            try
            {
                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procUpdateCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                proc.sqlCommand.Parameters.AddWithValue("@p_id", Convert.ToInt32(dtgvCustomer.CurrentRow.Cells[0].Value));
                proc.sqlCommand.Parameters.AddWithValue("@p_fullname", editFullname.Text);
                proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", editBirthdate.Value.ToString("yyyy-MM-dd"));
                proc.sqlCommand.Parameters.AddWithValue("@p_gender", editGender.Text);
                proc.sqlCommand.Parameters.AddWithValue("@p_address", editAddress.Text);
                proc.sqlCommand.Parameters.AddWithValue("@p_contactno", editContactNo.Text);
                proc.sqlCommand.Parameters.AddWithValue("@p_emailadd", editEmailAdd.Text);
                proc.sqlCommand.Parameters.AddWithValue("@p_cust_photo", imgCustomer);
                proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                procGetCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
