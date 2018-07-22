using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        DataSet xset;
        private void frmSales_Load(object sender, EventArgs e)
        {
            BindCustomer();
            BindProducts();
        }

        private void BindCustomer()
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * FROM Customer");
                cmbCustomerID.DataSource = dt;
                cmbCustomerID.DisplayMember = "CName";
                cmbCustomerID.ValueMember = "CID";
            }
            catch (Exception)
            { }
        }

        private void BindProducts()
        {
            try
            {
                cmbProductID.DataSource = clsDB.getdata("Select * FROM Products");
                cmbProductID.DisplayMember = "PName";
                cmbProductID.ValueMember = "Pid";
            }
            catch (Exception)
            { }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from Sales where SaleID = '" + txtSaleID.Text + "'";
                xset = clsDB.getddataset(query);
                DataTable dt = xset.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    txtSaleID.Text = item["SaleID"].ToString();
                    dtpSaleDate.Text = item["SaleDate"].ToString();
                    cmbCustomerID.SelectedValue = item["CustomerID"].ToString();
                }
                PopulateGrid(txtSaleID.Text);
            }
            catch (Exception)
            { }
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("insert into SalesDetail (SaleID, ProductID, Qty, Price) values ('" + txtSaleID.Text + "','" + cmbProductID.SelectedValue.ToString() + "','" + txtOrderQty.Text + "','" + txtPrice.Text + "')");
            PopulateGrid(txtSaleID.Text);
        }

        private void PopulateGrid(string SalesID)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from SalesDetail where SaleID = '" + SalesID + "'");
                dgvProduct.DataSource = dt;

                string query = "Select Count(Price) from SalesDetail where SaleID = '" + txtSaleID.Text + "'";
                xset = clsDB.getddataset(query);
                DataTable dt1 = xset.Tables[0];
                foreach (DataRow item in dt1.Rows)
                {
                    lblAmount.Text = item["Price"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSaleID.Text = "";
            txtOrderQty.Text = "";
            txtPrice.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("insert into Sales (SaleID, SaleDate, CustomerID) values ('" + txtSaleID.Text + "','" + dtpSaleDate.ToString() + "','" + cmbCustomerID.SelectedValue.ToString() + "')");
            PopulateGrid(txtSaleID.Text);
            MessageBox.Show("Data Saved Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("delete from Sales where SaleID = '" + txtSaleID.Text + "')");
            clsDB.executeQuery("delete from SalesDetail where POID = '" + txtSaleID.Text + "')");
            PopulateGrid(txtSaleID.Text);
            MessageBox.Show("Data Deleted Successfully");
        }

        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Products where Pid = '" + cmbProductID.SelectedValue.ToString() + "'";
            xset = clsDB.getddataset(query);
            DataTable dt = xset.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                if (Convert.ToDouble(item["BasePrice"]) > 0 || item["BasePrice"].ToString() != "")
                {
                    txtPrice.Text = item["BasePrice"].ToString();
                }
                else
                {
                    MessageBox.Show("Price for this product is not available");
                }
            }
        }
    }
}
