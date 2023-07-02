using System;
using System.IO;
//ATM uygulaması
//Uygulama ilk çalıştığında kullanıcıdan yamak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temem işlemledir. Para çekme, para yatırma, ödeme yapma vs.. İsteğe bağlı olarak genişletilebilir. Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.
//Uygulamada bir de gün sonu seçeneği olmalıdır. Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction ların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

namespace ATM_App;

class Program
{
   
    static void Main(string[] args)
    {
        ATM.GirisYap();
        bool devam = true;
        while (devam)
        {
            Console.WriteLine("\nİşlem Seçin:");
            Console.WriteLine("\n1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Ödeme Yapma");
            Console.WriteLine("4. Gün Sonu Al");
            Console.WriteLine("5. Çıkış Yap");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    ATM.ParaCekmeIslemi();
                    break;
                case "2":
                    ATM.ParaYatirmaIslemi();
                    break;
                case "3":
                    ATM.OdemeYapmaIslemi();
                    break;
                case "4":
                    ATM.GunSonuAl();
                    break;
                case "5":
                    devam =false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz:");
                    break;
            }
        }
    }
    
} 
static class ATM
{
    static string kullaniciAdi = "admin";
    static string kullaniciSifre = "1234";
    static string transactionLogFileName = "transaction_log.txt";
    static string hataliGirisLogFileName = "hatali_giris_log.txt";
    public static void GirisYap()
    {
        Console.WriteLine("Kullanici Adi: ");
        string kullanici = Console.ReadLine();
        Console.WriteLine("Sifre: ");
        string sifre = Console.ReadLine();
        if (kullanici == kullaniciAdi && sifre == kullaniciSifre)
        {
            Console.WriteLine("Giris Basarili");
        }
        else{
            Console.WriteLine("Hatalı kullanıcı adı veya şifre.");
            LogHataliGiris();
            Environment.Exit(0);

        }
    }
    public static void ParaCekmeIslemi()
    {
        // Para çekme işlemi gerçekleştirme
        Console.WriteLine("Para çekme işlemi gerçekleştirildi.");
        LogTransaction("Para Çekme");
    }
    public static void ParaYatirmaIslemi()
    {
        // Para yatırma işlemi gerçekleştirme
        Console.WriteLine("Para yatırma işlemi gerçekleştirildi.");
        LogTransaction("Para Yatırma");
    }
    public static void OdemeYapmaIslemi()
    {
        // Ödeme yapma işlemi gerçekleştirme
        Console.WriteLine("Ödeme yapma işlemi gerçekleştirildi.");
        LogTransaction("Ödeme Yapma");
    }
    public static void GunSonuAl()
    {
        //Transaction loglari okundu.
        string logIcerik = File.ReadAllText(transactionLogFileName);
        Console.WriteLine("\nTransaction Logları:\n" + logIcerik);
        
        //Hatali girislerin loglari okundu.
        string hataliGirisLogIcerik = File.ReadAllText(hataliGirisLogFileName);
        Console.WriteLine("\nHatalı Giriş Logları:\n" + hataliGirisLogIcerik);
        
        
        //Gün sonu alınmak istendiğinde, gün içerisinde yapılan transactionların logları ve  hatalı giriş loglari bu proje dosyasi icerisine EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazildi.
        string eodDosyaAdi = "EODTarih("+ DateTime.Now.ToString("ddMMyyyy") + ").txt";
        File.WriteAllText(eodDosyaAdi, logIcerik);
        Console.WriteLine("\nGün sonu alındı. Transaction logları '" + eodDosyaAdi + "' dosyasına kaydedildi.");
    }
    public static void LogTransaction(string islem)
    {
        string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + islem;
        File.AppendAllText(transactionLogFileName, log + Environment.NewLine);
    }
    public static void LogHataliGiris()
    {
         string log = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Hatalı giriş denemesi";
        File.AppendAllText(hataliGirisLogFileName, log + Environment.NewLine);
    }
}