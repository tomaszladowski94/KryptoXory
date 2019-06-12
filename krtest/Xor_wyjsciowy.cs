using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krtest
{
    class Xor_wyjsciowy
    {
        int nr;
        public List<int> xor_wejsciowy;
        List<int> liczba1;
        List<int> liczba2;
        public List<int> liczba_wejsciowa_S1E;
        public List<int> xory_wejsciowe_przyklad4;
        public Xor_wyjsciowy(int nr)
        {
            this.nr = nr;
            xor_wejsciowy = new List<int>();
            liczba1 = new List<int>();
            liczba2 = new List<int>();
            liczba_wejsciowa_S1E = new List<int>();
            xory_wejsciowe_przyklad4 = new List<int>();
        }
        public void dodaj_wejsciowy(int value)
        {
            xor_wejsciowy.Add(value);
        }
        public void dodaj_liczbe1(int v)
        {
            liczba1.Add(v);
        }
        public void dodaj_liczbe2(int v)
        {
            liczba2.Add(v);
        }
        public void wypisz(int i)
        {
            Console.Write("xor wejsciowy:" + xor_wejsciowy[i] + " liczba 1:" + liczba1[i] + " liczba 2:" + liczba2[i] + "\n");
        }
        public void test()
        {
            for(int i=0;i<64;i++)
            {
                for(int j=0;j<64;j++)
                {
                    int liczba1_loc = i;
                    int liczba2_loc = j;
                    int xor_wejsciowy_loc = i ^ j;
                    for(int z=0;z<xor_wejsciowy.Count;z++)
                    {
                        if(xor_wejsciowy[z]==xor_wejsciowy_loc)
                        {
                            liczba_wejsciowa_S1E.Add(liczba1[z]);
                            xory_wejsciowe_przyklad4.Add(liczba1_loc);
                        }
                    }
                }
            }
        }
    }
}
