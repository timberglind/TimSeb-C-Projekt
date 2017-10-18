using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public abstract class Abstrakt
    {
        public abstract XmlDocument fetchDocument(string urlString);

        public virtual void skrivXmlDokument(string url, string kategori, string namn)
        {
            Console.WriteLine(url + "" + kategori + "" + namn);
        }
    }
}
