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
    public class Kategori
    {
        List<Kategori> kategoriLista = new List<Kategori>();

        public void fyllKategoriLista (String namn, ListBox lista)
        {
            lista.Update();
            lista.Items.Add(namn);
        }

        public void läggTillKategori (String kategori, ListBox lista, ComboBox kombo)
        {
            String path = Directory.GetCurrentDirectory() + @"\" + kategori;
            XmlWriterSettings skrivSettings = new XmlWriterSettings();
            skrivSettings.Indent = true;
            skrivSettings.IndentChars = ("  ");

            XmlWriter xmlSkrivare = XmlWriter.Create(path, skrivSettings);

            xmlSkrivare.WriteStartDocument();
            xmlSkrivare.WriteStartElement("channel");

            xmlSkrivare.WriteEndDocument();
            xmlSkrivare.Close();

            kombo.Update();
            kombo.Items.Add(kategori);
            lista.Update();
            lista.Items.Add(kategori);
        }

        public bool nyMapp(string category)
        {
            string folderName = category;

            System.IO.Directory.CreateDirectory(folderName);
            return true;
        }
    }
}
