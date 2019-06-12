using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krtest
{
    class Inicjalizacja
    {
        public Xor_wyjsciowy[] xw;
        int[] kolejnosc_pol;
        int[] s1;
        public Inicjalizacja()
        {
            xw = new Xor_wyjsciowy[64];
            kolejnosc_pol = new int[64];
            kolejnosc_pol = uzupelnianie_kolejnosc_pol();

            s1 = new int[64];
            s1 = uzupelnianie_s1();

            int[,] wynikowa = new int[64, 16];
            wynikowa = xorowanie(kolejnosc_pol, s1);
            pary_wejsciowe(kolejnosc_pol,s1);
            
            //Console.ReadLine();
        }
        int[] uzupelnianie_kolejnosc_pol()
        {
            int[] kolejnosc_pol = new int[64];

            int wpisz = 0;
            for (int i = 0; i < 16; i++)
            {
                kolejnosc_pol[i] = wpisz;
                wpisz = wpisz + 2;
            }

            wpisz = 1;
            for (int i = 16; i < 32; i++)
            {
                kolejnosc_pol[i] = wpisz;
                wpisz = wpisz + 2;
            }

            wpisz = 32;
            for (int i = 32; i < 48; i++)
            {
                kolejnosc_pol[i] = wpisz;
                wpisz = wpisz + 2;
            }

            wpisz = 33;
            for (int i = 48; i < 64; i++)
            {
                kolejnosc_pol[i] = wpisz;
                wpisz = wpisz + 2;
            }

            return kolejnosc_pol;
        }
        int[] uzupelnianie_s1()
        {
            int[] s1 = new int[64] {
                14, 4, 13, 1, 2, 15, 11, 8,
                3, 10, 6, 12, 5, 9, 0, 7,
                0, 15, 7, 4, 14, 2, 13, 1,
                10, 6, 12, 11, 9, 5, 3, 8,
                4, 1, 14, 8, 13, 6, 2, 11,
                15, 12, 9, 7, 3, 10, 5, 0,
                15, 12, 8, 2, 4, 9, 1, 7,
                5, 11, 3, 14, 10, 0, 6, 13 };

            return s1;
        }
        int[,] xorowanie(int[] kolejnosc_pol, int[] s1)
        {
            int[,] wynikowa = new int[64, 16];
            int xor_wiersz, xor_kolumna;

            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    {
                        xor_wiersz = kolejnosc_pol[i] ^ kolejnosc_pol[j];
                        xor_kolumna = s1[i] ^ s1[j];

                        wynikowa[xor_wiersz, xor_kolumna] = wynikowa[xor_wiersz, xor_kolumna] + 1;
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.Out.Write(i + ": ");
                for (int j = 0; j < 16; j++)
                {
                    Console.Out.Write(wynikowa[i, j] + " ");
                }
                Console.Out.WriteLine();
            }
            Console.Out.WriteLine();

            for (int i = 16; i < 32; i++)
            {
                Console.Out.Write(i + ": ");
                for (int j = 0; j < 16; j++)
                {
                    Console.Out.Write(wynikowa[i, j] + " ");
                }
                Console.Out.WriteLine();
            }
            Console.Out.WriteLine();

            for (int i = 32; i < 48; i++)
            {
                Console.Out.Write(i + ": ");
                for (int j = 0; j < 16; j++)
                {
                    Console.Out.Write(wynikowa[i, j] + " ");
                }
                Console.Out.WriteLine();
            }
            Console.Out.WriteLine();

            for (int i = 48; i < 64; i++)
            {
                Console.Out.Write(i + ": ");
                for (int j = 0; j < 16; j++)
                {
                    Console.Out.Write(wynikowa[i, j] + " ");
                }
                Console.Out.WriteLine();
            }
            Console.Out.WriteLine();

            return wynikowa;
        }
        void pary_wejsciowe(int[] kolejnosc_pol, int[] s1)
        {
            int xor_wej;
            int[] wynikowa = new int[16];
            int xor_wiersz, xor_kolumna;

            //Console.WriteLine("Xor wyjściowy:\tLiczba 1\tLiczba2");
            for (int z = 0; z < 64; z++)
            {
                xw[z] = new Xor_wyjsciowy(z);
                xor_wej = z;
                for (int i = 0; i < 64; i++)
                {
                    for (int j = 0; j < 64; j++)
                    {
                        {
                            xor_wiersz = kolejnosc_pol[i] ^ kolejnosc_pol[j];
                            xor_kolumna = s1[i] ^ s1[j];
                            if (xor_wiersz == xor_wej)
                            {
                                wynikowa[xor_kolumna] = wynikowa[xor_kolumna] + 1;
                                //Console.WriteLine("dla " + z);
                                //Console.Write(xor_kolumna + "\t\t" + kolejnosc_pol[i].ToString() + "\t\t" + kolejnosc_pol[j].ToString());
                                //Console.WriteLine();
                                xw[z].dodaj_wejsciowy(xor_kolumna);
                                xw[z].dodaj_liczbe1(kolejnosc_pol[i]);
                                xw[z].dodaj_liczbe2(kolejnosc_pol[j]);
                            }
                        }
                    }
                }
            }



        }
    }
}
