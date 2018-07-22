using System;
using System.Data;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        DataSet xset;
        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Customer ID";
            this.label2.Text = "Customer Name";
            this.label3.Text = "Address";
            this.label4.Text = "City";
            this.label5.Text = "Phone 1";
            this.label6.Text = "Phone 2";
            this.label7.Text = "Contact person";
            this.label8.Text = "Email";
            this.label9.Text = "Credit Limit";
            this.label10.Text = "Status";
            this.label11.Text = "Group";
            PopulateGrid();
        }
        private void PopulateGrid()
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Customer");
                dgvCustomer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            this.txtCustomerName.Text = "";
            this.txtAddress.Text = "";
            this.txtCity.Text = "";
            this.txtConactPerson.Text = "";
            this.txtCreditLimit.Text = "";
            this.txtEmail.Text = "";
            this.txtGroup.Text = "";
            this.txtPhone1.Text = "";
            this.txtPhone2.Text = "";
            this.cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text != "")
                {
                    xset = clsDB.getddataset("Select * from Customer where CID = '" + txtCustomerID.Text + "'");
                    if (xset.Tables[0].Rows.Count < 1)
                    {
                        clsDB.executeQuery("insert into Customer (CID,Cname,CAddress,City,PH1,PH2,ContectPerson,CEmail,CreditLimit,CStatus,CGroup) values ('" + txtCustomerID.Text + "','" + txtCustomerName.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtPhone1.Text + "','" + txtPhone2.Text + "','" + txtConactPerson.Text + "','" + txtEmail.Text + "','" + txtCreditLimit.Text + "','" + cmbStatus.SelectedItem.ToString()+ "','" + txtGroup.Text + "')");
                        MessageBox.Show("Data Saved Successfully");
                    }
                    else
                    {
                        clsDB.executeQuery("update Customer set Cname = '" + txtCustomerName.Text + "', CAddress= '" + txtAddress.Text + "',City= '" + txtCity.Text + "',PH1= '" + txtPhone1.Text + "',PH2= '" + txtPhone2.Text + "',ContectPerson= '" + txtConactPerson.Text + "',CEmail= '" + txtEmail.Text + "',CreditLimit= '" + txtCreditLimit.Text + "',CStatus= '" + cmbStatus.SelectedItem.ToString() + "',CGroup= '" + txtGroup.Text + "' where CID = '" + txtCustomerID.Text + "'");
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
                string query = "Delete from Customer where CID = '" + txtCustomerID.Text + "'";
                clsDB.executeQuery(query);
                MessageBox.Show("Data Deleted Successfully");
                PopulateGrid();
            }
            catch (Exception)
            {

            }
        }

        
        private void PopulateSearchGrid(string ID)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Customer where CID like '%" + ID + "%'");
                dgvCustomer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text!= "")
            {
                try
                {
                    string query = "Select * from Customer where CID like '%" + txtCustomerID.Text + "%'";
                    xset = clsDB.getddataset(query);
                    DataTable dt = xset.Tables[0];
                    foreach (DataRow item in dt.Rows)
                    {
                        txtCustomerID.Text = item["CID"].ToString();
                        txtCustomerName.Text = item["Cname"].ToString();
                        txtAddress.Text = item["CAddress"].ToString();
                        txtCity.Text = item["City"].ToString();
                        txtPhone1.Text = item["PH1"].ToString();
                        txtPhone2.Text = item["PH2"].ToString();
                        txtConactPerson.Text = item["ContectPerson"].ToString();
                        txtEmail.Text = item["CEmail"].ToString();
                        txtCreditLimit.Text = item["CreditLimit"].ToString();
                        cmbStatus.SelectedItem = item["CStatus"].ToString();
                        txtGroup.Text = item["CGroup"].ToString();
                    }
                    PopulateSearchGrid(txtCustomerID.Text);
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
    }
}
