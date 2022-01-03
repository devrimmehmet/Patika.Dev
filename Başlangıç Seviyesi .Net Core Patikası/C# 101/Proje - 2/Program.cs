using System;
using System.Collections.Generic;

namespace Proje___2
{
    class Program
    {
        public static int start=0;
        static void Main(string[] args)
        {   AnasayfaArayuz();     
            AnaSayfa();
        }
   
        public static void AnaSayfa()
        {       
                
           
           
            Board board = new Board(); 
            while (true)
            {
                int secim=Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1: // Board Listele
                        board.BoardListele();
                        AnasayfaArayuz();
                        break;
                    case 2: // Board'a Kart Eklemek
                        board.KartEkle();
                        AnasayfaArayuz();                       
                        break;
                    case 3: // Board'dan Kart Silmek
                        board.KartSil();
                        AnasayfaArayuz();
                        break;
                    case 4: // Kart Taşımak
                        board.KartTasi();
                        AnasayfaArayuz();
                        break;
                        default:
                        AnasayfaArayuz();
                        break;
                }
            }
        }
        public static void AnasayfaArayuz()
        {
            Console.Clear();            
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");       
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }   
    }
}