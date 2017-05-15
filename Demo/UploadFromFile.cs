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
    public partial class UploadFromFile : Form
    {
        public UploadFromFile()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            //Browse Image
            OldopenFile.Multiselect = true;

            if (OldopenFile.ShowDialog() == DialogResult.OK)
            {
                OldopenFile.Filter = "JPG(*.JPG)|*.jpg";
                Save.Enabled = true;
                string[] temp = OldopenFile.FileNames;
                int x = 10;
                int y = 10;
                int maxHeight = 11;
                foreach (PictureBox img in panel1.Controls)
                {
                    //PictureBox pic = new PictureBox();
                    //pic.Image = Image.FromFile(img);
                    //pic.Location = new Point(x, y);
                    //pic.SizeMode = PictureBoxSizeMode.Zoom;
                    //x += pic.Width + 5;
                    //maxHeight = Math.Max(pic.Height, maxHeight);
                    //if (x > this.ClientSize.Width - 100)
                    //{
                    //    x = 20;
                    //    y += maxHeight + 20;
                    //}
                    img.Image = Image.FromFile(OldopenFile.FileName);
                    this.panel1.Controls.Add(img);
                }
            }
        }
    }
}
