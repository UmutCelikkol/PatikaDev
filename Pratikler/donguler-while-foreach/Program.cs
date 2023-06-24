
using System;
namespace donguler_while_foreach;

class Program
{
    static void Main(string[] args)
    {
        //While
        // 1 den baslayarak console"dan girilen sayiya kadar (sayi dahil) ortalama hesaplayip console'a yazdiralim.
        Console.WriteLine("Lutfen bir sayi giriniz!");
        int sayi = int.Parse(Console.ReadLine());
        int sayac=1;
        int toplam =0;
        while (sayac<=sayi)
        {
            toplam +=sayac;
            sayac++;
        }
        Console.WriteLine(toplam/sayi);

        // a'dan z'ye kadar tum harfleri console'a yazdir
        char chr = 'a';
        while (chr<='z')
        {
            Console.WriteLine(chr);
            chr++;
        }
        Console.WriteLine("******** Foreach **********");
        string[] arabalar = {"Ford", "BMV", "Nissan", "Mercedes"};
        foreach (var item in arabalar)
        {
            Console.WriteLine(item);
        }
    }
}
