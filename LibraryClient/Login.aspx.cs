using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Email = TextBox2.Text.Trim();
            string Password = TextBox3.Text.Trim();
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            int id = proxy.LoginStudent(Email, Password);
            if (id > 0)
            {
                Session["id"] = id.ToString();
                Response.Redirect("StudentHome.aspx");
            }
            else
                Label4.Text = "Please enter correct details.";
        }
    }
}