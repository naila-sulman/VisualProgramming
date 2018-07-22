using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventManagementSystem_Concert_
{
    class EventMangementSystemClass
    {
        static string Path = @"Data Source=AWAISOO-PC\SQLEXPRESS;Initial Catalog=EventMangementSystem(Concert);Integrated Security=True";
        public static void Add(string AddQuery)
        {
            
            SqlConnection connection = new SqlConnection(Path);
            SqlCommand command = new SqlCommand(AddQuery, connection);
            connection.Open();
            var RowEffected = command.ExecuteNonQuery();
            if (RowEffected > 0)
            {
                MessageBox.Show("Record Save SuccesFully!!!");

            }
            else
            {
                MessageBox.Show("No Such record Saved Successfully!!!");
            }
            connection.Close();
        }
        public static void DeleteQuery(string DeleteQuery)
        {
           // string Path = null;
            SqlConnection connection = new SqlConnection(Path);
            SqlCommand command = new SqlCommand(DeleteQuery, connection);
            connection.Open();
            var RowEffected = command.ExecuteNonQuery();
            if (RowEffected > 0)
            {
                MessageBox.Show("Record Delete SuccesFully!!!");

            }
            else
            {
                MessageBox.Show("No Such Record Deleted!!!");
            }

            connection.Close();
        }
        public static void RecordShow(string SelectQuery,DataGridView Grid)
        {
            SqlConnection Connection = new SqlConnection(Path);
            SqlCommand Command = new SqlCommand(SelectQuery, Connection);
            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(dt);
            Grid.DataSource = dt.DefaultView;
        }
        public static void Search(string SearchQuery)
        {
            SqlConnection connection = new SqlConnection(Path);
            SqlCommand command = new SqlCommand(SearchQuery, connection);
            DataSet dataset = new DataSet();
            connection.Open();
            var RowEffected = command.ExecuteNonQuery();
            if (RowEffected > 0)
            {
                MessageBox.Show("Record Search SuccesFully!!!");

            }
            else
            {
                MessageBox.Show("No Such record Exist!!!");
            }

        }
        public static void Update(string UpdateQuery)
        {
          //  string Path = null;
            SqlConnection connection = new SqlConnection(Path);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            connection.Open();
            var RowEffected = command.ExecuteNonQuery();
            if (RowEffected > 0)
            {
                MessageBox.Show("Record Update SuccesFully!!!");

            }
            else
            {
                MessageBox.Show("No Such record update Successfully!!!");
            }

        }
    }
}

