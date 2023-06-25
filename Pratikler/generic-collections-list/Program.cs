using System;
using System.Collections.Generic;

namespace generic_collections_list;

class Program
{
    static void Main(string[] args)
    {
       
       // .NEt platformda kullanıdığımız veri tipleri 2'ye ayrılır. Değer ve referans veri tipleridir. Değer tipleri belliğin stack bölgesinde tutulurken, Referans tipleri belleğin heap bölgesinde tutulur.
       
       // Değer Tipleri: int, long, float, double, decimal, char, bool, byte, short, struct, enum
       
       // Referans Tipleri: string, object, class, interface, array, delegate, pointer
       
       // Bir değer tipinin referans tipine dönüştürülme boxing, tam tersine unboxing işlemi denir.
       
       // Koleksiyonlar verilerini object tipinde tutuyor demiştik. Object de bir referans tipi. Bu demek oluyor ki değer tipinde bir veriyi koleksiyona eklemek istediğimde bir boxing işlemi yapıyorum. Daha sonra elemanı okumak istediğimde de unboxing işlemi yapıyorum. Boxing ve unboxing işlemleri bilgisayar açısından maliyetli bir işlemdir. Koleksiyon içerisindeki eleman sayısının artışına bağlı olarak bu boxing ve unboxing işlemlerinin sayısı artacaktır. Buna bağlı olarakta uygulamanın performansı olumsuz yönde etkilenecektir.

       //List<T> class
       //System.Collections.Generic uzerinden gelir. List dinamik olarak gelisebildiiginden referans tipindedir ve heap"te tutulur.
       // T bunun generic oldugunu ve object turundedir. Hangi tipte bir nesne eklemem gerektigini T belirtir

       List<int> sayiListesi = new List<int>();

       sayiListesi.Add(23);
       sayiListesi.Add(10);
       sayiListesi.Add(4);
       sayiListesi.Add(5);
       sayiListesi.Add(92);
       sayiListesi.Add(34);

       List<string> renkListesi = new List<string>();

       renkListesi.Add("kirmizi");
       renkListesi.Add("mavi");
       renkListesi.Add("turuncu");
       renkListesi.Add("sari");
       renkListesi.Add("yesil");

        //Count
        Console.WriteLine(renkListesi.Count); //Eleman sayisini getirir
        Console.WriteLine(sayiListesi.Count); //Eleman sayisini getirir

        foreach (var item in sayiListesi)
        {
            Console.WriteLine(item);
        }
        sayiListesi.ForEach( sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        // Listeden eleman cikarma
        sayiListesi.Remove(4);
        renkListesi.Remove("yesil");
        sayiListesi.RemoveAt(0); //0"inci indekstekini cikarir

        //Liste icerisinde Arama
        if (sayiListesi.Contains(10))
        {
            Console.WriteLine("10 elemani liste icersinde bulundu");
        }
        // Eleman ile index"e erisme
        renkListesi.BinarySearch("sari"); //eleman adindan index"i getirme

        // Diziyi List"e cevirme
        string[] hayvanlar = {"kedi","kopek", "kus"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi Temizleme
        hayvanListesi.Clear();

        //List uzerinde nesne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Umut";
        kullanici1.Soyisim = "Celikkol";
        kullanici1.Yas = 26;

        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Ayse";
        kullanici2.Soyisim = "Celikkol";
        kullanici2.Yas = 35;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar{
            Isim= "Hasan",
            Soyisim = "Celikkol",
            Yas = 36
        });

        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adi: "+kullanici.Isim);
            Console.WriteLine("Kullanici Soyadi: "+kullanici.Soyisim);
            Console.WriteLine("Kullanici Adi: "+kullanici.Yas);
        }
        kullaniciListesi.Clear(); // Listeyi temizler
    }
    public class Kullanicilar{
        string isim;
        string soyisim;
        int yas;

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
