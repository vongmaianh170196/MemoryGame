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
    public partial class Main_function_2players : Form
    {
        //Variables
        bool Player1 = true;
        bool Player2 = true;
        Random location = new Random();
        List<int> X = new List<int>(); //value x of picturebox
        List<int> Y = new List<int>();
        List<Point> points = new List<Point>();
        PictureBox PendingImage1;//storing 1st flipping image value
        PictureBox PendingImage2; //...for 2nd
        string imgPath = @"C:\Program Files\GreenICT\Matching_Game\Images\";
        public Main_function_2players()
        {
            InitializeComponent();
        }

        private void Main_function_2players_Load(object sender, EventArgs e)
        {
            //start game
            foreach (PictureBox picture in Game_panel.Controls)
            {
                timelb.Text = "3";
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            //random images
            Randomize();
            timer2.Start();
            timer1.Start();
            //load images 
            LoadImages();
            CheckPlayerturn();
        }
        private void CheckPlayerturn()
        {
            if (Player1 == false)
            {
                Player2 = true;
            }
            if (Player2 == false)
            {
                Player1 = true;
            }
        }
        private void Score()
        {
            if (Player1 == true)
            {
                score_1.Text = Convert.ToString(Convert.ToUInt32(score_1.Text) + 10);
                if (Convert.ToUInt32(score_1.Text) > 60)
                {
                    MessageBox.Show("Congratulations Player 1!!!");
                }
            }
            if (Player2 == true)
            {
                score_2.Text = Convert.ToString(Convert.ToUInt32(score_2.Text) + 10);
                if (Convert.ToUInt32(score_2.Text) > 60)
                {
                    MessageBox.Show("Congratulations Player 2!!!");
                }
            }
        }
        private void Randomize()
        {
            foreach (PictureBox pic in Game_panel.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                pic.Location = p;
                points.Remove(p);
            }
        }
        private void LoadImages()
        {
            card1.Image = Image.FromFile(imgPath + "pic (10).JPG");
            dubcard1.Image = Image.FromFile(imgPath + "pic (10).JPG");
            card2.Image = Image.FromFile(imgPath + "pic (11).JPG");
            dubcard2.Image = Image.FromFile(imgPath + "pic (11).JPG");
            card3.Image = Image.FromFile(imgPath + "pic (13).JPG");
            dubcard3.Image = Image.FromFile(imgPath + "pic (13).JPG");
            card4.Image = Image.FromFile(imgPath + "pic (15).JPG");
            dubcard4.Image = Image.FromFile(imgPath + "pic (15).JPG");
            card5.Image = Image.FromFile(imgPath + "pic (16).JPG");
            dubcard5.Image = Image.FromFile(imgPath + "pic (16).JPG");
            card6.Image = Image.FromFile(imgPath + "pic (18).JPG");
            dubcard6.Image = Image.FromFile(imgPath + "pic (18).JPG");
            card7.Image = Image.FromFile(imgPath + "pic (21).JPG");
            dubcard7.Image = Image.FromFile(imgPath + "pic (21).JPG");
            card8.Image = Image.FromFile(imgPath + "pic (3).JPG");
            dubcard8.Image = Image.FromFile(imgPath + "pic (3).JPG");
            card9.Image = Image.FromFile(imgPath + "pic (4).JPG");
            dubcard9.Image = Image.FromFile(imgPath + "pic (4).JPG");
            card10.Image = Image.FromFile(imgPath + "pic (5).JPG");
            dubcard10.Image = Image.FromFile(imgPath + "pic (5).JPG");
            dubcard11.Image = Image.FromFile(imgPath + "pic (6).JPG");
            card12.Image = Image.FromFile(imgPath + "pic (8).JPG");
            dubcard12.Image = Image.FromFile(imgPath + "pic (8).JPG");
        }
        private void FlipCards(PictureBox tempcard, PictureBox dubtempcard)
        {
            if (PendingImage1 == null)
            {
                PendingImage1 = tempcard;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = tempcard;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    tempcard.Enabled = false;
                    dubtempcard.Enabled = false;
                    Score();
                }
                else
                {
                    timer3.Start();
                    if (Player1 == true)
                    {
                        Player1 = false;
                        Player2 = true;
                    }
                    else
                    {
                        Player2 = false;
                        Player1 = true;
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in Game_panel.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(timelb.Text);
            timer = timer - 1;
            timelb.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.cover;
            PendingImage2.Image = Properties.Resources.cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void play_again_Click(object sender, EventArgs e)
        {
            Main_function_2players_Load(sender, e);
        }

        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Image.FromFile(imgPath + "pic (10).JPG");
            FlipCards(card1, dubcard1);
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Image.FromFile(imgPath + "pic (11).JPG");
            FlipCards(card2, dubcard2);
        }
        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Image.FromFile(imgPath + "pic (13).JPG");
            FlipCards(card3, dubcard3);
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Image.FromFile(imgPath + "pic (15).JPG");
            FlipCards(card4, dubcard4);
        }
        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Image.FromFile(imgPath + "pic (16).JPG"); ;
            FlipCards(card5, dubcard5);
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Image.FromFile(imgPath + "pic (18).JPG");
            FlipCards(card6, dubcard6);
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Image.FromFile(imgPath + "pic (21).JPG");
            FlipCards(card7, dubcard7);
        }
        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Image.FromFile(imgPath + "pic (3).JPG"); ;
            FlipCards(card8, dubcard8);
        }

        private void card9_Click(object sender, EventArgs e)
        {
            card9.Image = Image.FromFile(imgPath + "pic (4).JPG");
            FlipCards(card9, dubcard9);
        }

        private void card10_Click(object sender, EventArgs e)
        {
            card10.Image = Image.FromFile(imgPath + "pic (5).JPG");
            FlipCards(card10, dubcard10);
        }

        private void card11_Click(object sender, EventArgs e)
        {
            card11.Image = Image.FromFile(imgPath + "pic (6).JPG");
            FlipCards(card11, dubcard11);
        }
        private void card12_Click(object sender, EventArgs e)
        {
            card12.Image = Image.FromFile(imgPath + "pic (8).JPG"); ;
            FlipCards(card12, dubcard12);
        }
        private void dubcard1_Click(object sender, EventArgs e)
        {
            dubcard1.Image = Image.FromFile(imgPath + "pic (10).JPG");
            FlipCards(dubcard1, card1);
        }

        private void dubcard2_Click(object sender, EventArgs e)
        {
            dubcard2.Image = Image.FromFile(imgPath + "pic (11).JPG");
            FlipCards(dubcard2, card2);
        }

        private void dubcard3_Click(object sender, EventArgs e)
        {
            dubcard3.Image = Image.FromFile(imgPath + "pic (13).JPG");
            FlipCards(dubcard3, card3);
        }

        private void dubcard4_Click(object sender, EventArgs e)
        {
            dubcard4.Image = Image.FromFile(imgPath + "pic (15).JPG"); ;
            FlipCards(dubcard4, card4);
        }

        private void dubcard5_Click(object sender, EventArgs e)
        {
            dubcard5.Image = Image.FromFile(imgPath + "pic (16).JPG");
            FlipCards(dubcard5, card5);
        }

        private void dubcard6_Click(object sender, EventArgs e)
        {
            dubcard6.Image = Image.FromFile(imgPath + "pic (18).JPG");
            FlipCards(dubcard6, card6);
        }

        private void dubcard7_Click(object sender, EventArgs e)
        {
            dubcard7.Image = Image.FromFile(imgPath + "pic (21).JPG");
            FlipCards(dubcard7, card7);
        }

        private void dubcard8_Click(object sender, EventArgs e)
        {
            dubcard8.Image = Image.FromFile(imgPath + "pic (3).JPG");
            FlipCards(dubcard8, card8);
        }

        private void dubcard9_Click(object sender, EventArgs e)
        {
            dubcard9.Image = Image.FromFile(imgPath + "pic (4).JPG");
            FlipCards(dubcard9, card9);
        }

        private void dubcard10_Click(object sender, EventArgs e)
        {
            dubcard10.Image = Image.FromFile(imgPath + "pic (5).JPG");
            FlipCards(dubcard10, card10);
        }

        private void dubcard11_Click(object sender, EventArgs e)
        {
            dubcard11.Image = Image.FromFile(imgPath + "pic (6).JPG");
            FlipCards(dubcard11, card11);
        }

        private void dubcard12_Click(object sender, EventArgs e)
        {
            dubcard12.Image = Image.FromFile(imgPath + "pic (8).JPG");
            FlipCards(dubcard12, card12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 link = new Form1();
            link.Show();
        }

        private void player_1_Click(object sender, EventArgs e)
        {

        }
    }
}
