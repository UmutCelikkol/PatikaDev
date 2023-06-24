using System;
namespace odev_1;

class Program
{
    static void Main(string[] args)
    {
        #region Cevap 1 
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        
        Console.WriteLine("Pozitif bir sayi girin: ");
        int num = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{num} tane pozitif bir sayi girin: ");
        for (int i = 0; i < num; i++)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi%2 == 0)
            {
                Console.WriteLine(sayi);
            }
        }
        #endregion
        #region Cevap 2
        // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tabölünenleri console'a yazdırın.

        Console.Write("Pozitif bir sayi girin (sayi1): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Pozitif bir sayi girin (sayi2): ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine($"{n} tane pozitif sayi giriniz: ");
        for (int i = 0; i < n; i++)
        {
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == m || sayi%m == 0 )
            {
                Console.WriteLine(sayi);
            }
        }
        #endregion
        #region Cevap 3
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyi(n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcınıgirişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        
        Console.WriteLine("Pozitif bir sayi girin: ");
        int number = int.Parse(Console.ReadLine());

        string[] kelimeler = new string[number];
        Console.WriteLine($"{number} tane kelime yaziniz: ");
        for (int i = 0; i < number; i++)
        {
            kelimeler[i] = Console.ReadLine();
        }

        Console.WriteLine("Girdiginiz kelimeler sondan basa dogru asagidaki gibidir: ");
        for (int i = number-1; i >= 0; i--)
        {
            Console.WriteLine(kelimeler[i]);
        }
        #endregion
        #region Cevap 4
        // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        Console.WriteLine("Bir cumle yaziniz: ");
        string cumle = Console.ReadLine();
        string[] kelime = cumle.Split(" ");
        int kelimeSayisi = kelime.Length;
        int harfSayisi = cumle.Length;
        Console.WriteLine($"Toplam kelime sayısı: {kelimeSayisi}");
        Console.WriteLine($"Toplam harf sayısı: {harfSayisi}");
        #endregion
    }
}
