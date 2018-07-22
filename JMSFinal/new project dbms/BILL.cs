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
    public partial class BILL : Form
    {
        public BILL()
        {
            InitializeComponent();
            
        }

        private void BILL_Load(object sender, EventArgs e)
        {
            try
            {
                string aID = PAYMENT.ORD.Text;
                // TODO: This line of code loads data into the 'DataSet2.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1, Convert.ToInt32(aID));

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int A = Convert.ToInt32(textBox1.Text);
                this.DataTable1TableAdapter.Fill(this.DataSet2.DataTable1, A);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
