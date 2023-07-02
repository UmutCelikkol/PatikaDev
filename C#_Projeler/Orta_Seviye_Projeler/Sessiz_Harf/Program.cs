using System;
//Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

namespace Sessiz_Harf;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz: ");
        string input = Console.ReadLine();
        while (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Metin girmediniz. Lütfen tekrar deneyiniz: ");
            input = Console.ReadLine();
        }
        Console.WriteLine("Sonuclar: ");
        string[] kelimeler= input.Split(" ");
        foreach (string kelime in kelimeler)
        {
            bool sonuc = SessizHarfKontrol(kelime);
            Console.WriteLine(sonuc+" ");
         
        }
         
    }
    static bool SessizHarfKontrol(string kelime)
    {
        string sessizHarfler = "bcdfghjklmnpqrstvwxyz";
        
        for (int i = 0; i < kelime.Length - 1; i++)
        {
            char harf1 = Char.ToLower(kelime[i]);
            char harf2 = Char.ToLower(kelime[i + 1]);

            if (sessizHarfler.Contains(harf1) && sessizHarfler.Contains(harf2))
            {
                return true;
            }
        }

        return false;
    }

}
