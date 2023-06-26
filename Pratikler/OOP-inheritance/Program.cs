using System;

namespace OOP_inheritance;

class Program
{
    static void Main(string[] args)
    {
       // OOP-INHERITANCE

       //Canlilar-Hayvanlar-Bitkiler

       TohumluBitkiler tohumluBitki =new TohumluBitkiler();
       tohumluBitki.TohumlaCogalma();

       Console.WriteLine("***************");

       Kuslar marti =new Kuslar();
       marti.Ucmak();
    }
}
