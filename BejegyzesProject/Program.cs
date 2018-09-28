using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Program
    {
        static Random R = new Random();

        static void Main(string[] args)
        {
            List<Bejegyzes> lista1 = new List<Bejegyzes>();
            lista1.Add(new Bejegyzes("Kiss Jani", "asdasd"));
            lista1.Add(new Bejegyzes("Pici Laci", "asdasd"));

            Console.WriteLine("Kérek egy darabszámot!");

            int szam1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szam1; i++)
            {
                Console.WriteLine("adj egy szerzőt!");
                string szerzo = Console.ReadLine();
                Console.WriteLine("adj egy tartalmat!");
                string tartalom = Console.ReadLine();

                
                lista1.Add(new Bejegyzes(szerzo, tartalom));
            }
            int szamlike = lista1.Count *20;
            for (int i = 0; i < szamlike; i++)
            {
                int sorszam = R.Next(0, lista1.Count);
                lista1[sorszam].Like();

            }
            
            Console.WriteLine("Kérem módosítsa a 2. bejegyzést!!!"+ lista1[1].Tartalom);
            lista1[1].Tartalom = Console.ReadLine();

            Console.WriteLine(lista1[1].Kiir());

            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i].Kiir());
            }


            int nagy = lista1[0].Likeok;
            for (int i = 1; i < lista1.Count; i++)
            {
                
                if (nagy <lista1[i].Likeok)
                {
                    nagy = lista1[i].Likeok;
                }

                
            }

            Console.WriteLine(nagy);

            int vane = 35;
            for (int i = 0; i < lista1.Count; i++)
            {

                if (vane < lista1[i].Likeok)
                {
                    Console.WriteLine("van");
                }
                else {
                    Console.WriteLine("nincs");
                }
                
            }

            /*int lel = 0;
            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[0].Likeok < lista1[i].Likeok)
                {
                    lel = lista1[i].Likeok;
                    Console.WriteLine("VAN");
                }
               

            }
            */
            Console.ReadKey();
        }
    }
}
