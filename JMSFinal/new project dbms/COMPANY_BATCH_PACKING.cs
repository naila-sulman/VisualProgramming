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
    public partial class COMPANY_BATCH_PACKING : Form
    {
        public COMPANY_BATCH_PACKING()
        {
            InitializeComponent();
        }

        private void COMPANY_BATCH_PACKING_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seven86settings.PACKINGTYPE' table. You can move, or remove it, as needed.
            this.pACKINGTYPETableAdapter1.Fill(this.seven86settings.PACKINGTYPE);
            // TODO: This line of code loads data into the 'seven86settings.TRADEMARK' table. You can move, or remove it, as needed.
            this.tRADEMARKTableAdapter1.Fill(this.seven86settings.TRADEMARK);
            // TODO: This line of code loads data into the 'seven86settings.BATCH' table. You can move, or remove it, as needed.
            this.bATCHTableAdapter2.Fill(this.seven86settings.BATCH);
            //// TODO: This line of code loads data into the 'seven86DataSet13.BATCH' table. You can move, or remove it, as needed.
            //this.bATCHTableAdapter1.Fill(this.seven86DataSet13.BATCH);
            //// TODO: This line of code loads data into the 'seven86DataSet1.PACKINGTYPE' table. You can move, or remove it, as needed.
            //this.pACKINGTYPETableAdapter.Fill(this.seven86DataSet1.PACKINGTYPE);
            //// TODO: This line of code loads data into the 'seven86DataSet.TRADEMARK' table. You can move, or remove it, as needed.
            //this.tRADEMARKTableAdapter.Fill(this.seven86DataSet.TRADEMARK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string addquery = string.Format("insert into TRADEMARK(COMPANYNAME,COMPANYADDRESS,CONTACTNUMBER,EMAIL) values ('{0}','{1}','{2}','{3}')", textBox1.Text, textBox2.Text, maskedTextBox1.Text, textBox4.Text);
                EventMangementSystemClass.Add(addquery);
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox4.Clear();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string deletequery = string.Format("delete from TRADEMARK where COMPANYNAME= ('{0}')",textBox1.Text);
                EventMangementSystemClass.DeleteQuery(deletequery);
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox4.Clear();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView1.Refresh();
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
                string updatequery = string.Format("update TRADEMARK set  COMPANYNAME= ('{0}'), COMPANYADDRESS= ('{1}'), CONTACTNUMBER = ('{2}'), EMAIL = ('{3}') where COMPANYNAME = ('{4}')",textBox1.Text,textBox2.Text, maskedTextBox1.Text, textBox4.Text,textBox1.Text);
                EventMangementSystemClass.Update(updatequery);
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox4.Clear();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string addquery = string.Format("insert into PACKINGTYPE(PACKINGTYPE,VOLUME) values ('{0}','{1}')",packingnametextBox.Text,packingvolumetextBox.Text);
                EventMangementSystemClass.Add(addquery);
                packingidtextBox.Clear();
                packingnametextBox.Clear();
                packingvolumetextBox.Clear();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string deletequery = string.Format("delete from PACKINGTYPE where PACKINGID= ('{0}')", Convert.ToInt32( packingidtextBox.Text));
                EventMangementSystemClass.DeleteQuery(deletequery);
                packingidtextBox.Clear();
                packingnametextBox.Clear();
                packingvolumetextBox.Clear();
                COMPANY_BATCH_PACKING_Load(sender, e);
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
                string updatequery = string.Format("update PACKINGTYPE set  PACKINGTYPE= ('{0}'),VOLUME= ('{1}') where PACKINGID = ('{2}')",packingnametextBox.Text,packingvolumetextBox.Text, Convert.ToInt32(packingidtextBox.Text));
                EventMangementSystemClass.Update(updatequery);
                packingidtextBox.Clear();
                packingnametextBox.Clear();
                packingvolumetextBox.Clear();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                packingidtextBox.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                packingnametextBox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                packingnametextBox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                packingidtextBox.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                packingnametextBox.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                packingvolumetextBox.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                sdate = dateTimePicker1.Value;
                System.DateTime sdate1 = default(System.DateTime);
                sdate1 = dateTimePicker1.Value;
                System.DateTime sdate2 = default(System.DateTime);
                sdate2 = dateTimePicker1.Value;
                string addquery = string.Format("insert into BATCH(BATCHNAME,BATCHDATE) values ('{0}','{1}')", textBox3.Text, sdate);
                EventMangementSystemClass.Add(addquery);
                BatchIDtextbox.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView3.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string DELETE = string.Format("delete from BATCH where BATCHID= ('{0}')", Convert.ToInt32(BatchIDtextbox.Text));
                EventMangementSystemClass.DeleteQuery(DELETE);
                BatchIDtextbox.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView3.Refresh();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {

                System.DateTime sdate = default(System.DateTime);
                sdate = dateTimePicker1.Value;
                System.DateTime sdate1 = default(System.DateTime);
                sdate1 = dateTimePicker1.Value;
                System.DateTime sdate2 = default(System.DateTime);
                sdate2 = dateTimePicker1.Value;
                string updatequery = string.Format("UPDATE BATCH SET BATCHNAME = ('{0}'),BATCHDATE = ('{1}') WHERE BATCHID = ('{2}')",textBox3.Text,sdate, Convert.ToInt32(BatchIDtextbox.Text));
                EventMangementSystemClass.Update(updatequery);
                BatchIDtextbox.Clear();
                textBox3.Clear();
                dateTimePicker1.ResetText();
                COMPANY_BATCH_PACKING_Load(sender, e);
                dataGridView3.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BatchIDtextbox.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
           textBox3.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
           dateTimePicker1.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
