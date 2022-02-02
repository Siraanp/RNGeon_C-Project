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
    public partial class Gacha : Form
    {
        public int Gdiamond;
        public string PlayerName;
        private SqlConnection cn;

        private int CPHealth;
        private int CPAttack;
        private int GachaHealthPlus;
        private int GachaAttackPlus;

        Random random = new Random();
        public Gacha(string PN,int Diamond,int PH,int PA)
        {
            InitializeComponent();
            Gdiamond = Diamond;
            Player_Diamond.Text = Gdiamond.ToString();
            PlayerName = PN;
            CPHealth = PH;
            CPAttack = PA;
        }
        private void Gacha_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CP214_Final_Project_RNGeon\Database.mdf;Integrated Security=True");
            cn.Open();
            CurrentHealth.Text = CPHealth.ToString();
            CurrentAttack.Text = CPAttack.ToString();
        }

        private void tenRoll_Click(object sender, EventArgs e)
        {
            if (Gdiamond < 30)
            {
                MessageBox.Show("You don't have enough Diamond");
            }
            else
            {
                GachaHealthPlus *= 0;
                GachaAttackPlus *= 0;
                label1.Visible = false;
                pictureBox1.Visible = false;
                label2.Visible = false;
                Player_Diamond.Visible = false;
                oneRoll.Visible = false;
                tenRoll.Visible = false;
                bckBtn.Visible = false;
                Gresult1.Visible = true;
                Gresult2.Visible = true;
                Gresult3.Visible = true;
                Gresult4.Visible = true;
                Gresult5.Visible = true;
                Gresult6.Visible = true;
                Gresult7.Visible = true;
                Gresult8.Visible = true;
                Gresult9.Visible = true;
                Gresult10.Visible = true;
                BtoG10.Visible = true;
                for (int i = 1; i <= 10; i++)
                {
                    
                    SqlCommand OneR = new SqlCommand("select Path,Stat_Health,Stat_Attack from CultureTable where Id='" + random.Next(1,41) + "'", cn);
                    SqlDataReader salt = OneR.ExecuteReader();
                    if (salt.Read())
                    {
                        
                        if (i == 1)
                        {
                            Gresult1.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 2)
                        {
                            Gresult2.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 3)
                        {
                            Gresult3.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 4)
                        {
                            Gresult4.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 5)
                        {
                            Gresult5.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 6)
                        {
                            Gresult6.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 7)
                        {
                            Gresult7.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 8)
                        {
                            Gresult8.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 9)
                        {
                            Gresult9.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        else if (i == 10)
                        {
                            Gresult10.Image = Image.FromFile(@salt.GetValue(0).ToString());
                        }
                        
                        GachaHealthPlus += int.Parse(salt.GetValue(1).ToString());
                        GachaAttackPlus += int.Parse(salt.GetValue(2).ToString());
                        salt.Close();
                    }
                    salt.Close();
                }
                CPHealth += GachaHealthPlus;
                CPAttack += GachaAttackPlus;
                CurrentHealth.Text = CPHealth.ToString();
                CurrentAttack.Text = CPAttack.ToString();
                SqlCommand statUpdate = new SqlCommand("UPDATE LoginTable SET Player_Health = " + CPHealth + ", Player_Attack =" + CPAttack + " where username='" + PlayerName + "'", cn);
                SqlDataReader statUp = statUpdate.ExecuteReader();
                statUp.Close();
            }
        }

        private void oneRoll_Click(object sender, EventArgs e)
        {
            if (Gdiamond < 3)
            {
                MessageBox.Show("You don't have enough Diamond");
            }
            else
            {
                GachaHealthPlus *= 0;
                GachaAttackPlus *= 0;
                label1.Visible = false;
                pictureBox1.Visible = false;
                label2.Visible = false;
                Player_Diamond.Visible = false;
                bckBtn.Visible = false;

                oneRoll.Visible = false;
                tenRoll.Visible = false;
                Gresult1.Visible = true;
                BtoG1.Visible = true;
                SqlCommand OneR = new SqlCommand("select Path,Stat_Health,Stat_Attack from CultureTable where Id='" + random.Next(1, 41) + "'", cn);
                SqlDataReader salt = OneR.ExecuteReader();
                if (salt.Read())
                {
                    Gresult1.Image = Image.FromFile(@salt.GetValue(0).ToString());
                    GachaHealthPlus += int.Parse(salt.GetValue(1).ToString());
                    GachaAttackPlus += int.Parse(salt.GetValue(2).ToString());
                    salt.Close();
                }
                salt.Close();

                CPHealth += GachaHealthPlus;
                CPAttack += GachaAttackPlus;
                CurrentHealth.Text = CPHealth.ToString();
                CurrentAttack.Text = CPAttack.ToString();
                SqlCommand statUpdate = new SqlCommand("UPDATE LoginTable SET Player_Health = " + CPHealth + ", Player_Attack =" + CPAttack + " where username='" + PlayerName + "'", cn);
                SqlDataReader statUp = statUpdate.ExecuteReader();
                statUp.Close();

            }
             
         
        }



        private void Player_Diamond_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(PlayerName);
            home.ShowDialog();
        }

        private void BtoG_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            pictureBox1.Visible = true;
            label2.Visible = true;
            Player_Diamond.Visible = true;
            oneRoll.Visible = true;
            tenRoll.Visible = true;
            bckBtn.Visible = true;
            Gresult1.Visible = false;
            BtoG1.Visible = false;

            Gdiamond = Gdiamond - 3;
            Player_Diamond.Text = Gdiamond.ToString();
            SqlCommand show_diamond = new SqlCommand("UPDATE LoginTable SET Diamond = " + Gdiamond + " where username='" + PlayerName + "'", cn);
            SqlDataReader salt = show_diamond.ExecuteReader();
            salt.Close();

        }

        private void BoG10_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            bckBtn.Visible = true;
            pictureBox1.Visible = true;
            label2.Visible = true;
            Player_Diamond.Visible = true;
            oneRoll.Visible = true;
            tenRoll.Visible = true;
            Gresult1.Visible = false;
            Gresult2.Visible = false;
            Gresult3.Visible = false;
            Gresult4.Visible = false;
            Gresult5.Visible = false;
            Gresult6.Visible = false;
            Gresult7.Visible = false;
            Gresult8.Visible = false;
            Gresult9.Visible = false;
            Gresult10.Visible = false;
            BtoG10.Visible = false;


            Gdiamond = Gdiamond - 30;
            Player_Diamond.Text = Gdiamond.ToString();
            SqlCommand show_diamond = new SqlCommand("UPDATE LoginTable SET Diamond = " + Gdiamond + " where username='" + PlayerName + "'", cn);
            SqlDataReader salt = show_diamond.ExecuteReader();
            salt.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
