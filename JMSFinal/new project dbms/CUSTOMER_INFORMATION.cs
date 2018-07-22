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
    public partial class CUSTOMER_INFORMATION : Form
    {
        public CUSTOMER_INFORMATION()
        {
            InitializeComponent();
        }

        private void CUSTOMER_INFORMATION_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seven86DataSet21.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter4.Fill(this.seven86DataSet21.CUSTOMER);
            // TODO: This line of code loads data into the 'cUSTDATASET.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter3.Fill(this.cUSTDATASET.CUSTOMER);
            //// TODO: This line of code loads data into the 'seven86settings.CUSTOMER' table. You can move, or remove it, as needed.
            //this.cUSTOMERTableAdapter2.Fill(this.seven86settings.CUSTOMER);
           
            ////// TODO: This line of code loads data into the 'seven86DataSet12.CUSTOMER' table. You can move, or remove it, as needed.
            ////this.cUSTOMERTableAdapter1.Fill(this.seven86DataSet12.CUSTOMER);
            ////    // TODO: This line of code loads data into the 'seven86DataSet11.CUSTOMER' table. You can move, or remove it, as needed.
            ////    this.cUSTOMERTableAdapter.Fill(this.seven86DataSet11.CUSTOMER);
                comboBox1.Text = "";
                button7_Click(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = startdatetimepicker.Value;
                date2 = lastdatetimepicker.Value;
                string addquery = string.Format("insert into CUSTOMER (NAME,CONTACTNUMBER,[ADDRESS],NIC,JOINDATE,[STATUS],LEAVEDATE)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", customernametextbox.Text, maskedTextBox2.Text, textBox2.Text, maskedTextBox1.Text, sdate, STATUS.Text, date2);
                EventMangementSystemClass.Add(addquery);
                var query = string.Format("SELECT * FROM CUSTOMER");
                EventMangementSystemClass.RecordShow(query, dataGridView2);
                CUSTOMER_INFORMATION_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select CUSTOMERID from CUSTOMER where NAME = ('{0}')", customernametextbox.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    customeridtextbox.Clear();
                    customeridtextbox.Text = DR.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    string SHOW = string.Format("SELECT * FROM dbo.CUSTOMER");
            //    EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
            //}
            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = startdatetimepicker.Value;
                date2 = lastdatetimepicker.Value;
                string updatequery = string.Format("delete from CUSTOMER  where CUSTOMERID = ('{0}')", Convert.ToInt32(customeridtextbox.Text));
                EventMangementSystemClass.Update(updatequery);
                customernametextbox.Clear();
                customeridtextbox.Clear();
                maskedTextBox2.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                startdatetimepicker.ResetText();
                STATUS.Clear();
                lastdatetimepicker.ResetText();
                CUSTOMER_INFORMATION_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = startdatetimepicker.Value;
                date2 = lastdatetimepicker.Value;

                string updatequery = string.Format("UPDATE customer SET NAME = ('{0}'), CONTACTNUMBER = ('{1}'), [ADDRESS] = ('{2}'), NIC = ('{3}'), JOINDATE = ('{4}'), [STATUS] = ('{5}'), LEAVEDATE = ('{6}')  WHERE CUSTOMERID =('{7}')", customernametextbox.Text, maskedTextBox2.Text, textBox2.Text, maskedTextBox1.Text,sdate, STATUS.Text, date2, Convert.ToInt32(customeridtextbox.Text));
                EventMangementSystemClass.Update(updatequery);
                customernametextbox.Clear();
                customeridtextbox.Clear();
                maskedTextBox2.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                startdatetimepicker.ResetText();
                STATUS.Clear();
                lastdatetimepicker.ResetText();
                CUSTOMER_INFORMATION_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customeridtextbox.Text=dataGridView2.CurrentRow.Cells[0].Value.ToString();
            customernametextbox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            startdatetimepicker.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            STATUS.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            lastdatetimepicker.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string SHOW = string.Format("SELECT * FROM dbo.CUSTOMER WHERE NAME LIKE ('%{0}')", comboBox1.Text);
            //EventMangementSystemClass.RecordShow(SHOW, dataGridView2);

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customernametextbox.Clear();
            customeridtextbox.Clear();
            maskedTextBox2.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            startdatetimepicker.ResetText();
            STATUS.Clear();
            lastdatetimepicker.ResetText();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string SHOW = string.Format("SELECT * FROM dbo.CUSTOMER WHERE NAME LIKE ('{0}%')", textBox1.Text);
                EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
                textBox1.Clear();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //string SHOW = string.Format("SELECT * FROM dbo.CUSTOMER WHERE NAME LIKE ('%{0}')", comboBox1.Text);
            //EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            string SHOW = string.Format("SELECT * FROM dbo.CUSTOMER WHERE NAME = ('{0}')", comboBox1.Text);
            EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
            comboBox1.ResetText();
            //string SH = string.Format("SELECT * FROM dbo.CUSTOMER");
            //EventMangementSystemClass.RecordShow(SH, dataGridView2);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string SHOW = string.Format("SELECT * FROM dbo.CUSTOMER");
                EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cUSTOMERTableAdapter3.FillBy(this.cUSTDATASET.CUSTOMER);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
