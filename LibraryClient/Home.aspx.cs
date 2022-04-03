using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class Home : System.Web.UI.Page
    {
        public ServiceReference1.Book[] books;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            books = proxy.GetBooks();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }
    }
}