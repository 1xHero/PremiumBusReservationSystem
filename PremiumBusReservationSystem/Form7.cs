﻿using System;
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
    public partial class Form7 : Form
    {
        
        public static int freeseats=0;

        public Form7()
        {
            InitializeComponent();

        }
        private void ClearData()
        {

            textBox3.Text = "";
            id.Text = "";
            stime.Text = "";
            jtime.Text = "";
            sdeparture.Text = "";
            freeseats =0;
            price.Text = "";
            sarrive.Text = "";



        }

        private MySqlConnection con()
        {
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = general.getsql();
            return con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(general.getusername());
            //MessageBox.Show("@!!"+freeseats);
            con().Open();
            string query = "SELECT * FROM  trip";

            DataTable myTable = new DataTable();

            MySqlCommand sda = new MySqlCommand(query, con());
            MySqlDataAdapter returnVal = new MySqlDataAdapter(query, con());

            returnVal.Fill(myTable);

            dataGridView1.DataSource = myTable;

            con().Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
       {
            if (freeseats <= 0)
            {
                MessageBox.Show("This trip is full,you cant buy ticket.");
                ClearData();
            }
            else
            {
                string Query = "INSERT INTO ticket (username, journey_date,schedule_departure, schedule_arrival,price,From_To,trip_id) VALUES('" + general.getusername() + "','" + jtime.Text + "','" + sdeparture.Text + "','" +sarrive.Text + "','" + price.Text + "','" + textBox3.Text + "','" + id.Text + "');";
               // string Query3 = "Select freeseats from trip where id="+ id.Text +" ";
                string Query2 = "update trip set freeseats=freeseats-1 where id ='" + id.Text + "';";
            try
            {

                string MyConnection2 = general.getsql();

             

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
               
                
                while (MyReader2.Read())
                {
                }
                con().Close();
                
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
                {

                    string MyConnection3 = general.getsql();
                    MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                    MyConn3.Open();
                    MySqlCommand MyCommand3 = new MySqlCommand(Query2, MyConn3);
                    MySqlDataReader MyReader3;
                    MyReader3 = MyCommand3.ExecuteReader();
                while (MyReader3.Read())
                {
                }
                con().Close();MessageBox.Show("Ticket Bought Scussefully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           jtime.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            sdeparture.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            sarrive.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox3.Text ="From " + dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()+" TO "+dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            freeseats = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}