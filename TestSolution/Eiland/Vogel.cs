using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiland
{
    public class Vogel : EilandInwoner
    {
        public Vogel(string naam):base(naam) { }
        public override void vlug()
        {
            Console.WriteLine(Naam+" is hoger gevlogen");
        }
    }
}
