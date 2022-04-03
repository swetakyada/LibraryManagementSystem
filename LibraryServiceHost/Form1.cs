using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel.Description;

namespace LibraryServiceHost
{
    public partial class Form1 : Form
    {
        ServiceHost sh = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri baseUrl = new Uri("http://localhost:8000/LibraryService");
            sh = new ServiceHost(typeof(LibraryService.Service), baseUrl);
            sh.AddServiceEndpoint(typeof(LibraryService.IService), new WSHttpBinding(), "http://localhost:8000/LibraryService");
            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;
            sh.Description.Behaviors.Add(behavior);
            sh.Open();
            label1.Text = "Service Running...!";
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            sh.Close();
        }
    }
}
