using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EventManagementSystem_Concert_;
using System.Data.SqlClient;
using new_project_dbms;

namespace buttonchk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Left--;
            label3.Left--;
            label4.Left--;
            label5.Left--;
            label6.Left--;
            label7.Left--;
            label8.Left--;
            label9.Left--;
            label10.Left--;
            label11.Left--;
            label12.Left--;
            label13.Left--;
            label14.Left--;
            label15.Left--;
            label16.Left--;
            label17.Left--;
            label18.Left--;
            label19.Left--;
            label20.Left--;
            label21.Left--;
            label22.Left--;
            
            if (label2.Location.X == -20)
            {
                label2.Location = new Point(1355, 164);
            }
            if (label3.Location.X == -20)
            {
                label3.Location = new Point(1355, 164);
            }
            if (label4.Location.X == -20)
            {
                label4.Location = new Point(1355, 164);
            }
            if (label5.Location.X == -20)
            {
                label5.Location = new Point(1355, 164);
            }
            if (label6.Location.X == -20)
            {
                label6.Location = new Point(1355, 164);
            }
            if (label7.Location.X == -20)
            {
                label7.Location = new Point(1355, 164);
            }
            if (label8.Location.X == -20)
            {
                label8.Location = new Point(1355, 164);
            }
            if (label9.Location.X == -20)
            {
                label9.Location = new Point(1355, 164);
            }
            if (label10.Location.X == -20)
            {
                label10.Location = new Point(1355, 164);
            }
            if (label11.Location.X == -20)
            {
                label11.Location = new Point(1355, 164);
            }
            if (label12.Location.X == -20)
            {
                label12.Location = new Point(1355, 164);
            }
            if (label13.Location.X == -20)
            {
                label13.Location = new Point(1355, 164);
            }
            if (label14.Location.X == -20)
            {
                label14.Location = new Point(1355, 164);
            }
            if (label15.Location.X == -20)
            {
                label15.Location = new Point(1355, 164);
            }
            if (label16.Location.X == -20)
            {
                label16.Location = new Point(1355, 164);
            }
            if (label17.Location.X == -20)
            {
                label17.Location = new Point(1355, 164);
            }
            if (label18.Location.X == -20)
            {
                label18.Location = new Point(1355, 164);
            }
            if (label19.Location.X == -20)
            {
                label19.Location = new Point(1355, 164);
            }
            if (label20.Location.X == -20)
            {
                label20.Location = new Point(1355, 164);
            }
            if (label21.Location.X == -20)
            {
                label21.Location = new Point(1355, 164);
            }
            if (label22.Location.X == -20)
            {
                label22.Location = new Point(1355, 164);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox16.Location = new Point(174, -4);
            //pictureBox17.Location = new Point(174, -4);
            //pictureBox18.Location = new Point(174, -4);
            //pictureBox19.Location = new Point(174, -4);
            timer2.Enabled = true;
            timer1.Enabled = true;
            try
            {
                string SHOW = string.Format("SELECT ASSIGNEDTASKID,TASK,STARTTIME,ENDTIME,REMARKS,ASSIGNEDDATE,TASKID,EMPID,EMPLOYEENAME FROM dbo.ASSIGNEDTASKS INNER JOIN dbo.EMPLOYEES ON dbo.EMPLOYEES.EMPLOYEEID=dbo.ASSIGNEDTASKS.EMPID WHERE REMARKS= 'NO' OR REMARKS= 'NO'");
                EventMangementSystemClass.RecordShow(SHOW, dataGridView1);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TAKE_NEW_ORDER T = new TAKE_NEW_ORDER();
            T.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CUSTOMER_INFORMATION C = new CUSTOMER_INFORMATION();
            C.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PLACE_ORDER P = new PLACE_ORDER();
            P.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VENDOR_INFORMATION V = new VENDOR_INFORMATION();
            V.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ADD_NEW_PRODUCTS A = new ADD_NEW_PRODUCTS();
            A.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            COMPANY_BATCH_PACKING C2 = new COMPANY_BATCH_PACKING();
            C2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PRODUCTRETURN MP = new PRODUCTRETURN();
            MP.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TASKS T = new TASKS();
            T.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            COMPANY_BATCH_PACKING C3 = new COMPANY_BATCH_PACKING();
            C3.Show();
        }
        int counting = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            counting++;
            //pictureBox16.Visible = true;
            //pictureBox17.Visible = false;
            //pictureBox18.Visible = false;
            //pictureBox19.Visible = false;
            if ( counting == 10)
            {
                timer2.Enabled = false;
                timer3.Enabled = true;
                counting = 0;
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            counting++; 
            //pictureBox16.Visible = false;
            //pictureBox17.Visible = true;
            //pictureBox18.Visible = false;
            //pictureBox19.Visible = false;
            if (counting == 10)
            {
                timer3.Enabled = false;
                timer4.Enabled = true;
                counting = 0;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            counting++;
            //pictureBox16.Visible = false;
            //pictureBox17.Visible = false;
            //pictureBox18.Visible = true;
            //pictureBox19.Visible = false;
            if (counting == 10)
            {
                timer4.Enabled = false;
                timer5.Enabled = true;
                counting = 0;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            counting++;
            //pictureBox16.Visible = false;
            //pictureBox17.Visible = false;
            //pictureBox18.Visible = false;
            //pictureBox19.Visible = true;
            if (counting == 10)
            {
                timer5.Enabled = false;
                timer2.Enabled = true;
                counting = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EXPIRIES E1 = new EXPIRIES();
            E1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BILL B1 = new BILL();
            B1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            COMPANY_BATCH_PACKING C = new COMPANY_BATCH_PACKING();
            C.Show();
        }
    }
}
