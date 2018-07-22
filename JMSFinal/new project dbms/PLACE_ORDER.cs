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
    public partial class PLACE_ORDER : Form
    {
        public PLACE_ORDER()
        {
            InitializeComponent();
        }

        private void PLACE_ORDER_Load(object sender, EventArgs e)
        {

            comboBox1.Text = "";
            // TODO: This line of code loads data into the 'seven86DataSet26.DISTRIBUTOR' table. You can move, or remove it, as needed.
            this.dISTRIBUTORTableAdapter.Fill(this.seven86DataSet26.DISTRIBUTOR);
            try
            {
                string SHOW = string.Format("Select PRODUCTID, PRODUCTNAME, INSTRUCTION, FORMULA as SPECIALITY, QUANTITYINSTOCK, PACKINGID, BATCHID, TRADEMARKID, RETAILPRICE, TRADEPRICE, MARKUP, EXPIRYDATE, MANUFACTUREDATE FROM PRODUCT ");
                EventMangementSystemClass.RecordShow(SHOW, dataGridView1);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Query = string.Format("select * from DISTRIBUTOR where NAME = ('{0}')", comboBox1.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    VID.Text = DR.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Add(textBox18.Text, textBox6.Text, textBox13.Text, textBox16.Text, textBox15.Text, textBox11.Text, textBox1.Text, textBox14.Text, textBox19.Text);

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox19.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox15.Text != "")
                {
                    double A, B;
                    A = Convert.ToDouble(textBox16.Text);
                    B = Convert.ToDouble(textBox15.Text);
                    textBox11.Text = Convert.ToString(A * B);
                    textBox14.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) - Convert.ToInt32(textBox1.Text));

                }

            }
            catch (Exception)
            {
                MessageBox.Show("please enter quantity!!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                System.DateTime A = default(System.DateTime);
                A = dateTimePicker3.Value;
                string addquery = string.Format("insert into PLACEORDER (DISTRIBUTORID,ORDERDATE)values ('{0}','{1}')", Convert.ToInt32(VID.Text), A);
                EventMangementSystemClass.Add(addquery);
                string Query = string.Format("select ORDERNUMBER from PLACEORDER order by ORDERNUMBER desc");
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

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string addquery1 = string.Format("insert into DEMANDPRODUCTS (ORDERID,PRODUCTID,QUANTITY,TOTALAMOUNT,DISCOUNT,GROSSAMOUNT)values ('{0}','{1}','{2}','{3}','{4}','{5}')", Convert.ToInt32(textBox3.Text), dataGridView2.Rows[i].Cells[8].Value.ToString(), dataGridView2.Rows[i].Cells[4].Value.ToString(), dataGridView2.Rows[i].Cells[7].Value.ToString(), dataGridView2.Rows[i].Cells[6].Value.ToString(), dataGridView2.Rows[i].Cells[5].Value.ToString());
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand command = new SqlCommand(addquery1, connection);
                connection.Open();
                var RowEffected = command.ExecuteNonQuery();
                if (RowEffected >= dataGridView2.Rows.Count)
                {
                    MessageBox.Show("Record Save SuccesFully!!!");

                }
                else if (RowEffected < 1)
                {
                    MessageBox.Show("No Such record Saved Successfully!!!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                sdate = dateTimePicker1.Value;
                System.DateTime rdate = default(System.DateTime);
                rdate = dateTimePicker2.Value;
                var AllRecordQuery = string.Format("Select * from dbo.TAKEORDER inner join dbo.ORDEREDPRODUCTS on dbo.ORDEREDPRODUCTS.ORDERID= dbo.TAKEORDER.ORDERID where ORDERDATE >= ('{0}') and ORDERDATE <=('{1}')", sdate, rdate);
                dataGridView2.DataSource = EventMangementSystemClass.ReturnTable(AllRecordQuery);
                dataGridView2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}