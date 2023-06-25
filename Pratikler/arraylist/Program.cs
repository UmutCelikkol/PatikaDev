using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist;

class Program
{
    static void Main(string[] args)
    {
        //ArrayList
        //System.Collections namespace altindadir.

        ArrayList liste = new ArrayList();
        liste.Add("Ayse");
        liste.Add(2);
        liste.Add(true);
        liste.Add('A');

        //Icerisindekilere erisim
        Console.WriteLine(liste[1]);
        foreach (var item in liste)
        {
            Console.WriteLine(item);
        }

        //AddRange
        Console.WriteLine("******************* Add Range ******************");

        string[] renkler = {"kirmizi", "sari", "yesil"};
        List<int> sayilar = new List<int>(){1,3,8,3,7,9,92,5};
        liste.AddRange(renkler);
        liste.AddRange(sayilar);
        foreach (var item in liste)
        {
            Console.WriteLine(item);    
        }
        //Sort
        Console.WriteLine("******************* Sort ******************");
        liste.Sort(); //hata verir cunku string ve int"leri compare edemediginde RunTime"da hata verir
        //Binary Search
        Console.WriteLine("******************* Binary Search ******************");
        liste.BinarySearch(9);//9"un indeksini getirir
        // Reverse
        Console.WriteLine("******************* Reverse ******************");
        liste.Reverse();
        foreach (var item in liste)
        {
            Console.WriteLine(item);    
        }
        // Clear
         Console.WriteLine("******************* Clear ******************");
        liste.Clear();
        foreach (var item in liste)
        {
            Console.WriteLine(item);    
        }
    }
}
