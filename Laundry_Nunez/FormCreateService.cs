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
    public partial class FormCreateService : Form
    {
        public FormCreateService()
        {
            InitializeComponent();
        }

        private void lblServiceBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormServices goBack = new FormServices();
            this.Hide();
            goBack.Show();
        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {
            FormServices createService = new FormServices();
            this.Hide();
            createService.Show();
        }
    }
}
