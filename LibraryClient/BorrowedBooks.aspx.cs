using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class BorrowedBooks : System.Web.UI.Page
    {
        public ServiceReference1.Transaction[] transactions;
        public ServiceReference1.Book[] books;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            transactions = proxy.GetIssuedBooks(int.Parse(Session["id"].ToString()));
            books = new ServiceReference1.Book[transactions.Length];
            for (int i = 0; i < transactions.Length; i++)
                books[i] = proxy.GetBook(transactions[i].Book);
        }
    }
}