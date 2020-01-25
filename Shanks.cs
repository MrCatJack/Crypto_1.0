using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptologia
{
    class Shanks
    {
        int a;
        int b;
        public int N;
        int d;
        int r;
        int q;
        int x;
        
        public int Bolshoy_shag(int N)
        {
            int k = N - 1;
            d = Convert.ToInt32(Math.Ceiling(Math.Sqrt(k))); //вычисляем d
            Console.WriteLine("d=" + d);
            return d;
        }
        public int[] Predvichisleniya(int a)
        {
            Console.WriteLine("d="+d);
            int[] tab = new int[d];
            for(int i = 0; i < d; i++)
            {
                tab[i] = Convert.ToInt32(Math.Pow(a, i))%N;
                Console.WriteLine("tab[i]: {0}:{1}",tab[i],i);
            }
            return tab;

        }
        public void Maliy_Shag()
        {
            Vozvedenie_v_stepen vozv = new Vozvedenie_v_stepen();
            int razn = N- 1 - d;
            q = 1;
            long tab2 = vozv.Podschet(a, razn, N);
            long tab3 = (tab2 * b)%N;
            while (q < 100)
            {
                if (Sravneniye(tab3) == false)
                {
                    tab3 = (tab3 * tab2)%N;
                    q++;
                    Console.WriteLine("q=" + q);
                    Console.WriteLine("tab3=" + tab3);
                    Console.WriteLine(d);
                }
                else
                {
                    break;
                }
            }
        }
        public bool Sravneniye(long tab3)
        {
            bool bol=false;
            for (int i = 0; i < Predvichisleniya(a).Length; i++)
            {
                if (Predvichisleniya(a)[i] == tab3)
                {
                    this.r = i;
                    Console.WriteLine("hui"+r);
                    bol = true;
                    break;
                }
                else
                {
                    bol = false;
                }
            }
            return bol;

        }
        public int Rezultat(int a, int b, int p)
        {
            this.a = a;
            this.b = b;
            this.N = p;

            Bolshoy_shag(p);
            Predvichisleniya(a);
            Maliy_Shag();
            Console.WriteLine("x=(d*q)+r\n{0}=({1}*{2})+{3}",x,d,q,r);
            x = (d * q) + r;
            return x;
        }
        public Shanks()
        {

        }
    }
}
