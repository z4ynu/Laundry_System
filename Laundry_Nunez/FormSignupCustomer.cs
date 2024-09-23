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
    public partial class FormSignupCustomer : Form
    {
       
        public FormSignupCustomer()
        {
            InitializeComponent();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            this.Hide();
            customer.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormCustomer signUpCustomer = new FormCustomer();
            this.Hide();
            signUpCustomer.Show();
        }
    }
}
