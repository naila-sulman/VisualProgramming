using System;
using System.Windows.Forms;

namespace ERP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCustomerPortal_MouseHover(object sender, EventArgs e)
        {
            btnCustomerPortal.Text = "";
        }

        private void btnCustomerPortal_MouseLeave(object sender, EventArgs e)
        {
            btnCustomerPortal.Text = "CUSTOMER WEB PORTAL";
        }

        private void btnCRMSALES_MouseHover(object sender, EventArgs e)
        {
            btnCRMSALES.Text = "";
        }

        private void btnCRMSALES_MouseLeave(object sender, EventArgs e)
        {
            btnCRMSALES.Text = "CRM & SALES";
        }

        private void btnPURCHASING_MouseHover(object sender, EventArgs e)
        {
            btnPURCHASING.Text = "";
        }

        private void btnPURCHASING_MouseLeave(object sender, EventArgs e)
        {
            btnPURCHASING.Text = "PURCHASING";
        }

        private void btnDistribution_MouseHover(object sender, EventArgs e)
        {
            btnDistribution.Text = "";
        }

        private void btnDistribution_MouseLeave(object sender, EventArgs e)
        {
            btnDistribution.Text = "DISTRIBUTION";
        }

        private void btnManufacturing_MouseHover(object sender, EventArgs e)
        {
            btnManufacturing.Text = "";
        }

        private void btnManufacturing_MouseLeave(object sender, EventArgs e)
        {
            btnManufacturing.Text = "MANUFACTURING";
        }

        private void btnTimeadnProject_MouseHover(object sender, EventArgs e)
        {
            btnTimeadnProject.Text = "";
        }

        private void btnTimeadnProject_MouseLeave(object sender, EventArgs e)
        {
            btnTimeadnProject.Text = "TIME && PROJECT";
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.Text = "";
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.Text = "DASHBOARD";
        }

        private void btnFinance_MouseHover(object sender, EventArgs e)
        {
            btnFinance.Text = "";
        }

        private void btnFinance_MouseLeave(object sender, EventArgs e)
        {
            btnFinance.Text = "FINANCE";
        }

        private void btnCustomerPortal_Click(object sender, EventArgs e)
        {
            frmCustomer frmCust = new frmCustomer();
            frmCust.Show();
        }

        private void btnManufacturing_Click(object sender, EventArgs e)
        {
            frmDepartment frmdep = new frmDepartment();
            frmdep.Show();
        }
    }
}
