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
    public partial class frmPO : Form
    {
        public frmPO()
        {
            InitializeComponent();
        }
        DataSet xset;
        private void frmPO_Load(object sender, EventArgs e)
        {
            pnlGeneratePO.Visible = false;
            pnlApprovePO.Visible = false;
            pnlAssignVendor.Visible = false;
            pnlPODelivery.Visible = false;
            BindDept();
            BindProducts();
            BindVendor();
        }

        private void BindVendor()
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * FROM Vendor");
                cmbVendorID.DataSource = dt;
                cmbVendorID.DisplayMember = "VName";
                cmbVendorID.ValueMember = "VID";

                ApcmbVendor.DataSource = dt;
                ApcmbVendor.DisplayMember = "VName";
                ApcmbVendor.ValueMember = "VID";

                GRNtxtVendor.DataSource = dt;
                GRNtxtVendor.DisplayMember = "VName";
                GRNtxtVendor.ValueMember = "VID";

                AcmbVendor.DataSource = dt;
                AcmbVendor.DisplayMember = "VName";
                AcmbVendor.ValueMember = "VID";
            }
            catch (Exception)
            { }
        }

        private void BindDept()
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * FROM Dept");
                cmbDeptID.DataSource = dt;
                cmbDeptID.DisplayMember = "Deptname";
                cmbDeptID.ValueMember = "Deptid";

                APcmbApprovedBy.DataSource = dt;
                APcmbApprovedBy.DisplayMember = "Deptname";
                APcmbApprovedBy.ValueMember = "Deptid";

                AcmbApprovedBy.DataSource = dt;
                AcmbApprovedBy.DisplayMember = "Deptname";
                AcmbApprovedBy.ValueMember = "Deptid";

                GRNcmbApprovedBy.DataSource = dt;
                GRNcmbApprovedBy.DisplayMember = "Deptname";
                GRNcmbApprovedBy.ValueMember = "Deptid";
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

        private void generatePOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneratePO.Visible = true;
            pnlApprovePO.Visible = false;
            pnlAssignVendor.Visible = false;
            pnlPODelivery.Visible = false;
            pnlGeneratePO.Location = new Point(0, 28);
        }

        private void approvePOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneratePO.Visible = false;
            pnlApprovePO.Visible = true;
            pnlAssignVendor.Visible = false;
            pnlPODelivery.Visible = false;
            pnlApprovePO.Location = new Point(0, 28);
        }

        private void assignVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneratePO.Visible = false;
            pnlApprovePO.Visible = false;
            pnlAssignVendor.Visible = true;
            pnlPODelivery.Visible = false;
            pnlAssignVendor.Location = new Point(0, 28);
        }

        private void pODeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneratePO.Visible = false;
            pnlApprovePO.Visible = false;
            pnlAssignVendor.Visible = false;
            pnlPODelivery.Visible = true;
            pnlPODelivery.Location = new Point(0, 28);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDeliveredQty.Text = "";
            txtOrderQty.Text = "";
            txtRefNo.Text = "";
            txtPOID.Text = "";
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("insert into PODetails (POID, ProductID, OrderQty, DeliveryQty, Status) values ('" + txtPOID.Text + "','" + cmbProductID.SelectedValue.ToString()+ "','" + txtOrderQty.Text + "','" + "0" + "','" + "Oredered" + "')");
            PopulateGrid(txtPOID.Text);
        }

        private void PopulateGrid(string POID)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from PODetails where POID = '"+txtPOID.Text+"'");
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("insert into PO (POID, PODate, RefNo, Status, ApprovedBy,VID,DeliveryStatus) values ('" + txtPOID.Text + "','" + dtpPODate.ToString() + "','" + txtRefNo.Text + "','" + "Ordered" + "','" + "N/A" + "','" + "N/A" + "','" + "N/A" + "')");
            PopulateGrid(txtPOID.Text);
            MessageBox.Show("Data Saved Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("delete from PO where POID = '" + txtPOID.Text + "')");
            clsDB.executeQuery("delete from PODetails where POID = '" + txtPOID.Text + "')");
            PopulateGrid(txtPOID.Text);
            MessageBox.Show("Data Deleted Successfully");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from PO where POid = '" + txtPOID.Text + "'";
                xset = clsDB.getddataset(query);
                DataTable dt = xset.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    txtPOID.Text = item["POID"].ToString();
                    txtRefNo.Text = item["RefNo"].ToString();
                    cmbVendorID.Text = item["VID"].ToString();
                    dtpPODate.Text = item["PODate"].ToString();
                    cmbDeptID.Text = item["ApprovedBy"].ToString();
                }
                PopulateGrid(txtPOID.Text);
            }
            catch (Exception)
            { }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("update PO set Status ='" + "Approved" + "',ApprovedBy = '"+APcmbApprovedBy.SelectedValue.ToString()+"' where POID = '" + txtPOID.Text + "'");
            //PopulateGrid(txtPOID.Text);
            MessageBox.Show("PO Approved Successfully");
        }

        private void btnDisapprove_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("update PO set Status ='" + "DisApproved,ApprovedBy = '" + APcmbApprovedBy.SelectedValue.ToString() +"' where POID = '" + txtPOID.Text + "'");
            MessageBox.Show("PO DisApproved");
        }

        private void APbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from PO where POid = '" + APtxtPOID.Text + "'";
                xset = clsDB.getddataset(query);
                DataTable dt = xset.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    APtxtPOID.Text = item["POID"].ToString();
                    APtxtRefNo.Text = item["RefNo"].ToString();
                    ApcmbVendor.SelectedValue = item["VID"].ToString();
                    //APdtpPOdate.Value = Convert.ToDateTime(item["PODate"].ToString());
                    APcmbApprovedBy.SelectedValue = item["ApprovedBy"].ToString();
                }
                PopulateAPGrid(APtxtPOID.Text);
            }
            catch (Exception)
            {}
        }

        private void PopulateAPGrid(string text)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from PODetails where POID = '" + text + "'");
                APdgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateAssignGrid(string text)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from PODetails where POID = '" + text + "'");
                AdgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssignbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from PO where POid = '" + AtxtPOID.Text + "'";
                xset = clsDB.getddataset(query);
                DataTable dt = xset.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    AtxtPOID.Text = item["POID"].ToString();
                    AtxtRefNo.Text = item["RefNo"].ToString();
                    AcmbVendor.SelectedValue = item["VID"].ToString();
                    //AdtpPODate.Text = item["PODate"].ToString();
                    AcmbApprovedBy.SelectedValue = item["ApprovedBy"].ToString();
                }
                PopulateAssignGrid(AtxtPOID.Text);
            }
            catch (Exception)
            { }
        }

        private void btnAssignVenor_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("update PO set VID ='" + AcmbVendor.SelectedValue.ToString() + "' where POID = '" + txtPOID.Text + "'");
            MessageBox.Show("Vendor Assigned Successfully");
        }

        private void GRNbtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from PO where POid = '" + AtxtPOID.Text + "'";
                xset = clsDB.getddataset(query);
                DataTable dt = xset.Tables[0];
                foreach (DataRow item in dt.Rows)
                {
                    GRNtxtPOID.Text = item["POID"].ToString();
                    GRNtxtRefNo.Text = item["RefNo"].ToString();
                    GRNtxtVendor.SelectedValue = item["VID"].ToString();
                    //GRNdtpPOID.Text = item["PODate"].ToString();
                    GRNcmbApprovedBy.SelectedValue = item["ApprovedBy"].ToString();
                    
                }
                PopulateGRNGrid(GRNtxtPOID.Text);
            }
            catch (Exception)
            { }
        }

        private void PopulateGRNGrid(string text)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from PODetails where POID = '" + text + "'");
                GRNdgvproducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GRNbtnSave_Click(object sender, EventArgs e)
        {
            clsDB.executeQuery("update PO set DeliveryDate ='" + GRNdtpDeliveryDate.Text + "',DeliveryStatus ='" + "Delivered" + "' where POID = '" + txtPOID.Text + "'");
            clsDB.executeQuery("update PODetails set Status ='" + "Delivered" + "' where POID = '" + txtPOID.Text + "'");
            MessageBox.Show("Saved Successfully");
        }
    }
}
