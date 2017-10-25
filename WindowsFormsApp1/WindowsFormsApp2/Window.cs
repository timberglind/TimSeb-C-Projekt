using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Logic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Window : Form
    {
        PodFeed podfeed = new PodFeed();
        FyllPå fyll = new FyllPå();
        Validering validering = new Validering();
        Linq linq = new Linq();



        public Window()
        {
            try
            {
                InitializeComponent();
                fyll.fyllListaKategori(lbKategori, cbKategori);
                fyll.fyllCbUppdatering(cbUppdatering);
                linq.LinqMetod(lbVälkommen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private async void btnLäggTillPod_Click(object sender, EventArgs e)
        {
            await btnLäggTillPod_ClickAsync();
        }

        public async Task btnLäggTillPod_ClickAsync()
        {
            if (Validering.kollaTextFält(txtURL, "URL") && Validering.kollaTextFält(txtNamn, "Namn") && Validering.KollaUrl(txtURL.Text))
            {
                if (cbKategori.SelectedItem == null)
                {
                    MessageBox.Show("Välj kategori från komboboxen");
                }
                else
                {
                    PodFeed xmlPodFeed = new PodFeed();
                    xmlPodFeed.skapaPod(txtNamn.Text, txtURL.Text, cbKategori.SelectedItem.ToString(), cbUppdatering.SelectedItem.ToString());
                    lbPodcast.Items.Clear();
                    lbKategori.Items.Clear();
                    cbKategori.Items.Clear();
                    MessageBox.Show(txtNamn.Text + " har lagts till.");
                    txtNamn.Clear();
                    txtURL.Clear();
                    cbKategori.ResetText();
                    cbUppdatering.ResetText();
                    fyll.fyllListaKategori(lbKategori, cbKategori);
                    await Task.Delay(1000);
                    
                }
            }

        }

        private void btnLäggTillKategori_Click_1(object sender, EventArgs e)
        {
            if (Validering.kollaTextFält(txtLäggTillKategori, "'Lägg till Kategori'") && Validering.kollaSamma(txtLäggTillKategori, lbKategori))
            {
                fyll.nyMapp(txtLäggTillKategori.Text);
                lbKategori.Items.Clear();
                cbKategori.Items.Clear();
                fyll.fyllListaKategori(lbKategori, cbKategori);
                MessageBox.Show("Kategorin: '" + txtLäggTillKategori.Text + "' har lagts till.");
                txtLäggTillKategori.Clear();
            }
        }

        private void lbKategori_MouseClick(object sender, EventArgs e)
        {
            if (lbKategori.SelectedItem != null)
            {
                clbAvsnitt.Items.Clear();
                lbPodcast.Items.Clear();
                fyll.fyllListaPodcast(lbKategori.Text, lbPodcast);
            }
        }

        private void btnTabortKategori_Click(object sender, EventArgs e)
        {

            if (Validering.KollaPodLista(lbKategori))
            {
                podfeed.taBortKategori(lbKategori.Text);
                cbKategori.Items.Clear();
                lbKategori.Items.Clear();
                fyll.fyllListaKategori(lbKategori, cbKategori);
                clbAvsnitt.Items.Clear();
                lbPodcast.Items.Clear();
                MessageBox.Show("Kategorin är borttagen.");
            }

        }

        public async Task lbPodcast_MouseClick_ClickAsync()
        {
            await lbPodcast_MouseClick_ClickAsync();
        }

        private async void lbPodcast_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbPodcast.SelectedItem != null)
            {
                clbAvsnitt.Items.Clear();
                podfeed.hämtaAvsnitt(lbKategori.SelectedItem.ToString(), lbPodcast.SelectedItem.ToString(), clbAvsnitt);
                podfeed.omSpelad(lbKategori.SelectedItem.ToString(), lbPodcast.SelectedItem.ToString(), clbAvsnitt);
                await Task.Delay(1000);
            }

        }

        private void btnTabortPod_Click(object sender, EventArgs e)
        {
            if (Validering.KollaPodLista(lbPodcast))
            {
                podfeed.taBortPod(lbKategori.Text, lbPodcast.Text);
                clbAvsnitt.Items.Clear();
                lbPodcast.Items.Clear();
                tbOm.Clear();
                fyll.fyllListaPodcast(lbKategori.Text, lbPodcast);
                MessageBox.Show("Poddcasten är borttagen.");
            }
        }


        private void btnÄndraKategori_Click(object sender, EventArgs e)
        {
            if (Validering.kollaTextFält(txtNamn, "Namn") && Validering.kollaSamma(txtNamn, cbKategori))
                
            {
                if (cbKategori.SelectedItem == null)
                {
                    MessageBox.Show("Välj en kategori du vill ändra.");
                }
                else
                {
                    podfeed.ändraKategori(cbKategori.Text, txtNamn.Text, lbKategori, cbKategori);
                    lbKategori.Items.Clear();
                    cbKategori.Items.Clear();
                    cbKategori.ResetText();
                    clbAvsnitt.Items.Clear();
                    lbPodcast.Items.Clear();
                    txtNamn.Clear();
                    tbOm.Clear();
                    fyll.fyllListaKategori(lbKategori, cbKategori);
                }
            }

        }

        private void clbAvsnitt_MouseClick(object sender, MouseEventArgs e)
        {

            if (clbAvsnitt.SelectedItem != null)
            {
                podfeed.hamtaOmAvsnitt(lbKategori.SelectedItem.ToString(), lbPodcast.SelectedItem.ToString(), clbAvsnitt.SelectedItem.ToString(), tbOm);
            }
        }

        private void btnÄndraPodKategori_Click(object sender, EventArgs e)
        {
            if (Validering.KollacomboBox(cbKategori, lbKategori) && lbKategori.Items.Cast<string>().Any(x => x == txtNamn.Text))
            {
                if (lbPodcast.SelectedItem == null)
                {
                    MessageBox.Show("Välj en podcast från listan att ändra kategori på.");

                }
                else
                {
                    podfeed.ändraPodKat(lbKategori.Text, cbKategori.Text, lbPodcast.Text, cbKategori);
                    lbKategori.Items.Clear();
                    cbKategori.Items.Clear();
                    lbPodcast.Items.Clear();
                    clbAvsnitt.Items.Clear();
                    tbOm.Clear();
                    fyll.fyllListaKategori(lbKategori, cbKategori);
                }
            }
        }

        private void btnÄndraPodURL_Click(object sender, EventArgs e)
        {
            if (Validering.kollaTextFält(txtURL, "URL") && Validering.KollaValdPodUrlUppdatering(lbPodcast))
            {
                podfeed.ändraUrlPod(lbKategori.Text, lbPodcast.Text, txtURL);
                MessageBox.Show("URL uppdaterad.");
            }
            else
            {
                MessageBox.Show("Fyll i ny URL i URL fältet.");
            }
        }


        private void btnÄndraPodUppdatering_Click(object sender, EventArgs e)
        {
            if (Validering.kollaUppdatering(cbUppdatering, lbKategori) && Validering.KollaValdPodUppdatering(lbPodcast))
            {
                if (cbUppdatering.SelectedItem == null)
                {
                    MessageBox.Show("Välj ny uppdateringsintervall från comboboxen.");
                }
                else
                {
                    podfeed.ändraUppdateringPod(lbKategori.Text, lbPodcast.Text, cbUppdatering);
                    MessageBox.Show("Uppdateringsintervallen uppdaterad.");
                }
            }
        }

        private void btnSpelaPod_Click(object sender, EventArgs e)
        {
            try
            {
                string url;
                podfeed.hämtaPodUrl(lbKategori.SelectedItem.ToString(), lbPodcast.SelectedItem.ToString(), clbAvsnitt.SelectedItem.ToString(), out url);
                podfeed.ändraStatus(lbKategori.SelectedItem.ToString(), lbPodcast.SelectedItem.ToString(), clbAvsnitt.SelectedItem.ToString());
                Process.Start("wmplayer.exe", url);

                podfeed.omSpelad(lbKategori.SelectedItem.ToString(), lbPodcast.SelectedItem.ToString(), clbAvsnitt);
            }
            catch (Exception)
            {
                MessageBox.Show("Välj ett avsnitt att lyssna på från avsnittlistan.");
            }
        }

    }
}

