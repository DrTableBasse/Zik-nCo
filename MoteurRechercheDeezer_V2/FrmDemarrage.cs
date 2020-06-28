using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;
using System.Diagnostics;

namespace MoteurRechercheDeezer_V1
{
    public partial class FrmDemarrage : Form
    {
        #region champ
        Artist selectedArtist = new Artist();
        #endregion
        public FrmDemarrage()
        {
            InitializeComponent();
        }

        private void FrmDemmarage_Load(object sender, EventArgs e)
        {
            if (NetManager.isConnected() == false)
            {
                MessageBox.Show("Problème réseau....\n Vérifiez votre connexion Internet.");
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntRechercher_Click(object sender, EventArgs e)
        {

            //Artist monArtist = new Artist();
            //déclaration et instanciation de la collection (liste) d'artistes
            List<Artist> lesArtistes = new List<Artist>();



            //string recherche = "zaz";
            string recherche = txtArtisteRecherche.Text;

            //monArtist = DeezerApi.getFirstArtistByName(recherche);
            //affection de la collection
            lesArtistes = DeezerApi.getAllArtistsByName(recherche);

            //if (monArtist == null)
            if (lesArtistes.Count ==0)
            {
                // Console.WriteLine("\n Désolé, l'artiste " + recherche + " est inconnu sur Deezer. Vérifiez l'orthographe");
                MessageBox.Show("\n Désolé, l'artiste '" + recherche + "' est inconnu sur Deezer. Vérifiez l'orthographe", "Zick'nCo : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
            else
            {

                
                
                //alimentation de la liste lstArtistes par la collection lesArtistes dans le DataSource.
                lstArtistes.DataSource = lesArtistes;
                lstArtistes.DisplayMember = "name";
            }



        }

        private void grbArtisteInfos_Enter(object sender, EventArgs e)
        {

        }

        private void lklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lklDeezerLien.Text);
        }

        private void TxtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        

        private void FrmDemarrage_Activated(object sender, EventArgs e)
        {
            txtArtisteRecherche.Focus();

        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter notre application ?", "ZiK'nCo : question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lecteurMultimédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            formulaire.Show();
            //formulaire.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPropos formulaire = new FrmAPropos();
            formulaire.ShowDialog();
        }

        private void lstArtistes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedArtist = (Artist)lstArtistes.SelectedItem;
            //Affichage des informations dans les contrôles associés.
            lblArtisteNom.Text = selectedArtist.name;
            lklDeezerLien.Text = selectedArtist.link;
            picArtiste.ImageLocation = selectedArtist.picture;
            //Recherche de l'URL de la radio et navigation vers celle-ci.
            string urlWidget = DeezerPlugin.getUrlPluginRadio(selectedArtist.id, wbRadio.Width, wbRadio.Height);
            wbRadio.Navigate(urlWidget);
            
        }

        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {
            Artist selectedArtistDetails = new Artist();
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);

            if (selectedArtistDetails.nbAlbums == 0)
            {
                MessageBox.Show("Désolé, les extraits pour '" + selectedArtist.name + "' ne sont pas disponibles...", "Zik'nCo : Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();
                foreach (Album unAlbum in lesAlbums)
                {
                    List<Track> lesTracks = unAlbum.getLesTracks();
                    foreach (Track unTrack in lesTracks)
                    {
                        //On lit chaque titre de chaque Album de l'artiste
                        WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                    }
                }
                formulaire.Show();

                formulaire.wmpLecteur.Ctlcontrols.play();
            }
            
        }
    }
}
