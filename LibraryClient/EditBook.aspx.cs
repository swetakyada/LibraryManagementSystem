using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class EditBook : System.Web.UI.Page
    {
        public ServiceReference1.Book book;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            book = proxy.GetBook(int.Parse(Request.QueryString["id"]));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Title = TextBox1.Text.Trim();
            string Author = TextBox2.Text.Trim();
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            if (proxy.UpdateBook(book.Id, Title, Author))
                Response.Redirect("Home.aspx");
            else
                Label4.Text = "Failed to edit book.";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}