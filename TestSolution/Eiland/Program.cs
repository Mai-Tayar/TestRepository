using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eiland
{
    class Program
    {
        static void Main(string[] args) //SINGLETON , SIMPLE FACTORY zijn toegepast 
        {
            Eiland eiland = Eiland.GetInstance();
            
            using (StreamReader reader = new StreamReader("EilandInwoners.txt"))
            {
                EilandInwonerFactory factory = new EilandInwonerFactory();
                string regel = reader.ReadLine();
                while(regel!=null)
                {
                    eiland.AddInwoner(factory.MaakEilandInwoner(regel.Substring(0,1),regel.Substring(2)));
                    regel = reader.ReadLine();
                }

                eiland.VolkaanUitBarsting();
           
            }
        }
    }
}
