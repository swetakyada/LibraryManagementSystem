using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = TextBox1.Text;
            string Author = TextBox2.Text;
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            if (proxy.AddBook(Name, Author))
                Response.Redirect("Home.aspx");
            else
                Label3.Text = "Failed to add the book";
        }
    }
}