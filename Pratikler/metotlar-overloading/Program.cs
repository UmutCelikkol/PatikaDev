using System;

namespace metotlar_overloading;

class Program
{
    static void Main(string[] args)
    {
        //out parametreler

        string sayi = "999";
        bool sonuc = int.TryParse(sayi,out int outsayi); // parse dene, eger oluyorsa int sayi olarak cikar
        if (sonuc)
        {
            Console.WriteLine("Basarili!");
            Console.WriteLine(outsayi);
        }else
        {
            Console.WriteLine("Basarisiz!");
        }

        Metotlar instance = new Metotlar();
        instance.Topla(2,3,out int toplamSonuc);
        Console.WriteLine(toplamSonuc);

        //Metot Overloading
        int ifade = 999;
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Umut","Celikkol");

        //Metot Imzasi 
        //MetotAdi + parametreSayisi + parametre tipi 

    }
}

class Metotlar 
{
    public void Topla(int a, int b, out int toplam){
        toplam = a+b;
    }
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(int veri){ // bu metodun hem string hem int tipinde parametre alan karsiligi var yani overload ettik.
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(string veri1,string veri2){
        Console.WriteLine(veri1+veri2);
    }
}
