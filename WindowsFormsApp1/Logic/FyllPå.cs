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
        List<FyllPå> kategoriLista = new List<FyllPå>();

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
    }
}
