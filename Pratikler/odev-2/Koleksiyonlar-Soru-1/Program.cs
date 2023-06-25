using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1;

class Program
{
   static void Main(string[] args)
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        int girilenSayi = 0;
        int asalSayac = 0;
        int asalOlmayanSayac = 0;

        while (girilenSayi < 20)
        {
            Console.Write("Bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                if (sayi > 0)
                {
                    bool asal = true;
                    for (int i = 2; i <= Math.Sqrt(sayi); i++)
                    {
                        if (sayi % i == 0)
                        {
                            asal = false;
                            break;
                        }
                    }
                    if (asal)
                    {
                        asalSayilar.Add(sayi);
                        asalSayac++;
                    }
                    else
                    {
                        asalOlmayanSayilar.Add(sayi);
                        asalOlmayanSayac++;
                    }
                    girilenSayi++;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Bir sayı girin.");
            }
        }

        asalSayilar.Sort();
        asalSayilar.Reverse();
        asalOlmayanSayilar.Sort();
        asalOlmayanSayilar.Reverse();

        Console.WriteLine("Asal sayılar: ");
        foreach (int asalSayi in asalSayilar)
        {
            Console.Write(asalSayi + " ");
        }

        Console.WriteLine("\nAsal olmayan sayılar: ");
        foreach (int asalOlmayanSayi in asalOlmayanSayilar)
        {
            Console.Write(asalOlmayanSayi + " ");
        }

        Console.WriteLine("\nAsal sayıların sayısı: " + asalSayac);
        Console.WriteLine("Asal olmayan sayıların sayısı: " + asalOlmayanSayac);

        double asalOrtalama = asalSayilar.Count > 0 ? OrtalamaHesapla(asalSayilar) : 0;
        double asalOlmayanOrtalama = asalOlmayanSayilar.Count > 0 ? OrtalamaHesapla(asalOlmayanSayilar) : 0;

        Console.WriteLine("Asal sayıların ortalaması: " + asalOrtalama);
        Console.WriteLine("Asal olmayan sayıların ortalaması: " + asalOlmayanOrtalama);
    }

    static double OrtalamaHesapla(ArrayList liste)
    {
        double toplam = 0;
        foreach (int sayi in liste)
        {
            toplam += sayi;
        }
        return toplam / liste.Count;
    }
}
