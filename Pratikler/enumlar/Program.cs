using System;

namespace enumlar;

class Program
{
    static void Main(string[] args)
    {
    // Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız. Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum'lardan faydalanırız.
    // "enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
        Console.WriteLine(Gunler.pazartesi);
        Console.WriteLine((int)Gunler.cumartesi); // cast ettik ve 6 degeri gelir
        int sicaklik =32;
        if (sicaklik<=(int)HavaDurumu.Normal)
        {
            Console.WriteLine("Disariya cikmak icin havanin isinmasini bekleyin");
        }else if(sicaklik>= (int)HavaDurumu.Sicak)
        {
             Console.WriteLine("Disariya cikmak icin cok sicak bir gun");
        }else if(sicaklik>= (int)HavaDurumu.Normal&&sicaklik<(int)HavaDurumu.Coksicak)
        {
             Console.WriteLine("Hava hala sicak!");
        }

    }
}
enum Gunler
{
    // Aslinda burada numerik tutar
    pazartesi=1,
    sali,
    carsamba,
    persembe,
    // buraya kadar 4'e sayar
    //burada cuma"ya 23 verdigimizda ardisiklik 23'e gore artmaya baslar
    cuma=23,
    cumartesi,
    pazar
}
enum HavaDurumu
{
    Soguk=5,
    Normal=20,
    Sicak=25,
    Coksicak=30
}
