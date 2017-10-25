using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Virtual2 : Virtual
    {
        public override void braDag(TextBox tb)
        {
            String s = "  Ha det bra!";
            tb.AppendText(s);
        }
    }
}
