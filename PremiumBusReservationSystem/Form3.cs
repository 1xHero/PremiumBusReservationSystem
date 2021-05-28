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


    public partial class Form3 : Form
    {
        

        public Form3()
        {
            InitializeComponent();
            //button4.PerformClick();

        }
        private MySqlConnection con()
        {
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = general.getsql();
            return con;
        }

        private void ClearData()
        {
            
            textBox3.Text = null;//id box
            nseat.Text = null;
            dtime.Text = null;
            atime.Text = null;
            from.Text = null;
            to.Text = null;
            tprice.Text = null;
            mdate.Text = null;
            


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


           
           textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
          // textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        //   textBox3.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());


            from.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); 
            to.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtime.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            atime.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nseat.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            tprice.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            mdate.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
           // atime=
        }
      
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premiumbusDataSet.location' table. You can move, or remove it, as needed.
            //this.locationTableAdapter.Fill(this.premiumbusDataSet.location);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtime != null && atime != null && tprice != null && nseat != null)
            {
                try
                {

                    string MyConnection2 = general.getsql();

                    string Query = "INSERT INTO trip (departure_time,arrival_time, numseats,freeseats, ticketprice,pfrom,pto,monthdate) VALUES('" + dtime.Text + "','" + atime.Text + "','" + nseat.Text + "','" + nseat.Text + "','" + tprice.Text + "','" + from.Text + "','" + to.Text + "','" + mdate.Text + "');";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Save Data");
                    button4.PerformClick();
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
            }
            else
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
 
                 con().Open();
                 string query = "SELECT * FROM  trip";

                 DataTable myTable = new DataTable();
                 
                 MySqlCommand sda = new MySqlCommand(query, con());
                 MySqlDataAdapter returnVal = new MySqlDataAdapter(query, con());

                 returnVal.Fill(myTable);
                 
                 dataGridView1.DataSource = myTable;

                 con().Close();
            ClearData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text!=null) {
            
            
            try
            {
                
                string MyConnection2 = general.getsql();
                string Query = "update trip set departure_time ='" + dtime.Text+ "', arrival_time ='" + atime.Text+ "', numseats ='" + nseat.Text + "',freeseats ='" + nseat.Text + "', ticketprice ='" + tprice.Text + "', pfrom ='" + from.Text + "' , pto ='" + to.Text + "', monthdate ='" + mdate.Text + "' where id =" + textBox3.Text+";";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                    button4.PerformClick();

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
            
            }
            else
            {
                MessageBox.Show("Error : Please select Trip");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {

                try
                {

                    string MyConnection2 = general.getsql();
                    string Query = "delete from trip where id=" + textBox3.Text + "";

                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    button4.PerformClick();
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
            }
            else
            {
                MessageBox.Show("Error: Please select first trip");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void mdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mdate1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
