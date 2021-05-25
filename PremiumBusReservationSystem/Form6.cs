using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace PremiumBusReservationSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")

            {

                MessageBox.Show("please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Focus();

                return;

            }

            if (textBox2.Text == "")

            {

                MessageBox.Show("please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Focus();

                return;

            }
            if (textBox3.Text == "")

            {

                MessageBox.Show("please enter firstname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox4.Focus();

                return;

            }
            if (textBox4.Text == "")

            {

                MessageBox.Show("please enter lastname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Focus();

                return;

            }

            try
            {

                string MyConnection2 = "server=127.0.0.1;user id=root;database=premiumbus;Password=toor1234;";

                string Query = "INSERT INTO user_account (username, password, first_name,last_name,role) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','user');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                MessageBox.Show("Signup Successful!");

                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
