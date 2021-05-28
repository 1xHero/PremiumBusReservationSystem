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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private MySqlConnection con()
        {
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = general.getsql() ;
            return con;
        }
        private void ClearData()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            textBox4.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBox5.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            textBox6.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            textBox7.Text = (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con().Open();
            string query = "SELECT * FROM  user_account";

            DataTable myTable = new DataTable();

            MySqlCommand sda = new MySqlCommand(query, con());
            MySqlDataAdapter returnVal = new MySqlDataAdapter(query, con());

            returnVal.Fill(myTable);

            dataGridView1.DataSource = myTable;

            con().Close();
            // ClearData();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null) { 
            try
            {

                string MyConnection2 = general.getsql();
                string Query = "delete from user_account where id=" + textBox1.Text + "";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                    
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearData();
            button1.PerformClick();
            }
            else
            {
                MessageBox.Show("Error : Please Select user");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!=null && textBox2.Text!=""&& textBox3.Text != null && textBox3.Text != ""&& textBox4.Text != null && textBox4.Text != "")
            {
                try
                {

                    string MyConnection2 = general.getsql();
                    string Query = "update user_account set username ='" + textBox2.Text + "', password ='" + textBox3.Text + "', first_name ='" + textBox4.Text + "', last_name ='" + textBox5.Text + "', role ='" + textBox7.Text + "' where id =" + textBox1.Text + ";";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ClearData();
                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("Error : Please fill input box's first");
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            
            try
            {

                string MyConnection2 = general.getsql();

                string Query = "INSERT INTO user_account (username, password, first_name,last_name,role) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+ textBox7.Text +"');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                con().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearData();
            button1.PerformClick();
        }
    }
}
