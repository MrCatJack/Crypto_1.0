using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptologia
{
    class RSA
    {
        long p;      //простое число
        long q;      //простое число
        long fi;     //функция Эйлера для p и q
       public long n;      //p*q//вторая часть ключа
       public long e;      //первая часть открытого ключа
       public long d;      //первая часть секретного ключа
        public RSA(long p, long q) //конструктор
        {
            this.p = p;
            this.q = q;
            this.fi = (p - 1) * (q - 1);
            this.n = p * q;           //вторая часть ключа
        }

        private static bool isSimple(long N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делится ли 
            //число на числа до его половины
            for (long i = 2; i < (long)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
        static long NOD(long a, long b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void Nahojdeniye_E()
        {
            for(long i =2; i < this.fi; i++) 
            {
                if (isSimple(i))
                {
                    if (NOD(fi, i) == 1)
                    {
                        this.e = i;            //////e - ключ
                    }
                }
            }
        }
        public void Secret_Gay()
        {
            long d = 1;
            while (((d * this.e) % this.fi) != 1)
            {
                d++;
            }
            this.d = d;
        }

        public string Encrypt(string x)
        {
            Vozvedenie_v_stepen vozv = new Vozvedenie_v_stepen();
            string s = "";
            long[] massiv_intov = new long[x.Split(',').Length];
            for(long i = 0; i < massiv_intov.Length; i++)
            {
                massiv_intov[i] = Convert.ToInt64(x.Split(',')[i]);
                massiv_intov[i] = vozv.Podschet(massiv_intov[i], e , n);
                s += massiv_intov[i]+",";
            }
            Console.WriteLine("fi=" + this.fi);
            Console.WriteLine("e=" + this.e);
            s = s.Substring(0, s.Length - 1);
            return s;
        }
        public string decrypt (string x)
        {
            Vozvedenie_v_stepen vozv = new Vozvedenie_v_stepen();
            string s = "";
            long[] massiv_intov = new long[x.Split(',').Length];
            for (long i = 0; i < massiv_intov.Length; i++)
            {
                massiv_intov[i] = Convert.ToInt64(x.Split(',')[i]);
                massiv_intov[i] = vozv.Podschet(massiv_intov[i], this.d, this.n);
                s += massiv_intov[i] + ",";
            }
            s = s.Substring(0, s.Length - 1);
            return s;
        }



    }
}
