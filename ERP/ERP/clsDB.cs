using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace ERP
{
    class clsDB
    {
        #region DB Functions
        public static OleDbConnection getConnection()
        {
            OleDbConnection con = new OleDbConnection(ConfigurationManager.AppSettings["Connection"]);
            con.Open();
            return con;
        }

        public static DataSet getddataset(string aaa)
        {
            OleDbConnection con = getConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand(aaa, con);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();

            da.Fill(ds);
            con.Close();
            return ds;
        }

        public static DataTable getdata(string str)
        {
            OleDbConnection con = getConnection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand(str, con);
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static string GetScalor(string query)
        {
            try
            {
                OleDbConnection con = getConnection();
                OleDbCommand cmd = new OleDbCommand(query, con);
                return cmd.ExecuteScalar().ToString();
            }
            catch
            {
                return null;
            }

        }

        public static void executeQuery(string str)
        {
            OleDbConnection con = getConnection();
            OleDbCommand cmd = new OleDbCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
    }
}
