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
    public partial class TASKS : Form
    {
        public TASKS()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string addquery = string.Format("insert into TASKS (DETAILS,TASKPURPOSE) values ('{0}','{1}')", textBox1.Text, textBox4.Text);
                EventMangementSystemClass.Add(addquery);
                textBox1.Clear();
                textBox4.Clear();
                textBox2.Clear();
                TASKS_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string deletequery = string.Format("delete from TASKS where TASKID= ('{0}')", textBox2.Text);
                EventMangementSystemClass.DeleteQuery(deletequery);
                textBox1.Clear();
                textBox4.Clear();
                textBox2.Clear();
                TASKS_Load(sender, e);
                dataGridView1.Refresh();
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
                string updatequery = string.Format("update TASKS set  DETAILS= ('{0}'), TASKPURPOSE= ('{1}') where TASKID = ('{2}')", textBox1.Text, textBox4.Text, textBox2.Text);
                EventMangementSystemClass.Update(updatequery);
                textBox1.Clear();
                textBox4.Clear();
                textBox2.Clear();
                TASKS_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TASKS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seven86DataSet25.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter2.Fill(this.seven86DataSet25.EMPLOYEES);
            // TODO: This line of code loads data into the 'seven86DataSet24.ASSIGNEDTASKS' table. You can move, or remove it, as needed.
            this.aSSIGNEDTASKSTableAdapter2.Fill(this.seven86DataSet24.ASSIGNEDTASKS);
            // TODO: This line of code loads data into the 'seven86DataSet23.asigntaskview' table. You can move, or remove it, as needed.
            //this.asigntaskviewTableAdapter.Fill(this.seven86DataSet23.asigntaskview);
            // TODO: This line of code loads data into the 'seven86settings.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter1.Fill(this.seven86settings.EMPLOYEES);
            // TODO: This line of code loads data into the 'seven86settings.ASSIGNEDTASKS' table. You can move, or remove it, as needed.
            //this.aSSIGNEDTASKSTableAdapter1.Fill(this.seven86settings.ASSIGNEDTASKS);
            // TODO: This line of code loads data into the 'seven86settings.TASKS' table. You can move, or remove it, as needed.
            this.tASKSTableAdapter1.Fill(this.seven86settings.TASKS);
            //// TODO: This line of code loads data into the 'seven86DataSet10.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.seven86DataSet10.EMPLOYEES);
            //// TODO: This line of code loads data into the 'seven86DataSet8.ASSIGNEDTASKS' table. You can move, or remove it, as needed.
            //this.aSSIGNEDTASKSTableAdapter.Fill(this.seven86DataSet8.ASSIGNEDTASKS);
            //// TODO: This line of code loads data into the 'seven86DataSet7.TASKS' table. You can move, or remove it, as needed.
            //this.tASKSTableAdapter.Fill(this.seven86DataSet7.TASKS);
            comboBox1.Text="";

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                System.DateTime D = default(System.DateTime);
                D = dateTimePicker1.Value;
                sdate = dateTimePicker2.Value;
                date2 = dateTimePicker3.Value;
                string addquery = string.Format("insert into ASSIGNEDTASKS (TASK,STARTTIME,ENDTIME,REMARKS,ASSIGNEDDATE,TASKID,EMPID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", textBox18.Text, sdate, date2, textBox21.Text, D, textBox5.Text,Convert.ToInt32(textBox7.Text));
                EventMangementSystemClass.Add(addquery);
                textBox3.Clear();
                comboBox1.ResetText();
                textBox7.Clear();
                textBox18.Clear();
                textBox5.Clear();
                textBox21.Clear();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                TASKS_Load(sender, e);
                dataGridView4.Refresh();
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
                string deletequery = string.Format("delete from ASSIGNEDTASKS where ASSIGNEDTASKID= ('{0}')", textBox3.Text);
                EventMangementSystemClass.DeleteQuery(deletequery);
                textBox3.Clear();
                textBox18.Clear();
                comboBox1.ResetText();
                textBox7.Clear();
                textBox5.Clear();
                textBox21.Clear();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                TASKS_Load(sender, e);
                dataGridView1.Refresh();
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
                System.DateTime sdate = default(System.DateTime);
                System.DateTime date2 = default(System.DateTime);
                System.DateTime D = default(System.DateTime);
                D = dateTimePicker1.Value;
                sdate = dateTimePicker2.Value;
                date2 = dateTimePicker3.Value;
                string updatequery = string.Format("update ASSIGNEDTASKS set  TASK= ('{0}'), STARTTIME= ('{1}'), ENDTIME= ('{2}'), REMARKS= ('{3}'), ASSIGNEDDATE= ('{4}'), TASKID= ('{5}'),EMPID= ('{6}') where ASSIGNEDTASKID = ('{6}')", textBox18.Text, sdate, date2, textBox21.Text, D, textBox5.Text,Convert.ToInt32( textBox7.Text), textBox3.Text);
                EventMangementSystemClass.Update(updatequery);
                textBox3.Clear();
                textBox18.Clear();
                textBox7.Clear();
                textBox5.Clear();
                comboBox1.ResetText();
                textBox21.Clear();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();
                dateTimePicker3.ResetText();
                TASKS_Load(sender, e);
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textBox18.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox18.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text=dataGridView4.CurrentRow.Cells[0].Value.ToString();
            textBox18.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            textBox21.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker3.Text=dataGridView4.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView4.CurrentRow.Cells[7].Value.ToString();
            try
            {
                //string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from    EMPLOYEES where EMPLOYEEID= ('{0}')", Convert.ToInt32(textBox7.Text));
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    comboBox1.Text = DR.GetValue(1).ToString();
                    
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               // string path = @"Data Source=AAMIR-PC\AMIR;Initial Catalog=Seven86;Integrated Security=True";
                string Query = string.Format("select * from EMPLOYEES where EMPLOYEENAME = ('{0}')", comboBox1.Text);
                SqlConnection connection = new SqlConnection(EventMangementSystemClass.Path);
                SqlCommand sc = new SqlCommand(Query, connection);
                connection.Open();
                SqlDataReader DR = sc.ExecuteReader();
                if (DR.Read())
                {
                    textBox7.Text = DR.GetValue(0).ToString();
                }
                connection.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
