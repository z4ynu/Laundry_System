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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile();
            this.Hide();
            profile.Show();
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

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            this.Hide();
            customer.Show();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void dungeonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dungeonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void lblCreateService_Click(object sender, EventArgs e)
        {
            FormServiceCreate create = new FormServiceCreate();
            this.Hide();
            create.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            FormTransactions transaction = new FormTransactions();
            this.Hide();
            transaction.Show();
        }
    }
}
