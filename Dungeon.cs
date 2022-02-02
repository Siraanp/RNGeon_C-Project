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
    public partial class Dungeon : Form
    {
        private int PlayerHealth;
        private int PlayerAttack;
        private int PlayerDiamond;

        private int BossMaxHealth;
        private int BossHealth;
        private int BossAttack;

        public int Diamond_reward;
        public int Diamond_get;

        Random rng = new Random();
        private SqlConnection cn;

        public Dungeon(String Player_Name,String Player_Health,String Player_Attack,int Diamond)
        {
            InitializeComponent();
            PlayerN.Text = Player_Name;
            PlayerH.Text = Player_Health;
            PlayerA.Text = Player_Attack;
            PlayerDiamond = Diamond;
            PlayerHealth = int.Parse(Player_Health);
            PlayerAttack = int.Parse(Player_Attack);
            BossMaxHealth = 50;
            BossAttack = 10;
            Diamond_reward = 1;
            Diamond_get = 0;
        }

        private void Dungeon_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CP214_Final_Project_RNGeon\Database.mdf;Integrated Security=True");
            cn.Open();
            Fightlog_box.Focus();
            Fightlog_box.AppendText(Environment.NewLine + "Welcome to Dungeon");
            Fightlog_box.AppendText(Environment.NewLine + "Fight of Flee?");
        }
        private void Fight_btn_Click(object sender, EventArgs e)
        {
            Fightlog_box.AppendText(Environment.NewLine + "Fight Start!!");
            Fight_btn.Visible = false;
            BackToVillage.Visible = false;
            Slash_btn.Visible = true;
            Pierce_btn.Visible = true;
            Crush_btn.Visible = true;

            BossHealth = BossMaxHealth;
            Enermy_Health.Text = BossHealth.ToString();
            Enermy_Attack.Text = BossAttack.ToString();
    }

        private void Slash_btn_Click(object sender, EventArgs e)
        {
            Fightlog_box.Focus();
            Fightlog_box.AppendText(Environment.NewLine + "You Use Slash");

            int BossAtkType = rng.Next(3);
            if(BossAtkType == 0)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Slash");
                Fightlog_box.AppendText(Environment.NewLine + "Head-To-Head!!");
                BossHealth = BossHealth - PlayerAttack;
                Enermy_Health.Text = BossHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You hit for " + PlayerAttack + " Damage");
                
                PlayerHealth = PlayerHealth - BossAttack;
                PlayerH.Text = PlayerHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You get hit for " + BossAttack + " Damage");
                if (PlayerHealth <= 0 && BossHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
                else if (PlayerHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
                else if (BossHealth <= 0)
                {
                    Fightlog_box.AppendText(Environment.NewLine + "You Win!!!");
                    Fightlog_box.AppendText(Environment.NewLine + "Keep Fight or Return to Village");
                    Fight_btn.Visible = true;
                    BackToVillage.Visible = true;
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BossMaxHealth += 10;
                    BossAttack += 5;
                    Fightlog_box.AppendText(Environment.NewLine + "You get" + Diamond_reward + "Diamonds");
                    Diamond_get += Diamond_reward;
                    Diamond_reward += 1;
                    Fightlog_box.Focus();
                }

            }
            else if (BossAtkType == 1)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Pierce");
                PlayerHealth = PlayerHealth - BossAttack;
                PlayerH.Text = PlayerHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You get hit for " + BossAttack + " Damage");
                if (PlayerHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
            }
            else if (BossAtkType == 2)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Crush");
                BossHealth = BossHealth - PlayerAttack;
                Enermy_Health.Text = BossHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You hit for " + PlayerAttack + " Damage");
                if (BossHealth <= 0)
                {
                    Fightlog_box.AppendText(Environment.NewLine + "You Win!!!");
                    Fightlog_box.AppendText(Environment.NewLine + "Keep Fight or Return to Village");
                    Fightlog_box.Focus();
                    Fight_btn.Visible = true;
                    BackToVillage.Visible = true;
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BossMaxHealth += 10;
                    BossAttack += 5;
                    Fightlog_box.AppendText(Environment.NewLine + "You get" + Diamond_reward + "Diamonds");
                    Diamond_get += Diamond_reward;
                    Diamond_reward += 1;
                    Fightlog_box.Focus();
                }
            }

        }

        private void Pierce_btn_Click(object sender, EventArgs e)
        {
            Fightlog_box.Focus();
            Fightlog_box.AppendText(Environment.NewLine + "You Use Slash");

            int BossAtkType = rng.Next(3);
            if (BossAtkType == 0)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Slash");
                BossHealth = BossHealth - PlayerAttack;
                Enermy_Health.Text = BossHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You hit for " + PlayerAttack + " Damage");
                if (BossHealth <= 0)
                {
                    Fightlog_box.AppendText(Environment.NewLine + "You Win!!!");
                    Fightlog_box.AppendText(Environment.NewLine + "Keep Fight or Return to Village");
                    Fightlog_box.Focus();
                    Fight_btn.Visible = true;
                    BackToVillage.Visible = true;
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BossMaxHealth += 10;
                    BossAttack += 5;
                    Fightlog_box.AppendText(Environment.NewLine + "You get" + Diamond_reward + "Diamonds");
                    Diamond_get += Diamond_reward;
                    Diamond_reward += 1;
                    Fightlog_box.Focus();
                }

            }
            else if (BossAtkType == 1)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Pierce");
                Fightlog_box.AppendText(Environment.NewLine + "Head-To-Head!!");
                BossHealth = BossHealth - PlayerAttack;
                Enermy_Health.Text = BossHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You hit for " + PlayerAttack + " Damage");

                PlayerHealth = PlayerHealth - BossAttack;
                PlayerH.Text = PlayerHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You get hit for " + BossAttack + " Damage");
                if (PlayerHealth <= 0 && BossHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
                else if (PlayerHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
                else if (BossHealth <= 0)
                {
                    Fightlog_box.AppendText(Environment.NewLine + "You Win!!!");
                    Fightlog_box.AppendText(Environment.NewLine + "Keep Fight or Return to Village");
                    Fight_btn.Visible = true;
                    BackToVillage.Visible = true;
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BossMaxHealth += 10;
                    BossAttack += 5;
                    Fightlog_box.AppendText(Environment.NewLine + "You get" + Diamond_reward + "Diamonds");
                    Diamond_get += Diamond_reward;
                    Diamond_reward += 1;
                    Fightlog_box.Focus();
                }


            }
            else if (BossAtkType == 2)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Crush");
                PlayerHealth = PlayerHealth - BossAttack;
                PlayerH.Text = PlayerHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You get hit for " + BossAttack + " Damage");
                if (PlayerHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
            }

        }
        private void Crush_btn_Click(object sender, EventArgs e)
        {
            Fightlog_box.Focus();
            Fightlog_box.AppendText(Environment.NewLine + "You Use Slash");

            int BossAtkType = rng.Next(3);
            if (BossAtkType == 0)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Slash");
                PlayerHealth = PlayerHealth - BossAttack;
                PlayerH.Text = PlayerHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You get hit for " + BossAttack + " Damage");
                if (PlayerHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }

            }
            else if (BossAtkType == 1)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Pierce");
                BossHealth = BossHealth - PlayerAttack;
                Enermy_Health.Text = BossHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You hit for " + PlayerAttack + " Damage");
                if (BossHealth <= 0)
                {
                    Fightlog_box.AppendText(Environment.NewLine + "You Win!!!");
                    Fightlog_box.AppendText(Environment.NewLine + "Keep Fight or Return to Village");
                    Fightlog_box.Focus();
                    Fight_btn.Visible = true;
                    BackToVillage.Visible = true;
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BossMaxHealth += 10;
                    BossAttack += 5;
                    Fightlog_box.AppendText(Environment.NewLine + "You get" + Diamond_reward + "Diamonds");
                    Diamond_get += Diamond_reward;
                    Diamond_reward += 1;
                    Fightlog_box.Focus();
                }
            }
            else if (BossAtkType == 2)
            {
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "Enermy use Crush");
                Fightlog_box.AppendText(Environment.NewLine + "Head-To-Head!!");
                BossHealth = BossHealth - PlayerAttack;
                Enermy_Health.Text = BossHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You hit for " + PlayerAttack + " Damage");
                
                PlayerHealth = PlayerHealth - BossAttack;
                PlayerH.Text = PlayerHealth.ToString();
                Fightlog_box.Focus();
                Fightlog_box.AppendText(Environment.NewLine + "You get hit for " + BossAttack + " Damage");
                if (PlayerHealth <= 0 && BossHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
                else if (PlayerHealth <= 0)
                {
                    Fightlog_box.Focus();
                    Fightlog_box.AppendText(Environment.NewLine + "You Lose...");
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BackToVillage.Visible = true;
                }
                else if (BossHealth <= 0)
                {
                    Fightlog_box.AppendText(Environment.NewLine + "You Win!!!");
                    Fightlog_box.AppendText(Environment.NewLine + "Keep Fight or Return to Village");
                    Fight_btn.Visible = true;
                    BackToVillage.Visible = true;
                    Slash_btn.Visible = false;
                    Pierce_btn.Visible = false;
                    Crush_btn.Visible = false;
                    BossMaxHealth += 10;
                    BossAttack += 5;
                    Fightlog_box.AppendText(Environment.NewLine + "You get" + Diamond_reward + "Diamonds");
                    Diamond_get += Diamond_reward;
                    Diamond_reward += 1;
                    Fightlog_box.Focus();
                }
            }
        }
        private void BackToVillage_Click(object sender, EventArgs e)
        {
            PlayerDiamond += Diamond_get;
            SqlCommand show_diamond = new SqlCommand("UPDATE LoginTable SET Diamond = "+ PlayerDiamond + " where username='" + PlayerN.Text + "'", cn);
            SqlDataReader diamondUPDATE = show_diamond.ExecuteReader();
            diamondUPDATE.Close();
            this.Hide();
            Home home = new Home(PlayerN.Text);
            home.ShowDialog();
        }
        void PlayerDOAttack()
        {

        }
    }
}