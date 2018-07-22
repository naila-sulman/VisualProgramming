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
    public partial class ADD_EMPLOYEES : Form
    {
        public ADD_EMPLOYEES()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = dateTimePicker2.Value;
                date2 = dateTimePicker3.Value;
                string addquery = string.Format("insert into EMPLOYEES(EMPLOYEENAME,JOINDATE,LEAVEDATE,CONTACTNUMBER,NIC,[ADDRESS],DESIGNATION,SALARY,[STATUS]) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", textBox4.Text, sdate, date2, maskedTextBox2.Text, maskedTextBox1.Text, textBox1.Text, textBox5.Text, Convert.ToInt32(textBox3.Text), textBox8.Text);
                EventMangementSystemClass.Add(addquery);
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                textBox1.Clear();
                textBox8.Clear();
                maskedTextBox1.ResetText();
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                ADD_EMPLOYEES_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ADD_EMPLOYEES_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seven86DataSet31.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter2.Fill(this.seven86DataSet31.EMPLOYEES);
            // TODO: This line of code loads data into the 'seven86settings.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter1.Fill(this.seven86settings.EMPLOYEES);
            //// TODO: This line of code loads data into the 'seven86DataSet9.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.seven86DataSet9.EMPLOYEES);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string deletequery = string.Format("delete from EMPLOYEES where EMPLOYEEID= ('{0}')", textBox2.Text);
                EventMangementSystemClass.DeleteQuery(deletequery);
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                textBox1.Clear();
                textBox8.Clear();
                maskedTextBox1.ResetText();
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                ADD_EMPLOYEES_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{
             System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                sdate = dateTimePicker2.Value;
                date2 = dateTimePicker3.Value;

                string updatequery = string.Format("update EMPLOYEES set  EMPLOYEENAME= ('{0}'), JOINDATE= ('{1}'), LEAVEDATE= ('{2}'),CONTACTNUMBER= ('{3}'), NIC= ('{4}'), [ADDRESS]= ('{5}'), DESIGNATION= ('{6}'), SALARY= ('{7}'), [STATUS]= ('{8}') where EMPLOYEEID = ('{9}')", textBox4.Text, sdate, date2, maskedTextBox2.Text, maskedTextBox1.Text, textBox1.Text, textBox5.Text, Convert.ToInt32( textBox3.Text), textBox8.Text, Convert.ToInt32( textBox2.Text));
                EventMangementSystemClass.Update(updatequery);
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                textBox1.Clear();
                textBox8.Clear();
                maskedTextBox1.ResetText();
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                ADD_EMPLOYEES_Load(sender, e);
                dataGridView1.Refresh();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker2.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker3.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

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
