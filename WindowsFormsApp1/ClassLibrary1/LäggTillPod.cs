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
        
        public void läggTillPod(String namn, String url, String kategori, String uppdatering)
        {
            Rss varRss = new Rss();
            XmlDocument dokument = varRss.läggIhopDokument(url);
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";
           
            int i = 0;

            XmlWriter xmlSkrivare = XmlWriter.Create(path);

            xmlSkrivare.WriteStartDocument();
            xmlSkrivare.WriteStartElement("channel");
            xmlSkrivare.WriteElementString("interval", uppdatering);
            xmlSkrivare.WriteElementString("url", url);
            xmlSkrivare.WriteElementString("lastSync", DateTime.Now.ToString());
            foreach (XmlNode item in dokument.DocumentElement.SelectNodes("channel/item"))
                {
                var titel = item.SelectSingleNode("title");
                var beskrivning = item.SelectSingleNode("description");
                var stäng = item.SelectSingleNode("enclosure/@url");

                xmlSkrivare.WriteStartElement("item");
                xmlSkrivare.WriteAttributeString("ID", "pod" + i);

                if (beskrivning.InnerText.Equals(""))
                {
                    xmlSkrivare.WriteElementString("description", "Tyvärr finns ingen beskrivning för podcasten.");
                }
                else
                {
                    xmlSkrivare.WriteElementString("description", beskrivning.InnerText);
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
