using System;
using System.Collections.Generic;

namespace Proje_1;

public class Rehber
{
    //Rehber Metodlari
    // Kisileri dinamik list tipinde tutalim
    List<Kisi> kisiler;
    public Rehber()
    {
        kisiler = new List<Kisi>(){
            new Kisi("Umut", "Celikkol", "05334365363"),
            new Kisi("Ayse", "Kaya", "05324678935"),
            new Kisi("Ali", "Demir", "05335674563"),
            new Kisi("Hakan", "Atak", "05337643982"),
            new Kisi("Aysu", "Kara", "05329087754")
        }; // yeni ornek liste olusturalim
    }
    public void NumaraKaydet(){
        Console.WriteLine("Lutfen isim giriniz: ");
        string isim = Console.ReadLine();
        Console.WriteLine("Lutfen soyisim giriniz: ");
        string soyisim = Console.ReadLine();
        Console.WriteLine("Lutfen telefon numarasi giriniz: ");
        string telefonNo = Console.ReadLine();

        Kisi yeniKisi = new Kisi(isim,soyisim,telefonNo);
        kisiler.Add(yeniKisi);
        Console.WriteLine("Yeni kisi ve numarasi kaydedildi.");     
    } 
   public void NumaraSil(){
        Console.WriteLine("Lutfen numarasini silmek istediginiz kisinin adini veya soyadini giriniz: ");
        string arananKisi = Console.ReadLine();
        Kisi bulunanKisi = kisiler.Find(kisi => kisi.Isim ==arananKisi || kisi.Soyisim == arananKisi);
        if (bulunanKisi==null)
        {
            Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi.");
        }
        else{
            kisiler.Remove(bulunanKisi);
            Console.WriteLine($"{bulunanKisi.Isim} {bulunanKisi.Soyisim} rehberden silindi.");
        }
   }
    public void NumaraGuncelle(){
        Console.WriteLine("Lutfen numarasini guncellemek istediginiz kisinin adini veya soyadini giriniz: ");
        string arananKisi = Console.ReadLine();
        Kisi bulunanKisi = kisiler.Find(kisi => kisi.Isim == arananKisi|| kisi.Soyisim == arananKisi);
        if (bulunanKisi==null)
        {
            Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi.");
        }
        else
        {
            Console.WriteLine("Yeni telefon numarasi giriniz.");
            string telefonNo = Console.ReadLine();
            bulunanKisi.TelefonNo = telefonNo;
            Console.WriteLine($"{bulunanKisi.Isim} {bulunanKisi.Soyisim} telefon numarasi guncellendi.");
        }

    }   
    public void RehberListele(bool azalanSira){
        kisiler.Sort((k1,k2) => azalanSira ? String.Compare(k2.Isim,k1.Isim) : String.Compare(k1.Isim,k2.Isim)); // kisiler listesini A-Z"ye veya Z-A"ya siralamak icin kullanilan lambda ifadesidir.
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("*******************************************");
        foreach (Kisi kisi in kisiler)
        {
            Console.WriteLine($"Isim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarasi: {kisi.TelefonNo}");
        }
    }
    public void RehberArama(){
        Console.WriteLine("Arama yapmak istediginiz tipi seciniz.");
        Console.WriteLine("*********************************************");    
        Console.WriteLine("Isim veya soyisme gore arama yapmak icin:  (1)");
        Console.WriteLine("Telefon numarasina gore arama yapmak icin: (2)");
        int secim = int.Parse(Console.ReadLine());
        switch (secim)
        {
            case 1:
                Console.WriteLine("Arama yapmak istediginiz isim veya soyismi giriniz: ");
                string arananKisi = Console.ReadLine();
                List<Kisi> bulunanKisiler = kisiler.FindAll(kisi => kisi.Isim.Contains(arananKisi)|| kisi.Soyisim.Contains(arananKisi));
                if(bulunanKisiler.Count == 0)
                {
                    Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi.");
                }
                else{
                    Console.WriteLine("Arama Sonuclariniz:");
                    Console.WriteLine("*********************************************"); 
                    foreach(Kisi kisi in bulunanKisiler){
                        Console.WriteLine($"Isim: {kisi.Isim} Soyisim: {kisi.Soyisim} Telefon Numarasi: {kisi.TelefonNo}");
                    }   

                }
                break;
            case 2:
                Console.WriteLine("Arama yapmak istediginiz telefon numarasini giriniz: ");
                string arananTelefon = Console.ReadLine();
                Kisi bulunanKisi = kisiler.Find(kisi => kisi.TelefonNo == arananTelefon);
                if(bulunanKisi==null)
                {
                    Console.WriteLine("Aradiginiz kriterlere uygun veri rehberde bulunamadi.");
                }
                else{
                    Console.WriteLine("Arama Sonuclariniz:");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine($"Isim: {bulunanKisi.Isim} Soyisim: {bulunanKisi.Soyisim} Telefon Numarasi: {bulunanKisi.TelefonNo}"); 
                }
                break;

            default:
                Console.WriteLine("Gecersiz secim yaptiniz.Tekrar deneyiniz: ");
                break;
            
        }
    }
}
public class Kisi
{
    //Kisilerle ilgili property ve metodlar
    public string Isim { get; set; }
    public string Soyisim { get; set; }
    public string TelefonNo { get; set; }
    public Kisi(string isim, string soyisim, string telefonNo)
    {
        Isim = isim;
        Soyisim = soyisim;
        TelefonNo = telefonNo;
    }
}
class Program
{
    static void Main(string[] args)
    {
         Rehber rehber = new Rehber();

         while (true)
         {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    rehber.NumaraKaydet();
                    break;
                case 2:
                    rehber.NumaraSil();
                    break;
                case 3:
                    rehber.NumaraGuncelle();
                    break;
                case 4:
                    Console.WriteLine("Rehberi hangi sırayla listelemek istersiniz?");
                    Console.WriteLine("A-Z sıralaması için: (1)");
                    Console.WriteLine("Z-A sıralaması için: (2)");
                    int secim2 = int.Parse(Console.ReadLine());
                    bool azalanSira = secim2==2;
                    rehber.RehberListele(azalanSira);
                    break;
                case 5:
                    rehber.RehberArama();
                    break;
                default:
                    Console.WriteLine("Gecersiz secim yaptiniz.Tekrar deneyiniz: ");
                    break;
            }
            Console.WriteLine();

         }
    }
}
