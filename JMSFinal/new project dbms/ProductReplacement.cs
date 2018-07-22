using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EventManagementSystem_Concert_;
using buttonchk;

namespace new_project_dbms
{
    public partial class ProductReplacement : Form
    {
        public ProductReplacement()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = string.Format("SELECT ORDERDATE,PRODUCT.PRODUCTID,PRODUCTNAME,PACKINGTYPE,VOLUME,MANUFACTUREDATE,EXPIRYDATE,QUANTITY,TOTALAMOUNT FROM dbo.PRODUCT INNER JOIN dbo.ORDEREDPRODUCTS ON dbo.PRODUCT.PRODUCTID=dbo.ORDEREDPRODUCTS.PRODUCTID INNER JOIN dbo.PACKINGTYPE ON dbo.PACKINGTYPE.PACKINGID= dbo.PRODUCT.PACKINGID INNER JOIN  TAKEORDER ON dbo.TAKEORDER.ORDERID=dbo.ORDEREDPRODUCTS.ORDERID WHERE dbo.ORDEREDPRODUCTS.ORDERID   = ('{0}')", textBox12.Text);
                EventMangementSystemClass.RecordShow(Query, dataGridView1);
                string Query1 = string.Format("SELECT NAME,CUSTOMER.CUSTOMERID FROM dbo.TAKEORDER INNER JOIN dbo.CUSTOMER ON dbo.CUSTOMER.CUSTOMERID=dbo.TAKEORDER.CUSTOMERID WHERE ORDERID = ('{0}')", textBox12.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query1, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                   comboBox2.Text = DR.GetValue(0).ToString();
                   label19.Text = DR.GetValue(1).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox14.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label20.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int A = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PRODUCTID"].Value.ToString());

            string Query2 = string.Format("SELECT QUANTITYINSTOCK FROM dbo.PRODUCT WHERE PRODUCTID = ('{0}')", A);
            SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
            SqlCommand sc = new SqlCommand(Query2, connection);
            connection.Open();
            SqlDataReader DR = sc.ExecuteReader();
            if (DR.Read())
            {
                label1.Text = DR.GetValue(0).ToString();
            }
            connection.Close();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double X, Y, Z, A, B, C, D;
                
            if (textBox4.Text != "")
            {
                D = Convert.ToDouble(textBox2.Text);
                X = Convert.ToDouble(textBox13.Text);
                Y = Convert.ToDouble(textBox14.Text);
                A = Convert.ToDouble(textBox4.Text);
                if (A > Y)
                {
                    MessageBox.Show("RETURN QUANTITY IS GREATER THAN SOLD ONE!!!");
                }
                else
                {
                    Z = X / Y;
                    B = Z * A;
                    C = B - (B * D);
                    textBox5.Text = Convert.ToString(C);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string addquery = string.Format("insert into dbo.RETURNBYCUSTOMER ( ORDERID,PRODUCTID,CUSTOMERID,RETURNQUANTITY,AMOUNT)values ('{0}','{1}','{2}','{3}','{4}')", Convert.ToInt32(textBox12.Text),Convert.ToInt32(label19.Text),Convert.ToInt32(label20.Text),Convert.ToInt32(textBox4.Text),Convert.ToDouble(textBox5.Text));
                EventMangementSystemClass.Add(addquery);
                

                string a = label1.Text;
                int v1 = int.Parse(a);
                int v2 = Convert.ToInt32(textBox4.Text);
                int value = v1 + v2;


                string queryUpdate = "Update dbo.PRODUCT set QUANTITYINSTOCK = " + value + " where PRODUCTID ='" + Convert.ToInt32(label20.Text) +"'";
                EventMangementSystemClass.Update(queryUpdate);


                
                int S1 = Convert.ToInt32(textBox14.Text);
                int S2 = Convert.ToInt32(textBox4.Text);
                int SvalueS = S1 - S2;


                string queryUpdate2 = "Update dbo.ORDEREDPRODUCTS set QUANTITY = "+SvalueS+" where ORDERID ='" + Convert.ToInt32(textBox12.Text) + "'";
                EventMangementSystemClass.Update(queryUpdate2);

                textBox4.Clear(); textBox5.Clear(); textBox13.Clear(); textBox14.Clear();
                MedicineReplacement_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{

            //    string Query = string.Format("select RETURNID  from dbo.RETURNBYCUSTOMER  where ORDERID = ('{0}')", textBox12.Text);
            //    SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
            //    SqlCommand sc = new SqlCommand(Query, connection);
            //    connection.Open();
            //    SqlDataReader DR = sc.ExecuteReader();
            //    if (DR.Read())
            //    {
            //        label7.Text = DR.GetValue(0).ToString();
            //        textBox4.Clear();textBox5.Clear();  textBox13.Clear(); textBox14.Clear();

            //    }
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void MedicineReplacement_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            label19.Visible = false;
            label20.Visible = false;
            //// TODO: This line of code loads data into the 'seven86DataSet28.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.seven86DataSet28.CUSTOMER);
            //// TODO: This line of code loads data into the 'seven86DataSet27.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.seven86DataSet27.PRODUCT);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string values { get; set; }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
