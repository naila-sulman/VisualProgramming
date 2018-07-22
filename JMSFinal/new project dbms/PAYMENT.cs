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
    public partial class PAYMENT : Form
    {
        public PAYMENT()
        {
            InitializeComponent();
            ORD = comboBox2;
            //aID = textBox6;
            //aCUST = textBox7;
            //aordnum = comboBox2;
        }
        public static ComboBox ORD = new ComboBox();
        //public static TextBox aID = new TextBox();
        //public static TextBox aCUST = new TextBox();
        //public static ComboBox aordnum = new ComboBox();
        private void button1_Click(object sender, EventArgs e)
        {
            BILL b = new BILL();
            b.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void PAYMENT_Load(object sender, EventArgs e)
        {
            string aID = TAKE_NEW_ORDER.ID.Text;
            string aCUST = TAKE_NEW_ORDER.CUST.Text;
            string aordnum = TAKE_NEW_ORDER.ordnum.Text;
            textBox6.Text= aID;
              textBox7.Text=aCUST;
             comboBox2.Text=aordnum ;
             //try
             //{
             string Query = string.Format("SELECT  SUM(TOTALAMOUNT)AS TOTALAMOUNTS FROM dbo.ORDEREDPRODUCTS WHERE ORDERID = ('{0}')", comboBox2.Text);
                 SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                 SqlCommand sc1 = new SqlCommand(Query, connection);
                 connection.Open();
                 SqlDataReader DR = sc1.ExecuteReader();
                 if (DR.Read())
                 {
                     textBox1.Text = DR.GetValue(0).ToString();
                 }
                 connection.Close();
             //}
             //catch (Exception ex)
             //{
             //    MessageBox.Show(ex.Message);
             //}

            // TODO: This line of code loads data into the 'seven86DataSet22.TAKEORDER' table. You can move, or remove it, as needed.
            //this.tAKEORDERTableAdapter.Fill(this.seven86DataSet22.TAKEORDER);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from TAKEORDER where ORDERID = ('{0}')", comboBox2.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    //textBox5.Text = DR.GetValue(3).ToString();
                    //textBox9.Text = DR.GetValue(4).ToString();
                    //maskedTextBox1.Text = DR.GetValue(4).ToString();
                    textBox6.Text = DR.GetValue(1).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                double A,B;
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(B - A);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                string addquery = string.Format("insert into dbo.PAYMENTBYCUSTOMER (CUSTOMERID,ORDERPRODUCTID,BILLAMOUNT,PAIDAMOUNT,BALANCE,STATUS) values ('{0}','{1}','{2}','{3}','{4}','{5}')", Convert.ToInt32(textBox6.Text),Convert.ToInt32(comboBox2.Text),Convert.ToDouble(textBox1.Text),Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text),comboBox1.Text);
                EventMangementSystemClass.Add(addquery);
                textBox6.Clear();
                comboBox1.ResetText();
                comboBox2.ResetText();
                textBox7.Clear();
                textBox8.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                string SHOW = string.Format("SELECT * FROM dbo.PAYMENTBYCUSTOMER");
                EventMangementSystemClass.RecordShow(SHOW,dataGridView2);
                PAYMENT_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
