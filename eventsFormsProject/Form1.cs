using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eventsFormsProject
{
    public partial class Form1 : Form
    {
        private DataView usersDataView;
        List<UserClass> loginList = new List<UserClass>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventsDBDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.eventsDBDataSet.users);
            RefreshDataGridView();


        }

        private void RefreshDataGridView()
        {
        
            this.eventsDBDataSet.users.Clear();
            this.usersTableAdapter.Fill(this.eventsDBDataSet.users);
            usersDataView = new DataView(eventsDBDataSet.users);
            dataGridView1.DataSource = usersDataView;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                string n = login.userName;
                textBoxUserID.Text = "welcome, " + n;
                UserClass uc = new UserClass(n);
                loginList.Add(uc);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {

                if (int.TryParse(searchText, out int id))
                {
                    usersDataView.RowFilter = string.Format("ID = {0}", id);
                }
                else
                {

                    usersDataView.RowFilter = string.Format("username LIKE '%{0}%'", searchText);
                }
            }
            else
            {
                usersDataView.RowFilter = "";
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                string n = login.userName;
                textBoxUserID.Text = "welcome, " + n;
                UserClass uc = new UserClass(n);
                loginList.Add(uc);
            }
        }
    }
}








