using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Demo
{
    public partial class Player_Login : Form
    {
        DataTable temp = new DataTable();
        OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\LAMK\Homework_2\Green ICT application\Democode\Demo_Login_Register_Upload_Save_MainFuntion\DemoDB.mdb");
        OleDbDataAdapter dapt;
        public Player_Login()
        {
            InitializeComponent();
        }

        private void Player_Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            //Register
            string user = textUsername.Text;
            string pass = textPass.Text;
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandType = CommandType.Text;
            try
            {
                myCommand.CommandText = "INSERT into User_database(Name, [Password] )" + " VALUES (@user, @pass)";
                myCommand.Parameters.AddWithValue(user, textUsername.Text);
                myCommand.Parameters.AddWithValue(pass, textPass.Text);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Register successful, continue with Login");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in system Register");
            }
            myConnection.Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (myConnection.State.Equals(ConnectionState.Closed))
                myConnection.Open();
            dapt = new OleDbDataAdapter("Select Count(*) From User_database where Name ='" + textUsername.Text + "' and Password ='" + textPass.Text + "'", myConnection.ConnectionString);
            dapt.Fill(temp);
            try
            {
                if (temp.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main_function_1player linkto = new Main_function_1player();
                    linkto.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    temp.Clear();
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error in system Login");
            }
        }
    }
}
