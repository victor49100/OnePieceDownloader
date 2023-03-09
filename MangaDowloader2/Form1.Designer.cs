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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTelechargerListe = new System.Windows.Forms.Label();
            this.LabelPath = new System.Windows.Forms.Label();
            this.textBoxChapitre = new System.Windows.Forms.TextBox();
            this.labelNumeroChapitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitre.Font = new System.Drawing.Font("Kabel Bd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitre.Location = new System.Drawing.Point(284, 22);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(198, 22);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Manga Downloader 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Télecharger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Télecharger);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Kabel Bd", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(321, 58);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Locallisation des fichiers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ChangeLocation);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTelechargerListe
            // 
            this.labelTelechargerListe.AutoSize = true;
            this.labelTelechargerListe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTelechargerListe.Font = new System.Drawing.Font("Kabel Bd", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelechargerListe.ForeColor = System.Drawing.Color.White;
            this.labelTelechargerListe.Location = new System.Drawing.Point(254, 207);
            this.labelTelechargerListe.Name = "labelTelechargerListe";
            this.labelTelechargerListe.Size = new System.Drawing.Size(239, 17);
            this.labelTelechargerListe.TabIndex = 7;
            this.labelTelechargerListe.Text = "Télecharger via une liste de sites";
            this.labelTelechargerListe.Click += new System.EventHandler(this.LabelCombo);
            // 
            // LabelPath
            // 
            this.LabelPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPath.AutoSize = true;
            this.LabelPath.BackColor = System.Drawing.Color.Black;
            this.LabelPath.Font = new System.Drawing.Font("Kabel Bd", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPath.ForeColor = System.Drawing.Color.Red;
            this.LabelPath.Location = new System.Drawing.Point(236, 147);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(0, 22);
            this.LabelPath.TabIndex = 10;
            this.LabelPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxChapitre
            // 
            this.textBoxChapitre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBoxChapitre.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChapitre.ForeColor = System.Drawing.Color.Red;
            this.textBoxChapitre.Location = new System.Drawing.Point(340, 177);
            this.textBoxChapitre.Name = "textBoxChapitre";
            this.textBoxChapitre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxChapitre.Size = new System.Drawing.Size(68, 27);
            this.textBoxChapitre.TabIndex = 11;
            this.textBoxChapitre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxChapitre.TextChanged += new System.EventHandler(this.textBoxChapitre_TextChanged);
            // 
            // labelNumeroChapitre
            // 
            this.labelNumeroChapitre.AutoSize = true;
            this.labelNumeroChapitre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNumeroChapitre.Font = new System.Drawing.Font("Kabel Bd", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroChapitre.ForeColor = System.Drawing.Color.White;
            this.labelNumeroChapitre.Location = new System.Drawing.Point(304, 119);
            this.labelNumeroChapitre.Name = "labelNumeroChapitre";
            this.labelNumeroChapitre.Size = new System.Drawing.Size(139, 17);
            this.labelNumeroChapitre.TabIndex = 12;
            this.labelNumeroChapitre.Text = "numero du chapitre";
            // 
            // MangaDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::MangaDowloader2.Properties.Resources.vaisseau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 509);
            this.Controls.Add(this.labelNumeroChapitre);
            this.Controls.Add(this.textBoxChapitre);
            this.Controls.Add(this.LabelPath);
            this.Controls.Add(this.labelTelechargerListe);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTelechargerListe;
        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.TextBox textBoxChapitre;
        private System.Windows.Forms.Label labelNumeroChapitre;
    }
}

