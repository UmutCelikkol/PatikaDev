using System;

namespace static_sinif_ve_uyeler;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calisan sayisi:{0}",Calisan.CalisanSayisi); //Bir sınıfın static olamayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.

        Calisan calisan1 = new Calisan("Ayse","Yilmaz","Yazilim");
        Console.WriteLine("Calisan sayisi:{0}",Calisan.CalisanSayisi);

        //Static sinifa erisim
        Console.WriteLine("Toplama islemi sonucu {0}", Islemler.Topla(100,200));
        Console.WriteLine("Cikarma islemi sonucu {0}", Islemler.Cikar(300,400));


    }
}

class Calisan
{

    private static int calisanSayisi; // static olmayan sinif icersindeki static uyeler sinif bazinda atanir.
    private string isim;
    private string soyisim;
    private string departman;
    public static int CalisanSayisi { get => calisanSayisi; }

    public Calisan(string isim,string soyisim,string departman){
        this.isim =isim;
        this.soyisim =soyisim;
        this.departman=departman;
        calisanSayisi ++;
    }
    //Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz. Sınıfın static üyelerinin başlangıç değerlerini static kurucular aracılığıyla yapabiliriz. Parametre almazlar ve erişim belirleyicileri yoktur.
    static Calisan(){ // Static constructorlarin public gibi erisim beliteci olmaz.
        calisanSayisi = 0; // baslangicta 0 olsun. her zaman o sinif ilk cagrildiginda static constructor bir kere calisir.
    }
}
// Static elemanlar yazacaksak static class"lar altinda toplamak faydali olacaktir
// Static siniflar da static olmayan uyeler kullanilamaz
static class Islemler 
{
    public static long Topla(int sayi1, int sayi2){
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1, int sayi2){
        return sayi1-sayi2;
    }
}
