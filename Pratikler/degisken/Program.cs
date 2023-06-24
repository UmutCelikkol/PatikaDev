using System;

namespace degisken;

class Program
{
    static void Main(string[] args)
    {
        byte b = 5;  // 1 byte
        sbyte s = 5; // 1 byte

        short sh = 5; // 2 byte
        ushort us = 5; // 2 byte 
        
        Int16 i16 = 2; // 2 byte
        int i = 2 ;  //4 byte
        Int32 i32 =2; //4 byte
        Int64 i64 = 2; // 8 byte

        uint ui = 2; //4 byte
        long l = 4; //8 byte
        ulong ul = 4; // 8 byte u- unsigned - değer alamazlar.

        // Reel Sayılar
        //decimal veri tipi double ve floata göre bellekte daha çok yer kaplar, double veri tipi decimalden az floattan fazla yer kaplar, float veri tipi ise decimal ve double veri tiplerinden daha az yer kaplar.
        float f = 6.4f; // 4 byte
        double d = 5.4;  // 8 byte
        decimal dec =5;  // 16 byte

        char ch = '2';  // 2 byte
        string str = "Umut";  // sınırsız, yazdığın karakter kadar yer tutar
        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        //Object kendinden türeyen bütün türleri object veri tipine atayabiliriz.
        object o1 = "x";
        object o2 = "yemek";
        object o3 = 4;
        object o4 = 4.3;

        string strl = string.Empty;
        strl = "Umut Çelikkol";

        //boolean
        bool bool1 = 10>1;

        // Degisken donusumleri
        string str20 = "20";
        int int20 = 20;
        string yeniDeger =str20 + int20.ToString();

        int int21 = int20 + Convert.ToInt32(str20);
        int int22 = int20 + int.Parse(str20); // string donusumlerinde Parse kullanilir

        string datetime= DateTime.Now.ToString("dd.MM.yyyy"); // sadece gun ay yildiz getir diyoruz.
        string datetime2= DateTime.Now.ToString("dd/MM/yyyy"); 
        string datetime3= DateTime.Now.ToString("HH:mm");

        Console.WriteLine(datetime+" "+datetime2+" "+datetime3);



    }
}