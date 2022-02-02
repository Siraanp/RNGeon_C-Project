using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Gallery1 : Form
    {
        private string PlNameL;

        public Gallery1(string Plname)
        {
            PlNameL = Plname;
            InitializeComponent();
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.CultureTable' table. You can move, or remove it, as needed.
            this.cultureTableTableAdapter.Fill(this.databaseDataSet.CultureTable);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home(PlNameL);
            home.ShowDialog();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hideall();
            Show1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hideall();
            Show2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hideall();
            Show3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hideall();
            Show4();
        }
        void Show1()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
        }
        void Show2()
        {
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;

            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            textBox20.Visible = true;
        }
        void Show3()
        {
            pictureBox21.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
            pictureBox24.Visible = true;
            pictureBox25.Visible = true;
            pictureBox26.Visible = true;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            pictureBox29.Visible = true;
            pictureBox30.Visible = true;

            textBox21.Visible = true;
            textBox22.Visible = true;
            textBox23.Visible = true;
            textBox24.Visible = true;
            textBox25.Visible = true;
            textBox26.Visible = true;
            textBox27.Visible = true;
            textBox28.Visible = true;
            textBox29.Visible = true;
            textBox30.Visible = true;
        }
        void Show4()
        {
            pictureBox31.Visible = true;
            pictureBox32.Visible = true;
            pictureBox33.Visible = true;
            pictureBox34.Visible = true;
            pictureBox35.Visible = true;
            pictureBox36.Visible = true;
            pictureBox37.Visible = true;
            pictureBox38.Visible = true;
            pictureBox39.Visible = true;
            pictureBox40.Visible = true;

            textBox31.Visible = true;
            textBox32.Visible = true;
            textBox33.Visible = true;
            textBox34.Visible = true;
            textBox35.Visible = true;
            textBox36.Visible = true;
            textBox37.Visible = true;
            textBox38.Visible = true;
            textBox39.Visible = true;
            textBox40.Visible = true;
        }
        void Hideall()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;

            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;

            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;

            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;


            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;

            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;

            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;

            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;

        }

    }
}
