using System;
// Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.

namespace Karakter_Tersten_Yazdirma;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir metin girin:");
        string input = Console.ReadLine();

        string output = KarakterDegistir(input);
        Console.WriteLine("Sonuç: " + output);

        Console.ReadLine();
    }

    static string KarakterDegistir(string input)
    {
        char[] characters = input.ToCharArray(); // girilen string'i char karakterlere ayirdik

        for (int i = 1; i < characters.Length; i++)
        {
            char temp = characters[i - 1];
            characters[i - 1] = characters[i];
            characters[i] = temp;
        }

        return new string(characters);
    }
}
