using MySql.Data.MySqlClient;
using PrjLaundry;
using System;
using System.Data;
using System.Windows.Forms;

namespace Laundry_Nunez
{
    public partial class FormCustomer : Form
    {
        private GlobalProcedures proc;
        int row;
        private int selectedRowIndex = -1;

        public FormCustomer()
        {
            InitializeComponent();
            proc = new GlobalProcedures();
            proc.fncConnectToDatabase();
            procGetCustomer();
            dtgvCustomer.CellClick += dtgvCustomer_CellContentClick;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile();
            this.Hide();
            profile.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            this.Hide();
            customer.Show();
        }

        private void btnGarments_Click(object sender, EventArgs e)
        {
            FormGarments garments = new FormGarments();
            this.Hide();
            garments.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormStaff staff = new FormStaff();
            this.Hide();
            staff.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            FormServices services = new FormServices();
            this.Hide();
            services.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            f.Region = this.Region;
            this.Hide();
            f.Show();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // procGetCustomer();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            FormCustomerAdd signupCustomer = new FormCustomerAdd();
            this.Hide();
            signupCustomer.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FormTransactions transaction = new FormTransactions();
            this.Hide();
            transaction.Show();
        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Console.WriteLine(e.RowIndex);
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        public void procGetCustomer()
        {
            try
            {
                proc.sqlLaundryAdapter = new MySqlDataAdapter();
                proc.datLaundry = new DataTable();

                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procGetCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                proc.sqlLaundryAdapter.SelectCommand = proc.sqlCommand;
                proc.datLaundry.Clear();
                proc.sqlLaundryAdapter.Fill(proc.datLaundry);

                if (proc.datLaundry.Rows.Count > 0)
                {
                    row = 0;
                    lblTotal.Text = "Total Customers: " + Convert.ToString(proc.datLaundry.Rows.Count);
                    dtgvCustomer.RowCount = proc.datLaundry.Rows.Count;
                    while (!(proc.datLaundry.Rows.Count - 1 < row))
                    {
                        dtgvCustomer.Rows[row].Cells[0].Value = proc.datLaundry.Rows[row]["id"].ToString();
                        dtgvCustomer.Rows[row].Cells[1].Value = proc.datLaundry.Rows[row]["fullname"].ToString();
                        dtgvCustomer.Rows[row].Cells[2].Value = proc.datLaundry.Rows[row]["birthdate"].ToString();
                        dtgvCustomer.Rows[row].Cells[3].Value = proc.datLaundry.Rows[row]["gender"].ToString();
                        dtgvCustomer.Rows[row].Cells[4].Value = proc.datLaundry.Rows[row]["address"].ToString();
                        dtgvCustomer.Rows[row].Cells[5].Value = proc.datLaundry.Rows[row]["contactno"].ToString();
                        dtgvCustomer.Rows[row].Cells[6].Value = proc.datLaundry.Rows[row]["emailadd"].ToString();
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("Record not found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                proc.sqlLaundryAdapter.Dispose();
                proc.datLaundry.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            procSearchCustomer(txtSearch.Text);
        }

        public void procSearchCustomer(String v_name)
        {
            try
            {
                proc.sqlLaundryAdapter = new MySqlDataAdapter();
                proc.datLaundry = new DataTable();

                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procSearchCustomer";
                proc.sqlCommand.Parameters.AddWithValue("@p_search", v_name);
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                proc.sqlLaundryAdapter.SelectCommand = proc.sqlCommand;
                proc.datLaundry.Clear();
                proc.sqlLaundryAdapter.Fill(proc.datLaundry);

                if (proc.datLaundry.Rows.Count > 0)
                {
                    row = 0;
                    lblTotal.Text = "Total Customers: " + Convert.ToString(proc.datLaundry.Rows.Count);
                    dtgvCustomer.RowCount = proc.datLaundry.Rows.Count;
                    while (!(proc.datLaundry.Rows.Count - 1 < row))
                    {
                        dtgvCustomer.Rows[row].Cells[0].Value = proc.datLaundry.Rows[row]["id"].ToString();
                        dtgvCustomer.Rows[row].Cells[1].Value = proc.datLaundry.Rows[row]["fullname"].ToString();
                        dtgvCustomer.Rows[row].Cells[2].Value = proc.datLaundry.Rows[row]["birthdate"].ToString();
                        dtgvCustomer.Rows[row].Cells[3].Value = proc.datLaundry.Rows[row]["gender"].ToString();
                        dtgvCustomer.Rows[row].Cells[4].Value = proc.datLaundry.Rows[row]["address"].ToString();
                        dtgvCustomer.Rows[row].Cells[5].Value = proc.datLaundry.Rows[row]["contactno"].ToString();
                        dtgvCustomer.Rows[row].Cells[6].Value = proc.datLaundry.Rows[row]["emailadd"].ToString();
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("Record not found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                proc.sqlLaundryAdapter.Dispose();
                proc.datLaundry.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(selectedRowIndex);
            FormCustomerEdit edit;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtgvCustomer.Rows[selectedRowIndex];
                // Retrieve data from the selected row
                int customer_id = Convert.ToInt32(selectedRow.Cells["id"].Value.ToString());
                string fullName = selectedRow.Cells["FullName"].Value.ToString();
                DateTime birthdate = DateTime.Parse(selectedRow.Cells["Birthdate"].Value.ToString());
                string gender = selectedRow.Cells["Gender"].Value.ToString();
                Console.WriteLine(gender);
                string address = selectedRow.Cells["Address"].Value.ToString();
                string contactNo = selectedRow.Cells["ContactNo"].Value.ToString();
                string emailAddress = selectedRow.Cells["EmailAdd"].Value.ToString();
                
                edit = new FormCustomerEdit(customer_id, fullName, birthdate, gender, address, contactNo, emailAddress);
                Hide();
                // edit.ShowDialog();
                
                if (edit.ShowDialog() == DialogResult.OK)  // Check if the user clicked Save
                {
                    // Update the selected row with the new values from Form2
                    // selectedRow.Cells["FullName"].Value = edit.FullName;
                    // selectedRow.Cells["Birthdate"].Value = edit.Birthdate.ToShortDateString();
                    // selectedRow.Cells["Gender"].Value = edit.Gender;
                    // selectedRow.Cells["Address"].Value = edit.Address;
                    // selectedRow.Cells["ContactNo"].Value = edit.ContactNo;
                    // selectedRow.Cells["EmailAdd"].Value = edit.EmailAddress;
                    procGetCustomer();

                    // Refresh the DataGridView if necessary
                    dtgvCustomer.Refresh();
                    Show();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procDeleteCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                proc.sqlCommand.Parameters.AddWithValue("@p_customeriD", Convert.ToInt32(dtgvCustomer.CurrentRow.Cells[0].Value));
                proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Delete Record Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // redisplay datagrid to update list of records
                procGetCustomer();


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void dtgvCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpMain_Click(object sender, EventArgs e)
        {

        }
    }
}