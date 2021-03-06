﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Logic
{
    public class PodFeed
    {
        LäggTillPod newPod = new LäggTillPod();
        
        public void skapaPod(String namn, String url, String kategori, String uppdatering)
        {
            LäggTillPod nyPod = new LäggTillPod();
            nyPod.läggTillPod(namn, url, kategori, uppdatering);
        }

        public void hämtaPodUrl(String kategori, String namn, String valdPod, out String url)
        {
            XmlDocument xml = new XmlDocument();

            String[] minArray = valdPod.Split('(');
            String vald = minArray[0];

            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";
            xml.Load(path);

            url = "";

            foreach (XmlNode node in xml.DocumentElement.SelectNodes("item"))
            {
                XmlNode stäng = node.SelectSingleNode("enclosure");
                XmlNode titel = node.SelectSingleNode("title");

                if (titel.InnerText.Equals(vald))
                {
                    url = stäng.InnerText;
                    xml.Save(path);
                }
            }
        }

        public void ändraStatus(String kategori, String namn, String valdPod)
        {
            XmlDocument xml = new XmlDocument();

            String[] minArray = valdPod.Split('(');
            String vald = minArray[0];

            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";
            xml.Load(path);

            foreach (XmlNode node in xml.DocumentElement.SelectNodes("item"))
            {
                XmlNode titel = node.SelectSingleNode("title");
                XmlNode status = node.SelectSingleNode("status");
                if (titel.InnerText.Equals(vald))
                {
                    status.InnerText = "Lyssnat på.";
                    xml.Save(path);
                }
            }
        }

        public void omSpelad(String kategori, String namn, CheckedListBox avsnitt)
        {
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";

            XmlDocument synkDokument = new XmlDocument();
            synkDokument.Load(path);

            int i = 0;

            foreach (XmlNode xndNode in synkDokument.DocumentElement.SelectNodes("item"))
            {
                var titel = xndNode.SelectSingleNode("title");
                var status = xndNode.SelectSingleNode("status");

                if (status.InnerText.Equals("Lyssnat på."))
                {
                    avsnitt.SetItemChecked(i, true);
                }
                i++;
            }
        }

        public void hamtaOmAvsnitt(string kategori, string namn, string valtAvsnitt, TextBox textBox)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";

            XmlDocument xdcDocument = new XmlDocument();
            xdcDocument.Load(path);

            foreach (XmlNode xndNode in xdcDocument.DocumentElement.SelectNodes("item"))
            {
                var titel = xndNode.SelectSingleNode("title");
                if (valtAvsnitt.Equals(titel.InnerText))
                {
                    var omAvsnitt = xndNode.SelectSingleNode("description");
                    textBox.Text = omAvsnitt.InnerText;
                }
            }
        }

        public void taBortPod(String kategori, String namn)
        {
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";
            File.Delete(path);
        }

        public void taBortKategori(String kategori)
        {
            String path = Directory.GetCurrentDirectory() + @"\" + kategori;
            Directory.Delete(path, true);
        }

        public void ändraKategori(String kategori, String namn, ListBox lista, ComboBox kombo)
        {
            String väg1 = Directory.GetCurrentDirectory() + @"\" + kategori;
            String väg2 = Directory.GetCurrentDirectory() + @"\" + namn;

            Directory.Move(väg1, väg2);
            Directory.GetCurrentDirectory();
        }

        public void ändraUppdateringPod(String kategori, String namn, ComboBox kombo)
        {
            var doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml");
            var node = doc.SelectSingleNode(@"channel/interval");
            node.InnerText = kombo.Text;
            doc.Save(Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml");
        }

        public void ändraUrlPod(String kategori, String namn, TextBox text)
        {
            var doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml");
            var node = doc.SelectSingleNode(@"channel/url");
            node.InnerText = text.Text;
            doc.Save(Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml");
        }

        public void ändraPodKat(String kategori, String nyKat, String namn, ComboBox kombo)
        {
            String väg1 = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";
            String väg2 = Directory.GetCurrentDirectory() + @"\" + nyKat + @"\" + namn + @".xml";

            File.Move(väg1, väg2);
        }
    }
}
