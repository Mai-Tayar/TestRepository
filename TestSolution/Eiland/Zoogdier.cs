using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiland
{
    public class Zoogdier : EilandInwoner
    {
        public Zoogdier(string naam) : base(naam) { }
        public override void vlug()
        {
            Console.WriteLine(Naam + " heeft geschuild");
        }
    }
}
