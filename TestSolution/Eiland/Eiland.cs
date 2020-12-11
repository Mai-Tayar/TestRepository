using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiland
{
    public class Eiland  //Singleton
    {
        private static Eiland _uniekeEiland;
        public List<EilandInwoner> Inwoners { get; set; } = new List<EilandInwoner>();

        private Eiland() { }  //Private constructor

        public static Eiland GetInstance()
        {
            if (_uniekeEiland == null)
            {
                _uniekeEiland = new Eiland();
            }
            return _uniekeEiland;
        }
        public void AddInwoner(EilandInwoner inwoner)
        {
            Inwoners.Add(inwoner);
        }

        public void VolkaanUitBarsting()
        {
            foreach (var inwoner in this.Inwoners)
            {
                inwoner.vlug();
            }
        }
        
    }
}
