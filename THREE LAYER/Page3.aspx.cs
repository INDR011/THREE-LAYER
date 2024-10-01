using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace THREE_LAYER
{
    public partial class Page3 : System.Web.UI.Page
    {
        profile obj = new profile();
        protected void Page_Load(object sender, EventArgs e)
        {
            int uid = Convert.ToInt32(Session["uid"]);
            SqlDataReader dr = obj.fun_GetData(uid);
            while(dr.Read())
            {
                Label1.Text = dr["name"].ToString();
                Label2.Text = dr["Age"].ToString();
                Label3.Text = dr["address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

        }
    }
}