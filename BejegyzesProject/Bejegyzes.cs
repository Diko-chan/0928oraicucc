using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Bejegyzes
    {
        string szerzo;
        string tartalom;
        int likeok;
        DateTime letrejott;
        DateTime szerkesztve;

        public string Szerzo
        {
            get
            {
                return szerzo;
            }

           
        }

        public string Tartalom
        {
            get
            {
                return tartalom;
            }

            set
            {
                szerkesztve = DateTime.Now;
                tartalom = value;
            }
        }

        public int Likeok
        {
            get
            {
                return likeok;
            }
        }

        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }          
        }

        public DateTime Szerkesztve
        {
            get
            {
                return szerkesztve;
            }          
        }
        public Bejegyzes(string szerzo, string tartalom)
        {
            likeok = 0;
            letrejott = DateTime.Now;
            this.szerzo = szerzo;
            this.tartalom = tartalom;

        }
        public void Like()
        {
            likeok++;
        }
        public string Kiir()
        {
            //Console.WriteLine(szerzo + " - " + likeok + " - " + letrejott +"\n " +szerkesztve+": szerkesztes \n" +tartalom);
            string s = szerzo + " - " + likeok + " - " + letrejott + "\n " + szerkesztve + ": szerkesztes \n" + tartalom + "\n";

            return s;
        }
    }
}
