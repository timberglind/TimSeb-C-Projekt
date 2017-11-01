using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    internal class InternKlass
    {
        internal string xml = "";
    }
    class Rss : Abstrakt
    {

        public override XmlDocument läggIhopDokument(string urlString)
        {
            InternKlass iKlass = new InternKlass();
            var xml = iKlass.xml;

            using (var klient = new System.Net.WebClient())
            {
                klient.Encoding = Encoding.UTF8;
                xml = klient.DownloadString(urlString);
            }
            XmlDocument laddaXml = new XmlDocument();
            laddaXml.LoadXml(xml);
            return laddaXml;
        }
    }
}
