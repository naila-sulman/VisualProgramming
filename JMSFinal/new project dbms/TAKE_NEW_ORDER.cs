using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using EventManagementSystem_Concert_;
using buttonchk;

namespace new_project_dbms
{
    public partial class TAKE_NEW_ORDER : Form
    {
        public TAKE_NEW_ORDER()
        {
            InitializeComponent();

            ID = textBox1;
            CUST = comboBox1;
            ordnum = textBox3;

        }
        public static TextBox ID = new TextBox();
        public static ComboBox CUST = new ComboBox();
        public static TextBox ordnum = new TextBox();


        private void TAKE_NEW_ORDER_Load(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            // TODO: This line of code loads data into the 'seven86DataSet30.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter4.Fill(this.seven86DataSet30.PRODUCT);
            // TODO: This line of code loads data into the 'seven86DataSet29.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter3.Fill(this.seven86DataSet29.PRODUCT);
            // TODO: This line of code loads data into the 'seven86settings.TAKEORDER' table. You can move, or remove it, as needed.
            //this.tAKEORDERTableAdapter1.Fill(this.seven86settings.TAKEORDER);
            // TODO: This line of code loads data into the 'seven86settings.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter2.Fill(this.seven86settings.PRODUCT);
            // TODO: This line of code loads data into the 'seven86settings.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter1.Fill(this.seven86settings.CUSTOMER);
            //// TODO: This line of code loads data into the 'seven86DataSet20.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter1.Fill(this.seven86DataSet20.PRODUCT);

            //// TODO: This line of code loads data into the 'seven86DataSet19.TAKEORDER' table. You can move, or remove it, as needed.
            //this.tAKEORDERTableAdapter.Fill(this.seven86DataSet19.TAKEORDER);
            //// TODO: This line of code loads data into the 'seven86DataSet18.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.seven86DataSet18.PRODUCT);
            //// TODO: This line of code loads data into the 'seven86DataSet17.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter.Fill(this.seven86DataSet17.CUSTOMER);
            ////// TODO: This line of code loads data into the 'seven86DataSet16.TAKEORDER' table. You can move, or remove it, as needed.
            ////this.tAKEORDERTableAdapter.Fill(this.seven86DataSet16.TAKEORDER);
            ////// TODO: This line of code loads data into the 'seven86DataSet15.CUSTOMER' table. You can move, or remove it, as needed.
            ////this.cUSTOMERTableAdapter.Fill(this.seven86DataSet15.CUSTOMER);
            ////// TODO: This line of code loads data into the 'seven86DataSet14.PRODUCT' table. You can move, or remove it, as needed.
            ////this.pRODUCTTableAdapter.Fill(this.seven86DataSet14.PRODUCT);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from CUSTOMER where NAME LIKE ('{0}%')", comboBox1.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox1.Text = DR.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string SHOW = string.Format("SELECT * FROM PRODUCT");
                EventMangementSystemClass.RecordShow(SHOW, dataGridView1);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string a, b, c, d, ed;
                a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                c = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                d = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                ed = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (Convert.ToInt32(ed) <= 0)
                {
                    label15.Visible = true;
                    label16.Visible = false;
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();
                    textBox9.Clear();
                    textBox10.Clear();
                    comboBox3.ResetText();
                }
                else if (Convert.ToInt32(ed) <= 30)
                {
                    label16.Visible = true;
                    label15.Visible = false;
                    textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    label7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    label15.Visible = false;
                    label16.Visible = false;

                textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                label7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ORD_PROD.Rows.Add(textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox2.Text, textBox10.Text,textBox4.Text);
                string a = label7.Text;
                int v1 = int.Parse(a);
                int v2 = Convert.ToInt32(textBox8.Text);
                int value = v1 - v2;
                string queryUpdate = "Update dbo.PRODUCT set QUANTITYINSTOCK = " + value + " where PRODUCTNAME ='" + textBox5.Text + "'";
                EventMangementSystemClass.Update(queryUpdate);

                TAKE_NEW_ORDER_Load(sender, e);
                dataGridView1.Refresh();
                ORD_PROD.Visible =true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            //double A, B;
            //A = Convert.ToDouble(textBox8.Text);
            //B = Convert.ToDouble(textBox7.Text);
            //textBox9.Text = Convert.ToString(A * B);
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            //textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) - Convert.ToInt32(textBox2.Text));
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "")
                {
                    double A, B;
                    A = Convert.ToDouble(textBox8.Text);
                    B = Convert.ToDouble(textBox7.Text);
                    textBox9.Text = Convert.ToString(A * B);
                    textBox10.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) - Convert.ToInt32(textBox2.Text));

                }

            }
            catch (Exception)
            {
                MessageBox.Show("please enter quantity!!!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAYMENT p = new PAYMENT();
            p.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {

                System.DateTime A = default(System.DateTime);
                A = dateTimePicker1.Value;
                string addquery = string.Format("insert into TAKEORDER (CUSTOMERID,ORDERDATE)values ('{0}','{1}')", Convert.ToInt32(textBox1.Text), A);
                EventMangementSystemClass.Add(addquery);
                string Query = string.Format("select ORDERID from TAKEORDER order by ORDERID desc" );
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox3.Text = DR.GetValue(0).ToString();
                }
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < ORD_PROD.Rows.Count; i++)
            {
                string addquery1 = string.Format("insert into ORDEREDPRODUCTS (ORDERID,PRODUCTID,QUANTITY,TOTALAMOUNT,DISCOUNT,GROSSAMOUNT)values ('{0}','{1}','{2}','{3}','{4}','{5}')",  Convert.ToInt32(textBox3.Text), ORD_PROD.Rows[i].Cells[7].Value.ToString(), ORD_PROD.Rows[i].Cells[3].Value.ToString(), ORD_PROD.Rows[i].Cells[6].Value.ToString(), ORD_PROD.Rows[i].Cells[5].Value.ToString(), ORD_PROD.Rows[i].Cells[4].Value.ToString());
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand command = new SqlCommand(addquery1, connection);
                connection.Open();
                var RowEffected = command.ExecuteNonQuery();
                if (RowEffected >= ORD_PROD.Rows.Count)
                {
                    MessageBox.Show("Record Save SuccesFully!!!");

                }
                else if(RowEffected < 1)
                {
                    MessageBox.Show("No Such record Saved Successfully!!!");
                }
                connection.Close();


            }
            
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
                return;
            int num = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            if (num <= 10)
            {
                //e.CellStyle.SelectionBackColor = Color.Green;
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (num <= 50)
            {
                //e.CellStyle.SelectionBackColor = Color.Green;
                e.CellStyle.BackColor = Color.LightPink;
                e.CellStyle.ForeColor = Color.White;
            }
            //else
            //{
            //    e.CellStyle.SelectionBackColor = Color.Green;
            //    e.CellStyle.BackColor = Color.White;
            //}
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SHOW = string.Format("SELECT * FROM dbo.PRODUCTS WHERE PRODUCTNAME = ('{0}')", comboBox3.Text);
            EventMangementSystemClass.RecordShow(SHOW, dataGridView1);
            comboBox1.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PLACE_ORDER PO = new PLACE_ORDER();
            PO.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

