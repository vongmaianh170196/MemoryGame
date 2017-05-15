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
    public partial class Main_function_1player : Form
    {
        Random location = new Random();
        List<int> X = new List<int>(); //value x of picturebox
        List<int> Y = new List<int>();
        List<Point> points = new List<Point>();
        PictureBox PendingImage1;//storing 1st flipping image value
        PictureBox PendingImage2; //...for 2nd
        string imgPath = @"C:\Program Files\GreenICT\Matching_Game\Images\";
        public Main_function_1player()
        {
            InitializeComponent();
        }

        private void Main_function_1player_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in Game_panel.Controls)
            {
                timelb.Text = "3";
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            //random images
           //Randomize();
            timer2.Start();
            timer1.Start();
            //load images 
            LoadImages();
        }
        public void Randomize()
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
            Main_function_1player_Load(sender, e);
        }
        private void ScoreCount()
        {
            score_set.Text = Convert.ToString(Convert.ToUInt32(score_set.Text) + 10);
            if (Convert.ToUInt32(score_set.Text) >= 120)
            {
                MessageBox.Show("Congratulations!!!");
            }
        }
        private void card1_Click(object sender, EventArgs e)
        {
            card1.Image = Image.FromFile(imgPath + "pic (10).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dubcard1.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }

        }
        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Image.FromFile(imgPath + "pic (11).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dubcard1.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Image.FromFile(imgPath + "pic (13).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dubcard1.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Image.FromFile(imgPath + "pic (15).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dubcard1.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Image.FromFile(imgPath + "pic (16).JPG"); ;
            if (PendingImage1 == null)
            {
                PendingImage1 = card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card5.Enabled = false;
                    dubcard5.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Image.FromFile(imgPath + "pic (18).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card6.Enabled = false;
                    dubcard6.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Image.FromFile(imgPath + "pic (21).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card7.Enabled = false;
                    dubcard7.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Image.FromFile(imgPath + "pic (3).JPG"); ;
            if (PendingImage1 == null)
            {
                PendingImage1 = card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card8.Enabled = false;
                    dubcard8.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card9_Click(object sender, EventArgs e)
        {
            card9.Image = Image.FromFile(imgPath + "pic (4).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card9.Enabled = false;
                    dubcard9.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card10_Click(object sender, EventArgs e)
        {
            card10.Image = Image.FromFile(imgPath + "pic (5).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card10.Enabled = false;
                    dubcard10.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card11_Click(object sender, EventArgs e)
        {
            card11.Image = Image.FromFile(imgPath + "pic (6).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = card11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card11;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card11.Enabled = false;
                    dubcard11.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void card12_Click(object sender, EventArgs e)
        {
            card12.Image = Image.FromFile(imgPath + "pic (8).JPG"); ;
            if (PendingImage1 == null)
            {
                PendingImage1 = card12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = card12;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card12.Enabled = false;
                    dubcard12.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard1_Click(object sender, EventArgs e)
        {
            dubcard1.Image = Image.FromFile(imgPath + "pic (10).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card1.Enabled = false;
                    dubcard1.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard2_Click(object sender, EventArgs e)
        {
            dubcard2.Image = Image.FromFile(imgPath + "pic (11).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card2.Enabled = false;
                    dubcard2.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard3_Click(object sender, EventArgs e)
        {
            dubcard3.Image = Image.FromFile(imgPath + "pic (13).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card3.Enabled = false;
                    dubcard3.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard4_Click(object sender, EventArgs e)
        {
            dubcard4.Image = Image.FromFile(imgPath + "pic (15).JPG"); ;
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card4.Enabled = false;
                    dubcard4.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard5_Click(object sender, EventArgs e)
        {
            dubcard5.Image = Image.FromFile(imgPath + "pic (16).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card5.Enabled = false;
                    dubcard5.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard6_Click(object sender, EventArgs e)
        {
            dubcard6.Image = Image.FromFile(imgPath + "pic (18).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card6.Enabled = false;
                    dubcard6.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard7_Click(object sender, EventArgs e)
        {

            dubcard7.Image = Image.FromFile(imgPath + "pic (21).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card7.Enabled = false;
                    dubcard7.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard8_Click(object sender, EventArgs e)
        {
            dubcard8.Image = Image.FromFile(imgPath + "pic (3).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card8.Enabled = false;
                    dubcard8.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard9_Click(object sender, EventArgs e)
        {
            dubcard9.Image = Image.FromFile(imgPath + "pic (4).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard9;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard9;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card9.Enabled = false;
                    dubcard9.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard10_Click(object sender, EventArgs e)
        {
            dubcard10.Image = Image.FromFile(imgPath + "pic (5).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard10;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard10;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card10.Enabled = false;
                    dubcard10.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard11_Click(object sender, EventArgs e)
        {
            dubcard11.Image = Image.FromFile(imgPath + "pic (6).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard11;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard11;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card11.Enabled = false;
                    dubcard11.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void dubcard12_Click(object sender, EventArgs e)
        {
            dubcard12.Image = Image.FromFile(imgPath + "pic (8).JPG");
            if (PendingImage1 == null)
            {
                PendingImage1 = dubcard12;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = dubcard12;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    card12.Enabled = false;
                    dubcard12.Enabled = false;
                    ScoreCount();
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Game_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 link = new Form1();
            link.Show();
        }
    }
}



