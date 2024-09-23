using PrjLaundry;
using System;
using System.CodeDom.Compiler;
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
    public partial class FormLogin : Form
    {
        FormMainDashboard dashboard = new FormMainDashboard();       
        public FormLogin()
        {          
            InitializeComponent();            
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {

            GlobalProcedures proc = new GlobalProcedures();

            proc.fncConnectToDatabase();

            dashboard.Region = this.Region;
            this.Hide();
            dashboard.Show();

        }

        private void lblNoAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormRegisterAdmin signup = new FormRegisterAdmin();

            signup.Region = this.Region;
            this.Hide();
            signup.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
