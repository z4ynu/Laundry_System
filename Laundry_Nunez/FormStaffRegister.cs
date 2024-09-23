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
    public partial class FormStaffRegister : Form
    {
        public FormStaffRegister()
        {
            InitializeComponent();
        }   

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormStaff signUpStaff = new FormStaff();

            this.Hide();
            signUpStaff.Show();
        }

        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormStaff back = new FormStaff();
            this.Hide();
            back.Show();
        }
    }
}
