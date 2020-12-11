using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiland
{
    public abstract class EilandInwoner
    {
        public string Naam { get; set; }

        protected EilandInwoner(string naam) { Naam = naam; }
        public abstract void vlug();
    }
}
