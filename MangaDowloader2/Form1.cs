using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MangaDowloader2
{


    public partial class MangaDownloader : Form
    {
        Boolean finDownload = true;

        //variable contexte
        string ComboBoxUrlDownload = "";

        //chemin du dossier image
        string _Path;

        //chemin choisis par l'user 
        string folderPath = "";

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

            UrlManga.Add("chapitres OnePiece anglais", "https://cdn.readonepiece.com/file/mangap/2/{0}/{1}.jpeg?t=1677427643");


            comboBox1.DataSource = new BindingSource(UrlManga, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";


        }


        //boutton Telechargé
        public void DownloadFromUrl()
        {
            WebClient webClient = new WebClient();

            while (finDownload == true)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;


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
                    if (ComboBoxUrlDownload == "https://cdn.readonepiece.com/file/mangap/2/{0}/{1}.jpeg?t=1677427643")
                    {
                        newChapterNumber = ConvertUrlToTomeOp(int.Parse(newChapterNumber));
                    }

                    //Création du chemin fichier
                    _Path = "" + _Path + "\\OnePiece_" + newChapterNumber + "\\";

                    //on crée le dossier 
                    try
                    {
                        // If the directory doesn't exist, create it.
                        if (!Directory.Exists(_Path))
                        {
                            Directory.CreateDirectory(_Path);
                        }
                    }
                    catch (Exception)
                    {

                    }

                    for (int i = 1; i < 100; i++)
                    {


                        if (ComboBoxUrlDownload != "https://cdn.readonepiece.com/file/mangap/2/{0}/{1}.jpeg?t=1677427643")
                        {
                            if (i < 10)
                            {
                                pageNum = "0" + i;
                            }
                            else
                            {
                                pageNum = "" + i;
                            }
                        }
                        else
                        {
                            pageNum = "" + i;
                        }
                        string fileName = string.Format(pageNum + ".jpg");
                        string filePath = _Path + fileName;
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
                                if (Directory.GetFiles(_Path).Length == 0)
                                {
                                    finDownload = false;
                                    Directory.Delete(_Path, false);
                                    MessageBox.Show("aucun chapitre trouvé, essaye un autre site", "Erreur de téléchargement",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
                                    finDownload = false;
                                }
                                else
                                {
                                    finDownload = false;
                                    System.Windows.Forms.MessageBox.Show("Chapitre " + newChapterNumber + " téléchargé ! | " + _Path, "OK", MessageBoxButtons.OK);
                                }

                                finDownload = false;
                                break;

                            }

                        }

                    }
                }

                finDownload = false;
            }
        }
        //chemin
        public void ChangeLocation(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                folderPath = fbd.SelectedPath;
                LabelPath.Text = folderPath + "\\";
                _Path = folderPath + "\\";
            }

        }

        private void ConvertToPDF(object sender, EventArgs e)
        {

        }

        //SELECT COMBOBOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            var k = comboBox1.SelectedValue;
            ComboBoxUrlDownload = k.ToString();
        }

        public static string ConvertUrlToTomeOp(int tome)
        {
            string l1 = "10";
            string l2 = "00";
            string l3 = "00";

            if (tome < 10)
            {
                l3 = tome.ToString() + "0";
                string t = l1 + l2 + l3 + "00";
                return t;
            }
            if (tome > 9 && tome < 100)
            {
                int d = int.Parse(tome.ToString().Substring(0, 1));
                l2 = "0" + d.ToString();
                l3 = (tome % 10).ToString() + "0";
                Console.WriteLine(l1 + " " + l2 + " " + l3);
                string t = l1 + l2 + l3 + "00";
                return t;
            }
            if (tome > 99 && tome < 1000)
            {
                l2 = tome.ToString().Substring(0, 2);
                l3 = (tome % 10).ToString() + "0";
                string t = l1 + l2 + l3 + "00";
                return t;
            }
            if (tome > 999)
            {
                l1 = "11";
                l2 = tome.ToString().Substring(1, 2);
                l3 = (tome % 10).ToString() + "0";
                string t = l1 + l2 + l3 + "00";
                return t;
            }

            // Retour par défaut
            return null;
        }



        private void Télecharger(object sender, EventArgs e)
        {
            finDownload = true;
            DownloadFromUrl();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxChapitre_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
