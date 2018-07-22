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
    public partial class ADD_NEW_PRODUCTS : Form
    {
        public ADD_NEW_PRODUCTS()
        {
            InitializeComponent();
        }
        
        private void ADD_NEW_PRODUCTS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seven86settings.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter1.Fill(this.seven86settings.PRODUCT);
            // TODO: This line of code loads data into the 'seven86settings.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.seven86settings.products);
            // TODO: This line of code loads data into the 'seven86settings.PACKINGTYPE' table. You can move, or remove it, as needed.
            this.pACKINGTYPETableAdapter1.Fill(this.seven86settings.PACKINGTYPE);
            // TODO: This line of code loads data into the 'seven86settings.BATCH' table. You can move, or remove it, as needed.
            this.bATCHTableAdapter1.Fill(this.seven86settings.BATCH);
            // TODO: This line of code loads data into the 'seven86settings.TRADEMARK' table. You can move, or remove it, as needed.
            this.tRADEMARKTableAdapter1.Fill(this.seven86settings.TRADEMARK);
            //// TODO: This line of code loads data into the 'seven86DataSet6.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.seven86DataSet6.PRODUCT);
            //// TODO: This line of code loads data into the 'seven86DataSet5.PACKINGTYPE' table. You can move, or remove it, as needed.
            //this.pACKINGTYPETableAdapter.Fill(this.seven86DataSet5.PACKINGTYPE);
            //// TODO: This line of code loads data into the 'seven86DataSet4.BATCH' table. You can move, or remove it, as needed.
            //this.bATCHTableAdapter.Fill(this.seven86DataSet4.BATCH);
            //// TODO: This line of code loads data into the 'seven86DataSet3.TRADEMARK' table. You can move, or remove it, as needed.
            //this.tRADEMARKTableAdapter.Fill(this.seven86DataSet3.TRADEMARK);
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from TRADEMARK where COMPANYNAME = ('{0}')", comboBox4.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox18.Text = DR.GetValue(2).ToString();
                    maskedTextBox1.Text = DR.GetValue(4).ToString();
                    textBox17.Text = DR.GetValue(3).ToString();
                    textBox13.Text = DR.GetValue(0).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from BATCH where BATCHNAME = ('{0}')", comboBox1.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox14.Text = DR.GetValue(0).ToString();
                    dateTimePicker1.Text = DR.GetValue(2).ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from PACKINGTYPE where PACKINGTYPE = ('{0}')", comboBox2.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox15.Text = DR.GetValue(0).ToString();
                    textBox16.Text = DR.GetValue(2).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = dateTimePicker2.Value;
                date2 = dateTimePicker3.Value;
                string addquery = string.Format("insert into PRODUCT (PRODUCTNAME,INSTRUCTION,FORMULA,QUANTITYINSTOCK,PACKINGID,BATCHID,TRADEMARKID,RETAILPRICE,TRADEPRICE,MARKUP,MANUFACTUREDATE,EXPIRYDATE)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", textBox2.Text, textBox3.Text, textBox9.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox13.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox19.Text), sdate, date2);
                EventMangementSystemClass.Add(addquery);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox9.Clear();
                textBox19.Clear();
                textBox13.Clear();
                comboBox4.Text = "";
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                textBox5.Clear();
                textBox6.Clear();
                comboBox4.Text = "";
                textBox18.Clear();
                maskedTextBox1.ResetText();
                textBox17.Clear();
                comboBox1.Text = "";
                textBox14.Clear();
                dateTimePicker1.ResetText();
                comboBox2.Text = "";
                textBox15.Clear();
                textBox16.Clear();
                ADD_NEW_PRODUCTS_Load(sender, e);
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
                sdate = dateTimePicker2.Value;
                date2 = dateTimePicker3.Value;
                string updatequery = string.Format("UPDATE PRODUCT SET PRODUCTNAME = ('{0}'), INSTRUCTION = ('{1}'), FORMULA = ('{2}'), QUANTITYINSTOCK = ('{3}'), PACKINGID = ('{4}'), BATCHID = ('{5}'), TRADEMARKID = ('{6}'), RETAILPRICE = ('{7}'),  MARKUP= ('{8}'), MANUFACTUREDATE = ('{9}'), EXPIRYDATE  = ('{10}') WHERE PRODUCTID =('{11}')", textBox2.Text, textBox3.Text, textBox9.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox14.Text), Convert.ToInt32(textBox13.Text), Convert.ToDouble(textBox6.Text), Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox19.Text), sdate, date2, Convert.ToInt32(textBox1.Text));
                EventMangementSystemClass.Update(updatequery);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox9.Clear();
                textBox19.Clear();
                textBox13.Clear();
                comboBox4.Text = "";
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                textBox5.Clear();
                textBox6.Clear();
                comboBox4.Text = "";
                textBox18.Clear();
                maskedTextBox1.ResetText();
                textBox17.Clear();
                comboBox1.Text = "";
                textBox14.Clear();
                dateTimePicker1.ResetText();
                comboBox2.Text = "";
                textBox15.Clear();
                textBox16.Clear();
                ADD_NEW_PRODUCTS_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = dateTimePicker1.Value;
                date2 = dateTimePicker2.Value;
                string updatequery = string.Format("delete from PRODUCT where ProductId = ('{0}')", textBox1.Text);
                EventMangementSystemClass.Update(updatequery);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox9.Clear();
                textBox19.Clear();
                textBox13.Clear();
                comboBox4.Text = "";
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                textBox5.Clear();
                textBox6.Clear();
                comboBox4.Text = "";
                textBox18.Clear();
                maskedTextBox1.ResetText();
                textBox17.Clear();
                comboBox1.Text = "";
                textBox14.Clear();
                dateTimePicker1.ResetText();
                comboBox2.Text = "";
                textBox15.Clear();
                textBox16.Clear();
                ADD_NEW_PRODUCTS_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            //dateTimePicker2.Text = dataGridView2.CurrentRow.Cells[12].Value.ToString();
            //dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            textBox19.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();

            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from TRADEMARK where TRADEMARKID = ('{0}')", textBox13.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox4.Text = DR.GetValue(1).ToString();
                    textBox18.Text = DR.GetValue(2).ToString();
                    maskedTextBox1.Text = DR.GetValue(4).ToString();
                    textBox17.Text = DR.GetValue(3).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from BATCH where BATCHID = ('{0}')", textBox14.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox1.Text = DR.GetValue(1).ToString();
                    dateTimePicker1.Text = DR.GetValue(2).ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from PACKINGTYPE where PACKINGid = ('{0}')", textBox15.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox2.Text = DR.GetValue(0).ToString();
                    textBox16.Text = DR.GetValue(2).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string query1 = string.Format("select * from PRODUCT where PRODUCTID = ('{0}')", Convert.ToInt32(textBox10.Text));

                SqlConnection Conn1 = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand Comm1 = new SqlCommand(query1, Conn1);
                Conn1.Open();
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                    textBox1.Text = DR1.GetValue(0).ToString();
                    textBox2.Text = DR1.GetValue(1).ToString();
                    textBox3.Text = DR1.GetValue(2).ToString();
                    textBox4.Text = DR1.GetValue(4).ToString();
                    textBox9.Text = DR1.GetValue(3).ToString();
                    textBox13.Text = DR1.GetValue(7).ToString();
                    textBox14.Text = DR1.GetValue(6).ToString();
                    textBox15.Text = DR1.GetValue(5).ToString();
                    textBox5.Text = DR1.GetValue(9).ToString();
                    textBox6.Text = DR1.GetValue(8).ToString();
                    textBox19.Text = DR1.GetValue(10).ToString();
                    dateTimePicker2.Text = DR1.GetValue(11).ToString();
                    dateTimePicker3.Text = DR1.GetValue(12).ToString();
                }
                Conn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from TRADEMARK where TRADEMARKID = ('{0}')", textBox13.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox4.Text = DR.GetValue(1).ToString();
                    textBox18.Text = DR.GetValue(2).ToString();
                    maskedTextBox1.Text = DR.GetValue(4).ToString();
                    textBox17.Text = DR.GetValue(3).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from BATCH where BATCHID = ('{0}')", textBox14.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox1.Text = DR.GetValue(1).ToString();
                    dateTimePicker1.Text = DR.GetValue(2).ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from PACKINGTYPE where PACKINGid = ('{0}')", textBox15.Text);
                SqlConnection connection = new SqlConnection(path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox2.Text = DR.GetValue(0).ToString();
                    textBox16.Text = DR.GetValue(2).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

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
