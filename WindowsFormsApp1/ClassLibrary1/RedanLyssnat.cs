using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class RedanLyssnat
    {
        public void kollaOmLyssnat(String namn, String kategori)
        {
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";

            XmlDocument xml = new XmlDocument();
            xml.Load(path);

            foreach (XmlNode node in xml.DocumentElement.SelectNodes("channel/item"))
            {
                var titel = node.SelectSingleNode("title").InnerText;
                if (hittadLyssnad(kategori, titel) == false)
                {

                }
            }
        }

        public bool hittadLyssnad(String kategori, String namn)
        {
            bool finns = false;
            String path = Directory.GetCurrentDirectory() + @"\" + kategori + @"\" + namn + @".xml";

            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            foreach (XmlNode node in xml.DocumentElement.SelectNodes("channel/item"))
            {
                var titel = node.SelectSingleNode("title");
                if (titel.Equals(namn))
                {
                    finns = true;
                }
            }
            return finns;
        }
    }
}
