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
    public partial class Registration : Form
    {
        private SqlConnection cn;

        public Registration()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CP214_Final_Project_RNGeon\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tolgn_btn_Click(object sender, EventArgs e)
        {
           this.Hide();  
           Login login = new Login();  
           login.ShowDialog();  
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty || txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable(username,password) values(@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {
            txtconfirmpassword.PasswordChar = '*';
        }
    }
}
