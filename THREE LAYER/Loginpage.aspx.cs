using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL; 


namespace THREE_LAYER
{
    public partial class Loginpage : System.Web.UI.Page
    {
        Logincls objcls = new Logincls();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string cid = objcls.GetCountId(TextBox1.Text, TextBox2.Text);
            if (cid == "1")
            {
                string id = objcls.GetId(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                Response.Redirect("page3.aspx");
            }
            else
            {
                Label1.Text = "Invalid";
            }
        }
    }
}