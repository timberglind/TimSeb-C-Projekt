using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Linq
    {
        
            public void LinqMetod(ListBox list)
            {
                string[] fleraOrd = { "Hej", "Då", "Välkommen", "Finaste", "Användare" };

                
                var merÄn5Bokstäver = from ord in fleraOrd where ord.Length >= 5 select ord;

                
                foreach (var ord in merÄn5Bokstäver)
                {
                    list.Items.Add(ord);
                }
            }
        }
    }

