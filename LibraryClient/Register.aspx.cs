using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Email = TextBox2.Text;
            string Password = TextBox3.Text;
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            if (proxy.RegisterStudent(Name, Email, Password) >= 0)
                Response.Redirect("Login.aspx");
            else
                Label4.Text = "Failed to register student!";
        }
    }
}