using System;

namespace Alan_Hesaplama;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geometrik sekli seçiniz:");
        Console.WriteLine("1 - Daire");
        Console.WriteLine("2 - Üçgen");
        Console.WriteLine("3 - Kare");
        Console.WriteLine("4 - Dikdörtgen");

        int sekilSecim = Convert.ToInt32(Console.ReadLine());

        switch (sekilSecim)
        {
            case 1:
                DaireHesapla();
                break;
            case 2:
                UcgenHesapla();
                break;
            case 3:
                KareHesapla();
                break;
            case 4:
                DikdortgenHesapla();
                break;
            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız.");
                break;
        }

        Console.ReadLine();
    }

    static void DaireHesapla()
    {
        Console.WriteLine("Dairenin yarıçapını giriniz:");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz:");
        Console.WriteLine("1 - Çevre");
        Console.WriteLine("2 - Alan");

        int dimensionChoice = Convert.ToInt32(Console.ReadLine());

        switch (dimensionChoice)
        {
            case 1:
                double cevre = 2 * Math.PI * yaricap;
                Console.WriteLine($"Dairenin çevresi: {cevre}");
                break;
            case 2:
                double alan = Math.PI * Math.Pow(yaricap, 2);
                Console.WriteLine($"Dairenin alanı: {alan}");
                break;
            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız.");
                break;
        }
    }

    static void UcgenHesapla()
    {
        Console.WriteLine("Üçgenin birinci kenarını giriniz:");
        double kenar1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Üçgenin ikinci kenarını giriniz:");
        double kenar2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Üçgenin üçüncü kenarını giriniz:");
        double kenar3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz:");
        Console.WriteLine("1 - Çevre");
        Console.WriteLine("2 - Alan");

        int boyutSecim = Convert.ToInt32(Console.ReadLine());

        switch (boyutSecim)
        {
            case 1:
                double cevre = kenar1 + kenar1 + kenar3;
                Console.WriteLine($"Üçgenin çevresi: {cevre}");
                break;
            case 2:
                double yaricevre = (kenar1 + kenar2 + kenar3) / 2;
                double alan = Math.Sqrt(yaricevre * (yaricevre - kenar1) * (yaricevre - kenar2) * (yaricevre - kenar3));
                Console.WriteLine($"Üçgenin alanı: {alan}");
                break;
            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız.");
                break;
        }
    }

    static void KareHesapla()
    {
        Console.WriteLine("Karenin bir kenarını giriniz:");
        double kenar = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz:");
        Console.WriteLine("1 - Çevre");
        Console.WriteLine("2 - Alan");

        int boyutSecim = Convert.ToInt32(Console.ReadLine());

        switch (boyutSecim)
        {
            case 1:
                double cevre = 4 * kenar;
                Console.WriteLine($"Karenin çevresi: {cevre}");
                break;
            case 2:
                double alan = Math.Pow(kenar, 2);
                Console.WriteLine($"Karenin alanı: {alan}");
                break;
            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız.");
                break;
        }
    }

        static void DikdortgenHesapla()
        {
            Console.WriteLine("Dikdörtgenin birinci kenarını giriniz:");
            double kenar1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dikdörtgenin ikinci kenarını giriniz:");
            double kenar2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hesaplamak istediğiniz boyutu seçiniz:");
            Console.WriteLine("1 - Çevre");
            Console.WriteLine("2 - Alan");

            int boyutSecim = Convert.ToInt32(Console.ReadLine());

            switch (boyutSecim)
            {
                case 1:
                    double cevre = 2 * (kenar1 + kenar2);
                    Console.WriteLine($"Dikdörtgenin çevresi: {cevre}");
                    break;
                case 2:
                    double alan = kenar1 * kenar2;
                    Console.WriteLine($"Dikdörtgenin alanı: {alan}");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız.");
                    break;
            }
        }
 }