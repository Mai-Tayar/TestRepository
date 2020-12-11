using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiland
{
    public class EilandInwonerFactory //SIMPLE FACTORY
    {
        public EilandInwoner MaakEilandInwoner(String soort, string naam)
        {
            switch (soort)
            {
                case "V":
                    return new Vogel(naam);
                case "Z":
                    return new Zoogdier(naam);
                default:
                    throw new Exception("Verkeerde soort.");

            }
        }
    }
}
