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
using System.IO;

namespace Demo
{
    public partial class Upload : Form
    {
        int rowpos = 0;
        int rownumb = 0;
        DataTable temp = new DataTable();
        OleDbConnection myConnection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\LAMK\Homework_2\Green ICT application\Democode\Demo_Login_Register_Upload_Save_MainFuntion\DemoDB.mdb");
        OleDbDataAdapter dapt;
        public Upload()
        {
            InitializeComponent();
        }
        private void Upload_Load(object sender, EventArgs e)
        {

        }
        private void ConnectToDB()
        {
            myConnection.Open();
            OleDbDataAdapter dapt = new OleDbDataAdapter("Select* From Game_object", myConnection.ConnectionString);
            dapt.Fill(temp);
            if (temp.Rows.Count != 0)
            {
                rowpos = temp.Rows.Count;
            }
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            //Browse Image
            OldopenFile.Multiselect = true;

            if (OldopenFile.ShowDialog() == DialogResult.OK)
            {
                Save.Enabled = true;
                string[] temp = OldopenFile.FileNames;
                int x = 10;
                int y = 10;
                int maxHeight = 11;
                foreach (string img in temp)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    x += pic.Width + 5;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x > this.ClientSize.Width - 100)
                    {
                        x = 20;
                        y += maxHeight + 20;
                    }
                    this.Panel_images.Controls.Add(pic);
                }
            }
        }
        private byte[] ConvertImage(Image input_image)
        {
            Bitmap BmpImage = new Bitmap(input_image);//convert to bitmap format
            MemoryStream myStream = new MemoryStream(); //stream image
            BmpImage.Save(myStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] ImageAsByte = myStream.ToArray();
            return ImageAsByte;
        }
        private void StoreImage(byte[] ImageAsbyte)
        {
            if (myConnection.State.Equals(ConnectionState.Closed))
            myConnection.Open(); 
            try
            {
                OleDbCommand SaveImage = new OleDbCommand("INSERT into Game_object ( [Date], [Format])" +" VALUES('"  + DateTime.Now + "',@image)", myConnection);
                OleDbParameter imagePara = SaveImage.Parameters.AddWithValue("@image", SqlDbType.Binary);
                imagePara.Value = ImageAsbyte;
                imagePara.Size = ImageAsbyte.Length;
                int row = SaveImage.ExecuteNonQuery();
                row++;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            finally
            {
                RefreshDB();
            }
        }
        public void RefreshDB()
        {
            if (myConnection.State.Equals(ConnectionState.Open))
            {
                myConnection.Close();
                temp.Clear();
                ConnectToDB();
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string[] temp = OldopenFile.FileNames;
                foreach (string img in temp)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                    StoreImage(ConvertImage(pic.Image));

                }
                MessageBox.Show("Image successfully saved");

            }
            catch (Exception )
            {
                MessageBox.Show("There is problem in Saving system");
            }
        }
       private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
           Object_Option linkto = new Object_Option();
            linkto.Show();

        }
    }
}
