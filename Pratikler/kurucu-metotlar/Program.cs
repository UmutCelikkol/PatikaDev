using System;
namespace kurucu_metotlar;

class Program
{
    static void Main(string[] args)
    {
         // Constructor Kavramı
         // Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
         // Kurucu metot tanımlarken dikkat edilmesi gereken noktalar ise şu şekildedir:
         // Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
         // Public olarak bildirilmeleri gerekir.
         // Geri dönüş değerleri yoktur.
         // Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz. Metotları anlatırken aşırı yüklemeden bahsetmiştik. (Bkz: Metotların Aşırı Yüklenmesi)
         // Varsayılan Kurucu Metot
         // Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.
         // Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.

        Calisan calisan1 = new Calisan("Ayse","Kara", 12312412, "Insan Kaynaklari"); //Constructor ile instance aldik
        Calisan calisan2 = new Calisan(){
            Ad = "Deniz",
            Soyad = "Arda",
            No = 23353255,
            Departman = "Yazilim"
         };
        Calisan calisan3 =new Calisan("Umut", "Celikkol");
        calisan1.CalisanBilgiler();
        Console.WriteLine("*******************************************");
        calisan2.CalisanBilgiler();
        Console.WriteLine("*******************************************");
        calisan3.CalisanBilgiler();


    }
}

class Calisan
{
    public string Ad; //Fieldlar
    public  string Soyad;
    public int No;
    public string Departman;
    //Kurucu Fonksiyon, Overload edilebilir
    public Calisan(string ad, string soyad, int no, string departman){
        this.Ad =ad;
        this.Soyad =soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan(string ad, string soyad){
        this.Ad =ad;
        this.Soyad =soyad;
    }
    public Calisan(){}
    public void CalisanBilgiler(){ //Metotlar
        Console.WriteLine("Calisan Adi:{0}",Ad);
        Console.WriteLine("Calisan Soyadi:{0}",Soyad);
        Console.WriteLine("Calisan Numarasi:{0}",No);
        Console.WriteLine("Calisan Departmani:{0}",Departman);

    }

    
}
