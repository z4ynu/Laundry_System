using MySql.Data.MySqlClient;
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
    public partial class FormCustomerAdd : Form
    {
        private GlobalProcedures proc;
        string selectedPath;
       
        public FormCustomerAdd()
        {
            InitializeComponent();

            // connect to the database and global procedures

            proc = new GlobalProcedures();
            proc.fncConnectToDatabase();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            this.Hide();
            customer.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = proc.sqlCommand;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddCustomer";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_fullname", txtFullName.Text);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", dtmBirthdate.Value.ToString("yyyy-MM-dd"));
                sqlCmd.Parameters.AddWithValue("@p_gender", cmbGender.Text);
                sqlCmd.Parameters.AddWithValue("@p_address", txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_contactno", txtContactNo.Text);
                sqlCmd.Parameters.AddWithValue("@p_emailadd", txtEmailAddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_cust_photo", btnInsert.Text);
                sqlCmd.ExecuteNonQuery();

                // Show success message
                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }

            FormCustomer signUpCustomer = new FormCustomer();
            this.Hide();
            signUpCustomer.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "Image Files(*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";

            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(ofdPic.FileName);
                selectedPath = ofdPic.FileName;
                picBox.Image = Image.FromFile(selectedPath);
            }
        }
    }
}
