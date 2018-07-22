using System;
using System.Data;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        DataSet xset;
        private void frmProduct_Load(object sender, EventArgs e)
        {
            label1.Text = "Product ID";
            label2.Text = "Name";
            label3.Text = "Base Price";
            label4.Text = "Weight (lb)";
            label5.Text = "Inventory Status";
            label6.Text = "Estimated Delivery";
            label7.Text = "Amount In Hand";
            label8.Text = "Allow Per Order";
            label9.Text = "Warranty Period";
            label10.Text = "Product Type";
            PopulateGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAllowPerOrder.Text = "";
            txtAmountInHand.Text = "";
            txtBasePrice.Text = "";
            txtEstimatedDelivery.Text = "";
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductType.Text = "";
            txtStatus.Text = "";
            txtWarranty.Text = "";
            txtWeight.Text = "";
        }

        private void PopulateSearchGrid(string ID)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Products where Pid like '%" + ID + "%'");
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateGrid()
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Products");
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                try
                {
                    string query = "Select * from Products where Pid like '%" + txtProductID.Text + "%'";
                    xset = clsDB.getddataset(query);
                    DataTable dt = xset.Tables[0];
                    foreach (DataRow item in dt.Rows)
                    {
                        txtProductID.Text = item["Pid"].ToString();
                        txtProductName.Text = item["PName"].ToString();
                        txtBasePrice.Text = item["BasePrice"].ToString();
                        txtWeight.Text = item["WeightInPounds"].ToString();
                        txtStatus.Text = item["InventoryStatus"].ToString();
                        txtEstimatedDelivery.Text = item["EstimatedDelivery"].ToString();
                        txtAmountInHand.Text = item["AmountOnHand"].ToString();
                        txtAllowPerOrder.Text = item["AllowPerOrder"].ToString();
                        txtWarranty.Text = item["WarrentyPeriod"].ToString();
                        txtProductType.Text = item["ProductType"].ToString();
                    }
                    PopulateSearchGrid(txtProductID.Text);
                }
                catch (Exception)
                {

                }

            }
            else
            {
                PopulateGrid();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text != "")
                {
                    xset = clsDB.getddataset("Select * from Products where Pid = '" + txtProductID.Text + "'");
                    if (xset.Tables[0].Rows.Count < 1)
                    {
                        clsDB.executeQuery("insert into Products (Pid, PName, BasePrice, WeightInPounds, InventoryStatus, EstimatedDelivery, AmountOnHand,AllowPerOrder, WarrentyPeriod,ProductType) values ('" + txtProductID.Text + "','" + txtProductName.Text + "','" + txtBasePrice.Text + "','" + txtWeight.Text + "','" + txtStatus.Text + "','" + txtEstimatedDelivery.Text + "','" + txtAmountInHand.Text + "','" + txtAllowPerOrder.Text + "','" + txtWarranty.Text + "','" + txtProductType.Text + "')");
                        MessageBox.Show("Data Saved Successfully");
                    }
                    else
                    {
                        clsDB.executeQuery("update Products set PName = '" + txtProductName.Text + "', BasePrice= '" + txtBasePrice.Text + "',WeightInPounds= '" + txtWeight.Text + "',InventoryStatus= '" + txtStatus.Text + "',EstimatedDelivery= '" + txtEstimatedDelivery.Text + "',AmountOnHand= '" + txtAmountInHand.Text + "',AllowPerOrder= '" + txtAllowPerOrder.Text + "',WarrentyPeriod= '" + txtWarranty.Text + "',ProductType= '" + txtProductType.Text + "'");
                        MessageBox.Show("Data Saved Successfully");
                    }
                }
                PopulateGrid();
            }
            catch (Exception)
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Delete from Products where Pid = '" + txtProductID.Text + "'";
                clsDB.executeQuery(query);
                MessageBox.Show("Data Deleted Successfully");
                PopulateGrid();
            }
            catch (Exception)
            {

            }
        }
    }
}
