using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumBusReservationSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label2.Text = general.getusername();
            label4.Text = general.firstname;
            label6.Text = general.lastname;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Form1 fm = new Form1();
            
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 fm = new Form8();

            fm.Show();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
