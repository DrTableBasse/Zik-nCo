﻿namespace MoteurRechercheDeezer_V1
{
    partial class FrmDemarrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteurMultimédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBanniere = new System.Windows.Forms.PictureBox();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtisteInfos = new System.Windows.Forms.GroupBox();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblLien = new System.Windows.Forms.Label();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.tbpRadio = new System.Windows.Forms.TabPage();
            this.wbRadio = new System.Windows.Forms.WebBrowser();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            this.tbc.SuspendLayout();
            this.tbpArtiste.SuspendLayout();
            this.grbArtisteInfos.SuspendLayout();
            this.tbpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecteurMultimédiaToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // lecteurMultimédiaToolStripMenuItem
            // 
            this.lecteurMultimédiaToolStripMenuItem.Name = "lecteurMultimédiaToolStripMenuItem";
            this.lecteurMultimédiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lecteurMultimédiaToolStripMenuItem.Text = "Lecteur Multimédia";
            this.lecteurMultimédiaToolStripMenuItem.Click += new System.EventHandler(this.lecteurMultimédiaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.aProposToolStripMenuItem.Text = "A propos....";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // picBanniere
            // 
            this.picBanniere.Image = ((System.Drawing.Image)(resources.GetObject("picBanniere.Image")));
            this.picBanniere.Location = new System.Drawing.Point(12, 27);
            this.picBanniere.Name = "picBanniere";
            this.picBanniere.Size = new System.Drawing.Size(604, 134);
            this.picBanniere.TabIndex = 1;
            this.picBanniere.TabStop = false;
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteRecherche.ForeColor = System.Drawing.Color.White;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(13, 111);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(92, 13);
            this.lblArtisteRecherche.TabIndex = 2;
            this.lblArtisteRecherche.Text = "Artiste Recherché";
            this.lblArtisteRecherche.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.Location = new System.Drawing.Point(111, 108);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(100, 20);
            this.txtArtisteRecherche.TabIndex = 3;
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtArtisteRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(243, 106);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(42, 23);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "GO !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.bntRechercher_Click);
            // 
            // picDeezer
            // 
            this.picDeezer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDeezer.Image = ((System.Drawing.Image)(resources.GetObject("picDeezer.Image")));
            this.picDeezer.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDeezer.InitialImage")));
            this.picDeezer.Location = new System.Drawing.Point(434, 95);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(122, 50);
            this.picDeezer.TabIndex = 5;
            this.picDeezer.TabStop = false;
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpArtiste);
            this.tbc.Controls.Add(this.tbpRadio);
            this.tbc.Location = new System.Drawing.Point(12, 178);
            this.tbc.Multiline = true;
            this.tbc.Name = "tbc";
            this.tbc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(580, 241);
            this.tbc.TabIndex = 6;
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.Controls.Add(this.grbArtisteInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(572, 215);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Infos Artiste";
            this.tbpArtiste.UseVisualStyleBackColor = true;
            // 
            // grbArtisteInfos
            // 
            this.grbArtisteInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtisteInfos.Controls.Add(this.lstArtistes);
            this.grbArtisteInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtisteInfos.Controls.Add(this.lblLien);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtisteInfos.Controls.Add(this.picArtiste);
            this.grbArtisteInfos.Location = new System.Drawing.Point(6, 6);
            this.grbArtisteInfos.Name = "grbArtisteInfos";
            this.grbArtisteInfos.Size = new System.Drawing.Size(560, 214);
            this.grbArtisteInfos.TabIndex = 0;
            this.grbArtisteInfos.TabStop = false;
            this.grbArtisteInfos.Text = "Informations DEEZER";
            this.grbArtisteInfos.Enter += new System.EventHandler(this.grbArtisteInfos_Enter);
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(339, 110);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(125, 13);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien DEEZER de l\'Artiste";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerLien_LinkClicked);
            // 
            // lblLien
            // 
            this.lblLien.AutoSize = true;
            this.lblLien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLien.Location = new System.Drawing.Point(339, 75);
            this.lblLien.Name = "lblLien";
            this.lblLien.Size = new System.Drawing.Size(111, 13);
            this.lblLien.TabIndex = 3;
            this.lblLien.Text = "Lien Direct DEEZER :";
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(220, 16);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(59, 30);
            this.lblArtisteNom.TabIndex = 2;
            this.lblArtisteNom.Text = "NOM";
            this.lblArtisteNom.UseCompatibleTextRendering = true;
            // 
            // tbpRadio
            // 
            this.tbpRadio.Controls.Add(this.wbRadio);
            this.tbpRadio.Location = new System.Drawing.Point(4, 22);
            this.tbpRadio.Name = "tbpRadio";
            this.tbpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRadio.Size = new System.Drawing.Size(572, 215);
            this.tbpRadio.TabIndex = 1;
            this.tbpRadio.Text = "Radio Artiste";
            this.tbpRadio.UseVisualStyleBackColor = true;
            // 
            // wbRadio
            // 
            this.wbRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbRadio.Location = new System.Drawing.Point(3, 3);
            this.wbRadio.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbRadio.Name = "wbRadio";
            this.wbRadio.ScriptErrorsSuppressed = true;
            this.wbRadio.ScrollBarsEnabled = false;
            this.wbRadio.Size = new System.Drawing.Size(566, 209);
            this.wbRadio.TabIndex = 0;
            // 
            // picArtiste
            // 
            this.picArtiste.Image = ((System.Drawing.Image)(resources.GetObject("picArtiste.Image")));
            this.picArtiste.InitialImage = ((System.Drawing.Image)(resources.GetObject("picArtiste.InitialImage")));
            this.picArtiste.Location = new System.Drawing.Point(220, 49);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(113, 130);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 0;
            this.picArtiste.TabStop = false;
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(6, 19);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(183, 147);
            this.lstArtistes.TabIndex = 5;
            this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged);
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEcouterExtraits.Location = new System.Drawing.Point(6, 172);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(183, 23);
            this.btnEcouterExtraits.TabIndex = 6;
            this.btnEcouterExtraits.Text = "Ecouter tous les extraits";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picBanniere);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDemarrage";
            this.Text = " Moteur de Recherches Deezer V1";
            this.Activated += new System.EventHandler(this.FrmDemarrage_Activated);
            this.Load += new System.EventHandler(this.FrmDemmarage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            this.tbc.ResumeLayout(false);
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtisteInfos.ResumeLayout(false);
            this.grbArtisteInfos.PerformLayout();
            this.tbpRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteurMultimédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBanniere;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.TabPage tbpRadio;
        private System.Windows.Forms.GroupBox grbArtisteInfos;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblLien;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.WebBrowser wbRadio;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.PictureBox picArtiste;
    }
}

