using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marsRover;
using System.Collections;

namespace marsRover
{
    public class marsRover
    {
        static ArrayList sonuc = new ArrayList();
        static int k_x, k_y, x, y;
        static char yon;
        public marsRover(char[] konumGirdisi, string talimat, string boyut)
        {
            k_x = int.Parse(konumGirdisi[0].ToString());
            k_y = int.Parse(konumGirdisi[1].ToString());
            yon = konumGirdisi[2];
            x = int.Parse(boyut[0].ToString());
            y = int.Parse(boyut[2].ToString());

            for (int i = 0; i < talimat.Length; i++)
            {
                if (talimat[i] == 'l' || talimat[i] == 'L')
                {
                    if (yon == 'n' || yon == 'N')
                    {
                        yon = 'W';
                    }
                    else if (yon == 'w' || yon == 'W')
                    {
                        yon = 'S';
                    }
                    else if (yon == 's' || yon == 'S')
                    {
                        yon = 'E';
                    }
                    else if (yon == 'e' || yon == 'E')
                    {
                        yon = 'N';
                    }
                }
                if (talimat[i] == 'r' || talimat[i] == 'R')
                {
                    if (yon == 'n' || yon == 'N')
                    {
                        yon = 'E';
                    }
                    else if (yon == 'w' || yon == 'W')
                    {
                        yon = 'N';
                    }
                    else if (yon == 's' || yon == 'S')
                    {
                        yon = 'W';
                    }
                    else if (yon == 'e' || yon == 'E')
                    {
                        yon = 'S';
                    }
                }
                if (talimat[i] == 'm' || talimat[i] == 'M')
                {
                    if (yon == 'n' || yon == 'N')
                    {
                        if (y > k_y)
                            k_y += 1;
                    }
                    else if (yon == 'w' || yon == 'W')
                    {
                        if (0 < k_x)
                            k_x -= 1;
                    }
                    else if (yon == 's' || yon == 'S')
                    {
                        if (0 < k_y)
                            k_y -= 1;
                    }
                    else if (yon == 'e' || yon == 'E')
                    {
                        if (x > k_x)
                            k_x += 1;
                    }
                }
            }
            sonuc.Add(k_x);
            sonuc.Add(k_y);
            sonuc.Add(yon);
        }
        public static void sonucYazdir()
        {
            Console.Write("Output : ");
            int sayac = 0;
            for (int i = 0; i < sonuc.Count; i++)
            {
                sayac++;
                Console.Write(sonuc[i] + " ");
                if ((sayac % 3) == 0)
                {
                    Console.WriteLine("");
                }
            }
        }
        public string testSonuc()
        {
            string s = "";
            s += k_x + " " + k_y + " " + yon;
            return s;
        }
        public static void boslukSil(string boslukluKonum, char[] bosluksuzKonum)
        {
            int sayac = 0;
            for (int i = 0; i < boslukluKonum.Length; i++)
            {
                if (boslukluKonum[i] == ' ')
                {
                    sayac++;
                }
                else
                {
                    bosluksuzKonum[i - sayac] = boslukluKonum[i];
                }
            }
        }
    }
}
