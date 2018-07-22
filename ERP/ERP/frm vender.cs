using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{
    public partial class frmVendor : Form
    {
        OleDbCommand cmd;
        OleDbDataReader dr;
        string connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = ERPDB.mdb";
        OleDbConnection conn;
        public frmVendor()
        {
            InitializeComponent();
           conn = new OleDbConnection(connetionString);
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.label1.Text = "vender ID";
            this.label2.Text = "vender NAME";
            this.label3.Text = "vender CODE";
            this.label4.Text = "vender CITY";
            this.label5.Text = "vender PH1";
            this.label6.Text = "vender PH2";
            this.label7.Text = "vender ADDRESS";
            this.label8.Text = "vender CPNAME";
            this.label9.Text = "vender CPPH";
            this.label10.Text = "vender EMAIL";
            this.label11.Text = "vender FAX";
            this.label12.Text = "vender GROUP";
            this.label13.Text = "vender STATUS";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //cmd = new OleDbCommand("select * from Customer", conn);
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    //comboBox1.Items.Add(dr["sid"].ToString());
            //}
            //conn.Close();
            //OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID,VName,VCode,VCity,PH1,PH2,VAddress,CPName,CPPH,VEmail,VFax,VGroup,VStatus)values(@VID,@VName,@VCode,@VCity,@PH1,@PH2,@VAddress,@CPName,@CPPH,@VEmail,@VFax,@VGroup,@VStaus);", conn.oleDbConnection1);

            //cmd.Parameters.AddWithValue("@VName", textBox1.Text);
            //cmd.Parameters.AddWithValue("@VCode", textBox2.Text);
            //cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            //cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            //cmd.Parameters.AddWithValue("@PH2", textBox5.Text);
            //cmd.Parameters.AddWithValue("@VAddress", textBox6.Text);
            //cmd.Parameters.AddWithValue("@CPName", textBox7.Text);
            //cmd.Parameters.AddWithValue("@CPPH", textBox8.Text);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Your data has been inserted");
            //F2.oleDbConnection1.Close();
        }
    }
}
