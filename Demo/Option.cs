using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Object_Option : Form
    {
        public Object_Option()
        {
            InitializeComponent();
        }
        private void PLAY_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox8.Checked && single.Checked && Private.Checked)
                {
                    if (checkBox1.Checked || checkBox9.Checked)
                    {
                        MessageBox.Show("This function has not been modified yet. Please choose another option");
                        return;
                    }
                    this.Hide();
                    Player_Login linkto = new Player_Login();
                    linkto.Show();
                }
                else if (checkBox8.Checked && single.Checked && Public.Checked)
                {
                    if (checkBox1.Checked || checkBox9.Checked)
                    {
                        MessageBox.Show("This function has not been modified yet. Please choose another option");
                        return;
                    }
                    this.Hide();
                    Main_function_1player linkto = new Main_function_1player();
                    linkto.Show();
                }
                else if (checkBox8.Checked && two.Checked && Public.Checked)
                {
                    if (checkBox1.Checked || checkBox9.Checked)
                    {
                        MessageBox.Show("This function has not been modified yet. Please choose another option");
                        return;
                    }
                    this.Hide();
                    Main_function_2players linkto = new Main_function_2players();
                    linkto.Show();
                }
                else
                {
                    MessageBox.Show("Please make sure that you have choose correct number of players and cards");
                }
                
               
            }
            catch (Exception)
            {
                MessageBox.Show("System error!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload linkto = new Upload();
            linkto.Show();
        }

        private void Object_Option_Load(object sender, EventArgs e)
        {

        }
    }
    }

