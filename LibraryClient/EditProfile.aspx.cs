using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryClient
{
    public partial class EditProfile : System.Web.UI.Page
    {
        public ServiceReference1.Student student;
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            student = proxy.GetStudent(int.Parse(Session["id"].ToString()));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Session["id"].ToString());
            string name = TextBox1.Text.Trim();
            string email = TextBox2.Text.Trim();
            ServiceReference1.ServiceClient proxy = new ServiceReference1.ServiceClient("BasicHttpBinding_IService");
            if (proxy.UpdateStudentInfo(id, name, email))
                Response.Redirect("Profile.aspx");
            else
                Label3.Text = "Failed to update student info.";
        }
    }
}