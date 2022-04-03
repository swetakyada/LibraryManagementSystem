using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class ReturnBook : System.Web.UI.Page
    {
        public int id, book;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"]);
            book = int.Parse(Request.QueryString["book"]);
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            if(proxy.ReturnBook(id, book))
            {
                if(proxy.doTask(book, 0))
                    Response.Redirect("IssuedBooks.aspx");
            }
        }
    }
}