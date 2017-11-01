using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Logic
{
    public class FyllPå
    {
        PodFeed podfeed = new PodFeed();
        public bool nyMapp(string category)
        {
            string folderName = category;

            System.IO.Directory.CreateDirectory(folderName);
            return true;
        }

        public void fyllCbUppdatering(ComboBox combo)
        {
            try
            {
                combo.Items.Add("5");
                combo.Items.Add("10");
                combo.Items.Add("30");
                combo.Items.Add("60");
                combo.Items.Add("1440");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void fyllListaKategori(ListBox lista, ComboBox combo)
        {
            String[] kategori = Directory.GetDirectories(Directory.GetCurrentDirectory());
            foreach (String kat in kategori)
            {
                String[] splitta = kat.Split('\\');
                int längd = splitta.Length - 1;
                String fixadLängd = splitta[längd];
                lista.Items.Add(fixadLängd);
                combo.Items.Add(fixadLängd);
            }
        }

        public void fyllListaPodcast(String kategori, ListBox lista)
        {
            String[] podcast = Directory.GetFiles(kategori);
            foreach (String pod in podcast)
            {
                String[] splitta = pod.Split('\\');
                String splitta2 = splitta[splitta.Length - 1];
                String[] fixadLängd = splitta2.Split('.');
                String fixadSplitt = fixadLängd[0];
                lista.Items.Add(fixadSplitt);
            }
        }

        public void fyllListaAvsnitt(String kategori, String namn, ListBox avsnitt)
        {
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";

            XmlDocument synkDokument = new XmlDocument();
            synkDokument.Load(path);

            try
            {
                var url = synkDokument.SelectSingleNode("channel/url").InnerText;
                int uppdatering;
                DateTime senastSynkad;
                DateTime.TryParse(synkDokument.SelectSingleNode("channel/lastSync").InnerText, out senastSynkad);
                int.TryParse(synkDokument.SelectSingleNode("channel/interval").InnerText, out uppdatering);
                if (senastSynkad.AddMinutes(uppdatering).CompareTo(DateTime.Now) < 0)
                {
                    podfeed.skapaPod(namn, url, kategori, uppdatering.ToString());
                    Console.WriteLine("Uppdaterad");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Uppdateringen knasade.");
            }

            foreach (XmlNode xndNode in synkDokument.DocumentElement.SelectNodes("item"))
            {
                var titel = xndNode.SelectSingleNode("title");
                avsnitt.Items.Add(titel.InnerText);
            }
        }
    }
}
