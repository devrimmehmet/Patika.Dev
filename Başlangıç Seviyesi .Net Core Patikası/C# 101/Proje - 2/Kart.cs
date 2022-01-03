using System;
using System.Collections.Generic;
using System.Text;

namespace Proje___2
{
    public class Kart
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string AtananKisi { get; set; }
        public Buyukluk Boyut { get; set; }

        public enum Buyukluk
        {
            XS,
            S,
            M,
            L,
            XL
        } 

        public Kart(string baslik,string icerik,string atananKisi,Buyukluk boyut)
        {
            Baslik = baslik;
            Icerik = icerik;
            AtananKisi = atananKisi;
            Boyut = boyut;
            
        }


    }
}