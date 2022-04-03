using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox2.Text.Trim();
            string password = TextBox3.Text.Trim();
            if (username == "admin" && password == "admin")
            {
                Response.Redirect("Home.aspx");
            }
            else
                Label4.Text = "Please enter correct details.";
        }
    }
}