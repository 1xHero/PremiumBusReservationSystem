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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public static string selected_ID=null;
        public static string mdate = null;
        public static string tripid = null;
       


        private void ClearData()
        {

            /*  textBox3.Text = "";
              id.Text = "";
              stime.Text = "";
              jtime.Text = "";
              sdeparture.Text = "";
              freeseats = 0;
              price.Text = "";
              sarrive.Text = "";*/
            selected_ID = null;
            mdate = null;
            tripid = null;
        }
        private MySqlConnection con()
        {
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = general.getsql();
            return con;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            mdate = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tripid = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con().Open();
            string query = "SELECT `id`,`From_To`,`price`,`journey_date`,`schedule_departure`,`schedule_arrival`,`sales_time`,`trip_id` FROM `ticket` WHERE username='" + general.getusername() + "' ";

            DataTable myTable = new DataTable();

            MySqlCommand sda = new MySqlCommand(query, con());
            MySqlDataAdapter returnVal = new MySqlDataAdapter(query, con());

            returnVal.Fill(myTable);

            dataGridView1.DataSource = myTable;

            con().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (selected_ID == null && tripid==null)
            {
                

                    MessageBox.Show("Error: please select Ticket");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure to revok ticket id:"+selected_ID, "Revok Ticket", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {

                    try
                    {

                        string MyConnection2 = general.getsql();
                        string Query = "delete from ticket where username = '" + general.getusername() + "' and id = '" + selected_ID + "' ";

                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                       // MessageBox.Show("Ticket Revoked Successfully");
                        while (MyReader2.Read())
                        {
                        }
                        MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {

                        string MyConnection2 = general.getsql();
                        string Query = "UPDATE trip SET freeseats = freeseats + 1 WHERE id = '" + tripid +"'";

                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Ticket Revoked Successfully");
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
                else if (dialogResult == DialogResult.No)

                {

                    ClearData();

                }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
