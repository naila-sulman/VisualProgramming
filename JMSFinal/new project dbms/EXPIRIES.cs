using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace new_project_dbms
{
    public partial class EXPIRIES : Form
    {
        public EXPIRIES()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EXPIRIES_Load(object sender, EventArgs e)
        {
            System.DateTime sdate = default(System.DateTime);
            sdate = dateTimePicker1.Value;
            // TODO: This line of code loads data into the 'DataSet1.PRODUCT' table. You can move, or remove it, as needed.
            this.PRODUCTTableAdapter.Fill(this.DataSet1.PRODUCT,sdate);

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            System.DateTime sdate = default(System.DateTime);
            sdate = dateTimePicker1.Value;
            this.PRODUCTTableAdapter.Fill(this.DataSet1.PRODUCT, sdate);
            this.reportViewer1.RefreshReport();

        }
    }
}
