using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public static class Validering
    {

        public static bool kollaTextFält(TextBox fält, String label)
        {
            if (fält.Text == "")
            {
                MessageBox.Show("Du måste fylla i fältet " + label);
                fält.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool KollaUrl(String url)
        {
            try
            {
                var xml = "";
                using (var klient = new System.Net.WebClient())
                {
                    klient.Encoding = Encoding.UTF8;
                    xml = klient.DownloadString(url);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fel på URL.");
                return false;
            }
        }

        public static bool KollacomboBox(ComboBox kombo, ListBox lista)
        {
            if (kombo.Text == "")
            {
                MessageBox.Show("Välj ny kategori.");
                kombo.Focus();
                return false;
            }
            else if (kombo.SelectedItem == lista.SelectedItem)
            {
                MessageBox.Show("Podden ligger redan i denna kategori.");
                kombo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool kollaUppdatering(ComboBox kombo, ListBox lista)
        {
            if (kombo.Text == "")
            {
                MessageBox.Show("Välj ett uppdateringsintervall");
                kombo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool KollaPodLista(ListBox lista)
        {
            if (lista.Text == "")
            {
                MessageBox.Show("Välj en podcast att ta bort från listan");
                lista.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool KollaValdPodUppdatering(ListBox lista)
        {
            if (lista.Text == "")
            {
                MessageBox.Show("Välj en podcast att uppdatera uppdateringsintervallet på från podcastlistan");
                lista.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool KollaValdPodUrlUppdatering(ListBox lista)
        {
            if (lista.Text == "")
            {
                MessageBox.Show("Välj en podcast att uppdatera URL på från podcastlistan");
                lista.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool kollaSamma(TextBox textbox, ComboBox combo)
        {
            
            if (combo.SelectedItem.ToString() == textbox.Text)
            {
                MessageBox.Show("Namnet finns redan");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool kollaSamma(TextBox textbox, ListBox lista)
        {
            if (lista.Items.Contains(textbox.Text))
            {
                MessageBox.Show("Kategorin finns redan");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
