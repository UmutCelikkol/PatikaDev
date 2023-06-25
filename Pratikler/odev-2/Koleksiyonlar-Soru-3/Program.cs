using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3;

class Program
{
    static void Main(string[] args)
    {
   
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        List<char> sesliHarfler = new List<char>();

        foreach (char karakter in cumle)
        {
            if (Char.IsLetter(karakter) && SesliHarfMi(karakter))
            {
                sesliHarfler.Add(Char.ToLower(karakter));
            }
        }

        sesliHarfler.Sort();

        Console.WriteLine("Sesli harfler:");
        foreach (char harf in sesliHarfler)
        {
            Console.WriteLine(harf);
        }
    }

    static bool SesliHarfMi(char harf)
    {
        harf = Char.ToLower(harf);
        return harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü'; // sesli harf mi kontrol ederek bool dondur
    }
}
