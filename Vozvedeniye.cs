using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptologia
{
    class Vozvedeniye 
    {
        public Vozvedeniye() { }
        public Vozvedeniye(int a,int x,int p)
        {
            this.Result = ResulT(a, x, p);
        }
        int a; public int A { get { return a; } set { a = value; } }
        string x; public string X { get { return Convert.ToString(Convert.ToInt32(x), 10); }set { x = reversStr(Convert.ToString(Convert.ToInt32(value), 2)); } }
        int p; public int P { get { return p; } set { p = value; } }
        public int Result=1;
        int[] mass = new int[12]; public int[] Mass { get { return mass; } }

        public string reversStr(string str)
        {
            string s = String.Empty;
            for(int i = 0; i < str.Length ; i++)
            {
                s = s.Insert(0,Convert.ToString(str[i]));
            }
            return s;
        }
        public void supStep()
        {
            mass[0] = a % p;
            for(int i = 1; i < mass.Length; i++)
            {
                mass[i] = (mass[i - 1]*mass[i-1]) % p;
            }
        }
        public void steps()
        {
            int y = 1;
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] == '1') { y = (y * mass[i]) % p; }
            }
            Result = y;
        }
        public int ResulT(int a,int x, int p)
        {
            this.a = a; this.x = reversStr(Convert.ToString(x, 2)); this.p = p;
            supStep(); steps();
            return Result;
        }
        public string OutPut(int[] mass)
        {
            string s = "";
            foreach(int m in mass)
            {
                s += Convert.ToString(m) + "; ";
            }
            return s;
        }
        public int vozvStep(int a, int x)
        {
            int v = a;
            if (x != 0)
            {
                for (int i = 1; i < x; i++)
                {
                    a *= v;
                }
            }
            else { a = 1; }
            return a;
        }
    }
}
