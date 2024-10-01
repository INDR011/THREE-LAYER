using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connectionclass
    {
            SqlConnection con;
            SqlCommand cmd;

            public Connectionclass()
            {
                con = new SqlConnection(@"server=LAPTOP-TPBF88I9\SQLEXPRESS;database=ASP Example;Integrated Security=True");
            }
            public int Fun_exenonquery(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            public string Fun_exescalar(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                string s = cmd.ExecuteScalar().ToString();
                con.Close();
                return s;
            }
            public SqlDataReader Fun_exeReader(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            public DataSet Fun_exeAdapter(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            public DataTable Fn_Exedatatable(string sqlquery)//select
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
}
