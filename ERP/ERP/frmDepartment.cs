using System;
using System.Data;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmDepartment : Form
    {
        DataSet xset;
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frm_departe_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Department ID";
            this.label2.Text = "Department Name";
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Dept");
                dgvDepartment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDepartmentID.Text != "" && txtDepartmentName.Text != string.Empty)
                {
                    xset = clsDB.getddataset("Select * from Dept where Deptid = '" + txtDepartmentID.Text+"'");
                    if (xset.Tables[0].Rows.Count < 1)
                    {
                        clsDB.executeQuery("insert into Dept (Deptid,deptname) values('" + txtDepartmentID.Text + "','" + txtDepartmentName.Text + "')");
                        MessageBox.Show("Data Saved Successfully");
                    }
                    else
                    {
                        clsDB.executeQuery("update Dept set deptname = '" + txtDepartmentName.Text + "' where Deptid = '" + txtDepartmentID.Text + "'");
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
                string query = "Delete from Dept where Deptid = '" + txtDepartmentID.Text + "'";
                clsDB.executeQuery(query);
                MessageBox.Show("Data Deleted Successfully");
                PopulateGrid();
            }
            catch (Exception)
            {

            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtDepartmentName.Text = "";
            if (txtDepartmentID.Text != "")
            {
                try
                {
                    string query = "Select * from Dept where Deptid like '%" + txtDepartmentID.Text + "%'";
                    xset = clsDB.getddataset(query);
                    DataTable dt = xset.Tables[0];
                    foreach (DataRow item in dt.Rows)
                    {
                        txtDepartmentName.Text = item["deptname"].ToString();
                    }
                    PopulateSearchGrid(txtDepartmentID.Text);
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

        private void PopulateSearchGrid(string ID)
        {
            try
            {
                DataTable dt = clsDB.getdata("Select * from Dept where Deptid like '%"+ID+"%'");
                dgvDepartment.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
        }
    }
}
