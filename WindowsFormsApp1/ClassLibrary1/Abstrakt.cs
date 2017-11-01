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
    }
}
