using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace ERP
{
    public partial class frmVendor : Form
    {
        DataSet xset;
        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.label1.Text = "ID";
            this.label2.Text = "Name";
            this.label3.Text = "Code";
            this.label4.Text = "City";
            this.label5.Text = "Phone 1";
            this.label6.Text = "Phone 2";
            this.label7.Text = "Address";
            this.label8.Text = "Email";
            this.label9.Text = "Fax";
            this.label10.Text = "Group";
            this.label11.Text = "Status";
            PopulateGrid();
        }

        private void PopulateSearchGrid(string ID)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Vendor where VID like '%" + ID + "%'");
                dgvVendor.DataSource = dt;
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
                DataTable dt = clsDB.getdata("Select * from Vendor");
                dgvVendor.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtVendorID.Text != "")
            {
                try
                {
                    string query = "Select * from Vendor where VID like '%" + txtVendorID.Text + "%'";
                    xset = clsDB.getddataset(query);
                    DataTable dt = xset.Tables[0];
                    foreach (DataRow item in dt.Rows)
                    {
                        txtVendorID.Text = item["VID"].ToString();
                        txtVendorName.Text = item["VName"].ToString();
                        txtVendorCode.Text = item["VCode"].ToString();
                        txtCity.Text = item["VCity"].ToString();
                        txtPhone1.Text = item["PH1"].ToString();
                        txtPhone2.Text = item["PH2"].ToString();
                        txtAddress.Text = item["VAddress"].ToString();
                        txtEmail.Text = item["VEmail"].ToString();
                        txtFax.Text = item["VFax"].ToString();
                        cmbStatus.SelectedItem = item["VStatus"].ToString();
                        txtGroup.Text = item["VGroup"].ToString();
                    }
                    PopulateSearchGrid(txtVendorID.Text);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtVendorID.Text = "";
            this.txtVendorName.Text = "";
            txtVendorCode.Text = "";
            this.txtAddress.Text = "";
            this.txtCity.Text = "";
            this.txtEmail.Text = "";
            this.txtGroup.Text = "";
            this.txtPhone1.Text = "";
            this.txtPhone2.Text = "";
            this.cmbStatus.SelectedIndex = 0;
            txtFax.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVendorID.Text != "")
                {
                    xset = clsDB.getddataset("Select * from Vendor where VID = '" + txtVendorID.Text + "'");
                    if (xset.Tables[0].Rows.Count < 1)
                    {
                        clsDB.executeQuery("insert into Vendor (VID,VName,VCode,VCity,PH1,PH2,VAddress,VEmail,VFax,VGroup,VStatus) values ('" + txtVendorID.Text + "','" + txtVendorName.Text + "','" + txtVendorCode.Text + "','" + txtCity.Text + "','" + txtPhone1.Text + "','" + txtPhone2.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtFax.Text + "','" + txtGroup.Text + "','" + cmbStatus.SelectedItem.ToString()+ "')");
                        MessageBox.Show("Data Saved Successfully");
                    }
                    else
                    {
                        clsDB.executeQuery("update Vendor set VName = '" + txtVendorName.Text + "', VCode= '" + txtVendorCode.Text + "',VCity= '" + txtCity.Text + "',PH1= '" + txtPhone1.Text + "',PH2= '" + txtPhone2.Text + "',VAddress= '" + txtAddress.Text + "',VEmail= '" + txtEmail.Text + "',VFax= '" + txtFax.Text + "',VStatus= '" + cmbStatus.SelectedItem.ToString()+ "',VGroup= '" + txtGroup.Text + "' where VID = '" + txtVendorID.Text + "'");
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
                string query = "Delete from Vendor where VID = '" + txtVendorID.Text + "'";
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
