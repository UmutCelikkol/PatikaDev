using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje_2;
// TODO Uygulamasi
public enum KartBuyuklugu
{
    XS = 1,
    S =2,
    M=3,
    L=4,
    XL=5
}
public class Kart
{
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public int AtananKisi { get; set; }
    public KartBuyuklugu Buyukluk { get; set; }         
}
public class ToDoUygulamasi
{
    private Dictionary<int,string> takimUyeleri;
    private Dictionary<string,List<Kart>> board;
    public ToDoUygulamasi()
    {
        //varsayilan takim uyesi olusturma
        takimUyeleri = new Dictionary<int, string>(){
            {1, "Umut"},
            {2, "Ayse"},
            {3, "Hakan"},
            {4, "Cagla"},
        };
        //varsayilan board ve kartlar olusturma
        board = new Dictionary<string, List<Kart>>(){
            {
                "TODO Line", new List<Kart>{
                    new Kart{
                        Baslik = "Yemek Karti",
                        Icerik = "Yemek Kartina gore atanan kisi yemek yapacaktir.",
                        AtananKisi = 1,
                        Buyukluk = KartBuyuklugu.S
                    }, 
                    new Kart{
                        Baslik = "Temizlik Karti",
                        Icerik = "Temizlik Kartina gore atanan kisi temizlik yapacaktir.",
                        AtananKisi = 2,
                        Buyukluk = KartBuyuklugu.M
                    }
                }
            },
            {
                "IN PROGRESS Line", new List<Kart>{
                    new Kart{
                        Baslik = "Spor Karti",
                        Icerik = "Spor Kartina gore atanan kisi spor yapacaktir.",
                        AtananKisi = 3,
                        Buyukluk = KartBuyuklugu.L
                    }
                }
            },
            {
                "DONE Line", new List<Kart>()
            }
        };

    }
    public void Baslat(){
        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("***************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            int secim =int.Parse(Console.ReadLine());
            if(secim != null){
                switch (secim)
                {   
                    case 1:
                        BoardListele();
                        break;
                    case 2:
                        KartEkle();
                        break;
                    case 3:
                        KartSil();
                        break;
                    case 4:
                        KartTasi();
                        break;
                    default:
                        Console.WriteLine("Hatali bir secim yaptiniz!");
                        break;
                }
            }else{
                Console.WriteLine("Hatali bir secim yaptiniz!");
            }
        }        
    }
    private void BoardListele(){
        foreach (var item in board)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine("*****************************************");
            foreach (var kart in item.Value)
            {
                Console.WriteLine("Baslik         : "+kart.Baslik);
                Console.WriteLine("Icerik         : "+kart.Icerik);
                Console.WriteLine("Atanan Kisi    : "+takimUyeleri[kart.AtananKisi]);
                Console.WriteLine("Buyukluk       : "+kart.Buyukluk);
                Console.WriteLine("-");
            }
            Console.WriteLine();
        }
    }
    private void KartEkle(){
        Console.WriteLine("Baslik Giriniz                                     :");
        string baslik = Console.ReadLine();
        Console.WriteLine("Icerik Giriniz                                     :");
        string icerik = Console.ReadLine();
        Console.WriteLine("Buyukluk Seciniz -> XS(1), S(2), M(3), L(4), XL(5) :");
        int buyuklukSecim;
        if (!int.TryParse(Console.ReadLine(),out buyuklukSecim)|| !Enum.IsDefined(typeof(KartBuyuklugu),buyuklukSecim)) // burasi kullanıcının girdiği buyukluk değerini bir tamsayıya dönüştürmeye çalışır ve ardından bu değerin KartBuyuklugu enum tipinde tanımlanmış bir değer olup olmadığını kontrol eder.
        {
            Console.WriteLine("Hatali girisler yaptiniz!");
            return;
        }
        Console.WriteLine("Kisi Seciniz                                       :");
        int atananKisi;
        if(!int.TryParse(Console.ReadLine(),out atananKisi)|| !takimUyeleri.ContainsKey(atananKisi))
        {
            Console.WriteLine("Hatali girisler yaptiniz!");
            return;
        }
        var yeniKart = new Kart{
            Baslik= baslik,
            Icerik= icerik,
            AtananKisi = atananKisi,
            Buyukluk = (KartBuyuklugu)buyuklukSecim
        };

        board["TODO Line"].Add(yeniKart);
        Console.WriteLine("Kart basariyla eklendi!");
    }
    private void KartSil(){
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:");
        string baslik = Console.ReadLine();
        bool kartSilindi = false;
        foreach (var item in board)
        {
            var kart =item.Value.Find(kart => kart.Baslik == baslik);
            if(kart != null){
                item.Value.Remove(kart);
                Console.WriteLine("Kart basariyla silindi");
                kartSilindi = true; //Kart silindi diye check ediyoruz
            }
            if (!kartSilindi)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int secim;
                if (int.TryParse(Console.ReadLine(), out secim))
                {
                    switch (secim)
                    {
                        case 1:
                            return;
                        case 2:
                            KartSil();
                            return;
                        default:
                            Console.WriteLine("Hatali bir secim yaptiniz!");
                            return;
                    }
                }else {
                    Console.WriteLine("Hatali bir secim yaptiniz!");
                    return;
                }
            
            }
        }
    }
    private void KartTasi(){
        Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:");
        string baslik = Console.ReadLine();
        Kart secilenKart = null;

        foreach (var item in board)
        {
            secilenKart = item.Value.Find(kart => kart.Baslik == baslik);
            if (secilenKart !=null)
            {
                break;
            }
        }
        if (secilenKart ==null)
        {
            Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için : (2)");
            int secim;
            if (int.TryParse(Console.ReadLine(), out secim))
            {
                switch (secim)
                {
                    case 1:
                        return;
                    case 2:
                        KartTasi();
                        return;
                    default:
                        Console.WriteLine("Hatali bir secim yaptiniz!");
                        return;
                }
            }
            else{
                Console.WriteLine("Hatali bir secim yaptiniz!");
                return;
            }
        }
        Console.WriteLine("Bulunan Kart Bilgileri:");
        Console.WriteLine("**************************************");
        Console.WriteLine("Baslik : "+ secilenKart.Baslik);
        Console.WriteLine("Icerik : "+ secilenKart.Icerik);
        Console.WriteLine("Atanan Kisi : "+ takimUyeleri[secilenKart.AtananKisi]);
        Console.WriteLine("Buyukluk : "+secilenKart.Buyukluk);
        Console.WriteLine("Line : "+ board.FirstOrDefault(x=> x.Value.Contains(secilenKart)).Key);

        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
        Console.WriteLine("(1) TODO");
        Console.WriteLine("(2) IN PROGRESS");
        Console.WriteLine("(3) DONE");

        int lineSecim;
        if (int.TryParse(Console.ReadLine(),out lineSecim)&& lineSecim >=1 && lineSecim<=3)
        {
            var mevcutLine =board.FirstOrDefault(x=> x.Value.Contains(secilenKart)).Key;
            var hedefLine = board.ElementAt(lineSecim-1).Key;
            board[mevcutLine].Remove(secilenKart);
            board[hedefLine].Add(secilenKart); // Tasimada sil ve ekle yapariz
            Console.Write("Kart basariyla tasindi!");
        }
        else{
            Console.WriteLine("Hatalı bir seçim yaptınız!");
        }
    }
}
class Program
{
    public static void Main(string[] args)
    {
        var uygulama = new ToDoUygulamasi();
        uygulama.Baslat();
    }
}

