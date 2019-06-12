using System;
using System.Collections.Generic;

namespace krtest
{
    class Program
    {

        static void Main(string[] args)
        {
            Inicjalizacja I = new Inicjalizacja();
            int it = 0;
            Console.ReadLine();
            foreach(Xor_wyjsciowy x in I.xw)
            {
                Console.WriteLine("XOR WYJSCIOWY " + it);
                it++;
                for(int i=0;i<x.xor_wejsciowy.Count;i++)
                {
                    x.wypisz(i);
                }
            }
            it = 0;

            List<int> potencjalne_klucze = new List<int>();
            //int x1 = 22 ^ 1;
            //Console.WriteLine(x1);
            foreach (Xor_wyjsciowy x in I.xw)
            {
                x.test();
                for(int i=0;i<x.xory_wejsciowe_przyklad4.Count;i++)
                {
                    int klucz = x.liczba_wejsciowa_S1E[i] ^ x.xory_wejsciowe_przyklad4[i];
                    potencjalne_klucze.Add(klucz);
                }
            }
            Console.WriteLine("potencjalne klucze: ");
            for (int i = 0; i < potencjalne_klucze.Count; i++)
            {
                Console.Write(potencjalne_klucze[i] + ", ");
            }
            Console.ReadLine();
            int[] key = new int[64];
            for(int i =0;i<63;i++)
            {
                key[i] = 0;
            }
            for(int i=0;i<63;i++)
            {
                foreach(int j in potencjalne_klucze)
                {
                    if(j==i)
                    {
                        key[i]++;
                    }

                }
            }
            int max = 0;
            int maxi = 0;
            for (int i = 0; i < key.Length; i++)
            {
                
                if (key[i] > max)
                {
                    max = key[i];
                    maxi = i;
                }
            }

            Console.WriteLine("KLUCZ: " + maxi);
                Console.ReadLine();
        }
        
            //1 tabela wszystkich mozliwych 0-63
            //xor kazdego z kazdym i patrzy wynik 1
            //sbok 1 i kazde z kazdym to co w 1 tabeli
            //xor i wynik 2
            //punkty 1 i 2 do tabeli wynikowej x | y
            //sie zrobi xD

        
    }
}
