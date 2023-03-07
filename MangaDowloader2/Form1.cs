using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MangaDowloader2
{


    public partial class MangaDownloader : Form
    {
        public Dictionary<string, string> UrlManga = new Dictionary<string, string>();
        
        //liste manga

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public MangaDownloader()
        {
            //charge tt les items
            InitializeComponent();

            // liste manga TODO remplacer par XML
            UrlManga.Add("OnePiece", "https://lelscans.net/mangas/one-piece/{}/{}.jpg?v=fr1674202018");
            UrlManga.Add("OnePiece2", "https://lelscans.net/mangas/one-piece/{}/{}.jpg?v=fr1674202018");
            UrlManga.Add("OnePiece3", "https://lelscans.net/mangas/one-piece/{}/{}.jpg?v=fr1674202018");


            comboBox1.DataSource = new BindingSource(UrlManga, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            
            
        }


        //Transform url
        public void TrimUrl(string url)


        {
            Regex regex = new Regex(@"\/(\d+)\.(jpg|jpeg|png|webp)(?:\?.*)?");
            Match match = regex.Match(url);
            if (match.Success)
            {
                string pageNumber = match.Groups[1].Value;
                Debug.WriteLine($"Page number: {pageNumber}");
            }
            else
            {
                Debug.WriteLine("No match found.");
            }
        }



        //boutton Telechargé
        public void DownloadFromUrl()
        {
            int newChapterNumber = 1070;
            WebClient webClient = new WebClient();
            string k = "";
            string folderPath = "" + LabelFolder.Text + "\\";

            if (folderPath == "")
            {
                label2.Text = "Aucun chemin renseigné !";
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
                    string newUrl = string.Format("https://fr-scan.com/wp-content/uploads/WP-manga/data/manga_62b4957984def/eb0cb3fbac2d003454dbf5bab87efb65/0{0}.jpeg", i);

                    {
                        //telecharge
                        try
                        {
                            byte[] dataArr = webClient.DownloadData(newUrl);
                            System.IO.File.WriteAllBytes(filePath, dataArr);
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    LabelFolder.Text = newUrl;
                    Debug.WriteLine(newUrl);
                    Debug.WriteLine(filePath);


                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeLocation(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string folderPath = fbd.SelectedPath;
                LabelFolder.Text = folderPath + "\\";
                label2.Text = ("");

            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Télecharger(object sender, EventArgs e)
        {

            DownloadFromUrl();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxUrl(object sender, EventArgs e)
        {

        }

        private void c(object sender, EventArgs e)
        {

        }

        private void LabelCombo(object sender, EventArgs e)
        {

        }

        private void button3_ClickTrim(object sender, EventArgs e)
        {
            TrimUrl(textBoxUrl.Text);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void BoutonTelechargerCombo(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            
        }
    }
}
