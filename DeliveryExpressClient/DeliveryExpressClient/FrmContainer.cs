using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryExpressClient
{
    public partial class FrmContainer : Form
    {
        public string User { get; set; }
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void menuClicked(object sender, EventArgs e)
        {
            if (sender.Equals(NewItemStrip))
            {
                insertItem newMDIChild = new insertItem();
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                //Close previous form
                if (this.ActiveMdiChild != null) { this.ActiveMdiChild.Close(); }
                // Display the new form.  
                newMDIChild.Show();
            }
            else if (sender.Equals(UpdateItemStrip))
            {
                updateItem newMDIChild = new updateItem();
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                //Close previous form
                if (this.ActiveMdiChild != null) { this.ActiveMdiChild.Close(); }
                // Display the new form.  
                newMDIChild.Show();
            }
            else if (sender.Equals(ViewItemsStrip))
            {
                viewItems newMDIChild = new viewItems();
                // Set the Parent Form of the Child window.  
                newMDIChild.MdiParent = this;
                //Close previous form 
                if (this.ActiveMdiChild != null) { this.ActiveMdiChild.Close(); }
                // Display the new form.  
                newMDIChild.Show();
               
            }
        }

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            //set default as employee 
            this.User = "employee";
            LoginForm login = new LoginForm();
            // Set the Parent Form of the Child window.  
            login.MdiParent = this;
           
            // Display the new form.  
            login.Show();
            fileMenuStrip.Visible = false;
           

        }

        private void FrmContainer_MdiChildActivate(object sender, EventArgs e)
        {
            
            if (this.User.Equals("employee"))
            {
               var viStrip =  fileMenuStrip.Items.Find("ViewItemsStrip", true).First();
                //viStrip.Visible = false;
                var upStrip = fileMenuStrip.Items.Find("UpdateItemStrip", true).First();
               // upStrip.Visible = false;
                var newStrip = fileMenuStrip.Items.Find("NewItemStrip", true).First();
               // newStrip.Visible = false;
            }
        }

        /* private void toolStripMenuItem1_Click(object sender, EventArgs e)
         {
             Form2 newMDIChild = new Form2();
             // Set the Parent Form of the Child window.  
             newMDIChild.MdiParent = this;
             // Display the new form.  
             newMDIChild.Show();
         }*/
    }
}
