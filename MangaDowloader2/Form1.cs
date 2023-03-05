using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace MangaDowloader2
{

    public partial class Form1 : Form
    {
        string _PATH = "C:\\Users\\Victor\\Pictures\\TEST";
        public Form1()
        {
            InitializeComponent();
        }

        public void DownloadFromUrl(string imageUrl)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] dataArr = webClient.DownloadData("https://static.wikia.nocookie.net/manga-encyclopedie/images/a/a3/Guts.jpg/revision/latest?cb=20160228151038&path-prefix=fr");
                //save file to local
                File.WriteAllBytes(_PATH, dataArr);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeLocation(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Télecharger(object sender, EventArgs e)
        {
            string textUrl = textBox1.Text;
            DownloadFromUrl(textUrl);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
