using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventsFormsProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dell\OneDrive\Desktop\TERM 2\info systems\eventsFormsProject\eventsDB.mdf"";Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e) 
        {
            try
            {
                con.Open();
                SqlCommand sql = new SqlCommand("insert into users values('" + textBoxUsername.Text + "','" + textBoxEmail.Text + "','" + textBoxNumber.Text + "','" + textBoxAddress.Text + "')", con);
                sql.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                con.Close();

                string username = textBoxUsername.Text;
                string email = textBoxEmail.Text;
                string number = textBoxNumber.Text;
                string address = textBoxAddress.Text;

                this.usersTableAdapter.InsertQuery(username, email, number, address);
                this.usersTableAdapter.Update(this.eventsDBDataSet.users);
                this.usersTableAdapter.Fill(this.eventsDBDataSet.users);
            }
            catch 
            {
                
            }
        }



        private void labelAddUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }
    }
}

