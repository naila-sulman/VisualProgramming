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
        public static string Path = @"Data Source=(local);Initial Catalog=JMS;Integrated Security=True";
        public static DataTable ReturnTable(string searchQuery)
        {

            SqlConnection connection = new SqlConnection(Path);
            SqlCommand sc = new SqlCommand(searchQuery, connection);
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(sc);
            sd.Fill(dt);
            connection.Close();
            return dt;

        }
        public static void Add(string AddQuery)
        {
            
            SqlConnection connection = new SqlConnection(Path);
            SqlCommand command = new SqlCommand(AddQuery, connection);
            connection.Open();
            var RowEffected = command.ExecuteNonQuery();
            if (RowEffected > 0)
            {

            }
            else
            {
                MessageBox.Show("RECORD NOT SAVED!!!");
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
                MessageBox.Show("DELETION ERROR!!!");
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

            }
            else
            {
                MessageBox.Show("RECORD DOES NOT EXIST!!!");
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

            }
            else
            {
                MessageBox.Show("UPDATE ERROR!!!");
            }

        }
    }
}

