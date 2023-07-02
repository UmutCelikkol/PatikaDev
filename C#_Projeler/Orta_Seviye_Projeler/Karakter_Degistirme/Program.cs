using System;
// Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

namespace Karakter_Degistirme;

class Program
{
    static void Main(string[] args)
    {
        do
        {
         
         Console.WriteLine("Bir metin giriniz: ");
         string input= Console.ReadLine();
         if (input.Length>=2)
         {
            char ilkKarakter = input[0]; //ilk harf
            char sonKarakter = input[input.Length-1]; //son harf
            char[] dizi = input.ToCharArray();
            dizi[0] = sonKarakter;
            dizi[input.Length-1] = ilkKarakter;

            string output = new string(dizi);
            Console.WriteLine("Sonuc: "+ output);
            break;

         }
         else{
            Console.WriteLine("Girdiginiz metin en az 2 karakterden olusmalidir. Tekrar deneyiniz.");
         }
         Console.ReadLine();
        } while (true);
    }
}
