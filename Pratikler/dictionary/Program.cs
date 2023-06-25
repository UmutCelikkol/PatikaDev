using System;
using System.Collections.Generic;

namespace dictionary;

class Program
{
    static void Main(string[] args)
    {
        //Dictionary
        //System.Collection.Generic

        Dictionary<int,string> kullanicilar =new Dictionary<int, string>();

        kullanicilar.Add(10,"Umut Celikkol");
        kullanicilar.Add(12,"Ahmet Yilmaz");
        kullanicilar.Add(18, "Ozcan Cosar");
        kullanicilar.Add(20,"Deniz Arda");

        //Dictionary elemanlara erisim
        Console.WriteLine("************* Elemanlara Erisim *****************");
        Console.WriteLine(kullanicilar[12]); 
        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        //Count
        Console.WriteLine(kullanicilar.Count);

        //Contains
        Console.WriteLine(kullanicilar.ContainsKey(12)); //12 key"i olan var mi diye bool doner
         Console.WriteLine(kullanicilar.ContainsValue("Umut Arda")); //value"su Umut Arda olan var mi diye bool doner

         //Remove
         kullanicilar.Remove(12); //key"i 12 olan degeri siler.

        //Keys
        foreach (var item in kullanicilar.Keys)
        {
            Console.WriteLine(item);
        }
        //Values
        foreach (var item in kullanicilar.Values)
        {
            Console.WriteLine(item);
        }
    }
}
