using System;
using System.Collections.Generic;
using System.Text;

namespace Proje___2
{
    
    public class Board
    {
        Dictionary<int, string> kisiler = new Dictionary<int, string>();


        List<Kart> TODO = new List<Kart>();
        List<Kart> INPROGRESS = new List<Kart>();
        List<Kart> DONE = new List<Kart>();
        
        public Board()
        {
            
            kisiler.Add(0, "Devrim Mehmet Pattabanoğlu");
            kisiler.Add(1, "Mehmet Alper Sezer");
            kisiler.Add(2, "Mehmet Arslan");
            kisiler.Add(3, "Patika Dev");
            kisiler.Add(4, "Kodluyoruz Org");

            TODO.Add(new Kart("İngilizce Çalış", "Kelime Ezberle", "Devrim Mehmet Pattabanoğlu",Kart.Buyukluk.XL));
            INPROGRESS.Add(new Kart(".NET çalış", "OOP tekrar bak.", "Devrim Mehmet Pattabanoğlu",Kart.Buyukluk.XS));
            DONE.Add(new Kart("C# çalış", "c#101 tekrar izle", "Devrim Mehmet Pattabanoğlu",Kart.Buyukluk.L));
            DONE.Add(new Kart(".Net Başlangıç Seviyesi", "Patika'yı bitir.", "Devrim Mehmet Pattabanoğlu",Kart.Buyukluk.S));
            INPROGRESS.Add(new Kart("Çalış", "Daha çok çalış.", "Devrim Mehmet Pattabanoğlu",Kart.Buyukluk.XL));
           
            
        }
        

        public void KartEkle()
        {
            string baslik;
            string icerik;
            int buyukluk;
            string girilenBuyukluk;
            int kisi;
            string girilenKisi;

            Console.Write("Başlık Giriniz                                   : ");            baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                   : ");            icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)   : ");            girilenBuyukluk = Console.ReadLine();
            Console.Write("Kişinin ID'sini Giriniz                          : ");            girilenKisi=Console.ReadLine();
                try
                {
                     buyukluk = int.Parse(girilenBuyukluk);
                     kisi =int.Parse(girilenKisi);
                     if (kisiler.ContainsKey(kisi) && buyukluk > 0 && buyukluk <= 5)
                     {
                
                        TODO.Add(new Kart(baslik, icerik, kisiler[kisi], (Kart.Buyukluk)buyukluk));
                        Console.WriteLine("Kart Eklendi!");
                        BoardListele();
                        Console.ReadKey();
                        Program.AnasayfaArayuz();
                      
                     }else
                     {
                         Console.WriteLine("Bir hata oluştu Kart Eklenemedi!");
                         Program.AnasayfaArayuz();
                     }
                
                   
                }
                catch (Exception)
                {
                     Console.Clear();
                     Console.WriteLine("Büyüklük yanlış biçimde girildi!");
                     Console.ReadKey();
                     Program.AnasayfaArayuz();
                    
                     
                }
                
        }

        

        public void KartSil()
        {
            string baslik;
            string icerik;

            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçiniz.");
            Console.Write("Lütfen kartın başlığını giriniz :    ");            baslik = Console.ReadLine();
            Console.Write("Lütfen kartın içeriğini yazınız :    ");            icerik = Console.ReadLine();

            bool bulundu = false;
            
            foreach (var kart in TODO.ToArray())
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    TODO.Remove(kart);
                    Console.WriteLine("Kart silindi.(TODO)");
                    bulundu = true;
                    Console.ReadKey();
                    Program.AnasayfaArayuz();
                    
                    
                }
            }

            foreach (var kart in INPROGRESS.ToArray()) 
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    INPROGRESS.Remove(kart);
                    Console.WriteLine("Kart silindi.(INPROGRESS)");
                    bulundu = true;
                    Console.ReadKey();
                    Program.AnasayfaArayuz();
                }
            }

            foreach (var kart in DONE.ToArray())
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    DONE.Remove(kart);
                    Console.WriteLine("Kart silindi.(DONE)");
                    bulundu = true;                   
                    Console.ReadKey();
                    Program.AnasayfaArayuz();
                }
            }

            if (!bulundu)
            {
                int secim;
                Console.WriteLine("Aradiginiz kriterlere uygun kart bulunamadi.");
                Console.WriteLine("* Silmeyi sonlandirmak icin (1)");
                Console.WriteLine("* Yeniden denemek icin (2)");
                secim = int.Parse(Console.ReadLine());
                if (secim == 2)
                {
                    KartSil();   
                }                   
                if(secim==1)
                {
                    Console.WriteLine("Kart silme islemi sonlandi.");
                    Console.ReadKey();
                    Program.AnasayfaArayuz();
                    
                }
                    
            }
           
        }



        private void KartEkle(Kart kart,ref List<Kart> addList,ref List<Kart> deleteList)
        {
            addList.Add(kart);
            deleteList.Remove(kart);
            Console.WriteLine("Tasima islemi basarili!");
        }

        private void KartAra(string baslik,string icerik,ref List<Kart> kartListesi, ref bool bulundu, string listName)
        {
            foreach (var kart in kartListesi.ToArray())
            {
                if (kart.Baslik == baslik && kart.Icerik == icerik)
                {
                    bulundu = true;

                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("Baslik       :   {0}", kart.Baslik);
                    Console.WriteLine("Icerik       :   {0}", kart.Icerik);
                    Console.WriteLine("Atanan Kisi  :   {0}", kart.AtananKisi);
                    Console.WriteLine("Buyukluk     :   {0}", kart.Boyut);
                    Console.WriteLine("Line         :   {0}", listName);
                    Console.WriteLine();
                    Console.WriteLine("Lutfen tasimak istediginiz Line'i secin:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            KartEkle(kart,ref TODO,ref kartListesi);
                            break;
                        case 2:
                            KartEkle(kart, ref INPROGRESS, ref kartListesi);
                            break;
                        case 3:
                            KartEkle(kart, ref DONE, ref kartListesi);
                            break;
                        default:
                            Console.WriteLine("Hatali bir secim yaptiniz!");
                            break;
                    }


                }
            }
        }

        public void KartTasi()
        {
            string baslik;
            string icerik;
            bool bulundu = false;

            Console.WriteLine("Taşımak istediğiniz kartı seçiniz!");
            Console.Write("Lütfen kartın başlığını yazınız:    ");            baslik = Console.ReadLine();
            Console.Write("Lütfen kartın içeriğini yazınız:    ");            icerik = Console.ReadLine();


            KartAra(baslik, icerik,ref TODO,ref bulundu,"TODO");                // ----> yan tafata list isimlerini string olarak gondermemin nedeni
            KartAra(baslik, icerik,ref INPROGRESS,ref bulundu,"INPROGRESS");    // referanslari alindiktan sonra isimlerini yazdirmaya calistigimda
            KartAra(baslik, icerik,ref DONE, ref bulundu,"DONE");               // dogru degerleri vermemesidir. Bu yuzden boyle bisey yaptim.


            if (!bulundu)
            {
                int secim;
                Console.WriteLine("Aradiginiz kriterlere uygun kart bulunamadi.");
                Console.WriteLine("* Tasimayi sonlandirmak icin (1)");
                Console.WriteLine("* Yeniden denemek icin (2)");
                secim = int.Parse(Console.ReadLine());
                 if (secim == 2)
                {
                     KartTasi();   
                }                   
                if(secim==1)
                {
                    Console.WriteLine("Kart Taşıma işlemi Sonlandı.");
                    Console.ReadKey();
                    Program.AnasayfaArayuz();
                    
                }
                    
            }
        }

        public  void BoardListele()
        {
            Console.WriteLine();
            Console.WriteLine("TODO Line \n*****************************");

            foreach (var kart in TODO)
            {
                Console.WriteLine("Başlık       : {0}", kart.Baslik);
                Console.WriteLine("İçerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kişi  : {0}", kart.AtananKisi);
                Console.WriteLine("Büyüklük     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("IN PROGRESS Line \n*****************************");

            foreach (var kart in INPROGRESS)
            {
                Console.WriteLine("Başlık       : {0}", kart.Baslik);
                Console.WriteLine("İçerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kişi  : {0}", kart.AtananKisi);
                Console.WriteLine("Büyüklük     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }

            Console.WriteLine();
            Console.WriteLine("DONE Line \n*****************************");

            foreach (var kart in DONE)
            {
                Console.WriteLine("Başlık       : {0}", kart.Baslik);
                Console.WriteLine("İçerik       : {0}", kart.Icerik);
                Console.WriteLine("Atanan Kişi  : {0}", kart.AtananKisi);
                Console.WriteLine("Büyüklük     : {0}", kart.Boyut);
                Console.WriteLine("-");
            }
            Console.ReadKey();
            Program.AnasayfaArayuz();
            
        }

    }
}