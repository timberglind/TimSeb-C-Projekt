using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class LäggTillPod
    {
        public static List<String> enLista = new List<String>();
        public static List<String> listaKategori = new List<String>();
        public List<String> listaHämta()
        {
            return enLista;
        }
        public List<String> kategoriHämta()
        {
            return listaKategori;
        }
        public void läggTillPod(String namn, String url, String kategori, String uppdatering)
        {
            Rss varRss = new Rss();
            XmlDocument dokument = varRss.fetchDocument(url);
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";
            XmlWriterSettings skrivSettings = new XmlWriterSettings();
            skrivSettings.Indent = true;
            skrivSettings.IndentChars = ("  ");

            int i = 0;

            XmlWriter xmlSkrivare = XmlWriter.Create(path, skrivSettings);

            xmlSkrivare.WriteStartDocument();
            xmlSkrivare.WriteStartElement("channel");
            xmlSkrivare.WriteElementString("uppdatering", uppdatering);
            xmlSkrivare.WriteElementString("url", url);
            xmlSkrivare.WriteElementString("senastUppdatering", DateTime.Now.ToString());
            foreach (XmlNode item in dokument.DocumentElement.SelectNodes("channel/item"))
                {
                var titel = item.SelectSingleNode("title");
                var beskrivning = item.SelectSingleNode("description");
                var stäng = item.SelectSingleNode("enclosure/@url");

                xmlSkrivare.WriteStartElement("item");
                xmlSkrivare.WriteAttributeString("ID", "podcast" + i);

                if (beskrivning.InnerText.Equals(""))
                {
                    xmlSkrivare.WriteElementString("beskrivning", "Tyvärr finns ingen beskrivning för podcasten.");
                }
                else
                {
                    xmlSkrivare.WriteElementString("beskrivning", beskrivning.InnerText);

                }

                xmlSkrivare.WriteElementString("title", titel.InnerText);
                xmlSkrivare.WriteElementString("enclosure", stäng.InnerText);
                xmlSkrivare.WriteElementString("status", "Unlistened");
                xmlSkrivare.WriteEndElement();
                i++;

                }

            xmlSkrivare.WriteEndDocument();
            xmlSkrivare.Close();



        }
    }
}
