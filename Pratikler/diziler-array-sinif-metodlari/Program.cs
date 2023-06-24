using System;
namespace diziler_array_sinif_metodlari;

class Program
{
    static void Main(string[] args)
    {
       int[] sayiDizisi = {23,12,4,86,72,3,11,17};
       //Sort Metodu
       Console.WriteLine("****** Sirasiz Dizi ******");
       foreach (var sayi in sayiDizisi)
       {
           Console.WriteLine(sayi);
       }
       Console.WriteLine("****** Sirali Dizi ******");
       Array.Sort(sayiDizisi);
       foreach (var sayi in sayiDizisi)
       {
           Console.WriteLine(sayi);
       }
       //Clear Metodu
        Console.WriteLine("****** Array Clear ******");
        Array.Clear(sayiDizisi,2,2); // 2.indexten baslayarak 2 elemani sifirlar.
        foreach (var sayi in sayiDizisi)
        {
           Console.WriteLine(sayi);
        }
        //Reverse Metodu
        Console.WriteLine("****** Array Reverse ******");
        Array.Reverse(sayiDizisi); 
        foreach (var sayi in sayiDizisi)
        {
           Console.WriteLine(sayi);
        }
        //IndexOf Metodu
        Console.WriteLine("****** Array IndexOf ******");
        //23 sayisin indexi kactiri getirir. 
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));
        //Resize Metodu
        Console.WriteLine("****** Array Resize ******");
        Array.Resize<int>(ref sayiDizisi, 9); // Eleman sayisini 9 yap demektir.
        sayiDizisi[8] = 99; 
        foreach (var sayi in sayiDizisi)
        {
           Console.WriteLine(sayi);
        }
        
    }
}
