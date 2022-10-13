using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            //{
            //    [Erişim Belirleyici] [Veri Tipi] OzellikAdi; 
            //    [Erişim Belirleyici] [Geri Donus Tipi] OzellikAdi; MetotAdi([Parametre Listesi])
            // {
            //  Metot Komutları   
            // }
            //}

            //Erişim Belirleyiciler
            // * Public (HERYERDEN ERİŞEBİLİR)
            // * Private (SADECE TANIMLADIĞI SINIF İÇERİSİNDE ERİŞİBİLİR)
            // * Internal (SADECE PROJE İÇERİSİNDE ERİŞEBİLİR)
            // * Protected (SADECE SINIF VE KALITIM SINIFLARDA ERİŞİLEBİLİR)

            Calisan calisan1 = new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("************************" );

            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Deniz";
            calisan2.Soyad ="Arda";
            calisan2.No=25646789;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgileri();

             Console.WriteLine("************************" );

            Calisan calisan3 = new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgileri();






        }
    }

    class Calisan 
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
        
        public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }
        
        public Calisan(){}

        public void CalisanBilgileri() 
        {
            Console.WriteLine("Çalışanın Adı:{0}", Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın No:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }

    }
}


