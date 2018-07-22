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
    public partial class VENDOR_INFORMATION : Form
    {
        public VENDOR_INFORMATION()
        {
            InitializeComponent();
        }

        private void VENDOR_INFORMATION_Load(object sender, EventArgs e)
        {
            try
            {
                string SHOW = string.Format("SELECT DISTRIBUTORID,NAME,dbo.DISTRIBUTOR.CONTACTNUMBER,dbo.DISTRIBUTOR.EMAIL,COMPANYNAME FROM dbo.DISTRIBUTOR INNER JOIN dbo.TRADEMARK ON dbo.TRADEMARK.TRADEMARKID =  dbo.DISTRIBUTOR.TRADEMARKID ");
                EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // TODO: This line of code loads data into the 'seven86settings.TRADEMARK' table. You can move, or remove it, as needed.
            this.tRADEMARKTableAdapter.Fill(this.seven86settings.TRADEMARK);
            comboBox1.SelectedValue = ""; ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
                string addquery = string.Format("insert into DISTRIBUTOR (NAME,CONTACTNUMBER,TRADEMARKID,EMAIL)values ('{0}','{1}','{2}','{3}')",vendornametextbox.Text,maskedTextBox1.Text,Convert.ToInt32(textBox1.Text),emailtextbox.Text);
                EventMangementSystemClass.Add(addquery);
                var query = string.Format("SELECT * FROM DISTRIBUTOR");
                EventMangementSystemClass.RecordShow(query, dataGridView2);
                Vendoridtextbox.Clear();
                vendornametextbox.Clear();
                maskedTextBox1.Clear();
                emailtextbox.Clear();
                comboBox1.Text = "";
                textBox1.Clear();
                companyaddresstextbox.Clear();
                contactnumbertextbox.Clear();
                emailaddresstextbox.Clear();
                VENDOR_INFORMATION_Load(sender, e);
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
            string updatequery = string.Format("delete from DISTRIBUTOR  where DISTRIBUTORID = ('{0}')", Convert.ToInt32(Vendoridtextbox.Text ));
            EventMangementSystemClass.Update(updatequery);
            var query = string.Format("SELECT * FROM DISTRIBUTOR");
            EventMangementSystemClass.RecordShow(query, dataGridView2);
            Vendoridtextbox.Clear();
            vendornametextbox.Clear();
            maskedTextBox1.Clear();
            emailtextbox.Clear();
            comboBox1.Text = "";
            textBox1.Clear();
            companyaddresstextbox.Clear();
            contactnumbertextbox.Clear();
            emailaddresstextbox.Clear();
            VENDOR_INFORMATION_Load(sender, e);
            dataGridView2.Refresh();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
                string updatequery = string.Format("UPDATE DISTRIBUTOR SET NAME = ('{0}'), CONTACTNUMBER = ('{1}'),TRADEMARKID = ('{2}'), EMAIL = ('{3}') where DISTRIBUTORID=('{4}')", vendornametextbox.Text, maskedTextBox1.Text, Convert.ToInt32(textBox1.Text), emailtextbox.Text,Convert.ToInt32(Vendoridtextbox.Text));
            EventMangementSystemClass.Update(updatequery);
            var query = string.Format("SELECT * FROM DISTRIBUTOR");
            EventMangementSystemClass.RecordShow(query, dataGridView2);
            Vendoridtextbox.Clear();
            vendornametextbox.Clear();
            maskedTextBox1.Clear();
            emailtextbox.Clear();
            comboBox1.SelectedValue = ""; ;
            textBox1.Clear();
            companyaddresstextbox.Clear();
            contactnumbertextbox.Clear();
            emailaddresstextbox.Clear();
            VENDOR_INFORMATION_Load(sender, e);
            dataGridView2.Refresh();
            // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();
            //this.Hide();

        }

        private void contactnumbertextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void emailaddresstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void companyaddresstextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from TRADEMARK where COMPANYNAME = ('{0}')", comboBox1.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox1.Text = DR.GetValue(0).ToString();
                    companyaddresstextbox.Text = DR.GetValue(2).ToString();
                    contactnumbertextbox.Text = DR.GetValue(4).ToString();
                    emailaddresstextbox.Text = DR.GetValue(3).ToString();
                }
                connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Vendoridtextbox.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            vendornametextbox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            emailtextbox.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from TRADEMARK where TRADEMARKID = ('{0}')", textBox1.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox1.Text = DR.GetValue(1).ToString();
                    companyaddresstextbox.Text = DR.GetValue(2).ToString();
                    maskedTextBox1.Text = DR.GetValue(4).ToString();
                    emailaddresstextbox.Text = DR.GetValue(3).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void Comapny(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void SearchingCustomerIDtextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string SHOW = string.Format("SELECT * FROM dbo.DISTRIBUTOR WHERE NAME LIKE ('{0}%')", SearchingCustomerIDtextbox.Text);
                EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
                textBox1.Clear();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "")
                {
                    string SHOW = string.Format("SELECT DISTRIBUTORID,NAME,dbo.DISTRIBUTOR.CONTACTNUMBER,dbo.DISTRIBUTOR.EMAIL,COMPANYNAME FROM dbo.DISTRIBUTOR INNER JOIN dbo.TRADEMARK ON dbo.TRADEMARK.TRADEMARKID =  dbo.DISTRIBUTOR.TRADEMARKID  WHERE dbo.TRADEMARK.TRADEMARKID=  (SELECT dbo.TRADEMARK.TRADEMARKID FROM dbo.TRADEMARK WHERE COMPANYNAME LIKE ('{0}%'))", textBox2.Text);
                    EventMangementSystemClass.RecordShow(SHOW, dataGridView2);
                    textBox1.Clear();
                }
                else
                {
                    VENDOR_INFORMATION_Load(sender, e);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
