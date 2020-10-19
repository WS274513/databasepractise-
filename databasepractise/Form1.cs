using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace databasepractise
{
    public partial class Form1 : Form
    {

        //const string conString = "server=plesk.remote.ac;​user=WS274513_practise;​database=WS274513_practicals;​password=password;​CharSet=utf8;";​ //Database Connection
        const string conString = "server=plesk.remote.ac;user=WS274513_practise;database=WS274513_practicals;password=Password*;CharSet=utf8;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection(conString);

            try
            {

                cnn.Open();
                lblConnect.Text = "Working";
                lblConnect.ForeColor = Color.Aquamarine;
                cnn.Close();
            }
            catch (Exception ex)
            {

                lblConnect.Text = ex.ToString();//Changes something to string
                lblConnect.ForeColor = Color.Red;

            }

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            //Grabbing date from the database

            MySqlConnection cnn = new MySqlConnection(conString);

            string comString = "SELECT `Name` FROM `tbl_Test` WHERE `ID` = 1"; //SQL Statment to get the data

            MySqlCommand com = new MySqlCommand(comString, cnn);

            try
            {

                cnn.Open();
                lblName.Text = com.ExecuteScalar().ToString();//Turns it into a readable string.
         
                cnn.Close();

            }
            catch (Exception ex)
            {

                lblName.Text = "Error";

            }


        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection(conString);

            string comString = "UPDATE `tbl_Test` SET `Name`= \"" + txtUpdateName.Text + "\"  WHERE `ID` = 1"; //SQL Statment to update name

            MySqlCommand com = new MySqlCommand(comString, cnn);

            try //Try catch statement 
            {

                cnn.Open();
                com.ExecuteNonQuery(); //When it returns nothing
                cnn.Close();

            }
            catch (Exception ex)
            {

                lblName.Text = "Error";

            }



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            MySqlConnection cnn = new MySqlConnection(conString);

            string comString = "INSERT INTO `tbl_Test`(`Name`) VALUES (\"" + txtInsert.Text + "\")"; //SQL Statment to update name

            MySqlCommand com = new MySqlCommand(comString, cnn);

            try //Try catch statement 
            {

                cnn.Open();
                com.ExecuteNonQuery(); //When it returns nothing
                cnn.Close();

            }
            catch (Exception ex)
            {

                lblName.Text = "Error";

            }



        }
    }
}
