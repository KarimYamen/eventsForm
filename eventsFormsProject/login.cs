using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eventsFormsProject.eventsDBDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace eventsFormsProject
{
    public partial class login : Form
    {
        
        public string userName;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventsDBDataSet.users' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.eventsDBDataSet2.admin);

        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            string id = textBoxUserID.Text;
            string pass = textBoxPass.Text;

            DataTable admin = this.adminTableAdapter1.GetData();


            bool credentialsMatch = false;

            foreach (DataRow row in admin.Rows)
            {
                string UserID = row["userID"].ToString(); 
                string Password = row["password"].ToString(); 

                if (id == UserID && pass == Password)
                {
                    credentialsMatch = true;
                    break; 
                }
            }

            if (credentialsMatch)
            {
                userName = textBoxUserID.Text;
                this.DialogResult = DialogResult.OK;
            
            }
                else
                {
                    textBoxUserID.Text = "";
                    textBoxPass.Text = "";
                    MessageBox.Show("User Id or password is incorrect");
                }
        }

        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBoxPass.UseSystemPasswordChar = false;
                
            } else
            {
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxUserID.Text = "";
            textBoxPass.Text = "";
        }
    }
}
