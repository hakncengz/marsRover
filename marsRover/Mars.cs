using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using marsRover;
namespace marsRover
{
    public class Mars
    {        
        static string boyut;
        static char[] bosluksuzKonum;                  
        public static void Main(string[] args)
        {
            string secim = "";
            Console.WriteLine("");
            Console.WriteLine("Plato Boyutunu giriniz :");
            boyut = Console.ReadLine();           

            do
            {
                Console.WriteLine("Gezici eklemek için 'd' sonuç için 's' çıkmak için 'q' tuşuna basın");
                
                secim = Console.ReadLine();
                if (secim == "d" || secim=="D")
                {
                    Console.Clear();
                    Console.WriteLine("İndirilecek Gezicinin Konumunu Giriniz :");
                    string k_x = Console.ReadLine();
                    Console.WriteLine("Geziciye Verilecek Talimatları Giriniz : ");
                    string talimat = Console.ReadLine();
                    bosluksuzKonum = new char[k_x.Length];
                    marsRover.boslukSil(k_x, bosluksuzKonum);
                    marsRover gezi = new marsRover(bosluksuzKonum, talimat, boyut);                                                            
                }
                if (secim == "s"|| secim=="S")
                {
                    Console.Clear();
                    marsRover.sonucYazdir();
                }
            } while (secim != "q");
        }
    }
}