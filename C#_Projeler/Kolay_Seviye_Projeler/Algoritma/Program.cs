using System;

//Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulamasını yazınız.

namespace Algoritma;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Bir string ifade ve bir sayı girin (aralarına virgül koyunuz):");
        string input = Console.ReadLine();

        // Girdiyi virgül karakterine göre bölerek string ifadeyi ve indisi ayiririz.
        string[] parts = input.Split(',');

        if (parts.Length != 2)
        {
            Console.WriteLine("Hatalı giriş! Lütfen doğru formatta girin.");
            return;
        }

        string str = parts[0].Trim();
        int index;
        //Eger index sayisi int'ye donusuyorsa index'e atariz degilse error mesaji cikar.
        if (!int.TryParse(parts[1], out index))
        {
            Console.WriteLine("Hatalı giriş! Lütfen doğru formatta bir sayı giriniz.");
            return;
        }
        // index negatif bir sayi veya string'in karakter uzunlugundan buyuk bir sayi ise error mesaji gondeririz.
        if (index < 0 || index >= str.Length)
        {
            Console.WriteLine("Hatalı giriş! İndex, string ifadenin sınırları dışındadir.");
            return;
        }

        // İndexteki karakteri cikarip ekrana yazdiririz.
        string result = str.Remove(index, 1);
        Console.WriteLine("Sonuç: " + result);
    }
}
