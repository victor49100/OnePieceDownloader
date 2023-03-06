using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;


namespace MangaDowloader2
{

    public partial class MangaDownloader : Form
    {

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public MangaDownloader()
        {
            InitializeComponent();
        }

        public void DownloadFromUrl()
        {

            WebClient webClient = new WebClient();
            string k = "";
            string folderPath = labelTest.Text;

            if (folderPath == "")
            {
                labelTest.Text = "Aucun chemin renseigné !";
            }
            else
            {

                for (int i = 1; i < 40; i++)
                {
                    if (i < 10)
                    {
                        k = "0" + i;
                    }
                    else
                    {
                        k = "" + i;
                    }
                    string fileName = string.Format(i + ".png");
                    string filePath = folderPath + fileName;
                    //string imageUrl = imageUrl1 + i + imageUrl2;
                    string url = String.Format(@"https://lelscans.net/mangas/one-piece/1070/{0}.jpg?v=fr1674202018", k);


                    {
                        try
                        {
                            byte[] dataArr = webClient.DownloadData(url);
                            System.IO.File.WriteAllBytes(filePath, dataArr);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    labelTest.Text = url;
                    Debug.WriteLine(url);
                    Debug.WriteLine(filePath);


                }

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
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string folderPath = fbd.SelectedPath;
                labelTest.Text = folderPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Télecharger(object sender, EventArgs e)
        {
            string textUrl = textBox1.Text;
            DownloadFromUrl();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
