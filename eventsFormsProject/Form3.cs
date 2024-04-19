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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dell\OneDrive\Desktop\TERM 2\info systems\eventsFormsProject\eventsDB.mdf"";Integrated Security=True");

        private void buttonDelete_Click(object sender, EventArgs e)
        {
                try
                {

                    if (textBoxUserIdToDelete.Text == "")
                    {
                        MessageBox.Show("enter user ID to delete");
                    }
                    else
                    {
                        con.Open();
                        string res = "delete from users where id = '" + textBoxUserIdToDelete.Text + "'";
                        SqlCommand sql = new SqlCommand(res, con);
                        sql.ExecuteNonQuery();
                        con.Close();

                        int.TryParse(textBoxUserIdToDelete.Text, out int id);

                        // Execute the delete operation
                        this.usersTableAdapter1.DeleteUser(id);

                        // Update the DataSet to reflect the changes
                        this.usersTableAdapter1.Fill(this.eventsDBDataSet1.users);

                        MessageBox.Show("User deleted successfully.");
                    }
                                                           
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
