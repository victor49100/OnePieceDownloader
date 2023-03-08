using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace MangaDowloader2
{


    public partial class MangaDownloader : Form
    {

        //variable contexte
        string ComboBoxUrlDownload = "";
        string _Path;
        public Dictionary<string, string> UrlManga = new Dictionary<string, string>();

        //liste manga

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public MangaDownloader()
        {
            //charge tt les items
            InitializeComponent();
            // 0 --> Chapitre | 1 --> page
            // liste manga TODO remplacer par XML
            UrlManga.Add("Choix du site", "");
            UrlManga.Add("OnePiece récent : lelScan", "https://lelscans.net/mangas/one-piece/{0}/{1}.jpg?v=fr1677156665");
            UrlManga.Add("OnePiece récent2 : opfrcdn", "https://opfrcdn.xyz/uploads/manga/one-piece/chapters/{0}/vf2/{1}.jpg");
            UrlManga.Add("chapitres OnePiece  1 à 1049", "https://www.scan-vf.net/uploads/manga/one_piece/chapters/chapitre-{0}/{1}.webp");


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


            if (ComboBoxUrlDownload == "[Choix du site, ]" || _Path == null || newChapterNumber == "")
            {
                //LabelPath.Text = "Aucun chemin, site ou chapitre renseigné !";
                MessageBox.Show("Aucun chemin, site ou chapitre renseigné !", "Erreur de saisie",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation); 
               
            }
            else
            {
                //Création du chemin fichier
                string folderPath = "" + _Path + "\\OnePiece_" + newChapterNumber + "\\";

                //on crée le dossier 
                try
                {
                    // If the directory doesn't exist, create it.
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                }
                catch (Exception)
                {

                }

                for (int i = 1; i < 100; i++)
                {
                    if (i < 10)
                    {
                        pageNum = "0" + i;
                    }
                    else
                        pageNum = "" + i;

                    string fileName = string.Format(i + ".png");
                    string filePath = folderPath + fileName;
                    string imageUrl = string.Format(ComboBoxUrlDownload, newChapterNumber, pageNum);

                    {
                        //tente de telecharger les fichiers
                        try
                        {
                            byte[] dataArr = webClient.DownloadData(imageUrl);
                            System.IO.File.WriteAllBytes(filePath, dataArr);
                        }
                        catch (Exception ex)
                        {
                            //destruction du Dossier si il est vide
                            if (Directory.GetFiles(folderPath).Length == 0)
                            {
                                Directory.Delete(folderPath, false);
                                MessageBox.Show("aucun chapitre trouvé, essaye un autre site", "Erreur de téléchargement",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                            }
                            System.Windows.Forms.MessageBox.Show("Chapitre " + newChapterNumber + " téléchargé ! | " + folderPath,"OK" , MessageBoxButtons.OK);
                            break;

                        }

                    }
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
                LabelPath.Text = folderPath + "\\";
                _Path = folderPath + "\\";
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxChapitre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
