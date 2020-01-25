using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptologia
{
    class Vozvedenie_v_stepen
    {
        long chislo;
        long stepen;
        long mod;
        public long[] tablica = new long[20];
        public long result;

        public void Sostavleniye_tablici()
        {
            tablica[0] = (chislo);
            for (int i = 1; i <20; i++)
            {
                tablica[i] = (tablica[i-1]*tablica[i-1])% mod;
            }
        }
        public string Vivod_massiva(long[] tablica)
        {
            string vivod = string.Empty;
            int i=0;
            int n = 1;
            foreach(long m in tablica)
            {
                vivod += "Остаток от a^"+n+":  "+ m + "; "+"\n";
                i++;
                n = 2 * n;
                Console.WriteLine("i=" + i);
                Console.WriteLine("m=" + m);
            }
            return vivod;
        }

        public Vozvedenie_v_stepen(long chislo, long stepen, long mod)
        {
            result = Podschet(chislo, stepen,  mod);
        }

        public Vozvedenie_v_stepen()
        {

        }

        public string perevod()
        {
            string s = Convert.ToString(stepen, 2);

            string perevorot = "";

            foreach(char ci in s)
            {
                perevorot = ci + perevorot;
            }
            Console.WriteLine(s);
            Console.WriteLine(perevorot);
            return perevorot;
        }
        public long Podschet(long chislo, long stepen, long mod)
        {
            this.chislo = chislo;
            this.stepen = stepen;
            this.mod = mod;
            Sostavleniye_tablici();
            perevod();
            long resultat = 1;
            for(int i = 0; i<perevod().Length; i++)
            {
                if (perevod()[i] == '1')
                {
                    resultat = (resultat * tablica[i]) % mod;
                }
            }
            return resultat;
        }
    }
}
