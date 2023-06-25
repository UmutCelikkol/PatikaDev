using System;
namespace hazir_metotlar_string;

class Program
{
    static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hosgeldiniz";
        string degisken2 = "Dersimiz CSharp";

        //Length
        Console.WriteLine(degisken.Length); //Karakter uzunlugunu verir

        //ToUpper, ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(String.Concat(degisken, "Merhaba! "));// Sonuna ekler

        //Compare, CompareTo
        Console.WriteLine(String.Compare(degisken,degisken2,true));
        Console.WriteLine(String.Compare(degisken,degisken2,false));
        Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1 ve -1 dondurur. degisken, degisken2 ye esitse 0 dondurur, buyukse 1, kucukse -1 dondurur.

        //Contains
        Console.WriteLine(degisken.Contains(degisken2)); //icinde mi diye bakar
        Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
        Console.WriteLine(degisken.StartsWith("Hello"));

        //IndexOf
        Console.WriteLine(degisken.IndexOf("CS"));
        Console.WriteLine(degisken.IndexOf("Umut")); //Bulamazsa -1 dondurur.
        Console.WriteLine(degisken.LastIndexOf("i")); // i karakterleri icinde sonuncusunun index numarasini dondurur

        //Insert
        Console.WriteLine(degisken.Insert(0, "Merhaba! ")); // 0.ci indeksten itibaren ekle demek

        //Padleft, Padright
        Console.WriteLine(degisken+degisken2.PadLeft(30)); // degisken2'nin soluna degisken2 karakter sayisini 30'a tamamlayacak kadar karakter ekler
        Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); // degisken2'nin soluna degiskeni 30'a kadar tamamlayacak kadar * ekler
        Console.WriteLine(degisken.PadRight(50)+degisken2);// degisken'in sagina degiskenin karakterini 50'ye tamamlayacak kadar bosluk ekler.
        Console.WriteLine(degisken.PadRight(50,'-')+degisken2); // degisken'in sagina degiskenin karakterini 50'ye tamamlayacak kadar - ekler.
        //Remove
        Console.WriteLine(degisken.Remove(10)); // 10.cu indeksten baslayarak sonuna kadar siler.
        Console.WriteLine(degisken.Remove(5,3)); // 5.inci indeksten baslayarak 3 karakter siler.
        Console.WriteLine(degisken.Remove(0,1)); // 0.inci indeksten baslayarak 1 karakter siler.

        //Replace
        Console.WriteLine(degisken.Replace("CSharp","C"));
        Console.WriteLine(degisken.Replace(" ","*")); // bosluklari yildiz ile degistirir.

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);

        //Substring
        Console.WriteLine(degisken.Substring(4)); // 4. indeksten baslayarak tum degiskeni getirir
        Console.WriteLine(degisken.Substring(4,6));//4.indeksten baslayarak 6 karakter getirir

    }
}
