using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace KJT.Models.Common
{
    public class DbConnection
    {
        public static string ConnectionString = string.Empty;
        public DbConnection()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
        }

        public DataTable GetDataTable(string SPname, SqlParameter[] parameter)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SPname))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameter != null)
                    {
                        foreach (SqlParameter param in parameter)
                            cmd.Parameters.Add(param);
                    }
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        public DataSet GetDataSet(string SPname, SqlParameter[] parameter)
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SPname))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameter != null)
                    {
                        foreach (SqlParameter param in parameter)
                            cmd.Parameters.Add(param);
                    }
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                }
            }
            return ds;
        }

        public int GetExecutenonQuery(string SPname, SqlParameter[] parameter)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SPname))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameter != null)
                    {
                        foreach (SqlParameter param in parameter)
                            cmd.Parameters.Add(param);
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            return 0;
        }
    }
}