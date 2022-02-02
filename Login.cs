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

namespace Project1
{
    public partial class Login : Form
    {
        private SqlConnection cn;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CP214_Final_Project_RNGeon\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void lgn_btn_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)  
            {
                SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                SqlDataReader SqlDataReader = cmd.ExecuteReader();
                if (SqlDataReader.Read())  
                {

                    SqlDataReader.Close();  
                    this.Hide();
                    Home home = new Home(txtusername.Text);
                    home.ShowDialog();
                }  
                else  
                {  
                    SqlDataReader.Close();  
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }  
  
            }  
            else  
            {  
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }  
        }

        private void tolgn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
