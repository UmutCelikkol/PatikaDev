using System;

namespace Ortalama_Hesaplama;

// Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fibonacci serisi icin derinlik degerini giriniz;");
        int derinlik = Convert.ToInt32(Console.ReadLine());
        double ortalama = Fibonacci.OrtalamaHesapla(derinlik);
        Console.WriteLine($"Fibonacci serisi rakamlarinin ortalamasi: {ortalama}");
        Console.ReadLine();
    }
}

static class Fibonacci 
{
    public static double OrtalamaHesapla(int derinlik){
        // Serinin ilk iki rakami otomatikman 1 ve 0'dir.
        int fib1 =0;
        int fib2 =1;
        int toplam = fib1 + fib2;
        //Serinin geri kalan rakamlarini girilen derinlige gore hesapla ve toplami guncelle:
        for (int i = 2; i < derinlik; i++)
        {
            int fib3 = fib1 + fib2;
            toplam += fib3;
            fib1 = fib2;
            fib2 = fib3;
        }

        // Ortalamayi hesapla:
        double ortalama = (double)toplam / derinlik;
        return ortalama;
    } 
}

