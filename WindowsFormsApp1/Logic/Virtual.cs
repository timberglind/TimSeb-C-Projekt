using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Virtual
    {
            public virtual void braDag(TextBox tb)
            {
                String s = " Ha en dålig dag.";
                tb.AppendText(s);
            }

    }
}
