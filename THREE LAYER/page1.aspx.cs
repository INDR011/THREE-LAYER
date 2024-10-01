using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace THREE_LAYER
{
    
    public partial class page1 : System.Web.UI.Page
    {
        Insert objbll = new Insert();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "~/P/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(s));

            int i = objbll.DBInsert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), TextBox3.Text, s, TextBox4.Text, TextBox5.Text);
            if(i!=0)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}