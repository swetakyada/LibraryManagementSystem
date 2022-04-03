using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class IssueBook : System.Web.UI.Page
    {
        public ServiceReference1.Book book;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            book = proxy.GetBook(int.Parse(Request.QueryString["id"]));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int student = int.Parse(TextBox1.Text);
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            if (proxy.IssueBook(student, book.Id))
                Response.Redirect("Home.aspx");
            else
                Label5.Text = "Failed to issue the book";
        }
    }
}