using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.Data.SqlClient;

using MySql.Data.MySqlClient;

namespace PremiumBusReservationSystem
{
    public partial class Form1 : Form
    {

       
        //SqlConnection con = new SqlConnection("SERVER=127.0.0.1;DATABASE=premiumbus;UID=root;PASSWORD=toor1234;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = general.getsql();
            //con.Open();


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

            try

            {

                con.Open();

                string query = "select role,first_name,last_name from user_account where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                //SqlDataAdapter sda = new SqlDataAdapter("select * from user_account where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                MySqlCommand sda = new MySqlCommand(query, con);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(query, con);
                // DataSet dt = new DataSet();
                DataTable dt = new System.Data.DataTable();
                //sda.Fill(dt);
                returnVal.Fill(dt);
                con.Close();
                // int count = dt.Tables[0].Rows.Count;
                int count = dt.Rows.Count;
                if (count == 1)

                {

                    switch(dt.Rows[0]["role"] as string)
                    {
                        case "admin":
                            {
                               MessageBox.Show("Login Successful!"+dt.Rows[0]["first_name"]+dt.Rows[0]["last_name"]);
                                general.setusername(textBox1.Text);
                               // general.setuserinfo(, );
                               
                                    this.Hide();
                                   Form2 fm = new Form2();
                    
                                    fm.Show();

                                

                                // this.Hide();
                                break;
                            }
                        case "user":
                            {
                                MessageBox.Show("Login Successful!");
                                general.setusername(textBox1.Text);
                                this.Hide();
                                Form5 frm = new Form5();
                                frm.Show();

                                // this.Hide();
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Error!");
                                break;
                            }

                    }

               

                }

                else { MessageBox.Show("please check user username and password"); }

                con.Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();

            fm.Show();
        }
    }

    
}
