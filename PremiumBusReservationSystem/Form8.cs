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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;

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








        //Find and Replace Method
        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Creeate the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                /*this.FindAndReplace(wordApp, "<name>", textBox1.Text);
                this.FindAndReplace(wordApp, "<firstname>", textBox2.Text);
                this.FindAndReplace(wordApp, "<birthday>", dateTimePicker1.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());*/
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
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
