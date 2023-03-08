using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MangaDowloader2
{


    public partial class MangaDownloader : Form
    {

        //variable contexte
        string ComboBoxUrlDownload = "";
        public Dictionary<string, string> UrlManga = new Dictionary<string, string>();

        //liste manga

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public MangaDownloader()
        {
            //charge tt les items
            InitializeComponent();

            // liste manga TODO remplacer par XML
            UrlManga.Add("OnePiece", "https://lelscans.net/mangas/one-piece/{0}/{1}.jpg?v=fr1674202018");
            UrlManga.Add("OnePiece2", "https://lelscans.net/mangas/one-piece/{0}/{1}.jpg?v=fr1674202018");
            UrlManga.Add("OnePiece3", "https://lelscans.net/mangas/one-piece/{0}/{1}.jpg?v=fr1674202018");


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
            WebClient webClient = new WebClient();


            string newChapterNumber = textBoxChapitre.Text;
            string pageNum = "";
            string folderPath = "" + LabelFolder.Text + "\\";
            //string Myurl = comboBox1.

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
                        pageNum = "0" + i;
                    }
                    else
                    {
                        pageNum = "" + i;
                    }
                    string fileName = string.Format(i + ".png");
                    string filePath = folderPath + fileName;
                    string imageUrl = string.Format(ComboBoxUrlDownload,newChapterNumber,pageNum);
                    string newUrl = string.Format("https://fr-scan.com/wp-content/uploads/WP-manga/data/manga_62b4957984def/eb0cb3fbac2d003454dbf5bab87efb65/{0}.jpeg", pageNum);

                    {
                        //telecharge
                        try
                        {
                            byte[] dataArr = webClient.DownloadData(imageUrl);
                            System.IO.File.WriteAllBytes(filePath, dataArr);
                        }
                        catch (Exception ex)
                        {
                            break;
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

            var k = comboBox1.SelectedValue;
            ComboBoxUrlDownload = k.ToString();
            label1.Text = k.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
