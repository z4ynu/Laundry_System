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
    public partial class FormRegisterAdmin : Form
    {
        public FormRegisterAdmin()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormMainDashboard dashboard = new FormMainDashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
