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
    public partial class Home : Form
    {
        private SqlConnection cn;
        public String PID;
        public int PHel;
        public int PAtt;
        private int PDiamond;
        private void Home_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CP214_Final_Project_RNGeon\Database.mdf;Integrated Security=True");
            cn.Open();

            SqlCommand show_diamond = new SqlCommand("select Id,Diamond,Player_Health,Player_Attack from LoginTable where username='" + textBox1.Text + "'", cn);
            SqlDataReader read = show_diamond.ExecuteReader();
            if (read.Read())
            {
                PID = read.GetValue(0).ToString();
                Diamond_Show.Text = read.GetValue(1).ToString();
                PHealth_display.Text = read.GetValue(2).ToString();
                PAttack_display.Text = read.GetValue(3).ToString();
                read.Close();
            }
            PDiamond = int.Parse(Diamond_Show.Text);
            PHel = int.Parse(PHealth_display.Text);
            PAtt = int.Parse(PAttack_display.Text);
        }
        public Home(string pname)
        {
            InitializeComponent();
            textBox1.Text = pname;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Gallery1 g1 = new Gallery1(textBox1.Text);
            g1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Player_Name_TextChanged(object sender, EventArgs e)
        {

        }


        private void Player_Name_Click(object sender, EventArgs e)
        {

        }



        private void Diamond_Show_TextChanged(object sender, EventArgs e)
        {
        }

        private void diamond_Click(object sender, EventArgs e)
        {

        }

        private void PHealth_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mission_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dungeon home = new Dungeon(textBox1.Text,PHealth_display.Text,PAttack_display.Text,PDiamond);
            home.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gacha_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gacha home = new Gacha(textBox1.Text, PDiamond,PHel,PAtt);
            home.ShowDialog();
        }

        private void PAttack_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login back2l = new Login();
            back2l.ShowDialog();
            
        }
    }
}
