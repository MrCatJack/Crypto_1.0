using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptologia
{
    class Polig_Hellman
    {
        public long ogranicheniya;
        long resultatik;
        public long[] Razlojeniye;
        long a; long b; long p;    //a-то что возводим в степень  b- сравнение, р - модуль сравнения

        public void Pazlojeniye(long p)
        {
            long[] razlojeniye = new long[ogranicheniya];
            int schetchik = 1;
            for (int i = 2; i < ogranicheniya; i++)
            {
                if (p % i == 0)
                {
                    while (p % i == 0)
                    {
                        p = p / i;
                        razlojeniye[schetchik] = i;
                        schetchik++;
                    }
                }
            }
            string itog_razl = "";
            int kolvo = 0;
            for (int m = 0; m < razlojeniye.Length; m++)
            {
                if (razlojeniye[m] != 0)
                {
                    itog_razl = itog_razl + razlojeniye[m] + ";";
                    kolvo++;
                }
            }
            long[] massiv_razl = new long[kolvo];
            for (int k = 0; k < kolvo; k++)
            {
                massiv_razl[k] = Convert.ToInt64(itog_razl.Split(';')[k]);
            }
            Razlojeniye = massiv_razl;
        }
        public List<long> kolvostepenei()
        {
            int a = 0;
            int k = 0;
            List<long> stepeni = new List<long>();
            stepeni.Add(Razlojeniye[0]);
            for (int i = 0; i < Razlojeniye.Length; i++)
            {
                if (stepeni[a] == Razlojeniye[i])
                {
                    k++;
                }
                else
                {
                    stepeni.Insert(a + 1, k);
                    a += 2;
                    stepeni.Insert(a, Razlojeniye[i]);
                    k = 1;
                }
            }
            stepeni.Insert(a + 1, k);

            return stepeni;
        }
        public List<long> Tablica(long z)
        {
            Vozvedenie_v_stepen vozv = new Vozvedenie_v_stepen();
            List<long> tab = new List<long>();
            int i = 1;
            long C = vozv.Podschet(a, ((p - 1) / z), p);
            tab.Add(1);
            tab.Add(C);
            while (tab[i] != 1)
            {
                tab.Insert(i + 1,(C * tab[i]) % p);
                i++;
            }
            return tab;
        }
        public long[] Poisk_massiv_j(long del, long step)
        {
            Vozvedenie_v_stepen vozv = new Vozvedenie_v_stepen();
            long[] j = new long[step];
            j[0] = Tablica(del).IndexOf(vozv.Podschet(b, ((p - 1) / del), p));
            for (int i = 1; i < step; i++)
            {
                j[i] = Tablica(del).IndexOf(vozv.Podschet(b /Na_chto_delit(i,j,del), ((p - 1) / del), p));
            }
            return j;
        }
        public long Na_chto_delit(long nomer_schetchika, long[]j,long del)
        {
            long na_chto_del;
            Vozvedenie_v_stepen vozv = new Vozvedenie_v_stepen();
            na_chto_del = vozv.Podschet(a, j[0], p);
            for(int i = 1; i < nomer_schetchika; i++)
            {
                na_chto_del = (na_chto_del * vozv.Podschet(a, j[i] * Convert.ToInt64((Math.Pow(del, i))), p))%p;
            }
            return na_chto_del;
        }
        public long Sborka(long[] mass_j,long del,long stepen_delitelya)
        {
            long x = 1;
            for(int i =1; i < stepen_delitelya; i++)
            {
                x += mass_j[i] * Convert.ToInt64(Math.Pow(del, i));
            }
            return x;
        }
        
        public long[] Sobiratel_x()
        {
            List<long> kolvoStipenei = kolvostepenei();
            long[] Iksi_I_deliteli = new long[PodschetElementov_vListe(kolvoStipenei)]; 

            for(int i = 0; i < PodschetElementov_vListe(kolvoStipenei) ;i+=2)
            {
                Iksi_I_deliteli[i] = Sborka(Poisk_massiv_j(kolvoStipenei[i], kolvoStipenei[i + 1]),kolvoStipenei[i], kolvoStipenei[i + 1]);
                Iksi_I_deliteli[i + 1] = Convert.ToInt64(Math.Pow(kolvoStipenei[i], kolvoStipenei[i + 1]));
            }
            return Iksi_I_deliteli;
        }
        public int PodschetElementov_vListe(List<long> listik)
        {
            int n = 0;
            foreach(long z in listik)
            {
                n++;
            }
            return n;
        }
        public long Result(long[] Iksidelit)
        {
            long NOK=1;
            for (int i = 1; i < Iksidelit.Length; i += 2)
            {
                NOK = NOK * Iksidelit[i];
            }
            long z = 0;
            for(int j = 1; j < Iksidelit.Length; j+=2)
            {
                long domnojitel = NOK / Iksidelit[j]; long zz = domnojitel% Iksidelit[j];
                long beach=1;
                Console.WriteLine(vivodlista(Iksidelit));
                while(zz!= Iksidelit[j - 1])
                {
                    beach++;
                    zz = (zz + zz)% Iksidelit[j];
                    if (beach == 300)
                    {
                        Console.WriteLine("ti dawn?");
                        break;
                    }
                }
                z += domnojitel * beach;

            }
            return z;
        }
        public string vivodlista(long[] list)
        {
            string s = string.Empty;
            foreach(long p in list)
            {
                s += p + ";";
            }
            return s;
        }
        public Polig_Hellman(long a,long b,long p)// Вызов сборки
        {
            
            resultatik=sborshik(a, b, p);
            
        }
        public Polig_Hellman()
        {

        }
        public long sborshik(long a, long b, long p)
        {
            Konstruct(a,b,p);
            Pazlojeniye(p - 1);
            resultatik = Result(Sobiratel_x());
            return Result(Sobiratel_x());
        }
        public void Konstruct(long a,long b,long p)
        {
            this.a = a;
            this.b = b;
            this.p = p;
        }
    }
}
