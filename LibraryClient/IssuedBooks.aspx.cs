using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class IssuedBooks : System.Web.UI.Page
    {
        public ServiceReference1.Transaction[] transactions;
        public ServiceReference1.Book[] books;
        public ServiceReference1.Student[] students;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            transactions = proxy.GetIssuedBooksInfo();
            books = new ServiceReference1.Book[transactions.Length];
            students = new ServiceReference1.Student[transactions.Length];
            for (int i = 0; i < transactions.Length; i++)
            {
                students[i] = proxy.GetStudent(transactions[i].Student);
                books[i] = proxy.GetBook(transactions[i].Book);
            }
        }
    }
}