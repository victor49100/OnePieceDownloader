namespace MangaDowloader2
{
    partial class MangaDownloader
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangaDownloader));
            this.labelTitre = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelUrl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelFolder = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChapitre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTitre.Font = new System.Drawing.Font("Kabel Bd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(292, 30);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(198, 22);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Manga Downloader 2";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(21, 274);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(331, 23);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.TextBoxUrl);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Télecharger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Télecharger);
            // 
            // LabelUrl
            // 
            this.LabelUrl.AutoSize = true;
            this.LabelUrl.BackColor = System.Drawing.Color.Black;
            this.LabelUrl.Font = new System.Drawing.Font("Kabel Bd", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUrl.ForeColor = System.Drawing.Color.White;
            this.LabelUrl.Location = new System.Drawing.Point(107, 228);
            this.LabelUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUrl.Name = "LabelUrl";
            this.LabelUrl.Size = new System.Drawing.Size(146, 17);
            this.LabelUrl.TabIndex = 3;
            this.LabelUrl.Text = "Télecharger via URL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Locallisation des fichiers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeLocation);
            // 
            // LabelFolder
            // 
            this.LabelFolder.AutoSize = true;
            this.LabelFolder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelFolder.Location = new System.Drawing.Point(304, 129);
            this.LabelFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFolder.Name = "LabelFolder";
            this.LabelFolder.Size = new System.Drawing.Size(0, 15);
            this.LabelFolder.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(470, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Selectionnez un manga";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Kabel Bd", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Télecharger via une liste";
            this.label1.Click += new System.EventHandler(this.LabelCombo);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(488, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "Télécharger";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BoutonTelechargerCombo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "aucun dossier selectionné";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxChapitre
            // 
            this.textBoxChapitre.Location = new System.Drawing.Point(110, 154);
            this.textBoxChapitre.Name = "textBoxChapitre";
            this.textBoxChapitre.Size = new System.Drawing.Size(122, 23);
            this.textBoxChapitre.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "numero du chapitre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MangaDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::MangaDowloader2.Properties.Resources.shep2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxChapitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelFolder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LabelUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.labelTitre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Kabel Bd", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MangaDownloader";
            this.Text = "MangaDownloader";
            this.Load += new System.EventHandler(this.c);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelUrl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelFolder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChapitre;
        private System.Windows.Forms.Label label3;
    }
}

