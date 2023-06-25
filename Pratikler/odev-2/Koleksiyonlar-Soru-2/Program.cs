using System;
namespace Koleksiyonlar_Soru_2;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[20];

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write("Bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                sayilar[i] = sayi;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Bir sayı girin.");
                i--;
            }
        }

        Array.Sort(sayilar);
        int[] enKucukUc = new int[3];
        int[] enBuyukUc = new int[3];

        Array.Copy(sayilar, enKucukUc, 3);
        Array.Copy(sayilar, sayilar.Length - 3, enBuyukUc, 0, 3);

        double enKucukUcOrtalama = OrtalamaHesapla(enKucukUc);
        double enBuyukUcOrtalama = OrtalamaHesapla(enBuyukUc);
        double toplamOrtalama = (enKucukUcOrtalama + enBuyukUcOrtalama) / 2;

        Console.WriteLine("En küçük 3 sayı: ");
        foreach (int sayi in enKucukUc)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine("\nEn büyük 3 sayı: ");
        foreach (int sayi in enBuyukUc)
        {
            Console.Write(sayi + " ");
        }

        Console.WriteLine("\nEn küçük 3 sayıların ortalaması: " + enKucukUcOrtalama);
        Console.WriteLine("En büyük 3 sayıların ortalaması: " + enBuyukUcOrtalama);
        Console.WriteLine("Toplam ortalama: " + toplamOrtalama);
    }

    static double OrtalamaHesapla(int[] dizi)
    {
        double toplam = 0;
        foreach (int sayi in dizi)
        {
            toplam += sayi;
        }
        return toplam / dizi.Length;
    }
}
